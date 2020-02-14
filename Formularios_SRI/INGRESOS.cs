using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios_SRI
{
    public partial class INGRESOS : Form
    {
        Validaciones vd = new Validaciones();
        decimal total_ing;
        public INGRESOS()
        {
            InitializeComponent();
        }

        public static String idC;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtruc.Text)|| string.IsNullOrEmpty(txtrazon.Text))
            {
                MessageBox.Show("Es obligatorio ingresar el RUC y la Razón Social","ERROR");
                return;
            }
            
            
            DataSet1TableAdapters.CONTRIBUYENTETableAdapter ta = new DataSet1TableAdapters.CONTRIBUYENTETableAdapter();
            ta.InsertCont(txtruc.Text.Trim(),txtrazon.Text.Trim());
            
        }

        private void Suma_Totales_Ing()
        {
            SqlConnection sqlcmd = new SqlConnection(@"Data Source= DESKTOP-TSPT2F3;Initial Catalog=Formulario_102A;Integrated Security=True");
            try
            {
                if (sqlcmd.State == ConnectionState.Closed)
                    sqlcmd.Open();

                String query = "SELECT id_contribuyente from CONTRIBUYENTE where ruc_contr=@ruc";
                SqlCommand sqlcon = new SqlCommand(query, sqlcmd);
                sqlcon.Parameters.AddWithValue("@ruc", txtruc.Text);
                SqlDataReader register = sqlcon.ExecuteReader();

                if (register.Read())
                {
                    lblid.Text = register["id_contribuyente"].ToString();
                }

                sqlcmd.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idC = lblid.Text;
            GASTOS frm = new GASTOS();
            frm.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            total_ing = Convert.ToDecimal(textBox0.Text) + Convert.ToDecimal(textBox1.Text) + Convert.ToDecimal(textBox2.Text) + Convert.ToDecimal(textBox3.Text) + Convert.ToDecimal(textBox4.Text) + Convert.ToDecimal(textBox5.Text) + Convert.ToDecimal(textBox7.Text) + Convert.ToDecimal(textBox8.Text) + Convert.ToDecimal(textBox9.Text) + Convert.ToDecimal(textBox10.Text) + Convert.ToDecimal(textBox11.Text);
            txtTotal.Text = total_ing.ToString();

        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void txtruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void txtrazon_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Letras(e);
        }

        private void textBox0_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
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

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtruc.Text) || string.IsNullOrEmpty(txtrazon.Text))
            {
                MessageBox.Show("Es obligatorio ingresar el RUC y la Razón Social", "Error");
                return;
            }
            Suma_Totales_Ing();
            DataSet1TableAdapters.INGRESOSTableAdapter ta = new DataSet1TableAdapters.INGRESOSTableAdapter();
            try
            {
                ta.InsertarING(total_ing.ToString(), Convert.ToInt32(lblid.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no pudieron ser ingresados", "ERROR");
            }
        }
    }
}
