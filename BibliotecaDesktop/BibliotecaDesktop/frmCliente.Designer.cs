namespace BibliotecaDesktop
{
    partial class frmCliente
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
            this.label2 = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.NumericUpDown();
            this.txbCEP = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txbCPFResponsavel = new System.Windows.Forms.NumericUpDown();
            this.lblResponsavel = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txbCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCPFResponsavel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do cliente";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(16, 41);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(328, 26);
            this.txbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF do cliente";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(16, 113);
            this.txbCPF.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(328, 26);
            this.txbCPF.TabIndex = 3;
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(16, 189);
            this.txbCEP.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(328, 26);
            this.txbCEP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CEP do cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome do cliente";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Location = new System.Drawing.Point(16, 254);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(328, 26);
            this.dtpNascimento.TabIndex = 7;
            this.dtpNascimento.ValueChanged += new System.EventHandler(this.dtpNascimento_ValueChanged);
            // 
            // txbCPFResponsavel
            // 
            this.txbCPFResponsavel.Location = new System.Drawing.Point(16, 320);
            this.txbCPFResponsavel.Name = "txbCPFResponsavel";
            this.txbCPFResponsavel.Size = new System.Drawing.Size(328, 26);
            this.txbCPFResponsavel.TabIndex = 9;
            this.txbCPFResponsavel.Visible = false;
            // 
            // lblResponsavel
            // 
            this.lblResponsavel.AutoSize = true;
            this.lblResponsavel.Location = new System.Drawing.Point(12, 297);
            this.lblResponsavel.Name = "lblResponsavel";
            this.lblResponsavel.Size = new System.Drawing.Size(151, 20);
            this.lblResponsavel.TabIndex = 8;
            this.lblResponsavel.Text = "CPF do responsável";
            this.lblResponsavel.Visible = false;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(16, 369);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(328, 50);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Gravar Cliente";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 444);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txbCPFResponsavel);
            this.Controls.Add(this.lblResponsavel);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbCEP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.txbCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbCPFResponsavel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txbCPF;
        private System.Windows.Forms.NumericUpDown txbCEP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.NumericUpDown txbCPFResponsavel;
        private System.Windows.Forms.Label lblResponsavel;
        private System.Windows.Forms.Button btnInserir;
    }
}