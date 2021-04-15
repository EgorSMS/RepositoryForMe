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
        string path = @"C:\Users\negor\OneDrive\Рабочий стол\Магазин\index.html";
        string[] oblojkaItems = { "1", "2", "3" };
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(oblojkaItems);
        }

        // Бинарная запись в файл.html
        // БИНАРНЫЕ ЗАПИСЬ И ЧТЕНИЕ ФАЙЛОВ

        // Обновляем текстовик каждый раз при нажатии на оформить 
        // КАК НАЙТИ СПЕЦИАЛЬНУЮ СТРОКУ В ФАЙЛЕ И ВСТАВИТЬ ТУДА ТЕКСТ

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(path);
        }
    }
}
