namespace JogoMemoria
{
    partial class telaJogo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaJogo));
            this.cronometro = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuReiniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTentativas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAcertos = new System.Windows.Forms.Label();
            this.labelMinutos = new System.Windows.Forms.Label();
            this.labelSegundos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelResultados = new System.Windows.Forms.Panel();
            this.tabelaNivel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaNivel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.labelNivel = new System.Windows.Forms.Label();
            this.tabelaNivel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.ptBoxErro = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timerFinalizador = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxErro)).BeginInit();
            this.SuspendLayout();
            // 
            // cronometro
            // 
            this.cronometro.Enabled = true;
            this.cronometro.Interval = 1000;
            this.cronometro.Tick += new System.EventHandler(this.cronometro_Tick);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReiniciar});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1264, 33);
            this.menu.TabIndex = 7;
            this.menu.Text = "menuStrip1";
            // 
            // menuReiniciar
            // 
            this.menuReiniciar.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReiniciar.ImageTransparentColor = System.Drawing.Color.White;
            this.menuReiniciar.Name = "menuReiniciar";
            this.menuReiniciar.Size = new System.Drawing.Size(99, 29);
            this.menuReiniciar.Text = "Reiniciar";
            this.menuReiniciar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.menuReiniciar.Click += new System.EventHandler(this.menuReiniciar_Click);
            // 
            // labelTentativas
            // 
            this.labelTentativas.AutoSize = true;
            this.labelTentativas.Font = new System.Drawing.Font("Comic Book", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTentativas.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelTentativas.Location = new System.Drawing.Point(194, 9);
            this.labelTentativas.Name = "labelTentativas";
            this.labelTentativas.Size = new System.Drawing.Size(0, 41);
            this.labelTentativas.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Book", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(284, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Acertos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Book", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(57, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tentativas:";
            // 
            // labelAcertos
            // 
            this.labelAcertos.AutoSize = true;
            this.labelAcertos.Font = new System.Drawing.Font("Comic Book", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcertos.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelAcertos.Location = new System.Drawing.Point(407, 9);
            this.labelAcertos.Name = "labelAcertos";
            this.labelAcertos.Size = new System.Drawing.Size(0, 41);
            this.labelAcertos.TabIndex = 3;
            // 
            // labelMinutos
            // 
            this.labelMinutos.AutoSize = true;
            this.labelMinutos.Font = new System.Drawing.Font("Comic Book", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutos.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelMinutos.Location = new System.Drawing.Point(778, 9);
            this.labelMinutos.Name = "labelMinutos";
            this.labelMinutos.Size = new System.Drawing.Size(0, 41);
            this.labelMinutos.TabIndex = 4;
            // 
            // labelSegundos
            // 
            this.labelSegundos.AutoSize = true;
            this.labelSegundos.Font = new System.Drawing.Font("Comic Book", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSegundos.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelSegundos.Location = new System.Drawing.Point(867, 9);
            this.labelSegundos.Name = "labelSegundos";
            this.labelSegundos.Size = new System.Drawing.Size(0, 41);
            this.labelSegundos.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Book", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(843, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 45);
            this.label5.TabIndex = 6;
            this.label5.Text = ":";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Book", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(547, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tempo Decorrido:";
            // 
            // panelResultados
            // 
            this.panelResultados.Controls.Add(this.label2);
            this.panelResultados.Controls.Add(this.label5);
            this.panelResultados.Controls.Add(this.labelSegundos);
            this.panelResultados.Controls.Add(this.labelMinutos);
            this.panelResultados.Controls.Add(this.labelAcertos);
            this.panelResultados.Controls.Add(this.label1);
            this.panelResultados.Controls.Add(this.label3);
            this.panelResultados.Controls.Add(this.labelTentativas);
            this.panelResultados.Location = new System.Drawing.Point(98, 55);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(966, 54);
            this.panelResultados.TabIndex = 4;
            this.panelResultados.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResultados_Paint);
            // 
            // tabelaNivel2
            // 
            this.tabelaNivel2.ColumnCount = 6;
            this.tabelaNivel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tabelaNivel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tabelaNivel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tabelaNivel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tabelaNivel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tabelaNivel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67083F));
            this.tabelaNivel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabelaNivel2.Location = new System.Drawing.Point(113, 167);
            this.tabelaNivel2.Name = "tabelaNivel2";
            this.tabelaNivel2.RowCount = 4;
            this.tabelaNivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabelaNivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabelaNivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabelaNivel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabelaNivel2.Size = new System.Drawing.Size(966, 580);
            this.tabelaNivel2.TabIndex = 0;
            // 
            // tabelaNivel3
            // 
            this.tabelaNivel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tabelaNivel3.ColumnCount = 6;
            this.tabelaNivel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tabelaNivel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tabelaNivel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tabelaNivel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tabelaNivel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66583F));
            this.tabelaNivel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67083F));
            this.tabelaNivel3.Location = new System.Drawing.Point(116, 131);
            this.tabelaNivel3.Name = "tabelaNivel3";
            this.tabelaNivel3.RowCount = 6;
            this.tabelaNivel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaNivel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaNivel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaNivel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaNivel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaNivel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tabelaNivel3.Size = new System.Drawing.Size(963, 577);
            this.tabelaNivel3.TabIndex = 8;
            this.tabelaNivel3.Visible = false;
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAvancar.Enabled = false;
            this.btnAvancar.Font = new System.Drawing.Font("Comic Book", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnAvancar.Location = new System.Drawing.Point(350, 11);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(107, 33);
            this.btnAvancar.TabIndex = 8;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Font = new System.Drawing.Font("Comic Book", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNivel.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelNivel.Location = new System.Drawing.Point(224, 12);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(111, 27);
            this.labelNivel.TabIndex = 9;
            this.labelNivel.Text = "labelNivel";
            // 
            // tabelaNivel1
            // 
            this.tabelaNivel1.ColumnCount = 4;
            this.tabelaNivel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabelaNivel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabelaNivel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabelaNivel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tabelaNivel1.Location = new System.Drawing.Point(98, 146);
            this.tabelaNivel1.Name = "tabelaNivel1";
            this.tabelaNivel1.RowCount = 3;
            this.tabelaNivel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabelaNivel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabelaNivel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tabelaNivel1.Size = new System.Drawing.Size(981, 601);
            this.tabelaNivel1.TabIndex = 10;
            this.tabelaNivel1.Visible = false;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(1159, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 28);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // ptBoxErro
            // 
            this.ptBoxErro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptBoxErro.Location = new System.Drawing.Point(505, 7);
            this.ptBoxErro.Name = "ptBoxErro";
            this.ptBoxErro.Size = new System.Drawing.Size(411, 32);
            this.ptBoxErro.TabIndex = 13;
            this.ptBoxErro.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(968, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // timerFinalizador
            // 
            this.timerFinalizador.Enabled = true;
            this.timerFinalizador.Interval = 500;
            this.timerFinalizador.Tick += new System.EventHandler(this.timerFinalizador_Tick);
            // 
            // telaJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 801);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ptBoxErro);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.tabelaNivel1);
            this.Controls.Add(this.tabelaNivel3);
            this.Controls.Add(this.labelNivel);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.tabelaNivel2);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "telaJogo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.telaJogo_FormClosing);
            this.Load += new System.EventHandler(this.telaPrincipal_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panelResultados.ResumeLayout(false);
            this.panelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBoxErro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tabela;
        private System.Windows.Forms.Timer cronometro;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuReiniciar;
        private System.Windows.Forms.Label labelTentativas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAcertos;
        private System.Windows.Forms.Label labelMinutos;
        private System.Windows.Forms.Label labelSegundos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.TableLayoutPanel tabelaNivel2;
        private System.Windows.Forms.TableLayoutPanel tabelaNivel3;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.TableLayoutPanel tabelaNivel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox ptBoxErro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerFinalizador;
    }
}

