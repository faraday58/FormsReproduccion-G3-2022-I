using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormsReproduccion_G3_2022_I
{
    public partial class Form1 : Form
    {

        List<Musica> canciones;
        private int contador;
        public Form1()
        {
            InitializeComponent();
            canciones = new List<Musica>();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarCanciones();
            foreach(Musica musica in canciones   )
            {
                lstCanciones.Items.Add(musica.Cancion);
            }

        }

        public void CargarCanciones()
        {
            canciones.Add(new Musica("La leyenda del ada y el mago","Rata blanca"," Magos, espadas y rosas"));
            canciones.Add(new Musica("Warrios ","Imagine Dragons", "smoke and mirrors" ) );
        }

        private void lstCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCancion.Text = canciones[lstCanciones.SelectedIndex].Cancion;
            lbArtista.Text = canciones[lstCanciones.SelectedIndex].Artista;
            lbAlbum.Text = canciones[lstCanciones.SelectedIndex].Album;
        }

        private void ordenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canciones.Sort();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.EnviarMusica += AgregarCanciones;
            formAgregar.ShowDialog();

        }

        public void AgregarCanciones(Musica musica )
        {
            canciones.Add(musica);
            lstCanciones.Items.Add(musica.Cancion);

        }

        private void timerCancion_Tick(object sender, EventArgs e)
        {
            lbTiempoTrans.Text = contador.ToString();
            contador++;
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerCancion.Start();
        }

        private void pausarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerCancion.Stop();
        }
    }
}
