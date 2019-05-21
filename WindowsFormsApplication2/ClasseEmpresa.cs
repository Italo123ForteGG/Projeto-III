using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class ClasseEmpresa
    {
        public int IdEmpresa { get; set; }
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string RazaoSocial { get; set; }
        public string Responsavel { get; set; }
        public int Cep { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        ClasseAcessoBD bd = new ClasseAcessoBD();

        public bool InserirEmpresa()
        {
            try
            {
                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(String.Format("INSERT INTO Empresa (cnpj,nomeFantasia,telefone,email,razaoSocial,responsavel,cep,rua,numero,complemento,bairro,cidade,estado) VALUES ('{0}','{1}',{2},'{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}','{11}','{12}')", Cnpj, NomeFantasia, Telefone, Email, RazaoSocial, Responsavel, Cep, Rua, Numero, Complemento, Bairro, Cidade, Estado));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir aluno. ");
            }
        }

        public DataTable RetornarEmpresa()
        {
            try
            {
                bd.Conectar();
                DataTable dt = bd.RetDataTable(String.Format("SELECT * FROM Empresa"));
                bd.Desconectar();
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao demonstrar tabela. ");
            }
        }
        public DataTable ExibirEmpresa()
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT cnpj,nomeFantasia,responsavel,telefone,idEmpresa FROM Empresa"));
            bd.Desconectar();
            return dt;
        }

        public bool EditarEmpresa(int CodEmpresa)
        {
            try
            {

                //Conecta no banco
                bd.Conectar();

                //Executa o insert
                bd.ExecutarComandosSql(String.Format("UPDATE Empresa SET cnpj = '{0}',nomeFantasia = '{1}',telefone = {2},email = '{3}',razaoSocial = '{4}',responsavel = '{5}',cep = {6},rua = '{7}',numero = {8},complemento = '{9}',bairro = '{10}',cidade = '{11}',estado = '{12}' WHERE idEmpresa = {13}", Cnpj, NomeFantasia, Telefone, Email, RazaoSocial, Responsavel, Cep, Rua, Numero, Complemento, Bairro, Cidade, Estado, CodEmpresa));

                //Desconecta no banco 
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao inserir aluno. ");
            }
        }

        public DataTable RetornarEmpresaPorNome(string buscarEmpresa)
        {
            bd.Conectar();
            DataTable dt = bd.RetDataTable(String.Format("SELECT nomeFantasia,cnpj,responsavel,telefone FROM Empresa WHERE nomeFantasia LIKE '%{0}%'", buscarEmpresa));
            bd.Desconectar();
            return dt;
        }

        public bool ExcluirEmpresa(int CodEmpresa)
        {
            try
            {
                bd.Conectar();
                bd.ExecutarComandosSql(String.Format("DELETE Empresa WHERE idEmpresa = {0};", CodEmpresa));
                bd.Desconectar();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Erro ao excluir empresa");
            }
        }
    }
}
