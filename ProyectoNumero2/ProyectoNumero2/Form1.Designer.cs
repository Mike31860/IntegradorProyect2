﻿namespace ProyectoNumero2
{
    partial class ciudad
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ciudad));
			this.gmap = new GMap.NET.WindowsForms.GMapControl();
			this.satelite = new System.Windows.Forms.Button();
			this.normal = new System.Windows.Forms.Button();
			this.Relieve = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.zoomMelo = new System.Windows.Forms.TrackBar();
			this.ZOOM = new System.Windows.Forms.Timer(this.components);
			this.abrirDialogo = new System.Windows.Forms.OpenFileDialog();
			this.ABRIROPEN = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.labelCiudad = new System.Windows.Forms.Label();
			this.labelDireccion = new System.Windows.Forms.Label();
			this.labelUbicacion = new System.Windows.Forms.Label();
			this.data = new System.Windows.Forms.DataGridView();
			this.Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PuntoUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ubicación = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UbicaciónDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.zoomMelo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
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
			this.gmap.Location = new System.Drawing.Point(35, 179);
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
			this.gmap.Size = new System.Drawing.Size(549, 330);
			this.gmap.TabIndex = 0;
			this.gmap.Zoom = 5D;
			this.gmap.Load += new System.EventHandler(this.mapaColombia_Load);
			// 
			// satelite
			// 
			this.satelite.Location = new System.Drawing.Point(473, 548);
			this.satelite.Name = "satelite";
			this.satelite.Size = new System.Drawing.Size(75, 23);
			this.satelite.TabIndex = 1;
			this.satelite.Text = "Satélite";
			this.satelite.UseVisualStyleBackColor = true;
			this.satelite.Click += new System.EventHandler(this.satelite_Click);
			// 
			// normal
			// 
			this.normal.Location = new System.Drawing.Point(377, 548);
			this.normal.Name = "normal";
			this.normal.Size = new System.Drawing.Size(75, 23);
			this.normal.TabIndex = 2;
			this.normal.Text = "Normal";
			this.normal.UseVisualStyleBackColor = true;
			this.normal.Click += new System.EventHandler(this.normal_Click);
			// 
			// Relieve
			// 
			this.Relieve.Location = new System.Drawing.Point(282, 548);
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
			this.label1.Location = new System.Drawing.Point(32, 559);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Zoom:";
			// 
			// zoomMelo
			// 
			this.zoomMelo.Location = new System.Drawing.Point(75, 548);
			this.zoomMelo.Maximum = 25;
			this.zoomMelo.Name = "zoomMelo";
			this.zoomMelo.Size = new System.Drawing.Size(192, 45);
			this.zoomMelo.TabIndex = 5;
			this.zoomMelo.Scroll += new System.EventHandler(this.zoomMelo_Scroll);
			this.zoomMelo.ValueChanged += new System.EventHandler(this.zoomMelo_ValueChanged);
			// 
			// ZOOM
			// 
			this.ZOOM.Enabled = true;
			this.ZOOM.Interval = 10;
			this.ZOOM.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// abrirDialogo
			// 
			this.abrirDialogo.FileName = "AbrirDialogo";
			// 
			// ABRIROPEN
			// 
			this.ABRIROPEN.Location = new System.Drawing.Point(875, 536);
			this.ABRIROPEN.Name = "ABRIROPEN";
			this.ABRIROPEN.Size = new System.Drawing.Size(75, 23);
			this.ABRIROPEN.TabIndex = 6;
			this.ABRIROPEN.Text = "Abir";
			this.ABRIROPEN.UseVisualStyleBackColor = true;
			this.ABRIROPEN.Click += new System.EventHandler(this.ABRIROPEN_Click_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(37, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1100, 138);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(816, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 24);
			this.label2.TabIndex = 8;
			this.label2.Text = "Datos de la zona";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// labelCiudad
			// 
			this.labelCiudad.AutoSize = true;
			this.labelCiudad.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCiudad.Location = new System.Drawing.Point(722, 259);
			this.labelCiudad.Name = "labelCiudad";
			this.labelCiudad.Size = new System.Drawing.Size(0, 20);
			this.labelCiudad.TabIndex = 12;
			this.labelCiudad.Click += new System.EventHandler(this.labelCiudad_Click);
			// 
			// labelDireccion
			// 
			this.labelDireccion.AutoSize = true;
			this.labelDireccion.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDireccion.Location = new System.Drawing.Point(722, 348);
			this.labelDireccion.Name = "labelDireccion";
			this.labelDireccion.Size = new System.Drawing.Size(0, 20);
			this.labelDireccion.TabIndex = 13;
			this.labelDireccion.Click += new System.EventHandler(this.labelDireccion_Click);
			// 
			// labelUbicacion
			// 
			this.labelUbicacion.AutoSize = true;
			this.labelUbicacion.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUbicacion.Location = new System.Drawing.Point(722, 445);
			this.labelUbicacion.Name = "labelUbicacion";
			this.labelUbicacion.Size = new System.Drawing.Size(0, 20);
			this.labelUbicacion.TabIndex = 14;
			this.labelUbicacion.Click += new System.EventHandler(this.labelUbicacion_Click);
			// 
			// data
			// 
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Municipio,
            this.PuntoUbicacion,
            this.Column3,
            this.Ubicación,
            this.UbicaciónDos});
			this.data.Location = new System.Drawing.Point(607, 230);
			this.data.Name = "data";
			this.data.Size = new System.Drawing.Size(530, 279);
			this.data.TabIndex = 15;
			// 
			// Municipio
			// 
			this.Municipio.HeaderText = "Municipio";
			this.Municipio.Name = "Municipio";
			// 
			// PuntoUbicacion
			// 
			this.PuntoUbicacion.HeaderText = "Punto Ubicación";
			this.PuntoUbicacion.Name = "PuntoUbicacion";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Dirección";
			this.Column3.Name = "Column3";
			// 
			// Ubicación
			// 
			this.Ubicación.HeaderText = "Ubicación";
			this.Ubicación.Name = "Ubicación";
			// 
			// UbicaciónDos
			// 
			this.UbicaciónDos.HeaderText = "UbicaciónDos";
			this.UbicaciónDos.Name = "UbicaciónDos";
			// 
			// ciudad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1171, 598);
			this.Controls.Add(this.data);
			this.Controls.Add(this.labelUbicacion);
			this.Controls.Add(this.labelDireccion);
			this.Controls.Add(this.labelCiudad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.ABRIROPEN);
			this.Controls.Add(this.zoomMelo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Relieve);
			this.Controls.Add(this.normal);
			this.Controls.Add(this.satelite);
			this.Controls.Add(this.gmap);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ciudad";
			this.Text = "Zonas wifi";
			((System.ComponentModel.ISupportInitialize)(this.zoomMelo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
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
		private System.Windows.Forms.OpenFileDialog abrirDialogo;
		private System.Windows.Forms.Button ABRIROPEN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCiudad;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelUbicacion;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.DataGridViewTextBoxColumn Municipio;
		private System.Windows.Forms.DataGridViewTextBoxColumn PuntoUbicacion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ubicación;
		private System.Windows.Forms.DataGridViewTextBoxColumn UbicaciónDos;
	}
}

