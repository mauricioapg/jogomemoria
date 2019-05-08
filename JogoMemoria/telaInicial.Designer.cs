namespace JogoMemoria
{
    partial class telaInicial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaInicial));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuCriarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRemoverCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.legenda = new System.Windows.Forms.ToolTip(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCriarCategoria,
            this.menuRemoverCategoria});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(795, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuCriarCategoria
            // 
            this.menuCriarCategoria.AutoSize = false;
            this.menuCriarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuCriarCategoria.Font = new System.Drawing.Font("Comic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCriarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("menuCriarCategoria.Image")));
            this.menuCriarCategoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCriarCategoria.Name = "menuCriarCategoria";
            this.menuCriarCategoria.Size = new System.Drawing.Size(138, 24);
            this.menuCriarCategoria.Click += new System.EventHandler(this.menuCriarCategoria_Click);
            // 
            // menuRemoverCategoria
            // 
            this.menuRemoverCategoria.AutoSize = false;
            this.menuRemoverCategoria.Font = new System.Drawing.Font("Comic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRemoverCategoria.Image = ((System.Drawing.Image)(resources.GetObject("menuRemoverCategoria.Image")));
            this.menuRemoverCategoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuRemoverCategoria.Name = "menuRemoverCategoria";
            this.menuRemoverCategoria.Size = new System.Drawing.Size(148, 24);
            this.menuRemoverCategoria.Click += new System.EventHandler(this.menuRemoverCategoria_Click);
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdministrador.BackgroundImage")));
            this.btnAdministrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdministrador.Location = new System.Drawing.Point(753, 1);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(38, 23);
            this.btnAdministrador.TabIndex = 2;
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Visible = false;
            this.btnAdministrador.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // telaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 459);
            this.ControlBox = false;
            this.Controls.Add(this.btnAdministrador);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "telaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Início";
            this.Load += new System.EventHandler(this.telaInicial_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ToolStripMenuItem menuCriarCategoria;
        public System.Windows.Forms.ToolStripMenuItem menuRemoverCategoria;
        public System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.ToolTip legenda;
    }
}