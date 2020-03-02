namespace controleMedicamental
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lote = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.Label();
            this.fabrica = new System.Windows.Forms.Label();
            this.venci = new System.Windows.Forms.Label();
            this.textLote = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.dateFabrica = new System.Windows.Forms.DateTimePicker();
            this.dateVenci = new System.Windows.Forms.DateTimePicker();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.dateEntrada = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_descri = new System.Windows.Forms.Label();
            this.btn_atualiza = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lote
            // 
            this.lote.AutoSize = true;
            this.lote.Location = new System.Drawing.Point(12, 125);
            this.lote.Name = "lote";
            this.lote.Size = new System.Drawing.Size(56, 13);
            this.lote.TabIndex = 0;
            this.lote.Text = "Num. Lote";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(143, 125);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(116, 13);
            this.nome.TabIndex = 1;
            this.nome.Text = "Nome do medicamento";
            // 
            // entrada
            // 
            this.entrada.AutoSize = true;
            this.entrada.Location = new System.Drawing.Point(12, 177);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(70, 13);
            this.entrada.TabIndex = 2;
            this.entrada.Text = "Data Entrada";
            // 
            // fabrica
            // 
            this.fabrica.AutoSize = true;
            this.fabrica.Location = new System.Drawing.Point(191, 177);
            this.fabrica.Name = "fabrica";
            this.fabrica.Size = new System.Drawing.Size(57, 13);
            this.fabrica.TabIndex = 3;
            this.fabrica.Text = "Data  Fab.";
            // 
            // venci
            // 
            this.venci.AutoSize = true;
            this.venci.Location = new System.Drawing.Point(12, 224);
            this.venci.Name = "venci";
            this.venci.Size = new System.Drawing.Size(61, 13);
            this.venci.TabIndex = 4;
            this.venci.Text = "Data Venc.";
            // 
            // textLote
            // 
            this.textLote.Location = new System.Drawing.Point(12, 141);
            this.textLote.Name = "textLote";
            this.textLote.Size = new System.Drawing.Size(113, 20);
            this.textLote.TabIndex = 5;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(146, 141);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(203, 20);
            this.textNome.TabIndex = 6;
            // 
            // dateFabrica
            // 
            this.dateFabrica.CustomFormat = "yyyy-MM-dd";
            this.dateFabrica.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFabrica.Location = new System.Drawing.Point(252, 173);
            this.dateFabrica.Name = "dateFabrica";
            this.dateFabrica.Size = new System.Drawing.Size(97, 20);
            this.dateFabrica.TabIndex = 8;
            // 
            // dateVenci
            // 
            this.dateVenci.CustomFormat = "yyyy-MM-dd";
            this.dateVenci.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateVenci.Location = new System.Drawing.Point(79, 222);
            this.dateVenci.Name = "dateVenci";
            this.dateVenci.Size = new System.Drawing.Size(94, 20);
            this.dateVenci.TabIndex = 9;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(204, 222);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(145, 23);
            this.bt_salvar.TabIndex = 10;
            this.bt_salvar.Text = "CADASTRAR";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // dateEntrada
            // 
            this.dateEntrada.CustomFormat = "yyyy-MM-dd";
            this.dateEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEntrada.Location = new System.Drawing.Point(88, 174);
            this.dateEntrada.Name = "dateEntrada";
            this.dateEntrada.Size = new System.Drawing.Size(97, 20);
            this.dateEntrada.TabIndex = 7;
            this.dateEntrada.Value = new System.DateTime(2020, 2, 12, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(363, 275);
            this.dataGridView1.TabIndex = 14;
            // 
            // text_descri
            // 
            this.text_descri.AutoSize = true;
            this.text_descri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_descri.ForeColor = System.Drawing.Color.Red;
            this.text_descri.Location = new System.Drawing.Point(12, 270);
            this.text_descri.Name = "text_descri";
            this.text_descri.Size = new System.Drawing.Size(41, 13);
            this.text_descri.TabIndex = 15;
            this.text_descri.Text = "label1";
            // 
            // btn_atualiza
            // 
            this.btn_atualiza.Location = new System.Drawing.Point(276, 295);
            this.btn_atualiza.Name = "btn_atualiza";
            this.btn_atualiza.Size = new System.Drawing.Size(75, 23);
            this.btn_atualiza.TabIndex = 16;
            this.btn_atualiza.Text = "ATUALIZAR";
            this.btn_atualiza.UseVisualStyleBackColor = true;
            this.btn_atualiza.Click += new System.EventHandler(this.btn_atualiza_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 155);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CADASTRAR LOTE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_atualiza);
            this.Controls.Add(this.text_descri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.dateVenci);
            this.Controls.Add(this.dateFabrica);
            this.Controls.Add(this.dateEntrada);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textLote);
            this.Controls.Add(this.venci);
            this.Controls.Add(this.fabrica);
            this.Controls.Add(this.entrada);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.lote);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lote;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label entrada;
        private System.Windows.Forms.Label fabrica;
        private System.Windows.Forms.Label venci;
        private System.Windows.Forms.TextBox textLote;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.DateTimePicker dateFabrica;
        private System.Windows.Forms.DateTimePicker dateVenci;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.DateTimePicker dateEntrada;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label text_descri;
        private System.Windows.Forms.Button btn_atualiza;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

