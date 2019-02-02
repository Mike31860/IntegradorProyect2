namespace ProyectoNumero2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.gmap = new GMap.NET.WindowsForms.GMapControl();
			this.satelite = new System.Windows.Forms.Button();
			this.normal = new System.Windows.Forms.Button();
			this.Relieve = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.zoomMelo = new System.Windows.Forms.TrackBar();
			this.ZOOM = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.zoomMelo)).BeginInit();
			this.SuspendLayout();
			// 
			// gmap
			// 
			this.gmap.Bearing = 0F;
			this.gmap.CanDragMap = true;
			this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
			this.gmap.GrayScaleMode = false;
			this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
			this.gmap.LevelsKeepInMemmory = 5;
			this.gmap.Location = new System.Drawing.Point(38, 41);
			this.gmap.MarkersEnabled = true;
			this.gmap.MaxZoom = 18;
			this.gmap.MinZoom = 2;
			this.gmap.MouseWheelZoomEnabled = true;
			this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
			this.gmap.Name = "gmap";
			this.gmap.NegativeMode = false;
			this.gmap.PolygonsEnabled = true;
			this.gmap.RetryLoadTile = 0;
			this.gmap.RoutesEnabled = true;
			this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
			this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
			this.gmap.ShowTileGridLines = false;
			this.gmap.Size = new System.Drawing.Size(295, 302);
			this.gmap.TabIndex = 0;
			this.gmap.Zoom = 5D;
			this.gmap.Load += new System.EventHandler(this.mapaColombia_Load);
			// 
			// satelite
			// 
			this.satelite.Location = new System.Drawing.Point(38, 363);
			this.satelite.Name = "satelite";
			this.satelite.Size = new System.Drawing.Size(75, 23);
			this.satelite.TabIndex = 1;
			this.satelite.Text = "Satélite";
			this.satelite.UseVisualStyleBackColor = true;
			this.satelite.Click += new System.EventHandler(this.satelite_Click);
			// 
			// normal
			// 
			this.normal.Location = new System.Drawing.Point(141, 363);
			this.normal.Name = "normal";
			this.normal.Size = new System.Drawing.Size(75, 23);
			this.normal.TabIndex = 2;
			this.normal.Text = "Normal";
			this.normal.UseVisualStyleBackColor = true;
			this.normal.Click += new System.EventHandler(this.normal_Click);
			// 
			// Relieve
			// 
			this.Relieve.Location = new System.Drawing.Point(240, 363);
			this.Relieve.Name = "Relieve";
			this.Relieve.Size = new System.Drawing.Size(75, 23);
			this.Relieve.TabIndex = 3;
			this.Relieve.Text = "Relieve";
			this.Relieve.UseVisualStyleBackColor = true;
			this.Relieve.Click += new System.EventHandler(this.Relieve_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 403);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Zoom:";
			// 
			// zoomMelo
			// 
			this.zoomMelo.Location = new System.Drawing.Point(141, 403);
			this.zoomMelo.Maximum = 25;
			this.zoomMelo.Name = "zoomMelo";
			this.zoomMelo.Size = new System.Drawing.Size(192, 45);
			this.zoomMelo.TabIndex = 5;
			this.zoomMelo.ValueChanged += new System.EventHandler(this.zoomMelo_ValueChanged);
			// 
			// ZOOM
			// 
			this.ZOOM.Enabled = true;
			this.ZOOM.Interval = 10;
			this.ZOOM.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.zoomMelo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Relieve);
			this.Controls.Add(this.normal);
			this.Controls.Add(this.satelite);
			this.Controls.Add(this.gmap);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.zoomMelo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private GMap.NET.WindowsForms.GMapControl gmap;
		private System.Windows.Forms.Button satelite;
		private System.Windows.Forms.Button normal;
		private System.Windows.Forms.Button Relieve;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TrackBar zoomMelo;
		private System.Windows.Forms.Timer ZOOM;
	}
}

