using System;
using System.IO;
using System.IO.Pipes;

namespace client
{
    class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client");


            var client = new NamedPipeClientStream("PodatkiFERI");
            client.Connect();
            Console.WriteLine("Povezan s strežnikom.");

            StreamReader reader = new StreamReader(client);
            StreamWriter writer = new StreamWriter(client);

            Console.WriteLine("Pozdravljeni v oddaljenem kalkulatorju");
            while (true)
            {
                Console.WriteLine(reader.ReadLine());
                string operacija = Console.ReadLine();
                if (operacija == "") break;
                writer.WriteLine(operacija);
                writer.Flush();

            }



        }
    }
}
