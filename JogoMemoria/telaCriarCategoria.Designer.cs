namespace JogoMemoria
{
    partial class telaCriarCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelQtdeImagens = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCriarCategoria = new System.Windows.Forms.Button();
            this.uploadFotos = new System.Windows.Forms.OpenFileDialog();
            this.salvarImagens = new System.Windows.Forms.SaveFileDialog();
            this.legenda = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCategoria.Location = new System.Drawing.Point(28, 37);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(492, 29);
            this.txtNomeCategoria.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelQtdeImagens);
            this.groupBox1.Controls.Add(this.txtNomeCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // labelQtdeImagens
            // 
            this.labelQtdeImagens.AutoSize = true;
            this.labelQtdeImagens.Font = new System.Drawing.Font("Comic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQtdeImagens.ForeColor = System.Drawing.Color.DimGray;
            this.labelQtdeImagens.Location = new System.Drawing.Point(25, 78);
            this.labelQtdeImagens.Name = "labelQtdeImagens";
            this.labelQtdeImagens.Size = new System.Drawing.Size(0, 19);
            this.labelQtdeImagens.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCriarCategoria);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 146);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnCriarCategoria
            // 
            this.btnCriarCategoria.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCriarCategoria.Font = new System.Drawing.Font("Comic Book", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCriarCategoria.Location = new System.Drawing.Point(205, 96);
            this.btnCriarCategoria.Name = "btnCriarCategoria";
            this.btnCriarCategoria.Size = new System.Drawing.Size(146, 38);
            this.btnCriarCategoria.TabIndex = 0;
            this.btnCriarCategoria.Text = "Criar categoria";
            this.btnCriarCategoria.UseVisualStyleBackColor = false;
            this.btnCriarCategoria.Click += new System.EventHandler(this.btnCriarCategoria_Click);
            // 
            // uploadFotos
            // 
            this.uploadFotos.FileName = "openFileDialog1";
            this.uploadFotos.Multiselect = true;
            // 
            // telaCriarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 287);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaCriarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova categoria";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaCriarCategoria_FormClosing);
            this.Load += new System.EventHandler(this.telaCriarCategoria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog uploadFotos;
        private System.Windows.Forms.SaveFileDialog salvarImagens;
        private System.Windows.Forms.Button btnCriarCategoria;
        private System.Windows.Forms.Label labelQtdeImagens;
        private System.Windows.Forms.ToolTip legenda;
    }
}