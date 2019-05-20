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
            this.pnOpcoes = new System.Windows.Forms.Panel();
            this.btnEncaminharAlunos = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnLeitorExcel = new System.Windows.Forms.Button();
            this.pnOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnOpcoes
            // 
            this.pnOpcoes.BackColor = System.Drawing.Color.Red;
            this.pnOpcoes.Controls.Add(this.btnEncaminharAlunos);
            this.pnOpcoes.Controls.Add(this.btnEmpresa);
            this.pnOpcoes.Controls.Add(this.btnAluno);
            this.pnOpcoes.Controls.Add(this.btnLeitorExcel);
            this.pnOpcoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnOpcoes.Location = new System.Drawing.Point(0, 0);
            this.pnOpcoes.Name = "pnOpcoes";
            this.pnOpcoes.Size = new System.Drawing.Size(258, 663);
            this.pnOpcoes.TabIndex = 0;
            // 
            // btnEncaminharAlunos
            // 
            this.btnEncaminharAlunos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncaminharAlunos.ForeColor = System.Drawing.Color.Black;
            this.btnEncaminharAlunos.Location = new System.Drawing.Point(3, 309);
            this.btnEncaminharAlunos.Name = "btnEncaminharAlunos";
            this.btnEncaminharAlunos.Size = new System.Drawing.Size(252, 45);
            this.btnEncaminharAlunos.TabIndex = 3;
            this.btnEncaminharAlunos.Text = "Encaminhar Alunos";
            this.btnEncaminharAlunos.UseVisualStyleBackColor = true;
            this.btnEncaminharAlunos.Click += new System.EventHandler(this.btnEncaminharAlunos_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresa.ForeColor = System.Drawing.Color.Black;
            this.btnEmpresa.Location = new System.Drawing.Point(3, 261);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(252, 45);
            this.btnEmpresa.TabIndex = 2;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.UseVisualStyleBackColor = true;
            this.btnEmpresa.Click += new System.EventHandler(this.btnEmpresa_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAluno.ForeColor = System.Drawing.Color.Black;
            this.btnAluno.Location = new System.Drawing.Point(3, 210);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(252, 45);
            this.btnAluno.TabIndex = 1;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnLeitorExcel
            // 
            this.btnLeitorExcel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeitorExcel.ForeColor = System.Drawing.Color.Black;
            this.btnLeitorExcel.Location = new System.Drawing.Point(3, 159);
            this.btnLeitorExcel.Name = "btnLeitorExcel";
            this.btnLeitorExcel.Size = new System.Drawing.Size(252, 45);
            this.btnLeitorExcel.TabIndex = 0;
            this.btnLeitorExcel.Text = "Importar Alunos";
            this.btnLeitorExcel.UseVisualStyleBackColor = true;
            this.btnLeitorExcel.Click += new System.EventHandler(this.btnLeitorExcel_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1243, 663);
            this.Controls.Add(this.pnOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnOpcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnOpcoes;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnLeitorExcel;
        private System.Windows.Forms.Button btnEncaminharAlunos;
    }
}