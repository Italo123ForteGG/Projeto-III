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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnLeitorExcel_Click(object sender, EventArgs e)
        {
            frmExcelReader frmExcelReader = new frmExcelReader();
            this.Hide();
            frmExcelReader.Show();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            frmManterAlunos frmManterAlunos = new frmManterAlunos();
            this.Hide();
            frmManterAlunos.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmEmpresa frmEmpresa = new frmEmpresa();
            this.Hide();
            frmEmpresa.Show();
        }

        private void btnEncaminharAlunos_Click(object sender, EventArgs e)
        {

            frmAlunoEmpresa frmEncaminhar = new frmAlunoEmpresa();
            this.Hide();
            frmEncaminhar.Show();

        }
    }
}
