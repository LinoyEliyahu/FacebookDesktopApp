namespace BasicFacebookFeatures
{
    partial class FormImageGallery
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
            this.selectedPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedPhotoPictureBox
            // 
            this.selectedPhotoPictureBox.Location = new System.Drawing.Point(144, 12);
            this.selectedPhotoPictureBox.Name = "selectedPhotoPictureBox";
            this.selectedPhotoPictureBox.Size = new System.Drawing.Size(603, 465);
            this.selectedPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectedPhotoPictureBox.TabIndex = 0;
            this.selectedPhotoPictureBox.TabStop = false;
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GoBackButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GoBackButton.Location = new System.Drawing.Point(199, 483);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(105, 39);
            this.GoBackButton.TabIndex = 1;
            this.GoBackButton.Text = " << Back";
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NextButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextButton.Location = new System.Drawing.Point(567, 483);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(105, 39);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next >>";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // FormImageGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 546);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.selectedPhotoPictureBox);
            this.Name = "FormImageGallery";
            this.Text = "Gallery";
            ((System.ComponentModel.ISupportInitialize)(this.selectedPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox selectedPhotoPictureBox;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button NextButton;
    }
}