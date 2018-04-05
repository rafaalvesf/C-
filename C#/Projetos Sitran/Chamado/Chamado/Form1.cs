using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chamado
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConn = null;
        private string strCoon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rafael.ferreira\source\repos\Chamado\Chamado\chams.mdf;Integrated Security=True;Connect Timeout=30";
        private string _Sql = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        public void logar()
        {
            sqlConn = new SqlConnection(strCoon);
            string usu, pwd;

            try
            {
                usu = textBoxUsuario.Text;
                pwd = textBoxSenha.Text;

                _Sql = "SELECT COUNT(usuario)FROM usuario WHERE usuario = @usuario AND senha = @Senha";

                SqlCommand cmd = new SqlCommand(_Sql,sqlConn);

                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu;
                cmd.Parameters.Add("@Senha", SqlDbType.VarChar).Value = pwd;

                sqlConn.Open();

                int v = (int)cmd.ExecuteScalar();

                if(v > 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha incorretos. ");
                }
            }
            catch(SqlException errro)
            {
                MessageBox.Show(errro+"  No Banco  ");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            logar();
        }
    }
}
