namespace Views.Telas
{
    partial class CadastroCliente
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.tabCliente = new System.Windows.Forms.TabControl();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.tabPageAlterar = new System.Windows.Forms.TabPage();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.tabPageDeletar = new System.Windows.Forms.TabPage();
            this.btDeletar = new System.Windows.Forms.Button();
            this.tabPageListar = new System.Windows.Forms.TabPage();
            this.btListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.tabCliente.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.tabPageAlterar.SuspendLayout();
            this.tabPageDeletar.SuspendLayout();
            this.tabPageListar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.GridColor = System.Drawing.Color.White;
            this.dataGridViewClientes.Location = new System.Drawing.Point(6, 129);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(685, 179);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.tabPageAdd);
            this.tabCliente.Controls.Add(this.tabPageAlterar);
            this.tabCliente.Controls.Add(this.tabPageDeletar);
            this.tabCliente.Controls.Add(this.tabPageListar);
            this.tabCliente.Location = new System.Drawing.Point(12, 12);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(705, 369);
            this.tabCliente.TabIndex = 1;
            this.tabCliente.Enter += new System.EventHandler(this.tabCliente_Enter);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.btSalvar);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(697, 172);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Adicionar Cliente";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // tabPageAlterar
            // 
            this.tabPageAlterar.Controls.Add(this.btAlterar);
            this.tabPageAlterar.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlterar.Name = "tabPageAlterar";
            this.tabPageAlterar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlterar.Size = new System.Drawing.Size(697, 172);
            this.tabPageAlterar.TabIndex = 1;
            this.tabPageAlterar.Text = "Alterar Cliente";
            this.tabPageAlterar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(616, 143);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(616, 143);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 0;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // tabPageDeletar
            // 
            this.tabPageDeletar.Controls.Add(this.btDeletar);
            this.tabPageDeletar.Location = new System.Drawing.Point(4, 22);
            this.tabPageDeletar.Name = "tabPageDeletar";
            this.tabPageDeletar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeletar.Size = new System.Drawing.Size(697, 172);
            this.tabPageDeletar.TabIndex = 2;
            this.tabPageDeletar.Text = "Deletar Cliente";
            this.tabPageDeletar.UseVisualStyleBackColor = true;
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(616, 143);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 0;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // tabPageListar
            // 
            this.tabPageListar.Controls.Add(this.btListar);
            this.tabPageListar.Controls.Add(this.dataGridViewClientes);
            this.tabPageListar.Location = new System.Drawing.Point(4, 22);
            this.tabPageListar.Name = "tabPageListar";
            this.tabPageListar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListar.Size = new System.Drawing.Size(697, 343);
            this.tabPageListar.TabIndex = 3;
            this.tabPageListar.Text = "Listar Cliente";
            this.tabPageListar.UseVisualStyleBackColor = true;
            // 
            // btListar
            // 
            this.btListar.Location = new System.Drawing.Point(570, 314);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(121, 23);
            this.btListar.TabIndex = 1;
            this.btListar.Text = "Listar Clientes";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 386);
            this.Controls.Add(this.tabCliente);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.tabCliente.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAlterar.ResumeLayout(false);
            this.tabPageDeletar.ResumeLayout(false);
            this.tabPageListar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.TabControl tabCliente;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TabPage tabPageAlterar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.TabPage tabPageDeletar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.TabPage tabPageListar;
        private System.Windows.Forms.Button btListar;
    }
}