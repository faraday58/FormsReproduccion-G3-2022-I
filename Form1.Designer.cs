
namespace FormsReproduccion_G3_2022_I
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCancion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbArtista = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.automáticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bucleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbAlbumArtista = new System.Windows.Forms.PictureBox();
            this.pbrTiempoTrans = new System.Windows.Forms.ProgressBar();
            this.lbTiempoTrans = new System.Windows.Forms.Label();
            this.lbTiempoDuracion = new System.Windows.Forms.Label();
            this.timerCancion = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlbumArtista)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCanciones
            // 
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 32;
            this.lstCanciones.Location = new System.Drawing.Point(36, 256);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(542, 452);
            this.lstCanciones.TabIndex = 0;
            this.lstCanciones.SelectedIndexChanged += new System.EventHandler(this.lstCanciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(708, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Canción";
            // 
            // lbCancion
            // 
            this.lbCancion.AutoSize = true;
            this.lbCancion.Location = new System.Drawing.Point(853, 318);
            this.lbCancion.Name = "lbCancion";
            this.lbCancion.Size = new System.Drawing.Size(78, 32);
            this.lbCancion.TabIndex = 1;
            this.lbCancion.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(708, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Artísta";
            // 
            // lbArtista
            // 
            this.lbArtista.AutoSize = true;
            this.lbArtista.Location = new System.Drawing.Point(853, 379);
            this.lbArtista.Name = "lbArtista";
            this.lbArtista.Size = new System.Drawing.Size(78, 32);
            this.lbArtista.TabIndex = 1;
            this.lbArtista.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(708, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Álbum";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Location = new System.Drawing.Point(853, 435);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(78, 32);
            this.lbAlbum.TabIndex = 1;
            this.lbAlbum.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reproducciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1938, 42);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.ordenarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(114, 38);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(347, 44);
            this.cargarToolStripMenuItem.Text = "Cargar Canciones";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(347, 44);
            this.agregarToolStripMenuItem.Text = "Agregar Canciones";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(347, 44);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            this.ordenarToolStripMenuItem.Click += new System.EventHandler(this.ordenarToolStripMenuItem_Click);
            // 
            // reproducciónToolStripMenuItem
            // 
            this.reproducciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.siguienteToolStripMenuItem,
            this.anteriorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.automáticaToolStripMenuItem,
            this.aleatoriaToolStripMenuItem,
            this.bucleToolStripMenuItem});
            this.reproducciónToolStripMenuItem.Name = "reproducciónToolStripMenuItem";
            this.reproducciónToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.reproducciónToolStripMenuItem.Text = "Reproducción";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.pausarToolStripMenuItem.Text = "Pausar";
            this.pausarToolStripMenuItem.Click += new System.EventHandler(this.pausarToolStripMenuItem_Click);
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.siguienteToolStripMenuItem.Text = "Siguiente";
            // 
            // anteriorToolStripMenuItem
            // 
            this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.anteriorToolStripMenuItem.Text = "Anterior";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(356, 6);
            // 
            // automáticaToolStripMenuItem
            // 
            this.automáticaToolStripMenuItem.Name = "automáticaToolStripMenuItem";
            this.automáticaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.automáticaToolStripMenuItem.Text = "Automática";
            // 
            // aleatoriaToolStripMenuItem
            // 
            this.aleatoriaToolStripMenuItem.Name = "aleatoriaToolStripMenuItem";
            this.aleatoriaToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.aleatoriaToolStripMenuItem.Text = "Aleatoria";
            // 
            // bucleToolStripMenuItem
            // 
            this.bucleToolStripMenuItem.Name = "bucleToolStripMenuItem";
            this.bucleToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.bucleToolStripMenuItem.Text = "Bucle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de Reproducción";
            // 
            // ptbAlbumArtista
            // 
            this.ptbAlbumArtista.Image = global::FormsReproduccion_G3_2022_I.Properties.Resources.imagineDragons;
            this.ptbAlbumArtista.Location = new System.Drawing.Point(1391, 203);
            this.ptbAlbumArtista.Name = "ptbAlbumArtista";
            this.ptbAlbumArtista.Size = new System.Drawing.Size(497, 342);
            this.ptbAlbumArtista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAlbumArtista.TabIndex = 4;
            this.ptbAlbumArtista.TabStop = false;
            // 
            // pbrTiempoTrans
            // 
            this.pbrTiempoTrans.Location = new System.Drawing.Point(749, 634);
            this.pbrTiempoTrans.Name = "pbrTiempoTrans";
            this.pbrTiempoTrans.Size = new System.Drawing.Size(667, 10);
            this.pbrTiempoTrans.TabIndex = 5;
            // 
            // lbTiempoTrans
            // 
            this.lbTiempoTrans.AutoSize = true;
            this.lbTiempoTrans.Location = new System.Drawing.Point(688, 620);
            this.lbTiempoTrans.Name = "lbTiempoTrans";
            this.lbTiempoTrans.Size = new System.Drawing.Size(27, 32);
            this.lbTiempoTrans.TabIndex = 6;
            this.lbTiempoTrans.Text = "0";
            // 
            // lbTiempoDuracion
            // 
            this.lbTiempoDuracion.AutoSize = true;
            this.lbTiempoDuracion.Location = new System.Drawing.Point(1450, 619);
            this.lbTiempoDuracion.Name = "lbTiempoDuracion";
            this.lbTiempoDuracion.Size = new System.Drawing.Size(110, 32);
            this.lbTiempoDuracion.TabIndex = 6;
            this.lbTiempoDuracion.Text = "Duración";
            // 
            // timerCancion
            // 
            this.timerCancion.Interval = 1000;
            this.timerCancion.Tick += new System.EventHandler(this.timerCancion_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1938, 789);
            this.Controls.Add(this.lbTiempoDuracion);
            this.Controls.Add(this.lbTiempoTrans);
            this.Controls.Add(this.pbrTiempoTrans);
            this.Controls.Add(this.ptbAlbumArtista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.lbArtista);
            this.Controls.Add(this.lbCancion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCanciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAlbumArtista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCancion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbArtista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ordenarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem automáticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aleatoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bucleToolStripMenuItem;
        private System.Windows.Forms.PictureBox ptbAlbumArtista;
        private System.Windows.Forms.ProgressBar pbrTiempoTrans;
        private System.Windows.Forms.Label lbTiempoTrans;
        private System.Windows.Forms.Label lbTiempoDuracion;
        private System.Windows.Forms.Timer timerCancion;
    }
}

