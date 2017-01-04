namespace CreationTools
{
    partial class MapCreate
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
            this.ssButton = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Label();
            this.dropList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smColorUse = new System.Windows.Forms.TextBox();
            this.lgColorUse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.colorVariance = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.runTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ssButton
            // 
            this.ssButton.Location = new System.Drawing.Point(129, 466);
            this.ssButton.Name = "ssButton";
            this.ssButton.Size = new System.Drawing.Size(75, 23);
            this.ssButton.TabIndex = 1;
            this.ssButton.Text = "Start";
            this.ssButton.UseVisualStyleBackColor = true;
            this.ssButton.Click += new System.EventHandler(this.ssButton_Click);
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(17, 9);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(300, 300);
            this.canvas.TabIndex = 2;
            // 
            // dropList
            // 
            this.dropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropList.FormattingEnabled = true;
            this.dropList.Items.AddRange(new object[] {
            "Grass",
            "Water",
            "Building",
            "Mountain",
            "Misc"});
            this.dropList.Location = new System.Drawing.Point(200, 329);
            this.dropList.Name = "dropList";
            this.dropList.Size = new System.Drawing.Size(122, 21);
            this.dropList.TabIndex = 3;
            this.dropList.SelectedIndexChanged += new System.EventHandler(this.dropList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Color:";
            // 
            // smColorUse
            // 
            this.smColorUse.Location = new System.Drawing.Point(200, 356);
            this.smColorUse.Name = "smColorUse";
            this.smColorUse.Size = new System.Drawing.Size(122, 20);
            this.smColorUse.TabIndex = 5;
            // 
            // lgColorUse
            // 
            this.lgColorUse.Location = new System.Drawing.Point(200, 382);
            this.lgColorUse.Name = "lgColorUse";
            this.lgColorUse.Size = new System.Drawing.Size(122, 20);
            this.lgColorUse.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Largest continuous color use (1,000):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Smallest continuous color use (500):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Variance from main color (10):";
            // 
            // colorVariance
            // 
            this.colorVariance.Location = new System.Drawing.Point(200, 408);
            this.colorVariance.Name = "colorVariance";
            this.colorVariance.Size = new System.Drawing.Size(122, 20);
            this.colorVariance.TabIndex = 9;
            // 
            // colorLabel
            // 
            this.colorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLabel.Location = new System.Drawing.Point(65, 331);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(46, 16);
            this.colorLabel.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Run Time/Length (2,000):";
            // 
            // runTime
            // 
            this.runTime.Location = new System.Drawing.Point(200, 434);
            this.runTime.Name = "runTime";
            this.runTime.Size = new System.Drawing.Size(122, 20);
            this.runTime.TabIndex = 12;
            // 
            // MapCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.runTime);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.colorVariance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lgColorUse);
            this.Controls.Add(this.smColorUse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dropList);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.ssButton);
            this.Name = "MapCreate";
            this.Text = "MapCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ssButton;
        private System.Windows.Forms.Label canvas;
        private System.Windows.Forms.ComboBox dropList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox smColorUse;
        private System.Windows.Forms.TextBox lgColorUse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox colorVariance;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox runTime;
    }
}