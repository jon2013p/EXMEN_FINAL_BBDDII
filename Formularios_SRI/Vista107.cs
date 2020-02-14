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
    public partial class Vista107 : Form
    {
        public Vista107()
        {
            InitializeComponent();
        }

        private void Vista107_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Form107TableAdapter ta = new DataSet1TableAdapters.Form107TableAdapter();
            DataSet1.Form107DataTable dt = ta.GetDataBy1(LIQUIDACIÓN.ruc1);
            dataGridView1.DataSource = dt;
        }
    }
}
