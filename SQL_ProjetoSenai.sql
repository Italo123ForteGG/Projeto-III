CREATE DATABASE DbProjetoSenai11
GO
USE DbProjetoSenai11
-- DROP DATABASE DbProjetoSenai11
GO
CREATE TABLE Aluno(
	raAluno				FLOAT PRIMARY KEY,
	nomeAluno			VARCHAR(600),
	rg					VARCHAR(100),
	cpf					VARCHAR(110),
	dataNascimento		VARCHAR(100),
	idade				INT,
	sexo				CHAR(10),
	carteiraTrabalho	VARCHAR(200),
	email				VARCHAR(500),
	grauInstrucao		VARCHAR(300),
	endereco			VARCHAR(300),
	numero				INT,
	complemento			VARCHAR(100),
	bairro				VARCHAR(400),
	cidade				VARCHAR(400),
	estado				CHAR(20),
	cep					VARCHAR(80),
	telefoneAluno		VARCHAR(110),
	celularAluno		VARCHAR(110),
	nomePai				VARCHAR(600),
	telefonePai			VARCHAR(110),
	nomeMae				VARCHAR(600),
	telefoneMae			VARCHAR(110),
	nomeCurso			VARCHAR(300),
	codigoTurma			VARCHAR(100),
	statusMatricula		VARCHAR(200),						
	);
	   
INSERT INTO Aluno (raAluno,nomeAluno,rg,cpf,dataNascimento,idade,sexo,carteiraTrabalho,email,grauInstrucao,endereco,numero,complemento,bairro,cidade,estado,cep,telefoneAluno,celularAluno,nomePai,telefonePai,nomeMae,telefoneMae,nomeCurso,codigoTurma,statusMatricula) VALUES (006578655,'Henrique Pereira Pacheco','MG17654563','11154865645','09/08/2000',18,'M','61566314','henriquepacheco2015@hotmail.com','Ensino Médio Completo','Rua Estela',45,'CX 3','Piratininga','Belo Horizonte','MG','31573485','3134529565','31991867548','Pedro Augusto Pacheco','31997546851','Marília Carolina de Paula Pacheco','31998546254','Técnico em Informática','TI21 T','Matriculado')


CREATE TABLE Periodo(
	idPeriodo			INT IDENTITY(1,1) PRIMARY KEY,
	nomePeriodo				VARCHAR(15)
	);

INSERT INTO Periodo(nomePeriodo) VALUES ('2019-1')

CREATE TABLE Empresa (
	idEmpresa    INT IDENTITY(1,1) PRIMARY KEY,
	cnpj		 VARCHAR(20),
	nomeFantasia VARCHAR(45),
	telefone	 VARCHAR(20),
	email		 VARCHAR(100),
	razaoSocial  VARCHAR(50),
	responsavel  VARCHAR(150),

	cep			 CHAR(9),
	rua			 VARCHAR(80),
	numero		 INT,
	complemento  VARCHAR(20),
	bairro		 VARCHAR(50),
	cidade		 VARCHAR(30),
	estado		 CHAR(2)
);

CREATE TABLE Aluno_Empresa(
	idAluno_Empresa			INT IDENTITY(1,1) PRIMARY KEY,
	Aluno_raAluno			FLOAT,
	nomeAluno				VARCHAR (60),
	rgAluno					VARCHAR(11),
	cpfAluno				VARCHAR(11),
	codigoTurma				VARCHAR(10),
	nomeCurso				VARCHAR(30),
	Empresa_idEmpresa		INT,
	nomeFantasia			VARCHAR(45),
	cnpj					VARCHAR(20),
	responsavel				VARCHAR(60),
	tefefoneResponsavel		VARCHAR(12),
	FOREIGN KEY (Empresa_idEmpresa) REFERENCES Empresa(idEmpresa),
	FOREIGN KEY(Aluno_raAluno) REFERENCES Aluno(raAluno)
	);

INSERT INTO Empresa(cnpj, nomeFantasia, telefone, email, razaoSocial, responsavel, cep, rua, numero, complemento, bairro, cidade, estado) VALUES ('42.524.123/0001-71','Telemont','31 34487100','ouvidoria@telemont.com.br','Telemont Engenharia e Telecomunicações','Isis Ribeiro','31255-210','Rua Alcobaça','1270','Edifício 10','São Francisco','Belo Horizonte','MG')
INSERT INTO Aluno_Empresa (Aluno_raAluno,nomeAluno,rgAluno,cpfAluno,codigoTurma,nomeCurso,Empresa_idEmpresa,nomeFantasia,cnpj,responsavel,tefefoneResponsavel) VALUES ('6578655','Henrique Pereira Pacheco','MG17654563','11154865645','TI21 T','Técnico em Informática',1,'Telemont','42.524.123/0001-71','Isis Ribeiro','31 34487100');


SELECT*FROM Aluno;
SELECT*FROM Empresa;
SELECT*FROM Periodo;


--UPDATE Aluno SET nomeAluno = 'dd',rg = 'dd',cpf = 'dd',dataNascimento = 'dd',idade = 11,sexo = 'dd',carteiraTrabalho = 'dd',email = 'dd',grauInstrucao = 'dd',endereco = 'dd',numero = 11,complemento = 'dd',bairro = 'dd',cidade = 'dd',estado = 'dd',cep = 'dd',telefoneAluno = 'dd',celularAluno = 'dd',nomePai = 'dd',telefonePai = 'dd',nomeMae = 'dd',telefoneMae = 'dd',nomeCurso = 'dd',codigoTurma = 'dd',statusMatricula = 'dd' WHERE raAluno = 10808;
--SELECT*FROM Aluno WHERE raAluno = 108;
--DELETE Aluno;