using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace livretas
{
    public partial class Livreta : Form
    {
        public Livreta()
        {
            InitializeComponent();
        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.grupoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.livretasDataSet1);

        }

        private void Livreta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'livretasDataSet1.grupo' table. You can move, or remove it, as needed.
            this.grupoTableAdapter.Fill(this.livretasDataSet1.grupo);

        }
    }
}
