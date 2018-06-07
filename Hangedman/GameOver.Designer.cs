namespace Hangedman
{
    partial class GameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOver));
            this.resetButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Black;
            this.resetButton.Font = new System.Drawing.Font("Gentium Basic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.Window;
            this.resetButton.Location = new System.Drawing.Point(320, 156);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(169, 91);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Jugar de nuevo";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // outButton
            // 
            this.outButton.BackColor = System.Drawing.Color.Black;
            this.outButton.Font = new System.Drawing.Font("Gentium Basic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outButton.ForeColor = System.Drawing.SystemColors.Window;
            this.outButton.Location = new System.Drawing.Point(119, 156);
            this.outButton.Margin = new System.Windows.Forms.Padding(2);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(142, 91);
            this.outButton.TabIndex = 5;
            this.outButton.Text = "Salir";
            this.outButton.UseVisualStyleBackColor = false;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Gentium Basic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.ForeColor = System.Drawing.Color.Red;
            this.message.Location = new System.Drawing.Point(60, 47);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 32);
            this.message.TabIndex = 0;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(578, 308);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partida Terminada";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameOver_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.Label message;
    }
}