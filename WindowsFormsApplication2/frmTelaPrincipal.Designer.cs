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
            this.pnVisualizarEncaminhados = new System.Windows.Forms.Panel();
            this.pntelaPrincipal = new System.Windows.Forms.Panel();
            this.btnVisualizarEncaminhados = new System.Windows.Forms.Button();
            this.pn3 = new System.Windows.Forms.Panel();
            this.btnTelaPrincipal = new System.Windows.Forms.Button();
            this.pn4 = new System.Windows.Forms.Panel();
            this.pn1 = new System.Windows.Forms.Panel();
            this.pn2 = new System.Windows.Forms.Panel();
            this.picFechar = new System.Windows.Forms.PictureBox();
            this.pnEncaminharAlunos = new System.Windows.Forms.Panel();
            this.pnEmpresa = new System.Windows.Forms.Panel();
            this.pnAluno = new System.Windows.Forms.Panel();
            this.pnImportarAlunos = new System.Windows.Forms.Panel();
            this.btnEncaminharAlunos = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnLeitorExcel = new System.Windows.Forms.Button();
            this.pnCima = new System.Windows.Forms.Panel();
            this.pnContem = new System.Windows.Forms.Panel();
            this.pnOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnOpcoes
            // 
            this.pnOpcoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnOpcoes.Controls.Add(this.pnVisualizarEncaminhados);
            this.pnOpcoes.Controls.Add(this.pntelaPrincipal);
            this.pnOpcoes.Controls.Add(this.btnVisualizarEncaminhados);
            this.pnOpcoes.Controls.Add(this.pn3);
            this.pnOpcoes.Controls.Add(this.btnTelaPrincipal);
            this.pnOpcoes.Controls.Add(this.pn4);
            this.pnOpcoes.Controls.Add(this.pn1);
            this.pnOpcoes.Controls.Add(this.pn2);
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
            // pnVisualizarEncaminhados
            // 
            this.pnVisualizarEncaminhados.BackColor = System.Drawing.Color.Crimson;
            this.pnVisualizarEncaminhados.Location = new System.Drawing.Point(3, 346);
            this.pnVisualizarEncaminhados.Name = "pnVisualizarEncaminhados";
            this.pnVisualizarEncaminhados.Size = new System.Drawing.Size(12, 50);
            this.pnVisualizarEncaminhados.TabIndex = 10;
            this.pnVisualizarEncaminhados.Visible = false;
            // 
            // pntelaPrincipal
            // 
            this.pntelaPrincipal.BackColor = System.Drawing.Color.Crimson;
            this.pntelaPrincipal.Location = new System.Drawing.Point(3, 402);
            this.pntelaPrincipal.Name = "pntelaPrincipal";
            this.pntelaPrincipal.Size = new System.Drawing.Size(12, 50);
            this.pntelaPrincipal.TabIndex = 8;
            this.pntelaPrincipal.Visible = false;
            // 
            // btnVisualizarEncaminhados
            // 
            this.btnVisualizarEncaminhados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizarEncaminhados.FlatAppearance.BorderSize = 0;
            this.btnVisualizarEncaminhados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarEncaminhados.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarEncaminhados.ForeColor = System.Drawing.Color.White;
            this.btnVisualizarEncaminhados.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarEncaminhados.Image")));
            this.btnVisualizarEncaminhados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVisualizarEncaminhados.Location = new System.Drawing.Point(19, 346);
            this.btnVisualizarEncaminhados.Name = "btnVisualizarEncaminhados";
            this.btnVisualizarEncaminhados.Size = new System.Drawing.Size(239, 50);
            this.btnVisualizarEncaminhados.TabIndex = 9;
            this.btnVisualizarEncaminhados.Text = "Visualizar ";
            this.btnVisualizarEncaminhados.UseVisualStyleBackColor = true;
            this.btnVisualizarEncaminhados.Click += new System.EventHandler(this.btnVisualizarEncaminhados_Click);
            // 
            // pn3
            // 
            this.pn3.BackColor = System.Drawing.Color.White;
            this.pn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pn3.Location = new System.Drawing.Point(-1, 594);
            this.pn3.Name = "pn3";
            this.pn3.Size = new System.Drawing.Size(258, 1);
            this.pn3.TabIndex = 3;
            // 
            // btnTelaPrincipal
            // 
            this.btnTelaPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTelaPrincipal.FlatAppearance.BorderSize = 0;
            this.btnTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaPrincipal.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnTelaPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("btnTelaPrincipal.Image")));
            this.btnTelaPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTelaPrincipal.Location = new System.Drawing.Point(19, 402);
            this.btnTelaPrincipal.Name = "btnTelaPrincipal";
            this.btnTelaPrincipal.Size = new System.Drawing.Size(239, 50);
            this.btnTelaPrincipal.TabIndex = 7;
            this.btnTelaPrincipal.Text = "Tela Principal";
            this.btnTelaPrincipal.UseVisualStyleBackColor = true;
            this.btnTelaPrincipal.Click += new System.EventHandler(this.btnTelaPrincipal_Click);
            // 
            // pn4
            // 
            this.pn4.BackColor = System.Drawing.Color.White;
            this.pn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pn4.Location = new System.Drawing.Point(0, 597);
            this.pn4.Name = "pn4";
            this.pn4.Size = new System.Drawing.Size(258, 1);
            this.pn4.TabIndex = 2;
            // 
            // pn1
            // 
            this.pn1.BackColor = System.Drawing.Color.White;
            this.pn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pn1.Location = new System.Drawing.Point(0, 520);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(258, 1);
            this.pn1.TabIndex = 1;
            // 
            // pn2
            // 
            this.pn2.BackColor = System.Drawing.Color.White;
            this.pn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pn2.Location = new System.Drawing.Point(0, 523);
            this.pn2.Name = "pn2";
            this.pn2.Size = new System.Drawing.Size(258, 1);
            this.pn2.TabIndex = 0;
            // 
            // picFechar
            // 
            this.picFechar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFechar.Image = ((System.Drawing.Image)(resources.GetObject("picFechar.Image")));
            this.picFechar.Location = new System.Drawing.Point(98, 538);
            this.picFechar.Name = "picFechar";
            this.picFechar.Size = new System.Drawing.Size(60, 44);
            this.picFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFechar.TabIndex = 7;
            this.picFechar.TabStop = false;
            this.picFechar.Click += new System.EventHandler(this.picFechar_Click);
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
            // pnEmpresa
            // 
            this.pnEmpresa.BackColor = System.Drawing.Color.Crimson;
            this.pnEmpresa.Location = new System.Drawing.Point(3, 228);
            this.pnEmpresa.Name = "pnEmpresa";
            this.pnEmpresa.Size = new System.Drawing.Size(12, 50);
            this.pnEmpresa.TabIndex = 5;
            this.pnEmpresa.Visible = false;
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
            // pnImportarAlunos
            // 
            this.pnImportarAlunos.BackColor = System.Drawing.Color.Crimson;
            this.pnImportarAlunos.Location = new System.Drawing.Point(3, 104);
            this.pnImportarAlunos.Name = "pnImportarAlunos";
            this.pnImportarAlunos.Size = new System.Drawing.Size(12, 50);
            this.pnImportarAlunos.TabIndex = 4;
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
            this.pnContem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContem.Location = new System.Drawing.Point(258, 12);
            this.pnContem.Name = "pnContem";
            this.pnContem.Size = new System.Drawing.Size(850, 595);
            this.pnContem.TabIndex = 2;
            this.pnContem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnContem_MouseDown);
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
            ((System.ComponentModel.ISupportInitialize)(this.picFechar)).EndInit();
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
        private System.Windows.Forms.PictureBox picFechar;
        private System.Windows.Forms.Panel pn3;
        private System.Windows.Forms.Panel pn4;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Panel pn2;
        private System.Windows.Forms.Panel pntelaPrincipal;
        private System.Windows.Forms.Button btnTelaPrincipal;
        private System.Windows.Forms.Panel pnVisualizarEncaminhados;
        private System.Windows.Forms.Button btnVisualizarEncaminhados;
    }
}