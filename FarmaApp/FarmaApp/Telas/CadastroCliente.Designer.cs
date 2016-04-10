using System;

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
            this.tabPageListar = new System.Windows.Forms.TabPage();
            this.btCancelartabPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbValorPes = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.tabPageDeletar = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btCancelarDeletar = new System.Windows.Forms.Button();
            this.tbCodigoDelete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDeletar = new System.Windows.Forms.Button();
            this.dataGridViewDelete = new System.Windows.Forms.DataGridView();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.btCancelarAlterar = new System.Windows.Forms.Button();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.tabCliente = new System.Windows.Forms.TabControl();
            this.tabPageListar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.tabPageDeletar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).BeginInit();
            this.tabPageAdd.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageListar
            // 
            this.tabPageListar.Controls.Add(this.btCancelartabPesquisar);
            this.tabPageListar.Controls.Add(this.groupBox1);
            this.tabPageListar.Controls.Add(this.dataGridViewClientes);
            this.tabPageListar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageListar.Location = new System.Drawing.Point(4, 27);
            this.tabPageListar.Name = "tabPageListar";
            this.tabPageListar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListar.Size = new System.Drawing.Size(704, 384);
            this.tabPageListar.TabIndex = 3;
            this.tabPageListar.Text = "Pesquisar Cliente";
            this.tabPageListar.UseVisualStyleBackColor = true;
            this.tabPageListar.Enter += new System.EventHandler(this.dataGridViewClientes_Enter);
            // 
            // btCancelartabPesquisar
            // 
            this.btCancelartabPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelartabPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelartabPesquisar.Location = new System.Drawing.Point(592, 343);
            this.btCancelartabPesquisar.Name = "btCancelartabPesquisar";
            this.btCancelartabPesquisar.Size = new System.Drawing.Size(99, 35);
            this.btCancelartabPesquisar.TabIndex = 6;
            this.btCancelartabPesquisar.Text = "Cancelar";
            this.btCancelartabPesquisar.UseVisualStyleBackColor = true;
            this.btCancelartabPesquisar.Click += new System.EventHandler(this.btCancelartabPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbValorPes);
            this.groupBox1.Controls.Add(this.btPesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite nome para pesquisa:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbValorPes
            // 
            this.tbValorPes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValorPes.Location = new System.Drawing.Point(6, 61);
            this.tbValorPes.Name = "tbValorPes";
            this.tbValorPes.Size = new System.Drawing.Size(370, 25);
            this.tbValorPes.TabIndex = 3;
            // 
            // btPesquisar
            // 
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPesquisar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Location = new System.Drawing.Point(382, 55);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(99, 35);
            this.btPesquisar.TabIndex = 1;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewClientes.Location = new System.Drawing.Point(6, 135);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(685, 202);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellDoubleClick);
            this.dataGridViewClientes.Enter += new System.EventHandler(this.dataGridViewClientes_Enter);
            // 
            // tabPageDeletar
            // 
            this.tabPageDeletar.Controls.Add(this.groupBox3);
            this.tabPageDeletar.Controls.Add(this.dataGridViewDelete);
            this.tabPageDeletar.Location = new System.Drawing.Point(4, 27);
            this.tabPageDeletar.Name = "tabPageDeletar";
            this.tabPageDeletar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDeletar.Size = new System.Drawing.Size(704, 384);
            this.tabPageDeletar.TabIndex = 2;
            this.tabPageDeletar.Text = "Deletar Cliente";
            this.tabPageDeletar.UseVisualStyleBackColor = true;
            this.tabPageDeletar.Enter += new System.EventHandler(this.tabPageDeletar_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btCancelarDeletar);
            this.groupBox3.Controls.Add(this.tbCodigoDelete);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btDeletar);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(682, 111);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Excluir Cliente";
            // 
            // btCancelarDeletar
            // 
            this.btCancelarDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelarDeletar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarDeletar.Location = new System.Drawing.Point(225, 44);
            this.btCancelarDeletar.Name = "btCancelarDeletar";
            this.btCancelarDeletar.Size = new System.Drawing.Size(99, 35);
            this.btCancelarDeletar.TabIndex = 2;
            this.btCancelarDeletar.Text = "Cancelar";
            this.btCancelarDeletar.UseVisualStyleBackColor = true;
            this.btCancelarDeletar.Click += new System.EventHandler(this.btCancelarDeletar_Click);
            // 
            // tbCodigoDelete
            // 
            this.tbCodigoDelete.Location = new System.Drawing.Point(19, 50);
            this.tbCodigoDelete.Name = "tbCodigoDelete";
            this.tbCodigoDelete.Size = new System.Drawing.Size(95, 25);
            this.tbCodigoDelete.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código do Aluno";
            // 
            // btDeletar
            // 
            this.btDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDeletar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletar.Location = new System.Drawing.Point(120, 44);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(99, 35);
            this.btDeletar.TabIndex = 0;
            this.btDeletar.Text = "Excluir";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // dataGridViewDelete
            // 
            this.dataGridViewDelete.AllowUserToAddRows = false;
            this.dataGridViewDelete.AllowUserToDeleteRows = false;
            this.dataGridViewDelete.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelete.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewDelete.Location = new System.Drawing.Point(6, 135);
            this.dataGridViewDelete.Name = "dataGridViewDelete";
            this.dataGridViewDelete.ReadOnly = true;
            this.dataGridViewDelete.Size = new System.Drawing.Size(682, 238);
            this.dataGridViewDelete.TabIndex = 1;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.btCancelarAlterar);
            this.tabPageAdd.Controls.Add(this.CBEstado);
            this.tabPageAdd.Controls.Add(this.lblEstado);
            this.tabPageAdd.Controls.Add(this.txtCidade);
            this.tabPageAdd.Controls.Add(this.txtBairro);
            this.tabPageAdd.Controls.Add(this.txtNumero);
            this.tabPageAdd.Controls.Add(this.txtRua);
            this.tabPageAdd.Controls.Add(this.txtEmail);
            this.tabPageAdd.Controls.Add(this.txtIdade);
            this.tabPageAdd.Controls.Add(this.txtNome);
            this.tabPageAdd.Controls.Add(this.lblCidade);
            this.tabPageAdd.Controls.Add(this.lblBairro);
            this.tabPageAdd.Controls.Add(this.lblNumero);
            this.tabPageAdd.Controls.Add(this.lblRua);
            this.tabPageAdd.Controls.Add(this.lblEmail);
            this.tabPageAdd.Controls.Add(this.lblIdade);
            this.tabPageAdd.Controls.Add(this.lblNome);
            this.tabPageAdd.Controls.Add(this.btSalvar);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 27);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(704, 384);
            this.tabPageAdd.TabIndex = 0;
            this.tabPageAdd.Text = "Adicionar Cliente";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // btCancelarAlterar
            // 
            this.btCancelarAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelarAlterar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarAlterar.Location = new System.Drawing.Point(598, 348);
            this.btCancelarAlterar.Name = "btCancelarAlterar";
            this.btCancelarAlterar.Size = new System.Drawing.Size(99, 35);
            this.btCancelarAlterar.TabIndex = 19;
            this.btCancelarAlterar.Text = "Cancelar";
            this.btCancelarAlterar.UseVisualStyleBackColor = true;
            this.btCancelarAlterar.Click += new System.EventHandler(this.btCancelarAlterar_Click);
            // 
            // CBEstado
            // 
            this.CBEstado.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MS",
            "MT",
            "MA",
            "MG",
            "PB",
            "PA",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SP",
            "SC",
            "SE",
            "TO"});
            this.CBEstado.Location = new System.Drawing.Point(622, 191);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(75, 28);
            this.CBEstado.TabIndex = 18;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(619, 175);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 16);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(372, 191);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(244, 25);
            this.txtCidade.TabIndex = 15;
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(23, 191);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(340, 25);
            this.txtBairro.TabIndex = 13;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(619, 141);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(78, 25);
            this.txtNumero.TabIndex = 11;
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(23, 141);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(590, 25);
            this.txtRua.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(83, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(614, 25);
            this.txtEmail.TabIndex = 7;
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(23, 88);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(51, 25);
            this.txtIdade.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(23, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(674, 25);
            this.txtNome.TabIndex = 2;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(369, 175);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(45, 16);
            this.lblCidade.TabIndex = 14;
            this.lblCidade.Text = "Cidade";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(23, 175);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 16);
            this.lblBairro.TabIndex = 12;
            this.lblBairro.Text = "Bairro";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(619, 125);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(49, 16);
            this.lblNumero.TabIndex = 10;
            this.lblNumero.Text = "Numero";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(23, 125);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(29, 16);
            this.lblRua.TabIndex = 8;
            this.lblRua.Text = "Rua";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(80, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(23, 69);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(38, 16);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "Idade";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(23, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 16);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // btSalvar
            // 
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(493, 348);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(99, 35);
            this.btSalvar.TabIndex = 0;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.tabPageAdd);
            this.tabCliente.Controls.Add(this.tabPageDeletar);
            this.tabCliente.Controls.Add(this.tabPageListar);
            this.tabCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCliente.Location = new System.Drawing.Point(12, 12);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(712, 415);
            this.tabCliente.TabIndex = 1;
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 430);
            this.Controls.Add(this.tabCliente);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            //this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.tabPageListar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.tabPageDeletar.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelete)).EndInit();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.tabCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabPage tabPageListar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValorPes;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.TabPage tabPageDeletar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbCodigoDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.DataGridView dataGridViewDelete;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TabControl tabCliente;
        private System.Windows.Forms.Button btCancelarAlterar;
        private System.Windows.Forms.Button btCancelarDeletar;
        private System.Windows.Forms.Button btCancelartabPesquisar;
    }
}