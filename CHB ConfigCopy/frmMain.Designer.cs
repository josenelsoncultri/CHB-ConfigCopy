namespace CHB_ConfigCopy
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.tabCHBConfigCopy = new System.Windows.Forms.TabControl();
            this.tabPrincipal = new System.Windows.Forms.TabPage();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEnvironment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabConfiguracoes = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCriarPerfil = new System.Windows.Forms.Button();
            this.chkDesabilitarCache = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkSessionState = new System.Windows.Forms.CheckBox();
            this.txtSessionState = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.chkFechar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkClientExe = new System.Windows.Forms.CheckBox();
            this.chkWeb = new System.Windows.Forms.CheckBox();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOracle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSQL = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnOracle = new System.Windows.Forms.Button();
            this.btnCaminhoRaiz = new System.Windows.Forms.Button();
            this.txtCaminhoRaiz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tabCHBConfigCopy.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabConfiguracoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCHBConfigCopy
            // 
            this.tabCHBConfigCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCHBConfigCopy.Controls.Add(this.tabPrincipal);
            this.tabCHBConfigCopy.Controls.Add(this.tabConfiguracoes);
            this.tabCHBConfigCopy.Location = new System.Drawing.Point(12, 49);
            this.tabCHBConfigCopy.Name = "tabCHBConfigCopy";
            this.tabCHBConfigCopy.SelectedIndex = 0;
            this.tabCHBConfigCopy.Size = new System.Drawing.Size(522, 461);
            this.tabCHBConfigCopy.TabIndex = 0;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.btnCopiar);
            this.tabPrincipal.Controls.Add(this.cmbBase);
            this.tabPrincipal.Controls.Add(this.label6);
            this.tabPrincipal.Controls.Add(this.cmbEnvironment);
            this.tabPrincipal.Controls.Add(this.label5);
            this.tabPrincipal.Location = new System.Drawing.Point(4, 22);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrincipal.Size = new System.Drawing.Size(514, 472);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Text = "Principal";
            this.tabPrincipal.UseVisualStyleBackColor = true;
            // 
            // btnCopiar
            // 
            this.btnCopiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopiar.Location = new System.Drawing.Point(433, 127);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 23);
            this.btnCopiar.TabIndex = 4;
            this.btnCopiar.Text = "Copiar";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // cmbBase
            // 
            this.cmbBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Location = new System.Drawing.Point(6, 82);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(502, 21);
            this.cmbBase.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Selecione a base para cópia:";
            // 
            // cmbEnvironment
            // 
            this.cmbEnvironment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnvironment.FormattingEnabled = true;
            this.cmbEnvironment.Location = new System.Drawing.Point(6, 30);
            this.cmbEnvironment.Name = "cmbEnvironment";
            this.cmbEnvironment.Size = new System.Drawing.Size(502, 21);
            this.cmbEnvironment.TabIndex = 1;
            this.cmbEnvironment.SelectedIndexChanged += new System.EventHandler(this.cmbEnvironment_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Selecione o environment para cópia dos arquivos:";
            // 
            // tabConfiguracoes
            // 
            this.tabConfiguracoes.Controls.Add(this.chkDesabilitarCache);
            this.tabConfiguracoes.Controls.Add(this.chkSessionState);
            this.tabConfiguracoes.Controls.Add(this.txtSessionState);
            this.tabConfiguracoes.Controls.Add(this.label8);
            this.tabConfiguracoes.Controls.Add(this.chkFechar);
            this.tabConfiguracoes.Controls.Add(this.label7);
            this.tabConfiguracoes.Controls.Add(this.chkClientExe);
            this.tabConfiguracoes.Controls.Add(this.chkWeb);
            this.tabConfiguracoes.Controls.Add(this.txtSQL);
            this.tabConfiguracoes.Controls.Add(this.label4);
            this.tabConfiguracoes.Controls.Add(this.txtPost);
            this.tabConfiguracoes.Controls.Add(this.label3);
            this.tabConfiguracoes.Controls.Add(this.txtOracle);
            this.tabConfiguracoes.Controls.Add(this.label2);
            this.tabConfiguracoes.Controls.Add(this.btnSQL);
            this.tabConfiguracoes.Controls.Add(this.btnPost);
            this.tabConfiguracoes.Controls.Add(this.btnOracle);
            this.tabConfiguracoes.Controls.Add(this.btnCaminhoRaiz);
            this.tabConfiguracoes.Controls.Add(this.txtCaminhoRaiz);
            this.tabConfiguracoes.Controls.Add(this.label1);
            this.tabConfiguracoes.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguracoes.Name = "tabConfiguracoes";
            this.tabConfiguracoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguracoes.Size = new System.Drawing.Size(514, 435);
            this.tabConfiguracoes.TabIndex = 1;
            this.tabConfiguracoes.Text = "Configurações";
            this.tabConfiguracoes.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Perfil de configurações:";
            // 
            // btnCriarPerfil
            // 
            this.btnCriarPerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarPerfil.BackgroundImage = global::CHB_ConfigCopy.Properties.Resources.ActionInsert;
            this.btnCriarPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCriarPerfil.Location = new System.Drawing.Point(492, 16);
            this.btnCriarPerfil.Name = "btnCriarPerfil";
            this.btnCriarPerfil.Size = new System.Drawing.Size(32, 30);
            this.btnCriarPerfil.TabIndex = 20;
            this.Tooltip.SetToolTip(this.btnCriarPerfil, "Cria um novo perfil de configurações");
            this.btnCriarPerfil.UseVisualStyleBackColor = true;
            this.btnCriarPerfil.Click += new System.EventHandler(this.btnCriarPerfil_Click);
            // 
            // chkDesabilitarCache
            // 
            this.chkDesabilitarCache.AutoSize = true;
            this.chkDesabilitarCache.Location = new System.Drawing.Point(9, 440);
            this.chkDesabilitarCache.Name = "chkDesabilitarCache";
            this.chkDesabilitarCache.Size = new System.Drawing.Size(216, 17);
            this.chkDesabilitarCache.TabIndex = 19;
            this.chkDesabilitarCache.Text = "Desabilitar cache da aplicação na cópia";
            this.chkDesabilitarCache.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(470, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // chkSessionState
            // 
            this.chkSessionState.AutoSize = true;
            this.chkSessionState.Location = new System.Drawing.Point(9, 354);
            this.chkSessionState.Name = "chkSessionState";
            this.chkSessionState.Size = new System.Drawing.Size(265, 17);
            this.chkSessionState.TabIndex = 18;
            this.chkSessionState.Text = "Substituir valor do atributo \"stateConnectionString\"";
            this.chkSessionState.UseVisualStyleBackColor = true;
            // 
            // txtSessionState
            // 
            this.txtSessionState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSessionState.Location = new System.Drawing.Point(9, 245);
            this.txtSessionState.Name = "txtSessionState";
            this.txtSessionState.Size = new System.Drawing.Size(461, 20);
            this.txtSessionState.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "String de conexão do sessionState";
            // 
            // chkFechar
            // 
            this.chkFechar.AutoSize = true;
            this.chkFechar.Location = new System.Drawing.Point(9, 331);
            this.chkFechar.Name = "chkFechar";
            this.chkFechar.Size = new System.Drawing.Size(205, 17);
            this.chkFechar.TabIndex = 15;
            this.chkFechar.Text = "Fechar CHB ConfigCopy após a cópia";
            this.chkFechar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Orientação: deixar as duas opções SEMPRE marcadas!";
            // 
            // chkClientExe
            // 
            this.chkClientExe.AutoSize = true;
            this.chkClientExe.Location = new System.Drawing.Point(9, 308);
            this.chkClientExe.Name = "chkClientExe";
            this.chkClientExe.Size = new System.Drawing.Size(136, 17);
            this.chkClientExe.TabIndex = 13;
            this.chkClientExe.Text = "Copiar client.exe.config";
            this.chkClientExe.UseVisualStyleBackColor = true;
            // 
            // chkWeb
            // 
            this.chkWeb.AutoSize = true;
            this.chkWeb.Location = new System.Drawing.Point(9, 285);
            this.chkWeb.Name = "chkWeb";
            this.chkWeb.Size = new System.Drawing.Size(111, 17);
            this.chkWeb.TabIndex = 12;
            this.chkWeb.Text = "Copiar web.config";
            this.chkWeb.UseVisualStyleBackColor = true;
            // 
            // txtSQL
            // 
            this.txtSQL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSQL.Location = new System.Drawing.Point(9, 194);
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(461, 20);
            this.txtSQL.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Aplicação SQL Server:";
            // 
            // txtPost
            // 
            this.txtPost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPost.Location = new System.Drawing.Point(9, 138);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(461, 20);
            this.txtPost.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aplicação PostgreSQL:";
            // 
            // txtOracle
            // 
            this.txtOracle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOracle.Location = new System.Drawing.Point(9, 84);
            this.txtOracle.Name = "txtOracle";
            this.txtOracle.Size = new System.Drawing.Size(461, 20);
            this.txtOracle.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aplicação Oracle:";
            // 
            // btnSQL
            // 
            this.btnSQL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSQL.BackgroundImage = global::CHB_ConfigCopy.Properties.Resources.zoom;
            this.btnSQL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSQL.Location = new System.Drawing.Point(476, 188);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(32, 30);
            this.btnSQL.TabIndex = 5;
            this.Tooltip.SetToolTip(this.btnSQL, "Caminho da aplicação SQL Server local");
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // btnPost
            // 
            this.btnPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPost.BackgroundImage = global::CHB_ConfigCopy.Properties.Resources.zoom;
            this.btnPost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPost.Location = new System.Drawing.Point(476, 132);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(32, 30);
            this.btnPost.TabIndex = 4;
            this.Tooltip.SetToolTip(this.btnPost, "Caminho da aplicação PostgreSQL local");
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnOracle
            // 
            this.btnOracle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOracle.BackgroundImage = global::CHB_ConfigCopy.Properties.Resources.zoom;
            this.btnOracle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOracle.Location = new System.Drawing.Point(476, 78);
            this.btnOracle.Name = "btnOracle";
            this.btnOracle.Size = new System.Drawing.Size(32, 30);
            this.btnOracle.TabIndex = 3;
            this.Tooltip.SetToolTip(this.btnOracle, "Caminho da aplicação Oracle local");
            this.btnOracle.UseVisualStyleBackColor = true;
            this.btnOracle.Click += new System.EventHandler(this.btnOracle_Click);
            // 
            // btnCaminhoRaiz
            // 
            this.btnCaminhoRaiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaminhoRaiz.BackgroundImage = global::CHB_ConfigCopy.Properties.Resources.zoom;
            this.btnCaminhoRaiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaminhoRaiz.Location = new System.Drawing.Point(476, 22);
            this.btnCaminhoRaiz.Name = "btnCaminhoRaiz";
            this.btnCaminhoRaiz.Size = new System.Drawing.Size(32, 30);
            this.btnCaminhoRaiz.TabIndex = 2;
            this.Tooltip.SetToolTip(this.btnCaminhoRaiz, "Selecione o caminho raiz para buscar os arquivos de configuração");
            this.btnCaminhoRaiz.UseVisualStyleBackColor = true;
            this.btnCaminhoRaiz.Click += new System.EventHandler(this.btnCaminhoRaiz_Click);
            // 
            // txtCaminhoRaiz
            // 
            this.txtCaminhoRaiz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaminhoRaiz.Location = new System.Drawing.Point(9, 28);
            this.txtCaminhoRaiz.Name = "txtCaminhoRaiz";
            this.txtCaminhoRaiz.Size = new System.Drawing.Size(461, 20);
            this.txtCaminhoRaiz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caminho raiz dos arquivos:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 523);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabCHBConfigCopy);
            this.Controls.Add(this.btnCriarPerfil);
            this.Controls.Add(this.comboBox1);
            this.MinimumSize = new System.Drawing.Size(562, 483);
            this.Name = "frmMain";
            this.Text = "CHB ConfigCopy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.tabCHBConfigCopy.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPrincipal.PerformLayout();
            this.tabConfiguracoes.ResumeLayout(false);
            this.tabConfiguracoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCHBConfigCopy;
        private System.Windows.Forms.TabPage tabPrincipal;
        private System.Windows.Forms.TabPage tabConfiguracoes;
        private System.Windows.Forms.TextBox txtCaminhoRaiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaminhoRaiz;
        private System.Windows.Forms.TextBox txtOracle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnOracle;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip Tooltip;
        private System.Windows.Forms.ComboBox cmbEnvironment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkClientExe;
        private System.Windows.Forms.CheckBox chkWeb;
        private System.Windows.Forms.CheckBox chkFechar;
        private System.Windows.Forms.TextBox txtSessionState;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkSessionState;
        private System.Windows.Forms.CheckBox chkDesabilitarCache;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCriarPerfil;
    }
}

