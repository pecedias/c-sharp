namespace WindowsFormsApp1 {
    partial class FrmLicenca {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnLicenca = new System.Windows.Forms.Button();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLicenca
            // 
            this.btnLicenca.Location = new System.Drawing.Point(12, 59);
            this.btnLicenca.Name = "btnLicenca";
            this.btnLicenca.Size = new System.Drawing.Size(218, 44);
            this.btnLicenca.TabIndex = 0;
            this.btnLicenca.Text = "Obter Licença";
            this.btnLicenca.UseVisualStyleBackColor = true;
            this.btnLicenca.Click += new System.EventHandler(this.btnLicenca_Click);
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(12, 109);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(510, 20);
            this.txtChave.TabIndex = 1;
            this.txtChave.Text = "Chave de acesso";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(537, 109);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 20);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.btnLicenca);
            this.Name = "FrmLicenca";
            this.Text = "FrmLicenca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLicenca;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnRegistrar;
    }
}