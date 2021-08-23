using System;
using System.Collections.Generic;

namespace Nal_02
{
    class Program
    {
        public struct Student
        {
            string ime;
            string priimek;
            string vpisnaStevilka;

            public Student(string ime, string priimek, string vpisnaStevilka)
            {
                this.ime = ime;
                this.priimek = priimek;
                this.vpisnaStevilka = vpisnaStevilka;
            }

            public void Izpis()
            {
                Console.WriteLine("Ime: {0}, Priimek: {1}, Vpisna stevilka {2}", ime, priimek, vpisnaStevilka);
            }


            public void Povozi(Student student)
            {
                this.ime = student.ime;
                this.priimek = student.priimek;
                this.vpisnaStevilka = student.vpisnaStevilka;
            }
        }
        public static void Vstavi(LinkedList<Student> ll, int index, Student student)
        {

            Student[] st = new Student[ll.Count];
            int indexPolja = 0;
            foreach (Student a in ll)
            {
                st[indexPolja] = a;
                indexPolja++;
            }

            st[index] = student;
            ll.Clear();

            for (int i = 0; i < st.Length; i++)
            {
                ll.AddLast(st[i]);
            }


        }

        public static void Vstavi_ll(LinkedList<Student> ll, int index, Student student)
        {
            LinkedList<Student> zacetniDel = new LinkedList<Student>();

            int index_a = 0;
            foreach (Student st in ll)
            {
                if (index_a == index) zacetniDel.AddLast(student);
                else zacetniDel.AddLast(st);
                index_a++;
            }
            ll.Clear();
            foreach (Student st in zacetniDel)
            {
                ll.AddLast(st);
            }
            //if (index >= Dolzina_ll(ll)) ll.AddLast(student);

        }

        public static void Vstavi_ll_node(LinkedList<Student> seznam, int index, Student student)
        {
            Student st = new Student();
            LinkedListNode<Student> ll_node = null;
            int index_node = 0;
            for (LinkedListNode<Student> it = seznam.First; it != null; it = it.Next)
            {
                if (index_node == index)
                {
                    seznam.AddBefore(it, student);
                    seznam.Remove(it);
                    break;
                }


                index_node++;
            }
        }


        public static void Vrini_ll(LinkedList<Student> ll, int index, Student student)
        {
            LinkedList<Student> zacetniDel = new LinkedList<Student>();

            int index_a = 0;
            foreach (Student st in ll)
            {
                if (index_a == index) zacetniDel.AddLast(student);
                zacetniDel.AddLast(st);
                index_a++;
            }
            ll.Clear();
            foreach (Student st in zacetniDel)
            {
                ll.AddLast(st);
            }
            if (index >= Dolzina_ll(ll)) ll.AddLast(student);
        }

        public static void Vrini_ll_node(LinkedList<Student> seznam, int index, Student student)
        {
            if (index == seznam.Count) { seznam.AddLast(student); return; }
            int indeks_node = 0;
            for (LinkedListNode<Student> it = seznam.First; it != null; it = it.Next, indeks_node++)
            {
                if (indeks_node == index)
                {
                    seznam.AddBefore(it, student);
                    break;
                }
            }
        }


        public static void Pripravi_ll(LinkedList<Student> ll, int dolzina)
        {
            Student student = new Student();
            for (int i = 0; i < dolzina; i++)
            {
                ll.AddLast(student);
            }
        }

        public static Student Odstrani_ll(LinkedList<Student> seznam, int indeks)
        {
            LinkedList<Student> zacetniDel = new LinkedList<Student>();

            int index_a = 0;
            Student odstranjen = new Student();
            foreach (Student st in seznam)
            {
                if (index_a == indeks) { odstranjen = st; }
                else zacetniDel.AddLast(st);
                index_a++;
            }
            seznam.Clear();
            foreach (Student st in zacetniDel)
            {
                seznam.AddLast(st);
            }
            return odstranjen; // metoda vrača odstranjenega študenta ter prav tako odstrani tega iz lista

        }

        public static Student Odstrani_ll_node(LinkedList<Student> seznam, int indeks)
        {
            Student vrni = new Student();
            int index = 0;
            for (LinkedListNode<Student> it = seznam.First; it != null; it = it.Next, index++)
            {
                if (indeks == index)
                {
                    seznam.Remove(it);
                    vrni = it.Value;
                }
            }
            return vrni;

        }



        public static int Dolzina_ll(LinkedList<Student> ll)
        {
            return ll.Count;
        }

        public static Student Vrni(LinkedList<Student> ll, int index)
        {
            Student vrni = new Student();
            int index_a = 0;
            foreach (Student st in ll)
            {
                if (index_a == index) return st;
                index_a++;
            }

            return vrni;
        }

        private static void JeMožnoVstavitiNaiTemIndexu(LinkedList<Student> ll, int index)
        {

            if (ll.Count < index)
                throw new ArgumentException("Index na katerega bomo vnašali podatke ne sme biti večji od dolžine LinkedList");
        }

        public static void Izpis(LinkedList<Student> ll)
        {
            foreach (var student in ll)
            {
                student.Izpis();
            }

        }


        static void Main(string[] args)
        {
            LinkedList<Student> ll = new LinkedList<Student>();


            Student st1 = new Student("Primož", "Ratej", "E10822244");
            Student st2 = new Student("Jan", "Prah", "E1045244");
            Student st3 = new Student("Niko", "Piko", "E13652244");
            Student st4 = new Student("Jaka", "Spaka", "E10254644");

            Student odstranjen = new Student();


            Student st5 = new Student("Vstavljeni", "Miha", "EEEEEEEEEE");
            Student st6 = new Student("Vrinjeni", "Jože", "AAAAAAAAAA");
            ll.AddLast(st1);
            ll.AddLast(st2);
            ll.AddLast(st3);
            ll.AddLast(st4);

            Izpis(ll);

            Console.WriteLine();
            Vrini_ll_node(ll, 5, st6);
            Console.WriteLine();

            Izpis(ll);

            Console.ReadKey();

        }
    }
}
