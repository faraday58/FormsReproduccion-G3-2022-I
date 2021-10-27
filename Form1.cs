using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FormsReproduccion_G3_2022_I
{
    public partial class Form1 : Form
    {

        List<Musica> canciones;

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
    }
}
