using System;

namespace PrimeiroProjetoTI48
{
    partial class frmAgendda
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.Nome = new System.Windows.Forms.Label();
            this.Numerotel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Dados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(119, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(21, 130);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(141, 20);
            this.txtNum.TabIndex = 2;
            this.txtNum.Text = "(___) _____-____";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(21, 187);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(182, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(52, 250);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(240, 150);
            this.dg.TabIndex = 4;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(41, 213);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(259, 20);
            this.txtData.TabIndex = 5;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(18, 64);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 6;
            this.Nome.Text = "Nome:";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // Numerotel
            // 
            this.Numerotel.AutoSize = true;
            this.Numerotel.Location = new System.Drawing.Point(18, 114);
            this.Numerotel.Name = "Numerotel";
            this.Numerotel.Size = new System.Drawing.Size(92, 13);
            this.Numerotel.TabIndex = 7;
            this.Numerotel.Text = "Numero Telefone:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(18, 162);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(35, 13);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email:";
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(12, 415);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 23);
            this.Adicionar.TabIndex = 9;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Alterar
            // 
            this.Alterar.Location = new System.Drawing.Point(93, 415);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(75, 23);
            this.Alterar.TabIndex = 10;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(174, 415);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(75, 23);
            this.Excluir.TabIndex = 11;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(255, 415);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 12;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(21, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(53, 20);
            this.txtID.TabIndex = 13;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(18, 13);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 14;
            this.ID.Text = "ID";
            // 
            // Dados
            // 
            this.Dados.Location = new System.Drawing.Point(12, 444);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(75, 40);
            this.Dados.TabIndex = 15;
            this.Dados.Text = "Mostrar Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // frmAgendda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 510);
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
            this.Name = "frmAgendda";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label Numerotel;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button Alterar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Button Dados;
    }
}