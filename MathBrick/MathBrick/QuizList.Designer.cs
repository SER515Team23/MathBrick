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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userNameDescriptionLabel = new System.Windows.Forms.Label();
            this.levelDescriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.addButton = new CCWin.SkinControl.SkinButton();
            this.editButton = new CCWin.SkinControl.SkinButton();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.btn_takeQuiz = new CCWin.SkinControl.SkinButton();
            this.timer_quiz = new System.Windows.Forms.Timer(this.components);
            this.btn_delete = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // quizListView
            // 
            this.quizListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.quizListView.FullRowSelect = true;
            this.quizListView.HideSelection = false;
            this.quizListView.Location = new System.Drawing.Point(1, 65);
            this.quizListView.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.quizListView.MultiSelect = false;
            this.quizListView.Name = "quizListView";
            this.quizListView.Size = new System.Drawing.Size(551, 242);
            this.quizListView.TabIndex = 0;
            this.quizListView.UseCompatibleStateImageBehavior = false;
            this.quizListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Due Date";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Subject";
            this.columnHeader3.Width = 270;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Level";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Teacher ID";
            this.columnHeader5.Width = 77;
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
            this.nameLabel.Location = new System.Drawing.Point(73, 9);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 12);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Leonardo DiCaprio";
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Location = new System.Drawing.Point(115, 40);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(53, 12);
            this.levelLabel.TabIndex = 4;
            this.levelLabel.Text = "Advanced";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BaseColor = System.Drawing.SystemColors.Control;
            this.addButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.addButton.DownBack = null;
            this.addButton.DownBaseColor = System.Drawing.SystemColors.ControlDark;
            this.addButton.Location = new System.Drawing.Point(12, 324);
            this.addButton.MouseBack = null;
            this.addButton.Name = "addButton";
            this.addButton.NormlBack = null;
            this.addButton.Size = new System.Drawing.Size(68, 29);
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
            this.editButton.Location = new System.Drawing.Point(100, 324);
            this.editButton.MouseBack = null;
            this.editButton.Name = "editButton";
            this.editButton.NormlBack = null;
            this.editButton.Size = new System.Drawing.Size(68, 29);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BaseColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.DownBaseColor = System.Drawing.SystemColors.ControlDark;
            this.btn_cancel.Location = new System.Drawing.Point(386, 324);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(68, 29);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // btn_takeQuiz
            // 
            this.btn_takeQuiz.BackColor = System.Drawing.Color.Transparent;
            this.btn_takeQuiz.BaseColor = System.Drawing.SystemColors.Control;
            this.btn_takeQuiz.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_takeQuiz.DownBack = null;
            this.btn_takeQuiz.DownBaseColor = System.Drawing.SystemColors.ControlDark;
            this.btn_takeQuiz.Location = new System.Drawing.Point(472, 324);
            this.btn_takeQuiz.MouseBack = null;
            this.btn_takeQuiz.Name = "btn_takeQuiz";
            this.btn_takeQuiz.NormlBack = null;
            this.btn_takeQuiz.Size = new System.Drawing.Size(68, 29);
            this.btn_takeQuiz.TabIndex = 10;
            this.btn_takeQuiz.Text = "Take Quiz";
            this.btn_takeQuiz.UseVisualStyleBackColor = false;
            this.btn_takeQuiz.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // timer_quiz
            // 
            this.timer_quiz.Tick += new System.EventHandler(this.Timer_quiz_Tick);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BaseColor = System.Drawing.SystemColors.Control;
            this.btn_delete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_delete.DownBack = null;
            this.btn_delete.DownBaseColor = System.Drawing.SystemColors.ControlDark;
            this.btn_delete.Location = new System.Drawing.Point(187, 324);
            this.btn_delete.MouseBack = null;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.NormlBack = null;
            this.btn_delete.Size = new System.Drawing.Size(68, 29);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // QuizList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 368);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_takeQuiz);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.levelDescriptionLabel);
            this.Controls.Add(this.userNameDescriptionLabel);
            this.Controls.Add(this.quizListView);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.MaximizeBox = false;
            this.Name = "QuizList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuizList_FormClosed);
            this.Load += new System.EventHandler(this.QuizList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView quizListView;
        private System.Windows.Forms.Label userNameDescriptionLabel;
        private System.Windows.Forms.Label levelDescriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label levelLabel;
        private CCWin.SkinControl.SkinButton addButton;
        private CCWin.SkinControl.SkinButton editButton;
        private CCWin.SkinControl.SkinButton btn_cancel;
        private CCWin.SkinControl.SkinButton btn_takeQuiz;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Timer timer_quiz;
        private CCWin.SkinControl.SkinButton btn_delete;
    }
}