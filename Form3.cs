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
    public partial class Form3 : Form
    {
        Model1 db = new Model1();
        internal Drivers drv;

        //public static Drivers drv { get; set; }
        public Form3()
        {
            InitializeComponent();
        }
        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 db = new Form2();
            db.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(drv == null)
            {
                drv = (Drivers) driversBindingSource.Current;
                db.Drivers.Add(drv);
            }
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка" + ex.Message);
            }
        }
    }
}
