namespace MathBrick
{
    partial class Question
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
            this.textBox_question = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.btn_save = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // textBox_question
            // 
            this.textBox_question.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_question.Location = new System.Drawing.Point(121, 35);
            this.textBox_question.Name = "textBox_question";
            this.textBox_question.Size = new System.Drawing.Size(424, 32);
            this.textBox_question.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Answer:";
            // 
            // textBox_answer
            // 
            this.textBox_answer.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_answer.Location = new System.Drawing.Point(121, 104);
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(424, 32);
            this.textBox_answer.TabIndex = 2;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.BaseColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.DownBaseColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(94, 167);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(110, 46);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BaseColor = System.Drawing.SystemColors.Control;
            this.btn_save.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_save.DownBack = null;
            this.btn_save.DownBaseColor = System.Drawing.SystemColors.Control;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(387, 167);
            this.btn_save.MouseBack = null;
            this.btn_save.Name = "btn_save";
            this.btn_save.NormlBack = null;
            this.btn_save.Size = new System.Drawing.Size(110, 46);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
            // 
            // Question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 248);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_question);
            this.MaximizeBox = false;
            this.Name = "Question";
            this.Text = "Question";
            this.Load += new System.EventHandler(this.Question_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_answer;
        private CCWin.SkinControl.SkinButton btn_cancel;
        private CCWin.SkinControl.SkinButton btn_save;
    }
}