namespace WindowsFormsApplication2
{
    partial class frmManterAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtCarteiraTrabalho = new System.Windows.Forms.TextBox();
            this.lblCarteiraTrabalho = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtGrauInstrucao = new System.Windows.Forms.TextBox();
            this.lblGrauInstrucao = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtTelefone1 = new System.Windows.Forms.TextBox();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.txtTelefone2 = new System.Windows.Forms.TextBox();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.lblNomePai = new System.Windows.Forms.Label();
            this.txtTelefonePai = new System.Windows.Forms.TextBox();
            this.lblTelefonePai = new System.Windows.Forms.Label();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.lblNomeMae = new System.Windows.Forms.Label();
            this.txtTelefoneMae = new System.Windows.Forms.TextBox();
            this.lblTelefoneMae = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblRegistroAcademico = new System.Windows.Forms.Label();
            this.lblNomeCurso = new System.Windows.Forms.Label();
            this.txtCodigoTurma = new System.Windows.Forms.TextBox();
            this.lblCodTurma = new System.Windows.Forms.Label();
            this.txtNomeCurso = new System.Windows.Forms.TextBox();
            this.txtStatusMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(31, 105);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(869, 507);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(94, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 24);
            this.txtNome.TabIndex = 3;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(82, 135);
            this.txtRg.MaxLength = 11;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(228, 24);
            this.txtRg.TabIndex = 8;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(31, 136);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(34, 21);
            this.lblRG.TabIndex = 7;
            this.lblRG.Text = "RG";
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(111, 165);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(135, 24);
            this.txtCpf.TabIndex = 10;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(31, 167);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 21);
            this.lblCPF.TabIndex = 9;
            this.lblCPF.Text = "CPF";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataNascimento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataNascimento.Location = new System.Drawing.Point(190, 195);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(111, 24);
            this.txtDataNascimento.TabIndex = 12;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(31, 198);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(174, 21);
            this.lblDataNascimento.TabIndex = 11;
            this.lblDataNascimento.Text = "Data de Nascimento";
            // 
            // txtIdade
            // 
            this.txtIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdade.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(111, 231);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(37, 24);
            this.txtIdade.TabIndex = 14;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(31, 229);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(58, 21);
            this.lblIdade.TabIndex = 13;
            this.lblIdade.Text = "Idade";
            // 
            // txtSexo
            // 
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSexo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(111, 261);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(120, 24);
            this.txtSexo.TabIndex = 16;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(31, 260);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 21);
            this.lblSexo.TabIndex = 15;
            this.lblSexo.Text = "Sexo";
            // 
            // txtCarteiraTrabalho
            // 
            this.txtCarteiraTrabalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarteiraTrabalho.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarteiraTrabalho.Location = new System.Drawing.Point(189, 291);
            this.txtCarteiraTrabalho.Name = "txtCarteiraTrabalho";
            this.txtCarteiraTrabalho.Size = new System.Drawing.Size(138, 24);
            this.txtCarteiraTrabalho.TabIndex = 18;
            // 
            // lblCarteiraTrabalho
            // 
            this.lblCarteiraTrabalho.AutoSize = true;
            this.lblCarteiraTrabalho.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteiraTrabalho.Location = new System.Drawing.Point(31, 291);
            this.lblCarteiraTrabalho.Name = "lblCarteiraTrabalho";
            this.lblCarteiraTrabalho.Size = new System.Drawing.Size(173, 21);
            this.lblCarteiraTrabalho.TabIndex = 17;
            this.lblCarteiraTrabalho.Text = "Carteira de Trabalho";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(111, 321);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 24);
            this.txtEmail.TabIndex = 20;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(31, 322);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // txtGrauInstrucao
            // 
            this.txtGrauInstrucao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGrauInstrucao.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrauInstrucao.Location = new System.Drawing.Point(190, 351);
            this.txtGrauInstrucao.Name = "txtGrauInstrucao";
            this.txtGrauInstrucao.Size = new System.Drawing.Size(137, 24);
            this.txtGrauInstrucao.TabIndex = 22;
            // 
            // lblGrauInstrucao
            // 
            this.lblGrauInstrucao.AutoSize = true;
            this.lblGrauInstrucao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrauInstrucao.Location = new System.Drawing.Point(31, 353);
            this.lblGrauInstrucao.Name = "lblGrauInstrucao";
            this.lblGrauInstrucao.Size = new System.Drawing.Size(153, 21);
            this.lblGrauInstrucao.TabIndex = 21;
            this.lblGrauInstrucao.Text = "Grau de Instrução";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(426, 129);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(203, 24);
            this.txtEndereco.TabIndex = 24;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(335, 129);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(85, 21);
            this.lblEndereco.TabIndex = 23;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumero.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(426, 159);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(76, 24);
            this.txtNumero.TabIndex = 26;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(348, 159);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(72, 21);
            this.lblNumero.TabIndex = 25;
            this.lblNumero.Text = "Número";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComplemento.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(529, 189);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(100, 24);
            this.txtComplemento.TabIndex = 28;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(399, 190);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(124, 21);
            this.lblComplemento.TabIndex = 27;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(227, 233);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(100, 24);
            this.txtBairro.TabIndex = 30;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(164, 230);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(53, 21);
            this.lblBairro.TabIndex = 29;
            this.lblBairro.Text = "Bairro";
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(445, 353);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 24);
            this.txtEstado.TabIndex = 32;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(371, 349);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 21);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado";
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCep.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(464, 99);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(165, 24);
            this.txtCep.TabIndex = 34;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(417, 99);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 21);
            this.lblCEP.TabIndex = 33;
            this.lblCEP.Text = "CEP";
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone1.Location = new System.Drawing.Point(723, 94);
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(100, 24);
            this.txtTelefone1.TabIndex = 36;
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1.Location = new System.Drawing.Point(619, 94);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(89, 21);
            this.lblTelefone1.TabIndex = 35;
            this.lblTelefone1.Text = "Telefone 1";
            // 
            // txtTelefone2
            // 
            this.txtTelefone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone2.Location = new System.Drawing.Point(723, 132);
            this.txtTelefone2.Name = "txtTelefone2";
            this.txtTelefone2.Size = new System.Drawing.Size(100, 24);
            this.txtTelefone2.TabIndex = 38;
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.Location = new System.Drawing.Point(619, 132);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(89, 21);
            this.lblTelefone2.TabIndex = 37;
            this.lblTelefone2.Text = "Telefone 2";
            // 
            // txtNomePai
            // 
            this.txtNomePai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomePai.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePai.Location = new System.Drawing.Point(723, 170);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(100, 24);
            this.txtNomePai.TabIndex = 40;
            // 
            // lblNomePai
            // 
            this.lblNomePai.AutoSize = true;
            this.lblNomePai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePai.Location = new System.Drawing.Point(599, 170);
            this.lblNomePai.Name = "lblNomePai";
            this.lblNomePai.Size = new System.Drawing.Size(109, 21);
            this.lblNomePai.TabIndex = 39;
            this.lblNomePai.Text = "Nome do Pai";
            // 
            // txtTelefonePai
            // 
            this.txtTelefonePai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonePai.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonePai.Location = new System.Drawing.Point(723, 208);
            this.txtTelefonePai.Name = "txtTelefonePai";
            this.txtTelefonePai.Size = new System.Drawing.Size(100, 24);
            this.txtTelefonePai.TabIndex = 42;
            // 
            // lblTelefonePai
            // 
            this.lblTelefonePai.AutoSize = true;
            this.lblTelefonePai.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonePai.Location = new System.Drawing.Point(580, 208);
            this.lblTelefonePai.Name = "lblTelefonePai";
            this.lblTelefonePai.Size = new System.Drawing.Size(128, 21);
            this.lblTelefonePai.TabIndex = 41;
            this.lblTelefonePai.Text = "Telefone do Pai";
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeMae.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMae.Location = new System.Drawing.Point(723, 246);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(100, 24);
            this.txtNomeMae.TabIndex = 44;
            // 
            // lblNomeMae
            // 
            this.lblNomeMae.AutoSize = true;
            this.lblNomeMae.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMae.Location = new System.Drawing.Point(585, 246);
            this.lblNomeMae.Name = "lblNomeMae";
            this.lblNomeMae.Size = new System.Drawing.Size(123, 21);
            this.lblNomeMae.TabIndex = 43;
            this.lblNomeMae.Text = "Nome da Mãe";
            // 
            // txtTelefoneMae
            // 
            this.txtTelefoneMae.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneMae.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneMae.Location = new System.Drawing.Point(723, 284);
            this.txtTelefoneMae.Name = "txtTelefoneMae";
            this.txtTelefoneMae.Size = new System.Drawing.Size(100, 24);
            this.txtTelefoneMae.TabIndex = 46;
            // 
            // lblTelefoneMae
            // 
            this.lblTelefoneMae.AutoSize = true;
            this.lblTelefoneMae.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefoneMae.Location = new System.Drawing.Point(566, 284);
            this.lblTelefoneMae.Name = "lblTelefoneMae";
            this.lblTelefoneMae.Size = new System.Drawing.Size(142, 21);
            this.lblTelefoneMae.TabIndex = 45;
            this.lblTelefoneMae.Text = "Telefone da Mãe";
            // 
            // txtCidade
            // 
            this.txtCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidade.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(445, 312);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 24);
            this.txtCidade.TabIndex = 50;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(366, 309);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(69, 21);
            this.lblCidade.TabIndex = 49;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(274, 18);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(100, 24);
            this.txtBusca.TabIndex = 52;
            // 
            // lblRegistroAcademico
            // 
            this.lblRegistroAcademico.AutoSize = true;
            this.lblRegistroAcademico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroAcademico.Location = new System.Drawing.Point(21, 15);
            this.lblRegistroAcademico.Name = "lblRegistroAcademico";
            this.lblRegistroAcademico.Size = new System.Drawing.Size(247, 21);
            this.lblRegistroAcademico.TabIndex = 51;
            this.lblRegistroAcademico.Text = "Registo Acadêmico do Aluno: ";
            // 
            // lblNomeCurso
            // 
            this.lblNomeCurso.AutoSize = true;
            this.lblNomeCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCurso.Location = new System.Drawing.Point(578, 398);
            this.lblNomeCurso.Name = "lblNomeCurso";
            this.lblNomeCurso.Size = new System.Drawing.Size(130, 21);
            this.lblNomeCurso.TabIndex = 53;
            this.lblNomeCurso.Text = "Nome do Curso";
            // 
            // txtCodigoTurma
            // 
            this.txtCodigoTurma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoTurma.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoTurma.Location = new System.Drawing.Point(723, 322);
            this.txtCodigoTurma.Name = "txtCodigoTurma";
            this.txtCodigoTurma.Size = new System.Drawing.Size(100, 24);
            this.txtCodigoTurma.TabIndex = 56;
            // 
            // lblCodTurma
            // 
            this.lblCodTurma.AutoSize = true;
            this.lblCodTurma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTurma.Location = new System.Drawing.Point(561, 322);
            this.lblCodTurma.Name = "lblCodTurma";
            this.lblCodTurma.Size = new System.Drawing.Size(147, 21);
            this.lblCodTurma.TabIndex = 55;
            this.lblCodTurma.Text = "Código da Turma";
            // 
            // txtNomeCurso
            // 
            this.txtNomeCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCurso.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCurso.Location = new System.Drawing.Point(722, 398);
            this.txtNomeCurso.Name = "txtNomeCurso";
            this.txtNomeCurso.Size = new System.Drawing.Size(100, 24);
            this.txtNomeCurso.TabIndex = 57;
            // 
            // txtStatusMatricula
            // 
            this.txtStatusMatricula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatusMatricula.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusMatricula.Location = new System.Drawing.Point(723, 360);
            this.txtStatusMatricula.Name = "txtStatusMatricula";
            this.txtStatusMatricula.Size = new System.Drawing.Size(100, 24);
            this.txtStatusMatricula.TabIndex = 59;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(566, 360);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(138, 21);
            this.lblMatricula.TabIndex = 58;
            this.lblMatricula.Text = "Status Matrícula";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(386, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 60;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // frmManterAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 595);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtStatusMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.txtNomeCurso);
            this.Controls.Add(this.txtCodigoTurma);
            this.Controls.Add(this.lblCodTurma);
            this.Controls.Add(this.lblNomeCurso);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.lblRegistroAcademico);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtTelefoneMae);
            this.Controls.Add(this.lblTelefoneMae);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.lblNomeMae);
            this.Controls.Add(this.txtTelefonePai);
            this.Controls.Add(this.lblTelefonePai);
            this.Controls.Add(this.txtNomePai);
            this.Controls.Add(this.lblNomePai);
            this.Controls.Add(this.txtTelefone2);
            this.Controls.Add(this.lblTelefone2);
            this.Controls.Add(this.txtTelefone1);
            this.Controls.Add(this.lblTelefone1);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.lblComplemento);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtGrauInstrucao);
            this.Controls.Add(this.lblGrauInstrucao);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtCarteiraTrabalho);
            this.Controls.Add(this.lblCarteiraTrabalho);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManterAlunos";
            this.Text = "frmManterAlunos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtCarteiraTrabalho;
        private System.Windows.Forms.Label lblCarteiraTrabalho;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtGrauInstrucao;
        private System.Windows.Forms.Label lblGrauInstrucao;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtTelefone1;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.TextBox txtTelefone2;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.Label lblNomePai;
        private System.Windows.Forms.TextBox txtTelefonePai;
        private System.Windows.Forms.Label lblTelefonePai;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label lblNomeMae;
        private System.Windows.Forms.TextBox txtTelefoneMae;
        private System.Windows.Forms.Label lblTelefoneMae;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label lblRegistroAcademico;
        private System.Windows.Forms.Label lblNomeCurso;
        private System.Windows.Forms.TextBox txtCodigoTurma;
        private System.Windows.Forms.Label lblCodTurma;
        private System.Windows.Forms.TextBox txtNomeCurso;
        private System.Windows.Forms.TextBox txtStatusMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Button btnBuscar;
    }
}