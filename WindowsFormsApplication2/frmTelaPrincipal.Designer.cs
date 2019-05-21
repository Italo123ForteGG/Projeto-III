namespace WindowsFormsApplication2
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.pnOpcoes = new System.Windows.Forms.Panel();
            this.btnEncaminharAlunos = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnLeitorExcel = new System.Windows.Forms.Button();
            this.pnImportarAlunos = new System.Windows.Forms.Panel();
            this.pnAluno = new System.Windows.Forms.Panel();
            this.pnEmpresa = new System.Windows.Forms.Panel();
            this.pnEncaminharAlunos = new System.Windows.Forms.Panel();
            this.pnCima = new System.Windows.Forms.Panel();
            this.pnContem = new System.Windows.Forms.Panel();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.picTelaInicial = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnOpcoes.SuspendLayout();
            this.pnContem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTelaInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnOpcoes
            // 
            this.pnOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnOpcoes.Controls.Add(this.picTelaInicial);
            this.pnOpcoes.Controls.Add(this.picFechar);
            this.pnOpcoes.Controls.Add(this.pnEncaminharAlunos);
            this.pnOpcoes.Controls.Add(this.pnEmpresa);
            this.pnOpcoes.Controls.Add(this.pnAluno);
            this.pnOpcoes.Controls.Add(this.pnImportarAlunos);
            this.pnOpcoes.Controls.Add(this.btnEncaminharAlunos);
            this.pnOpcoes.Controls.Add(this.btnEmpresa);
            this.pnOpcoes.Controls.Add(this.btnAluno);
            this.pnOpcoes.Controls.Add(this.btnLeitorExcel);
            this.pnOpcoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnOpcoes.Location = new System.Drawing.Point(0, 0);
            this.pnOpcoes.Name = "pnOpcoes";
            this.pnOpcoes.Size = new System.Drawing.Size(258, 607);
            this.pnOpcoes.TabIndex = 0;
            this.pnOpcoes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnOpcoes_MouseDown);
            // 
            // btnEncaminharAlunos
            // 
            this.btnEncaminharAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncaminharAlunos.FlatAppearance.BorderSize = 0;
            this.btnEncaminharAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncaminharAlunos.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncaminharAlunos.ForeColor = System.Drawing.Color.White;
            this.btnEncaminharAlunos.Image = ((System.Drawing.Image)(resources.GetObject("btnEncaminharAlunos.Image")));
            this.btnEncaminharAlunos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEncaminharAlunos.Location = new System.Drawing.Point(19, 290);
            this.btnEncaminharAlunos.Name = "btnEncaminharAlunos";
            this.btnEncaminharAlunos.Size = new System.Drawing.Size(239, 50);
            this.btnEncaminharAlunos.TabIndex = 3;
            this.btnEncaminharAlunos.Text = "Encaminhar Alunos";
            this.btnEncaminharAlunos.UseVisualStyleBackColor = true;
            this.btnEncaminharAlunos.Click += new System.EventHandler(this.btnEncaminharAlunos_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.FlatAppearance.BorderSize = 0;
            this.btnEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresa.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpresa.Image")));
            this.btnEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpresa.Location = new System.Drawing.Point(19, 228);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(239, 50);
            this.btnEmpresa.TabIndex = 2;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAluno.FlatAppearance.BorderSize = 0;
            this.btnAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAluno.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.Color.White;
            this.btnAluno.Image = ((System.Drawing.Image)(resources.GetObject("btnAluno.Image")));
            this.btnAluno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAluno.Location = new System.Drawing.Point(19, 166);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(239, 50);
            this.btnAluno.TabIndex = 1;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnLeitorExcel
            // 
            this.btnLeitorExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLeitorExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeitorExcel.FlatAppearance.BorderSize = 0;
            this.btnLeitorExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeitorExcel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeitorExcel.ForeColor = System.Drawing.Color.White;
            this.btnLeitorExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnLeitorExcel.Image")));
            this.btnLeitorExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeitorExcel.Location = new System.Drawing.Point(19, 104);
            this.btnLeitorExcel.Name = "btnLeitorExcel";
            this.btnLeitorExcel.Size = new System.Drawing.Size(239, 50);
            this.btnLeitorExcel.TabIndex = 0;
            this.btnLeitorExcel.Text = "Importar Alunos";
            this.btnLeitorExcel.UseVisualStyleBackColor = true;
            this.btnLeitorExcel.Click += new System.EventHandler(this.btnLeitorExcel_Click);
            // 
            // pnImportarAlunos
            // 
            this.pnImportarAlunos.BackColor = System.Drawing.Color.Crimson;
            this.pnImportarAlunos.Location = new System.Drawing.Point(3, 104);
            this.pnImportarAlunos.Name = "pnImportarAlunos";
            this.pnImportarAlunos.Size = new System.Drawing.Size(12, 50);
            this.pnImportarAlunos.TabIndex = 4;
            // 
            // pnAluno
            // 
            this.pnAluno.BackColor = System.Drawing.Color.Crimson;
            this.pnAluno.Location = new System.Drawing.Point(3, 166);
            this.pnAluno.Name = "pnAluno";
            this.pnAluno.Size = new System.Drawing.Size(12, 50);
            this.pnAluno.TabIndex = 5;
            this.pnAluno.Visible = false;
            // 
            // pnEmpresa
            // 
            this.pnEmpresa.BackColor = System.Drawing.Color.Crimson;
            this.pnEmpresa.Location = new System.Drawing.Point(3, 228);
            this.pnEmpresa.Name = "pnEmpresa";
            this.pnEmpresa.Size = new System.Drawing.Size(12, 50);
            this.pnEmpresa.TabIndex = 5;
            this.pnEmpresa.Visible = false;
            // 
            // pnEncaminharAlunos
            // 
            this.pnEncaminharAlunos.BackColor = System.Drawing.Color.Crimson;
            this.pnEncaminharAlunos.Location = new System.Drawing.Point(3, 290);
            this.pnEncaminharAlunos.Name = "pnEncaminharAlunos";
            this.pnEncaminharAlunos.Size = new System.Drawing.Size(12, 50);
            this.pnEncaminharAlunos.TabIndex = 6;
            this.pnEncaminharAlunos.Visible = false;
            // 
            // pnCima
            // 
            this.pnCima.BackColor = System.Drawing.Color.Crimson;
            this.pnCima.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCima.Location = new System.Drawing.Point(258, 0);
            this.pnCima.Name = "pnCima";
            this.pnCima.Size = new System.Drawing.Size(850, 12);
            this.pnCima.TabIndex = 1;
            this.pnCima.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnCima_MouseDown);
            // 
            // pnContem
            // 
            this.pnContem.BackColor = System.Drawing.Color.White;
            this.pnContem.Controls.Add(this.pictureBox1);
            this.pnContem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContem.Location = new System.Drawing.Point(258, 12);
            this.pnContem.Name = "pnContem";
            this.pnContem.Size = new System.Drawing.Size(850, 595);
            this.pnContem.TabIndex = 2;
            this.pnContem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnContem_MouseDown);
            // 
            // picFechar
            // 
            this.picFechar.Image = ((System.Drawing.Image)(resources.GetObject("picFechar.Image")));
            this.picFechar.Location = new System.Drawing.Point(54, 549);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(43, 34);
            this.picFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFechar.TabIndex = 7;
            this.picFechar.TabStop = false;
            // 
            // picTelaInicial
            // 
            this.picTelaInicial.Image = ((System.Drawing.Image)(resources.GetObject("picTelaInicial.Image")));
            this.picTelaInicial.Location = new System.Drawing.Point(156, 549);
            this.picTelaInicial.Name = "picTelaInicial";
            this.picTelaInicial.Size = new System.Drawing.Size(43, 34);
            this.picTelaInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTelaInicial.TabIndex = 7;
            this.picTelaInicial.TabStop = false;
            this.picTelaInicial.Click += new System.EventHandler(this.picTelaInicial_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 607);
            this.Controls.Add(this.pnContem);
            this.Controls.Add(this.pnCima);
            this.Controls.Add(this.pnOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnOpcoes.ResumeLayout(false);
            this.pnContem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTelaInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnOpcoes;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnLeitorExcel;
        private System.Windows.Forms.Button btnEncaminharAlunos;
        private System.Windows.Forms.Panel pnEncaminharAlunos;
        private System.Windows.Forms.Panel pnEmpresa;
        private System.Windows.Forms.Panel pnAluno;
        private System.Windows.Forms.Panel pnImportarAlunos;
        private System.Windows.Forms.Panel pnCima;
        private System.Windows.Forms.Panel pnContem;
        private System.Windows.Forms.PictureBox picTelaInicial;
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}