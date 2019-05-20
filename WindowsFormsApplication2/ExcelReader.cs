using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Importar
using ExcelDataReader;

namespace WindowsFormsApplication2
{
    public partial class frmExcelReader : Form
    {
        public frmExcelReader()
        {
            InitializeComponent();
        }
        int idAluno = 0;
        
        ClasseAluno aluno = new ClasseAluno();
        bool jaCadastrado = true;

        DataSet result;

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog of = new OpenFileDialog() { Filter = "Excel Work Book 97-2003|*.xls|Excel Workbook|* .xlsx", ValidateNames = true })
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = File.Open(of.FileName, FileMode.Open, FileAccess.Read);
                    IExcelDataReader reader; // Clicar no aviso e selecionar using ExcelDataReader
                    if (of.FilterIndex == 1)
                        reader = ExcelReaderFactory.CreateBinaryReader(fs);
                    else
                        reader = ExcelReaderFactory.CreateOpenXmlReader(fs);
                    result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });
                    cbbPlanilha.Items.Clear();
                    foreach (DataTable dt in result.Tables)
                    {
                        cbbPlanilha.Items.Add(dt.TableName);
                    }
                    reader.Close();
                }
            }
        }

        private void cbbPlanilha_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvAlunos.DataSource = result.Tables[cbbPlanilha.SelectedIndex];
        }

     

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            barra.Value = 0;
            barra.Maximum = dgvAlunos.RowCount;

            for (int i = 0; i < dgvAlunos.RowCount -1; i++)
            {
                    aluno.raAluno = int.Parse(dgvAlunos.Rows[i].Cells["RA ALUNO"].Value.ToString());
                    aluno.nomeAluno = dgvAlunos.Rows[i].Cells["ALUNO NOME"].Value.ToString();
                    aluno.dataNascimento = dgvAlunos.Rows[i].Cells["NASCIMENTO"].Value.ToString();
                    aluno.idade = int.Parse(dgvAlunos.Rows[i].Cells["IDADE DO ALUNO"].Value.ToString());
                    aluno.sexo = dgvAlunos.Rows[i].Cells["SEXO"].Value.ToString();
                    aluno.grauInstrucao = dgvAlunos.Rows[i].Cells["GRAU_INSTRUCAO"].Value.ToString();
                    aluno.endereco = dgvAlunos.Rows[i].Cells["RUA"].Value.ToString();
                    aluno.numero = int.Parse(dgvAlunos.Rows[i].Cells["NUMERO"].Value.ToString());
                    aluno.complemento = dgvAlunos.Rows[i].Cells["COMPLEMENTO"].Value.ToString();
                    aluno.cep = dgvAlunos.Rows[i].Cells["CEP"].Value.ToString();
                    aluno.bairro = dgvAlunos.Rows[i].Cells["BAIRRO"].Value.ToString();
                    aluno.cidade = dgvAlunos.Rows[i].Cells["CIDADE"].Value.ToString();
                    aluno.estado = dgvAlunos.Rows[i].Cells[" ESTADO"].Value.ToString();
                    aluno.celularAluno = dgvAlunos.Rows[i].Cells["TELEFONE 1"].Value.ToString();
                    aluno.rg = dgvAlunos.Rows[i].Cells["IDENTIDADE"].Value.ToString();
                    aluno.cpf = dgvAlunos.Rows[i].Cells["CPF"].Value.ToString();
                    aluno.email = dgvAlunos.Rows[i].Cells["E-MAIL"].Value.ToString();
                    aluno.carteiraTrabalho = dgvAlunos.Rows[i].Cells["CARTEIRA TRABALHO"].Value.ToString();
                    aluno.nomePai = dgvAlunos.Rows[i].Cells["NOME DO PAI"].Value.ToString();
                    aluno.telefonePai = dgvAlunos.Rows[i].Cells["TELEFONE DO PAI"].Value.ToString();
                    aluno.nomeMae = dgvAlunos.Rows[i].Cells["NOME MÃE"].Value.ToString();
                    aluno.telefoneMae = dgvAlunos.Rows[i].Cells["TELEFONE MÃE"].Value.ToString();
                    aluno.nomeCurso = dgvAlunos.Rows[i].Cells["NOME CURSO"].Value.ToString();
                    aluno.codigoTurma = dgvAlunos.Rows[i].Cells["CODIGO TURMA"].Value.ToString();
                    aluno.statusMatricula = dgvAlunos.Rows[i].Cells["STATUS"].Value.ToString();
                    aluno.telefoneAluno = dgvAlunos.Rows[i].Cells["TELEFONE ALUNO 2"].Value.ToString();

                idAluno = int.Parse(dgvAlunos.Rows[i].Cells["RA ALUNO"].Value.ToString());//Primeiramente idAluno recebe a PK raAluno;
              
                DataTable dt = aluno.LocalizarAlunoMatriculado(idAluno); //O método localiza o aluno pelo raAluno

                if (dt.Rows.Count > 0)//Se existir alguma linha no banco com esta PK raAluno prova que ele já está matriculado assim pode decidir se o aluno será matriculado ou editado
                {
                    aluno.EditarAluno(idAluno);//Todos os alunos já cadastrados teram seus dados atualizados. Um de cada vez.
                    jaCadastrado = false;
                }
                else
                {
                    aluno.InserirAluno();
                }

                barra.Value = barra.Value + 1; //Para encher a barra a cada loop.
              
            }

            barra.Value = dgvAlunos.RowCount;//Para preencher a barra corretamente.

            if (jaCadastrado == false)
            {
                MessageBox.Show("Todos os Alunos foram cadastrados e atualizados com sucesso!");
            }
            else
            {
                MessageBox.Show("Todos os Alunos foram cadastrados com sucesso!");
                
            }

            barra.Value = 0;
        
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            frmManterAlunos formularioManterAlunos  = new frmManterAlunos();
            this.Hide();
            formularioManterAlunos.Show();
        }
    }
}
