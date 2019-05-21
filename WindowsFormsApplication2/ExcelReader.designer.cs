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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lblPlanilha = new System.Windows.Forms.Label();
            this.cbbPlanilha = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.barra = new System.Windows.Forms.ProgressBar();
            this.pnPlanilha = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.pnPlanilha.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlunos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunos.Location = new System.Drawing.Point(27, 141);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.Size = new System.Drawing.Size(800, 380);
            this.dgvAlunos.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.Color.Crimson;
            this.btnAbrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(351, 103);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(191, 32);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lblPlanilha
            // 
            this.lblPlanilha.AutoSize = true;
            this.lblPlanilha.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanilha.ForeColor = System.Drawing.Color.Black;
            this.lblPlanilha.Location = new System.Drawing.Point(400, 31);
            this.lblPlanilha.Name = "lblPlanilha";
            this.lblPlanilha.Size = new System.Drawing.Size(87, 23);
            this.lblPlanilha.TabIndex = 2;
            this.lblPlanilha.Text = "Planilha";
            // 
            // cbbPlanilha
            // 
            this.cbbPlanilha.BackColor = System.Drawing.Color.White;
            this.cbbPlanilha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbPlanilha.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPlanilha.ForeColor = System.Drawing.Color.White;
            this.cbbPlanilha.FormattingEnabled = true;
            this.cbbPlanilha.Location = new System.Drawing.Point(1, 1);
            this.cbbPlanilha.Name = "cbbPlanilha";
            this.cbbPlanilha.Size = new System.Drawing.Size(245, 25);
            this.cbbPlanilha.TabIndex = 3;
            this.cbbPlanilha.SelectedIndexChanged += new System.EventHandler(this.cbbPlanilha_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Green;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(649, 529);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(178, 41);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // barra
            // 
            this.barra.ForeColor = System.Drawing.Color.Blue;
            this.barra.Location = new System.Drawing.Point(352, 529);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(190, 25);
            this.barra.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barra.TabIndex = 8;
            // 
            // pnPlanilha
            // 
            this.pnPlanilha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pnPlanilha.Controls.Add(this.cbbPlanilha);
            this.pnPlanilha.Location = new System.Drawing.Point(321, 70);
            this.pnPlanilha.Name = "pnPlanilha";
            this.pnPlanilha.Size = new System.Drawing.Size(247, 27);
            this.pnPlanilha.TabIndex = 10;
            // 
            // frmExcelReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 595);
            this.Controls.Add(this.pnPlanilha);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblPlanilha);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.dgvAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExcelReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.pnPlanilha.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnPlanilha;
    }
}

