using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Views
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {           
            Application.Exit();
        }

        private void BtAcessar_Click(object sender, EventArgs e)
        {
            Telas.SistemaFarmaApp telaPrincipal = new Telas.SistemaFarmaApp();
            telaPrincipal.Show();          
            
            //Verificando o Login - Refazer com o banco
            //if((txtLogin.Text == "Fulano") && (txtSenha.Text == "1234"))
            //{
            //    MessageBox.Show("Você foi logado com sucesso");
            //    //Mostrando a tela Inicial
            //    Views.Telas.SistemaFarmaApp cadastro = new Views.Telas.SistemaFarmaApp();


            //    cadastro.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Login ou Senha não estão corretos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
           
        
        }
    }
}
