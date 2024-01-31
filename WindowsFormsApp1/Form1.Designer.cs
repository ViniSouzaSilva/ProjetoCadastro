namespace WindowsFormsApp1
{
    partial class Form1
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
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbNome = new System.Windows.Forms.TextBox();
            this.TxbRenda = new System.Windows.Forms.TextBox();
            this.TxbCPF = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxbData = new System.Windows.Forms.DateTimePicker();
            this.BtnAtt = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxbPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(26, 344);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(230, 344);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de Nascimento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor da Renda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF";
            // 
            // TxbNome
            // 
            this.TxbNome.Location = new System.Drawing.Point(133, 70);
            this.TxbNome.Name = "TxbNome";
            this.TxbNome.Size = new System.Drawing.Size(100, 20);
            this.TxbNome.TabIndex = 1;
            this.TxbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNome_KeyPress);
            // 
            // TxbRenda
            // 
            this.TxbRenda.Location = new System.Drawing.Point(133, 145);
            this.TxbRenda.Name = "TxbRenda";
            this.TxbRenda.Size = new System.Drawing.Size(100, 20);
            this.TxbRenda.TabIndex = 3;
            this.TxbRenda.TextChanged += new System.EventHandler(this.TxbRenda_TextChanged);
            this.TxbRenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbRenda_KeyPress);
            this.TxbRenda.Leave += new System.EventHandler(this.TxbRenda_Leave);
            // 
            // TxbCPF
            // 
            this.TxbCPF.Location = new System.Drawing.Point(133, 180);
            this.TxbCPF.MaxLength = 14;
            this.TxbCPF.Name = "TxbCPF";
            this.TxbCPF.Size = new System.Drawing.Size(100, 20);
            this.TxbCPF.TabIndex = 4;
            this.TxbCPF.TextChanged += new System.EventHandler(this.TxbCPF_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 250);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // TxbData
            // 
            this.TxbData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxbData.Location = new System.Drawing.Point(133, 106);
            this.TxbData.Name = "TxbData";
            this.TxbData.Size = new System.Drawing.Size(100, 20);
            this.TxbData.TabIndex = 2;
            // 
            // BtnAtt
            // 
            this.BtnAtt.Enabled = false;
            this.BtnAtt.Location = new System.Drawing.Point(121, 344);
            this.BtnAtt.Name = "BtnAtt";
            this.BtnAtt.Size = new System.Drawing.Size(75, 23);
            this.BtnAtt.TabIndex = 6;
            this.BtnAtt.Text = "Atualizar";
            this.BtnAtt.UseVisualStyleBackColor = true;
            this.BtnAtt.Click += new System.EventHandler(this.BtnAtt_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(339, 344);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Deletar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(532, 44);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BtnPesquisar.TabIndex = 11;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TxbPesquisa
            // 
            this.TxbPesquisa.Location = new System.Drawing.Point(339, 44);
            this.TxbPesquisa.Name = "TxbPesquisa";
            this.TxbPesquisa.Size = new System.Drawing.Size(187, 20);
            this.TxbPesquisa.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxbPesquisa);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAtt);
            this.Controls.Add(this.TxbData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TxbCPF);
            this.Controls.Add(this.TxbRenda);
            this.Controls.Add(this.TxbNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbNome;
        private System.Windows.Forms.TextBox TxbRenda;
        private System.Windows.Forms.TextBox TxbCPF;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker TxbData;
        private System.Windows.Forms.Button BtnAtt;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxbPesquisa;
    }
}

