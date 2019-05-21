using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmEmpresa : Form
    {
        ClasseEmpresa empresa = new ClasseEmpresa();
        public frmEmpresa()
        {
            InitializeComponent();
            
        }
        int CodEmpresa = 0;
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            empresa.Cnpj = txtCnpj.Text;
            empresa.NomeFantasia = txtNomeFantasia.Text;
            empresa.Telefone = txtTelefone.Text;
            empresa.Email = txtEmail.Text;
            empresa.RazaoSocial = txtRazaoSocial.Text;
            empresa.Responsavel = txtResponsavel.Text;
            empresa.Cep = int.Parse(txtCEP.Text);
            empresa.Rua = txtRua.Text;
            empresa.Numero = txtNumero.Text;
            empresa.Complemento = txtComplemento.Text;
            empresa.Bairro = txtBairro.Text;
            empresa.Cidade = txtCidade.Text;
            empresa.Estado = txtEstado.Text;

            if (empresa.InserirEmpresa() == true)
            {
                dgvEmpresa.DataSource = empresa.RetornarEmpresa();
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Cadastro não realizado!");
            }
        }

        private void dgvEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCnpj.Text = dgvEmpresa.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
            txtNomeFantasia.Text = dgvEmpresa.Rows[e.RowIndex].Cells["nomeFantasia"].Value.ToString();
            txtTelefone.Text = dgvEmpresa.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            txtEmail.Text = dgvEmpresa.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtRazaoSocial.Text = dgvEmpresa.Rows[e.RowIndex].Cells["razaoSocial"].Value.ToString();
            txtResponsavel.Text = dgvEmpresa.Rows[e.RowIndex].Cells["responsavel"].Value.ToString();
            txtCEP.Text = dgvEmpresa.Rows[e.RowIndex].Cells["cep"].Value.ToString();
            txtRua.Text = dgvEmpresa.Rows[e.RowIndex].Cells["rua"].Value.ToString();
            txtNumero.Text = dgvEmpresa.Rows[e.RowIndex].Cells["numero"].Value.ToString();
            txtComplemento.Text = dgvEmpresa.Rows[e.RowIndex].Cells["complemento"].Value.ToString();
            txtBairro.Text = dgvEmpresa.Rows[e.RowIndex].Cells["bairro"].Value.ToString();
            txtCidade.Text = dgvEmpresa.Rows[e.RowIndex].Cells["cidade"].Value.ToString();
            txtEstado.Text = dgvEmpresa.Rows[e.RowIndex].Cells["estado"].Value.ToString();
            CodEmpresa = int.Parse(dgvEmpresa.Rows[e.RowIndex].Cells["IdEmpresa"].Value.ToString());
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            dgvEmpresa.DataSource = empresa.RetornarEmpresa();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            empresa.Cnpj = txtCnpj.Text;
            empresa.NomeFantasia = txtNomeFantasia.Text;
            empresa.Telefone = txtTelefone.Text;
            empresa.Email = txtEmail.Text;
            empresa.RazaoSocial = txtRazaoSocial.Text;
            empresa.Responsavel = txtResponsavel.Text;
            empresa.Cep = int.Parse(txtCEP.Text);
            empresa.Rua = txtRua.Text;
            empresa.Numero = txtNumero.Text;
            empresa.Complemento = txtComplemento.Text;
            empresa.Bairro = txtBairro.Text;
            empresa.Cidade = txtCidade.Text;
            empresa.Estado = txtEstado.Text;

            if (empresa.EditarEmpresa(CodEmpresa) == true)
            {
                dgvEmpresa.DataSource = empresa.RetornarEmpresa();
                MessageBox.Show("Edição realizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Edição não realizada.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            empresa.Cnpj = txtCnpj.Text;
            empresa.NomeFantasia = txtNomeFantasia.Text;
            empresa.Telefone = txtTelefone.Text;
            empresa.Email = txtEmail.Text;
            empresa.RazaoSocial = txtRazaoSocial.Text;
            empresa.Responsavel = txtResponsavel.Text;
            empresa.Cep = int.Parse(txtCEP.Text);
            empresa.Rua = txtRua.Text;
            empresa.Numero = txtNumero.Text;
            empresa.Complemento = txtComplemento.Text;
            empresa.Bairro = txtBairro.Text;
            empresa.Cidade = txtCidade.Text;
            empresa.Estado = txtEstado.Text;

            if (empresa.ExcluirEmpresa(CodEmpresa) == true)
            {
                dgvEmpresa.DataSource = empresa.RetornarEmpresa();
                MessageBox.Show("Exclusão realizada com sucesso!");
            }
            else
            {
                MessageBox.Show("Exclusão não realizada com sucesso!");
            }
        }
    }
}
