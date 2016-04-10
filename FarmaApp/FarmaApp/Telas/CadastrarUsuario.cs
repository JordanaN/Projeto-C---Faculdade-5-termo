using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Classes;
using System.Data.SqlClient;
using Banco;

namespace Views.Telas
{
    public partial class CadastrarUsuario : Form
    {
        OperacoesBD objCon = new OperacoesBD();        

        public CadastrarUsuario()
        {
            InitializeComponent();
        }

        private void btCancelarUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvarUser_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario user = new Usuario();
                user.Nome = txtNomeUser.Text;
                user.Senha = txtSenhaUser.Text;


                var retorno = objCon.InsertUser(user);
                if (retorno == true)
                {
                    limparCampos();
                    MessageBox.Show("Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao Cadastrar Usuario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            catch (SqlException)
            {
                throw;
            }

        }

        public void limparCampos()
        {
            txtNomeUser.Text = String.Empty;
            txtSenhaUser.Text = String.Empty;
        }
    }
}
