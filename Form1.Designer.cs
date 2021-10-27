
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
            this.label2 = new System.Windows.Forms.Label();
            this.ordenarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1616, 42);
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
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.agregarToolStripMenuItem.Text = "Agregar";
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
            // ordenarToolStripMenuItem
            // 
            this.ordenarToolStripMenuItem.Name = "ordenarToolStripMenuItem";
            this.ordenarToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.ordenarToolStripMenuItem.Text = "Ordenar";
            this.ordenarToolStripMenuItem.Click += new System.EventHandler(this.ordenarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 789);
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
    }
}

