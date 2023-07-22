
namespace BasicFacebookFeatures.Command
{
    partial class FormComposer
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
            this.buttonBuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBuilder
            // 
            this.buttonBuilder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBuilder.Location = new System.Drawing.Point(227, 349);
            this.buttonBuilder.Name = "buttonBuilder";
            this.buttonBuilder.Size = new System.Drawing.Size(337, 48);
            this.buttonBuilder.TabIndex = 0;
            this.buttonBuilder.Text = "Show Info";
            this.buttonBuilder.UseVisualStyleBackColor = true;
            this.buttonBuilder.Click += new System.EventHandler(this.buttonBuilder_Click);
            // 
            // FormComposer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBuilder);
            this.Name = "FormComposer";
            this.Text = "FormComposer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBuilder;
    }
}