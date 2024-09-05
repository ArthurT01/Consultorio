using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string nome;
            string senha;
            string nomeCadastrado = "123";
            string senhaCadastrada = "123";

            nome = txtNome.Text;
            senha = txtSenha.Text;

            if(nome == nomeCadastrado && senha == senhaCadastrada)
            {
                frmCadastro frm = new frmCadastro();
                frm.ShowDialog();
            }
            else
            {
                string msg = "Dados Incorretos";
                string titulo = "Erro";
                var result = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
