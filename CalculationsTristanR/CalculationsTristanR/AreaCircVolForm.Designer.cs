namespace CalculationsTristanR
{
    partial class AreaCircVolForm
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
            this.btnPer = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.lblPer = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPer
            // 
            this.btnPer.Location = new System.Drawing.Point(12, 2);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(148, 58);
            this.btnPer.TabIndex = 6;
            this.btnPer.Text = "Calculate the perimeter of a rectangle with a length of 10cm and a width of 9cm";
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(12, 66);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(148, 52);
            this.btnArea.TabIndex = 1;
            this.btnArea.Text = "Calculate the area of a circle with radius 10cm";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Location = new System.Drawing.Point(12, 124);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(148, 46);
            this.btnVolume.TabIndex = 2;
            this.btnVolume.Text = "Calculate the volume of a sphere with radius 10cm";
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Location = new System.Drawing.Point(198, 33);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(35, 13);
            this.lblPer.TabIndex = 3;
            this.lblPer.Text = "label1";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(198, 86);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "label2";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(198, 141);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(35, 13);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "label3";
            // 
            // AreaCircVolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnPer);
            this.Name = "AreaCircVolForm";
            this.Text = "PerCircVol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblVolume;
    }
}

