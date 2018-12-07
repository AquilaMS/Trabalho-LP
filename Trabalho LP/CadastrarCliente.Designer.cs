namespace Trabalho_LP
{
    partial class CadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_cpf = new System.Windows.Forms.TextBox();
            this.txb_genero = new System.Windows.Forms.TextBox();
            this.dt_nascimento = new System.Windows.Forms.DateTimePicker();
            this.dt_cadastro = new System.Windows.Forms.DateTimePicker();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(243, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(256, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(150, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero favorito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaShell;
            this.label4.Location = new System.Drawing.Point(114, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaShell;
            this.label5.Location = new System.Drawing.Point(141, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data de cadastro:";
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(344, 54);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(160, 20);
            this.txb_nome.TabIndex = 6;
            this.txb_nome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txb_cpf
            // 
            this.txb_cpf.Location = new System.Drawing.Point(344, 102);
            this.txb_cpf.MaxLength = 11;
            this.txb_cpf.Name = "txb_cpf";
            this.txb_cpf.Size = new System.Drawing.Size(160, 20);
            this.txb_cpf.TabIndex = 7;
            // 
            // txb_genero
            // 
            this.txb_genero.Location = new System.Drawing.Point(344, 151);
            this.txb_genero.Name = "txb_genero";
            this.txb_genero.Size = new System.Drawing.Size(160, 20);
            this.txb_genero.TabIndex = 8;
            // 
            // dt_nascimento
            // 
            this.dt_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_nascimento.Location = new System.Drawing.Point(344, 197);
            this.dt_nascimento.Name = "dt_nascimento";
            this.dt_nascimento.Size = new System.Drawing.Size(160, 20);
            this.dt_nascimento.TabIndex = 9;
            // 
            // dt_cadastro
            // 
            this.dt_cadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_cadastro.Location = new System.Drawing.Point(344, 242);
            this.dt_cadastro.Name = "dt_cadastro";
            this.dt_cadastro.Size = new System.Drawing.Size(160, 20);
            this.dt_cadastro.TabIndex = 10;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.Location = new System.Drawing.Point(295, 288);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(163, 58);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = "Cadastrar Cliente";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // CadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.dt_cadastro);
            this.Controls.Add(this.dt_nascimento);
            this.Controls.Add(this.txb_genero);
            this.Controls.Add(this.txb_cpf);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarCliente";
            this.Text = "CadastrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_cpf;
        private System.Windows.Forms.TextBox txb_genero;
        private System.Windows.Forms.DateTimePicker dt_nascimento;
        private System.Windows.Forms.DateTimePicker dt_cadastro;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}