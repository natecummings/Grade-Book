namespace Assignment3
{
    partial class scores
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
            this.countsBox = new System.Windows.Forms.GroupBox();
            this.numStudentLabel = new System.Windows.Forms.Label();
            this.numAssignLabel = new System.Windows.Forms.Label();
            this.numStuText = new System.Windows.Forms.TextBox();
            this.numAssignText = new System.Windows.Forms.TextBox();
            this.submitCounts = new System.Windows.Forms.Button();
            this.resetScores = new System.Windows.Forms.Button();
            this.navigateBox = new System.Windows.Forms.GroupBox();
            this.firstStuButton = new System.Windows.Forms.Button();
            this.prevStuButton = new System.Windows.Forms.Button();
            this.nextStuButton = new System.Windows.Forms.Button();
            this.lastStuButton = new System.Windows.Forms.Button();
            this.stuInfoBox = new System.Windows.Forms.GroupBox();
            this.stuNumLabel = new System.Windows.Forms.Label();
            this.stuNameText = new System.Windows.Forms.TextBox();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.stuInfoBox2 = new System.Windows.Forms.GroupBox();
            this.assignNumLabel = new System.Windows.Forms.Label();
            this.assignNumText = new System.Windows.Forms.TextBox();
            this.assignScoreLabel = new System.Windows.Forms.Label();
            this.assignScoreText = new System.Windows.Forms.TextBox();
            this.saveScoreButton = new System.Windows.Forms.Button();
            this.displayScoreButton = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.countsBox.SuspendLayout();
            this.navigateBox.SuspendLayout();
            this.stuInfoBox.SuspendLayout();
            this.stuInfoBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // countsBox
            // 
            this.countsBox.Controls.Add(this.submitCounts);
            this.countsBox.Controls.Add(this.numAssignText);
            this.countsBox.Controls.Add(this.numStuText);
            this.countsBox.Controls.Add(this.numAssignLabel);
            this.countsBox.Controls.Add(this.numStudentLabel);
            this.countsBox.Location = new System.Drawing.Point(21, 23);
            this.countsBox.Name = "countsBox";
            this.countsBox.Size = new System.Drawing.Size(360, 92);
            this.countsBox.TabIndex = 0;
            this.countsBox.TabStop = false;
            this.countsBox.Text = "Counts";
            // 
            // numStudentLabel
            // 
            this.numStudentLabel.AutoSize = true;
            this.numStudentLabel.Location = new System.Drawing.Point(39, 29);
            this.numStudentLabel.Name = "numStudentLabel";
            this.numStudentLabel.Size = new System.Drawing.Size(102, 13);
            this.numStudentLabel.TabIndex = 0;
            this.numStudentLabel.Text = "Number of students:";
            // 
            // numAssignLabel
            // 
            this.numAssignLabel.AutoSize = true;
            this.numAssignLabel.Location = new System.Drawing.Point(21, 56);
            this.numAssignLabel.Name = "numAssignLabel";
            this.numAssignLabel.Size = new System.Drawing.Size(120, 13);
            this.numAssignLabel.TabIndex = 1;
            this.numAssignLabel.Text = "Number of assignments:";
            // 
            // numStuText
            // 
            this.numStuText.Location = new System.Drawing.Point(148, 27);
            this.numStuText.Name = "numStuText";
            this.numStuText.Size = new System.Drawing.Size(71, 20);
            this.numStuText.TabIndex = 2;
            // 
            // numAssignText
            // 
            this.numAssignText.Location = new System.Drawing.Point(148, 54);
            this.numAssignText.Name = "numAssignText";
            this.numAssignText.Size = new System.Drawing.Size(71, 20);
            this.numAssignText.TabIndex = 3;
            // 
            // submitCounts
            // 
            this.submitCounts.Location = new System.Drawing.Point(241, 37);
            this.submitCounts.Name = "submitCounts";
            this.submitCounts.Size = new System.Drawing.Size(93, 23);
            this.submitCounts.TabIndex = 4;
            this.submitCounts.Text = "Submit Counts";
            this.submitCounts.UseVisualStyleBackColor = true;
            this.submitCounts.Click += new System.EventHandler(this.submitCounts_Click);
            // 
            // resetScores
            // 
            this.resetScores.Location = new System.Drawing.Point(421, 52);
            this.resetScores.Name = "resetScores";
            this.resetScores.Size = new System.Drawing.Size(75, 35);
            this.resetScores.TabIndex = 1;
            this.resetScores.Text = "Reset Scores";
            this.resetScores.UseVisualStyleBackColor = true;
            this.resetScores.Click += new System.EventHandler(this.resetScores_Click);
            // 
            // navigateBox
            // 
            this.navigateBox.Controls.Add(this.lastStuButton);
            this.navigateBox.Controls.Add(this.nextStuButton);
            this.navigateBox.Controls.Add(this.prevStuButton);
            this.navigateBox.Controls.Add(this.firstStuButton);
            this.navigateBox.Location = new System.Drawing.Point(21, 122);
            this.navigateBox.Name = "navigateBox";
            this.navigateBox.Size = new System.Drawing.Size(482, 55);
            this.navigateBox.TabIndex = 2;
            this.navigateBox.TabStop = false;
            this.navigateBox.Text = "Navigate";
            // 
            // firstStuButton
            // 
            this.firstStuButton.Location = new System.Drawing.Point(19, 20);
            this.firstStuButton.Name = "firstStuButton";
            this.firstStuButton.Size = new System.Drawing.Size(95, 23);
            this.firstStuButton.TabIndex = 0;
            this.firstStuButton.Text = "<< First Student";
            this.firstStuButton.UseVisualStyleBackColor = true;
            this.firstStuButton.Click += new System.EventHandler(this.firstStuButton_Click);
            // 
            // prevStuButton
            // 
            this.prevStuButton.Location = new System.Drawing.Point(135, 20);
            this.prevStuButton.Name = "prevStuButton";
            this.prevStuButton.Size = new System.Drawing.Size(95, 23);
            this.prevStuButton.TabIndex = 1;
            this.prevStuButton.Text = "< Prev Student";
            this.prevStuButton.UseVisualStyleBackColor = true;
            this.prevStuButton.Click += new System.EventHandler(this.prevStuButton_Click);
            // 
            // nextStuButton
            // 
            this.nextStuButton.Location = new System.Drawing.Point(253, 20);
            this.nextStuButton.Name = "nextStuButton";
            this.nextStuButton.Size = new System.Drawing.Size(95, 23);
            this.nextStuButton.TabIndex = 2;
            this.nextStuButton.Text = "Next Student >";
            this.nextStuButton.UseVisualStyleBackColor = true;
            this.nextStuButton.Click += new System.EventHandler(this.nextStuButton_Click);
            // 
            // lastStuButton
            // 
            this.lastStuButton.Location = new System.Drawing.Point(369, 20);
            this.lastStuButton.Name = "lastStuButton";
            this.lastStuButton.Size = new System.Drawing.Size(95, 23);
            this.lastStuButton.TabIndex = 3;
            this.lastStuButton.Text = "Last Student >>";
            this.lastStuButton.UseVisualStyleBackColor = true;
            this.lastStuButton.Click += new System.EventHandler(this.lastStuButton_Click);
            // 
            // stuInfoBox
            // 
            this.stuInfoBox.Controls.Add(this.saveNameButton);
            this.stuInfoBox.Controls.Add(this.stuNameText);
            this.stuInfoBox.Controls.Add(this.stuNumLabel);
            this.stuInfoBox.Location = new System.Drawing.Point(21, 184);
            this.stuInfoBox.Name = "stuInfoBox";
            this.stuInfoBox.Size = new System.Drawing.Size(482, 53);
            this.stuInfoBox.TabIndex = 3;
            this.stuInfoBox.TabStop = false;
            this.stuInfoBox.Text = "Student Info";
            // 
            // stuNumLabel
            // 
            this.stuNumLabel.AutoSize = true;
            this.stuNumLabel.Location = new System.Drawing.Point(28, 23);
            this.stuNumLabel.Name = "stuNumLabel";
            this.stuNumLabel.Size = new System.Drawing.Size(63, 13);
            this.stuNumLabel.TabIndex = 0;
            this.stuNumLabel.Text = "Student #1:";
            // 
            // stuNameText
            // 
            this.stuNameText.Location = new System.Drawing.Point(189, 20);
            this.stuNameText.Name = "stuNameText";
            this.stuNameText.Size = new System.Drawing.Size(170, 20);
            this.stuNameText.TabIndex = 1;
            // 
            // saveNameButton
            // 
            this.saveNameButton.Location = new System.Drawing.Point(381, 18);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(75, 23);
            this.saveNameButton.TabIndex = 2;
            this.saveNameButton.Text = "Save Name";
            this.saveNameButton.UseVisualStyleBackColor = true;
            this.saveNameButton.Click += new System.EventHandler(this.saveNameButton_Click);
            // 
            // stuInfoBox2
            // 
            this.stuInfoBox2.Controls.Add(this.saveScoreButton);
            this.stuInfoBox2.Controls.Add(this.assignScoreText);
            this.stuInfoBox2.Controls.Add(this.assignScoreLabel);
            this.stuInfoBox2.Controls.Add(this.assignNumText);
            this.stuInfoBox2.Controls.Add(this.assignNumLabel);
            this.stuInfoBox2.Location = new System.Drawing.Point(21, 244);
            this.stuInfoBox2.Name = "stuInfoBox2";
            this.stuInfoBox2.Size = new System.Drawing.Size(482, 77);
            this.stuInfoBox2.TabIndex = 4;
            this.stuInfoBox2.TabStop = false;
            this.stuInfoBox2.Text = "Student Info";
            // 
            // assignNumLabel
            // 
            this.assignNumLabel.AutoSize = true;
            this.assignNumLabel.Location = new System.Drawing.Point(19, 20);
            this.assignNumLabel.Name = "assignNumLabel";
            this.assignNumLabel.Size = new System.Drawing.Size(132, 13);
            this.assignNumLabel.TabIndex = 0;
            this.assignNumLabel.Text = "Enter Assignment Number:";
            // 
            // assignNumText
            // 
            this.assignNumText.Location = new System.Drawing.Point(186, 17);
            this.assignNumText.Name = "assignNumText";
            this.assignNumText.Size = new System.Drawing.Size(84, 20);
            this.assignNumText.TabIndex = 1;
            // 
            // assignScoreLabel
            // 
            this.assignScoreLabel.AutoSize = true;
            this.assignScoreLabel.Location = new System.Drawing.Point(80, 46);
            this.assignScoreLabel.Name = "assignScoreLabel";
            this.assignScoreLabel.Size = new System.Drawing.Size(95, 13);
            this.assignScoreLabel.TabIndex = 2;
            this.assignScoreLabel.Text = "Assignment Score:";
            // 
            // assignScoreText
            // 
            this.assignScoreText.Location = new System.Drawing.Point(186, 43);
            this.assignScoreText.Name = "assignScoreText";
            this.assignScoreText.Size = new System.Drawing.Size(84, 20);
            this.assignScoreText.TabIndex = 3;
            // 
            // saveScoreButton
            // 
            this.saveScoreButton.Location = new System.Drawing.Point(293, 27);
            this.saveScoreButton.Name = "saveScoreButton";
            this.saveScoreButton.Size = new System.Drawing.Size(75, 23);
            this.saveScoreButton.TabIndex = 4;
            this.saveScoreButton.Text = "Save Score";
            this.saveScoreButton.UseVisualStyleBackColor = true;
            this.saveScoreButton.Click += new System.EventHandler(this.saveScoreButton_Click);
            // 
            // displayScoreButton
            // 
            this.displayScoreButton.Location = new System.Drawing.Point(207, 327);
            this.displayScoreButton.Name = "displayScoreButton";
            this.displayScoreButton.Size = new System.Drawing.Size(85, 23);
            this.displayScoreButton.TabIndex = 5;
            this.displayScoreButton.Text = "Display Scores";
            this.displayScoreButton.UseVisualStyleBackColor = true;
            this.displayScoreButton.Click += new System.EventHandler(this.displayScoreButton_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(21, 354);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(482, 118);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            this.richTextBox.WordWrap = false;
            // 
            // scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 474);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.displayScoreButton);
            this.Controls.Add(this.stuInfoBox2);
            this.Controls.Add(this.stuInfoBox);
            this.Controls.Add(this.navigateBox);
            this.Controls.Add(this.resetScores);
            this.Controls.Add(this.countsBox);
            this.Name = "scores";
            this.Text = "Scores";
            this.countsBox.ResumeLayout(false);
            this.countsBox.PerformLayout();
            this.navigateBox.ResumeLayout(false);
            this.stuInfoBox.ResumeLayout(false);
            this.stuInfoBox.PerformLayout();
            this.stuInfoBox2.ResumeLayout(false);
            this.stuInfoBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox countsBox;
        private System.Windows.Forms.Button submitCounts;
        private System.Windows.Forms.TextBox numAssignText;
        private System.Windows.Forms.TextBox numStuText;
        private System.Windows.Forms.Label numAssignLabel;
        private System.Windows.Forms.Label numStudentLabel;
        private System.Windows.Forms.Button resetScores;
        private System.Windows.Forms.GroupBox navigateBox;
        private System.Windows.Forms.Button lastStuButton;
        private System.Windows.Forms.Button nextStuButton;
        private System.Windows.Forms.Button prevStuButton;
        private System.Windows.Forms.Button firstStuButton;
        private System.Windows.Forms.GroupBox stuInfoBox;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.TextBox stuNameText;
        private System.Windows.Forms.Label stuNumLabel;
        private System.Windows.Forms.GroupBox stuInfoBox2;
        private System.Windows.Forms.Button saveScoreButton;
        private System.Windows.Forms.TextBox assignScoreText;
        private System.Windows.Forms.Label assignScoreLabel;
        private System.Windows.Forms.TextBox assignNumText;
        private System.Windows.Forms.Label assignNumLabel;
        private System.Windows.Forms.Button displayScoreButton;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}

