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
    public partial class frmAlunoEmpresa : Form
    {
        ClasseAluno aluno = new ClasseAluno();
        ClasseEmpresa empresa = new ClasseEmpresa();
        ClasseAlunoEmpresa alunoEmpresa = new ClasseAlunoEmpresa();

        public frmAlunoEmpresa()
        {
            InitializeComponent();
            dgvAlunos.DataSource = aluno.RetornarAlunoEmpresa();
            dgvEmpresas.DataSource = empresa.ExibirEmpresa();
        }

        private void txtBuscarAluno_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarAluno.Text != "")
            {
                dgvAlunos.DataSource = aluno.RetornarAlunoPorNome(txtBuscarAluno.Text);
            }
        }
        
        private void txtBuscarEmpresa_TextChanged(object sender, EventArgs e)
        {
           if (txtBuscarEmpresa.Text != "")
            {
                dgvEmpresas.DataSource = empresa.RetornarEmpresaPorNome(txtBuscarEmpresa.Text);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            alunoEmpresa.raAluno = float.Parse(txtRa.Text);
            alunoEmpresa.nomeAluno = txtNomeAluno.Text;
            alunoEmpresa.rgAluno = txtRg.Text;
            alunoEmpresa.cpfAluno = txtCpf.Text;
            alunoEmpresa.codigoTurma = txtCodigoTurma.Text;
            alunoEmpresa.nomeCurso = txtCurso.Text;

            alunoEmpresa.cnpj = txtCnpj.Text;
            alunoEmpresa.nomeFantasia = txtNomeFantasia.Text;
            alunoEmpresa.responsavel = txtResponsavel.Text;
            alunoEmpresa.telefoneResponsavel = txtTelefone.Text;

            if (alunoEmpresa.RegistrarAlunoEmpresa() == true)
            {
                MessageBox.Show("Aluno encaminhado com sucesso.");
            }
        }

       

  
        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRa.Text = dgvAlunos.Rows[e.RowIndex].Cells["raAluno"].Value.ToString();
            txtNomeAluno.Text = dgvAlunos.Rows[e.RowIndex].Cells["nomeAluno"].Value.ToString();
            txtRg.Text = dgvAlunos.Rows[e.RowIndex].Cells["rg"].Value.ToString();
            txtCpf.Text = dgvAlunos.Rows[e.RowIndex].Cells["cpf"].Value.ToString();
            txtCodigoTurma.Text = dgvAlunos.Rows[e.RowIndex].Cells["codigoTurma"].Value.ToString();
            txtCurso.Text = dgvAlunos.Rows[e.RowIndex].Cells["nomeCurso"].Value.ToString();
            
           
        }

        private void dgvEmpresas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeFantasia.Text = dgvEmpresas.Rows[e.RowIndex].Cells["nomeFantasia"].Value.ToString();
            txtCnpj.Text = dgvEmpresas.Rows[e.RowIndex].Cells["cnpj"].Value.ToString();
            txtResponsavel.Text = dgvEmpresas.Rows[e.RowIndex].Cells["responsavel"].Value.ToString();
            txtTelefone.Text = dgvEmpresas.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
        }
    }
}
