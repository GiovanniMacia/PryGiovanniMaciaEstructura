﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGiovanniMaciaEstructura
{
    internal class clsArbolBinario
    {
        //Creo el campo inicial del arbol. Lo llamamos raiz
        private clsNodo PrimerNodo;
        //Creo la unica propiedad que necesito.
        public clsNodo Raiz
        {
            get { return PrimerNodo; }
            set { PrimerNodo = value; }
        }
       

       
        public clsNodo BuscarCodigo(Int32 cod)
        {
            clsNodo Aux = Raiz;
            while (Aux != null)
            {
                if (cod == Aux.Código) break;
                if (cod < Aux.Código) Aux = Aux.Izquierdo;
                else Aux = Aux.Derecho;
            }
            return Aux;
        }
       
        public void Agregar(clsNodo Nvo)
        {
            Nvo.Izquierdo = null;
            Nvo.Derecho = null;
            if (Raiz == null) Raiz = Nvo;
            else
            {
                clsNodo NodoPadre = Raiz; //ant
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    NodoPadre = Aux;
                    if (Nvo.Código < Aux.Código) Aux = Aux.Izquierdo;
                    else Aux = Aux.Derecho;
                }

                if (Nvo.Código < NodoPadre.Código) NodoPadre.Izquierdo = Nvo;
                else NodoPadre.Derecho = Nvo;
            }
        }

        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void Recorrer(ListBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }

        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }
        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz, NodoPadre);
            tree.ExpandAll();
        }
        public void RecorrerPre(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }
        public void RecorrerPost(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }
        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Dgv, R.Izquierdo);
            Dgv.Rows.Add(R.Código, R.Nombre, R.Trámite);
            if (R.Derecho != null) InOrdenAsc(Dgv, R.Derecho);
        }
        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Código);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }
        private void InOrdenAsc(ListBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(Lst, R.Izquierdo);
            Lst.Items.Add(R.Código);
            if (R.Derecho != null) InOrdenAsc(Lst, R.Derecho);
        }
        public void InOrdenDesc(ListBox Lst, clsNodo R)
        {
            if (R.Derecho != null)
            {
                InOrdenDesc(Lst, R.Derecho);
            }
            Lst.Items.Add(R.Código);
            if (R.Izquierdo != null)
            {
                InOrdenDesc(Lst, R.Izquierdo);
            }
        }
        public void PreOrden(DataGridView Grilla, clsNodo R)
        {
            Grilla.Rows.Add(R.Código, R.Nombre, R.Trámite);
            if (R.Izquierdo != null)
            {
                PreOrden(Grilla, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Grilla, R.Derecho);
            }
        }
        public void PostOrden(DataGridView Grilla, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                PostOrden(Grilla, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(Grilla, R.Derecho);
            }
            Grilla.Rows.Add(R.Código, R.Nombre, R.Trámite);
        }


        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Código.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if (R.Izquierdo != null) PreOrden(R.Izquierdo, NodoPadre);
            if (R.Derecho != null) PreOrden(R.Derecho, NodoPadre);
        }

        private clsNodo[] Vector = new clsNodo[100];
        private Int32 i = 0;
        public void Equilibrar()
        {
            i = 0;
            GrabarVectorInOrden(Raiz);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void EquilibrarArbol(Int32 ini, Int32 fin)
        {
            Int32 m = (ini + fin) / 2;
            if (ini <= fin)
            {
                Agregar(Vector[m]);
                EquilibrarArbol(ini, m - 1);
                EquilibrarArbol(m + 1, fin);
            }
        }
        public void Eliminar(Int32 codigo)
        {
            i = 0;
            GrabarVectorInOrden(Raiz, codigo);
            Raiz = null;
            EquilibrarArbol(0, i - 1);
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo);
            }
            Vector[i] = NodoPadre;
            i = i + 1;
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho);
            }
        }
        private void GrabarVectorInOrden(clsNodo NodoPadre, Int32 Codigo)
        {
            if (NodoPadre.Izquierdo != null)
            {
                GrabarVectorInOrden(NodoPadre.Izquierdo, Codigo);
            }
            if (NodoPadre.Código != Codigo)
            {
                Vector[i] = NodoPadre;
                i = i + 1;
            }
            if (NodoPadre.Derecho != null)
            {
                GrabarVectorInOrden(NodoPadre.Derecho, Codigo);
            }
        }
    }
}


