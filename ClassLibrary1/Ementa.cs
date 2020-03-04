using System;
using System.Collections.Generic;
using System.Text;

namespace EPATVMenu.entities
{
    public class Ementa
    {
        private int id;
        private DateTime data;
        private string diaSemana;
        private int idUtilizador;

        public Ementa() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public string DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }

        public int IdUtilizador
        {
            get { return idUtilizador; }
            set { idUtilizador = value; }
        }
    }
}
