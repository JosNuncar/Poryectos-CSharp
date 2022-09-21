using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPizzas
{
    public class PizzaPiedra: Pizza, IPiedra
    {
        private int temperaturaCoccion;

        public PizzaPiedra() : base()
        {
            temperaturaCoccion = 0;
        }

        public PizzaPiedra(   string tipoDeMasa,
                              int diasCaducidad,
                              int numeroHorno,
                              int temperaturaCoccion,
                              string tipoPizza)
        {
            this.tipoDeMasa = tipoDeMasa;
            this.diasCaducidad = diasCaducidad;
            this.numeroHorno = numeroHorno;
            this.temperaturaCoccion = temperaturaCoccion;
            this.tipoPizza = tipoPizza;
        }

        public int TemperaturaCoccion
        {
            get { return temperaturaCoccion; }
            set { temperaturaCoccion = value; }
        }

        public string InfoCoccion()
        {
            string info = $"Temperatura para cocción: {temperaturaCoccion}";
            return info; ;
        }

        public override string ObtieneInformacion()
        {
            string info = $"Esta Pizza es {tipoPizza}. \n" +
                $"La masa es de {tipoDeMasa} \n" +
                $"Salió del horno {numeroHorno} \n" +
                $"Dias caducidad: {diasCaducidad} \n" +
                InfoCoccion();
            return info;
        }
    }
}
