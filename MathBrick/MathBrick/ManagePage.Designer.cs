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
            this.actComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.accountListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actComboBox
            // 
            this.actComboBox.FormattingEnabled = true;
            this.actComboBox.Location = new System.Drawing.Point(10, 326);
            this.actComboBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.actComboBox.Name = "actComboBox";
            this.actComboBox.Size = new System.Drawing.Size(279, 20);
            this.actComboBox.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleLabel.Location = new System.Drawing.Point(13, 14);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(171, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Management";
            // 
            // accountListView
            // 
            this.accountListView.HideSelection = false;
            this.accountListView.Location = new System.Drawing.Point(17, 52);
            this.accountListView.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.accountListView.Name = "accountListView";
            this.accountListView.Size = new System.Drawing.Size(530, 240);
            this.accountListView.TabIndex = 2;
            this.accountListView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 306);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(311, 306);
            this.returnButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(107, 54);
            this.returnButton.TabIndex = 4;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // ManagePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 372);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accountListView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.actComboBox);
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "ManagePage";
            this.Text = "Administrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox actComboBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListView accountListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button returnButton;
    }
}