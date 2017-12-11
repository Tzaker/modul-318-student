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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrafficSchedules));
            this.lb_start = new System.Windows.Forms.Label();
            this.lb_ziel = new System.Windows.Forms.Label();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.grpbox_selection = new System.Windows.Forms.GroupBox();
            this.rb_departure = new System.Windows.Forms.RadioButton();
            this.rb_connections = new System.Windows.Forms.RadioButton();
            this.lbox_stations = new System.Windows.Forms.ListBox();
            this.bt_newsearch = new System.Windows.Forms.Button();
            this.bt_show = new System.Windows.Forms.Button();
            this.picbox_switchendstart = new System.Windows.Forms.PictureBox();
            this.dgv_connections = new System.Windows.Forms.DataGridView();
            this.trafficSchedulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_date = new System.Windows.Forms.Label();
            this.datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.grpbox_selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_switchendstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_connections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficSchedulesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Location = new System.Drawing.Point(13, 48);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(32, 13);
            this.lb_start.TabIndex = 0;
            this.lb_start.Text = "Start:";
            // 
            // lb_ziel
            // 
            this.lb_ziel.AutoSize = true;
            this.lb_ziel.Location = new System.Drawing.Point(12, 105);
            this.lb_ziel.Name = "lb_ziel";
            this.lb_ziel.Size = new System.Drawing.Size(27, 13);
            this.lb_ziel.TabIndex = 1;
            this.lb_ziel.Text = "Ziel:";
            // 
            // tb_start
            // 
            this.tb_start.Location = new System.Drawing.Point(78, 45);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(228, 20);
            this.tb_start.TabIndex = 1;
            this.tb_start.Click += new System.EventHandler(this.tb_start_Click);
            this.tb_start.TextChanged += new System.EventHandler(this.tb_start_TextChanged);
            // 
            // tb_destination
            // 
            this.tb_destination.Location = new System.Drawing.Point(78, 102);
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(228, 20);
            this.tb_destination.TabIndex = 2;
            this.tb_destination.Click += new System.EventHandler(this.tb_destination_Click);
            this.tb_destination.TextChanged += new System.EventHandler(this.tb_destination_TextChanged);
            // 
            // grpbox_selection
            // 
            this.grpbox_selection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpbox_selection.Controls.Add(this.rb_departure);
            this.grpbox_selection.Controls.Add(this.rb_connections);
            this.grpbox_selection.Location = new System.Drawing.Point(794, 48);
            this.grpbox_selection.Name = "grpbox_selection";
            this.grpbox_selection.Size = new System.Drawing.Size(246, 70);
            this.grpbox_selection.TabIndex = 4;
            this.grpbox_selection.TabStop = false;
            // 
            // rb_departure
            // 
            this.rb_departure.AutoSize = true;
            this.rb_departure.Location = new System.Drawing.Point(0, 42);
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
            // lbox_stations
            // 
            this.lbox_stations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_stations.FormattingEnabled = true;
            this.lbox_stations.Location = new System.Drawing.Point(349, 45);
            this.lbox_stations.Name = "lbox_stations";
            this.lbox_stations.Size = new System.Drawing.Size(389, 121);
            this.lbox_stations.TabIndex = 3;
            this.lbox_stations.Click += new System.EventHandler(this.lbox_stations_Click);
            this.lbox_stations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbox_stations_KeyDown);
            // 
            // bt_newsearch
            // 
            this.bt_newsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_newsearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_newsearch.Location = new System.Drawing.Point(965, 497);
            this.bt_newsearch.Name = "bt_newsearch";
            this.bt_newsearch.Size = new System.Drawing.Size(75, 23);
            this.bt_newsearch.TabIndex = 9;
            this.bt_newsearch.Text = "Neue Suche";
            this.bt_newsearch.UseVisualStyleBackColor = true;
            this.bt_newsearch.Click += new System.EventHandler(this.bt_newsearch_Click);
            // 
            // bt_show
            // 
            this.bt_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_show.Location = new System.Drawing.Point(872, 497);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(75, 23);
            this.bt_show.TabIndex = 8;
            this.bt_show.Text = "Anzeigen";
            this.bt_show.UseVisualStyleBackColor = true;
            this.bt_show.Click += new System.EventHandler(this.bt_show_Click);
            // 
            // picbox_switchendstart
            // 
            this.picbox_switchendstart.Image = ((System.Drawing.Image)(resources.GetObject("picbox_switchendstart.Image")));
            this.picbox_switchendstart.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox_switchendstart.InitialImage")));
            this.picbox_switchendstart.Location = new System.Drawing.Point(172, 71);
            this.picbox_switchendstart.Name = "picbox_switchendstart";
            this.picbox_switchendstart.Size = new System.Drawing.Size(25, 25);
            this.picbox_switchendstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_switchendstart.TabIndex = 10;
            this.picbox_switchendstart.TabStop = false;
            this.picbox_switchendstart.Click += new System.EventHandler(this.picbox_switchendstart_Click);
            // 
            // dgv_connections
            // 
            this.dgv_connections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_connections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_connections.Location = new System.Drawing.Point(16, 197);
            this.dgv_connections.Name = "dgv_connections";
            this.dgv_connections.Size = new System.Drawing.Size(1024, 294);
            this.dgv_connections.TabIndex = 7;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(12, 152);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(44, 13);
            this.lb_date.TabIndex = 12;
            this.lb_date.Text = "Datum: ";
            // 
            // datetimepicker
            // 
            this.datetimepicker.CustomFormat = "dd-MM-yyyy HH:mm";
            this.datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepicker.Location = new System.Drawing.Point(78, 146);
            this.datetimepicker.Name = "datetimepicker";
            this.datetimepicker.Size = new System.Drawing.Size(228, 20);
            this.datetimepicker.TabIndex = 13;
            // 
            // TrafficSchedules
            // 
            this.AcceptButton = this.bt_show;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_newsearch;
            this.ClientSize = new System.Drawing.Size(1062, 561);
            this.Controls.Add(this.datetimepicker);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.dgv_connections);
            this.Controls.Add(this.picbox_switchendstart);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.bt_newsearch);
            this.Controls.Add(this.lbox_stations);
            this.Controls.Add(this.grpbox_selection);
            this.Controls.Add(this.tb_destination);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.lb_ziel);
            this.Controls.Add(this.lb_start);
            this.Name = "TrafficSchedules";
            this.Text = "Traffic Schedules - Swiss Transport";
            this.Load += new System.EventHandler(this.TrafficSchedules_Load);
            this.grpbox_selection.ResumeLayout(false);
            this.grpbox_selection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_switchendstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_connections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trafficSchedulesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_ziel;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.TextBox tb_destination;
        private System.Windows.Forms.GroupBox grpbox_selection;
        private System.Windows.Forms.RadioButton rb_departure;
        private System.Windows.Forms.RadioButton rb_connections;
        private System.Windows.Forms.ListBox lbox_stations;
        private System.Windows.Forms.Button bt_newsearch;
        private System.Windows.Forms.Button bt_show;
        private System.Windows.Forms.PictureBox picbox_switchendstart;
        private System.Windows.Forms.DataGridView dgv_connections;
        private System.Windows.Forms.BindingSource trafficSchedulesBindingSource;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.DateTimePicker datetimepicker;
    }
}

