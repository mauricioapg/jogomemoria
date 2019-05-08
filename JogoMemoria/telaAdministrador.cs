using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoMemoria
{
    public partial class telaAdministrador : Form
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

        public telaAdministrador()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text.Equals(""))
                {
                    MessageBox.Show("Preencha o campo usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtSenha.Text.Equals(""))
                {
                    MessageBox.Show("Preencha o campo senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtUsuario.Text != "adminceb" || txtSenha.Text != "anchor3128")
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Clear();
                }
                else
                {
                    telaInicial tela = new telaInicial();
                    tela.menuCriarCategoria.Visible = true;
                    tela.menuRemoverCategoria.Visible = true;
                    tela.MdiParent = telaFundo.ActiveForm;
                    //tela.Show();
                    telaInicial.adm = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DefinirFontesPadrao()
        {
            PrivateFontCollection font = new PrivateFontCollection();
            font.AddFontFile(@"fontes/Comic Book.otf");
            label1.Font = new Font(font.Families[0], 12, FontStyle.Regular);
            label2.Font = new Font(font.Families[0], 12, FontStyle.Regular);
            btnLogin.Font = new Font(font.Families[0], 12, FontStyle.Regular);
        }

        private void telaAdministrador_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            DefinirFontesPadrao();
        }

        private void telaAdministrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaInicial objTela = new telaInicial();
            objTela.MdiParent = telaFundo.ActiveForm;
            objTela.Show();
            if (telaInicial.adm == true)
            {
                objTela.menuCriarCategoria.Visible = true;
                objTela.menuRemoverCategoria.Visible = true;
            }
        }
    }
}
