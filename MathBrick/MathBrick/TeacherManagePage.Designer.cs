namespace MathBrick
{
    partial class TeacherManagePage
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.gradeListView = new CCWin.SkinControl.SkinListView();
            this.SuspendLayout();
            // 
            // gradeListView
            // 
            this.gradeListView.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gradeListView.BorderColor = System.Drawing.Color.DimGray;
            this.gradeListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradeListView.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeListView.HeadColor = System.Drawing.Color.LightGray;
            this.gradeListView.HideSelection = false;
            this.gradeListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.gradeListView.Location = new System.Drawing.Point(8, 39);
            this.gradeListView.Name = "gradeListView";
            this.gradeListView.OwnerDraw = true;
            this.gradeListView.SelectedColor = System.Drawing.Color.Gainsboro;
            this.gradeListView.Size = new System.Drawing.Size(1007, 497);
            this.gradeListView.TabIndex = 8;
            this.gradeListView.UseCompatibleStateImageBehavior = false;
            this.gradeListView.View = System.Windows.Forms.View.Details;
            // 
            // TeacherManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.Silver;
            this.CaptionBackColorTop = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1023, 544);
            this.Controls.Add(this.gradeListView);
            this.Name = "TeacherManagePage";
            this.Text = "TeacherManagePage";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinListView gradeListView;
    }
}