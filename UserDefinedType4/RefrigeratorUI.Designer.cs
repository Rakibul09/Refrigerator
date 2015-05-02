namespace UserDefinedType4
{
    partial class RefrigeratorUI
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
            this.maximumWeightTextBox = new System.Windows.Forms.TextBox();
            this.maximuWeightLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.itemsTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.currentWeightLabel = new System.Windows.Forms.Label();
            this.currentWeightTextBox = new System.Windows.Forms.TextBox();
            this.remainingWeightLabel = new System.Windows.Forms.Label();
            this.remainingWeightTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maximumWeightTextBox
            // 
            this.maximumWeightTextBox.Location = new System.Drawing.Point(230, 30);
            this.maximumWeightTextBox.Name = "maximumWeightTextBox";
            this.maximumWeightTextBox.Size = new System.Drawing.Size(119, 20);
            this.maximumWeightTextBox.TabIndex = 0;
            // 
            // maximuWeightLabel
            // 
            this.maximuWeightLabel.AutoSize = true;
            this.maximuWeightLabel.Location = new System.Drawing.Point(86, 33);
            this.maximuWeightLabel.Name = "maximuWeightLabel";
            this.maximuWeightLabel.Size = new System.Drawing.Size(138, 13);
            this.maximuWeightLabel.TabIndex = 1;
            this.maximuWeightLabel.Text = "Maximum weight it can take";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(378, 28);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Location = new System.Drawing.Point(55, 98);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(63, 13);
            this.itemsLabel.TabIndex = 3;
            this.itemsLabel.Text = "No. of items";
            // 
            // itemsTextBox
            // 
            this.itemsTextBox.Location = new System.Drawing.Point(124, 95);
            this.itemsTextBox.Name = "itemsTextBox";
            this.itemsTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemsTextBox.TabIndex = 4;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(278, 98);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(81, 13);
            this.weightLabel.TabIndex = 5;
            this.weightLabel.Text = "Weight(kg)/unit";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(365, 95);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 6;
            // 
            // currentWeightLabel
            // 
            this.currentWeightLabel.AutoSize = true;
            this.currentWeightLabel.Location = new System.Drawing.Point(37, 177);
            this.currentWeightLabel.Name = "currentWeightLabel";
            this.currentWeightLabel.Size = new System.Drawing.Size(81, 13);
            this.currentWeightLabel.TabIndex = 7;
            this.currentWeightLabel.Text = "Current (weight)";
            // 
            // currentWeightTextBox
            // 
            this.currentWeightTextBox.Location = new System.Drawing.Point(124, 174);
            this.currentWeightTextBox.Name = "currentWeightTextBox";
            this.currentWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.currentWeightTextBox.TabIndex = 8;
            // 
            // remainingWeightLabel
            // 
            this.remainingWeightLabel.AutoSize = true;
            this.remainingWeightLabel.Location = new System.Drawing.Point(262, 177);
            this.remainingWeightLabel.Name = "remainingWeightLabel";
            this.remainingWeightLabel.Size = new System.Drawing.Size(97, 13);
            this.remainingWeightLabel.TabIndex = 9;
            this.remainingWeightLabel.Text = "Remaining(Weight)";
            // 
            // remainingWeightTextBox
            // 
            this.remainingWeightTextBox.Location = new System.Drawing.Point(365, 174);
            this.remainingWeightTextBox.Name = "remainingWeightTextBox";
            this.remainingWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.remainingWeightTextBox.TabIndex = 10;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(436, 134);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // RefrigeratorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 223);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.remainingWeightTextBox);
            this.Controls.Add(this.remainingWeightLabel);
            this.Controls.Add(this.currentWeightTextBox);
            this.Controls.Add(this.currentWeightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.itemsTextBox);
            this.Controls.Add(this.itemsLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.maximuWeightLabel);
            this.Controls.Add(this.maximumWeightTextBox);
            this.Name = "RefrigeratorUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maximumWeightTextBox;
        private System.Windows.Forms.Label maximuWeightLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.TextBox itemsTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label currentWeightLabel;
        private System.Windows.Forms.TextBox currentWeightTextBox;
        private System.Windows.Forms.Label remainingWeightLabel;
        private System.Windows.Forms.TextBox remainingWeightTextBox;
        private System.Windows.Forms.Button enterButton;
    }
}

