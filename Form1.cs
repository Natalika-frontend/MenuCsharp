using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        class FioCompareAsc : IComparer<Student>
        {
            public int Compare(Student o1, Student o2)
            {
                if (string.Compare(o1.Fio, o2.Fio) > 0) return 1;
                else if (string.Compare(o1.Fio, o2.Fio) < 0) return -1;
                return 0;
            }
        }

        int find_Room(int p_nk, List<Room> m)
        {
            int vz = -1;
            for (int i = 0; i < m.Count; i++)
            {
                if (m[i].Nomer == p_nk)
                {
                    vz = i; break;
                }
            }
            return vz;
        }

        int find_Stud(string p_nzk, List<Student> m)
        {
            int vz = -1;
            for (int i = 0; i < m.Count; i++)
            {
                if (m[i].Nzk == p_nzk)
                {
                    vz = i; break;
                }
            }
            return vz;
        }

        string padr(string p, int len, string s)
        {
            string vz = "";
            if (p != null)
            {
                if (p.Length >= len)
                {
                    vz = p.Substring(0, len);
                }
                else
                {
                    vz = p;
                    while (vz.Length < len)
                    {
                        vz += s;
                    }
                }
            }
            return vz;
        }

        private void refreshRoom()
        {
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
        }

        private void refreshStud()
        {
            FioCompareAsc v2 = new FioCompareAsc();
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
                if (fl == 0)
                {
                    p_name = s.Substring(0, 20);
                    p_adr = s.Substring(20, 30);
                    p_Max_kol = Convert.ToInt16(s.Substring(50));
                    fl = 1;
                }
                else
                {
                    p_nk = Convert.ToInt16(s.Substring(0, 3));
                    p_max = Convert.ToInt16(s.Substring(4, 2));
                    p_nzk = s.Substring(7, 7);
                    p_fio = s.Substring(15, 30);
                    p_pol = s.Substring(46, 1);
                    p_kurs = Convert.ToInt16(s.Substring(48, 1));
                    p_spec = s.Substring(50);

                    Student o = new Student(p_nzk, p_fio, p_pol, p_kurs, p_spec, p_nk);
                    MStudent.Add(o);


                    int ind_room = find_Room(p_nk, MRoom);
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

            refreshRoom();
            refreshStud();

            textBox1.Text = p_name;
            textBox2.Text = p_adr;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != null && textBox7.Text != null && textBox7.Text != "")
            {
                int p_nk, p_max;
                p_nk = Convert.ToInt16(textBox6.Text);
                p_max = Convert.ToInt16(textBox7.Text);
                if (p_nk > 0 && p_max > 0 && p_max < 41)
                {
                    if (find_Room(p_nk, MRoom) < 0)
                    {
                        Room o = new Room(p_nk, p_max);
                        MRoom.Add(o);
                        refreshRoom();
                        textBox6.Text = "";
                        textBox7.Text = "";
                    }

                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != null && (textBox7.Text == null || textBox7.Text == ""))
            {
                int p_nk;
                p_nk = Convert.ToUInt16(textBox6.Text);
                int ind_nom = find_Room(p_nk, MRoom);
                if (ind_nom > 0)
                {
                    if (MRoom[ind_nom].T == 0)
                    {
                        MRoom.RemoveAt(ind_nom);
                        refreshRoom();
                        textBox6.Text = "";
                    }
                }
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_MouseEnter(object sender, EventArgs e)
        {
            if (comboBox2.Text != null)
            {
                string p_pol = comboBox2.Text;
                comboBox7.Items.Clear();
                List<Room> m1 = new List<Room>();
                for (int i = 0; i < MRoom.Count; i++)
                {
                    if (MRoom[i].T < MRoom[i].Nmax)
                    {
                        if (MRoom[i].T == 0)
                        {
                            m1.Add(MRoom[i]);
                        }
                        else
                        {
                            for (int j = 0; j < MStudent.Count; j++)
                            {
                                if (MStudent[j].N_room == MRoom[i].Nomer)
                                {
                                    if (MStudent[j].Pol == p_pol)
                                    {
                                        if (find_Room(MStudent[j].N_room, m1) < 0)
                                        {
                                            m1.Add(MRoom[i]);
                                        }

                                    }
                                }
                            }
                        }
                    }

                }
                if (m1.Count > 0)
                {
                    for (int i = 0; i < m1.Count; i++)
                    {
                        comboBox7.Items.Add(m1[i].Nomer);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != null && textBox3.Text != "" && textBox4.Text != null && textBox4.Text != "" && textBox5.Text != null && textBox5.Text != "" && comboBox2.Text != null && comboBox2.Text != "" && comboBox3.Text != null && comboBox3.Text != "" && comboBox7.Text != null && comboBox7.Text != "")
            {
                int n_room, p_kurs, ind_S = -1;
                string p_nzk, p_fio, p_pol, p_spec;
                p_nzk = padr(textBox3.Text, 7, " ");
                p_fio = padr(textBox4.Text, 30, " ");
                p_spec = textBox5.Text;
                n_room = Convert.ToInt16(comboBox7.Text);
                p_pol = comboBox7.Text;
                p_kurs = Convert.ToInt16(comboBox3.Text);
                ind_S = find_Stud(p_nzk, MStudent);
                if (ind_S < 0)
                {
                    Student o = new Student(p_nzk, p_fio, p_pol, p_kurs, p_spec, n_room);
                    MStudent.Add(o);
                    refreshStud();
                    int ind_nom = find_Room(n_room, MRoom);
                    MRoom[ind_nom].incT();
                    refreshRoom();
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    comboBox7.Text = "";
                    comboBox7.Items.Clear();
                }
                else
                {
                    MStudent[ind_S].Fio = textBox4.Text;
                    MStudent[ind_S].Spec = textBox5.Text;
                    //MStudent[ind_S].N_room = Convert.ToInt16(comboBox7.Text);
                    //MStudent[ind_S].Pol = comboBox2.Text;
                    MStudent[ind_S].Kurs = Convert.ToInt16(comboBox3.Text);
                    refreshStud();
                    if (MStudent[ind_S].N_room != Convert.ToInt16(comboBox7.Text))
                    {
                        MessageBox.Show("Изменить номер комнаты в режиме корректировки данных невозможно!", "Внимание!!!");
                    }
                    if (MStudent[ind_S].Pol != comboBox2.Text)
                    {
                        MessageBox.Show("Изменить пол студента в режиме корректировки данных невозможно!", "Внимание!!!");
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != null && textBox3.Text != "" && (textBox4.Text == null || textBox4.Text == ""))
            {
                string p_nzk;
                p_nzk = padr(textBox3.Text, 7, " ");
                int ind_nom = find_Stud(p_nzk, MStudent);
                if (ind_nom >= 0)
                {
                    textBox4.Text = MStudent[ind_nom].Fio;
                    comboBox2.Text = MStudent[ind_nom].Pol;
                    comboBox3.Text = MStudent[ind_nom].Kurs.ToString();
                    textBox5.Text = MStudent[ind_nom].Spec;
                    comboBox7.Text = MStudent[ind_nom].N_room.ToString();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != null && textBox3.Text != "")
            {
                string p_nzk;
                p_nzk = padr(textBox3.Text, 7, " ");
                int ind_S = find_Stud(p_nzk, MStudent);
                if (ind_S >= 0)
                {
                    int ind_nom;
                    ind_nom = find_Room(MStudent[ind_S].N_room, MRoom);
                    if (ind_nom >= 0)
                    {
                        MRoom[ind_nom].decT();
                        refreshRoom();
                    }
                    MStudent.RemoveAt(ind_S);
                    refreshStud();
                }
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                textBox5.Text = "";
                comboBox7.Text = "";
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            if (MRoom.Count > 0)
            {
                for (int i = 0; i < MRoom.Count; i++)
                {
                    comboBox1.Items.Add(MRoom[i].Nomer.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (comboBox1.Text != null || comboBox1.Text != "")
            {
                int p_nk = Convert.ToInt16(comboBox1.Text);
                string p_str = ""; int k = 0;
                for (int i = 0; i < MStudent.Count; i++)
                {
                    if (MStudent[i].N_room == p_nk)
                    {
                        p_str = (k + 1).ToString() + ". " + MStudent[i].Nzk + " " + MStudent[i].Fio + " ";
                        p_str += MStudent[i].Pol + "  " + MStudent[i].Kurs.ToString() + "  " + MStudent[i].Spec + " ";
                        listBox1.Items.Add(p_str);
                        k++;
                    }
                }
            }
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            if (MRoom.Count > 0)
            {
                for (int i = 0; i < MRoom.Count; i++)
                {
                    if (MRoom[i].T > 0)
                    {
                        comboBox4.Items.Add(MRoom[i].Nomer.ToString());
                    }
                    
                }
            }
        }
    }
}

