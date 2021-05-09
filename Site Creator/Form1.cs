using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Site_Creator
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\negor\OneDrive\Рабочий стол\Курсач\HTML + CSS\HTML.html";
        string[] oblojkaItems = { "1", "2", "3" };

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

        public void InitComboBox()
        {
            // 1 КОМБО БОКС ОБЛОЖКА
            var dataSource1 = new List<ComboClass>();
            dataSource1.Add(new ComboClass() { IdCombo = 1, NameCombo = "Обложка: заголовок и описание" });
            dataSource1.Add(new ComboClass() { IdCombo = 2, NameCombo = "Обложка: логотип на фоне" });
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

        }



        public Form1()
        {
            InitializeComponent();
            InitComboBox();
            //comboBox1.Items.AddRange(oblojkaItems);
            
        }

        // Бинарная запись в файл.html
        // БИНАРНЫЕ ЗАПИСЬ И ЧТЕНИЕ ФАЙЛОВ

        // Обновляем текстовик каждый раз при нажатии на оформить 
        // КАК НАЙТИ СПЕЦИАЛЬНУЮ СТРОКУ В ФАЙЛЕ И ВСТАВИТЬ ТУДА ТЕКСТ

        private void button2_Click(object sender, EventArgs e)
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

            if(checkBox2.Checked == true)
            {
                applyForm.groupBox3.Visible = true;
            }
            else
            {
                applyForm.groupBox3.Visible = false;
            }


            applyForm.ShowDialog();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(path);
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
            }
            else
            {
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
    }
}
