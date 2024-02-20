using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegaJuego
{
    // Creamos el personaje Broncas
    internal class Broncas : Personaje
    {
        // Creamos el constructor del personaje
        public Broncas(Level1 vegaZelda, int x, int y) : base(vegaZelda, x, y) {

            Caja.BackgroundImage = global::VegaJuego.Properties.Resources.Broncas_abajo;

        }
        // Creamos el método mover para el personaje Broncas
        public new void mover()
        {
            // Hacemos que el personaje se mueva hacia la derecha
            if (Direccion == "DERECHA")
            {
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.Broncas_Derecha;
                this.Caja.Location= new Point(Caja.Location.X + 10, Caja.Location.Y);       // Velocidad = 10 (Se puede aumentar variando ese numero)
                // Si el personaje llega hasta el borde derecho de la pantalla, cambiará su dirección hacia la izquierda
                if (Caja.Location.X > Lienzo.Size.Width - 120)
                {
                    Direccion = "IZQUIERDA";
                }
            }
            // Hacemos que el personaje se mueva hacia la izquierda
            if (Direccion == "IZQUIERDA")
            {
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.Broncas_Izquierda;
                this.Caja.Location = new Point(Caja.Location.X - 10, Caja.Location.Y);      // Velocidad = 10 (Se puede aumentar variando ese numero)
                // Si el personaje llega hasta el borde izquierdo de la pantalla, cambiará su dirección hacia la derecha
                if (Caja.Location.X < 0)
                {
                    Direccion = "DERECHA";
                }
            }
        }

    }
}
