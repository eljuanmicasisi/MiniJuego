using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegaJuego
{
    // Creamos el Personaje Link
    internal class Link : Personaje
    {
        private int salud;          // Declaramos la variable salud
        private int escudo;         // Declaramos la variable escudo
        private int arma;           // Declaramos la variable arma

        public Link(Level1 vegaZelda, int x, int y, int s, int e, int a): base(vegaZelda, x, y)
        {
            salud = s;
            escudo = e;
            arma = a;
        }

        public int Arma
        {
            get { return arma; }
            set { arma = value; }
        }

        public int Escudo
        {
            get { return escudo; }
            set { escudo = value; }
        }

        public int Salud
        {
            get { return arma; }
            set { arma = value; }
        }

        // Creamos el método mover, para permitirnos mover el personaje con las teclas W, A, S, D 
        public void mover(KeyPressEventArgs e) { 
        
            // Asignamos los valores para movernos hacia arriba
            if(e.KeyChar == 'w' && (Caja.Location.Y > 0))
            {
                this.Direccion = "ARRIBA";
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.Arriba;
                this.Caja.Location=new Point(this.Caja.Location.X, this.Caja.Location.Y - 10);
            }

            // Asignamos los valores para movernos hacia abajo
            if (e.KeyChar == 's' && (Caja.Location.Y < Lienzo.Size.Height - 160))
            {
                this.Direccion = "ABAJO";
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.Abajo;
                this.Caja.Location = new Point(this.Caja.Location.X, this.Caja.Location.Y + 10);
            }

            // Asignamos los valores para movernos hacia la izquierda
            if (e.KeyChar == 'a' && (Caja.Location.X > 0))
            {
                this.Direccion = "IZQUIERDA";
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.izquierda;
                this.Caja.Location = new Point(this.Caja.Location.X - 10, this.Caja.Location.Y);
            }

            // Asignamos los valores para movernos hacaia la derecha
            if (e.KeyChar == 'd' && (Caja.Location.Y < Lienzo.Size.Height - 120))
            {
                this.Direccion = "DERECHA";
                this.Caja.BackgroundImage = global::VegaJuego.Properties.Resources.derecha;
                this.Caja.Location = new Point(this.Caja.Location.X + 10, this.Caja.Location.Y);
            }

        }

    }

}
