using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaiorMenor6Csharp
{
    public partial class frmMaiorde6 : Form
    {
        int n1, n2, n3, n4, n5, n6, maior = 0;

        private void txtNum2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtNum3.Focus();
            }
        }

        private void txtNum3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtNum4.Focus();
            }
        }

        private void txtNum4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtNum5.Focus();
            }
        }

        private void txtNum5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtNum6.Focus();
            }
        }

        private void txtNum6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnVerifica.Focus();
            }
        }

        private void btnCanclar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Deseja realmene fechar a aplicação ?", "Fechar", MessageBoxButtons.YesNo,MessageBoxIcon.Question) ==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtNum1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                txtNum2.Focus();
            }
        }

        string mensagem = " ";
        public frmMaiorde6()
        {
            InitializeComponent();
        }

        #region "Entrada de dados"
        private void btnVerifica_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = int.Parse(txtNum1.Text);
                n2 = int.Parse(txtNum2.Text);
                n3 = int.Parse(txtNum3.Text);
                n4 = int.Parse(txtNum4.Text);
                n5 = int.Parse(txtNum5.Text);
                n6 = int.Parse(txtNum6.Text);
                Testar();
                lblResultado.Text = mensagem;
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message + "\nSequência  de entrada não está em um formato correto...\nTente novamente...", 
                    "***** ERRO *****",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    Cancelar();
            }
        }


        #endregion
        #region Procedimento Testar
        public void Testar ()
        {
            if(n1>n2 && n1>n3 && n1>n4 && n1> n5 && n1 >n6)
            {
                maior = n1;
                mensagem = "O maior número é " + maior.ToString();
            }
            else if(n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5 && n2 > n6)
            {
                maior = n2;
                mensagem = "O maior número é " + maior.ToString();
            }

            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5 && n3 > n6)
            {
                maior = n3;
                mensagem = "O maior número é " + maior.ToString();
            }

            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5 && n4 > n6)
            {
                maior = n4;
                mensagem = "O maior número é " + maior.ToString();
            }

            else if (n5 > n1 && n5 > n2 && n5 > n3 && n5 > n4 && n5 > n6)
            {
                maior = n5;
                mensagem = "O maior número é " + maior.ToString();
            }

            else if (n6 > n1 && n6 > n2 && n6 > n3 && n6 > n4 && n6 > n5)
            {
                maior = n6;
                mensagem = "O maior número é " + maior.ToString();
            }

            else if (n1 == n2 && n3 == n4 && n5 == n6)
            {
                
                mensagem = "Todos os números são iguais";
            }

            else if (n1 == n2 || n3 == n4 || n5 == n6)
            {

                mensagem = "Existem números iguais na sequência";
            }
        }
        #endregion

        #region Procedimento Cancelar
        public void Cancelar()
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
            txtNum4.Clear();
            txtNum5.Clear();
            txtNum6.Clear();
            lblResultado.Text = "";
            txtNum1.Focus();
        }
        #endregion
    }
}
