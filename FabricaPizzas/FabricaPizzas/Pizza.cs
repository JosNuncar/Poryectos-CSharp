using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPizzas
{
    public abstract class Pizza
    {
        //Atributos
        protected string tipoDeMasa, tipoPizza;
        protected int diasCaducidad, numeroHorno;

        //Constructor de la clase
        public Pizza()
        {
            tipoDeMasa = "";
            tipoPizza = "";
            diasCaducidad = 0;
            numeroHorno = 0;
        }
        public Pizza(string tipoDeMasa, int diasCaducidad, int numeroMolino, string tipoPizza)
        {
            this.tipoDeMasa = tipoDeMasa;
            this.numeroHorno = numeroMolino;
            this.diasCaducidad = diasCaducidad;
            this.tipoPizza = tipoPizza;
        }
        public string TipoDeMasa
        {
            get { return tipoDeMasa; }
            set { tipoDeMasa = value; }
        }

        public string TipoPizza
        {
            get { return tipoPizza; }
            set { tipoPizza = value; }
        }

        public int NumeroHorno
        {
            get { return numeroHorno; }
            set { numeroHorno = value; }
        }
        public int DiasCaducidad
        {
            get { return diasCaducidad; }
            set { diasCaducidad = value; }
        }
        public abstract string ObtieneInformacion();
    }
}

