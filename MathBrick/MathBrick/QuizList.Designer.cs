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
            this.components = new System.ComponentModel.Container();
            this.quizListView = new System.Windows.Forms.ListView();
            this.userNameDescriptionLabel = new System.Windows.Forms.Label();
            this.levelDescriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.addButton = new CCWin.SkinControl.SkinButton();
            this.editButton = new CCWin.SkinControl.SkinButton();
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
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BaseColor = System.Drawing.SystemColors.Control;
            this.addButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.addButton.DownBack = null;
            this.addButton.DownBaseColor = System.Drawing.SystemColors.ControlDark;
            this.addButton.Location = new System.Drawing.Point(12, 316);
            this.addButton.MouseBack = null;
            this.addButton.Name = "addButton";
            this.addButton.NormlBack = null;
            this.addButton.Size = new System.Drawing.Size(68, 37);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.BaseColor = System.Drawing.SystemColors.Control;
            this.editButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.editButton.DownBack = null;
            this.editButton.DownBaseColor = System.Drawing.SystemColors.ControlDark;
            this.editButton.Location = new System.Drawing.Point(89, 316);
            this.editButton.MouseBack = null;
            this.editButton.Name = "editButton";
            this.editButton.NormlBack = null;
            this.editButton.Size = new System.Drawing.Size(68, 37);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // QuizList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 368);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
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
        private CCWin.SkinControl.SkinButton addButton;
        private CCWin.SkinControl.SkinButton editButton;
    }
}