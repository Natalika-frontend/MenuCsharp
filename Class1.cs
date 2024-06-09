using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCsharp
{

    class Room
    {
        private int nomer;
        private int nMax;
        private int t;

        public Room()
        {
            nomer = 0; nMax = 4; t = 0;
        }

        public Room(int p_nom, int p_max)
        {
            nomer = p_nom;
            if (p_max > 0 && p_max < 41) nMax = p_max; else nMax = 4;
            t = 0;
        }
        public Room(int p_nom, int p_max, int tek)
        {
            nomer = p_nom;
            if (p_max > 0 && p_max < 41) nMax = p_max; else nMax = 4;
            if (tek > 0 && tek <= nMax) t = tek; else t = 0;
        }

        public Room(Room o)
        {
            nomer = o.nomer; nMax = o.nMax; t = o.t;
        }

        public int Nomer
        {
            get { return nomer; }
            set { nomer = value; }
        }

        public int Nmax
        {
            get { return nMax; }
            set { nMax = value; }
        }

        public int T
        {
            get { return t; }
        }

        public void incT() { t++; }
    }

    class Student
    {
        private string nzk;
        private string fio;
        private string pol;
        private int kurs;
        private string spec;
        private int n_room;

        public Student() {
            nzk = ""; fio = ""; pol = ""; kurs = 0; spec = ""; n_room = 0;
        }

        public Student(string p1, string p2, string p3, int p4, string p5, int p6)
        {
            nzk = p1; fio = p2;
            if (p3 == "m" || p3 == "w") pol = p3; else pol = "";
            if (p4 > 0 && p4 < 7) kurs = p4; else kurs = 0;
            spec = p5;
            if (p6 > 0) n_room = p6; else n_room = 0;
        }

        public Student(Student o)
        {
            nzk = o.nzk; fio = o.fio; pol = o.pol; kurs = o.kurs; spec = o.spec; n_room = o.n_room;
        }

        public string Nzk
        {
            get { return nzk; }
            set { nzk = value; }
        }
        
        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }

        public string Pol
        {
            get { return pol; }
            set { if (value == "m" || value == "w") pol = value; }
        }

        public int Kurs
        {
            get { return kurs; }
            set { if (value > 0 && value < 7) kurs = value; }
        }

        public string Spec
        {
            get { return spec; }
            set { spec = value; }
        }

        public int N_room
        {
            get { return n_room; }
            set { n_room = value; }
        }
    }

    internal class Class1
    {
    }
}
