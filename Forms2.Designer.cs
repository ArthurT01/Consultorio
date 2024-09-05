namespace Consultorio
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.mtBoxCep = new System.Windows.Forms.MaskedTextBox();
            this.gpBoxSexo = new System.Windows.Forms.GroupBox();
            this.rdBtnFem = new System.Windows.Forms.RadioButton();
            this.rdBtnMasc = new System.Windows.Forms.RadioButton();
            this.dtGrid01 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtBoxCpf = new System.Windows.Forms.MaskedTextBox();
            this.mtBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.gpBoxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid01)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE CLIENTES";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(544, 22);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(94, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "FECHAR";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEncerrar);
            this.panel1.Location = new System.Drawing.Point(-5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 62);
            this.panel1.TabIndex = 2;
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(429, 22);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(75, 23);
            this.btnEncerrar.TabIndex = 14;
            this.btnEncerrar.Text = "ENCERRAR";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(75, 152);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(187, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(75, 117);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(109, 20);
            this.txtID.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(539, 117);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 24);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(539, 176);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(94, 25);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CEP";
            // 
            // mtBoxCep
            // 
            this.mtBoxCep.Location = new System.Drawing.Point(75, 264);
            this.mtBoxCep.Mask = "00.000-000";
            this.mtBoxCep.Name = "mtBoxCep";
            this.mtBoxCep.Size = new System.Drawing.Size(124, 20);
            this.mtBoxCep.TabIndex = 16;
            // 
            // gpBoxSexo
            // 
            this.gpBoxSexo.Controls.Add(this.rdBtnFem);
            this.gpBoxSexo.Controls.Add(this.rdBtnMasc);
            this.gpBoxSexo.Location = new System.Drawing.Point(307, 117);
            this.gpBoxSexo.Name = "gpBoxSexo";
            this.gpBoxSexo.Size = new System.Drawing.Size(182, 100);
            this.gpBoxSexo.TabIndex = 17;
            this.gpBoxSexo.TabStop = false;
            this.gpBoxSexo.Text = "Sexo";
            // 
            // rdBtnFem
            // 
            this.rdBtnFem.AutoSize = true;
            this.rdBtnFem.Location = new System.Drawing.Point(7, 67);
            this.rdBtnFem.Name = "rdBtnFem";
            this.rdBtnFem.Size = new System.Drawing.Size(67, 17);
            this.rdBtnFem.TabIndex = 1;
            this.rdBtnFem.TabStop = true;
            this.rdBtnFem.Text = "Feminino";
            this.rdBtnFem.UseVisualStyleBackColor = true;
            this.rdBtnFem.CheckedChanged += new System.EventHandler(this.rdBtnFem_CheckedChanged);
            // 
            // rdBtnMasc
            // 
            this.rdBtnMasc.AutoSize = true;
            this.rdBtnMasc.Location = new System.Drawing.Point(6, 28);
            this.rdBtnMasc.Name = "rdBtnMasc";
            this.rdBtnMasc.Size = new System.Drawing.Size(73, 17);
            this.rdBtnMasc.TabIndex = 0;
            this.rdBtnMasc.TabStop = true;
            this.rdBtnMasc.Text = "Masculino";
            this.rdBtnMasc.UseVisualStyleBackColor = true;
            this.rdBtnMasc.CheckedChanged += new System.EventHandler(this.rdBtnMasc_CheckedChanged);
            // 
            // dtGrid01
            // 
            this.dtGrid01.AllowUserToAddRows = false;
            this.dtGrid01.AllowUserToDeleteRows = false;
            this.dtGrid01.BackgroundColor = System.Drawing.Color.Black;
            this.dtGrid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid01.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nome,
            this.cpf,
            this.telefone,
            this.cep,
            this.sexo});
            this.dtGrid01.Location = new System.Drawing.Point(-5, 371);
            this.dtGrid01.Name = "dtGrid01";
            this.dtGrid01.ReadOnly = true;
            this.dtGrid01.Size = new System.Drawing.Size(681, 184);
            this.dtGrid01.TabIndex = 18;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // cep
            // 
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // mtBoxCpf
            // 
            this.mtBoxCpf.Location = new System.Drawing.Point(75, 197);
            this.mtBoxCpf.Mask = "000.000.000-00";
            this.mtBoxCpf.Name = "mtBoxCpf";
            this.mtBoxCpf.Size = new System.Drawing.Size(187, 20);
            this.mtBoxCpf.TabIndex = 19;
            // 
            // mtBoxTelefone
            // 
            this.mtBoxTelefone.Location = new System.Drawing.Point(75, 235);
            this.mtBoxTelefone.Mask = "(00) 00000-0000";
            this.mtBoxTelefone.Name = "mtBoxTelefone";
            this.mtBoxTelefone.Size = new System.Drawing.Size(109, 20);
            this.mtBoxTelefone.TabIndex = 20;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(674, 548);
            this.Controls.Add(this.mtBoxTelefone);
            this.Controls.Add(this.mtBoxCpf);
            this.Controls.Add(this.dtGrid01);
            this.Controls.Add(this.gpBoxSexo);
            this.Controls.Add(this.mtBoxCep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpBoxSexo.ResumeLayout(false);
            this.gpBoxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtBoxCep;
        private System.Windows.Forms.GroupBox gpBoxSexo;
        private System.Windows.Forms.RadioButton rdBtnFem;
        private System.Windows.Forms.RadioButton rdBtnMasc;
        private System.Windows.Forms.DataGridView dtGrid01;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.MaskedTextBox mtBoxCpf;
        private System.Windows.Forms.MaskedTextBox mtBoxTelefone;
    }
}