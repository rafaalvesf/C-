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
    public partial class alterar_a_senha : Form
    {
        public alterar_a_senha()
        {
            InitializeComponent();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chamsDataSet1);

        }

        private void alterar_a_senha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamsDataSet1.usuario' table. You can move, or remove it, as needed.
            this.usuarioTableAdapter.Fill(this.chamsDataSet1.usuario);

        }

        private void perfilLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
