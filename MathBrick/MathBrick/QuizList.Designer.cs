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
            this.quizListView.Location = new System.Drawing.Point(1, 65);
            this.quizListView.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.quizListView.Name = "quizListView";
            this.quizListView.Size = new System.Drawing.Size(551, 242);
            this.quizListView.TabIndex = 0;
            this.quizListView.UseCompatibleStateImageBehavior = false;
            // 
            // userNameDescriptionLabel
            // 
            this.userNameDescriptionLabel.AutoSize = true;
            this.userNameDescriptionLabel.Location = new System.Drawing.Point(6, 9);
            this.userNameDescriptionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.userNameDescriptionLabel.Name = "userNameDescriptionLabel";
            this.userNameDescriptionLabel.Size = new System.Drawing.Size(65, 12);
            this.userNameDescriptionLabel.TabIndex = 1;
            this.userNameDescriptionLabel.Text = "User Name:";
            // 
            // levelDescriptionLabel
            // 
            this.levelDescriptionLabel.AutoSize = true;
            this.levelDescriptionLabel.Location = new System.Drawing.Point(6, 40);
            this.levelDescriptionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.levelDescriptionLabel.Name = "levelDescriptionLabel";
            this.levelDescriptionLabel.Size = new System.Drawing.Size(107, 12);
            this.levelDescriptionLabel.TabIndex = 2;
            this.levelDescriptionLabel.Text = "Level of Student:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(63, 9);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 12);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Leonardo DiCaprio";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(85, 40);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(53, 12);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Advanced";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(403, 316);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(68, 37);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(480, 316);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(61, 37);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // QuizList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 368);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.levelDescriptionLabel);
            this.Controls.Add(this.userNameDescriptionLabel);
            this.Controls.Add(this.quizListView);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
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