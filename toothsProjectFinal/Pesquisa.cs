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
    public partial class Pesquisa : Form
    {
        private int idEscolhido;

        public Pesquisa(int tipoAcesso, int id = 0, string nome = "")
        {
            CarregaLista(tipoAcesso, id, nome);
            InitializeComponent();
        }

        private UsuarioDao RetornaUsuarioDAO()
        {
            IConnection conexao = new Connection();
            conexao.Abrir();

            UsuarioDao usuarioDao = new UsuarioDao(conexao);
            return usuarioDao;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            this.idEscolhido = int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString());
            this.Close();
        }

        private void CarregaLista(int tipoAcesso, int id, string nome)
        {
            UsuarioDao u = RetornaUsuarioDAO();

            List<Usuario> usuarios;

            if (id != 0)
            {
                usuarios = u.Localizar(tipoAcesso, id);
;            }
            else if (nome != "")
            {
                usuarios = u.Localizar(tipoAcesso, 0, nome);
            }
            else
            {
                usuarios = u.Localizar(tipoAcesso);
            }
        }

        private void CarregaGrid(List<Usuario> usuarios)
        {
            var rows = new List<String[]>();

            foreach (Usuario u in usuarios)
            {
                String[] row1 = new string[] { u.ID.ToString(), u.Nome, u.Documento };
                rows.Add(row1);
            }
            
            foreach (string[] a in rows)
            {
                dataGridView1.Rows.Add(a);
            }
        }
    }
}
