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
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.levelLabel = new CCWin.SkinControl.SkinLabel();
            this.nameLabel = new CCWin.SkinControl.SkinLabel();
            this.levelDescriptionLabel = new CCWin.SkinControl.SkinLabel();
            this.userNameDescrictionLabel = new CCWin.SkinControl.SkinLabel();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.cancelButton = new CCWin.SkinControl.SkinButton();
            this.conformButton = new CCWin.SkinControl.SkinButton();
            this.quizListView = new CCWin.SkinControl.SkinListView();
            this.skinPanel1.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.FloralWhite;
            this.skinPanel1.Controls.Add(this.conformButton);
            this.skinPanel1.Controls.Add(this.cancelButton);
            this.skinPanel1.Controls.Add(this.skinPanel2);
            this.skinPanel1.Controls.Add(this.levelLabel);
            this.skinPanel1.Controls.Add(this.nameLabel);
            this.skinPanel1.Controls.Add(this.levelDescriptionLabel);
            this.skinPanel1.Controls.Add(this.userNameDescrictionLabel);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(8, 39);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(536, 382);
            this.skinPanel1.TabIndex = 0;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelLabel.BorderColor = System.Drawing.Color.White;
            this.levelLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(186, 58);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(77, 19);
            this.levelLabel.TabIndex = 3;
            this.levelLabel.Text = "Advanced";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.BorderColor = System.Drawing.Color.White;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(186, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(136, 19);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Leonardo DiCaprio";
            // 
            // levelDescriptionLabel
            // 
            this.levelDescriptionLabel.AutoSize = true;
            this.levelDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelDescriptionLabel.BorderColor = System.Drawing.Color.White;
            this.levelDescriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelDescriptionLabel.Location = new System.Drawing.Point(45, 58);
            this.levelDescriptionLabel.Name = "levelDescriptionLabel";
            this.levelDescriptionLabel.Size = new System.Drawing.Size(127, 19);
            this.levelDescriptionLabel.TabIndex = 1;
            this.levelDescriptionLabel.Text = "Level Of Student:";
            // 
            // userNameDescrictionLabel
            // 
            this.userNameDescrictionLabel.AutoSize = true;
            this.userNameDescrictionLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameDescrictionLabel.BorderColor = System.Drawing.Color.White;
            this.userNameDescrictionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameDescrictionLabel.Location = new System.Drawing.Point(45, 26);
            this.userNameDescrictionLabel.Name = "userNameDescrictionLabel";
            this.userNameDescrictionLabel.Size = new System.Drawing.Size(87, 19);
            this.userNameDescrictionLabel.TabIndex = 0;
            this.userNameDescrictionLabel.Text = "User Name:";
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel2.Controls.Add(this.quizListView);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Location = new System.Drawing.Point(0, 90);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.Size = new System.Drawing.Size(536, 292);
            this.skinPanel2.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BaseColor = System.Drawing.Color.Linen;
            this.cancelButton.BorderColor = System.Drawing.Color.Silver;
            this.cancelButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cancelButton.DownBack = null;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelButton.Location = new System.Drawing.Point(340, 45);
            this.cancelButton.MouseBack = null;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.NormlBack = null;
            this.cancelButton.Radius = 10;
            this.cancelButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.cancelButton.Size = new System.Drawing.Size(68, 32);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // conformButton
            // 
            this.conformButton.BackColor = System.Drawing.Color.Transparent;
            this.conformButton.BaseColor = System.Drawing.Color.Linen;
            this.conformButton.BorderColor = System.Drawing.Color.Silver;
            this.conformButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.conformButton.DownBack = null;
            this.conformButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conformButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.conformButton.Location = new System.Drawing.Point(442, 45);
            this.conformButton.MouseBack = null;
            this.conformButton.Name = "conformButton";
            this.conformButton.NormlBack = null;
            this.conformButton.Radius = 10;
            this.conformButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.conformButton.Size = new System.Drawing.Size(68, 32);
            this.conformButton.TabIndex = 17;
            this.conformButton.Text = "OK";
            this.conformButton.UseVisualStyleBackColor = false;
            this.conformButton.Click += new System.EventHandler(this.conformButton_Click);
            // 
            // quizListView
            // 
            this.quizListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizListView.HideSelection = false;
            this.quizListView.Location = new System.Drawing.Point(0, 0);
            this.quizListView.Name = "quizListView";
            this.quizListView.OwnerDraw = true;
            this.quizListView.Size = new System.Drawing.Size(536, 292);
            this.quizListView.TabIndex = 0;
            this.quizListView.UseCompatibleStateImageBehavior = false;
            this.quizListView.View = System.Windows.Forms.View.Details;
            // 
            // QuizList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.CaptionBackColorBottom = System.Drawing.Color.Silver;
            this.CaptionBackColorTop = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(552, 429);
            this.Controls.Add(this.skinPanel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "QuizList";
            this.Text = "Quiz List";
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel userNameDescrictionLabel;
        private CCWin.SkinControl.SkinLabel levelDescriptionLabel;
        private CCWin.SkinControl.SkinLabel levelLabel;
        private CCWin.SkinControl.SkinLabel nameLabel;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinButton conformButton;
        private CCWin.SkinControl.SkinButton cancelButton;
        private CCWin.SkinControl.SkinListView quizListView;
    }
}