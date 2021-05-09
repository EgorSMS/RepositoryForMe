using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_Creator
{
    public partial class FirstApply : Form
    {
        string path = @"C:\Users\negor\OneDrive\Рабочий стол\Курсач\HTML + CSS\HTML.html";

        public FirstApply()
        {
            InitializeComponent();
        }
        int coutinho = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            coutinho++;
            if (coutinho <= 5)
            {
                listBox1.Items.Add(textBox9.Text);
                textBox9.Text = "";
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Мы создаём сайт! Или Вы хотите создать меню ресторана?", "Нельзя добавить больше элементов!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(dialogResult == DialogResult.Yes)
                {
                    Application.Exit();

                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    int change = flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.VerticalScroll.SmallChange * 30;
                    flowLayoutPanel1.AutoScrollPosition = new Point(0, change);
                    break;

                case Keys.Down:
                    int change1 = flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.VerticalScroll.SmallChange * 30;
                    flowLayoutPanel1.AutoScrollPosition = new Point(0, change1);
                    break;

                default: break;
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.JPG; *.PNG; *.BMP)| *.JPG; *.PNG; *.BMP| All files (*.*)| *.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox2.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form1 form1 = Owner as Form1;
            StreamWriter streamwriter = new StreamWriter(@"D:\index.html");
            streamwriter.WriteLine("<html>");
            streamwriter.WriteLine("<head>");
            streamwriter.WriteLine($"<title>{textBox7.Text}</title>");
            streamwriter.WriteLine("<link rel=\"stylesheet\" href= \"C:\\Users\\negor\\OneDrive\\Рабочий стол\\Курсач\\HTML + CSS\\style.css\" >");
            streamwriter.WriteLine("</head>");
            streamwriter.WriteLine("<body>");

            if (form1.checkBox2.Checked == true) // НАВИГАЦИОННОЕ МЕНЮ С ЛОГО ПО ЦЕНТРУ
            {
                if (form1.comboBox2.SelectedIndex == 0)
                {
                    if (textBox12.Text != null && listBox1.Items.Count > 0)
                    {
                        streamwriter.WriteLine("<div class=" + "nav-menu-1" + ">");
                        streamwriter.WriteLine("<ul class=" + "main-menu-1" + ">");
                        streamwriter.WriteLine($"<li><a href=\"11\" > {textBox9.Text}</a></li>");
                        streamwriter.WriteLine($"<li><a href= \"11\" > {listBox1.SelectedItem}</a></li>");
                        streamwriter.WriteLine($"<li><p> {textBox9.Text} </p></li>");
                        streamwriter.WriteLine($"<li><a href= \"11\" > {listBox1.SelectedItem}</a></li>");
                        streamwriter.WriteLine($"<li><a href= \"11\" > {textBox9.Text}</a></li>");
                        streamwriter.WriteLine("</ul>");
                        streamwriter.WriteLine("</div>");
                    }
                    else
                    {
                        MessageBox.Show("Заполните навигационное меню");
                    }
                }
            }

            //if (form1.comboBox1.SelectedIndex == 0) // ОБЛОЖКА
            //{
            //    if(pictureBox3.Image != null && textBox7.Text != null && textBox8.Text != null)
            //    {
            //        streamwriter.WriteLine("<div class=" + "zagolovok1" + ">");
            //        streamwriter.WriteLine($"<h2>{textBox7.Text}</h2>");
            //        streamwriter.WriteLine("<br>");
            //        streamwriter.WriteLine($"<p>{textBox8.Text}</p>");
            //        streamwriter.WriteLine("</div>");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Заполните обложку");
            //    }
            //}
            // if (form1.comboBox1.SelectedIndex == 2) // ОБЛОЖКА
            //{

            //    if (pictureBox3.Image != null && textBox7.Text != null && textBox8.Text != null)
            //    {
            //        streamwriter.WriteLine("<div class=" + "zagolovok2" + ">");
            //        streamwriter.WriteLine($"<p class=\"zag1\">{textBox7.Text}</p>");
            //        streamwriter.WriteLine("<hr class= \"hr1\">");
            //        streamwriter.WriteLine("<br>");
            //        streamwriter.WriteLine($"<p class= \"opisanie\"> {textBox8.Text}");
            //        streamwriter.WriteLine("</p>");
            //        streamwriter.WriteLine("</div>");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Заполните обложку 2");
            //    }
            //}


             

            streamwriter.WriteLine("</body>");
            streamwriter.WriteLine("</html>");
            streamwriter.Close();

            System.Diagnostics.Process.Start(@"D:\index.html");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            form1.ShowDialog();
            
        }
        int valuev = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            valuev++;
            if (valuev <= 3)
            {
                listBox2.Items.Add(textBox4.Text);
                textBox4.Text = "";
            }
            else
            {
                MessageBox.Show("Нельзя добавить больше элементов", "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int count = 0;
        private void button9_Click(object sender, EventArgs e)
        {
            count++;
            if(count <= 3)
            {
                listBox3.Items.Add(textBox10.Text);
                textBox10.Text = "";
            }
            else
            {
                MessageBox.Show("Нельзя добавить больше элементов", "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox10.Text = "";
            }
        }
        int value = 0;
        private void button12_Click(object sender, EventArgs e)
        {
            value++;
            if (value <= 2)
            {
                listBox4.Items.Add(textBox11.Text);
                textBox11.Text = "";
            }
            else
            {
                MessageBox.Show("Вы слишком социальный", "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox11.Text = "";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.JPG; *.PNG; *.BMP)| *.JPG; *.PNG; *.BMP| All files (*.*)| *.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox3.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
