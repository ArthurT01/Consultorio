using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultorio
{
    public partial class frmCadastro : Form
    {
        int codigoId = 0;
        
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
            txtNome.Text = "";
            mtBoxCpf.Text = "";
            mtBoxTelefone.Text = "";
            mtBoxCep.Text = "";
            gpBoxSexo.Text = "";
            rdBtnMasc.Checked = false;
            rdBtnFem.Checked = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //string nome = txtNome.Text;
            //string cpf = mtBoxCpf.Text;
            //string telefone = mtBoxTelefone.Text;
            //string cep = mtBoxCep.Text;
            


            if (!mtBoxCep.MaskCompleted || !mtBoxCpf.MaskCompleted || !mtBoxTelefone.MaskCompleted || gpBoxSexo.Text == "" || txtNome.Text == "")
            {
                string msg = "Dados Incompletos!";
                string titulo = "AVISO";
                var result = MessageBox.Show(msg, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                dtGrid01.Rows.Add(txtID.Text, txtNome.Text, mtBoxCpf.Text, mtBoxTelefone.Text, mtBoxCep.Text, gpBoxSexo.Text);
                codigoId += 1;
                txtID.Text = codigoId.ToString();
            }
                    

        }

        private void rdBtnMasc_CheckedChanged(object sender, EventArgs e)
        {
            gpBoxSexo.Text = "Masculino";
        }

        private void rdBtnFem_CheckedChanged(object sender, EventArgs e)
        {
            gpBoxSexo.Text = "Feminino";
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            codigoId += 1;
            txtID.Text = codigoId.ToString();
            
        }
    }   
}
