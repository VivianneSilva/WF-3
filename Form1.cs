using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace WF_3
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncriar_Click(object sender, EventArgs e)
        {
            string pastaCriada = @"C:\" + txtPastaCriada.Text;
            if (Directory.Exists(pastaCriada))
            {
                
                MessageBox.Show("Esta pasta já existe", "", MessageBoxButtons.OK);
            }
            else
            {
                Directory.CreateDirectory(pastaCriada);
                MessageBox.Show("Pasta criada");
               
                txtPastaCriada.Clear();
               
            }
            

        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            string pastaDeletada = @"C:\" + txtDeletarArquivo.Text;
            if (!Directory.Exists(pastaDeletada))
            {
                MessageBox.Show("Pasta não Existe");
            }
            else
            {
                Directory.Delete(pastaDeletada);
                MessageBox.Show("Pasta Deletada!");
                txtDeletarArquivo.Clear();
               
                
                
            }
        }

        private void btnmover_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                string Origem = Path.Combine(@"C:\" + txtPastaOrigem.Text, txtArquivoOrigem.Text);
                string destino = Path.Combine(@"C:\" + txtPastaDestino.Text, txtArquivoOrigem.Text);

                File.Move(Origem, destino);
                MessageBox.Show("Movido com sucesso!");
                txtArquivoOrigem.Clear();
                txtPastaDestino.Clear();
                txtPastaOrigem.Clear();
              

                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
