namespace Program_2
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
            this.timeMessageLabel = new System.Windows.Forms.Label();
            this.timeOutputLabel = new System.Windows.Forms.Label();
            this.dateOutputLabel = new System.Windows.Forms.Label();
            this.dateMessageLabel = new System.Windows.Forms.Label();
            this.showDateButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.freshmanButton = new System.Windows.Forms.RadioButton();
            this.sophomoreButton = new System.Windows.Forms.RadioButton();
            this.juniorButton = new System.Windows.Forms.RadioButton();
            this.seniorButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // timeMessageLabel
            // 
            this.timeMessageLabel.AutoSize = true;
            this.timeMessageLabel.Location = new System.Drawing.Point(13, 171);
            this.timeMessageLabel.Name = "timeMessageLabel";
            this.timeMessageLabel.Size = new System.Drawing.Size(176, 13);
            this.timeMessageLabel.TabIndex = 23;
            this.timeMessageLabel.Text = "The earliest time you may register is:";
            // 
            // timeOutputLabel
            // 
            this.timeOutputLabel.AutoSize = true;
            this.timeOutputLabel.Location = new System.Drawing.Point(207, 171);
            this.timeOutputLabel.Name = "timeOutputLabel";
            this.timeOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.timeOutputLabel.TabIndex = 22;
            // 
            // dateOutputLabel
            // 
            this.dateOutputLabel.AutoSize = true;
            this.dateOutputLabel.Location = new System.Drawing.Point(207, 140);
            this.dateOutputLabel.Name = "dateOutputLabel";
            this.dateOutputLabel.Size = new System.Drawing.Size(0, 13);
            this.dateOutputLabel.TabIndex = 21;
            // 
            // dateMessageLabel
            // 
            this.dateMessageLabel.AutoSize = true;
            this.dateMessageLabel.Location = new System.Drawing.Point(11, 140);
            this.dateMessageLabel.Name = "dateMessageLabel";
            this.dateMessageLabel.Size = new System.Drawing.Size(178, 13);
            this.dateMessageLabel.TabIndex = 20;
            this.dateMessageLabel.Text = "The earliest date you may register is:";
            // 
            // showDateButton
            // 
            this.showDateButton.Location = new System.Drawing.Point(243, 80);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(75, 23);
            this.showDateButton.TabIndex = 19;
            this.showDateButton.Text = "Show Date";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(210, 33);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.lastNameTextBox.TabIndex = 18;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(207, 17);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(120, 13);
            this.lastNameLabel.TabIndex = 17;
            this.lastNameLabel.Text = "What is your last name?";
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Location = new System.Drawing.Point(11, 17);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(158, 13);
            this.classLabel.TabIndex = 12;
            this.classLabel.Text = "What class are you currently in?";
            // 
            // freshmanButton
            // 
            this.freshmanButton.AutoSize = true;
            this.freshmanButton.Location = new System.Drawing.Point(24, 102);
            this.freshmanButton.Name = "freshmanButton";
            this.freshmanButton.Size = new System.Drawing.Size(71, 17);
            this.freshmanButton.TabIndex = 16;
            this.freshmanButton.TabStop = true;
            this.freshmanButton.Text = "Freshman";
            this.freshmanButton.UseVisualStyleBackColor = true;
            // 
            // sophomoreButton
            // 
            this.sophomoreButton.AutoSize = true;
            this.sophomoreButton.Location = new System.Drawing.Point(24, 80);
            this.sophomoreButton.Name = "sophomoreButton";
            this.sophomoreButton.Size = new System.Drawing.Size(79, 17);
            this.sophomoreButton.TabIndex = 15;
            this.sophomoreButton.TabStop = true;
            this.sophomoreButton.Text = "Sophomore";
            this.sophomoreButton.UseVisualStyleBackColor = true;
            // 
            // juniorButton
            // 
            this.juniorButton.AutoSize = true;
            this.juniorButton.Location = new System.Drawing.Point(24, 56);
            this.juniorButton.Name = "juniorButton";
            this.juniorButton.Size = new System.Drawing.Size(53, 17);
            this.juniorButton.TabIndex = 14;
            this.juniorButton.TabStop = true;
            this.juniorButton.Text = "Junior";
            this.juniorButton.UseVisualStyleBackColor = true;
            // 
            // seniorButton
            // 
            this.seniorButton.AutoSize = true;
            this.seniorButton.Location = new System.Drawing.Point(24, 33);
            this.seniorButton.Name = "seniorButton";
            this.seniorButton.Size = new System.Drawing.Size(55, 17);
            this.seniorButton.TabIndex = 13;
            this.seniorButton.TabStop = true;
            this.seniorButton.Text = "Senior";
            this.seniorButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.showDateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 202);
            this.Controls.Add(this.timeMessageLabel);
            this.Controls.Add(this.timeOutputLabel);
            this.Controls.Add(this.dateOutputLabel);
            this.Controls.Add(this.dateMessageLabel);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.freshmanButton);
            this.Controls.Add(this.sophomoreButton);
            this.Controls.Add(this.juniorButton);
            this.Controls.Add(this.seniorButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeMessageLabel;
        private System.Windows.Forms.Label timeOutputLabel;
        private System.Windows.Forms.Label dateOutputLabel;
        private System.Windows.Forms.Label dateMessageLabel;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.RadioButton freshmanButton;
        private System.Windows.Forms.RadioButton sophomoreButton;
        private System.Windows.Forms.RadioButton juniorButton;
        private System.Windows.Forms.RadioButton seniorButton;
    }
}

