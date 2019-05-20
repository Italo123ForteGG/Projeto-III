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

        public frmAlunoEmpresa()
        {
            InitializeComponent();
            dgvAlunos.DataSource = aluno.RetornarAluno();
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
            
        }
    }
}
