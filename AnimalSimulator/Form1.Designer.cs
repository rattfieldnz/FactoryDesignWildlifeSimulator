namespace AnimalSimulator
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
            this.animalNamesLB = new System.Windows.Forms.ListBox();
            this.northAmericaBTN = new System.Windows.Forms.Button();
            this.australiaBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animalNamesLB
            // 
            this.animalNamesLB.FormattingEnabled = true;
            this.animalNamesLB.Location = new System.Drawing.Point(191, 23);
            this.animalNamesLB.Name = "animalNamesLB";
            this.animalNamesLB.Size = new System.Drawing.Size(520, 446);
            this.animalNamesLB.TabIndex = 1;
            // 
            // northAmericaBTN
            // 
            this.northAmericaBTN.Font = new System.Drawing.Font("Magneto", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.northAmericaBTN.Location = new System.Drawing.Point(191, 475);
            this.northAmericaBTN.Name = "northAmericaBTN";
            this.northAmericaBTN.Size = new System.Drawing.Size(250, 50);
            this.northAmericaBTN.TabIndex = 2;
            this.northAmericaBTN.Text = "North America";
            this.northAmericaBTN.UseVisualStyleBackColor = true;
            this.northAmericaBTN.Click += new System.EventHandler(this.northAmericaBTN_Click);
            // 
            // australiaBTN
            // 
            this.australiaBTN.Font = new System.Drawing.Font("Magneto", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.australiaBTN.Location = new System.Drawing.Point(461, 475);
            this.australiaBTN.Name = "australiaBTN";
            this.australiaBTN.Size = new System.Drawing.Size(250, 50);
            this.australiaBTN.TabIndex = 3;
            this.australiaBTN.Text = "Australia";
            this.australiaBTN.UseVisualStyleBackColor = true;
            this.australiaBTN.Click += new System.EventHandler(this.australiaBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 538);
            this.Controls.Add(this.australiaBTN);
            this.Controls.Add(this.northAmericaBTN);
            this.Controls.Add(this.animalNamesLB);
            this.Name = "Form1";
            this.Text = "Animal Wildlife Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox animalNamesLB;
        private System.Windows.Forms.Button northAmericaBTN;
        private System.Windows.Forms.Button australiaBTN;
    }
}

