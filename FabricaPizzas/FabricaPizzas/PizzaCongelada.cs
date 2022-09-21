using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricaPizzas
{
    public class PizzaCongelada : Pizza, ICongelable
    {
        private int diasMaximosCongelado;

        public PizzaCongelada() : base()
        {
            diasMaximosCongelado = 0;
        }

        public PizzaCongelada(string tipoDeMasa,
                              int diasCaducidad,
                              int numeroHorno,
                              int diasMaximosCongelado,
                              string tipoPizza) : base(
                                  tipoDeMasa, diasCaducidad, numeroHorno, tipoPizza)
        {
            this.diasMaximosCongelado = diasMaximosCongelado;
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

        public override string ObtieneInformacion()
        {
            string info = $"Esta Pizza es {tipoPizza}. \n" +
                $"La masa es de {tipoDeMasa} \n" +
                $"Salió del horno {numeroHorno} \n" +
                $"Dias caducidad: {diasCaducidad} \n" +
                InfoCongelacion();
            return info;
        }
    }
}
