namespace MathBrick
{
    partial class QuizPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_subject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_add = new CCWin.SkinControl.SkinButton();
            this.btn_delete = new CCWin.SkinControl.SkinButton();
            this.btn_save = new CCWin.SkinControl.SkinButton();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.label3 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // textBox_subject
            // 
            this.textBox_subject.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_subject.Location = new System.Drawing.Point(282, 35);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(383, 32);
            this.textBox_subject.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Due:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(694, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(67, 133);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(827, 349);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BaseColor = System.Drawing.SystemColors.Control;
            this.btn_add.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add.DownBack = null;
            this.btn_add.DownBaseColor = System.Drawing.SystemColors.Control;
            this.btn_add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(26, 500);
            this.btn_add.MouseBack = null;
            this.btn_add.Name = "btn_add";
            this.btn_add.NormlBack = null;
            this.btn_add.Size = new System.Drawing.Size(81, 33);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BaseColor = System.Drawing.SystemColors.Control;
            this.btn_delete.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_delete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_delete.DownBack = null;
            this.btn_delete.DownBaseColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(142, 500);
            this.btn_delete.MouseBack = null;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.NormlBack = null;
            this.btn_delete.Size = new System.Drawing.Size(81, 33);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
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
            this.btn_save.Location = new System.Drawing.Point(840, 500);
            this.btn_save.MouseBack = null;
            this.btn_save.Name = "btn_save";
            this.btn_save.NormlBack = null;
            this.btn_save.Size = new System.Drawing.Size(81, 33);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.Btn_save_Click);
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
            this.btn_cancel.Location = new System.Drawing.Point(726, 500);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(81, 33);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Questions:";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Question";
            this.columnHeader2.Width = 600;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Answer";
            this.columnHeader3.Width = 163;
            // 
            // QuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_subject);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "QuizPage";
            this.Text = "QuizPage";
            this.Load += new System.EventHandler(this.QuizPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private CCWin.SkinControl.SkinButton btn_add;
        private CCWin.SkinControl.SkinButton btn_delete;
        private CCWin.SkinControl.SkinButton btn_save;
        private CCWin.SkinControl.SkinButton btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}