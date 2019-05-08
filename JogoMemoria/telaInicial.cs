using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace JogoMemoria
{
    public partial class telaInicial : Form
    {
        //Este método inpede que a janela seja movimentada
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        public static Boolean adm = false;
        public static string categoriaEscolhida = "";
        public static TableLayoutPanel tabela;
        Button categoria;
        PrivateFontCollection font = new PrivateFontCollection();

        public telaInicial()
        {
            InitializeComponent();
            legenda.SetToolTip(btnAdministrador, "Entre como administrador para gerenciar categorias");
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {            
            AdicionarTabela();            
            DefinirBotoes();
            DefinirFontePadrao();
        }

        private void DefinirFontePadrao()
        {            
            font.AddFontFile(@"fontes/Comic Book.otf");
            categoria.Font = new Font(font.Families[0], 18, FontStyle.Regular);
            menuCriarCategoria.Font = new Font(font.Families[0], 12, FontStyle.Regular);
            menuRemoverCategoria.Font = new Font(font.Families[0], 12, FontStyle.Regular);
            btnAdministrador.Font = new Font(font.Families[0], 11, FontStyle.Regular);
        }

        public void DefinirBotoes()
        {
            AdicionarBotoes();
            AdicionarBarraRolagem();
        }

        private void AdicionarTabela()
        {
            tabela = new TableLayoutPanel();
            tabela.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tabela.Location = new Point(58, 47);
            tabela.Size = new Size(674, 376);
            tabela.MaximumSize = new Size(tabela.Width, tabela.Height);
            tabela.AutoScroll = true;
            this.Controls.Add(tabela);
        }

        private void AdicionarBotoes()
        {            
            foreach (DirectoryInfo pasta in telaJogo.pastaRaiz.GetDirectories())
            {                
                AdicionarColuna(tabela);
                AdicionarLinhas(tabela);
                categoria = new Button();
                categoria.Size = new Size(tabela.Size.Width, tabela.Size.Height);
                categoria.Tag = 0;
                categoria.Text = pasta.Name;
                font.AddFontFile(@"fontes/Comic Book.otf");
                categoria.Font = new Font(font.Families[0], 18, FontStyle.Regular);
                categoria.BackColor = Color.DarkCyan;
                categoria.ForeColor = Color.White;
                categoria.Click += new EventHandler(Categoria_Click);
                tabela.Controls.Add(categoria);
            }
        }

        private void AdicionarColuna(TableLayoutPanel t)
        {
            t.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
        }

        private void AdicionarLinhas(TableLayoutPanel t)
        {
            t.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        }

        private void AdicionarBarraRolagem()
        {
            ScrollBar barraRolagem = new VScrollBar();
            barraRolagem.Dock = DockStyle.Right;
            barraRolagem.Scroll += (sender, e) => { tabela.VerticalScroll.Value = barraRolagem.Value; };
            tabela.Controls.Add(barraRolagem);
        }

        private void Categoria_Click(object sender, EventArgs e)
        {
            Button botao = (sender as Button);
            categoriaEscolhida = botao.Text;

            telaJogo objTela = new telaJogo();
            objTela.MdiParent = telaFundo.ActiveForm;
            objTela.Show();
            this.Close();
            //teste tela = new teste();
            //tela.MdiParent = telaFundo.ActiveForm;
            //tela.Show();
        }

        private void menuCriarCategoria_Click(object sender, EventArgs e)
        {
            telaCriarCategoria objTela = new telaCriarCategoria();
            objTela.MdiParent = telaFundo.ActiveForm;
            objTela.Show();
            this.Close();
        }

        private void menuRemoverCategoria_Click(object sender, EventArgs e)
        {
            telaRemoverCategoria objTela = new telaRemoverCategoria();
            objTela.MdiParent = telaFundo.ActiveForm;
            objTela.Show();
            this.Close();
        }

        private void linkAdministrador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (adm == false)
            {
                telaAdministrador objTela = new telaAdministrador();
                objTela.MdiParent = telaFundo.ActiveForm;
                objTela.Show();
                this.Close();            
            }            
        }
    }
}
