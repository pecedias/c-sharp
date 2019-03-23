using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            MessageBox.Show("Inicializando o formulário pelo construtor!");
        }


        private void btnOk_Click(object sender, EventArgs e) {
            txtResultado.Text = "Olá Paulo, este é seu primeiro programa! - "
                + ((Estado)cboEstados.SelectedItem).Id;
        }

        private void btnAbrir_Click(object sender, EventArgs e) {
            FrmShow form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e) {
            AtualizaHora();

            cboEstados.DataSource = Estado.Lista(); // Usando DataSource não precisa fazer foreach
            cboEstados.Text = "[Selecione]";
            /*
             cboEstados.Items.Clear();
            foreach (Estado estado in Estado.Lista()) {
                cboEstados.Items.Add(estado);
            }        
            */

            /*
             * comboBox entende o ToString para mostrar as informações
             * dataGridView entende as propriedades e as joga na tela
             */

            // maneira simples de utilizar
            // dataGridView.DataSource = Estado.Lista();
            /*
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Nome";

            var rows = new List<string[]>();
            foreach (Estado estado in Estado.Lista()) {
                string[] row1 = new string[] {
                                estado.Id.ToString(), estado.Nome
                            };
                rows.Add(row1);
            }

            foreach (string[] rowArray in rows) {
                dataGridView.Rows.Add(rowArray);
            }
            */

            // utilizando link
            var data = from estado in Estado.Lista()
                       // where estado.Id == 1
                       orderby estado.Nome
                       select new {
                           Id = estado.Id,
                           Nome = estado.Nome
                       };
            dataGridView.DataSource = data.ToList();
        }

        private void AtualizaHora() {
            lblHoraAtual.Text = "Dia e Hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e) {
            new FrmTexto().Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
           Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            new FrmSobre().Show();
        }

        private void licencaToolStripMenuItem_Click(object sender, EventArgs e) {
            new FrmLicenca().Show();
        }

        private void doacaoToolStripMenuItem_Click(object sender, EventArgs e) {
            new FrmDoacao().Show();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            AtualizaHora();
        }
    }
}
