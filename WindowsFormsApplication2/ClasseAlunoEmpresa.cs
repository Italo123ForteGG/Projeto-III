using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication2
{
    class ClasseAlunoEmpresa
    {
        ClasseAcessoBD bd = new ClasseAcessoBD();

        public int idAluno_Empresa { get; set; }
        public float raAluno { get; set; }
        public string nomeAluno { get; set; }
        public string rgAluno { get; set; }
        public string cpfAluno { get; set; }
        public string codigoTurma { get; set; }
        public string nomeCurso { get; set; }
        public int idEmpresa { get; set; }
        public string nomeFantasia { get; set;}
        public string cnpj { get; set;}
        public string responsavel { get; set; }
        public string telefoneResponsavel { get; set; }



        public bool RegistrarAlunoEmpresa()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Aluno_Empresa (raAluno,nomeAluno,rgAluno,cpfAluno,codigoTurma,nomeCurso,idEmpresa,nomeFantasia,cnpj,responsavel,tefefoneResponsavel) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}')",raAluno,nomeAluno,rgAluno,cpfAluno,codigoTurma,nomeCurso,idEmpresa,nomeFantasia,cnpj,responsavel,telefoneResponsavel));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao encaminhar aluno para empresa. ");
            }
        }
        public DataTable RetornarAlunoEmpresa()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Aluno_Empresa"));
            bd.Desconectar();
            return dt;
        }
    }
}
