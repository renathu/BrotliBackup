using BrotliBackup.Brotli.NET;
using BrotliBackup.FolderDialog;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Windows.Forms;

namespace BrotliBackup.Forms
{
    public partial class FrmMain : Form
    {
        BackgroundWorker workerExportar = null;
        BackgroundWorker workerImportar = null;
        DateTime dateTimeStart;

        public FrmMain()
        {
            InitializeComponent();

            workerExportar = new BackgroundWorker();
            workerExportar.DoWork += WorkerExportar_DoWork;
            workerExportar.RunWorkerCompleted += WorkerExportar_RunWorkerCompleted;

            workerImportar = new BackgroundWorker();
            workerImportar.DoWork += WorkerImportar_DoWork;
            workerImportar.RunWorkerCompleted += WorkerImportar_RunWorkerCompleted;
        }

        private void HabilitarControles(bool habilitar)
        {
            tbxDiretorioExportar.ReadOnly = !habilitar;
            btnProcurarExportar.Enabled = habilitar;
            btnIniciarExportar.Enabled = habilitar;

            tbxDiretorioImportar.ReadOnly = !habilitar;
            btnProcurarImportar.Enabled = habilitar;
            btnIniciarImportar.Enabled = habilitar;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (workerExportar.IsBusy || workerImportar.IsBusy)
            {
                MessageBox.Show(this, "Aguarde o termino do processo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                e.Cancel = true;
                return;
            }

            dynamic expObject = new ExpandoObject();
            expObject.DiretorioBaseDados = tbxDiretorioBaseDados.Text;
            expObject.DiretorioExportar = tbxDiretorioExportar.Text;
            expObject.DiretorioImportar = tbxDiretorioImportar.Text;

            string json = JsonConvert.SerializeObject(expObject, Formatting.Indented);
            File.WriteAllText(Path.Combine(Application.StartupPath, "AppConf.json"), json);
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                this.Close();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Application.StartupPath, "AppConf.json")) == true)
            {
                string json = File.ReadAllText(Path.Combine(Application.StartupPath, "AppConf.json"));
                dynamic objJson = JsonConvert.DeserializeObject(json);

                tbxDiretorioBaseDados.Text = objJson.DiretorioBaseDados;
                tbxDiretorioExportar.Text = objJson.DiretorioExportar;
                tbxDiretorioImportar.Text = objJson.DiretorioImportar;
            }

            if (tbxDiretorioBaseDados.Text != string.Empty)
            {
                if (tbxDiretorioExportar.Text != string.Empty)
                {
                    this.ActiveControl = btnIniciarExportar;
                }
                else
                {
                    this.ActiveControl = tbxDiretorioExportar;
                }
            }
        }

        private void tbxDiretorioBaseDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                btnProcurarBaseDados.PerformClick();
            }
        }

        private void btnProcurarBaseDados_Click(object sender, EventArgs e)
        {
            SuperFolderBrowserDialog folderDialog = new SuperFolderBrowserDialog();
            folderDialog.ShowDialog();

            if (folderDialog.SelectedPath != string.Empty)
            {
                tbxDiretorioBaseDados.Text = folderDialog.SelectedPath;
            }
        }

        private void tbxDiretorioExportar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                btnProcurarExportar.PerformClick();
            }
        }

        private void btnProcurarExportar_Click(object sender, EventArgs e)
        {
            SuperFolderBrowserDialog folderDialog = new SuperFolderBrowserDialog();
            folderDialog.ShowDialog();

            if (folderDialog.SelectedPath != string.Empty)
            {
                tbxDiretorioExportar.Text = folderDialog.SelectedPath;
            }
        }

        private void btnIniciarExportar_Click(object sender, EventArgs e)
        {
            if (tbxDiretorioBaseDados.Text == string.Empty)
            {
                tbxDiretorioBaseDados.Focus();
                MessageBox.Show(this, "Informe o diretório da base de dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Directory.Exists(tbxDiretorioBaseDados.Text) == false)
            {
                tbxDiretorioBaseDados.Focus();
                MessageBox.Show(this, "Diretório da base de dados não existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbxDiretorioExportar.Text == string.Empty)
            {
                tbxDiretorioExportar.Focus();
                MessageBox.Show(this, "Informe o diretório para exportar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Directory.Exists(tbxDiretorioExportar.Text) == false)
            {
                tbxDiretorioExportar.Focus();
                MessageBox.Show(this, "Diretório de exportação não existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tbxDiretorioExportar.Focus();
            HabilitarControles(false);
            pgBarExportar.Visible = true;

            workerExportar.RunWorkerAsync();
        }

        private void WorkerExportar_DoWork(object sender, DoWorkEventArgs e)
        {
            dateTimeStart = DateTime.Now;

            BrotliFile.CompressFile(tbxDiretorioBaseDados.Text, tbxDiretorioExportar.Text);
        }

        private void WorkerExportar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HabilitarControles(true);
            pgBarExportar.Visible = false;

            MessageBox.Show(this, "Exportação dos dados realizado com sucesso" + 
                                   Environment.NewLine +
                                   $"Tempo decorrido: {(DateTime.Now - dateTimeStart).ToString()}", 
                                   "Sucesso", 
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void tbxDiretorioImportar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                btnProcurarImportar.PerformClick();
            }
        }

        private void btnProcurarImportar_Click(object sender, EventArgs e)
        {
            SuperFolderBrowserDialog folderDialog = new SuperFolderBrowserDialog();
            folderDialog.ShowDialog();

            if (folderDialog.SelectedPath != string.Empty)
            {
                tbxDiretorioImportar.Text = folderDialog.SelectedPath;
            }
        }

        private void btnIniciarImportar_Click(object sender, EventArgs e)
        {
            if (tbxDiretorioBaseDados.Text == string.Empty)
            {
                tbxDiretorioBaseDados.Focus();
                MessageBox.Show(this, "Informe o diretório da base de dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Directory.Exists(tbxDiretorioBaseDados.Text) == false)
            {
                tbxDiretorioBaseDados.Focus();
                MessageBox.Show(this, "Diretório da base de dados não existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbxDiretorioImportar.Text == string.Empty)
            {
                tbxDiretorioImportar.Focus();
                MessageBox.Show(this, "Informe o diretório para importar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Directory.Exists(tbxDiretorioImportar.Text) == false)
            {
                tbxDiretorioImportar.Focus();
                MessageBox.Show(this, "Diretório de importação não existe", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tbxDiretorioImportar.Focus();
            HabilitarControles(false);
            pgBarImportar.Visible = true;

            workerImportar.RunWorkerAsync();
        }

        private void WorkerImportar_DoWork(object sender, DoWorkEventArgs e)
        {
            dateTimeStart = DateTime.Now;

            BrotliFile.DecompressFile(tbxDiretorioImportar.Text, tbxDiretorioBaseDados.Text);
        }

        private void WorkerImportar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            HabilitarControles(true);
            pgBarImportar.Visible = false;

            MessageBox.Show(this, "Importação dos dados realizado com sucesso" +
                                   Environment.NewLine +
                                   $"Tempo decorrido: {(DateTime.Now - dateTimeStart).ToString()}",
                                   "Sucesso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
