namespace livretas
{
    partial class Livreta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livreta));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label grupoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            this.livretasDataSet1 = new livretas.livretasDataSet1();
            this.grupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grupoTableAdapter = new livretas.livretasDataSet1TableAdapters.grupoTableAdapter();
            this.tableAdapterManager = new livretas.livretasDataSet1TableAdapters.TableAdapterManager();
            this.grupoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.grupoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.grupoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            grupoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.livretasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingNavigator)).BeginInit();
            this.grupoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // livretasDataSet1
            // 
            this.livretasDataSet1.DataSetName = "livretasDataSet1";
            this.livretasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grupoBindingSource
            // 
            this.grupoBindingSource.DataMember = "grupo";
            this.grupoBindingSource.DataSource = this.livretasDataSet1;
            // 
            // grupoTableAdapter
            // 
            this.grupoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.grupoTableAdapter = this.grupoTableAdapter;
            this.tableAdapterManager.UpdateOrder = livretas.livretasDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // grupoBindingNavigator
            // 
            this.grupoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.grupoBindingNavigator.BindingSource = this.grupoBindingSource;
            this.grupoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.grupoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.grupoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.grupoBindingNavigatorSaveItem});
            this.grupoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.grupoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.grupoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.grupoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.grupoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.grupoBindingNavigator.Name = "grupoBindingNavigator";
            this.grupoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.grupoBindingNavigator.Size = new System.Drawing.Size(308, 25);
            this.grupoBindingNavigator.TabIndex = 0;
            this.grupoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // grupoBindingNavigatorSaveItem
            // 
            this.grupoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.grupoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("grupoBindingNavigatorSaveItem.Image")));
            this.grupoBindingNavigatorSaveItem.Name = "grupoBindingNavigatorSaveItem";
            this.grupoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.grupoBindingNavigatorSaveItem.Text = "Save Data";
            this.grupoBindingNavigatorSaveItem.Click += new System.EventHandler(this.grupoBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(34, 48);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(96, 45);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // grupoLabel
            // 
            grupoLabel.AutoSize = true;
            grupoLabel.Location = new System.Drawing.Point(34, 74);
            grupoLabel.Name = "grupoLabel";
            grupoLabel.Size = new System.Drawing.Size(37, 13);
            grupoLabel.TabIndex = 3;
            grupoLabel.Text = "grupo:";
            // 
            // grupoTextBox
            // 
            this.grupoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "grupo", true));
            this.grupoTextBox.Location = new System.Drawing.Point(96, 71);
            this.grupoTextBox.Name = "grupoTextBox";
            this.grupoTextBox.Size = new System.Drawing.Size(100, 20);
            this.grupoTextBox.TabIndex = 4;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(34, 100);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(56, 13);
            descricaoLabel.TabIndex = 5;
            descricaoLabel.Text = "descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(96, 97);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 6;
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(34, 126);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(44, 13);
            usuarioLabel.TabIndex = 7;
            usuarioLabel.Text = "usuario:";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(96, 123);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.usuarioTextBox.TabIndex = 8;
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(34, 152);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(39, 13);
            senhaLabel.TabIndex = 9;
            senhaLabel.Text = "senha:";
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.grupoBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(96, 149);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(100, 20);
            this.senhaTextBox.TabIndex = 10;
            // 
            // Livreta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 290);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(grupoLabel);
            this.Controls.Add(this.grupoTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.grupoBindingNavigator);
            this.Name = "Livreta";
            this.Text = "Livreta";
            this.Load += new System.EventHandler(this.Livreta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livretasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grupoBindingNavigator)).EndInit();
            this.grupoBindingNavigator.ResumeLayout(false);
            this.grupoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private livretasDataSet1 livretasDataSet1;
        private System.Windows.Forms.BindingSource grupoBindingSource;
        private livretasDataSet1TableAdapters.grupoTableAdapter grupoTableAdapter;
        private livretasDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator grupoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton grupoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox grupoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
    }
}

