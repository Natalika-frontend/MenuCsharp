using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MenuCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Room> MRoom = new List<Room>();
        List<Student> MStudent = new List<Student>();

        string name_f = "F:\\DonNTY\\semestr2\\OOP\\obshaga.txt";
        string p_name = "", p_adr = ""; int p_Max_kol = 0;

        class NomerRoomCompareAsc : IComparer<Room>
        {
            public int Compare(Room o1, Room o2)
            {
                if (o1.Nomer > o2.Nomer) return 1;
                else if (o1.Nomer < o2.Nomer) return -1;
                return 0;
            }
        }

        class FioRoomCompareAsc : IComparer<Student>
        {
            public int Compare(Student o1, Student o2)
            {
                if (string.Compare(o1.Fio, o2.Fio) > 0) return 1;
                else if (string.Compare(o1.Fio, o2.Fio) < 0) return -1;
                return 0;
            }
        }

        int find_Room(int p_nk)
        {
            int vz = -1;
            for (int i = 0; i < MRoom.Count; i++)
            {
                if (MRoom[i].Nomer == p_nk)
                {
                    vz = i; break;
                }
            }
            return vz;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(name_f);

            string s; int fl = 0;
            int p_nk, p_max, p_kurs;
            string p_nzk = "", p_fio = "", p_pol = "", p_spec = "";

            
            while (sr.EndOfStream != true) 
            {
                s = sr.ReadLine();
                if (fl == 0) {
                    p_name = s.Substring(0, 20);
                    p_adr = s.Substring(20, 30);
                    p_Max_kol = Convert.ToInt16(s.Substring(50));
                    fl = 1;
                }
                else {
                    p_nk = Convert.ToInt16(s.Substring(0, 3));
                    p_max = Convert.ToInt16(s.Substring(4, 2));
                    p_nzk = s.Substring(7, 7);
                    p_fio = s.Substring(15, 30);
                    p_pol = s.Substring(46, 1);
                    p_kurs = Convert.ToInt16(s.Substring(48, 1));
                    p_spec = s.Substring(50);

                    Student o = new Student(p_nzk, p_fio, p_pol, p_kurs, p_spec, p_nk);
                    MStudent.Add(o);


                    int ind_room = find_Room(p_nk);
                    if (ind_room < 0)
                    {
                        Room r = new Room(p_nk, p_max, 1);
                        MRoom.Add(r);
                    }
                    else
                    {
                        MRoom[ind_room].incT();
                    }
                }
            }
            sr.Close();

            NomerRoomCompareAsc v1 = new NomerRoomCompareAsc();
            MRoom.Sort(v1);

            dataGridView1.RowCount = MRoom.Count;
            for (int i = 0; i < MRoom.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = MRoom[i].Nomer;
                dataGridView1.Rows[i].Cells[1].Value = MRoom[i].Nmax;
                dataGridView1.Rows[i].Cells[2].Value = MRoom[i].T;
            }
            dataGridView1.Refresh();

            FioRoomCompareAsc v2 = new FioRoomCompareAsc();
            MStudent.Sort(v2);

            dataGridView2.RowCount = MStudent.Count;
            for (int i = 0; i < MStudent.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = (i + 1);
                dataGridView2.Rows[i].Cells[1].Value = MStudent[i].Nzk;
                dataGridView2.Rows[i].Cells[2].Value = MStudent[i].Fio;
                dataGridView2.Rows[i].Cells[3].Value = MStudent[i].Pol;
                dataGridView2.Rows[i].Cells[4].Value = MStudent[i].Kurs;
                dataGridView2.Rows[i].Cells[5].Value = MStudent[i].Spec;
                dataGridView2.Rows[i].Cells[6].Value = MStudent[i].N_room;
            }
            dataGridView2.Refresh();

            textBox1.Text = p_name; 
            textBox2.Text = p_adr;
        }
    }
}
