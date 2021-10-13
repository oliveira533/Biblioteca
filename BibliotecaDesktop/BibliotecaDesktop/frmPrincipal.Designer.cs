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
            this.btnLivro = new System.Windows.Forms.Button();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.rdbData = new System.Windows.Forms.RadioButton();
            this.rdbEscritor = new System.Windows.Forms.RadioButton();
            this.rdbLivro = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.grdEmprestimo = new System.Windows.Forms.DataGridView();
            this.btnEntregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLivros)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbFiltro.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmprestimo)).BeginInit();
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
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 577);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLivro);
            this.tabPage1.Controls.Add(this.grdLivros);
            this.tabPage1.Controls.Add(this.gbFiltro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(846, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLivro
            // 
            this.btnLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivro.Location = new System.Drawing.Point(257, 16);
            this.btnLivro.Name = "btnLivro";
            this.btnLivro.Size = new System.Drawing.Size(112, 44);
            this.btnLivro.TabIndex = 4;
            this.btnLivro.Text = "Inserir livro";
            this.btnLivro.UseVisualStyleBackColor = true;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.rdbData);
            this.gbFiltro.Controls.Add(this.rdbEscritor);
            this.gbFiltro.Controls.Add(this.rdbLivro);
            this.gbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFiltro.Location = new System.Drawing.Point(13, 4);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(220, 56);
            this.gbFiltro.TabIndex = 3;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtros";
            // 
            // rdbData
            // 
            this.rdbData.AutoSize = true;
            this.rdbData.Location = new System.Drawing.Point(159, 25);
            this.rdbData.Name = "rdbData";
            this.rdbData.Size = new System.Drawing.Size(59, 24);
            this.rdbData.TabIndex = 2;
            this.rdbData.TabStop = true;
            this.rdbData.Text = "data";
            this.rdbData.UseVisualStyleBackColor = true;
            this.rdbData.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rdbEscritor
            // 
            this.rdbEscritor.AutoSize = true;
            this.rdbEscritor.Location = new System.Drawing.Point(74, 25);
            this.rdbEscritor.Name = "rdbEscritor";
            this.rdbEscritor.Size = new System.Drawing.Size(79, 24);
            this.rdbEscritor.TabIndex = 1;
            this.rdbEscritor.TabStop = true;
            this.rdbEscritor.Text = "escritor";
            this.rdbEscritor.UseVisualStyleBackColor = true;
            this.rdbEscritor.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbLivro
            // 
            this.rdbLivro.AutoSize = true;
            this.rdbLivro.Location = new System.Drawing.Point(6, 25);
            this.rdbLivro.Name = "rdbLivro";
            this.rdbLivro.Size = new System.Drawing.Size(62, 24);
            this.rdbLivro.TabIndex = 0;
            this.rdbLivro.TabStop = true;
            this.rdbLivro.Text = "livros";
            this.rdbLivro.UseVisualStyleBackColor = true;
            this.rdbLivro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEntregar);
            this.tabPage2.Controls.Add(this.grdEmprestimo);
            this.tabPage2.Controls.Add(this.btnEmprestimo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(846, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.Location = new System.Drawing.Point(684, 6);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(155, 38);
            this.btnEmprestimo.TabIndex = 5;
            this.btnEmprestimo.Text = "emprestar livro ";
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
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
            // btnEntregar
            // 
            this.btnEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregar.Location = new System.Drawing.Point(523, 7);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(155, 38);
            this.btnEntregar.TabIndex = 7;
            this.btnEntregar.Text = "entregar livro";
            this.btnEntregar.UseVisualStyleBackColor = true;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
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
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmprestimo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdLivros;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLivro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.RadioButton rdbData;
        private System.Windows.Forms.RadioButton rdbEscritor;
        private System.Windows.Forms.RadioButton rdbLivro;
        private System.Windows.Forms.DataGridView grdEmprestimo;
        private System.Windows.Forms.Button btnEntregar;
    }
}

