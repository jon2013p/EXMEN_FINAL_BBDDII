using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Formularios_SRI
{
    public partial class Login : Form
    {
        Validaciones vd = new Validaciones();
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if(Txt_Ruc.Text.Trim() == "" && Txt_Pass.Text.Trim() == "")
            {
                MessageBox.Show("Los campos están vacíos","Error");
            }
            else
            {
                string query="SELECT * FROM Usuarios WHERE Ruc=@ruc AND password=@pass";
                SQLiteConnection conn = new SQLiteConnection("Data Source=Login.db; Version=3;");
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@ruc",Txt_Ruc.Text);
                cmd.Parameters.AddWithValue("@pass", Txt_Pass.Text);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Usted ha ingresado correctamente", "Loggeo Exitoso");
                    Formularios frm = new Formularios();
                    frm.ShowDialog();
                    conn.Close();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto", "Error");
                }


            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Ruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            vd.Numeros(e);
        }
    }
}
