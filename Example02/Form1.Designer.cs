namespace Example02
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
            this.ResetSeatsButton = new System.Windows.Forms.Button();
            this.ChooseSeatsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResetSeatsButton
            // 
            this.ResetSeatsButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetSeatsButton.Location = new System.Drawing.Point(1122, 200);
            this.ResetSeatsButton.Name = "ResetSeatsButton";
            this.ResetSeatsButton.Size = new System.Drawing.Size(207, 60);
            this.ResetSeatsButton.TabIndex = 0;
            this.ResetSeatsButton.Text = "ResetSeats";
            this.ResetSeatsButton.UseVisualStyleBackColor = true;
            this.ResetSeatsButton.Click += new System.EventHandler(this.ResetSeatsButton_Click);
            // 
            // ChooseSeatsButton
            // 
            this.ChooseSeatsButton.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseSeatsButton.Location = new System.Drawing.Point(1122, 12);
            this.ChooseSeatsButton.Name = "ChooseSeatsButton";
            this.ChooseSeatsButton.Size = new System.Drawing.Size(207, 60);
            this.ChooseSeatsButton.TabIndex = 0;
            this.ChooseSeatsButton.Text = "ChooseSeats";
            this.ChooseSeatsButton.UseVisualStyleBackColor = true;
            this.ChooseSeatsButton.Click += new System.EventHandler(this.ChooseSeatsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 272);
            this.Controls.Add(this.ChooseSeatsButton);
            this.Controls.Add(this.ResetSeatsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ResetSeatsButton;
        private System.Windows.Forms.Button ChooseSeatsButton;
    }
}

