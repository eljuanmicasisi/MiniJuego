using System.Diagnostics;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        // Insertamos los personajes dentro de la ventana gráfica
        Link player;
        Broncas Enemigo1;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
        }

        private void IniciarPersonajes()
        {
            // Lienzo / coordenadaX / coordenadaY / salud / escudo / arma 
            player = new Link(this, 0, 0, 30, 0, 0);
            Enemigo1 = new Broncas(this, 0, 300);
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cuando se pulse una tecla, llamará al método mover del personaje Link
            player.mover(e);

            // Esto nos permite ver las coordenadas de nuestro personaje en el apartado "Salida"
            Debug.WriteLine("[X" + player.Caja.Location.X + ",Y" + player.Caja.Location.Y + "]");
        }

        // Creamos un timer para el primer Enemigo
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Enemigo1.mover();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}