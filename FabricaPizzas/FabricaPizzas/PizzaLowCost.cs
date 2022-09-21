using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPizzas
{
    public class PizzaLowCost : Pizza, IPiedra, ICongelable
    {
        private int temperaturaCoccion;
        private int diasMaximosCongelado;

        public PizzaLowCost() : base()
        {
            this.diasMaximosCongelado = 0;
            this.temperaturaCoccion = 0;
        }

        public PizzaLowCost(string tipoDeMasa,
                              int diasCaducidad,
                              int numeroHorno,
                              int temperaturaCoccion,
                              int diasMaximosCongelado,
                              string tipoPizza) : base(
                                  tipoDeMasa, diasCaducidad, numeroHorno, tipoPizza)
        {
            this.temperaturaCoccion = temperaturaCoccion;
            this.diasMaximosCongelado = diasMaximosCongelado;
        }

        public int TemperaturaCoccion
        {
            get { return temperaturaCoccion; }
            set { temperaturaCoccion = value; }
        }

        public int DiasMaximosCongelado
        {
            get { return diasMaximosCongelado; }
            set { diasMaximosCongelado = value; }
        }

        public string InfoCongelacion()
        {
            string info = $"Dias maximos de congelacion: {diasMaximosCongelado}";
            return info; ;
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
                InfoCoccion() + " \n" +
                InfoCongelacion();
            return info;
        }
    }
}
