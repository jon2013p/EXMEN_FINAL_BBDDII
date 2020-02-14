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
    public partial class LIQUIDACIÓN : Form
    {

        Validaciones vd = new Validaciones();
        public static String ruc1;
        
        public LIQUIDACIÓN()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Form107TableAdapter ta1 = new DataSet1TableAdapters.Form107TableAdapter();
            ta1.AddDataF107(txtRuc.Text,txtRSocial.Text,txt301.Text.Trim(),txt303.Text.Trim(), txt305.Text.Trim(), txt307.Text.Trim(), txt311.Text.Trim(), txt313.Text.Trim(), txt315.Text.Trim(), txt317.Text.Trim(), txt351.Text.Trim(), txt353.Text.Trim(), txt361.Text.Trim(), txt363.Text.Trim(), txt365.Text.Trim(), txt367.Text.Trim(), txt369.Text.Trim(), txt371.Text.Trim(), txt373.Text.Trim(), txt381.Text.Trim(), txt399.Text.Trim(), txt401.Text.Trim(), txt403.Text.Trim(), txt405.Text.Trim(), txt407.Text.Trim());
            MessageBox.Show("Los datos han sido guardados correctamente.", "Guardado Exitoso");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            decimal Base_Imponible = Decimal.Parse(txt301.Text) + Decimal.Parse(txt303.Text) + Decimal.Parse(txt305.Text) + Decimal.Parse(txt307.Text) - Decimal.Parse(txt351.Text) - Decimal.Parse(txt353.Text) - Decimal.Parse(txt361.Text) - Decimal.Parse(txt363.Text) - Decimal.Parse(txt365.Text) - Decimal.Parse(txt367.Text) - Decimal.Parse(txt369.Text) - Decimal.Parse(txt371.Text) - Decimal.Parse(txt373.Text) + Decimal.Parse(txt381.Text);
            txt399.Text = Base_Imponible.ToString();

            btnInsertar.Enabled = true;

            MessageBox.Show("La base imponible ha sido calculada. Revise el campo 399", "Base Imponible");
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txtRSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Letras(e);
        }
        private void txt301_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt303_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt305_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt307_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt311_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt313_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt315_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt317_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt351_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt353_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt361_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt363_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt365_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt367_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt369_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt371_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt373_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt381_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt399_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt401_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt403_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt405_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
        private void txt407_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }

        private void txt301_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ruc1 = txtRuc.Text;
            Vista107 frm = new Vista107();
            frm.ShowDialog();
        }

        private void LIQUIDACIÓN_Load(object sender, EventArgs e)
        {

        }
    }
}
