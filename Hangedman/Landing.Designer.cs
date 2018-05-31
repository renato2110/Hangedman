namespace Hangedman
{
    partial class Landing
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
            this.landing_title_label = new System.Windows.Forms.Label();
            this.landing_name_textBox = new System.Windows.Forms.TextBox();
            this.landing_name_label = new System.Windows.Forms.Label();
            this.landing_records_button = new System.Windows.Forms.Button();
            this.landing_startGame_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // landing_title_label
            // 
            this.landing_title_label.AutoSize = true;
            this.landing_title_label.Font = new System.Drawing.Font("Source Sans Pro", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landing_title_label.ForeColor = System.Drawing.Color.Coral;
            this.landing_title_label.Location = new System.Drawing.Point(40, 23);
            this.landing_title_label.Name = "landing_title_label";
            this.landing_title_label.Size = new System.Drawing.Size(183, 40);
            this.landing_title_label.TabIndex = 0;
            this.landing_title_label.Text = "Hangedman";
            // 
            // landing_name_textBox
            // 
            this.landing_name_textBox.Location = new System.Drawing.Point(77, 132);
            this.landing_name_textBox.Name = "landing_name_textBox";
            this.landing_name_textBox.Size = new System.Drawing.Size(124, 26);
            this.landing_name_textBox.TabIndex = 1;
            // 
            // landing_name_label
            // 
            this.landing_name_label.AutoSize = true;
            this.landing_name_label.Location = new System.Drawing.Point(73, 97);
            this.landing_name_label.Name = "landing_name_label";
            this.landing_name_label.Size = new System.Drawing.Size(128, 20);
            this.landing_name_label.TabIndex = 2;
            this.landing_name_label.Text = "Insert your name";
            // 
            // landing_records_button
            // 
            this.landing_records_button.Location = new System.Drawing.Point(47, 223);
            this.landing_records_button.Name = "landing_records_button";
            this.landing_records_button.Size = new System.Drawing.Size(89, 57);
            this.landing_records_button.TabIndex = 3;
            this.landing_records_button.Text = "Records";
            this.landing_records_button.UseVisualStyleBackColor = true;
            this.landing_records_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // landing_startGame_button
            // 
            this.landing_startGame_button.Location = new System.Drawing.Point(142, 223);
            this.landing_startGame_button.Name = "landing_startGame_button";
            this.landing_startGame_button.Size = new System.Drawing.Size(81, 57);
            this.landing_startGame_button.TabIndex = 4;
            this.landing_startGame_button.Text = "Start Game";
            this.landing_startGame_button.UseVisualStyleBackColor = true;
            this.landing_startGame_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.landing_title_label);
            this.panel1.Controls.Add(this.landing_startGame_button);
            this.panel1.Controls.Add(this.landing_records_button);
            this.panel1.Controls.Add(this.landing_name_textBox);
            this.panel1.Controls.Add(this.landing_name_label);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 320);
            this.panel1.TabIndex = 5;
            // 
            // landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 341);
            this.Controls.Add(this.panel1);
            this.Name = "landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangedman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label landing_title_label;
        private System.Windows.Forms.TextBox landing_name_textBox;
        private System.Windows.Forms.Label landing_name_label;
        private System.Windows.Forms.Button landing_records_button;
        private System.Windows.Forms.Button landing_startGame_button;
        private System.Windows.Forms.Panel panel1;
    }
}

