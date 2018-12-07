namespace Trabalho_LP
{
    partial class Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venda));
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_dvd = new System.Windows.Forms.TextBox();
            this.txb_qnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_venda = new System.Windows.Forms.DateTimePicker();
            this.btn_buscarcliente = new System.Windows.Forms.Button();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.cmb_dvd = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_retirada = new System.Windows.Forms.DateTimePicker();
            this.txb_idcliente = new System.Windows.Forms.TextBox();
            this.txb_iddvd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(203, 59);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(145, 20);
            this.txb_nome.TabIndex = 0;
            // 
            // txb_dvd
            // 
            this.txb_dvd.Location = new System.Drawing.Point(426, 59);
            this.txb_dvd.Name = "txb_dvd";
            this.txb_dvd.Size = new System.Drawing.Size(145, 20);
            this.txb_dvd.TabIndex = 1;
            // 
            // txb_qnt
            // 
            this.txb_qnt.Location = new System.Drawing.Point(343, 226);
            this.txb_qnt.Name = "txb_qnt";
            this.txb_qnt.Size = new System.Drawing.Size(88, 20);
            this.txb_qnt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(233, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comprador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(463, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(339, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // dt_venda
            // 
            this.dt_venda.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_venda.Enabled = false;
            this.dt_venda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_venda.Location = new System.Drawing.Point(290, 262);
            this.dt_venda.Name = "dt_venda";
            this.dt_venda.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dt_venda.Size = new System.Drawing.Size(192, 20);
            this.dt_venda.TabIndex = 6;
            // 
            // btn_buscarcliente
            // 
            this.btn_buscarcliente.Location = new System.Drawing.Point(203, 112);
            this.btn_buscarcliente.Name = "btn_buscarcliente";
            this.btn_buscarcliente.Size = new System.Drawing.Size(145, 23);
            this.btn_buscarcliente.TabIndex = 7;
            this.btn_buscarcliente.Text = "Buscar cliente";
            this.btn_buscarcliente.UseVisualStyleBackColor = true;
            this.btn_buscarcliente.Click += new System.EventHandler(this.btn_buscarcliente_Click);
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(203, 85);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(145, 21);
            this.cmb_cliente.TabIndex = 8;
            this.cmb_cliente.SelectedIndexChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged);
            // 
            // cmb_dvd
            // 
            this.cmb_dvd.FormattingEnabled = true;
            this.cmb_dvd.Location = new System.Drawing.Point(426, 85);
            this.cmb_dvd.Name = "cmb_dvd";
            this.cmb_dvd.Size = new System.Drawing.Size(145, 21);
            this.cmb_dvd.TabIndex = 10;
            this.cmb_dvd.SelectedIndexChanged += new System.EventHandler(this.cmb_dvd_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Buscar produto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 64);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(170, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data venda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(170, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data retirada";
            // 
            // dt_retirada
            // 
            this.dt_retirada.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_retirada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_retirada.Location = new System.Drawing.Point(290, 298);
            this.dt_retirada.Name = "dt_retirada";
            this.dt_retirada.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dt_retirada.Size = new System.Drawing.Size(192, 20);
            this.dt_retirada.TabIndex = 14;
            // 
            // txb_idcliente
            // 
            this.txb_idcliente.Location = new System.Drawing.Point(96, 59);
            this.txb_idcliente.Name = "txb_idcliente";
            this.txb_idcliente.ReadOnly = true;
            this.txb_idcliente.Size = new System.Drawing.Size(77, 20);
            this.txb_idcliente.TabIndex = 15;
            // 
            // txb_iddvd
            // 
            this.txb_iddvd.Location = new System.Drawing.Point(596, 59);
            this.txb_iddvd.Name = "txb_iddvd";
            this.txb_iddvd.ReadOnly = true;
            this.txb_iddvd.Size = new System.Drawing.Size(77, 20);
            this.txb_iddvd.TabIndex = 16;
            // 
            // Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.txb_iddvd);
            this.Controls.Add(this.txb_idcliente);
            this.Controls.Add(this.dt_retirada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_dvd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.btn_buscarcliente);
            this.Controls.Add(this.dt_venda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_qnt);
            this.Controls.Add(this.txb_dvd);
            this.Controls.Add(this.txb_nome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Venda";
            this.Text = "Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_dvd;
        private System.Windows.Forms.TextBox txb_qnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_venda;
        private System.Windows.Forms.Button btn_buscarcliente;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.ComboBox cmb_dvd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt_retirada;
        private System.Windows.Forms.TextBox txb_idcliente;
        private System.Windows.Forms.TextBox txb_iddvd;
    }
}