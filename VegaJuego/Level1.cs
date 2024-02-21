using System.Diagnostics;
using System.Media;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        // Insertamos los personajes dentro de la ventana gráfica
        Link player;
        Broncas Enemigo1;
        SoundPlayer musica;
        Boolean HaySonido = false;


        public Level1(CheckBox onOff)
        {
            InitializeComponent();
            IniciarPersonajes();
            IniciarOpcionesDelMapa(onOff);
        }

        // Aignamos los valores de la salud, escudo y arma visualmente al juego
        private void IniciarOpcionesDelMapa(CheckBox onOff)
        {
            if(onOff.Checked==true) {
                musica = new SoundPlayer(global::VegaJuego.Properties.Resources.WhatsApp_Audio_2024_02_21_at_20_10_40);
                musica.PlayLooping();
                HaySonido =true;
            }
            labelVida.Text = "Salud->" + player.Salud;
            labelEscudo.Text = "Escudo->" + player.Escudo;
            labelArma.Text = "Arma->" + player.Arma;

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
            labelVida.Text = "Salud->" + player.Salud;
            labelEscudo.Text = "Escudo->" + player.Escudo;
            labelArma.Text = "Arma->" + player.Arma;

            // Si colisiona el enemigo con el personaje, bajará en 1 la vida 
            if (player.Caja.Bounds.IntersectsWith(Enemigo1.Caja.Bounds))
            {
                player.Salud = player.Salud - 1;

            }
            Enemigo1.mover();

            // Si la vida del personaje es 0 o menor, acaba el juego y para la música
            if (player.Salud <= 0)
            {
                this.Hide();
                if (HaySonido == true)
                {
                    musica.Stop();
                }
                Final End = new Final();
                // Paramos el temporizador 
                MovEnemigos.Stop();
                End.Show();

            }
        }
        // Boton de exit del juego
        private void Level1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}