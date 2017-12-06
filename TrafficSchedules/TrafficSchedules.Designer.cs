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
            this.lb_ziel = new System.Windows.Forms.Label();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.tb_destination = new System.Windows.Forms.TextBox();
            this.grpbox_selection = new System.Windows.Forms.GroupBox();
            this.rb_nearme = new System.Windows.Forms.RadioButton();
            this.rb_departure = new System.Windows.Forms.RadioButton();
            this.rb_connections = new System.Windows.Forms.RadioButton();
            this.lbox_stations = new System.Windows.Forms.ListBox();
            this.lbox_connections = new System.Windows.Forms.ListBox();
            this.bt_newsearch = new System.Windows.Forms.Button();
            this.bt_show = new System.Windows.Forms.Button();
            this.picbox_switchendstart = new System.Windows.Forms.PictureBox();
            this.grpbox_selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_switchendstart)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Location = new System.Drawing.Point(13, 45);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(29, 13);
            this.lb_start.TabIndex = 0;
            this.lb_start.Text = "Start";
            // 
            // lb_ziel
            // 
            this.lb_ziel.AutoSize = true;
            this.lb_ziel.Location = new System.Drawing.Point(13, 120);
            this.lb_ziel.Name = "lb_ziel";
            this.lb_ziel.Size = new System.Drawing.Size(24, 13);
            this.lb_ziel.TabIndex = 1;
            this.lb_ziel.Text = "Ziel";
            // 
            // tb_start
            // 
            this.tb_start.Location = new System.Drawing.Point(94, 42);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(200, 20);
            this.tb_start.TabIndex = 1;
            this.tb_start.TextChanged += new System.EventHandler(this.tb_start_TextChanged);
            // 
            // tb_destination
            // 
            this.tb_destination.Location = new System.Drawing.Point(94, 117);
            this.tb_destination.Name = "tb_destination";
            this.tb_destination.Size = new System.Drawing.Size(200, 20);
            this.tb_destination.TabIndex = 2;
            // 
            // grpbox_selection
            // 
            this.grpbox_selection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpbox_selection.Controls.Add(this.rb_nearme);
            this.grpbox_selection.Controls.Add(this.rb_departure);
            this.grpbox_selection.Controls.Add(this.rb_connections);
            this.grpbox_selection.Location = new System.Drawing.Point(94, 234);
            this.grpbox_selection.Name = "grpbox_selection";
            this.grpbox_selection.Size = new System.Drawing.Size(200, 120);
            this.grpbox_selection.TabIndex = 4;
            this.grpbox_selection.TabStop = false;
            // 
            // rb_nearme
            // 
            this.rb_nearme.AutoSize = true;
            this.rb_nearme.Location = new System.Drawing.Point(6, 97);
            this.rb_nearme.Name = "rb_nearme";
            this.rb_nearme.Size = new System.Drawing.Size(96, 17);
            this.rb_nearme.TabIndex = 5;
            this.rb_nearme.Text = "in meiner Nähe";
            this.rb_nearme.UseVisualStyleBackColor = true;
            // 
            // rb_departure
            // 
            this.rb_departure.AutoSize = true;
            this.rb_departure.Location = new System.Drawing.Point(6, 58);
            this.rb_departure.Name = "rb_departure";
            this.rb_departure.Size = new System.Drawing.Size(147, 17);
            this.rb_departure.TabIndex = 4;
            this.rb_departure.Text = "Abfahrtstabelle ab Startort";
            this.rb_departure.UseVisualStyleBackColor = true;
            // 
            // rb_connections
            // 
            this.rb_connections.AutoSize = true;
            this.rb_connections.Checked = true;
            this.rb_connections.Location = new System.Drawing.Point(6, 19);
            this.rb_connections.Name = "rb_connections";
            this.rb_connections.Size = new System.Drawing.Size(91, 17);
            this.rb_connections.TabIndex = 3;
            this.rb_connections.TabStop = true;
            this.rb_connections.Text = "Verbindungen";
            this.rb_connections.UseVisualStyleBackColor = true;
            // 
            // lbox_stations
            // 
            this.lbox_stations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_stations.FormattingEnabled = true;
            this.lbox_stations.Location = new System.Drawing.Point(359, 42);
            this.lbox_stations.Name = "lbox_stations";
            this.lbox_stations.Size = new System.Drawing.Size(457, 95);
            this.lbox_stations.TabIndex = 6;
            // 
            // lbox_connections
            // 
            this.lbox_connections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_connections.FormattingEnabled = true;
            this.lbox_connections.Location = new System.Drawing.Point(359, 234);
            this.lbox_connections.Name = "lbox_connections";
            this.lbox_connections.Size = new System.Drawing.Size(457, 238);
            this.lbox_connections.TabIndex = 7;
            // 
            // bt_newsearch
            // 
            this.bt_newsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_newsearch.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_newsearch.Location = new System.Drawing.Point(741, 497);
            this.bt_newsearch.Name = "bt_newsearch";
            this.bt_newsearch.Size = new System.Drawing.Size(75, 23);
            this.bt_newsearch.TabIndex = 9;
            this.bt_newsearch.Text = "Neue Suche";
            this.bt_newsearch.UseVisualStyleBackColor = true;
            // 
            // bt_show
            // 
            this.bt_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_show.Location = new System.Drawing.Point(647, 497);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(75, 23);
            this.bt_show.TabIndex = 8;
            this.bt_show.Text = "Anzeigen";
            this.bt_show.UseVisualStyleBackColor = true;
            // 
            // picbox_switchendstart
            // 
            this.picbox_switchendstart.Image = ((System.Drawing.Image)(resources.GetObject("picbox_switchendstart.Image")));
            this.picbox_switchendstart.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox_switchendstart.InitialImage")));
            this.picbox_switchendstart.Location = new System.Drawing.Point(171, 77);
            this.picbox_switchendstart.Name = "picbox_switchendstart";
            this.picbox_switchendstart.Size = new System.Drawing.Size(25, 25);
            this.picbox_switchendstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_switchendstart.TabIndex = 10;
            this.picbox_switchendstart.TabStop = false;
            // 
            // TrafficSchedules
            // 
            this.AcceptButton = this.bt_show;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_newsearch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.picbox_switchendstart);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.bt_newsearch);
            this.Controls.Add(this.lbox_connections);
            this.Controls.Add(this.lbox_stations);
            this.Controls.Add(this.grpbox_selection);
            this.Controls.Add(this.tb_destination);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.lb_ziel);
            this.Controls.Add(this.lb_start);
            this.Name = "TrafficSchedules";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TrafficSchedules_Load);
            this.grpbox_selection.ResumeLayout(false);
            this.grpbox_selection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_switchendstart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_ziel;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.TextBox tb_destination;
        private System.Windows.Forms.GroupBox grpbox_selection;
        private System.Windows.Forms.RadioButton rb_nearme;
        private System.Windows.Forms.RadioButton rb_departure;
        private System.Windows.Forms.RadioButton rb_connections;
        private System.Windows.Forms.ListBox lbox_stations;
        private System.Windows.Forms.ListBox lbox_connections;
        private System.Windows.Forms.Button bt_newsearch;
        private System.Windows.Forms.Button bt_show;
        private System.Windows.Forms.PictureBox picbox_switchendstart;
    }
}

