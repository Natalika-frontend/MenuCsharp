namespace MenuCsharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            listBox1 = new ListBox();
            label6 = new Label();
            panel1 = new Panel();
            comboBox7 = new ComboBox();
            label15 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox5 = new TextBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            button6 = new Button();
            comboBox6 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 8);
            button1.Name = "button1";
            button1.Size = new Size(116, 41);
            button1.TabIndex = 0;
            button1.Text = "Загрузить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(134, 16);
            label1.Name = "label1";
            label1.Size = new Size(234, 25);
            label1.TabIndex = 1;
            label1.Text = "Наименование объекта";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(374, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 33);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(676, 12);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 3;
            label2.Text = "Адрес";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(740, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(477, 29);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(10, 85);
            label3.Name = "label3";
            label3.Size = new Size(118, 21);
            label3.TabIndex = 5;
            label3.Text = "Список комнат";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(9, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(206, 446);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "№ ком";
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "Мах. кол-во";
            Column2.Name = "Column2";
            Column2.Width = 60;
            // 
            // Column3
            // 
            Column3.HeaderText = "Тек. кол-во";
            Column3.Name = "Column3";
            Column3.Width = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(250, 85);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 7;
            label4.Text = "Список студентов";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientActiveCaption;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6, Column7, Column8, Column9, Column10 });
            dataGridView2.Location = new Point(250, 108);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.Size = new Size(393, 447);
            dataGridView2.TabIndex = 8;
            // 
            // Column4
            // 
            Column4.HeaderText = "№ п/п";
            Column4.Name = "Column4";
            Column4.Width = 30;
            // 
            // Column5
            // 
            Column5.HeaderText = "№ зач.кн.";
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // Column6
            // 
            Column6.HeaderText = "ФИО";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Пол";
            Column7.Name = "Column7";
            Column7.Width = 40;
            // 
            // Column8
            // 
            Column8.HeaderText = "Курс";
            Column8.Name = "Column8";
            Column8.Width = 40;
            // 
            // Column9
            // 
            Column9.HeaderText = "Спец";
            Column9.Name = "Column9";
            Column9.Width = 50;
            // 
            // Column10
            // 
            Column10.HeaderText = "№ комн";
            Column10.Name = "Column10";
            Column10.Width = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(659, 108);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 9;
            label5.Text = "Выбор";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(709, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(68, 23);
            comboBox1.TabIndex = 10;
            comboBox1.Click += comboBox1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(796, 105);
            button2.Name = "button2";
            button2.Size = new Size(84, 23);
            button2.TabIndex = 11;
            button2.Text = "Применить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(676, 180);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(541, 100);
            listBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(835, 156);
            label6.Name = "label6";
            label6.Size = new Size(208, 21);
            label6.TabIndex = 13;
            label6.Text = "Список жильцов комнаты";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(comboBox7);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(676, 305);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 160);
            panel1.TabIndex = 14;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(81, 125);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(72, 23);
            comboBox7.TabIndex = 14;
            comboBox7.SelectedIndexChanged += comboBox7_SelectedIndexChanged;
            comboBox7.MouseEnter += comboBox7_MouseEnter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 128);
            label15.Name = "label15";
            label15.Size = new Size(54, 15);
            label15.TabIndex = 13;
            label15.Text = "Комната";
            // 
            // button5
            // 
            button5.Location = new Point(381, 92);
            button5.Name = "button5";
            button5.Size = new Size(75, 29);
            button5.TabIndex = 12;
            button5.Text = "Удалить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(381, 55);
            button4.Name = "button4";
            button4.Size = new Size(75, 31);
            button4.TabIndex = 11;
            button4.Text = "Сохранить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(381, 14);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 10;
            button3.Text = "Найти";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(81, 97);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(72, 23);
            textBox5.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6" });
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            comboBox3.Location = new Point(262, 68);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(54, 23);
            comboBox3.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "м", "ж" });
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "м", "ж" });
            comboBox2.Location = new Point(81, 68);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(56, 23);
            comboBox2.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(81, 39);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(167, 23);
            textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(81, 11);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 100);
            label11.Name = "label11";
            label11.Size = new Size(35, 15);
            label11.TabIndex = 4;
            label11.Text = "Спец";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(192, 71);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 3;
            label10.Text = "Курс";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 71);
            label9.Name = "label9";
            label9.Size = new Size(30, 15);
            label9.TabIndex = 2;
            label9.Text = "Пол";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 42);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 1;
            label8.Text = "ФИО";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 14);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 0;
            label7.Text = "№ зач.кн.";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(comboBox6);
            panel2.Controls.Add(comboBox5);
            panel2.Controls.Add(comboBox4);
            panel2.Location = new Point(676, 484);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 71);
            panel2.TabIndex = 15;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(316, 11);
            label14.Name = "label14";
            label14.Size = new Size(32, 15);
            label14.TabIndex = 6;
            label14.Text = "Куда";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(107, 11);
            label13.Name = "label13";
            label13.Size = new Size(33, 15);
            label13.TabIndex = 5;
            label13.Text = "Кого";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 11);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 4;
            label12.Text = "Откуда";
            // 
            // button6
            // 
            button6.Location = new Point(432, 23);
            button6.Name = "button6";
            button6.Size = new Size(85, 33);
            button6.TabIndex = 3;
            button6.Text = "Переселить";
            button6.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(316, 29);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(89, 23);
            comboBox6.TabIndex = 2;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(106, 29);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(203, 23);
            comboBox5.TabIndex = 1;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(11, 29);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(89, 23);
            comboBox4.TabIndex = 0;
            comboBox4.Click += comboBox4_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 579);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(42, 23);
            textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(60, 579);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(55, 23);
            textBox7.TabIndex = 17;
            // 
            // button7
            // 
            button7.Location = new Point(134, 561);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 18;
            button7.Text = "Добавить";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(134, 590);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 19;
            button8.Text = "Удалить";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 637);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Пример программы";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label4;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Label label5;
        private ComboBox comboBox1;
        private Button button2;
        private ListBox listBox1;
        private Label label6;
        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox5;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label11;
        private Label label10;
        private Panel panel2;
        private Label label14;
        private Label label13;
        private Label label12;
        private Button button6;
        private ComboBox comboBox6;
        private ComboBox comboBox5;
        private ComboBox comboBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button7;
        private Button button8;
        private Label label15;
        private ComboBox comboBox7;
    }
}
