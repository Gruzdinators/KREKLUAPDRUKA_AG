namespace ApgerbiKautKas_AG
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
            this.KANTE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KANTE
            // 
            this.KANTE.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.KANTE.Location = new System.Drawing.Point(12, 12);
            this.KANTE.Name = "KANTE";
            this.KANTE.Size = new System.Drawing.Size(743, 350);
            this.KANTE.TabIndex = 1;
            this.KANTE.Text = "KANTE";
            this.KANTE.UseVisualStyleBackColor = false;
            this.KANTE.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 374);
            this.Controls.Add(this.KANTE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button KANTE;
    }
}

