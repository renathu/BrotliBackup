namespace BrotliBackup.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lbExportarDados = new System.Windows.Forms.Label();
            this.lbDiretorioExportar = new System.Windows.Forms.Label();
            this.tbxDiretorioExportar = new System.Windows.Forms.TextBox();
            this.btnProcurarExportar = new System.Windows.Forms.Button();
            this.btnProcurarImportar = new System.Windows.Forms.Button();
            this.tbxDiretorioImportar = new System.Windows.Forms.TextBox();
            this.lbDiretorioImportar = new System.Windows.Forms.Label();
            this.lbImportarDados = new System.Windows.Forms.Label();
            this.btnIniciarExportar = new System.Windows.Forms.Button();
            this.btnIniciarImportar = new System.Windows.Forms.Button();
            this.btnProcurarBaseDados = new System.Windows.Forms.Button();
            this.tbxDiretorioBaseDados = new System.Windows.Forms.TextBox();
            this.lbDiretorioBaseDados = new System.Windows.Forms.Label();
            this.lbBaseDados = new System.Windows.Forms.Label();
            this.pgBarExportar = new System.Windows.Forms.ProgressBar();
            this.pgBarImportar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbExportarDados
            // 
            this.lbExportarDados.AutoSize = true;
            this.lbExportarDados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExportarDados.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbExportarDados.Location = new System.Drawing.Point(12, 117);
            this.lbExportarDados.Name = "lbExportarDados";
            this.lbExportarDados.Size = new System.Drawing.Size(115, 20);
            this.lbExportarDados.TabIndex = 0;
            this.lbExportarDados.Text = "Exportar dados";
            // 
            // lbDiretorioExportar
            // 
            this.lbDiretorioExportar.AutoSize = true;
            this.lbDiretorioExportar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiretorioExportar.ForeColor = System.Drawing.Color.Black;
            this.lbDiretorioExportar.Location = new System.Drawing.Point(31, 145);
            this.lbDiretorioExportar.Name = "lbDiretorioExportar";
            this.lbDiretorioExportar.Size = new System.Drawing.Size(107, 17);
            this.lbDiretorioExportar.TabIndex = 1;
            this.lbDiretorioExportar.Text = "Diretório destino";
            // 
            // tbxDiretorioExportar
            // 
            this.tbxDiretorioExportar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiretorioExportar.Location = new System.Drawing.Point(34, 170);
            this.tbxDiretorioExportar.Name = "tbxDiretorioExportar";
            this.tbxDiretorioExportar.Size = new System.Drawing.Size(679, 25);
            this.tbxDiretorioExportar.TabIndex = 5;
            this.tbxDiretorioExportar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxDiretorioExportar_KeyDown);
            // 
            // btnProcurarExportar
            // 
            this.btnProcurarExportar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarExportar.Location = new System.Drawing.Point(721, 169);
            this.btnProcurarExportar.Name = "btnProcurarExportar";
            this.btnProcurarExportar.Size = new System.Drawing.Size(70, 27);
            this.btnProcurarExportar.TabIndex = 6;
            this.btnProcurarExportar.Text = "Procurar...";
            this.btnProcurarExportar.UseVisualStyleBackColor = true;
            this.btnProcurarExportar.Click += new System.EventHandler(this.btnProcurarExportar_Click);
            // 
            // btnProcurarImportar
            // 
            this.btnProcurarImportar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarImportar.Location = new System.Drawing.Point(721, 319);
            this.btnProcurarImportar.Name = "btnProcurarImportar";
            this.btnProcurarImportar.Size = new System.Drawing.Size(70, 27);
            this.btnProcurarImportar.TabIndex = 11;
            this.btnProcurarImportar.Text = "Procurar...";
            this.btnProcurarImportar.UseVisualStyleBackColor = true;
            this.btnProcurarImportar.Click += new System.EventHandler(this.btnProcurarImportar_Click);
            // 
            // tbxDiretorioImportar
            // 
            this.tbxDiretorioImportar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiretorioImportar.Location = new System.Drawing.Point(34, 320);
            this.tbxDiretorioImportar.Name = "tbxDiretorioImportar";
            this.tbxDiretorioImportar.Size = new System.Drawing.Size(679, 25);
            this.tbxDiretorioImportar.TabIndex = 10;
            this.tbxDiretorioImportar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxDiretorioImportar_KeyDown);
            // 
            // lbDiretorioImportar
            // 
            this.lbDiretorioImportar.AutoSize = true;
            this.lbDiretorioImportar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiretorioImportar.ForeColor = System.Drawing.Color.Black;
            this.lbDiretorioImportar.Location = new System.Drawing.Point(31, 295);
            this.lbDiretorioImportar.Name = "lbDiretorioImportar";
            this.lbDiretorioImportar.Size = new System.Drawing.Size(106, 17);
            this.lbDiretorioImportar.TabIndex = 5;
            this.lbDiretorioImportar.Text = "Diretório origem";
            // 
            // lbImportarDados
            // 
            this.lbImportarDados.AutoSize = true;
            this.lbImportarDados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImportarDados.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbImportarDados.Location = new System.Drawing.Point(12, 267);
            this.lbImportarDados.Name = "lbImportarDados";
            this.lbImportarDados.Size = new System.Drawing.Size(118, 20);
            this.lbImportarDados.TabIndex = 4;
            this.lbImportarDados.Text = "Importar dados";
            // 
            // btnIniciarExportar
            // 
            this.btnIniciarExportar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarExportar.Location = new System.Drawing.Point(32, 203);
            this.btnIniciarExportar.Name = "btnIniciarExportar";
            this.btnIniciarExportar.Size = new System.Drawing.Size(153, 29);
            this.btnIniciarExportar.TabIndex = 7;
            this.btnIniciarExportar.Text = "Iniciar";
            this.btnIniciarExportar.UseVisualStyleBackColor = true;
            this.btnIniciarExportar.Click += new System.EventHandler(this.btnIniciarExportar_Click);
            // 
            // btnIniciarImportar
            // 
            this.btnIniciarImportar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarImportar.Location = new System.Drawing.Point(32, 352);
            this.btnIniciarImportar.Name = "btnIniciarImportar";
            this.btnIniciarImportar.Size = new System.Drawing.Size(153, 29);
            this.btnIniciarImportar.TabIndex = 12;
            this.btnIniciarImportar.Text = "Iniciar";
            this.btnIniciarImportar.UseVisualStyleBackColor = true;
            this.btnIniciarImportar.Click += new System.EventHandler(this.btnIniciarImportar_Click);
            // 
            // btnProcurarBaseDados
            // 
            this.btnProcurarBaseDados.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurarBaseDados.ForeColor = System.Drawing.Color.DimGray;
            this.btnProcurarBaseDados.Location = new System.Drawing.Point(721, 61);
            this.btnProcurarBaseDados.Name = "btnProcurarBaseDados";
            this.btnProcurarBaseDados.Size = new System.Drawing.Size(70, 27);
            this.btnProcurarBaseDados.TabIndex = 1;
            this.btnProcurarBaseDados.Text = "Procurar...";
            this.btnProcurarBaseDados.UseVisualStyleBackColor = true;
            this.btnProcurarBaseDados.Click += new System.EventHandler(this.btnProcurarBaseDados_Click);
            // 
            // tbxDiretorioBaseDados
            // 
            this.tbxDiretorioBaseDados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiretorioBaseDados.ForeColor = System.Drawing.Color.DimGray;
            this.tbxDiretorioBaseDados.Location = new System.Drawing.Point(34, 62);
            this.tbxDiretorioBaseDados.Name = "tbxDiretorioBaseDados";
            this.tbxDiretorioBaseDados.Size = new System.Drawing.Size(679, 25);
            this.tbxDiretorioBaseDados.TabIndex = 0;
            this.tbxDiretorioBaseDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxDiretorioBaseDados_KeyDown);
            // 
            // lbDiretorioBaseDados
            // 
            this.lbDiretorioBaseDados.AutoSize = true;
            this.lbDiretorioBaseDados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiretorioBaseDados.ForeColor = System.Drawing.Color.DimGray;
            this.lbDiretorioBaseDados.Location = new System.Drawing.Point(31, 37);
            this.lbDiretorioBaseDados.Name = "lbDiretorioBaseDados";
            this.lbDiretorioBaseDados.Size = new System.Drawing.Size(60, 17);
            this.lbDiretorioBaseDados.TabIndex = 9;
            this.lbDiretorioBaseDados.Text = "Diretório";
            // 
            // lbBaseDados
            // 
            this.lbBaseDados.AutoSize = true;
            this.lbBaseDados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaseDados.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbBaseDados.Location = new System.Drawing.Point(12, 9);
            this.lbBaseDados.Name = "lbBaseDados";
            this.lbBaseDados.Size = new System.Drawing.Size(109, 20);
            this.lbBaseDados.TabIndex = 7;
            this.lbBaseDados.Text = "Base de dados";
            // 
            // pgBarExportar
            // 
            this.pgBarExportar.Location = new System.Drawing.Point(273, 203);
            this.pgBarExportar.Name = "pgBarExportar";
            this.pgBarExportar.Size = new System.Drawing.Size(294, 29);
            this.pgBarExportar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgBarExportar.TabIndex = 13;
            this.pgBarExportar.Visible = false;
            // 
            // pgBarImportar
            // 
            this.pgBarImportar.Location = new System.Drawing.Point(273, 353);
            this.pgBarImportar.Name = "pgBarImportar";
            this.pgBarImportar.Size = new System.Drawing.Size(294, 29);
            this.pgBarImportar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pgBarImportar.TabIndex = 14;
            this.pgBarImportar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Para o backup físico o banco de dados não pode estar em uso.";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgBarImportar);
            this.Controls.Add(this.pgBarExportar);
            this.Controls.Add(this.btnProcurarBaseDados);
            this.Controls.Add(this.tbxDiretorioBaseDados);
            this.Controls.Add(this.lbDiretorioBaseDados);
            this.Controls.Add(this.lbBaseDados);
            this.Controls.Add(this.btnIniciarImportar);
            this.Controls.Add(this.btnIniciarExportar);
            this.Controls.Add(this.btnProcurarImportar);
            this.Controls.Add(this.tbxDiretorioImportar);
            this.Controls.Add(this.lbDiretorioImportar);
            this.Controls.Add(this.lbImportarDados);
            this.Controls.Add(this.btnProcurarExportar);
            this.Controls.Add(this.tbxDiretorioExportar);
            this.Controls.Add(this.lbDiretorioExportar);
            this.Controls.Add(this.lbExportarDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ferramenta de backup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbExportarDados;
        private System.Windows.Forms.Label lbDiretorioExportar;
        private System.Windows.Forms.TextBox tbxDiretorioExportar;
        private System.Windows.Forms.Button btnProcurarExportar;
        private System.Windows.Forms.Button btnProcurarImportar;
        private System.Windows.Forms.TextBox tbxDiretorioImportar;
        private System.Windows.Forms.Label lbDiretorioImportar;
        private System.Windows.Forms.Label lbImportarDados;
        private System.Windows.Forms.Button btnIniciarExportar;
        private System.Windows.Forms.Button btnIniciarImportar;
        private System.Windows.Forms.Button btnProcurarBaseDados;
        private System.Windows.Forms.TextBox tbxDiretorioBaseDados;
        private System.Windows.Forms.Label lbDiretorioBaseDados;
        private System.Windows.Forms.Label lbBaseDados;
        private System.Windows.Forms.ProgressBar pgBarExportar;
        private System.Windows.Forms.ProgressBar pgBarImportar;
        private System.Windows.Forms.Label label1;
    }
}