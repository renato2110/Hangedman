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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            this.landing_name_textBox = new System.Windows.Forms.TextBox();
            this.landing_name_label = new System.Windows.Forms.Label();
            this.landing_records_button = new System.Windows.Forms.Button();
            this.landing_startGame_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // landing_name_textBox
            // 
            this.landing_name_textBox.BackColor = System.Drawing.Color.White;
            this.landing_name_textBox.Font = new System.Drawing.Font("Gentium Basic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landing_name_textBox.Location = new System.Drawing.Point(159, 357);
            this.landing_name_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.landing_name_textBox.Name = "landing_name_textBox";
            this.landing_name_textBox.Size = new System.Drawing.Size(123, 20);
            this.landing_name_textBox.TabIndex = 1;
            this.landing_name_textBox.TextChanged += new System.EventHandler(this.landing_name_textBox_TextChanged);
            // 
            // landing_name_label
            // 
            this.landing_name_label.AutoSize = true;
            this.landing_name_label.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landing_name_label.Location = new System.Drawing.Point(11, 357);
            this.landing_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.landing_name_label.Name = "landing_name_label";
            this.landing_name_label.Size = new System.Drawing.Size(139, 19);
            this.landing_name_label.TabIndex = 2;
            this.landing_name_label.Text = "Nombre del jugador:";
            // 
            // landing_records_button
            // 
            this.landing_records_button.BackColor = System.Drawing.Color.Black;
            this.landing_records_button.Font = new System.Drawing.Font("Gentium Basic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landing_records_button.ForeColor = System.Drawing.SystemColors.Window;
            this.landing_records_button.Location = new System.Drawing.Point(15, 397);
            this.landing_records_button.Margin = new System.Windows.Forms.Padding(2);
            this.landing_records_button.Name = "landing_records_button";
            this.landing_records_button.Size = new System.Drawing.Size(133, 60);
            this.landing_records_button.TabIndex = 3;
            this.landing_records_button.Text = "Mejores Puntajes";
            this.landing_records_button.UseVisualStyleBackColor = false;
            this.landing_records_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // landing_startGame_button
            // 
            this.landing_startGame_button.BackColor = System.Drawing.Color.Black;
            this.landing_startGame_button.Font = new System.Drawing.Font("Gentium Basic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landing_startGame_button.ForeColor = System.Drawing.SystemColors.Window;
            this.landing_startGame_button.Location = new System.Drawing.Point(171, 397);
            this.landing_startGame_button.Margin = new System.Windows.Forms.Padding(2);
            this.landing_startGame_button.Name = "landing_startGame_button";
            this.landing_startGame_button.Size = new System.Drawing.Size(109, 60);
            this.landing_startGame_button.TabIndex = 4;
            this.landing_startGame_button.Text = "Jugar";
            this.landing_startGame_button.UseVisualStyleBackColor = false;
            this.landing_startGame_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.landing_startGame_button);
            this.panel1.Controls.Add(this.landing_name_textBox);
            this.panel1.Controls.Add(this.landing_name_label);
            this.panel1.Controls.Add(this.landing_records_button);
            this.panel1.Location = new System.Drawing.Point(11, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 470);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gentium Basic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 74);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ahorcado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 246);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Landing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 483);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahorcado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox landing_name_textBox;
        private System.Windows.Forms.Label landing_name_label;
        private System.Windows.Forms.Button landing_records_button;
        private System.Windows.Forms.Button landing_startGame_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

