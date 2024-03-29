﻿using System.Windows.Forms;

namespace MathBrick
{
    partial class ViewGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewGrade));
            this.SubjectLebel = new CCWin.SkinControl.SkinLabel();
            this.LevelLabel = new CCWin.SkinControl.SkinLabel();
            this.GradeListView = new CCWin.SkinControl.SkinListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectLabel = new CCWin.SkinControl.SkinLabel();
            this.LevelLabel2 = new CCWin.SkinControl.SkinLabel();
            this.DueDate = new CCWin.SkinControl.SkinLabel();
            this.DueDateLabel = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // SubjectLebel
            // 
            this.SubjectLebel.AutoSize = true;
            this.SubjectLebel.BackColor = System.Drawing.Color.Honeydew;
            this.SubjectLebel.BorderColor = System.Drawing.Color.White;
            this.SubjectLebel.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLebel.Location = new System.Drawing.Point(28, 56);
            this.SubjectLebel.Name = "SubjectLebel";
            this.SubjectLebel.Size = new System.Drawing.Size(98, 26);
            this.SubjectLebel.TabIndex = 0;
            this.SubjectLebel.Text = "Subject：";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.Color.Honeydew;
            this.LevelLabel.BorderColor = System.Drawing.Color.White;
            this.LevelLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LevelLabel.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(278, 56);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(62, 26);
            this.LevelLabel.TabIndex = 1;
            this.LevelLabel.Text = "Level:";
            // 
            // GradeListView
            // 
            this.GradeListView.BackColor = System.Drawing.Color.Honeydew;
            this.GradeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.GradeListView.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeListView.HeadColor = System.Drawing.Color.WhiteSmoke;
            this.GradeListView.HideSelection = false;
            this.GradeListView.Location = new System.Drawing.Point(1, 105);
            this.GradeListView.Name = "GradeListView";
            this.GradeListView.OwnerDraw = true;
            this.GradeListView.RowBackColor1 = System.Drawing.Color.WhiteSmoke;
            this.GradeListView.RowBackColor2 = System.Drawing.Color.WhiteSmoke;
            this.GradeListView.SelectedColor = System.Drawing.Color.Ivory;
            this.GradeListView.Size = new System.Drawing.Size(758, 415);
            this.GradeListView.TabIndex = 2;
            this.GradeListView.UseCompatibleStateImageBehavior = false;
            this.GradeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "StudentID";
            this.columnHeader2.Width = 360;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Grade";
            this.columnHeader3.Width = 364;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.BackColor = System.Drawing.Color.Honeydew;
            this.SubjectLabel.BorderColor = System.Drawing.Color.White;
            this.SubjectLabel.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(149, 56);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(86, 26);
            this.SubjectLabel.TabIndex = 3;
            this.SubjectLabel.Text = "Midterm";
            // 
            // LevelLabel2
            // 
            this.LevelLabel2.AutoSize = true;
            this.LevelLabel2.BackColor = System.Drawing.Color.Honeydew;
            this.LevelLabel2.BorderColor = System.Drawing.Color.White;
            this.LevelLabel2.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel2.Location = new System.Drawing.Point(373, 56);
            this.LevelLabel2.MaximumSize = new System.Drawing.Size(200, 30);
            this.LevelLabel2.Name = "LevelLabel2";
            this.LevelLabel2.Size = new System.Drawing.Size(96, 26);
            this.LevelLabel2.TabIndex = 4;
            this.LevelLabel2.Text = "Advanced";
            // 
            // DueDate
            // 
            this.DueDate.AutoSize = true;
            this.DueDate.BackColor = System.Drawing.Color.Honeydew;
            this.DueDate.BorderColor = System.Drawing.Color.White;
            this.DueDate.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate.Location = new System.Drawing.Point(517, 56);
            this.DueDate.Name = "DueDate";
            this.DueDate.Size = new System.Drawing.Size(110, 26);
            this.DueDate.TabIndex = 5;
            this.DueDate.Text = "DueDate：";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.BackColor = System.Drawing.Color.Honeydew;
            this.DueDateLabel.BorderColor = System.Drawing.Color.White;
            this.DueDateLabel.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateLabel.Location = new System.Drawing.Point(633, 56);
            this.DueDateLabel.MaximumSize = new System.Drawing.Size(200, 30);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(116, 26);
            this.DueDateLabel.TabIndex = 6;
            this.DueDateLabel.Text = "11/17/2019";
            // 
            // ViewGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.CaptionBackColorBottom = System.Drawing.Color.DarkOliveGreen;
            this.CaptionBackColorTop = System.Drawing.Color.Honeydew;
            this.CaptionFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(760, 520);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.DueDate);
            this.Controls.Add(this.LevelLabel2);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.GradeListView);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.SubjectLebel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewGrade";
            this.Text = "ViewGrade";
            this.Load += new System.EventHandler(this.ViewGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel SubjectLebel;
        private CCWin.SkinControl.SkinLabel LevelLabel;
        private CCWin.SkinControl.SkinListView GradeListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private CCWin.SkinControl.SkinLabel SubjectLabel;
        private CCWin.SkinControl.SkinLabel LevelLabel2;
        private ColumnHeader columnHeader3;
        private CCWin.SkinControl.SkinLabel DueDate;
        private CCWin.SkinControl.SkinLabel DueDateLabel;
    }
}