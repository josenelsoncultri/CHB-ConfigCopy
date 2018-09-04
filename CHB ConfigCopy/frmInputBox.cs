using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHB_ConfigCopy
{
    public partial class frmInputBox : Form
    {
        public static string NomePerfil = "";

        public frmInputBox()
        {
            InitializeComponent();
            frmInputBox.NomePerfil = "";
        }

        private void txtNomePerfil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmInputBox.NomePerfil = txtNomePerfil.Text.Trim();
                this.Close();
            }
        }

        private void frmInputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
