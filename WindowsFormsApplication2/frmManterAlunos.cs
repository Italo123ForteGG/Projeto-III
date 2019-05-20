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
    public partial class frmManterAlunos : Form
    {
        public frmManterAlunos()
        {
            InitializeComponent();
        }
        ClasseAcessoBD bd = new ClasseAcessoBD();
        ClasseAluno aluno = new ClasseAluno();
        int idAluno = 0;

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            DataTable dt = aluno.LocalizarAlunoMatriculado(int.Parse(txtBusca.Text));

            txtNome.Text = dt.Rows[0]["nomeAluno"].ToString();
            txtRg.Text = dt.Rows[0]["rg"].ToString();
            txtCpf.Text = dt.Rows[0]["cpf"].ToString();
            txtDataNascimento.Text = dt.Rows[0]["dataNascimento"].ToString();
            txtIdade.Text = dt.Rows[0]["idade"].ToString();
            txtSexo.Text = dt.Rows[0]["sexo"].ToString();
            txtCarteiraTrabalho.Text = dt.Rows[0]["carteiraTrabalho"].ToString();
            txtEmail.Text = dt.Rows[0]["email"].ToString();
            txtGrauInstrucao.Text = dt.Rows[0]["grauInstrucao"].ToString();
            txtEndereco.Text = dt.Rows[0]["endereco"].ToString();
            txtNumero.Text = dt.Rows[0]["numero"].ToString();
            txtComplemento.Text = dt.Rows[0]["complemento"].ToString();
            txtBairro.Text = dt.Rows[0]["bairro"].ToString();
            txtCidade.Text = dt.Rows[0]["cidade"].ToString();
            txtEstado.Text = dt.Rows[0]["estado"].ToString();
            txtCep.Text = dt.Rows[0]["cep"].ToString();
            txtTelefone1.Text = dt.Rows[0]["celularAluno"].ToString();
            txtTelefone2.Text = dt.Rows[0]["telefoneAluno"].ToString();
            txtNomePai.Text = dt.Rows[0]["nomePai"].ToString();
            txtTelefonePai.Text = dt.Rows[0]["telefonePai"].ToString();
            txtNomeMae.Text = dt.Rows[0]["nomeMae"].ToString();
            txtTelefoneMae.Text = dt.Rows[0]["telefoneMae"].ToString();
            txtNomeCurso.Text = dt.Rows[0]["nomeCurso"].ToString();
            txtCodigoTurma.Text = dt.Rows[0]["codigoTurma"].ToString();
            txtStatusMatricula.Text = dt.Rows[0]["statusMatricula"].ToString();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            frmExcelReader formulario1 = new frmExcelReader();
            this.Hide();
            formulario1.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            aluno.nomeAluno = txtNome.Text;
            aluno.rg = txtRg.Text;
            aluno.cpf = txtCpf.Text;
            aluno.dataNascimento = txtDataNascimento.Text;
            aluno.idade = int.Parse(txtIdade.Text);
            aluno.sexo = txtSexo.Text;
            aluno.carteiraTrabalho = txtCarteiraTrabalho.Text;
            aluno.email = txtEmail.Text;
            aluno.grauInstrucao = txtGrauInstrucao.Text;
            aluno.endereco = txtEndereco.Text;
            aluno.numero = int.Parse(txtNumero.Text);
            aluno.complemento = txtComplemento.Text;
            aluno.bairro = txtBairro.Text;
            aluno.cidade = txtCidade.Text;
            aluno.estado = txtEstado.Text; ;
            aluno.cep = txtCep.Text;
            aluno.celularAluno = txtTelefone1.Text;
            aluno.telefoneAluno = txtTelefone2.Text;
            aluno.nomePai = txtNomePai.Text;
            aluno.telefonePai = txtTelefonePai.Text;
            aluno.nomeMae = txtNomeMae.Text;
            aluno.telefoneMae = txtTelefoneMae.Text;
            aluno.nomeCurso = txtNomeCurso.Text;
            aluno.codigoTurma = txtCodigoTurma.Text;
            aluno.statusMatricula = txtStatusMatricula.Text;

            idAluno = int.Parse(txtBusca.Text);

            if(txtNome.Text != "")
            {
                aluno.EditarAluno(idAluno);
                MessageBox.Show("Aluno Editado");
            }
        }
    }
}
