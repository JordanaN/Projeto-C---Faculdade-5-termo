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
       

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {           
            CadastroCliente cadCliente = new CadastroCliente();
            cadCliente.Show();
                     
        }
               

        private void SistemaFarmaApp_Load(object sender, EventArgs e)
        {
                     
        }

        private void btSairTelaPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
