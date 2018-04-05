using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chamado
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void passwordChsngeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterar_a_senha abrir = new alterar_a_senha();
            abrir.Show();
        }
    }
}
