namespace Trabalho_LP
{
    partial class Alterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alterar));
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.cmb_dvd = new System.Windows.Forms.ComboBox();
            this.btn_dvd = new System.Windows.Forms.Button();
            this.txb_dvd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_titulo = new System.Windows.Forms.TextBox();
            this.dt_lancamento = new System.Windows.Forms.DateTimePicker();
            this.txb_genero = new System.Windows.Forms.TextBox();
            this.txb_diretor = new System.Windows.Forms.TextBox();
            this.cmb_idade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_alterardvd = new System.Windows.Forms.Button();
            this.btn_alterarcliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txb_clientegenero = new System.Windows.Forms.TextBox();
            this.txb_clientecpf = new System.Windows.Forms.TextBox();
            this.dt_clientenascimento = new System.Windows.Forms.DateTimePicker();
            this.txb_clientenome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dt_clientedata = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_iddvd = new System.Windows.Forms.TextBox();
            this.txb_idcliente = new System.Windows.Forms.TextBox();
            this.dt_duracao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(194, 27);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(100, 20);
            this.txb_nome.TabIndex = 0;
            // 
            // btn_cliente
            // 
            this.btn_cliente.Location = new System.Drawing.Point(444, 27);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(157, 23);
            this.btn_cliente.TabIndex = 1;
            this.btn_cliente.Text = "Buscar cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(300, 27);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(121, 21);
            this.cmb_cliente.TabIndex = 2;
            this.cmb_cliente.SelectedIndexChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged);
            // 
            // cmb_dvd
            // 
            this.cmb_dvd.FormattingEnabled = true;
            this.cmb_dvd.Location = new System.Drawing.Point(300, 56);
            this.cmb_dvd.Name = "cmb_dvd";
            this.cmb_dvd.Size = new System.Drawing.Size(121, 21);
            this.cmb_dvd.TabIndex = 5;
            this.cmb_dvd.SelectedIndexChanged += new System.EventHandler(this.cmb_dvd_SelectedIndexChanged);
            // 
            // btn_dvd
            // 
            this.btn_dvd.Location = new System.Drawing.Point(444, 56);
            this.btn_dvd.Name = "btn_dvd";
            this.btn_dvd.Size = new System.Drawing.Size(157, 23);
            this.btn_dvd.TabIndex = 4;
            this.btn_dvd.Text = "Buscar DVD";
            this.btn_dvd.UseVisualStyleBackColor = true;
            this.btn_dvd.Click += new System.EventHandler(this.btn_dvd_Click);
            // 
            // txb_dvd
            // 
            this.txb_dvd.Location = new System.Drawing.Point(194, 56);
            this.txb_dvd.Name = "txb_dvd";
            this.txb_dvd.Size = new System.Drawing.Size(100, 20);
            this.txb_dvd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(74, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente";
            // 
            // txb_titulo
            // 
            this.txb_titulo.Location = new System.Drawing.Point(20, 207);
            this.txb_titulo.Name = "txb_titulo";
            this.txb_titulo.Size = new System.Drawing.Size(121, 20);
            this.txb_titulo.TabIndex = 7;
            // 
            // dt_lancamento
            // 
            this.dt_lancamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_lancamento.Location = new System.Drawing.Point(147, 207);
            this.dt_lancamento.Name = "dt_lancamento";
            this.dt_lancamento.Size = new System.Drawing.Size(121, 20);
            this.dt_lancamento.TabIndex = 9;
            // 
            // txb_genero
            // 
            this.txb_genero.Location = new System.Drawing.Point(274, 207);
            this.txb_genero.Name = "txb_genero";
            this.txb_genero.Size = new System.Drawing.Size(121, 20);
            this.txb_genero.TabIndex = 10;
            // 
            // txb_diretor
            // 
            this.txb_diretor.Location = new System.Drawing.Point(401, 207);
            this.txb_diretor.Name = "txb_diretor";
            this.txb_diretor.Size = new System.Drawing.Size(121, 20);
            this.txb_diretor.TabIndex = 11;
            // 
            // cmb_idade
            // 
            this.cmb_idade.FormattingEnabled = true;
            this.cmb_idade.Items.AddRange(new object[] {
            "Livre",
            "10",
            "12",
            "16",
            "18"});
            this.cmb_idade.Location = new System.Drawing.Point(655, 207);
            this.cmb_idade.Name = "cmb_idade";
            this.cmb_idade.Size = new System.Drawing.Size(121, 21);
            this.cmb_idade.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(58, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(139, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data de lançamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(299, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Genero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.Location = new System.Drawing.Point(431, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Diretor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaShell;
            this.label6.Location = new System.Drawing.Point(555, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Duração";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaShell;
            this.label7.Location = new System.Drawing.Point(682, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "idade";
            // 
            // btn_alterardvd
            // 
            this.btn_alterardvd.Location = new System.Drawing.Point(38, 234);
            this.btn_alterardvd.Name = "btn_alterardvd";
            this.btn_alterardvd.Size = new System.Drawing.Size(502, 23);
            this.btn_alterardvd.TabIndex = 19;
            this.btn_alterardvd.Text = "Alterar DVD";
            this.btn_alterardvd.UseVisualStyleBackColor = true;
            this.btn_alterardvd.Click += new System.EventHandler(this.btn_alterardvd_Click);
            // 
            // btn_alterarcliente
            // 
            this.btn_alterarcliente.Location = new System.Drawing.Point(38, 371);
            this.btn_alterarcliente.Name = "btn_alterarcliente";
            this.btn_alterarcliente.Size = new System.Drawing.Size(502, 23);
            this.btn_alterarcliente.TabIndex = 32;
            this.btn_alterarcliente.Text = "Alterar Cliente";
            this.btn_alterarcliente.UseVisualStyleBackColor = true;
            this.btn_alterarcliente.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Chocolate;
            this.label9.Location = new System.Drawing.Point(504, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Nascimento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Chocolate;
            this.label10.Location = new System.Drawing.Point(643, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Genero favorito";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Chocolate;
            this.label11.Location = new System.Drawing.Point(381, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 16);
            this.label11.TabIndex = 28;
            this.label11.Text = "CPF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Chocolate;
            this.label12.Location = new System.Drawing.Point(194, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Data de cadastro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Chocolate;
            this.label13.Location = new System.Drawing.Point(76, 316);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 16);
            this.label13.TabIndex = 26;
            this.label13.Text = "Nome";
            // 
            // txb_clientegenero
            // 
            this.txb_clientegenero.Location = new System.Drawing.Point(632, 345);
            this.txb_clientegenero.Name = "txb_clientegenero";
            this.txb_clientegenero.Size = new System.Drawing.Size(121, 20);
            this.txb_clientegenero.TabIndex = 24;
            this.txb_clientegenero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txb_clientecpf
            // 
            this.txb_clientecpf.Location = new System.Drawing.Point(337, 345);
            this.txb_clientecpf.MaxLength = 11;
            this.txb_clientecpf.Name = "txb_clientecpf";
            this.txb_clientecpf.Size = new System.Drawing.Size(121, 20);
            this.txb_clientecpf.TabIndex = 23;
            // 
            // dt_clientenascimento
            // 
            this.dt_clientenascimento.Checked = false;
            this.dt_clientenascimento.CustomFormat = "";
            this.dt_clientenascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_clientenascimento.Location = new System.Drawing.Point(480, 342);
            this.dt_clientenascimento.Name = "dt_clientenascimento";
            this.dt_clientenascimento.Size = new System.Drawing.Size(121, 20);
            this.dt_clientenascimento.TabIndex = 21;
            // 
            // txb_clientenome
            // 
            this.txb_clientenome.Location = new System.Drawing.Point(38, 345);
            this.txb_clientenome.Name = "txb_clientenome";
            this.txb_clientenome.Size = new System.Drawing.Size(121, 20);
            this.txb_clientenome.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaShell;
            this.label8.Location = new System.Drawing.Point(74, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "DVD";
            // 
            // dt_clientedata
            // 
            this.dt_clientedata.Checked = false;
            this.dt_clientedata.CustomFormat = "";
            this.dt_clientedata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_clientedata.Location = new System.Drawing.Point(194, 342);
            this.dt_clientedata.Name = "dt_clientedata";
            this.dt_clientedata.Size = new System.Drawing.Size(121, 20);
            this.dt_clientedata.TabIndex = 34;
            this.dt_clientedata.Value = new System.DateTime(2018, 12, 3, 21, 28, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.SeaShell;
            this.label14.Location = new System.Drawing.Point(332, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "id:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Chocolate;
            this.label15.Location = new System.Drawing.Point(332, 290);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "id:";
            // 
            // txb_iddvd
            // 
            this.txb_iddvd.Location = new System.Drawing.Point(358, 154);
            this.txb_iddvd.Name = "txb_iddvd";
            this.txb_iddvd.ReadOnly = true;
            this.txb_iddvd.Size = new System.Drawing.Size(100, 20);
            this.txb_iddvd.TabIndex = 37;
            // 
            // txb_idcliente
            // 
            this.txb_idcliente.Location = new System.Drawing.Point(358, 289);
            this.txb_idcliente.Name = "txb_idcliente";
            this.txb_idcliente.ReadOnly = true;
            this.txb_idcliente.Size = new System.Drawing.Size(100, 20);
            this.txb_idcliente.TabIndex = 38;
            // 
            // dt_duracao
            // 
            this.dt_duracao.Location = new System.Drawing.Point(528, 208);
            this.dt_duracao.Name = "dt_duracao";
            this.dt_duracao.Size = new System.Drawing.Size(121, 20);
            this.dt_duracao.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(605, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Excluir DVD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(605, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Excluir Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dt_duracao);
            this.Controls.Add(this.txb_idcliente);
            this.Controls.Add(this.txb_iddvd);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dt_clientedata);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_alterarcliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txb_clientegenero);
            this.Controls.Add(this.txb_clientecpf);
            this.Controls.Add(this.dt_clientenascimento);
            this.Controls.Add(this.txb_clientenome);
            this.Controls.Add(this.btn_alterardvd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_idade);
            this.Controls.Add(this.txb_diretor);
            this.Controls.Add(this.txb_genero);
            this.Controls.Add(this.dt_lancamento);
            this.Controls.Add(this.txb_titulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_dvd);
            this.Controls.Add(this.btn_dvd);
            this.Controls.Add(this.txb_dvd);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.txb_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alterar";
            this.Text = "Alterar";
            this.Load += new System.EventHandler(this.Alterar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.ComboBox cmb_dvd;
        private System.Windows.Forms.Button btn_dvd;
        private System.Windows.Forms.TextBox txb_dvd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_titulo;
        private System.Windows.Forms.DateTimePicker dt_lancamento;
        private System.Windows.Forms.TextBox txb_genero;
        private System.Windows.Forms.TextBox txb_diretor;
        private System.Windows.Forms.ComboBox cmb_idade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_alterardvd;
        private System.Windows.Forms.Button btn_alterarcliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txb_clientegenero;
        private System.Windows.Forms.TextBox txb_clientecpf;
        private System.Windows.Forms.DateTimePicker dt_clientenascimento;
        private System.Windows.Forms.TextBox txb_clientenome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dt_clientedata;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb_iddvd;
        private System.Windows.Forms.TextBox txb_idcliente;
        private System.Windows.Forms.TextBox dt_duracao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}