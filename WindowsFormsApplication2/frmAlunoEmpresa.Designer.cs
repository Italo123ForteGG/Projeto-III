namespace WindowsFormsApplication2
{
    partial class frmAlunoEmpresa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.dgvEmpresas = new System.Windows.Forms.DataGridView();
            this.txtBuscarAluno = new System.Windows.Forms.TextBox();
            this.txtBuscarEmpresa = new System.Windows.Forms.TextBox();
            this.txtNomeFantasia = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblNomeEmpresa = new System.Windows.Forms.Label();
            this.lblNomeAluno2 = new System.Windows.Forms.Label();
            this.lblRegistroAcademico = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblIdentidade = new System.Windows.Forms.Label();
            this.lblCodTurma = new System.Windows.Forms.Label();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.lblNomeFantasia = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCodigoTurma = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblTituloAluno = new System.Windows.Forms.Label();
            this.lblTituloEmpresa = new System.Windows.Forms.Label();
            this.panelAluno = new System.Windows.Forms.Panel();
            this.panelEmpresa = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).BeginInit();
            this.panelAluno.SuspendLayout();
            this.panelEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToOrderColumns = true;
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlunos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunos.Location = new System.Drawing.Point(45, 106);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(309, 150);
            this.dgvAlunos.TabIndex = 0;
            this.dgvAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellContentClick);
            // 
            // dgvEmpresas
            // 
            this.dgvEmpresas.AllowUserToOrderColumns = true;
            this.dgvEmpresas.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpresas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmpresas.Location = new System.Drawing.Point(45, 107);
            this.dgvEmpresas.Name = "dgvEmpresas";
            this.dgvEmpresas.Size = new System.Drawing.Size(300, 150);
            this.dgvEmpresas.TabIndex = 1;
            this.dgvEmpresas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpresas_CellClick);
            // 
            // txtBuscarAluno
            // 
            this.txtBuscarAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAluno.Location = new System.Drawing.Point(162, 77);
            this.txtBuscarAluno.Name = "txtBuscarAluno";
            this.txtBuscarAluno.Size = new System.Drawing.Size(192, 23);
            this.txtBuscarAluno.TabIndex = 2;
            this.txtBuscarAluno.TextChanged += new System.EventHandler(this.txtBuscarAluno_TextChanged);
            // 
            // txtBuscarEmpresa
            // 
            this.txtBuscarEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarEmpresa.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEmpresa.Location = new System.Drawing.Point(182, 76);
            this.txtBuscarEmpresa.Name = "txtBuscarEmpresa";
            this.txtBuscarEmpresa.Size = new System.Drawing.Size(163, 24);
            this.txtBuscarEmpresa.TabIndex = 3;
            this.txtBuscarEmpresa.TextChanged += new System.EventHandler(this.txtBuscarEmpresa_TextChanged);
            // 
            // txtNomeFantasia
            // 
            this.txtNomeFantasia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFantasia.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFantasia.Location = new System.Drawing.Point(160, 330);
            this.txtNomeFantasia.Name = "txtNomeFantasia";
            this.txtNomeFantasia.Size = new System.Drawing.Size(184, 24);
            this.txtNomeFantasia.TabIndex = 4;
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(186, 382);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(191, 24);
            this.txtCpf.TabIndex = 5;
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeAluno.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAluno.Location = new System.Drawing.Point(186, 320);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(191, 24);
            this.txtNomeAluno.TabIndex = 6;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRg.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(186, 351);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(191, 24);
            this.txtRg.TabIndex = 7;
            // 
            // txtRa
            // 
            this.txtRa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRa.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRa.Location = new System.Drawing.Point(186, 289);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(191, 24);
            this.txtRa.TabIndex = 8;
            // 
            // txtCnpj
            // 
            this.txtCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCnpj.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpj.Location = new System.Drawing.Point(160, 297);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(185, 24);
            this.txtCnpj.TabIndex = 9;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(42, 77);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(111, 21);
            this.lblAluno.TabIndex = 10;
            this.lblAluno.Text = "Nome Aluno:";
            // 
            // lblNomeEmpresa
            // 
            this.lblNomeEmpresa.AutoSize = true;
            this.lblNomeEmpresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEmpresa.Location = new System.Drawing.Point(44, 79);
            this.lblNomeEmpresa.Name = "lblNomeEmpresa";
            this.lblNomeEmpresa.Size = new System.Drawing.Size(132, 21);
            this.lblNomeEmpresa.TabIndex = 11;
            this.lblNomeEmpresa.Text = "Nome Empresa:";
            // 
            // lblNomeAluno2
            // 
            this.lblNomeAluno2.AutoSize = true;
            this.lblNomeAluno2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeAluno2.Location = new System.Drawing.Point(65, 323);
            this.lblNomeAluno2.Name = "lblNomeAluno2";
            this.lblNomeAluno2.Size = new System.Drawing.Size(115, 21);
            this.lblNomeAluno2.TabIndex = 13;
            this.lblNomeAluno2.Text = "Nome Aluno: ";
            // 
            // lblRegistroAcademico
            // 
            this.lblRegistroAcademico.AutoSize = true;
            this.lblRegistroAcademico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroAcademico.Location = new System.Drawing.Point(3, 292);
            this.lblRegistroAcademico.Name = "lblRegistroAcademico";
            this.lblRegistroAcademico.Size = new System.Drawing.Size(177, 21);
            this.lblRegistroAcademico.TabIndex = 14;
            this.lblRegistroAcademico.Text = "Registro Acadêmico: ";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(132, 385);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(48, 21);
            this.lblCPF.TabIndex = 15;
            this.lblCPF.Text = "CPF: ";
            // 
            // lblIdentidade
            // 
            this.lblIdentidade.AutoSize = true;
            this.lblIdentidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentidade.Location = new System.Drawing.Point(73, 354);
            this.lblIdentidade.Name = "lblIdentidade";
            this.lblIdentidade.Size = new System.Drawing.Size(107, 21);
            this.lblIdentidade.TabIndex = 16;
            this.lblIdentidade.Text = "Idêntidade: ";
            // 
            // lblCodTurma
            // 
            this.lblCodTurma.AutoSize = true;
            this.lblCodTurma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTurma.Location = new System.Drawing.Point(51, 416);
            this.lblCodTurma.Name = "lblCodTurma";
            this.lblCodTurma.Size = new System.Drawing.Size(129, 21);
            this.lblCodTurma.TabIndex = 17;
            this.lblCodTurma.Text = "Código Turma: ";
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponsavel.Location = new System.Drawing.Point(40, 363);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(115, 21);
            this.lblResponsavel.TabIndex = 28;
            this.lblResponsavel.Text = "Responsável: ";
            // 
            // lblNomeFantasia
            // 
            this.lblNomeFantasia.AutoSize = true;
            this.lblNomeFantasia.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFantasia.Location = new System.Drawing.Point(18, 331);
            this.lblNomeFantasia.Name = "lblNomeFantasia";
            this.lblNomeFantasia.Size = new System.Drawing.Size(136, 21);
            this.lblNomeFantasia.TabIndex = 27;
            this.lblNomeFantasia.Text = "Nome Fantasia: ";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.Location = new System.Drawing.Point(94, 297);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(60, 21);
            this.lblCNPJ.TabIndex = 26;
            this.lblCNPJ.Text = "CNPJ: ";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(118, 444);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(62, 21);
            this.lblCurso.TabIndex = 25;
            this.lblCurso.Text = "Curso: ";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(70, 396);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(84, 21);
            this.lblTelefone.TabIndex = 29;
            this.lblTelefone.Text = "Telefone: ";
            // 
            // txtCodigoTurma
            // 
            this.txtCodigoTurma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoTurma.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoTurma.Location = new System.Drawing.Point(186, 413);
            this.txtCodigoTurma.Name = "txtCodigoTurma";
            this.txtCodigoTurma.Size = new System.Drawing.Size(191, 24);
            this.txtCodigoTurma.TabIndex = 33;
            // 
            // txtCurso
            // 
            this.txtCurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurso.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.Location = new System.Drawing.Point(186, 444);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(191, 24);
            this.txtCurso.TabIndex = 31;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(161, 396);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(186, 24);
            this.txtTelefone.TabIndex = 35;
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResponsavel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponsavel.Location = new System.Drawing.Point(161, 363);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(184, 24);
            this.txtResponsavel.TabIndex = 34;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Green;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(654, 536);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(178, 41);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblTituloAluno
            // 
            this.lblTituloAluno.AutoSize = true;
            this.lblTituloAluno.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAluno.Location = new System.Drawing.Point(157, 20);
            this.lblTituloAluno.Name = "lblTituloAluno";
            this.lblTituloAluno.Size = new System.Drawing.Size(78, 27);
            this.lblTituloAluno.TabIndex = 37;
            this.lblTituloAluno.Text = "Aluno";
            // 
            // lblTituloEmpresa
            // 
            this.lblTituloEmpresa.AutoSize = true;
            this.lblTituloEmpresa.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEmpresa.Location = new System.Drawing.Point(155, 20);
            this.lblTituloEmpresa.Name = "lblTituloEmpresa";
            this.lblTituloEmpresa.Size = new System.Drawing.Size(109, 27);
            this.lblTituloEmpresa.TabIndex = 38;
            this.lblTituloEmpresa.Text = "Empresa";
            // 
            // panelAluno
            // 
            this.panelAluno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAluno.Controls.Add(this.lblTituloAluno);
            this.panelAluno.Controls.Add(this.dgvAlunos);
            this.panelAluno.Controls.Add(this.txtBuscarAluno);
            this.panelAluno.Controls.Add(this.txtCpf);
            this.panelAluno.Controls.Add(this.txtNomeAluno);
            this.panelAluno.Controls.Add(this.txtRg);
            this.panelAluno.Controls.Add(this.txtCodigoTurma);
            this.panelAluno.Controls.Add(this.txtRa);
            this.panelAluno.Controls.Add(this.txtCurso);
            this.panelAluno.Controls.Add(this.lblAluno);
            this.panelAluno.Controls.Add(this.lblNomeAluno2);
            this.panelAluno.Controls.Add(this.lblRegistroAcademico);
            this.panelAluno.Controls.Add(this.lblCPF);
            this.panelAluno.Controls.Add(this.lblIdentidade);
            this.panelAluno.Controls.Add(this.lblCurso);
            this.panelAluno.Controls.Add(this.lblCodTurma);
            this.panelAluno.Location = new System.Drawing.Point(12, 12);
            this.panelAluno.Name = "panelAluno";
            this.panelAluno.Size = new System.Drawing.Size(409, 501);
            this.panelAluno.TabIndex = 39;
            // 
            // panelEmpresa
            // 
            this.panelEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEmpresa.Controls.Add(this.lblTituloEmpresa);
            this.panelEmpresa.Controls.Add(this.dgvEmpresas);
            this.panelEmpresa.Controls.Add(this.txtBuscarEmpresa);
            this.panelEmpresa.Controls.Add(this.txtTelefone);
            this.panelEmpresa.Controls.Add(this.txtNomeFantasia);
            this.panelEmpresa.Controls.Add(this.txtResponsavel);
            this.panelEmpresa.Controls.Add(this.txtCnpj);
            this.panelEmpresa.Controls.Add(this.lblTelefone);
            this.panelEmpresa.Controls.Add(this.lblNomeEmpresa);
            this.panelEmpresa.Controls.Add(this.lblResponsavel);
            this.panelEmpresa.Controls.Add(this.lblCNPJ);
            this.panelEmpresa.Controls.Add(this.lblNomeFantasia);
            this.panelEmpresa.Location = new System.Drawing.Point(439, 12);
            this.panelEmpresa.Name = "panelEmpresa";
            this.panelEmpresa.Size = new System.Drawing.Size(399, 501);
            this.panelEmpresa.TabIndex = 38;
            // 
            // frmAlunoEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 595);
            this.Controls.Add(this.panelEmpresa);
            this.Controls.Add(this.panelAluno);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlunoEmpresa";
            this.Text = "frmAlunoEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresas)).EndInit();
            this.panelAluno.ResumeLayout(false);
            this.panelAluno.PerformLayout();
            this.panelEmpresa.ResumeLayout(false);
            this.panelEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.DataGridView dgvEmpresas;
        private System.Windows.Forms.TextBox txtBuscarAluno;
        private System.Windows.Forms.TextBox txtBuscarEmpresa;
        private System.Windows.Forms.TextBox txtNomeFantasia;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblNomeEmpresa;
        private System.Windows.Forms.Label lblNomeAluno2;
        private System.Windows.Forms.Label lblRegistroAcademico;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblIdentidade;
        private System.Windows.Forms.Label lblCodTurma;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Label lblNomeFantasia;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCodigoTurma;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblTituloAluno;
        private System.Windows.Forms.Label lblTituloEmpresa;
        private System.Windows.Forms.Panel panelAluno;
        private System.Windows.Forms.Panel panelEmpresa;
    }
}