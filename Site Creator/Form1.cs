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
    public partial class StartPage : Form
    {
        string path = @"C:\Users\negor\OneDrive\Рабочий стол\Курсач\HTML + CSS\HTML.html";

        struct State
        {
            public string name;
            public string capital;
            public int area;
            public double people;

            public State(string n, string c, int a, double p)
            {
                name = n;
                capital = c;
                people = p;
                area = a;
            }
        }

        public void InitComboBox() // МЕТОД ИНИЦИАЛИЗАЦИИ ТЕКСТ БОКСОВ
        {
            // 1 КОМБО БОКС ОБЛОЖКА
            var dataSource1 = new List<ComboClass>();
            dataSource1.Add(new ComboClass() { IdCombo = 1, NameCombo = "Обложка: заголовок и описание" });
            dataSource1.Add(new ComboClass() { IdCombo = 2, NameCombo = "Фоновое изображение" });
            dataSource1.Add(new ComboClass() { IdCombo = 3, NameCombo = "Обложка: заголовок и подзаголовок" });

            comboBox1.DataSource = dataSource1;
            comboBox1.DisplayMember = "NameCombo";
            comboBox1.ValueMember = "IdCombo";
            // ----------------------------------------------------------------------------------------------------------

            // 2 КОМБО БОКС ТЕКСТОВОЙ БЛОК
            var dataSource2 = new List<ComboClass>();
            dataSource2.Add(new ComboClass() { IdCombo = 1, NameCombo = "Текст по центру" });
            dataSource2.Add(new ComboClass() { IdCombo = 2, NameCombo = "Текст на серой карточке" });
            dataSource2.Add(new ComboClass() { IdCombo = 3, NameCombo = "Мелкий текст" });

            comboBox5.DataSource = dataSource2;
            comboBox5.DisplayMember = "NameCombo";
            comboBox5.ValueMember = "IdCombo";
            // ----------------------------------------------------------------------------------------------------------

            // 3 КОМБО БОКС ПРЕИМУЩЕСТВА
            var dataSource3 = new List<ComboClass>();
            dataSource3.Add(new ComboClass() { IdCombo = 1, NameCombo = "Список с галочками" });
            dataSource3.Add(new ComboClass() { IdCombo = 2, NameCombo = "Список с цифрами и кружками" });
            dataSource3.Add(new ComboClass() { IdCombo = 3, NameCombo = "Колонки с иконками" });

            comboBox4.DataSource = dataSource3;
            comboBox4.DisplayMember = "NameCombo";
            comboBox4.ValueMember = "IdCombo";
            // ----------------------------------------------------------------------------------------------------------

            // 4 КОМБО БОКС КОНТАКТЫ
            var dataSource4 = new List<ComboClass>();
            dataSource4.Add(new ComboClass() { IdCombo = 1, NameCombo = "С заголовком и описанием" });
            dataSource4.Add(new ComboClass() { IdCombo = 2, NameCombo = "Контакты с телефоном и email" });

            comboBox3.DataSource = dataSource4;
            comboBox3.DisplayMember = "NameCombo";
            comboBox3.ValueMember = "IdCombo";
            // ----------------------------------------------------------------------------------------------------------

            // 5 КОМБО БОКС ПОДВАЛ
            var dataSource5 = new List<ComboClass>();
            dataSource5.Add(new ComboClass() { IdCombo = 1, NameCombo = "Текст + соц. сети" });
            dataSource5.Add(new ComboClass() { IdCombo = 2, NameCombo = "Строка ссылок и копирайт" });

            comboBox6.DataSource = dataSource5;
            comboBox6.DisplayMember = "NameCombo";
            comboBox6.ValueMember = "IdCombo";
            // ----------------------------------------------------------------------------------------------------------


            // 6 КОМБО БОКС НАВ МЕНЮ
            var dataSource6 = new List<ComboClass>();
            dataSource6.Add(new ComboClass() { IdCombo = 1, NameCombo = "С логотипом по центру" });
            dataSource6.Add(new ComboClass() { IdCombo = 2, NameCombo = "С логотипом слева" });

            comboBox2.DataSource = dataSource6;
            comboBox2.DisplayMember = "NameCombo";
            comboBox2.ValueMember = "IdCombo";
            // ----------------------------------------------------------------------------------------------------------


            // 7 КОМБО БОКС НАВ МЕНЮ
            var dataSource7 = new List<ComboClass>();
            dataSource7.Add(new ComboClass() { IdCombo = 1, NameCombo = "Изображения в две колонки" });
            dataSource7.Add(new ComboClass() { IdCombo = 2, NameCombo = "Изображения в три колонки" });

            comboBox7.DataSource = dataSource7;
            comboBox7.DisplayMember = "NameCombo";
            comboBox7.ValueMember = "IdCombo";
            // ----------------------------------------------------------------------------------------------------------

            // 8 КОМБО БОКС НАВ МЕНЮ
            var dataSource8 = new List<ComboClass>();
            dataSource8.Add(new ComboClass() { IdCombo = 1, NameCombo = "Темная тема" });
            dataSource8.Add(new ComboClass() { IdCombo = 2, NameCombo = "Светлая тема" });

            comboBox8.DataSource = dataSource8;
            comboBox8.DisplayMember = "NameCombo";
            comboBox8.ValueMember = "IdCombo";
            // ----------------------------------------------------------------------------------------------------------

        }



        public StartPage()
        {
            InitializeComponent();
            InitComboBox();            
        }


        private void button2_Click(object sender, EventArgs e) // МЕТОД ВЫБОРА ЭЛЕМЕНТОВ НА ИНДИВИДУАЛЬНОЙ СТРАНИЦЕ ЗАПОЛНЕНИЯ МАКЕТОВ
        {
            FirstApply applyForm = new FirstApply();

            applyForm.Owner = this;

            if(comboBox1.SelectedIndex == 0) // ОБЛОЖКА
            {
                applyForm.label2.Visible = false;
                applyForm.pictureBox2.Visible = false;
            }

            if(comboBox1.SelectedIndex == 1)// ОБЛОЖКА
            {
                applyForm.label2.Visible = false;
                applyForm.pictureBox2.Visible = false;
                applyForm.label5.Visible = false;
                applyForm.textBox7.Visible = false;
                applyForm.label8.Visible = false;
                applyForm.textBox8.Visible = false;
            }
            if(comboBox1.SelectedIndex == 2)// ОБЛОЖКА
            {
                applyForm.label2.Visible = false;
                applyForm.pictureBox2.Visible = false;
                applyForm.label8.Text = "Подзаголовок";
            }

            if(comboBox3.SelectedIndex == 1) // ОФОРМЛЕНИЕ КОНТАКТОВ
            {
                applyForm.label10.Text = "Почта:";
                applyForm.label11.Text = "Телефон:";
            }
            if(comboBox2.SelectedIndex == 1)
            {
                applyForm.label9.Visible = false;
                applyForm.textBox12.Visible = false;
            }

            if(comboBox5.SelectedIndex == 0 || comboBox5.SelectedIndex == 2)
            {
                applyForm.label4.Visible = false;
                applyForm.textBox2.Visible = false;
            }

            if(checkBox1.Checked == true) // ДОБАВИТЬ ГАЛЕРЕЮ
            {
                if(comboBox7.SelectedIndex == 0)
                {
                    applyForm.pictureBox6.Visible = false;
                }
                else
                {
                    
                }
            }
            else
            {
                applyForm.groupBox9.Visible = false;
            }

            if(checkBox2.Checked == true) // ОТОБРАЖЕНИЕ НАВ МЕНЮ НА ВТОРОЙ ФОРМЕ
            {
                applyForm.groupBox3.Visible = true;
            }
            else
            {
                applyForm.groupBox3.Visible = false;
            }

            if(checkBox3.Checked == true) // ОТОБРАЖЕНИЕ ОБЛОЖКИ НА ВТОРОЙ ФОРМЕ
            {
                applyForm.groupBox2.Visible = true;
            }
            else
            {
                applyForm.groupBox2.Visible = false;
            }

            if(comboBox5.SelectedIndex == 0 || comboBox5.SelectedIndex == 2)
            {
                applyForm.label4.Visible = false;
                applyForm.textBox2.Visible = false;
            }

            if(comboBox3.SelectedIndex == 1)
            {
                applyForm.label10.Visible = false;
                applyForm.textBox6.Visible = false;
                applyForm.label11.Visible = false;
                applyForm.textBox5.Visible = false;
            }


            applyForm.ShowDialog();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e) // МЕТОД заполнения примерных макетов
        {
            StreamWriter streamwriter = new StreamWriter(@"D:\index.html");
            streamwriter.WriteLine("<html>");
            streamwriter.WriteLine("<head>");
            streamwriter.WriteLine($"<title>Название</title>");
            streamwriter.WriteLine("<link rel=\"stylesheet\" href= \"C:\\Users\\negor\\OneDrive\\Рабочий стол\\Курсач\\HTML + CSS\\style.css\" >");
            streamwriter.WriteLine("</head>");
            streamwriter.WriteLine("<body>");

            if (checkBox3.Checked == true)
            {
                if (comboBox1.SelectedIndex == 0) // ОБЛОЖКА
                {
                    streamwriter.WriteLine("<div class=" + "zagolovok1" + ">");
                    streamwriter.WriteLine("<div class=" + "img" + ">");
                    streamwriter.WriteLine($"<h2>Заголовок обложки</h2>");
                    streamwriter.WriteLine("<br>");
                    streamwriter.WriteLine($"<p>Подзаголовок обложки</p>");
                    streamwriter.WriteLine("</div>");
                    streamwriter.WriteLine("</div>");
                }

                if (comboBox1.SelectedIndex == 1) // ОБЛОЖКА
                {
                    streamwriter.WriteLine("<div class=" + "zagolovok3" + ">");
                    streamwriter.WriteLine($"<img class=\"imagefull\" src=\"C:\\Users\negor\\OneDrive\\Рабочий стол\\Курсач\\Фотки\\Youtube-kanal-Dodo-Pizza-Russia.jpg\">");
                    streamwriter.WriteLine("</div>");
                }

                if (comboBox1.SelectedIndex == 2) // ОБЛОЖКА
                {
                    streamwriter.WriteLine("<div class=" + "zagolovok2" + ">");
                    streamwriter.WriteLine("<div class=" + "img" + ">");
                    streamwriter.WriteLine($"<p class=\"zag1\">Заголовок обложки</p>");
                    streamwriter.WriteLine("<hr class= \"hr1\">");
                    streamwriter.WriteLine("<br>");
                    streamwriter.WriteLine($"<p class= \"opisanie\">Описание обложки");
                    streamwriter.WriteLine("</p>");
                    streamwriter.WriteLine("</div>");
                    streamwriter.WriteLine("</div>");
                }
            }

            if (checkBox2.Checked == true) // НАВИГАЦИОННОЕ МЕНЮ С ЛОГО ПО ЦЕНТРУ
            {
                if (comboBox2.SelectedIndex == 0)
                {
                        streamwriter.WriteLine("<div class=" + "nav-menu-1" + ">");
                        streamwriter.WriteLine("<ul class=" + "main-menu-1" + ">");
                        streamwriter.WriteLine($"<li><a href=\"\" >Пункт меню</a></li>");
                        streamwriter.WriteLine($"<li><a href=\"\" >Пункт меню</a></li>");
                        streamwriter.WriteLine($"<li><p>Название сайта</p></li>");
                        streamwriter.WriteLine($"<li><a href=\"\" >Пункт меню</a></li>");
                        streamwriter.WriteLine($"<li><a href=\"\" >Пункт меню</a></li>");
                        streamwriter.WriteLine("</ul>");
                        streamwriter.WriteLine("</div>");
                }

                if (comboBox2.SelectedIndex == 1) // НАВИГАЦИОННОЕ МЕНЮ по краям
                {

                        streamwriter.WriteLine("<div class=" + "nav-menu-2" + ">");
                        streamwriter.WriteLine("<ul class=" + "main-menu-2" + ">");
                    streamwriter.WriteLine($"<li><a href=\"\" >Пункт меню</a></li>");
                    streamwriter.WriteLine($"<li><a href=\"\" >Пункт меню</a></li>");
                        streamwriter.WriteLine($"<div class=" + "main-menu2-right" + ">");
                    streamwriter.WriteLine($"<li><a href=\"\" >Пункт меню</a></li>");
                    streamwriter.WriteLine($"<li><a href=\"\" >Пункт меню</a></li>");
                    streamwriter.WriteLine("</div>");
                        streamwriter.WriteLine("</ul>");
                        streamwriter.WriteLine("</div>");
                }
            }

             if (comboBox5.SelectedIndex == 0) // ТТЕКСТ ПОЛЕ
            {
                streamwriter.WriteLine("<div class=" + "singletext" + ">");
                streamwriter.WriteLine($"<p>Обычный текст по центру</p>");
                streamwriter.WriteLine("</div>");
            }

            if (comboBox5.SelectedIndex == 1) // ТТЕКСТ ПОЛЕ
            {
                    streamwriter.WriteLine("<div class=" + "fondiv" + ">");
                    streamwriter.WriteLine("<br><br>");
                    streamwriter.WriteLine($"<b class=\"text1\">Заголовок тестового поля</b> <br>");
                    streamwriter.WriteLine($"<p class=\"text2\">Зи́мняя рыба́лка — рыбалка в зимний период, обычно на льду через лунку или прорубь.</p>");
                    streamwriter.WriteLine("</div>");
                    streamwriter.WriteLine("<br>");
            }

            if (comboBox5.SelectedIndex == 2) // ТТЕКСТ ПОЛЕ
            {
                streamwriter.WriteLine("<div class=" + "smalltext" + ">");
                streamwriter.WriteLine($"<small>Мелкий текст</small>");
                streamwriter.WriteLine("</div>");
            }

            if (comboBox4.SelectedIndex == 0)// ПРЕИМУЩЕСТВА
            {
                    streamwriter.WriteLine("<div class=" + "prem1" + ">");
                    streamwriter.WriteLine($"<h2>Преимущества меню</h2>");
                    streamwriter.WriteLine("<ol>");
                    streamwriter.WriteLine($"<li>Преимущество1");
                streamwriter.WriteLine($"<li>Преимущество2");
                streamwriter.WriteLine($"<li>Преимущество3");

                streamwriter.WriteLine("</ol>");
                    streamwriter.WriteLine("</div>");
            }
            if (comboBox4.SelectedIndex == 1) // ПРЕИМУЩЕСТВА
            {
                streamwriter.WriteLine("<div class=" + "prem1" + ">");
                streamwriter.WriteLine($"<h2>Преимущества меню</h2>");
                streamwriter.WriteLine("<ol>");
                streamwriter.WriteLine($"<li>Преимущество1");
                streamwriter.WriteLine($"<li>Преимущество2");
                streamwriter.WriteLine($"<li>Преимущество3");

                streamwriter.WriteLine("</ol>");
                streamwriter.WriteLine("</div>");
            }
            if (comboBox4.SelectedIndex == 2)// ПРЕИМУЩЕСТВА
            {

            }

            if (comboBox7.SelectedIndex == 0) // Галерея
            {
                streamwriter.WriteLine("<p class=" + "galereya1" + ">");
                streamwriter.WriteLine($"<img src=\"https://m.media-amazon.com/images/I/71FLVw1BKBL._AC_AA180_.jpg\" width=\"120\" height=\"120\">");
                streamwriter.WriteLine($"<img src=\"C:\\Users\\negor\\OneDrive\\Рабочий стол\\Курсач\\tik_tok_logo.png\" width=\"120\" height=\"120\">");
                streamwriter.WriteLine("</p>");
            }

            if (comboBox7.SelectedIndex == 1) // Галерея
            {
                streamwriter.WriteLine("<p class=" + "galereya1" + ">");
                streamwriter.WriteLine($"<img src=\"https://m.media-amazon.com/images/I/71FLVw1BKBL._AC_AA180_.jpg\" width=\"120\" height=\"120\">");
                streamwriter.WriteLine($"<img src=\"C:\\Users\\negor\\OneDrive\\Рабочий стол\\Курсач\\tik_tok_logo.png\" width=\"120\" height=\"120\">");
                streamwriter.WriteLine($"<img src=\"C:\\Users\\negor\\OneDrive\\Рабочий стол\\Курсач\\d29fc14e3e508b26c3c121c133df174c.png\" width=\"120\" height=\"120\">");
                streamwriter.WriteLine("</p>");
            }

            if (comboBox3.SelectedIndex == 0) // КОНТАКТЫ
            {
                streamwriter.WriteLine("<div class=" + "contacts-1" + ">");
                streamwriter.WriteLine($"<p>Ваши контакты</p>");
                streamwriter.WriteLine($"<p>Ваши контакты</p>");
                streamwriter.WriteLine("</div>");
            }

            if (comboBox3.SelectedIndex == 1) // КОНТАКТЫ
            {
                    streamwriter.WriteLine("<div class=" + "contacts-1" + ">");
                    streamwriter.WriteLine($"<p>+798218392319</p>");
                    streamwriter.WriteLine($"<p>negoric@bk.ru</p>");
                    streamwriter.WriteLine("</div>");
            }
            if (comboBox6.SelectedIndex == 0) // ФУТЕР
            {
                    streamwriter.WriteLine("<div class=" + "podval1" + ">");
                    streamwriter.WriteLine("<ul class=" + "podval-1" + ">");
                    streamwriter.WriteLine($"<li><a href=\"podval-img1\" src= >Копирайт сайта</a></li>");
                    streamwriter.WriteLine("<div class=" + "main-menu2-right" + ">");
                    streamwriter.WriteLine($"<li><img class=\"podval-img1\" src=\"C:\\Users\\negor\\OneDrive\\Рабочий стол\\Курсач\\d29fc14e3e508b26c3c121c133df174c.png\" alt =\"\" height=\"40px\"></li>");
                    streamwriter.WriteLine($"<li><img class=\"podval-img2\" src=\"C:\\Users\negor\\OneDrive\\Рабочий стол\\Курсач\\tik_tok_logo.png\" alt =\"\" height=\"40px\"></li>");
                    streamwriter.WriteLine("</div>");
                    streamwriter.WriteLine("</ul>");
                    streamwriter.WriteLine("</div>");
            }
            if (comboBox6.SelectedIndex == 1) // ФУТЕР
            {
                    streamwriter.WriteLine("<div class=" + "podval2" + ">");
                    streamwriter.WriteLine("<ul class=" + "pod" + ">");
                    streamwriter.WriteLine($"<li><a href=\"\" >Ссылка1</a></li>");
                    streamwriter.WriteLine($"<li><a href=\"\" >Ссылка2</a></li>");
                    streamwriter.WriteLine($"<li><a href=\"\" >Ссылка3</a></li>");
                    streamwriter.WriteLine($"<li><a href=\"\" >Ссылка4</a></li>");
                    streamwriter.WriteLine($"<li><a href=\"\" >Ссылка5</a></li>");
                    streamwriter.WriteLine("</ul>");
                    streamwriter.WriteLine($"<p class=\"podval-p\">Копирайт сайта</p>");
                    streamwriter.WriteLine("</div>");
            }


            streamwriter.WriteLine("</body>");
            streamwriter.WriteLine("</html>");
            streamwriter.Close();

            System.Diagnostics.Process.Start(@"D:\index.html");
            //System.Diagnostics.Process.Start(path);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label6.Visible = true;
                comboBox7.Visible = true;
            }
            else
            {
                label6.Visible = false;
                comboBox7.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                comboBox1.SelectedIndex = 1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                label2.Visible = true;
                comboBox2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                comboBox2.Visible = false;
                
            }
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkBox3.Checked == true)
            {
                label1.Visible = true;
                comboBox1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                comboBox1.Visible = false;
            }
        }

    }
}
