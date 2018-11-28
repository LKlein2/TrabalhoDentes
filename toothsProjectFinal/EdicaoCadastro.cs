using DAO;
using DAO.Classes;
using DAO.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toothsProjectFinal
{
    public partial class frmEdicaoCadastro : Form
    {
        public frmEdicaoCadastro()
        {
            InitializeComponent();
            if (Acesso.TipoUsuario() == 4)
            {
                buttonAtualizar.Enabled = false;
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            IConnection conexao = new Connection();
            conexao.Abrir();

            UsuarioDao pesquisaCadstro = new UsuarioDao(conexao);

            Usuario usuarioPesquisa = new Usuario();

            if (pesquisaCadstro.LocalizarPorId(Convert.ToInt16(textBoxCodigo.Text)) != null)
            {
                usuarioPesquisa = pesquisaCadstro.LocalizarPorId(Convert.ToInt16(textBoxCodigo.Text));
                labelMensagem.Text = "Usuario localizado !";
                labelMensagem.ForeColor = Color.Green;
            }
            else
            {
                labelMensagem.Text = "Usuario não localizado !";
                labelMensagem.ForeColor = Color.Red;
                LimparTela();
                return;
            }

            textBoxLogin.Text = usuarioPesquisa.Login;
            textBoxSenha.Text = usuarioPesquisa.Senha;
            textBoxNome.Text = usuarioPesquisa.Nome;
            textBoxDocumento.Text = usuarioPesquisa.Documento;
            textBoxEndereco.Text = usuarioPesquisa.Endereco;
            textBoxTelefone.Text = usuarioPesquisa.Contato;
            dateTimePickerNascimento.Value = usuarioPesquisa.DataNascimento;
            if (usuarioPesquisa.TipoAcesso == 2)
            {
                radioButtonOdontologista.Checked = true;
            }
            if (usuarioPesquisa.TipoAcesso == 3)
            {
                radioButtonSecretaria.Checked = true;
            }
            if (usuarioPesquisa.TipoAcesso == 4)
            {
                radioButtonPaciente.Checked = true;
            }

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void LimparTela ()
        {
            textBoxLogin.Clear();
            textBoxSenha.Clear();
            textBoxNome.Clear();
            textBoxDocumento.Clear();
            textBoxEndereco.Clear();
            textBoxTelefone.Clear();
            radioButtonOdontologista.Checked = false;
            radioButtonPaciente.Checked = false;
            radioButtonSecretaria.Checked = false;
        }
    }
}
