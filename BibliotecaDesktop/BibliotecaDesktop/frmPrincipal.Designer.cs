namespace BibliotecaDesktop
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdLivros = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLivro = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.grdEmprestimo = new System.Windows.Forms.DataGridView();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEscritor = new System.Windows.Forms.Button();
            this.btnAtualiza2 = new System.Windows.Forms.Button();
            this.grdEscritor = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.btnCliente = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmprestimo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEscritor)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLivros
            // 
            this.grdLivros.AllowUserToAddRows = false;
            this.grdLivros.AllowUserToDeleteRows = false;
            this.grdLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLivros.Location = new System.Drawing.Point(3, 66);
            this.grdLivros.MultiSelect = false;
            this.grdLivros.Name = "grdLivros";
            this.grdLivros.ReadOnly = true;
            this.grdLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdLivros.Size = new System.Drawing.Size(843, 479);
            this.grdLivros.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 577);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnLivro);
            this.tabPage1.Controls.Add(this.grdLivros);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Livro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(125, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnLivro
            // 
            this.btnLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivro.Location = new System.Drawing.Point(7, 16);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(112, 44);
            this.btnLivro.TabIndex = 4;
            this.btnLivro.Text = "Inserir livro";
            this.btnLivro.UseVisualStyleBackColor = true;
            this.btnLivro.Click += new System.EventHandler(this.btnLivro_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAtualiza);
            this.tabPage2.Controls.Add(this.btnEntregar);
            this.tabPage2.Controls.Add(this.grdEmprestimo);
            this.tabPage2.Controls.Add(this.btnEmprestimo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Emprestimo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualiza.Location = new System.Drawing.Point(329, 24);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(155, 38);
            this.btnAtualiza.TabIndex = 8;
            this.btnAtualiza.Text = "atualizar";
            this.btnAtualiza.UseVisualStyleBackColor = true;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnEntregar
            // 
            this.btnEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregar.Location = new System.Drawing.Point(168, 24);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(155, 38);
            this.btnEntregar.TabIndex = 7;
            this.btnEntregar.Text = "entregar livro";
            this.btnEntregar.UseVisualStyleBackColor = true;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // grdEmprestimo
            // 
            this.grdEmprestimo.AllowUserToAddRows = false;
            this.grdEmprestimo.AllowUserToDeleteRows = false;
            this.grdEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmprestimo.Location = new System.Drawing.Point(0, 68);
            this.grdEmprestimo.Name = "grdEmprestimo";
            this.grdEmprestimo.ReadOnly = true;
            this.grdEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmprestimo.Size = new System.Drawing.Size(846, 480);
            this.grdEmprestimo.TabIndex = 6;
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.Location = new System.Drawing.Point(7, 24);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(155, 38);
            this.btnEmprestimo.TabIndex = 5;
            this.btnEmprestimo.Text = "emprestar livro ";
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEscritor);
            this.tabPage3.Controls.Add(this.btnAtualiza2);
            this.tabPage3.Controls.Add(this.grdEscritor);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(846, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Escritores ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEscritor
            // 
            this.btnEscritor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscritor.Location = new System.Drawing.Point(7, 24);
            this.btnEscritor.Name = "btnEscritor";
            this.btnEscritor.Size = new System.Drawing.Size(155, 38);
            this.btnEscritor.TabIndex = 10;
            this.btnEscritor.Text = "Adicionar escritor";
            this.btnEscritor.UseVisualStyleBackColor = true;
            this.btnEscritor.Click += new System.EventHandler(this.btnEscritor_Click);
            // 
            // btnAtualiza2
            // 
            this.btnAtualiza2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualiza2.Location = new System.Drawing.Point(168, 24);
            this.btnAtualiza2.Name = "btnAtualiza2";
            this.btnAtualiza2.Size = new System.Drawing.Size(155, 38);
            this.btnAtualiza2.TabIndex = 9;
            this.btnAtualiza2.Text = "atualizar";
            this.btnAtualiza2.UseVisualStyleBackColor = true;
            this.btnAtualiza2.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // grdEscritor
            // 
            this.grdEscritor.AllowUserToAddRows = false;
            this.grdEscritor.AllowUserToDeleteRows = false;
            this.grdEscritor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdEscritor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEscritor.Location = new System.Drawing.Point(0, 68);
            this.grdEscritor.Name = "grdEscritor";
            this.grdEscritor.ReadOnly = true;
            this.grdEscritor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEscritor.Size = new System.Drawing.Size(846, 480);
            this.grdEscritor.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.btnCliente);
            this.tabPage4.Controls.Add(this.grdCliente);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(846, 551);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Clientes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // grdCliente
            // 
            this.grdCliente.AllowUserToAddRows = false;
            this.grdCliente.AllowUserToDeleteRows = false;
            this.grdCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(0, 68);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.ReadOnly = true;
            this.grdCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCliente.Size = new System.Drawing.Size(846, 480);
            this.grdCliente.TabIndex = 8;
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Location = new System.Drawing.Point(7, 24);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(155, 38);
            this.btnCliente.TabIndex = 11;
            this.btnCliente.Text = "Adicionar cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(168, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmprestimo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEscritor)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLivros;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.DataGridView grdEmprestimo;
        private System.Windows.Forms.Button btnEntregar;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnEscritor;
        private System.Windows.Forms.Button btnAtualiza2;
        private System.Windows.Forms.DataGridView grdEscritor;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.DataGridView grdCliente;
    }
}

