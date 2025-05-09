using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryGiovanniMaciaEstructura
{
    internal class clsNodo
    {
        private Int32 cod;
        private String nom;
        private String tra;
        private clsNodo sig;
        private clsNodo ant;

        public Int32 Código
        {
            get { return cod; }
            set { cod = value; }
        }

        public String Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Trámite
        {
            get { return tra; }
            set { tra = value; }
        }

        public clsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public clsNodo Anterior
        {
            get { return ant; }
            set { ant = value; }
        }

        public clsNodo Izquierdo
        {
            get { return ant; }
            set { ant = value; }
        }

        public clsNodo Derecho
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}

