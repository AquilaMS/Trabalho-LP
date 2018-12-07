namespace Trabalho_LP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarDVDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarClenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarDVDToolStripMenuItem,
            this.cadastrarClenteToolStripMenuItem,
            this.alterarDadosToolStripMenuItem,
            this.registrarVendaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarDVDToolStripMenuItem
            // 
            this.cadastrarDVDToolStripMenuItem.Name = "cadastrarDVDToolStripMenuItem";
            this.cadastrarDVDToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.cadastrarDVDToolStripMenuItem.Text = "Cadastrar DVD";
            this.cadastrarDVDToolStripMenuItem.Click += new System.EventHandler(this.cadastrarDVDToolStripMenuItem_Click);
            // 
            // cadastrarClenteToolStripMenuItem
            // 
            this.cadastrarClenteToolStripMenuItem.Name = "cadastrarClenteToolStripMenuItem";
            this.cadastrarClenteToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.cadastrarClenteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClenteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClenteToolStripMenuItem_Click);
            // 
            // alterarDadosToolStripMenuItem
            // 
            this.alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            this.alterarDadosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.alterarDadosToolStripMenuItem.Text = "Alterar dados";
            this.alterarDadosToolStripMenuItem.Click += new System.EventHandler(this.alterarDadosToolStripMenuItem_Click);
            // 
            // registrarVendaToolStripMenuItem
            // 
            this.registrarVendaToolStripMenuItem.Name = "registrarVendaToolStripMenuItem";
            this.registrarVendaToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.registrarVendaToolStripMenuItem.Text = "Registrar venda";
            this.registrarVendaToolStripMenuItem.Click += new System.EventHandler(this.registrarVendaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDVDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVendaToolStripMenuItem;
    }
}

