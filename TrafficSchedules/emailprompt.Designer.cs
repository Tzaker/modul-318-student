namespace TrafficSchedules
{
    partial class emailprompt
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
            this.tb_emailaddress = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancelemail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_emailaddress
            // 
            this.tb_emailaddress.Location = new System.Drawing.Point(22, 22);
            this.tb_emailaddress.Name = "tb_emailaddress";
            this.tb_emailaddress.Size = new System.Drawing.Size(189, 20);
            this.tb_emailaddress.TabIndex = 0;
            // 
            // bt_ok
            // 
            this.bt_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_ok.Location = new System.Drawing.Point(22, 61);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(109, 23);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "Email Senden";
            this.bt_ok.UseVisualStyleBackColor = true;
            // 
            // bt_cancelemail
            // 
            this.bt_cancelemail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancelemail.Location = new System.Drawing.Point(137, 60);
            this.bt_cancelemail.Name = "bt_cancelemail";
            this.bt_cancelemail.Size = new System.Drawing.Size(74, 23);
            this.bt_cancelemail.TabIndex = 2;
            this.bt_cancelemail.Text = "Abbrechen";
            this.bt_cancelemail.UseVisualStyleBackColor = true;
            // 
            // emailprompt
            // 
            this.AcceptButton = this.bt_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancelemail;
            this.ClientSize = new System.Drawing.Size(233, 95);
            this.Controls.Add(this.bt_cancelemail);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_emailaddress);
            this.Name = "emailprompt";
            this.Text = "emailprompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancelemail;
        public System.Windows.Forms.TextBox tb_emailaddress;
    }
}