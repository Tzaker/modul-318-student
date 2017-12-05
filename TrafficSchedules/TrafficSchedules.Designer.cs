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
            this.tb_ziel = new System.Windows.Forms.TextBox();
            this.grpbox_selection = new System.Windows.Forms.GroupBox();
            this.rb_verbindungen = new System.Windows.Forms.RadioButton();
            this.rb_abfahrt = new System.Windows.Forms.RadioButton();
            this.rb_nahe = new System.Windows.Forms.RadioButton();
            this.lbox_haltestellen = new System.Windows.Forms.ListBox();
            this.lbox_verbindungen = new System.Windows.Forms.ListBox();
            this.bt_neuesuche = new System.Windows.Forms.Button();
            this.bt_anzeigen = new System.Windows.Forms.Button();
            this.picbox_wechslestartziel = new System.Windows.Forms.PictureBox();
            this.grpbox_selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_wechslestartziel)).BeginInit();
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
            // 
            // tb_ziel
            // 
            this.tb_ziel.Location = new System.Drawing.Point(94, 117);
            this.tb_ziel.Name = "tb_ziel";
            this.tb_ziel.Size = new System.Drawing.Size(200, 20);
            this.tb_ziel.TabIndex = 2;
            // 
            // grpbox_selection
            // 
            this.grpbox_selection.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grpbox_selection.Controls.Add(this.rb_nahe);
            this.grpbox_selection.Controls.Add(this.rb_abfahrt);
            this.grpbox_selection.Controls.Add(this.rb_verbindungen);
            this.grpbox_selection.Location = new System.Drawing.Point(94, 234);
            this.grpbox_selection.Name = "grpbox_selection";
            this.grpbox_selection.Size = new System.Drawing.Size(200, 120);
            this.grpbox_selection.TabIndex = 4;
            this.grpbox_selection.TabStop = false;
            // 
            // rb_verbindungen
            // 
            this.rb_verbindungen.AutoSize = true;
            this.rb_verbindungen.Checked = true;
            this.rb_verbindungen.Location = new System.Drawing.Point(6, 19);
            this.rb_verbindungen.Name = "rb_verbindungen";
            this.rb_verbindungen.Size = new System.Drawing.Size(91, 17);
            this.rb_verbindungen.TabIndex = 3;
            this.rb_verbindungen.TabStop = true;
            this.rb_verbindungen.Text = "Verbindungen";
            this.rb_verbindungen.UseVisualStyleBackColor = true;
            // 
            // rb_abfahrt
            // 
            this.rb_abfahrt.AutoSize = true;
            this.rb_abfahrt.Location = new System.Drawing.Point(6, 58);
            this.rb_abfahrt.Name = "rb_abfahrt";
            this.rb_abfahrt.Size = new System.Drawing.Size(147, 17);
            this.rb_abfahrt.TabIndex = 4;
            this.rb_abfahrt.Text = "Abfahrtstabelle ab Startort";
            this.rb_abfahrt.UseVisualStyleBackColor = true;
            // 
            // rb_nahe
            // 
            this.rb_nahe.AutoSize = true;
            this.rb_nahe.Location = new System.Drawing.Point(6, 97);
            this.rb_nahe.Name = "rb_nahe";
            this.rb_nahe.Size = new System.Drawing.Size(96, 17);
            this.rb_nahe.TabIndex = 5;
            this.rb_nahe.Text = "in meiner Nähe";
            this.rb_nahe.UseVisualStyleBackColor = true;
            // 
            // lbox_haltestellen
            // 
            this.lbox_haltestellen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_haltestellen.FormattingEnabled = true;
            this.lbox_haltestellen.Location = new System.Drawing.Point(359, 42);
            this.lbox_haltestellen.Name = "lbox_haltestellen";
            this.lbox_haltestellen.Size = new System.Drawing.Size(457, 95);
            this.lbox_haltestellen.TabIndex = 6;
            // 
            // lbox_verbindungen
            // 
            this.lbox_verbindungen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_verbindungen.FormattingEnabled = true;
            this.lbox_verbindungen.Location = new System.Drawing.Point(359, 234);
            this.lbox_verbindungen.Name = "lbox_verbindungen";
            this.lbox_verbindungen.Size = new System.Drawing.Size(457, 238);
            this.lbox_verbindungen.TabIndex = 7;
            // 
            // bt_neuesuche
            // 
            this.bt_neuesuche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_neuesuche.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_neuesuche.Location = new System.Drawing.Point(741, 497);
            this.bt_neuesuche.Name = "bt_neuesuche";
            this.bt_neuesuche.Size = new System.Drawing.Size(75, 23);
            this.bt_neuesuche.TabIndex = 9;
            this.bt_neuesuche.Text = "Neue Suche";
            this.bt_neuesuche.UseVisualStyleBackColor = true;
            // 
            // bt_anzeigen
            // 
            this.bt_anzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_anzeigen.Location = new System.Drawing.Point(647, 497);
            this.bt_anzeigen.Name = "bt_anzeigen";
            this.bt_anzeigen.Size = new System.Drawing.Size(75, 23);
            this.bt_anzeigen.TabIndex = 8;
            this.bt_anzeigen.Text = "Anzeigen";
            this.bt_anzeigen.UseVisualStyleBackColor = true;
            // 
            // picbox_wechslestartziel
            // 
            this.picbox_wechslestartziel.Image = ((System.Drawing.Image)(resources.GetObject("picbox_wechslestartziel.Image")));
            this.picbox_wechslestartziel.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox_wechslestartziel.InitialImage")));
            this.picbox_wechslestartziel.Location = new System.Drawing.Point(171, 77);
            this.picbox_wechslestartziel.Name = "picbox_wechslestartziel";
            this.picbox_wechslestartziel.Size = new System.Drawing.Size(25, 25);
            this.picbox_wechslestartziel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_wechslestartziel.TabIndex = 10;
            this.picbox_wechslestartziel.TabStop = false;
            // 
            // TrafficSchedules
            // 
            this.AcceptButton = this.bt_anzeigen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_neuesuche;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.picbox_wechslestartziel);
            this.Controls.Add(this.bt_anzeigen);
            this.Controls.Add(this.bt_neuesuche);
            this.Controls.Add(this.lbox_verbindungen);
            this.Controls.Add(this.lbox_haltestellen);
            this.Controls.Add(this.grpbox_selection);
            this.Controls.Add(this.tb_ziel);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.lb_ziel);
            this.Controls.Add(this.lb_start);
            this.Name = "TrafficSchedules";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TrafficSchedules_Load);
            this.grpbox_selection.ResumeLayout(false);
            this.grpbox_selection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_wechslestartziel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Label lb_ziel;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.TextBox tb_ziel;
        private System.Windows.Forms.GroupBox grpbox_selection;
        private System.Windows.Forms.RadioButton rb_nahe;
        private System.Windows.Forms.RadioButton rb_abfahrt;
        private System.Windows.Forms.RadioButton rb_verbindungen;
        private System.Windows.Forms.ListBox lbox_haltestellen;
        private System.Windows.Forms.ListBox lbox_verbindungen;
        private System.Windows.Forms.Button bt_neuesuche;
        private System.Windows.Forms.Button bt_anzeigen;
        private System.Windows.Forms.PictureBox picbox_wechslestartziel;
    }
}

