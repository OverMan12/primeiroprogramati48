using System;
using System.Windows.Forms;

namespace Formulario
{
    partial class frmAgenda
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
            this.Dados = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Consultar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.Numerotel = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // Dados
            // 
            this.Dados.Location = new System.Drawing.Point(15, 443);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(75, 40);
            this.Dados.TabIndex = 30;
            this.Dados.Text = "Mostrar Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(21, 14);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 29;
            this.ID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(24, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(53, 20);
            this.txtID.TabIndex = 28;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(258, 414);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 27;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(177, 414);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 26;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(96, 414);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 23);
            this.Alterar.TabIndex = 25;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(15, 414);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 24;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(21, 161);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 23;
            this.Email.Text = "Email:";
            // 
            // Numerotel
            // 
            this.Numerotel.AutoSize = true;
            this.Numerotel.Location = new System.Drawing.Point(21, 113);
            this.Numerotel.Name = "Numerotel";
            this.Numerotel.Size = new System.Drawing.Size(92, 13);
            this.Numerotel.TabIndex = 22;
            this.Numerotel.Text = "Numero Telefone:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(21, 63);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 21;
            this.Nome.Text = "Nome:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(44, 212);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(259, 20);
            this.txtData.TabIndex = 20;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(55, 249);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(240, 150);
            this.dg.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 18;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(24, 129);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(141, 20);
            this.txtNum.TabIndex = 17;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 79);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(119, 20);
            this.txtNome.TabIndex = 16;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 496);
            this.Controls.Add(this.Dados);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Numerotel);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtNome);
            this.Name = "frmAgenda";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != null)
            {
                MessageBox.Show("O ID não precisa/pode ser preenchido!");
                return;
            }
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button Dados;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Numerotel;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtNome;
    }
}

