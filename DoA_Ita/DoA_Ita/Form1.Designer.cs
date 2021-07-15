namespace DoA_Ita
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
            this.PTDE = new System.Windows.Forms.Button();
            this.Remastered = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // PTDE
            // 
            this.PTDE.CausesValidation = false;
            this.PTDE.Font = new System.Drawing.Font("Webdings", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTDE.Location = new System.Drawing.Point(12, 103);
            this.PTDE.Name = "PTDE";
            this.PTDE.Size = new System.Drawing.Size(192, 83);
            this.PTDE.TabIndex = 0;
            this.PTDE.Text = "Dark Souls: Prepare To Die Edition";
            this.PTDE.UseVisualStyleBackColor = true;
            this.PTDE.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remastered
            // 
            this.Remastered.CausesValidation = false;
            this.Remastered.Font = new System.Drawing.Font("Webdings", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remastered.Location = new System.Drawing.Point(210, 103);
            this.Remastered.Name = "Remastered";
            this.Remastered.Size = new System.Drawing.Size(192, 83);
            this.Remastered.TabIndex = 1;
            this.Remastered.Text = "Dark Souls: Remastered";
            this.Remastered.UseVisualStyleBackColor = true;
            this.Remastered.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 74);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(386, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 198);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Remastered);
            this.Controls.Add(this.PTDE);
            this.Font = new System.Drawing.Font("Sony Sketch EF", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Figlie della Cenere - V1.2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PTDE;
        private System.Windows.Forms.Button Remastered;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

