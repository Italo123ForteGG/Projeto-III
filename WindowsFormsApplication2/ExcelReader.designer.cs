namespace WindowsFormsApplication2
{
    partial class frmExcelReader
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
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblPlanilha = new System.Windows.Forms.Label();
            this.cbbPlanilha = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.ProgressBar();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(103, 162);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(1043, 410);
            this.dgvAlunos.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.Blue;
            this.btnAbrir.Location = new System.Drawing.Point(717, 121);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(96, 28);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblPlanilha
            // 
            this.lblPlanilha.AutoSize = true;
            this.lblPlanilha.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanilha.Location = new System.Drawing.Point(440, 124);
            this.lblPlanilha.Name = "lblPlanilha";
            this.lblPlanilha.Size = new System.Drawing.Size(76, 21);
            this.lblPlanilha.TabIndex = 2;
            this.lblPlanilha.Text = "Planilha";
            // 
            // cbbPlanilha
            // 
            this.cbbPlanilha.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cbbPlanilha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPlanilha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPlanilha.ForeColor = System.Drawing.Color.White;
            this.cbbPlanilha.FormattingEnabled = true;
            this.cbbPlanilha.Location = new System.Drawing.Point(522, 120);
            this.cbbPlanilha.Name = "cbbPlanilha";
            this.cbbPlanilha.Size = new System.Drawing.Size(189, 29);
            this.cbbPlanilha.TabIndex = 3;
            this.cbbPlanilha.SelectedIndexChanged += new System.EventHandler(this.cbbPlanilha_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Green;
            this.btnCadastrar.Location = new System.Drawing.Point(956, 596);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(190, 48);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // barra
            // 
            this.barra.ForeColor = System.Drawing.Color.Blue;
            this.barra.Location = new System.Drawing.Point(551, 599);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(238, 25);
            this.barra.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barra.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(506, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 40);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Ecxel Reader";
            // 
            // frmExcelReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1228, 656);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbbPlanilha);
            this.Controls.Add(this.lblPlanilha);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.dgvAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExcelReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lblPlanilha;
        private System.Windows.Forms.ComboBox cbbPlanilha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ProgressBar barra;
        private System.Windows.Forms.Label lblTitulo;
    }
}

