namespace MathBrick
{
    partial class ManagePage
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
            this.titleLabel = new CCWin.SkinControl.SkinLabel();
            this.accoutListView = new System.Windows.Forms.ListView();
            this.actComboBox = new CCWin.SkinControl.SkinComboBox();
            this.returnButton = new CCWin.SkinControl.SkinButton();
            this.conformButton = new CCWin.SkinControl.SkinButton();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.conformButton);
            this.skinPanel1.Controls.Add(this.returnButton);
            this.skinPanel1.Controls.Add(this.actComboBox);
            this.skinPanel1.Controls.Add(this.accoutListView);
            this.skinPanel1.Controls.Add(this.titleLabel);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(8, 39);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(549, 328);
            this.skinPanel1.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.BorderColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(3, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(121, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Management";
            // 
            // accoutListView
            // 
            this.accoutListView.HideSelection = false;
            this.accoutListView.Location = new System.Drawing.Point(17, 39);
            this.accoutListView.Name = "accoutListView";
            this.accoutListView.Size = new System.Drawing.Size(509, 219);
            this.accoutListView.TabIndex = 1;
            this.accoutListView.UseCompatibleStateImageBehavior = false;
            // 
            // actComboBox
            // 
            this.actComboBox.BaseColor = System.Drawing.Color.PeachPuff;
            this.actComboBox.BorderColor = System.Drawing.Color.Silver;
            this.actComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.actComboBox.FormattingEnabled = true;
            this.actComboBox.Location = new System.Drawing.Point(17, 283);
            this.actComboBox.Name = "actComboBox";
            this.actComboBox.Size = new System.Drawing.Size(162, 22);
            this.actComboBox.TabIndex = 2;
            this.actComboBox.WaterText = "";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.BaseColor = System.Drawing.Color.PeachPuff;
            this.returnButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.returnButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.returnButton.DownBack = null;
            this.returnButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(287, 271);
            this.returnButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.returnButton.MouseBack = null;
            this.returnButton.Name = "returnButton";
            this.returnButton.NormlBack = null;
            this.returnButton.Radius = 15;
            this.returnButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.returnButton.Size = new System.Drawing.Size(102, 39);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Retutn";
            this.returnButton.UseVisualStyleBackColor = false;
            // 
            // conformButton
            // 
            this.conformButton.BackColor = System.Drawing.Color.Transparent;
            this.conformButton.BaseColor = System.Drawing.Color.PeachPuff;
            this.conformButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.conformButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.conformButton.DownBack = null;
            this.conformButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conformButton.Location = new System.Drawing.Point(403, 271);
            this.conformButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.conformButton.MouseBack = null;
            this.conformButton.Name = "conformButton";
            this.conformButton.NormlBack = null;
            this.conformButton.Radius = 15;
            this.conformButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.conformButton.Size = new System.Drawing.Size(102, 39);
            this.conformButton.TabIndex = 7;
            this.conformButton.Text = "Conform";
            this.conformButton.UseVisualStyleBackColor = false;
            // 
            // ManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.Silver;
            this.CaptionBackColorTop = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(565, 375);
            this.Controls.Add(this.skinPanel1);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "ManagePage";
            this.Text = "Administrator";
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinComboBox actComboBox;
        private System.Windows.Forms.ListView accoutListView;
        private CCWin.SkinControl.SkinLabel titleLabel;
        private CCWin.SkinControl.SkinButton conformButton;
        private CCWin.SkinControl.SkinButton returnButton;
    }
}