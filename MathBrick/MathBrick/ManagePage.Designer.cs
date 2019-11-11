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
            this.confirmButton = new CCWin.SkinControl.SkinButton();
            this.returnButton = new CCWin.SkinControl.SkinButton();
            this.actComboBox = new CCWin.SkinControl.SkinComboBox();
            this.accoutListView = new System.Windows.Forms.ListView();
            this.titleLabel = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.confirmButton);
            this.skinPanel1.Controls.Add(this.returnButton);
            this.skinPanel1.Controls.Add(this.actComboBox);
            this.skinPanel1.Controls.Add(this.accoutListView);
            this.skinPanel1.Controls.Add(this.titleLabel);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(8, 39);
            this.skinPanel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(1208, 703);
            this.skinPanel1.TabIndex = 0;
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.Transparent;
            this.confirmButton.BaseColor = System.Drawing.Color.PeachPuff;
            this.confirmButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.confirmButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.confirmButton.DownBack = null;
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(873, 542);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.confirmButton.MouseBack = null;
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.NormlBack = null;
            this.confirmButton.Radius = 15;
            this.confirmButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.confirmButton.Size = new System.Drawing.Size(221, 78);
            this.confirmButton.TabIndex = 7;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.BaseColor = System.Drawing.Color.PeachPuff;
            this.returnButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.returnButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.returnButton.DownBack = null;
            this.returnButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(622, 542);
            this.returnButton.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.returnButton.MouseBack = null;
            this.returnButton.Name = "returnButton";
            this.returnButton.NormlBack = null;
            this.returnButton.Radius = 15;
            this.returnButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.returnButton.Size = new System.Drawing.Size(221, 78);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // actComboBox
            // 
            this.actComboBox.BaseColor = System.Drawing.Color.PeachPuff;
            this.actComboBox.BorderColor = System.Drawing.Color.Silver;
            this.actComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.actComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actComboBox.FormattingEnabled = true;
            this.actComboBox.Location = new System.Drawing.Point(37, 566);
            this.actComboBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.actComboBox.Name = "actComboBox";
            this.actComboBox.Size = new System.Drawing.Size(346, 37);
            this.actComboBox.TabIndex = 2;
            this.actComboBox.WaterText = "";
            // 
            // accoutListView
            // 
            this.accoutListView.HideSelection = false;
            this.accoutListView.Location = new System.Drawing.Point(37, 78);
            this.accoutListView.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.accoutListView.Name = "accoutListView";
            this.accoutListView.Size = new System.Drawing.Size(1098, 434);
            this.accoutListView.TabIndex = 1;
            this.accoutListView.UseCompatibleStateImageBehavior = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.BorderColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(7, 24);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(245, 49);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Management";
            // 
            // ManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.Silver;
            this.CaptionBackColorTop = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1224, 750);
            this.Controls.Add(this.skinPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
        private CCWin.SkinControl.SkinButton confirmButton;
        private CCWin.SkinControl.SkinButton returnButton;
    }
}