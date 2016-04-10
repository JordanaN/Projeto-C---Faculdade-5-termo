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
    public partial class AlterarCliente : Form
    {
        OperacoesBD objConn = new OperacoesBD();
        public AlterarCliente()
        {
            InitializeComponent();
        }

        private void CancelarAlt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();
                cliente.id_Cliente = Convert.ToInt32(lblCodigo.Text);
                cliente.Nome = txtNomeAlt.Text;
                cliente.Idade = Convert.ToInt32(txtIdadeAlt.Text);
                cliente.Email = txtEmailAlt.Text;
                cliente.Rua = txtRuaAlt.Text;
                cliente.Numero = Convert.ToInt32(txtNumeroAlt.Text);
                cliente.Bairro = txtBairroAlt.Text;
                cliente.Cidade = txtCidadeAlt.Text;
                cliente.Estado = CBEstadoAlt.Text;

                var retorno = objConn.Update(cliente);
                DialogResult = DialogResult.OK;

                if (retorno == true)
                {
                    MessageBox.Show("Alterado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Falha ao Alterar Cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
    }
}

