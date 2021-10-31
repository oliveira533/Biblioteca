namespace BibliotecaDesktop
{
    partial class frmLivro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.cbmEscritor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpLancamento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txaResumo = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbQtdLivro = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txbQtdLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Livro";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(16, 32);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(327, 26);
            this.txbNome.TabIndex = 1;
            // 
            // cbmEscritor
            // 
            this.cbmEscritor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmEscritor.FormattingEnabled = true;
            this.cbmEscritor.Location = new System.Drawing.Point(360, 32);
            this.cbmEscritor.Name = "cbmEscritor";
            this.cbmEscritor.Size = new System.Drawing.Size(327, 28);
            this.cbmEscritor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escritor do Livro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data de Lançamento";
            // 
            // dtpLancamento
            // 
            this.dtpLancamento.Location = new System.Drawing.Point(360, 241);
            this.dtpLancamento.Name = "dtpLancamento";
            this.dtpLancamento.Size = new System.Drawing.Size(327, 26);
            this.dtpLancamento.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Resumo do Livro";
            // 
            // txaResumo
            // 
            this.txaResumo.Location = new System.Drawing.Point(16, 105);
            this.txaResumo.Multiline = true;
            this.txaResumo.Name = "txaResumo";
            this.txaResumo.Size = new System.Drawing.Size(327, 162);
            this.txaResumo.TabIndex = 9;
            // 
            // btnInserir
            // 
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Location = new System.Drawing.Point(596, 290);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(91, 34);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gênero do Livro";
            // 
            // cbmGenero
            // 
            this.cbmGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmGenero.FormattingEnabled = true;
            this.cbmGenero.Location = new System.Drawing.Point(360, 105);
            this.cbmGenero.Name = "cbmGenero";
            this.cbmGenero.Size = new System.Drawing.Size(327, 28);
            this.cbmGenero.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantidade de Livro";
            // 
            // txbQtdLivro
            // 
            this.txbQtdLivro.Location = new System.Drawing.Point(360, 174);
            this.txbQtdLivro.Name = "txbQtdLivro";
            this.txbQtdLivro.Size = new System.Drawing.Size(327, 26);
            this.txbQtdLivro.TabIndex = 13;
            // 
            // frmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 356);
            this.Controls.Add(this.txbQtdLivro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txaResumo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpLancamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbmGenero);
            this.Controls.Add(this.cbmEscritor);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLivro";
            this.Load += new System.EventHandler(this.frmLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txbQtdLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.ComboBox cbmEscritor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpLancamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txaResumo;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txbQtdLivro;
    }
}