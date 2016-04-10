using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco;
using Domain.Classes;
using System.Data.SqlClient;

namespace Views
{
    public partial class TelaLogin : Form
    {
        OperacoesBD objCon = new OperacoesBD();
        public bool logado = false;

        public TelaLogin()
        {
            InitializeComponent();
        }

        //metodo de autenticação de login com o Banco
        public void logar()
        {   
            string nomeUser, senhaUser;
            try
            {
                nomeUser = txtLogin.Text;
                senhaUser = txtSenha.Text;

                var sql = "SELECT COUNT(ID) FROM USUARIO WHERE NOME = @NOME AND SENHA = @SENHA";

                SqlCommand cmd = new SqlCommand(sql, objCon.conectar());
                cmd.Parameters.Add("@NOME", SqlDbType.VarChar).Value = nomeUser;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senhaUser;

                int v = (int)cmd.ExecuteScalar();

                if (v > 0)
                {
                    MessageBox.Show("Logado com sucesso");
                    
                }
                else
                {
                    MessageBox.Show("Erro ao Logar");
                    Application.Exit(); 
                }               
            }
            catch (SqlException)
            {
                throw;
            }
        }


        private void BtSair_Click(object sender, EventArgs e)
        {           
            Application.Exit();
        }

        //botão Logar
        private void BtAcessar_Click(object sender, EventArgs e)
        {
            logar();
            Telas.SistemaFarmaApp telaPrincipal = new Telas.SistemaFarmaApp();
            telaPrincipal.Show();            
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
           
        
        }

        //Botão Cadastrar usuario
        private void btCadastrarUser_Click(object sender, EventArgs e)
        {
            Telas.CadastrarUsuario cadastrarUser = new Telas.CadastrarUsuario();
            cadastrarUser.Show();
        }

        //metodo de logar com o Enter
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                logar();
                Telas.SistemaFarmaApp telaPrincipal = new Telas.SistemaFarmaApp();
                telaPrincipal.Show();
            }
        }
    }
}
