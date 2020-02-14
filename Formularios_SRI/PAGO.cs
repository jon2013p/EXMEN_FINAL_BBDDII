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
    public partial class PAGO : Form
    {

        public static decimal pago;
        private void RescateID()
        {
            lblid3.Text = INGRESOS.idC;
        }
        public PAGO()
        {
            InitializeComponent();
            RescateID();
            DataSet1TableAdapters.INGRESOSTableAdapter ta = new DataSet1TableAdapters.INGRESOSTableAdapter();
            DataSet1.INGRESOSDataTable dt = ta.GetDataBy1(Convert.ToInt32(lblid3.Text));
            DataSet1.INGRESOSRow row = (DataSet1.INGRESOSRow)dt.Rows[0];
            DataSet1TableAdapters.GASTOSTableAdapter tb = new DataSet1TableAdapters.GASTOSTableAdapter();
            DataSet1.GASTOSDataTable dt2 = tb.GetDataBy1(Convert.ToInt32(lblid3.Text));
            DataSet1.GASTOSRow row2 = (DataSet1.GASTOSRow)dt2.Rows[0];
            textBox1.Text = (row.valor_ingresos.ToString());
            textBox2.Text = (row2.valor_gastos.ToString());

            pago = Convert.ToDecimal(textBox1.Text) - Convert.ToDecimal(textBox2.Text);
            textBox3.Text = pago.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formularios frm = new Formularios();
            frm.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.CONTRIBUYENTETableAdapter pg = new DataSet1TableAdapters.CONTRIBUYENTETableAdapter();
            pg.UpdateSaldo(pago, Convert.ToInt32(lblid3.Text));
            MessageBox.Show("GUARDADO", "EXITO!");
        }
    }
}
