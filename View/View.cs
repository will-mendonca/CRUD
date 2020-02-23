using CRUD.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class View : Form
    {
        int IdGeral = 0;
        public View()
        {
            InitializeComponent();
            DesativaCampos();
            CarregaLista();
        }
        public void DesativaCampos()
        {
            txtNome.Enabled = false;
            txtIdade.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
        }
        public void AtivaCampos()
        {
            txtNome.Enabled = true;
            txtIdade.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
        }

        public void LimparCampos()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
        }

        private bool ValidaCampos()
        {
            if(string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtIdade.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtEndereco.Text))
            {
                return false;
            }
            return true;
        }
        public void CarregaLista()
        {
            dtLista.DataSource = new PessoasController().CarregaLista();
            dtLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtLista.Columns[0].Visible = false;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AtivaCampos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(ValidaCampos())
            {
                new PessoasController().AdicionaPessoa(txtNome.Text, Convert.ToInt32(txtIdade.Text), txtEmail.Text, txtEndereco.Text);
                MessageBox.Show("Cadastro concluído com Sucesso!");
                CarregaLista();
                LimparCampos();
                DesativaCampos();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
            }
        }

        private void dtLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Deseja Editar ou Excluir?", "Editar ou excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.IdGeral = Convert.ToInt32(dtLista.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = dtLista.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtIdade.Text = dtLista.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dtLista.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtEndereco.Text = dtLista.Rows[e.RowIndex].Cells[4].Value.ToString();
                AtivaCampos();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            new PessoasController().RemoverPessoas(IdGeral);
            MessageBox.Show("Removido com Sucesso!");
            CarregaLista();
            LimparCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            new PessoasController().EditarPessoas(IdGeral, txtNome.Text, Convert.ToInt32(txtIdade.Text), txtEmail.Text, txtEndereco.Text);
            AtivaCampos();
            IdGeral = 0;
            CarregaLista();
            MessageBox.Show("Alterado!");
        }
    }
}
