﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace CHB_ConfigCopy
{
    public partial class frmMain : Form
    {
        private const string CAMINHO_RAIZ = @"\\serverchbweb\sites\";
        private const string CAMINHO_ORACLE = @"C:\inetpub\wwwroot\chbwebora\";
        private const string CAMINHO_POST = @"C:\inetpub\wwwroot\chbwebpos\";
        private const string CAMINHO_SQL = @"C:\inetpub\wwwroot\chbwebsql\";
        private const string SESSION_STATE = @"tcpip=serverchb02:42424";
        private string CaminhoConfig = Application.StartupPath + @"\Settings.xml";

        public frmMain()
        {
            InitializeComponent();

            ConfigDefault();
        }

        private void ExecutarCopia(string CaminhoRaiz, string Environment, string Base, string Oracle, string Post, string SQL)
        {
            string msgErro = "";
            string WebConfig = CaminhoRaiz + Environment + @"\" + Base + @"\web.config";
            string ClientExeConfig = CaminhoRaiz + Environment + @"\" + Base + @"\client.exe.config"; //Alterado a pedido do Tiago do TI, pois ele manipula os arquivos na raiz das pastas na rede e não dentro da pasta "bin"
            //string ClientExeConfig = CaminhoRaiz + Environment + @"\" + Base + @"\bin\client.exe.config";

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
                if (chkWeb.Checked)
                {
                    if (File.Exists(WebConfig))
                    {
                        File.Copy(WebConfig, WebConfigDestino, true);

                        if (chkSessionState.Checked)
                        {
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.Load(WebConfigDestino);
                            xmlDoc.GetElementsByTagName("sessionState")[0].Attributes["stateConnectionString"].Value = txtSessionState.Text;
                            xmlDoc.Save(WebConfigDestino);
                        }

                        if (chkRemoverShadowCopy.Checked)
                        {
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.Load(WebConfigDestino);

                            XmlNode hostingEnvironment = xmlDoc.GetElementsByTagName("system.web")[0]["hostingEnvironment"];

                            if (hostingEnvironment != null)
                            {
                                xmlDoc.GetElementsByTagName("system.web")[0].RemoveChild(hostingEnvironment);
                                xmlDoc.Save(WebConfigDestino);                            
                            }
                        }

                        msgErro += "O web.config foi copiado com sucesso!\n";
                    }
                    else
                    {
                        msgErro += "Não foi encontrado o web.config para a base \"" + Base + "\"!\n";
                    }
                }

                if (chkClientExe.Checked)
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

                if (chkFechar.Checked)
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

        private void ConfigDefault()
        {
            XmlDocument xmlDoc = new XmlDocument();

            if (File.Exists(CaminhoConfig))
            {
                xmlDoc.Load(CaminhoConfig);

                txtCaminhoRaiz.Text = xmlDoc.DocumentElement.GetElementsByTagName("CaminhoRaiz").Item(0).InnerText;
                txtOracle.Text = xmlDoc.DocumentElement.GetElementsByTagName("Oracle").Item(0).InnerText;
                txtPost.Text = xmlDoc.DocumentElement.GetElementsByTagName("Post").Item(0).InnerText;
                txtSQL.Text = xmlDoc.DocumentElement.GetElementsByTagName("SQL").Item(0).InnerText;
                txtSessionState.Text = xmlDoc.DocumentElement.GetElementsByTagName("SessionState").Item(0).InnerText;

                try
                {
                    chkWeb.Checked = bool.Parse(xmlDoc.DocumentElement.GetElementsByTagName("CopiarWebConfig").Item(0).InnerText);
                }
                catch (Exception)
                {
                    chkWeb.Checked = true;
                }

                try
                {
                    chkClientExe.Checked = bool.Parse(xmlDoc.DocumentElement.GetElementsByTagName("CopiarClientExeConfig").Item(0).InnerText);
                }
                catch (Exception)
                {
                    chkClientExe.Checked = true;
                }

                try
                {
                    chkFechar.Checked = bool.Parse(xmlDoc.DocumentElement.GetElementsByTagName("FecharCHBConfigCopy").Item(0).InnerText);
                }
                catch (Exception)
                {
                    chkFechar.Checked = true;
                }

                try
                {
                    chkSessionState.Checked = bool.Parse(xmlDoc.DocumentElement.GetElementsByTagName("ModificarSessionState").Item(0).InnerText);
                }
                catch (Exception)
                {
                    chkSessionState.Checked = true;
                }

                try
                {
                    chkRemoverShadowCopy.Checked = bool.Parse(xmlDoc.DocumentElement.GetElementsByTagName("RemoverShadowCopy").Item(0).InnerText);
                }
                catch (Exception)
                {
                    chkRemoverShadowCopy.Checked = true;
                }
            }
            else
            {
                SalvarConfig(ref xmlDoc, CAMINHO_RAIZ, CAMINHO_ORACLE, CAMINHO_POST, CAMINHO_SQL, SESSION_STATE, true, true, false, false, true);

                txtCaminhoRaiz.Text = CAMINHO_RAIZ;
                txtOracle.Text = CAMINHO_ORACLE;
                txtPost.Text = CAMINHO_POST;
                txtSQL.Text = CAMINHO_SQL;
                txtSessionState.Text = SESSION_STATE;
                chkClientExe.Checked = chkWeb.Checked = true;
                chkFechar.Checked = false;
                chkSessionState.Checked = false;
                chkRemoverShadowCopy.Checked = true;
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            SalvarConfig(ref xmlDoc, txtCaminhoRaiz.Text, txtOracle.Text, txtPost.Text, txtSQL.Text, txtSessionState.Text, chkWeb.Checked, chkClientExe.Checked, chkFechar.Checked, chkSessionState.Checked, chkRemoverShadowCopy.Checked);
        }

        private void SalvarConfig(ref XmlDocument xmlDoc, string CaminhoRaiz, string Oracle, string Post, string SQL, string SessionState, bool CopiarWebConfig, bool CopiarClientExeConfig, bool FecharCHBConfigCopy, bool ModificarSessionState, bool RemoverShadowCopy)
        {
            XmlElement xmlRoot = xmlDoc.CreateElement("Settings");
            xmlDoc.AppendChild(xmlRoot);

            XmlElement xmlCaminhoRaiz = xmlDoc.CreateElement("CaminhoRaiz");
            xmlCaminhoRaiz.InnerText = CaminhoRaiz;
            xmlDoc.DocumentElement.AppendChild(xmlCaminhoRaiz);

            XmlElement xmlOracle = xmlDoc.CreateElement("Oracle");
            xmlOracle.InnerText = Oracle;
            xmlDoc.DocumentElement.AppendChild(xmlOracle);

            XmlElement xmlPost = xmlDoc.CreateElement("Post");
            xmlPost.InnerText = Post;
            xmlDoc.DocumentElement.AppendChild(xmlPost);

            XmlElement xmlSQL = xmlDoc.CreateElement("SQL");
            xmlSQL.InnerText = SQL;
            xmlDoc.DocumentElement.AppendChild(xmlSQL);

            XmlElement xmlSessionState = xmlDoc.CreateElement("SessionState");
            xmlSessionState.InnerText = SessionState;
            xmlDoc.DocumentElement.AppendChild(xmlSessionState);

            XmlElement xmlWeb = xmlDoc.CreateElement("CopiarWebConfig");
            xmlWeb.InnerText = CopiarWebConfig.ToString();
            xmlDoc.DocumentElement.AppendChild(xmlWeb);

            XmlElement xmlClientExe = xmlDoc.CreateElement("CopiarClientExeConfig");
            xmlClientExe.InnerText = CopiarClientExeConfig.ToString();
            xmlDoc.DocumentElement.AppendChild(xmlClientExe);

            XmlElement xmlFecharCHBConfigCopy = xmlDoc.CreateElement("FecharCHBConfigCopy");
            xmlFecharCHBConfigCopy.InnerText = FecharCHBConfigCopy.ToString();
            xmlDoc.DocumentElement.AppendChild(xmlFecharCHBConfigCopy);

            XmlElement xmlModificarSessionState = xmlDoc.CreateElement("ModificarSessionState");
            xmlModificarSessionState.InnerText = ModificarSessionState.ToString();
            xmlDoc.DocumentElement.AppendChild(xmlModificarSessionState);

            XmlElement xmlRemoverShadowCopy = xmlDoc.CreateElement("RemoverShadowCopy");
            xmlRemoverShadowCopy.InnerText = RemoverShadowCopy.ToString();
            xmlDoc.DocumentElement.AppendChild(xmlRemoverShadowCopy);

            xmlDoc.Save(CaminhoConfig);          
        }
    }
}