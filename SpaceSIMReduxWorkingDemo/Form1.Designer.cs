namespace SpaceSIMReduxWorkingDemo
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
            this.yardrat = new System.Windows.Forms.Button();
            this.buttonEarth = new System.Windows.Forms.Button();
            this.listBoxEarth = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOnePiece = new System.Windows.Forms.Button();
            this.listBoxLandOfWater = new System.Windows.Forms.ListBox();
            this.yardratBoxListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yardrat
            // 
            this.yardrat.Location = new System.Drawing.Point(82, 29);
            this.yardrat.Name = "yardrat";
            this.yardrat.Size = new System.Drawing.Size(75, 23);
            this.yardrat.TabIndex = 0;
            this.yardrat.Text = "Yardrat";
            this.yardrat.UseVisualStyleBackColor = true;
            this.yardrat.Click += new System.EventHandler(this.yardrat_Click);
            // 
            // buttonEarth
            // 
            this.buttonEarth.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEarth.FlatAppearance.BorderSize = 4;
            this.buttonEarth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonEarth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEarth.Location = new System.Drawing.Point(326, 66);
            this.buttonEarth.Name = "buttonEarth";
            this.buttonEarth.Size = new System.Drawing.Size(75, 23);
            this.buttonEarth.TabIndex = 2;
            this.buttonEarth.Text = "Earth";
            this.buttonEarth.UseVisualStyleBackColor = true;
            this.buttonEarth.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxEarth
            // 
            this.listBoxEarth.FormattingEnabled = true;
            this.listBoxEarth.Location = new System.Drawing.Point(309, 95);
            this.listBoxEarth.Name = "listBoxEarth";
            this.listBoxEarth.Size = new System.Drawing.Size(120, 95);
            this.listBoxEarth.TabIndex = 3;
            this.listBoxEarth.SelectedIndexChanged += new System.EventHandler(this.listBoxEarth_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(180, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 103);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOnePiece
            // 
            this.buttonOnePiece.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOnePiece.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonOnePiece.FlatAppearance.BorderSize = 10;
            this.buttonOnePiece.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonOnePiece.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonOnePiece.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOnePiece.Location = new System.Drawing.Point(12, 215);
            this.buttonOnePiece.Name = "buttonOnePiece";
            this.buttonOnePiece.Size = new System.Drawing.Size(86, 23);
            this.buttonOnePiece.TabIndex = 1;
            this.buttonOnePiece.Text = "LandofWater";
            this.buttonOnePiece.UseVisualStyleBackColor = false;
            this.buttonOnePiece.Click += new System.EventHandler(this.buttonOnePiece_Click);
            // 
            // listBoxLandOfWater
            // 
            this.listBoxLandOfWater.FormattingEnabled = true;
            this.listBoxLandOfWater.Location = new System.Drawing.Point(104, 234);
            this.listBoxLandOfWater.Name = "listBoxLandOfWater";
            this.listBoxLandOfWater.Size = new System.Drawing.Size(120, 95);
            this.listBoxLandOfWater.TabIndex = 5;
            this.listBoxLandOfWater.SelectedIndexChanged += new System.EventHandler(this.listBoxLandOfWater_SelectedIndexChanged);
            // 
            // yardratBoxListBox
            // 
            this.yardratBoxListBox.FormattingEnabled = true;
            this.yardratBoxListBox.Location = new System.Drawing.Point(54, 58);
            this.yardratBoxListBox.Name = "yardratBoxListBox";
            this.yardratBoxListBox.Size = new System.Drawing.Size(120, 95);
            this.yardratBoxListBox.TabIndex = 4;
            this.yardratBoxListBox.SelectedIndexChanged += new System.EventHandler(this.yardratBoxListBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 356);
            this.textBox1.MinimumSize = new System.Drawing.Size(100, 50);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(120, 95);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 482);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.yardratBoxListBox);
            this.Controls.Add(this.listBoxLandOfWater);
            this.Controls.Add(this.buttonOnePiece);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxEarth);
            this.Controls.Add(this.buttonEarth);
            this.Controls.Add(this.yardrat);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //UI COMPONENTS

        //FIRST CARD COMPONENTS

        //Yardrat Plannet One Objects
        private System.Windows.Forms.Button yardrat;//BUTTON THAT WHEN CLICKED WILL REVEAL THE YARDRAT PLANAT Image in the PictureBox and will also populate the listbox next to it with relevant infomration form the resources Folder about the planet.


        //OnePiece, Land of Water with nothing but a stare Planet Two Objects
        private System.Windows.Forms.Button buttonOnePiece;//Same as the Yardrat button but for a different planet, the button text and the listbox information will be different, but the functionality will be the same as the Yardrat button.
        private System.Windows.Forms.ListBox listBoxEarth;

        private System.Windows.Forms.Button buttonEarth;//Same as the Yardrat button but for a different planet, the button text and the listbox information will be different, but the functionality will be the same as the Yardrat button.

        private System.Windows.Forms.ListBox listBoxLandOfWater;

        private System.Windows.Forms.PictureBox pictureBox1;//This picturebox will be used to display the image for the planet that is currently selected, it will be populated with the relevant image for the planet from the resources folder, and it will be cleared when another button is clicked, so that only one planet's information is shown at a time.
        private System.Windows.Forms.ListBox yardratBoxListBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

