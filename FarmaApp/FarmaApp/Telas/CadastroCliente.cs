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

namespace Views.Telas
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
            {
                var con = new OperacoesBD();
                var listaCliente = con.ListaCliente();
                dataGridViewClientes.DataSource = listaCliente;
            }
            catch (Exception)
            {
                throw;
            }*/
        }

        public void testeDB()
        {
            OperacoesBD obj = new OperacoesBD();
            /*ArrayList array = new ArrayList();
                      
            array.Add("Jordana 5");
            array.Add(24);
            array.Add("teste rua23");
            array.Add(14);
            array.Add("centro12");
            array.Add("mariliaS");
            array.Add("CE");
            array.Add(02);

            int codCliente = 1;

            if (obj.Delete(codCliente))
            {
               MessageBox.Show("Deletado com Sucesso");
            }
            else
            {
                MessageBox.Show("Falha ao Deletar o Cliente");
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testeDB();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            testeDB();

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            testeDB();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
           

        }

        //mostrando as informações de cliente na DataGridView
        private void tabCliente_Enter(object sender, EventArgs e)
        {
            try
            {
                var con = new OperacoesBD();
                dataGridViewClientes.DataSource = con.ListGrid();                
            }
            catch (Exception)
            {
                throw;
            }
        }
    }    
}
