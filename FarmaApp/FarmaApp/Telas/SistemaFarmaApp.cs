using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Views.Telas
{
    public partial class SistemaFarmaApp : Form
    {
        public SistemaFarmaApp()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Colocando Data e Hora no Rodapé da Tela
            DateTime dataHora = DateTime.Now;
            lblDataTime.Text = "Data: " + dataHora.ToShortDateString() + "Hora: " + dataHora.ToLongTimeString();
        }

        private void telaInicial(object sender, EventArgs e)
        {
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {           
            CadastroCliente cadCliente = new CadastroCliente();
            cadCliente.Show();
                     
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cadastro_de_Produtos cadProduto = new Cadastro_de_Produtos();
            cadProduto.Show();
        }

        private void SistemaFarmaApp_Load(object sender, EventArgs e)
        {
            timer1_Tick(e, e);

            Banco.ConexaoDB testConn = new Banco.ConexaoDB();

            testConn.conectar();
        }

        private void btSairTelaPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
