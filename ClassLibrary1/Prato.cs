using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPATVMenu.entities
{
    public class Prato
    {
        private int id;
        private string nome;
        private string descricao;
        private string foto;
        private string tipo;

        public Prato() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }
    }
}
