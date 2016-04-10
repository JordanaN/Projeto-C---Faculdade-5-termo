namespace Views.Telas
{
    partial class CadastrarUsuario
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
            this.btSalvarUser = new System.Windows.Forms.Button();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.lblSenhaUser = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.btCancelarUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSalvarUser
            // 
            this.btSalvarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvarUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvarUser.Location = new System.Drawing.Point(95, 107);
            this.btSalvarUser.Name = "btSalvarUser";
            this.btSalvarUser.Size = new System.Drawing.Size(78, 27);
            this.btSalvarUser.TabIndex = 0;
            this.btSalvarUser.Text = "Salvar";
            this.btSalvarUser.UseVisualStyleBackColor = true;
            this.btSalvarUser.Click += new System.EventHandler(this.btSalvarUser_Click);
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.Location = new System.Drawing.Point(29, 42);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(42, 16);
            this.lblNomeUser.TabIndex = 1;
            this.lblNomeUser.Text = "Nome";
            // 
            // lblSenhaUser
            // 
            this.lblSenhaUser.AutoSize = true;
            this.lblSenhaUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaUser.Location = new System.Drawing.Point(29, 82);
            this.lblSenhaUser.Name = "lblSenhaUser";
            this.lblSenhaUser.Size = new System.Drawing.Size(45, 16);
            this.lblSenhaUser.TabIndex = 2;
            this.lblSenhaUser.Text = "Senha";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUser.Location = new System.Drawing.Point(95, 39);
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(164, 22);
            this.txtNomeUser.TabIndex = 3;
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUser.Location = new System.Drawing.Point(95, 79);
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.PasswordChar = '*';
            this.txtSenhaUser.Size = new System.Drawing.Size(164, 22);
            this.txtSenhaUser.TabIndex = 4;
            // 
            // btCancelarUser
            // 
            this.btCancelarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelarUser.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelarUser.Location = new System.Drawing.Point(179, 107);
            this.btCancelarUser.Name = "btCancelarUser";
            this.btCancelarUser.Size = new System.Drawing.Size(78, 27);
            this.btCancelarUser.TabIndex = 5;
            this.btCancelarUser.Text = "Cancelar";
            this.btCancelarUser.UseVisualStyleBackColor = true;
            this.btCancelarUser.Click += new System.EventHandler(this.btCancelarUser_Click);
            // 
            // CadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(284, 171);
            this.Controls.Add(this.btCancelarUser);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.lblSenhaUser);
            this.Controls.Add(this.lblNomeUser);
            this.Controls.Add(this.btSalvarUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvarUser;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.Label lblSenhaUser;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.Button btCancelarUser;
    }
}