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
    public partial class Form2 : Form
    {
        Model1 db = new Model1();
        public Form2()
        {
            InitializeComponent();
        }
        public static Drivers drv { get; set; } = null;
        private void Form2_Load(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = db.Drivers.ToList();
            if(drv == null)
            {
                driversBindingSource.AddNew();
            }
            else
            {
                driversBindingSource.Add(drv);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Ссерия и номер паспорта") // если в комбобоксе выбрано ссерия и номер пасорта, то данные отсортируются по возрастанию
            {
                driversBindingSource.DataSource = db.Drivers.OrderBy(a => a.Ссерия_и_номер_паспорта).ToList();
            }
            if (comboBox1.Text == "Вернуть исходные значения") // возвращает данные по умолчанию
            {
                driversBindingSource.DataSource = null;
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
        }
    


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = db.Drivers.Where(a => a.name.Contains(textBox1.Text) || a.middlename.Contains(textBox1.Text)).ToList();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = db.Drivers.Where(a => a.name.Contains(textBox1.Text) || a.middlename.Contains(textBox1.Text)).ToList();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            driversBindingSource.DataSource = db.Drivers.Where(a => a.name.Contains(textBox1.Text) || a.middlename.Contains(textBox1.Text)).ToList(); // выполяет поиск по имени и фамилии
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 db = new Form1();
            db.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.drv = null;
            DialogResult dr = frm.ShowDialog();
            if(dr == DialogResult.OK)
            {
                driversBindingSource.DataSource = null;
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Drivers drv = (Drivers)driversBindingSource.Current;
            Form3 frm = new Form3();
            frm.drv = drv;
            DialogResult dr = frm.ShowDialog();
            if(dr == DialogResult.OK)
            {
                driversBindingSource.DataSource = null;
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Drivers drv = (Drivers)driversBindingSource.Current;
            DialogResult dr = MessageBox.Show("Удалить учетную запись" + drv.ID + "?", "Удаление учетной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                db.Drivers.Remove(drv);
            }
            try
            {
                db.SaveChanges();
                driversBindingSource.DataSource = db.Drivers.ToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }
    }
}
