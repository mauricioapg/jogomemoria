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
    public partial class telaRemoverCategoria : Form
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

        string itemEscolhido;

        public telaRemoverCategoria()
        {
            InitializeComponent();
        }

        private void telaRemoverCategoria_Load(object sender, EventArgs e)
        {
            ExibirCategorias();
        }

        private void DefinirFontesPadrao()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile(@"fontes/Comic Book.otf");
            listViewCategorias.Font = new Font(font.Families[0], 14, FontStyle.Regular);
            btnRemoverCategoria.Font = new Font(font.Families[0], 13, FontStyle.Regular);
        }

        private void ExibirCategorias()
        {
            foreach (var pastas in telaJogo.pastaRaiz.GetDirectories())
            {
                listViewCategorias.Items.Add(new ListViewItem(new[] { pastas.Name, pastas.GetFiles().Count().ToString() }));
            }
        }

        private void RemoverCategoria()
        {
            foreach (var pasta in telaJogo.pastaRaiz.GetDirectories())
            {
                if (itemEscolhido == pasta.Name)
                {
                    Directory.Delete(pasta.FullName, true);
                }
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

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(itemEscolhido))
                {
                    MessageBox.Show("Escolha uma categoria para remover", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {                    
                    DialogResult confirmacao = MessageBox.Show("Deseja mesmo remover esta categoria?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if(confirmacao.ToString().ToUpper().Equals("YES"))
                    {
                        this.Close();
                        RemoverCategoria();
                        MessageBox.Show("Categoria removida!\nReinicie o programa para aplicar as alterações", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewCategorias_Click(object sender, EventArgs e)
        {
            itemEscolhido = listViewCategorias.SelectedItems[0].Text;
        }

        private void telaRemoverCategoria_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

    }
}
