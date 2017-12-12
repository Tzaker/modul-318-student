namespace TrafficSchedules
{
    partial class TrafficSchedules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficSchedules));
            this.lb_start = new System.Windows.Forms.Label();
            this.grpbox_selection = new System.Windows.Forms.GroupBox();
            this.rb_departure = new System.Windows.Forms.RadioButton();
            this.rb_connections = new System.Windows.Forms.RadioButton();
            this.lb_ziel = new System.Windows.Forms.Label();
            this.lbox_stations = new System.Windows.Forms.ListBox();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.dgv_connections = new System.Windows.Forms.DataGridView();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.picbox_switchendstart = new System.Windows.Forms.PictureBox();
            this.bt_newsearch = new System.Windows.Forms.Button();
            this.lb_date = new System.Windows.Forms.Label();
            this.bt_email = new System.Windows.Forms.Button();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.bt_show = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.grpbox_selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_connections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_switchendstart)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Location = new System.Drawing.Point(32, 32);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(32, 13);
            this.lb_start.TabIndex = 0;
            this.lb_start.Text = "Start:";
            // 
            // grpbox_selection
            // 
            this.grpbox_selection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbox_selection.Controls.Add(this.rb_departure);
            this.grpbox_selection.Controls.Add(this.rb_connections);
            this.grpbox_selection.Location = new System.Drawing.Point(855, 32);
            this.grpbox_selection.Name = "grpbox_selection";
            this.grpbox_selection.Size = new System.Drawing.Size(331, 81);
            this.grpbox_selection.TabIndex = 5;
            this.grpbox_selection.TabStop = false;
            // 
            // rb_departure
            // 
            this.rb_departure.AutoSize = true;
            this.rb_departure.Location = new System.Drawing.Point(0, 46);
            this.rb_departure.Name = "rb_departure";
            this.rb_departure.Size = new System.Drawing.Size(147, 17);
            this.rb_departure.TabIndex = 5;
            this.rb_departure.Text = "Abfahrtstabelle ab Startort";
            this.rb_departure.UseVisualStyleBackColor = true;
            this.rb_departure.CheckedChanged += new System.EventHandler(this.rb_departure_CheckedChanged);
            // 
            // rb_connections
            // 
            this.rb_connections.AutoSize = true;
            this.rb_connections.Checked = true;
            this.rb_connections.Location = new System.Drawing.Point(0, 19);
            this.rb_connections.Name = "rb_connections";
            this.rb_connections.Size = new System.Drawing.Size(91, 17);
            this.rb_connections.TabIndex = 4;
            this.rb_connections.TabStop = true;
            this.rb_connections.Text = "Verbindungen";
            this.rb_connections.UseVisualStyleBackColor = true;
            this.rb_connections.CheckedChanged += new System.EventHandler(this.rb_connections_CheckedChanged);
            // 
            // lb_ziel
            // 
            this.lb_ziel.AutoSize = true;
            this.lb_ziel.Location = new System.Drawing.Point(31, 89);
            this.lb_ziel.Name = "lb_ziel";
            this.lb_ziel.Size = new System.Drawing.Size(27, 13);
            this.lb_ziel.TabIndex = 1;
            this.lb_ziel.Text = "Ziel:";
            // 
            // lbox_stations
            // 
            this.lbox_stations.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbox_stations.FormattingEnabled = true;
            this.lbox_stations.Location = new System.Drawing.Point(332, 32);
            this.lbox_stations.Name = "lbox_stations";
            this.lbox_stations.Size = new System.Drawing.Size(477, 121);
            this.lbox_stations.TabIndex = 4;
            this.lbox_stations.Click += new System.EventHandler(this.lbox_stations_Click);
            this.lbox_stations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbox_stations_KeyDown);
            // 
            // tb_start
            // 
            this.tb_start.Location = new System.Drawing.Point(97, 29);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(207, 20);
            this.tb_start.TabIndex = 1;
            this.tb_start.Click += new System.EventHandler(this.tb_start_Click);
            this.tb_start.TextChanged += new System.EventHandler(this.tb_start_TextChanged);
            // 
            // dgv_connections
            // 
            this.dgv_connections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_connections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_connections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_connections.Location = new System.Drawing.Point(35, 181);
            this.dgv_connections.Name = "dgv_connections";
            this.dgv_connections.ReadOnly = true;
            this.dgv_connections.Size = new System.Drawing.Size(774, 390);
            this.dgv_connections.TabIndex = 7;
            this.dgv_connections.TabStop = false;
            // 
            // tb_destination
            // 
            this.tb_destination.Location = new System.Drawing.Point(97, 86);
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(207, 20);
            this.tb_destination.TabIndex = 2;
            this.tb_destination.Click += new System.EventHandler(this.tb_destination_Click);
            this.tb_destination.TextChanged += new System.EventHandler(this.tb_destination_TextChanged);
            // 
            // picbox_switchendstart
            // 
            this.picbox_switchendstart.Image = ((System.Drawing.Image)(resources.GetObject("picbox_switchendstart.Image")));
            this.picbox_switchendstart.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox_switchendstart.InitialImage")));
            this.picbox_switchendstart.Location = new System.Drawing.Point(191, 55);
            this.picbox_switchendstart.Name = "picbox_switchendstart";
            this.picbox_switchendstart.Size = new System.Drawing.Size(25, 25);
            this.picbox_switchendstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_switchendstart.TabIndex = 10;
            this.picbox_switchendstart.TabStop = false;
            this.picbox_switchendstart.Click += new System.EventHandler(this.picbox_switchendstart_Click);
            // 
            // bt_newsearch
            // 
            this.bt_newsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_newsearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_newsearch.Location = new System.Drawing.Point(1111, 588);
            this.bt_newsearch.Name = "bt_newsearch";
            this.bt_newsearch.Size = new System.Drawing.Size(75, 23);
            this.bt_newsearch.TabIndex = 8;
            this.bt_newsearch.Text = "Neue Suche";
            this.bt_newsearch.UseVisualStyleBackColor = true;
            this.bt_newsearch.Click += new System.EventHandler(this.bt_newsearch_Click);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(31, 136);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(44, 13);
            this.lb_date.TabIndex = 12;
            this.lb_date.Text = "Datum: ";
            // 
            // bt_email
            // 
            this.bt_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_email.Location = new System.Drawing.Point(1039, 126);
            this.bt_email.Name = "bt_email";
            this.bt_email.Size = new System.Drawing.Size(147, 23);
            this.bt_email.TabIndex = 6;
            this.bt_email.Text = "Daten per Email exportieren";
            this.bt_email.UseVisualStyleBackColor = true;
            this.bt_email.Click += new System.EventHandler(this.bt_email_Click);
            // 
            // datetimepicker
            // 
            this.datetimepicker.CustomFormat = "dd-MM-yyyy HH:mm";
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepicker.Location = new System.Drawing.Point(97, 130);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(207, 20);
            this.datetimepicker.TabIndex = 3;
            // 
            // bt_show
            // 
            this.bt_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_show.Location = new System.Drawing.Point(1004, 588);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(75, 23);
            this.bt_show.TabIndex = 7;
            this.bt_show.Text = "Anzeigen";
            this.bt_show.UseVisualStyleBackColor = true;
            this.bt_show.Click += new System.EventHandler(this.bt_show_Click);
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(855, 181);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 17;
            this.gmap.MinZoom = 14;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(331, 390);
            this.gmap.TabIndex = 14;
            this.gmap.TabStop = false;
            this.gmap.Zoom = 0D;
            // 
            // TrafficSchedules
            // 
            this.AcceptButton = this.bt_show;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_newsearch;
            this.ClientSize = new System.Drawing.Size(1210, 635);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.dgv_connections);
            this.Controls.Add(this.datetimepicker);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.bt_email);
            this.Controls.Add(this.picbox_switchendstart);
            this.Controls.Add(this.tb_destination);
            this.Controls.Add(this.bt_newsearch);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.grpbox_selection);
            this.Controls.Add(this.lb_ziel);
            this.Controls.Add(this.lbox_stations);
            this.Controls.Add(this.lb_start);
            this.Name = "TrafficSchedules";
            this.Text = "Traffic Schedules - Swiss Transport";
            this.grpbox_selection.ResumeLayout(false);
            this.grpbox_selection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_connections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_switchendstart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.GroupBox grpbox_selection;
        private System.Windows.Forms.RadioButton rb_departure;
        private System.Windows.Forms.RadioButton rb_connections;
        private System.Windows.Forms.Label lb_ziel;
        private System.Windows.Forms.ListBox lbox_stations;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.DataGridView dgv_connections;
        private System.Windows.Forms.TextBox tb_destination;
        private System.Windows.Forms.PictureBox picbox_switchendstart;
        private System.Windows.Forms.Button bt_newsearch;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Button bt_email;
        private System.Windows.Forms.DateTimePicker datetimepicker;
        private System.Windows.Forms.Button bt_show;
        private GMap.NET.WindowsForms.GMapControl gmap;
    }
}

