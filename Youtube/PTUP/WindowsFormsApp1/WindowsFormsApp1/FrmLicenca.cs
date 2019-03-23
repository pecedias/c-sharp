using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class FrmLicenca : Form {
        public FrmLicenca() {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) {
            MessageBox.Show("Programa registrado!");
        }

        private void btnLicenca_Click(object sender, EventArgs e) {
            Process.Start("http://google.com.br");
        }
    }
}
