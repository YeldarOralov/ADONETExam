namespace TheWorldsCountries
{
    partial class StartForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.countriesList = new System.Windows.Forms.ListBox();
            this.citiesList = new System.Windows.Forms.ListBox();
            this.streetsList = new System.Windows.Forms.ListBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(701, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(701, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(701, 276);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // countriesList
            // 
            this.countriesList.FormattingEnabled = true;
            this.countriesList.Location = new System.Drawing.Point(27, 62);
            this.countriesList.Name = "countriesList";
            this.countriesList.Size = new System.Drawing.Size(182, 329);
            this.countriesList.TabIndex = 4;
            this.countriesList.SelectedIndexChanged += new System.EventHandler(this.countriesList_SelectedIndexChanged);
            // 
            // citiesList
            // 
            this.citiesList.FormattingEnabled = true;
            this.citiesList.Location = new System.Drawing.Point(229, 62);
            this.citiesList.Name = "citiesList";
            this.citiesList.Size = new System.Drawing.Size(204, 329);
            this.citiesList.TabIndex = 5;
            // 
            // streetsList
            // 
            this.streetsList.FormattingEnabled = true;
            this.streetsList.Location = new System.Drawing.Point(454, 62);
            this.streetsList.Name = "streetsList";
            this.streetsList.Size = new System.Drawing.Size(211, 329);
            this.streetsList.TabIndex = 6;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(27, 28);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(35, 13);
            this.countryLabel.TabIndex = 7;
            this.countryLabel.Text = "label1";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(226, 28);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 13);
            this.cityLabel.TabIndex = 8;
            this.cityLabel.Text = "label2";
            // 
            // streetLable
            // 
            this.streetLable.AutoSize = true;
            this.streetLable.Location = new System.Drawing.Point(454, 28);
            this.streetLable.Name = "streetLable";
            this.streetLable.Size = new System.Drawing.Size(35, 13);
            this.streetLable.TabIndex = 9;
            this.streetLable.Text = "label3";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.streetLable);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.streetsList);
            this.Controls.Add(this.citiesList);
            this.Controls.Add(this.countriesList);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox countriesList;
        private System.Windows.Forms.ListBox citiesList;
        private System.Windows.Forms.ListBox streetsList;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLable;
    }
}