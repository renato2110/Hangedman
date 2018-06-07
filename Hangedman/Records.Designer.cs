namespace Hangedman
{
    partial class Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.landing_startGame_button = new System.Windows.Forms.Button();
            this.playersList = new System.Windows.Forms.ListBox();
            this.timesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gentium Basic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jugador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gentium Basic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(217, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 61);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // landing_startGame_button
            // 
            this.landing_startGame_button.BackColor = System.Drawing.Color.Black;
            this.landing_startGame_button.Font = new System.Drawing.Font("Gentium Basic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.landing_startGame_button.ForeColor = System.Drawing.SystemColors.Window;
            this.landing_startGame_button.Location = new System.Drawing.Point(129, 431);
            this.landing_startGame_button.Name = "landing_startGame_button";
            this.landing_startGame_button.Size = new System.Drawing.Size(164, 92);
            this.landing_startGame_button.TabIndex = 5;
            this.landing_startGame_button.Text = "Volver";
            this.landing_startGame_button.UseVisualStyleBackColor = false;
            this.landing_startGame_button.Click += new System.EventHandler(this.landing_startGame_button_Click);
            // 
            // playersList
            // 
            this.playersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playersList.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersList.FormattingEnabled = true;
            this.playersList.ItemHeight = 28;
            this.playersList.Location = new System.Drawing.Point(57, 102);
            this.playersList.Name = "playersList";
            this.playersList.Size = new System.Drawing.Size(236, 308);
            this.playersList.TabIndex = 6;
            // 
            // timesList
            // 
            this.timesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timesList.Font = new System.Drawing.Font("Gentium Basic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesList.FormattingEnabled = true;
            this.timesList.ItemHeight = 28;
            this.timesList.Location = new System.Drawing.Point(288, 102);
            this.timesList.Name = "timesList";
            this.timesList.Size = new System.Drawing.Size(125, 308);
            this.timesList.TabIndex = 7;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 537);
            this.Controls.Add(this.timesList);
            this.Controls.Add(this.playersList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.landing_startGame_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mejores Tiempos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Records_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button landing_startGame_button;
        private System.Windows.Forms.ListBox playersList;
        private System.Windows.Forms.ListBox timesList;
    }
}