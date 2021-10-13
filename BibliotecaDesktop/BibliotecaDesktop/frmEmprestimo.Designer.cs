namespace BibliotecaDesktop
{
    partial class frmEmprestimo
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
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.cbmCliente = new System.Windows.Forms.ComboBox();
            this.cbmLivro = new System.Windows.Forms.ComboBox();
            this.Cliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(12, 239);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(323, 41);
            this.btnEmprestar.TabIndex = 1;
            this.btnEmprestar.Text = "Emitir empréstimo";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
            // 
            // cbmCliente
            // 
            this.cbmCliente.FormattingEnabled = true;
            this.cbmCliente.Location = new System.Drawing.Point(12, 40);
            this.cbmCliente.Name = "cbmCliente";
            this.cbmCliente.Size = new System.Drawing.Size(323, 28);
            this.cbmCliente.TabIndex = 2;
            // 
            // cbmLivro
            // 
            this.cbmLivro.FormattingEnabled = true;
            this.cbmLivro.Location = new System.Drawing.Point(12, 113);
            this.cbmLivro.Name = "cbmLivro";
            this.cbmLivro.Size = new System.Drawing.Size(323, 28);
            this.cbmLivro.TabIndex = 3;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(12, 17);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(58, 20);
            this.Cliente.TabIndex = 4;
            this.Cliente.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Livro";
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(12, 186);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(323, 26);
            this.dtpEntrega.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data de entrga";
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.cbmLivro);
            this.Controls.Add(this.cbmCliente);
            this.Controls.Add(this.btnEmprestar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmprestimo";
            this.Load += new System.EventHandler(this.frmEmprestimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.ComboBox cbmCliente;
        private System.Windows.Forms.ComboBox cbmLivro;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label label3;
    }
}