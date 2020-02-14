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
    public partial class CONTRIBUYENTE : Form
    {
        public CONTRIBUYENTE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INGRESOS frm = new INGRESOS();
            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GASTOS frm = new GASTOS();
            frm.ShowDialog();

        }
    }
}
