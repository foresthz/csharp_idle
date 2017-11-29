namespace multi_forms
{
    partial class PopForm
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
            this.pbox_shanben = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_shanben)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_shanben
            // 
            this.pbox_shanben.Image = global::multi_forms.Properties.Resources.shanben;
            this.pbox_shanben.Location = new System.Drawing.Point(432, 12);
            this.pbox_shanben.Name = "pbox_shanben";
            this.pbox_shanben.Size = new System.Drawing.Size(190, 299);
            this.pbox_shanben.TabIndex = 0;
            this.pbox_shanben.TabStop = false;
            // 
            // PopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 344);
            this.Controls.Add(this.pbox_shanben);
            this.Name = "PopForm";
            this.Text = "PopForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_shanben)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_shanben;
    }
}