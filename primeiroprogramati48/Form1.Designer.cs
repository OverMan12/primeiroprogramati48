using System;
using Microsoft.Win32;

namespace primeiroprogramati48
{
    partial class Form1
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Sete = new System.Windows.Forms.Button();
            this.Oito = new System.Windows.Forms.Button();
            this.Nove = new System.Windows.Forms.Button();
            this.Quatro = new System.Windows.Forms.Button();
            this.Seis = new System.Windows.Forms.Button();
            this.Um = new System.Windows.Forms.Button();
            this.Dois = new System.Windows.Forms.Button();
            this.Tres = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Virgula = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Adicao = new System.Windows.Forms.Button();
            this.Subtracao = new System.Windows.Forms.Button();
            this.Multiplicacao = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.Limpa = new System.Windows.Forms.Button();
            this.Ccinco = new System.Windows.Forms.Button();
            this.Menos = new System.Windows.Forms.Button();
            this.Porcentagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNum.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtNum.Location = new System.Drawing.Point(48, 112);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(237, 20);
            this.txtNum.TabIndex = 1;
            // 
            // txtResul
            // 
            this.txtResul.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResul.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtResul.Location = new System.Drawing.Point(48, 147);
            this.txtResul.Name = "txtResul";
            this.txtResul.Size = new System.Drawing.Size(237, 20);
            this.txtResul.TabIndex = 2;
            // 
            // Titulo
            // 
            this.Titulo.Font = new System.Drawing.Font("ISOCPEUR", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(38, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(250, 100);
            this.Titulo.TabIndex = 3;
            this.Titulo.Text = "Caluladora";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sete
            // 
            this.Sete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sete.ForeColor = System.Drawing.Color.Black;
            this.Sete.Location = new System.Drawing.Point(42, 185);
            this.Sete.Name = "Sete";
            this.Sete.Size = new System.Drawing.Size(56, 48);
            this.Sete.TabIndex = 4;
            this.Sete.Text = "7";
            this.Sete.UseVisualStyleBackColor = true;
            this.Sete.Click += new System.EventHandler(this.Sete_Click);
            // 
            // Oito
            // 
            this.Oito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oito.ForeColor = System.Drawing.Color.Black;
            this.Oito.Location = new System.Drawing.Point(104, 185);
            this.Oito.Name = "Oito";
            this.Oito.Size = new System.Drawing.Size(56, 48);
            this.Oito.TabIndex = 5;
            this.Oito.Text = "8";
            this.Oito.UseVisualStyleBackColor = true;
            this.Oito.Click += new System.EventHandler(this.Oito_Click);
            // 
            // Nove
            // 
            this.Nove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nove.ForeColor = System.Drawing.Color.Black;
            this.Nove.Location = new System.Drawing.Point(167, 185);
            this.Nove.Name = "Nove";
            this.Nove.Size = new System.Drawing.Size(56, 48);
            this.Nove.TabIndex = 6;
            this.Nove.Text = "9";
            this.Nove.UseVisualStyleBackColor = true;
            this.Nove.Click += new System.EventHandler(this.Nove_Click);
            // 
            // Quatro
            // 
            this.Quatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quatro.ForeColor = System.Drawing.Color.Black;
            this.Quatro.Location = new System.Drawing.Point(42, 239);
            this.Quatro.Name = "Quatro";
            this.Quatro.Size = new System.Drawing.Size(56, 48);
            this.Quatro.TabIndex = 8;
            this.Quatro.Text = "4";
            this.Quatro.UseVisualStyleBackColor = true;
            this.Quatro.Click += new System.EventHandler(this.Quatro_Click);
            // 
            // Seis
            // 
            this.Seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seis.ForeColor = System.Drawing.Color.Black;
            this.Seis.Location = new System.Drawing.Point(167, 239);
            this.Seis.Name = "Seis";
            this.Seis.Size = new System.Drawing.Size(56, 48);
            this.Seis.TabIndex = 9;
            this.Seis.Text = "6";
            this.Seis.UseVisualStyleBackColor = true;
            this.Seis.Click += new System.EventHandler(this.Seis_Click);
            // 
            // Um
            // 
            this.Um.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Um.ForeColor = System.Drawing.Color.Black;
            this.Um.Location = new System.Drawing.Point(42, 293);
            this.Um.Name = "Um";
            this.Um.Size = new System.Drawing.Size(56, 48);
            this.Um.TabIndex = 10;
            this.Um.Text = "1";
            this.Um.UseVisualStyleBackColor = true;
            this.Um.Click += new System.EventHandler(this.Um_Click);
            // 
            // Dois
            // 
            this.Dois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dois.ForeColor = System.Drawing.Color.Black;
            this.Dois.Location = new System.Drawing.Point(104, 293);
            this.Dois.Name = "Dois";
            this.Dois.Size = new System.Drawing.Size(56, 48);
            this.Dois.TabIndex = 11;
            this.Dois.Text = "2";
            this.Dois.UseVisualStyleBackColor = true;
            this.Dois.Click += new System.EventHandler(this.Dois_Click);
            // 
            // Tres
            // 
            this.Tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tres.ForeColor = System.Drawing.Color.Black;
            this.Tres.Location = new System.Drawing.Point(167, 293);
            this.Tres.Name = "Tres";
            this.Tres.Size = new System.Drawing.Size(56, 48);
            this.Tres.TabIndex = 12;
            this.Tres.Text = "3";
            this.Tres.UseVisualStyleBackColor = true;
            this.Tres.Click += new System.EventHandler(this.Tres_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zero.ForeColor = System.Drawing.Color.Black;
            this.Zero.Location = new System.Drawing.Point(104, 347);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(56, 48);
            this.Zero.TabIndex = 13;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Virgula
            // 
            this.Virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Virgula.ForeColor = System.Drawing.Color.Black;
            this.Virgula.Location = new System.Drawing.Point(42, 347);
            this.Virgula.Name = "Virgula";
            this.Virgula.Size = new System.Drawing.Size(56, 48);
            this.Virgula.TabIndex = 14;
            this.Virgula.Text = ",";
            this.Virgula.UseVisualStyleBackColor = true;
            this.Virgula.Click += new System.EventHandler(this.Virgula_Click);
            // 
            // Igual
            // 
            this.Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.ForeColor = System.Drawing.Color.Black;
            this.Igual.Location = new System.Drawing.Point(198, 401);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(56, 48);
            this.Igual.TabIndex = 15;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Adicao
            // 
            this.Adicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adicao.ForeColor = System.Drawing.Color.Black;
            this.Adicao.Location = new System.Drawing.Point(229, 185);
            this.Adicao.Name = "Adicao";
            this.Adicao.Size = new System.Drawing.Size(56, 48);
            this.Adicao.TabIndex = 16;
            this.Adicao.Text = "+";
            this.Adicao.UseVisualStyleBackColor = true;
            this.Adicao.Click += new System.EventHandler(this.Adicao_Click);
            // 
            // Subtracao
            // 
            this.Subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtracao.ForeColor = System.Drawing.Color.Black;
            this.Subtracao.Location = new System.Drawing.Point(229, 239);
            this.Subtracao.Name = "Subtracao";
            this.Subtracao.Size = new System.Drawing.Size(56, 48);
            this.Subtracao.TabIndex = 17;
            this.Subtracao.Text = "-";
            this.Subtracao.UseVisualStyleBackColor = true;
            this.Subtracao.Click += new System.EventHandler(this.Subtracao_Click);
            // 
            // Multiplicacao
            // 
            this.Multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacao.ForeColor = System.Drawing.Color.Black;
            this.Multiplicacao.Location = new System.Drawing.Point(229, 293);
            this.Multiplicacao.Name = "Multiplicacao";
            this.Multiplicacao.Size = new System.Drawing.Size(56, 48);
            this.Multiplicacao.TabIndex = 18;
            this.Multiplicacao.Text = "X";
            this.Multiplicacao.UseVisualStyleBackColor = true;
            this.Multiplicacao.Click += new System.EventHandler(this.Multiplicacao_Click);
            // 
            // Divisao
            // 
            this.Divisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisao.ForeColor = System.Drawing.Color.Black;
            this.Divisao.Location = new System.Drawing.Point(166, 347);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(56, 48);
            this.Divisao.TabIndex = 19;
            this.Divisao.Text = "/";
            this.Divisao.UseVisualStyleBackColor = true;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // Limpa
            // 
            this.Limpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpa.ForeColor = System.Drawing.Color.Black;
            this.Limpa.Location = new System.Drawing.Point(73, 401);
            this.Limpa.Name = "Limpa";
            this.Limpa.Size = new System.Drawing.Size(56, 48);
            this.Limpa.TabIndex = 20;
            this.Limpa.Text = "C";
            this.Limpa.UseVisualStyleBackColor = true;
            this.Limpa.Click += new System.EventHandler(this.Limpa_Click);
            // 
            // Ccinco
            // 
            this.Ccinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ccinco.ForeColor = System.Drawing.Color.Black;
            this.Ccinco.Location = new System.Drawing.Point(104, 239);
            this.Ccinco.Name = "Ccinco";
            this.Ccinco.Size = new System.Drawing.Size(56, 48);
            this.Ccinco.TabIndex = 22;
            this.Ccinco.Text = "5";
            this.Ccinco.UseVisualStyleBackColor = true;
            this.Ccinco.Click += new System.EventHandler(this.Ccinco_Click);
            // 
            // Menos
            // 
            this.Menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menos.ForeColor = System.Drawing.Color.Black;
            this.Menos.Location = new System.Drawing.Point(229, 347);
            this.Menos.Name = "Menos";
            this.Menos.Size = new System.Drawing.Size(56, 48);
            this.Menos.TabIndex = 24;
            this.Menos.Text = "+/-";
            this.Menos.UseVisualStyleBackColor = true;
            this.Menos.Click += new System.EventHandler(this.Menos_Click);
            // 
            // Porcentagem
            // 
            this.Porcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Porcentagem.ForeColor = System.Drawing.Color.Black;
            this.Porcentagem.Location = new System.Drawing.Point(136, 401);
            this.Porcentagem.Name = "Porcentagem";
            this.Porcentagem.Size = new System.Drawing.Size(56, 48);
            this.Porcentagem.TabIndex = 25;
            this.Porcentagem.Text = "%";
            this.Porcentagem.UseVisualStyleBackColor = true;
            this.Porcentagem.Click += new System.EventHandler(this.Porcentagem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 463);
            this.Controls.Add(this.Porcentagem);
            this.Controls.Add(this.Menos);
            this.Controls.Add(this.Ccinco);
            this.Controls.Add(this.Limpa);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.Multiplicacao);
            this.Controls.Add(this.Subtracao);
            this.Controls.Add(this.Adicao);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.Virgula);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Tres);
            this.Controls.Add(this.Dois);
            this.Controls.Add(this.Um);
            this.Controls.Add(this.Seis);
            this.Controls.Add(this.Quatro);
            this.Controls.Add(this.Nove);
            this.Controls.Add(this.Oito);
            this.Controls.Add(this.Sete);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.txtNum);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        decimal resultado;
        decimal valor1;
        decimal valor2;
        string operacao = "adicao";

        private void Form1_Load(object sender, EventArgs e)
        {
            resultado = 0;
            valor1 = 0;
            valor2 = 0;
        }



        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.Label Titulo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Sete;
        private System.Windows.Forms.Button Oito;
        private System.Windows.Forms.Button Nove;
        private System.Windows.Forms.Button Quatro;
        private System.Windows.Forms.Button Seis;
        private System.Windows.Forms.Button Um;
        private System.Windows.Forms.Button Dois;
        private System.Windows.Forms.Button Tres;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Virgula;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Adicao;
        private System.Windows.Forms.Button Subtracao;
        private System.Windows.Forms.Button Multiplicacao;
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.Button Limpa;
        private System.Windows.Forms.Button Ccinco;
        private System.Windows.Forms.Button Menos;
        private System.Windows.Forms.Button Porcentagem;
    }
}

