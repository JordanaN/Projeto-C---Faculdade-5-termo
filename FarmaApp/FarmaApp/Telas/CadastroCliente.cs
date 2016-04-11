using Banco;
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Classes;
using System.Data.SqlClient;

namespace Views.Telas
{
    public partial class CadastroCliente : Form
    {
        Cliente cliente = new Cliente();
        OperacoesBD objConn = new OperacoesBD();

        public CadastroCliente()
        {
            InitializeComponent();
        }

        //Botão Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
                    
            try
            {
                Cliente cliente = new Cliente();

                cliente.Nome = txtNome.Text;
                cliente.Idade = Convert.ToInt32(txtIdade.Text);
                cliente.Email = txtEmail.Text;
                cliente.Rua = txtRua.Text;
                cliente.Numero = Convert.ToInt32(txtNumero.Text);
                cliente.Bairro = txtBairro.Text;
                cliente.Cidade = txtCidade.Text;
                cliente.Estado = CBEstado.Text;

                var retorno = objConn.Insert(cliente);               

                if (retorno == true)
                {
                    MessageBox.Show("Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao Cadastrar Cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                limpar();
            }
            catch(SqlException)
            {
                throw;
            }
        }

        //botão cancelar tabPageSalvar
        private void btCancelarAlterar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botão Excluir
        private void btDeletar_Click(object sender, EventArgs e)
        {
            try {
                Cliente c = new Cliente(); 
                c.id_Cliente = Convert.ToInt32(tbCodigoDelete.Text);
                var retorno = objConn.Delete(c);               
                tbCodigoDelete.Text = (" ");                
                dataGridViewDelete.DataSource = objConn.ListaCliente(); 

                if (retorno == true)
                {
                    MessageBox.Show("Deletado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao Deletar Cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(SqlException)
            {
                throw;
            }
        }

        //botão cancelar tabPageDeletar
        private void btCancelarDeletar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        //botão Pesquisar
        private void btPesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                var pesq = tbValorPes.Text;

                if ((tbValorPes.Text.Length) < 0)
                {
                    this.tbValorPes.Focus();
                    MessageBox.Show("Inserir Nome a ser pesquisado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var pesquisaNome = objConn.PesquisaNome(pesq);
                    dataGridViewClientes.DataSource = pesquisaNome;
                }

            }
            catch (SqlException)
            {
                throw;
            }


        }

        //botão Cancelar tabPagePesquisar
        private void btCancelartabPesquisar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //DataGridView Aba Deletar cliente
        private void tabPageDeletar_Enter(object sender, EventArgs e)
        {
            var lista1 = objConn.ListaCliente();
            dataGridViewDelete.DataSource = lista1;

        }

        //DataGridView Aba pesquisar cliente 
        private void dataGridViewClientes_Enter(object sender, EventArgs e)
        {
            var lista1 = objConn.ListaCliente();
            dataGridViewClientes.DataSource = lista1;
        }                     

        //evento para chamar a tela de alterar cliente
        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {  
            var row = dataGridViewClientes.CurrentRow;
            AlterarCliente alt = new AlterarCliente();
            var txtCodigo = alt.Controls["lblCodigo"];
            var txtNome = alt.Controls["txtNomeAlt"];
            var txtIdade = alt.Controls["txtIdadeAlt"];
            var txtEmail = alt.Controls["txtEmailAlt"];
            var txtRua = alt.Controls["txtRuaAlt"];
            var txtNumero = alt.Controls["txtNumeroAlt"];
            var txtBairro = alt.Controls["txtBairroAlt"];
            var txtCidade = alt.Controls["txtCidadeAlt"];
            var txtEstado = alt.Controls["CBEstadoAlt"];

            txtCodigo.Text = row.Cells[0].Value.ToString();
            txtNome.Text = row.Cells[1].Value.ToString();
            txtIdade.Text = row.Cells[2].Value.ToString();
            txtEmail.Text = row.Cells[3].Value.ToString();
            txtRua.Text = row.Cells[4].Value.ToString();           
            txtBairro.Text = row.Cells[5].Value.ToString();
            txtCidade.Text = row.Cells[6].Value.ToString();
            txtNumero.Text = row.Cells[7].Value.ToString();
            txtEstado.Text = row.Cells[8].Value.ToString();

            if(alt.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                row.Cells[0].Value = txtCodigo.Text;
                row.Cells[1].Value = txtNome.Text;
                row.Cells[2].Value = txtIdade.Text;
                row.Cells[3].Value = txtEmail.Text;
                row.Cells[4].Value = txtRua.Text;                
                row.Cells[5].Value = txtBairro.Text;
                row.Cells[6].Value = txtCidade.Text;
                row.Cells[7].Value = txtNumero.Text;
                row.Cells[8].Value = txtEstado.Text;                
            }

        }

        //metodo para limpar campos
        private void limpar()
        {
            txtNome.Text = String.Empty;
            txtIdade.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtRua.Text = String.Empty;
            CBEstado.Text = String.Empty;
        }
      
    }
}
