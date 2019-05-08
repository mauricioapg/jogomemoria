namespace JogoMemoria
{
    partial class telaRemoverCategoria
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
            this.listViewCategorias = new System.Windows.Forms.ListView();
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Itens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemoverCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewCategorias
            // 
            this.listViewCategorias.BackColor = System.Drawing.SystemColors.Control;
            this.listViewCategorias.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Itens});
            this.listViewCategorias.Font = new System.Drawing.Font("Comic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCategorias.Location = new System.Drawing.Point(26, 18);
            this.listViewCategorias.Name = "listViewCategorias";
            this.listViewCategorias.Size = new System.Drawing.Size(315, 240);
            this.listViewCategorias.TabIndex = 0;
            this.listViewCategorias.UseCompatibleStateImageBehavior = false;
            this.listViewCategorias.View = System.Windows.Forms.View.Details;
            this.listViewCategorias.SelectedIndexChanged += new System.EventHandler(this.listViewCategorias_SelectedIndexChanged);
            this.listViewCategorias.Click += new System.EventHandler(this.listViewCategorias_Click);
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 250;
            // 
            // Itens
            // 
            this.Itens.Text = "Itens";
            // 
            // btnRemoverCategoria
            // 
            this.btnRemoverCategoria.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRemoverCategoria.Font = new System.Drawing.Font("Comic Book", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverCategoria.ForeColor = System.Drawing.Color.White;
            this.btnRemoverCategoria.Location = new System.Drawing.Point(111, 267);
            this.btnRemoverCategoria.Name = "btnRemoverCategoria";
            this.btnRemoverCategoria.Size = new System.Drawing.Size(146, 38);
            this.btnRemoverCategoria.TabIndex = 1;
            this.btnRemoverCategoria.Text = "Remover";
            this.btnRemoverCategoria.UseVisualStyleBackColor = false;
            this.btnRemoverCategoria.Click += new System.EventHandler(this.btnRemoverCategoria_Click);
            // 
            // telaRemoverCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 317);
            this.ControlBox = false;
            this.Controls.Add(this.btnRemoverCategoria);
            this.Controls.Add(this.listViewCategorias);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaRemoverCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover Categoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaRemoverCategoria_FormClosing);
            this.Load += new System.EventHandler(this.telaRemoverCategoria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCategorias;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Itens;
        private System.Windows.Forms.Button btnRemoverCategoria;
    }
}