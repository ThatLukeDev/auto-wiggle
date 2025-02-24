namespace AutoWiggle
{
    partial class AutoWiggle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoWiggle));
            this.slider = new System.Windows.Forms.TrackBar();
            this.amount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // slider
            // 
            this.slider.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.slider.Location = new System.Drawing.Point(0, 405);
            this.slider.Maximum = 6;
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(800, 45);
            this.slider.TabIndex = 0;
            this.slider.Value = 3;
            this.slider.Scroll += new System.EventHandler(this.slider_Scroll);
            // 
            // amount
            // 
            this.amount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.Location = new System.Drawing.Point(0, 326);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(800, 79);
            this.amount.TabIndex = 1;
            this.amount.Text = "Timer: 1 min";
            this.amount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // AutoWiggle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.slider);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoWiggle";
            this.Text = "AutoWiggle";
            this.Load += new System.EventHandler(this.AutoWiggle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar slider;
        private System.Windows.Forms.Label amount;
    }
}

