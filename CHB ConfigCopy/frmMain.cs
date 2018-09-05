using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using CHB_ConfigCopy.Classes;

namespace CHB_ConfigCopy
{
    public partial class frmMain : Form
    {
        private const string CAMINHO_RAIZ = @"\\serverchbweb15\sites\";
        private const string CAMINHO_ORACLE = @"C:\inetpub\wwwroot\chbwebora\";
        private const string CAMINHO_POST = @"C:\inetpub\wwwroot\chbwebpos\";
        private const string CAMINHO_SQL = @"C:\inetpub\wwwroot\chbwebsql\";
        private const string SESSION_STATE = @"tcpip=serverchb02:42424";

        public frmMain()
        {
            InitializeComponent();
            if (File.Exists(Defaults.CaminhoConfig()))
            {
                ProcessadorXml processador = new ProcessadorXml();
                processador.PrepararConfiguracoes();
            }
            else
            {
                Defaults.CriarArquivo();
                CarregarConfiguracoes(Defaults.PerfilPadrao());
            }
        }

        private void ExecutarCopia(string CaminhoRaiz, string Environment, string Base, string Oracle, string Post, string SQL)
        {
            string msgErro = "";
            string WebConfig = CaminhoRaiz + Environment + @"\" + Base + @"\web.config";
            string ClientExeConfig = CaminhoRaiz + Environment + @"\" + Base + @"\client.exe.config";

            bool Executar = false;
            string WebConfigDestino = "";
            string ClientExeConfigDestino = "";

            switch (Environment)
            {
                case "oracle":
                    Executar = true;
                    WebConfigDestino = Oracle + @"web.config";
                    ClientExeConfigDestino = Oracle + @"bin\client.exe.config";
                    break;
                case "post":
                    Executar = true;
                    WebConfigDestino = Post + @"web.config";
                    ClientExeConfigDestino = Post + @"bin\client.exe.config";
                    break;
                case "sql":
                    Executar = true;
                    WebConfigDestino = SQL + @"web.config";
                    ClientExeConfigDestino = SQL + @"bin\client.exe.config";
                    break;
                default:
                    MessageBox.Show("Não foi selecionada uma base correta para cópia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            if (Executar)
            {
                if (chkCopiarWebConfig.Checked)
                {
                    if (File.Exists(WebConfig))
                    {
                        File.Copy(WebConfig, WebConfigDestino, true);

                        XmlDocument xmlDoc = new XmlDocument();
                        xmlDoc.Load(WebConfigDestino);

                        if (chkModificarSessionState.Checked)
                        {
                            xmlDoc.GetElementsByTagName("sessionState")[0].Attributes["stateConnectionString"].Value = txtSessionState.Text;
                        }

                        xmlDoc.Save(WebConfigDestino);

                        msgErro += "O web.config foi copiado com sucesso!\n";
                    }
                    else
                    {
                        msgErro += "Não foi encontrado o web.config para a base \"" + Base + "\"!\n";
                    }
                }

                if (chkCopiarClientExeConfig.Checked)
                {
                    if (File.Exists(ClientExeConfig))
                    {
                        File.Copy(ClientExeConfig, ClientExeConfigDestino, true);
                        msgErro += "O client.exe.config foi copiado com sucesso!\n";
                    }
                    else
                    {
                        msgErro += "Não foi encontrado o client.exe.config para a base \"" + Base + "\"!\n";
                    }
                }

                if (msgErro.Trim() != "")
                {
                    MessageBox.Show(msgErro, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (chkFecharCHBConfigCopy.Checked)
                {
                    this.Close();
                }
            }        
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            ExecutarCopia(txtCaminhoRaiz.Text, cmbEnvironment.Text, cmbBase.Text, txtOracle.Text, txtPost.Text, txtSQL.Text);
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            string _temp = txtSQL.Text;

            FolderBrowser.ShowDialog();

            if (FolderBrowser.SelectedPath.Trim() != "")
            {
                txtSQL.Text = FolderBrowser.SelectedPath + @"\";
            }
            else
            {
                txtSQL.Text = _temp;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string _temp = txtPost.Text;

            FolderBrowser.ShowDialog();

            if (FolderBrowser.SelectedPath.Trim() != "")
            {
                txtPost.Text = FolderBrowser.SelectedPath + @"\";
            }
            else
            {
                txtPost.Text = _temp;
            }
        }

        private void btnOracle_Click(object sender, EventArgs e)
        {
            string _temp = txtOracle.Text;

            FolderBrowser.ShowDialog();

            if (FolderBrowser.SelectedPath.Trim() != "")
            {
                txtOracle.Text = FolderBrowser.SelectedPath + @"\";
            }
            else
            {
                txtOracle.Text = _temp;
            }
        }

        private void btnCaminhoRaiz_Click(object sender, EventArgs e)
        {
            string _temp = txtCaminhoRaiz.Text;

            FolderBrowser.ShowDialog();

            if (FolderBrowser.SelectedPath.Trim() != "")
            {
                txtCaminhoRaiz.Text = FolderBrowser.SelectedPath + @"\";
            }
            else
            {
                txtCaminhoRaiz.Text = _temp;
            }

            
            BuscarEnvironments();
        }

        private void BuscarEnvironments()
        {
            cmbEnvironment.Items.Clear();
            cmbBase.Items.Clear();

            foreach (string Diretorio in Directory.GetDirectories(txtCaminhoRaiz.Text))
            {
                cmbEnvironment.Items.Add(Diretorio.Replace(txtCaminhoRaiz.Text, ""));
            }
        }

        private void cmbEnvironment_SelectedIndexChanged(object sender, EventArgs e)
        {
            string BuscaDiretorio = txtCaminhoRaiz.Text + cmbEnvironment.Text + @"\";

            cmbBase.Items.Clear();
            foreach (string Diretorio in Directory.GetDirectories(BuscaDiretorio))
            {
                cmbBase.Items.Add(Diretorio.Replace(BuscaDiretorio, ""));
            }
        }

        private void btnCriarPerfil_Click(object sender, EventArgs e)
        {
            frmInputBox f = new frmInputBox();
            f.ShowDialog();

            ProcessadorXml processador = new ProcessadorXml();
            if (processador.AdicionarPerfil(frmInputBox.NomePerfil))
            {
                CarregarConfiguracoes(frmInputBox.NomePerfil);
            }
        }

        private void CarregarConfiguracoes(string nomePerfil)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Defaults.CaminhoConfig());
            xmlDoc.PreserveWhitespace = true;

            List<TextBox> camposTexto = new List<TextBox>() { txtCaminhoRaiz, txtOracle, txtPost, txtSQL, txtSessionState };
            List<CheckBox> camposCheckBox = new List<CheckBox>() { chkCopiarWebConfig, chkCopiarClientExeConfig, chkFecharCHBConfigCopy, chkModificarSessionState };

            XmlNodeList configuracoes = xmlDoc.SelectSingleNode("/Settings/Profiles/Profile[@name=\"" + nomePerfil.Trim() + "\"]").ChildNodes;

            foreach (XmlNode configuracao in configuracoes)
            {
                var res = camposTexto.Where(c => c.Name.EndsWith(configuracao.Name));

                if (res.Count() > 0)
                {
                    ((TextBox)res.First<TextBox>()).Text = configuracao.InnerText;
                }
                else
                {
                    var res2 = camposCheckBox.Where(c => c.Name.EndsWith(configuracao.Name));

                    if (res2.Count() > 0)
                    {
                        ((CheckBox)res2.First<CheckBox>()).Checked = bool.Parse(configuracao.InnerText);
                    }
                }
            }

            cmbPerfil.Items.Clear();
            XmlNodeList perfis = xmlDoc.SelectSingleNode("/Settings/Profiles").ChildNodes;
            foreach (XmlNode perfil in perfis)
            {
                string nome = perfil.Attributes["name"].Value.ToString().Trim();
                cmbPerfil.Items.Add(nome);
            }

            cmbPerfil.Text = nomePerfil;
        }
    }
}