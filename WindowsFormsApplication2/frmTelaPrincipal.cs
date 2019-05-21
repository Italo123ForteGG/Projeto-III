using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication2
{
    public partial class frmTelaPrincipal : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwmd, int wmsg, int wparam, int lparam);


        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnLeitorExcel_Click(object sender, EventArgs e)
        {
            if (pnImportarAlunos.Visible == false)
            {
                pnImportarAlunos.Visible = true;
                pnAluno.Visible = false;
                pnEmpresa.Visible = false;
                pnEncaminharAlunos.Visible = false;
            }

            AberturaTela(new frmExcelReader());
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            if (pnAluno.Visible == false)
            {
                pnImportarAlunos.Visible = false;
                pnAluno.Visible = true;
                pnEmpresa.Visible = false;
                pnEncaminharAlunos.Visible = false;
            }

            AberturaTela(new frmManterAlunos());
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            if (pnEmpresa.Visible == false)
            {
                pnImportarAlunos.Visible = false;
                pnAluno.Visible = false;
                pnEmpresa.Visible = true;
                pnEncaminharAlunos.Visible = false;
            }

            AberturaTela(new frmEmpresa());
        }

        private void btnEncaminharAlunos_Click(object sender, EventArgs e)
        {
            if (pnEncaminharAlunos.Visible == false)
            {
                pnImportarAlunos.Visible = false;
                pnAluno.Visible = false;
                pnEmpresa.Visible = false;
                pnEncaminharAlunos.Visible = true;
            }
            AberturaTela(new frmRelatorioAlunos());
        }

        private void AberturaTela(object frmAluno)
        {
            if (this.pnContem.Controls.Count > 0)
            {
                this.pnContem.Controls.RemoveAt(0);

            }
            Form fa = frmAluno as Form;
            fa.TopLevel = false;
            fa.Dock = DockStyle.Fill;
            this.pnContem.Controls.Add(fa);
            this.pnContem.Tag = fa;
            fa.Show();
        }

        private void pnOpcoes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnCima_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnContem_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void picSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void picTelaInicial_Click(object sender, EventArgs e)
        {
        }
    }
}
