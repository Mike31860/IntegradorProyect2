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
			this.abrirDialogo = new System.Windows.Forms.OpenFileDialog();
			this.ABRIROPEN = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.zoomMelo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			// abrirDialogo
			// 
			this.abrirDialogo.FileName = "AbrirDialogo";
			// 
			// ABRIROPEN
			// 
			this.ABRIROPEN.Location = new System.Drawing.Point(413, 304);
			this.ABRIROPEN.Name = "ABRIROPEN";
			this.ABRIROPEN.Size = new System.Drawing.Size(75, 23);
			this.ABRIROPEN.TabIndex = 6;
			this.ABRIROPEN.Text = "Abir";
			this.ABRIROPEN.UseVisualStyleBackColor = true;
			this.ABRIROPEN.Click += new System.EventHandler(this.ABRIROPEN_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView1.Location = new System.Drawing.Point(384, 96);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(404, 193);
			this.dataGridView1.TabIndex = 7;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Column2";
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Column3";
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Column4";
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Column5";
			this.Column5.Name = "Column5";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.ABRIROPEN);
			this.Controls.Add(this.zoomMelo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Relieve);
			this.Controls.Add(this.normal);
			this.Controls.Add(this.satelite);
			this.Controls.Add(this.gmap);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.zoomMelo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}

