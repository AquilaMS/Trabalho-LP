namespace Trabalho_LP
{
    partial class CadastrarDVD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarDVD));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_titulo = new System.Windows.Forms.TextBox();
            this.txb_genero = new System.Windows.Forms.TextBox();
            this.dt_lancamento = new System.Windows.Forms.DateTimePicker();
            this.cb_classificacao = new System.Windows.Forms.ComboBox();
            this.btn_cadastrardvd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_diretor = new System.Windows.Forms.TextBox();
            this.txb_duracao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(276, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(146, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de lançamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(209, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duração(min):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(258, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.Location = new System.Drawing.Point(104, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Classificação indicativa:";
            // 
            // txb_titulo
            // 
            this.txb_titulo.Location = new System.Drawing.Point(356, 35);
            this.txb_titulo.Name = "txb_titulo";
            this.txb_titulo.Size = new System.Drawing.Size(143, 20);
            this.txb_titulo.TabIndex = 5;
            // 
            // txb_genero
            // 
            this.txb_genero.Location = new System.Drawing.Point(356, 184);
            this.txb_genero.Name = "txb_genero";
            this.txb_genero.Size = new System.Drawing.Size(143, 20);
            this.txb_genero.TabIndex = 7;
            // 
            // dt_lancamento
            // 
            this.dt_lancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_lancamento.Location = new System.Drawing.Point(356, 77);
            this.dt_lancamento.Name = "dt_lancamento";
            this.dt_lancamento.Size = new System.Drawing.Size(143, 20);
            this.dt_lancamento.TabIndex = 9;
            // 
            // cb_classificacao
            // 
            this.cb_classificacao.FormattingEnabled = true;
            this.cb_classificacao.Items.AddRange(new object[] {
            "Livre",
            "10",
            "12",
            "16",
            "18"});
            this.cb_classificacao.Location = new System.Drawing.Point(356, 223);
            this.cb_classificacao.Name = "cb_classificacao";
            this.cb_classificacao.Size = new System.Drawing.Size(143, 21);
            this.cb_classificacao.TabIndex = 10;
            // 
            // btn_cadastrardvd
            // 
            this.btn_cadastrardvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrardvd.Location = new System.Drawing.Point(312, 298);
            this.btn_cadastrardvd.Name = "btn_cadastrardvd";
            this.btn_cadastrardvd.Size = new System.Drawing.Size(187, 62);
            this.btn_cadastrardvd.TabIndex = 11;
            this.btn_cadastrardvd.Text = "Cadastrar";
            this.btn_cadastrardvd.UseVisualStyleBackColor = true;
            this.btn_cadastrardvd.Click += new System.EventHandler(this.btn_cadastrardvd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaShell;
            this.label6.Location = new System.Drawing.Point(258, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Diretor:";
            // 
            // txb_diretor
            // 
            this.txb_diretor.Location = new System.Drawing.Point(353, 149);
            this.txb_diretor.Name = "txb_diretor";
            this.txb_diretor.Size = new System.Drawing.Size(143, 20);
            this.txb_diretor.TabIndex = 13;
            // 
            // txb_duracao
            // 
            this.txb_duracao.Location = new System.Drawing.Point(356, 115);
            this.txb_duracao.Name = "txb_duracao";
            this.txb_duracao.Size = new System.Drawing.Size(143, 20);
            this.txb_duracao.TabIndex = 15;
            // 
            // CadastrarDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.txb_duracao);
            this.Controls.Add(this.txb_diretor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_cadastrardvd);
            this.Controls.Add(this.cb_classificacao);
            this.Controls.Add(this.dt_lancamento);
            this.Controls.Add(this.txb_genero);
            this.Controls.Add(this.txb_titulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarDVD";
            this.Text = "CadastrarDVD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_titulo;
        private System.Windows.Forms.TextBox txb_genero;
        private System.Windows.Forms.DateTimePicker dt_lancamento;
        private System.Windows.Forms.ComboBox cb_classificacao;
        private System.Windows.Forms.Button btn_cadastrardvd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_diretor;
        private System.Windows.Forms.TextBox txb_duracao;
    }
}