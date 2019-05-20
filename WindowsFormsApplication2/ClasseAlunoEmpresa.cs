using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class ClasseAlunoEmpresa
    {
        ClasseAcessoBD bd = new ClasseAcessoBD();

        private int idAluno_Empresa { get; set; }
        private float raAluno { get; set; }
        private string nomeAluno { get; set; }
        private string rgAluno { get; set; }
        private string cpfAluno { get; set; }
        private string codigoTurma { get; set; }
        private string nomeCurso { get; set; }
        private int idEmpresa { get; set; }
        private string nomeFantasia { get; set;}
        private string cnpj { get; set;}
        private string responsavel { get; set; }
        public string telefoneResponsavel { get; set; }



        public bool RegistrarAlunoEmpresa()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(String.Format(""));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao registrar. ");
            }
        }
    }
}
