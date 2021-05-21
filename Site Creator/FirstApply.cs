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
        string picturePath = ""; // ОБЛОЖКА
        string picturePath1 = ""; // ОБЛОЖКА
        string picturePath2 = ""; // ОБЛОЖКА


        public FirstApply()
        {
            InitializeComponent();
        }
        int coutinho = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            coutinho++;
            if (listBox1.Items.Count <= 4)
            {
                listBox1.Items.Add(textBox9.Text);
                textBox9.Text = "";
            }
            else
            {
                MessageBox.Show("Нельзя добавить больше элементов!");
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


            if (form1.checkBox3.Checked == true)
            {
                if (form1.comboBox1.SelectedIndex == 0) // ОБЛОЖКА
                {
                    if (pictureBox3.Image != null && textBox7.Text != null && textBox8.Text != null)
                    {
                        streamwriter.WriteLine("<div class=" + "zagolovok1" + ">");
                        streamwriter.WriteLine("<div class=" + "img" + ">");
                        streamwriter.WriteLine($"<h2>{textBox7.Text}</h2>");
                        streamwriter.WriteLine("<br>");
                        streamwriter.WriteLine($"<p>{textBox8.Text}</p>");
                        streamwriter.WriteLine("</div>");
                        streamwriter.WriteLine("</div>");
                    }
                    else
                    {
                        MessageBox.Show("Заполните обложку");
                    }
                }
                if (form1.comboBox1.SelectedIndex == 1) // ОБЛОЖКА
                {
                    if (pictureBox3.Image != null && textBox7.Text != null && textBox8.Text != null)
                    {

                        streamwriter.WriteLine("<div class=" + "zagolovok3" + ">");
                        streamwriter.WriteLine($"<img class=\"imagefull\" src=\"{picturePath}\">");
                        streamwriter.WriteLine("</div>");
                    }
                    else
                    {
                        MessageBox.Show("Заполните обложку");
                    }
                }
                if (form1.comboBox1.SelectedIndex == 2) // ОБЛОЖКА
                {

                    if (pictureBox3.Image != null && textBox7.Text != null && textBox8.Text != null)
                    {

                        streamwriter.WriteLine("<div class=" + "zagolovok2" + ">");
                        streamwriter.WriteLine("<div class=" + "img" + ">");
                        streamwriter.WriteLine($"<p class=\"zag1\">{textBox7.Text}</p>");
                        streamwriter.WriteLine("<hr class= \"hr1\">");
                        streamwriter.WriteLine("<br>");
                        streamwriter.WriteLine($"<p class= \"opisanie\"> {textBox8.Text}");
                        streamwriter.WriteLine("</p>");
                        streamwriter.WriteLine("</div>");
                        streamwriter.WriteLine("</div>");
                    }
                    else
                    {
                        MessageBox.Show("Заполните обложку 3");
                    }
                }
            }

            if (form1.checkBox2.Checked == true) // НАВИГАЦИОННОЕ МЕНЮ С ЛОГО ПО ЦЕНТРУ
            {
                if (form1.comboBox2.SelectedIndex == 0)
                {
                    if (textBox12.Text != null && listBox1.Items.Count > 0)
                    {

                        streamwriter.WriteLine("<div class=" + "nav-menu-1" + ">");
                        streamwriter.WriteLine("<ul class=" + "main-menu-1" + ">");
                        for (int i = 0; i < listBox1.Items.Count - 2; i++)
                        {
                            streamwriter.WriteLine($"<li><a href=\"\" >{listBox1.Items[i]}</a></li>");
                        }
                        streamwriter.WriteLine($"<li><p>{textBox12.Text}</p></li>");
                        for (int i = 2; i < listBox1.Items.Count; i++)
                        {
                            streamwriter.WriteLine($"<li><a href=\"\" >{listBox1.Items[i]}</a></li>");
                        }
                        streamwriter.WriteLine("</ul>");
                        streamwriter.WriteLine("</div>");
                    }
                    else
                    {
                        MessageBox.Show("Заполните навигационное меню");
                    }
                }

                if (form1.comboBox2.SelectedIndex == 1) // НАВИГАЦИОННОЕ МЕНЮ по краям
                {
                    if (textBox12.Text != null && listBox1.Items.Count > 0)
                    {


                        streamwriter.WriteLine("<div class=" + "nav-menu-2" + ">");
                        streamwriter.WriteLine("<ul class=" + "main-menu-2" + ">");
                        for (int i = 0; i < listBox1.Items.Count-2; i++)
                        {
                            streamwriter.WriteLine($"<li><a href=\"\" >{listBox1.Items[i]}</a></li>");
                        }
                        streamwriter.WriteLine($"<div class=" + "main-menu2-right" + ">");
                        for (int i = 2; i < listBox1.Items.Count; i++)
                        {
                            streamwriter.WriteLine($"<li><a href=\"\" >{listBox1.Items[i]}</a></li>");
                        }
                        streamwriter.WriteLine("</div>");
                        streamwriter.WriteLine("</ul>");
                        streamwriter.WriteLine("</div>");
                    }
                    else
                    {
                        MessageBox.Show("Заполните навигационное меню 2");
                    }
                }
            }
            
            if(form1.comboBox5.SelectedIndex == 1) // ТТЕКСТ ПОЛЕ
            {
                if(textBox2.Text != null && textBox1.Text != null)
                {
                    streamwriter.WriteLine("<div class=" + "fondiv" + ">");
                    streamwriter.WriteLine("<br><br>");
                    streamwriter.WriteLine($"<b class=\"text1\">{textBox2.Text}</b> <br>");
                    streamwriter.WriteLine($"<p class=\"text2\">{textBox1.Text}</p>");
                    streamwriter.WriteLine("</div>");
                    streamwriter.WriteLine("<br>");

                }
                else
                {
                    MessageBox.Show("Не заполнен тестовый блок 2");
                }
            }

            if (form1.comboBox4.SelectedIndex == 0)// ПРЕИМУЩЕСТВА
            {
                if(textBox3.Text != null && listBox2.Items.Count > 0)
                {
                    streamwriter.WriteLine("<div class=" + "prem1" + ">");
                    streamwriter.WriteLine($"<h2>{textBox3.Text}</h2>");
                    streamwriter.WriteLine("<ol>");
                    for(int i = 0; i < listBox2.Items.Count; i++)
                    {
                        streamwriter.WriteLine($"<li>{listBox2.Items[i]}");
                    }
                    streamwriter.WriteLine("</ol>");
                    streamwriter.WriteLine("</div>");
                }
                else
                {
                    MessageBox.Show("Заполните преимущества");
                }
            }
            if(form1.comboBox4.SelectedIndex == 1) // ПРЕИМУЩЕСТВА
            {
                if (textBox3.Text != null && listBox2.Items.Count > 0)
                {
                    streamwriter.WriteLine("<div class=" + "prem1" + ">");
                    streamwriter.WriteLine($"<h2>{textBox3.Text}</h2>");
                    streamwriter.WriteLine("<ol>");
                    for (int i = 0; i < listBox2.Items.Count; i++)
                    {
                        streamwriter.WriteLine($"<li>{listBox2.Items[i]}");
                    }
                    streamwriter.WriteLine("</ol>");
                    streamwriter.WriteLine("</div>");
                }
                else
                {
                    MessageBox.Show("Заполните преимущества 2");
                }
            }
            if (form1.comboBox4.SelectedIndex == 2)// ПРЕИМУЩЕСТВА
            {

            }
            if(form1.checkBox1.Checked == true) // Галерея
            {
                if (form1.comboBox7.SelectedIndex == 0) 
                {
                    if(pictureBox4.Image != null && pictureBox5.Image != null)
                    {
                        //           < p class="galereya1">
                        //  <img src = "https://m.media-amazon.com/images/I/71FLVw1BKBL._AC_AA180_.jpg" alt="Фотография 1" width="120" height="120">
                        //  <img src = "C:\Users\negor\OneDrive\Рабочий стол\Курсач\d29fc14e3e508b26c3c121c133df174c.png" alt="Фотография 2" width="120" height="120">
                        //  <img src = "C:\Users\negor\OneDrive\Рабочий стол\Курсач\tik_tok_logo.png" alt="Фотография 3" width="120" height="120">
                        //</p>
                        streamwriter.WriteLine("<p class=" + "galereya1" + ">");
                        streamwriter.WriteLine($"<img src=\"{picturePath1}\" width=\"120\" height=\"120\">");
                        streamwriter.WriteLine($"<img src=\"{picturePath2}\" width=\"120\" height=\"120\">");
                        streamwriter.WriteLine("</p>");
                        streamwriter.WriteLine("</div>");
                    }
                    else
                    {
                        MessageBox.Show("Заполните все изображения");
                    }
                }
            }
            
            
            if(form1.comboBox3.SelectedIndex == 1) // КОНТАКТЫ
            {
                if(listBox3.Items.Count > 0)
                {
                    streamwriter.WriteLine("<div class=" + "contacts-1" + ">");
                    for(int i = 0; i < listBox3.Items.Count; i++)
                    {
                        streamwriter.WriteLine($"<p>{listBox3.Items[i]}</p>");
                    }
                    streamwriter.WriteLine("</div>");
                }
                else
                {
                    MessageBox.Show("Заполните контакты 2");
                }
            }
            if (form1.comboBox6.SelectedIndex == 0) // ФУТЕР
            {
                if(textBox13.Text != null && listBox4.Items.Count > 0)
                {
                    streamwriter.WriteLine("<div class=" + "podval1" + ">");
                    streamwriter.WriteLine("<ul class=" + "podval-1" + ">");
                    streamwriter.WriteLine($"<li><a href=\"podval-img1\" src= >{textBox13.Text}</a></li>");
                    streamwriter.WriteLine("<div class=" + "main-menu2-right" + ">");
                    streamwriter.WriteLine($"<li><img class=\"podval-img1\" src=\"C:\\Users\\negor\\OneDrive\\Рабочий стол\\Курсач\\d29fc14e3e508b26c3c121c133df174c.png\" alt =\"\" height=\"40px\"></li>");
                    streamwriter.WriteLine($"<li><img class=\"podval-img2\" src=\"C:\\Users\negor\\OneDrive\\Рабочий стол\\Курсач\\tik_tok_logo.png\" alt =\"\" height=\"40px\"></li>");
                    streamwriter.WriteLine("</div>");
                    streamwriter.WriteLine("</ul>");
                    streamwriter.WriteLine("</div>");
                }
                else
                {
                    MessageBox.Show("Футер не заполнен");
                }
            }
            if(form1.comboBox6.SelectedIndex == 1) // ФУТЕР
            {
                if (textBox13.Text != null && listBox4.Items.Count > 0)
                {
                    streamwriter.WriteLine("<div class=" + "podval2" + ">");
                    streamwriter.WriteLine("<ul class=" + "pod" + ">");
                    for (int i = 0; i < listBox4.Items.Count; i++)
                    {
                        streamwriter.WriteLine($"<li><a href=\"\" >{listBox4.Items[i]}</a></li>");
                    }
                    streamwriter.WriteLine("</ul>");
                    streamwriter.WriteLine($"<p class=\"podval-p\">{textBox13.Text}</p>");
                    streamwriter.WriteLine("</div>");
                }
                else
                {
                    MessageBox.Show("Заполните футер 2");
                }
            }

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
            if (listBox2.Items.Count <= 3)
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
            if(listBox3.Items.Count <= 3)
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
            if (listBox4.Items.Count <= 5)
            {
                listBox4.Items.Add(textBox11.Text);
                textBox11.Text = "";
            }
            else
            {
                MessageBox.Show("Слишком много ссылок", "Критическая ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox11.Text = "";
            }
        }
        
        public void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.JPG; *.PNG; *.BMP)| *.JPG; *.PNG; *.BMP| All files (*.*)| *.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picturePath = openFileDialog.FileName;
                    pictureBox3.Image = new Bitmap(openFileDialog.FileName);
                    //textBox8.Text = picturePath;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox3.Items.Remove(listBox3.SelectedItem);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox4.Items.Remove(listBox4.SelectedItem);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.JPG; *.PNG; *.BMP)| *.JPG; *.PNG; *.BMP| All files (*.*)| *.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picturePath1 = openFileDialog.FileName;
                    pictureBox4.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.JPG; *.PNG; *.BMP)| *.JPG; *.PNG; *.BMP| All files (*.*)| *.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picturePath2 = openFileDialog.FileName;
                    pictureBox5.Image = new Bitmap(openFileDialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
