using System;
using System.IO;
using System.IO.Pipes;

namespace Server
{
    class Operacija
    {
        int rezultat;
        public string tipOperacije;
        public string znakOperacije;
        public int prvo_stevilo;
        public int drugo_stevilo;

        public void NastaviTipOperacije(string operacija)
        {
            if (operacija == "+")
            {
                tipOperacije = "seštevanje";
                znakOperacije = "+";
            }
            if (operacija == "-")
            {
                tipOperacije = "odštevanje";
                znakOperacije = "-";
            }
            if (operacija == "*")
            {
                tipOperacije = "množenje";
                znakOperacije = "*";
            }
            if (operacija == "/")
            {
                tipOperacije = "deljenje";
                znakOperacije = "/";
            }

        }

        public int izracun()
        {
            if (this.znakOperacije == "+")
                rezultat = prvo_stevilo + drugo_stevilo;
            if (this.znakOperacije == "-")
                rezultat = prvo_stevilo - drugo_stevilo;
            if (this.znakOperacije == "*")
                rezultat = prvo_stevilo * drugo_stevilo;
            if (this.znakOperacije == "/")
                rezultat = prvo_stevilo / drugo_stevilo;
            return rezultat;
        }

        public void ponastavi()
        {
            this.rezultat = 0;
            this.tipOperacije = null;
            this.znakOperacije = null;
            this.prvo_stevilo = 0;
            this.drugo_stevilo = 0;

        }


    }
    class server
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Server");

            var server = new NamedPipeServerStream("PodatkiFERI");
            Console.WriteLine("Strežnik je pripravljen");
            server.WaitForConnection();
            Console.WriteLine("Strežnik je povezan");
            StreamReader reader = new StreamReader(server);
            StreamWriter writer = new StreamWriter(server);

            writer.WriteLine("Vnesit,e željeno operacijo (+,-,*,/)");
            writer.Flush();
            string operacija = reader.ReadLine();
            while (operacija != "+" && operacija != "-" && operacija != "*" && operacija != "/")
            {
                writer.WriteLine("Napačna operacija, vnesite operacijo ponovno");
                writer.Flush();
                operacija = reader.ReadLine();
            }
            if (operacija == "+" || operacija == "-" || operacija == "*" || operacija == "/")
            {
                Operacija op = new Operacija();
                op.NastaviTipOperacije(operacija);
                writer.WriteLine("Izbrali ste operacijo " + op.tipOperacije + ". Izberite 1. število");
                writer.Flush();
                string prvoString = reader.ReadLine();
                int prvo;
                bool isNumeric = int.TryParse(prvoString, out prvo);
                while (isNumeric == false)
                {
                    writer.WriteLine("Nepravilno število, vnesite število ponovno");
                    writer.Flush();
                    prvoString = reader.ReadLine();
                    isNumeric = int.TryParse(prvoString, out prvo);
                }
                if (isNumeric)
                {
                    op.prvo_stevilo = prvo;
                    writer.WriteLine("Izbrali ste število {0} Izberite 2. število", prvo);
                    writer.Flush();
                    string drugoString = reader.ReadLine();
                    int drugo;
                    bool isnumeric2 = int.TryParse(drugoString, out drugo);
                    while (isnumeric2 == false)
                    {
                        writer.WriteLine("Nepravilno število, vnesite število ponovno");
                        writer.Flush();
                        drugoString = reader.ReadLine();
                        isnumeric2 = int.TryParse(drugoString, out drugo);
                    }
                    while (op.znakOperacije == "/" && drugoString == "0")
                    {
                        writer.WriteLine("Prepovedano deljenje z 0 ponovnno vpiši drugo število");
                        writer.Flush();
                        drugoString = reader.ReadLine();
                        isnumeric2 = int.TryParse(drugoString, out drugo);
                    }
                    op.drugo_stevilo = drugo;
                    if (isnumeric2)
                    {
                        writer.WriteLine("Izbrali ste stevilo {0}  REZULTAT seštevanja: {1} za konec pritisnite ENTER", drugo, op.izracun());
                        writer.Flush();
                        server.Disconnect();
                        op.ponastavi();

                    }
                }


            }


        }
    }
}
