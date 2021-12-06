using MassTransit.Monitoring.Performance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ВодителиВАР3
{
    public partial class Form1 : Form
    {
        Model1 db = new Model1(); // связываем с БД
        public Form1()
        {
            InitializeComponent();
        }
        static int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            counter++;
            if (textBox1.Text == "inspector" || textBox2.Text == "inspector") // проверяет логин и пароль
            {
                Form2 db = new Form2();
                db.Show(); // показывает форму
                this.Hide(); // скрывает форму Авторизации
            }
            else if (counter >= 3) // лимит до 3 попыток
            {
                textBox1.Enabled = false; //блокируем текстбокс 1
                textBox2.Enabled = false; //блокируем текстбокс 2
                MessageBox.Show("Превышен лимит попыток захода в систему, перезапустите систему");
            }
            if (textBox1.Text == "" || textBox2.Text == "") // если пароль и логин незаполнены или неверно заполены
            {
                MessageBox.Show("Неверный логин и пароль");
                return;
            }
            else if (counter >= 3) // лимит до 3 попыток
            {
                textBox1.Enabled = false; //блокируем текстбокс 1
                textBox2.Enabled = false; //блокируем текстбокс 2
                MessageBox.Show("Превышен лимит попыток захода в систему, перезапустите систему");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
