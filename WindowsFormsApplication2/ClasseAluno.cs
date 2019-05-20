using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class ClasseAluno
    {
        public int raAluno;
        public string nomeAluno;
        public string rg;
        public string cpf;
        public string dataNascimento;
        public int idade;
        public string sexo;
        public string carteiraTrabalho;
        public string email;
        public string grauInstrucao;
        public string endereco;
        public int numero;
        public string complemento;
        public string bairro;
        public string estado;
        public string cidade;
        public string cep;
        public string telefoneAluno;
        public string celularAluno;
        public string nomePai;
        public string telefonePai;
        public string nomeMae;
        public string telefoneMae;
        public string nomeCurso;
        public string codigoTurma;
        public string statusMatricula;

        ClasseAcessoBD bd = new ClasseAcessoBD();

        public bool InserirAluno()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Aluno (raAluno,nomeAluno,rg,cpf,dataNascimento,idade,sexo,carteiraTrabalho,email,grauInstrucao,endereco,numero,complemento,bairro,cidade,estado,cep,telefoneAluno,celularAluno,nomePai,telefonePai,nomeMae,telefoneMae,nomeCurso,codigoTurma,statusMatricula) VALUES ({0},'{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','10',{11},'{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}')", raAluno, nomeAluno, rg, cpf, dataNascimento, idade, sexo, carteiraTrabalho, email, grauInstrucao, endereco, numero, complemento, bairro, cidade, estado, cep, telefoneAluno, celularAluno, nomePai, telefonePai, nomeMae, telefoneMae, nomeCurso, codigoTurma, statusMatricula));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir aluno. ");
            }
        }
        public DataTable LocalizarAlunoMatriculado(int idAluno)
        {
            //Conecta no banco
            bd.Conectar();

            //Executa o insert
            DataTable dt = bd.RetDataTable(String.Format("SELECT*FROM Aluno WHERE raAluno = {0}", idAluno));

            //Desconecta no banco 
            bd.Desconectar();

            return dt;
        }
        public bool EditarAluno(int idAluno)
        {
            try
            {

                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(String.Format("UPDATE Aluno SET nomeAluno = '{0}',rg = '{1}',cpf = '{2}',dataNascimento = '{3}',idade = {4},sexo = '{5}',carteiraTrabalho = '{6}',email = '{7}',grauInstrucao = '{8}',endereco = '{9}',numero = {10},complemento = '{11}',bairro = '{12}',cidade = '{13}',estado = '{14}',cep = '{15}',telefoneAluno = '{16}',celularAluno = '{17}',nomePai = '{18}',telefonePai = '{19}',nomeMae = '{20}',telefoneMae = '{21}',nomeCurso = '{22}',codigoTurma = '{23}',statusMatricula = '{24}' WHERE raAluno = {25};", nomeAluno, rg, cpf, dataNascimento, idade, sexo, carteiraTrabalho, email, grauInstrucao, endereco, numero, complemento, bairro, cidade, estado, cep, telefoneAluno, celularAluno, nomePai, telefonePai, nomeMae, telefoneMae, nomeCurso, codigoTurma, statusMatricula, idAluno));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir aluno. ");
            }
        }
        public DataTable RetornarAluno()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno"));
            bd.Desconectar();
            return dt;
        }
        public DataTable RetornarAlunoPorNome(string buscarAluno)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT nomeAluno,rg,cpf,codigoTurma,nomeCurso FROM Aluno WHERE nomeAluno LIKE '%{0}%'",buscarAluno));
            bd.Desconectar();
            return dt;
        }
    }
}
