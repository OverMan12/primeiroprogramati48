using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Formulario
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        bool EmailValido(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void frmAgendda_Load(object sender, EventArgs e)
        {
            txtNome.Focus();

        }

        List<Contato> lista = new List<Contato>();
        int proximoId = 1;

        private void LimparCampos()
        {
            txtID.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtNum.Clear();
            txtNome.Focus();
        }

        private void AtualizarGrid()
        {
            dg.DataSource = null;
            dg.DataSource = lista;
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var contato = lista[e.RowIndex];

                txtID.Text = contato.ID.ToString();
                txtNome.Text = contato.Nome.ToString();
                txtNum.Text = contato.Num.ToString();
                txtEmail.Text = contato.Email.ToString();
                txtData.Value = contato.DataRegistro;
            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o Nome!");
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email Invalido!");
                return;
            }

            Contato c = new Contato();
            c.ID = proximoId++;
            c.Nome = txtNome.Text;
            c.Email = txtEmail.Text;
            c.DataRegistro = txtData.Value;

            lista.Add(c);

            AtualizarGrid();

            LimparCampos();



        }

        private void btnAlterar_Click(object sender, EventArgs args)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Selecione um Registro para alterar!");
                return;
            }

            int id = int.Parse(txtID.Text);

            Contato contato = lista.FirstOrDefault(c => c.ID == id);

            if (contato == null)
            {
                MessageBox.Show("Registro não encontrado!");
                return;
            }

            contato.Nome = txtNome.Text;
            contato.Num = txtNum.Text;
            contato.Email = txtEmail.Text;
            contato.DataRegistro = txtData.Value;

            AtualizarGrid();

            MessageBox.Show("Registro alterado com sucesso!");

            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                if (MessageBox.Show("Deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            if (MessageBox.Show("Deseja excluir este registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int id = int.Parse(txtID.Text);

            Contato contato = lista.FirstOrDefault(c => c.ID == id);

            if (contato != null)
            {
                lista.Remove(contato);
                AtualizarGrid();
                LimparCampos();

                MessageBox.Show("Registro excluido com sucesso!");
            }
        }

        private void btn_Click (object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void txtID_Changed(object sender, EventArgs e)
        {
            if (txtID.Text != null)
            {
                MessageBox.Show("O ID não precisa/pode ser preenchido!");
                return;
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            txtNum.MaxLength = 10;
            if (txtNum.Text.Length > 9)
            {
                MessageBox.Show("Numero invalido, digite corretamente!");
                return;
            }
        }

    }
}
