using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios_SRI
{
    public partial class GASTOS : Form
    {
        Validaciones vd = new Validaciones();
        decimal total_gastos;
        public GASTOS()
        {
            InitializeComponent();
        }

        private void RescateID()
        {
            lblid2.Text = INGRESOS.idC;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RescateID();
            total_gastos = decimal.Parse(textBox1.Text) + decimal.Parse(textBox2.Text) + decimal.Parse(textBox3.Text) + decimal.Parse(textBox4.Text) + decimal.Parse(textBox5.Text) + decimal.Parse(textBox6.Text) + decimal.Parse(textBox7.Text) + decimal.Parse(textBox8.Text) + decimal.Parse(textBox9.Text) + decimal.Parse(textBox10.Text) + decimal.Parse(textBox11.Text);
            txtTotal.Text = total_gastos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataSet1TableAdapters.GASTOSTableAdapter ta= new DataSet1TableAdapters.GASTOSTableAdapter();
            try
            {
                ta.InsertGASTOS(Convert.ToInt32(lblid2.Text), total_gastos.ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PAGO frm = new PAGO();
            frm.ShowDialog();
        }
    }
}
