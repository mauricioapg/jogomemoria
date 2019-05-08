using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class telaCriarCategoria : Form
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

        Button fotos;
        TableLayoutPanel tabela;
        List<Image> imagensCategoria = new List<Image>();
        public static string caminhoFotos;

        public telaCriarCategoria()
        {
            InitializeComponent();
        }

        private void AdicionarTabela()
        {
            tabela = new TableLayoutPanel();
            tabela.Location = new Point(28, 13);
            tabela.Size = new Size(492, 124);
            tabela.MaximumSize = new Size(tabela.Width, tabela.Height);
            groupBox2.Controls.Add(tabela);
        }

        private void AdicionarColunas(TableLayoutPanel t)
        {
            t.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
        }

        private void AdicionarLinhas(TableLayoutPanel t)
        {
            t.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
        }

        private void AdicionarBotoes()
        {
            AdicionarLinhas(tabela);
            AdicionarColunas(tabela);            
            fotos = new Button();
            fotos.Size = new Size(tabela.Size.Width, 40);
            fotos.Text = "selecionar fotos";
            fotos.BackColor = Color.DarkGray;
            fotos.ForeColor = Color.Black;
            fotos.Click += new EventHandler(Fotos_Click);
            tabela.Controls.Add(fotos);
        }

        private void Fotos_Click(object sender, EventArgs e)
        {
            uploadFotos.Filter = "JPEG Imagem|*.jpg|PNG Imagem|*.png|Bitmap Imagem|*.bmp|Gif Imagem|*.gif";
            uploadFotos.Title = "Salve um arquivo de imagem";
            Directory.CreateDirectory(telaJogo.pastaRaiz + txtNomeCategoria.Text + @"/");            
            caminhoFotos = telaJogo.pastaRaiz + txtNomeCategoria.Text + @"/";
            txtNomeCategoria.Enabled = false;

            if (!String.IsNullOrEmpty(txtNomeCategoria.Text))
            {
                if (uploadFotos.ShowDialog() == DialogResult.OK)
                {
                    imagensCategoria.Clear();
                    foreach (var imagem in uploadFotos.FileNames)
                    {
                        imagensCategoria.Add(Image.FromFile(imagem));
                    }
                    labelQtdeImagens.Text = imagensCategoria.Count + " fotos selecionadas";
                }
            }
            else
            {
                MessageBox.Show("Por favor, dê um nome à categoria", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RedefinirListaCategorias()
        {
            telaInicial tela = new telaInicial();
            if (telaInicial.adm == true)
            {
                tela.menuCriarCategoria.Visible = true;
                tela.menuRemoverCategoria.Visible = true;
            }
        }

        private void DefinirFontesPadrao()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile(@"fontes/Comic Book.otf");
            label1.Font = new Font(font.Families[0], 11, FontStyle.Regular);
            labelQtdeImagens.Font = new Font(font.Families[0], 11, FontStyle.Regular);
            btnCriarCategoria.Font = new Font(font.Families[0], 13, FontStyle.Regular);
            fotos.Font = new Font(font.Families[0], 13, FontStyle.Regular);
        }

        private void telaCriarCategoria_Load(object sender, EventArgs e)
        {
            AdicionarTabela();
            AdicionarBotoes();
            DefinirFontesPadrao();
        }

        private void btnCriarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (imagensCategoria.Count < 6)
                {
                    MessageBox.Show("Quantidade de imagens insuficiente para o jogo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    foreach (var imagem in imagensCategoria)
                    {
                        imagem.Save(caminhoFotos + "imagem" + imagensCategoria.IndexOf(imagem) + ".png");
                        //File.WriteAllBytes(caminhoFotos + imagem + ".png", telaJogo.ObterBytesImagens(imagem));
                    }
                    MessageBox.Show("Categoria criada!\nReinicie o programa para aplicar as alterações", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Directory.Exists(caminhoFotos))
                {
                    Directory.Delete(caminhoFotos);
                }
            }
        }

        private void telaCriarCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(caminhoFotos))
            {
                if (Directory.GetFiles(caminhoFotos).Length == 0)
                {
                    Directory.Delete(caminhoFotos);
                }
            }
            this.Close();
        }
    }
}
