namespace MathBrick
{
    partial class QuizList
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
            this.quizListView = new System.Windows.Forms.ListView();
            this.userNameDescriptionLabel = new System.Windows.Forms.Label();
            this.levelDescriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quizListView
            // 
            this.quizListView.HideSelection = false;
            this.quizListView.Location = new System.Drawing.Point(3, 130);
            this.quizListView.Name = "quizListView";
            this.quizListView.Size = new System.Drawing.Size(1190, 480);
            this.quizListView.TabIndex = 0;
            this.quizListView.UseCompatibleStateImageBehavior = false;
            // 
            // userNameDescriptionLabel
            // 
            this.userNameDescriptionLabel.AutoSize = true;
            this.userNameDescriptionLabel.Location = new System.Drawing.Point(12, 18);
            this.userNameDescriptionLabel.Name = "userNameDescriptionLabel";
            this.userNameDescriptionLabel.Size = new System.Drawing.Size(119, 24);
            this.userNameDescriptionLabel.TabIndex = 1;
            this.userNameDescriptionLabel.Text = "User Name:";
            // 
            // levelDescriptionLabel
            // 
            this.levelDescriptionLabel.AutoSize = true;
            this.levelDescriptionLabel.Location = new System.Drawing.Point(12, 80);
            this.levelDescriptionLabel.Name = "levelDescriptionLabel";
            this.levelDescriptionLabel.Size = new System.Drawing.Size(166, 24);
            this.levelDescriptionLabel.TabIndex = 2;
            this.levelDescriptionLabel.Text = "Level of Student:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(137, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(185, 24);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Leonardo DiCaprio";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(184, 80);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(100, 24);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Advanced";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(874, 632);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(147, 74);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(1039, 632);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(133, 74);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // QuizList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 736);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.levelDescriptionLabel);
            this.Controls.Add(this.userNameDescriptionLabel);
            this.Controls.Add(this.quizListView);
            this.Name = "QuizList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView quizListView;
        private System.Windows.Forms.Label userNameDescriptionLabel;
        private System.Windows.Forms.Label levelDescriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}