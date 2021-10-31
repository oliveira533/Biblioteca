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
            this.Cliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.grdLivros = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.Location = new System.Drawing.Point(16, 463);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(663, 41);
            this.btnEmprestar.TabIndex = 1;
            this.btnEmprestar.Text = "Emitir empréstimo";
            this.btnEmprestar.UseVisualStyleBackColor = true;
            this.btnEmprestar.Click += new System.EventHandler(this.btnEmprestar_Click);
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
            this.label2.Location = new System.Drawing.Point(352, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Livro";
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Location = new System.Drawing.Point(16, 410);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.Size = new System.Drawing.Size(663, 26);
            this.dtpEntrega.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data de entrga";
            // 
            // grdCliente
            // 
            this.grdCliente.AllowUserToAddRows = false;
            this.grdCliente.AllowUserToDeleteRows = false;
            this.grdCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(16, 58);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCliente.Size = new System.Drawing.Size(323, 299);
            this.grdCliente.TabIndex = 11;
            // 
            // grdLivros
            // 
            this.grdLivros.AllowUserToAddRows = false;
            this.grdLivros.AllowUserToDeleteRows = false;
            this.grdLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLivros.Location = new System.Drawing.Point(356, 58);
            this.grdLivros.Name = "grdLivros";
            this.grdLivros.ReadOnly = true;
            this.grdLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLivros.Size = new System.Drawing.Size(323, 299);
            this.grdLivros.TabIndex = 12;
            // 
            // frmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 527);
            this.Controls.Add(this.grdLivros);
            this.Controls.Add(this.grdCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.btnEmprestar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmprestimo";
            this.Load += new System.EventHandler(this.frmEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdCliente;
        private System.Windows.Forms.DataGridView grdLivros;
    }
}