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
            this.dateTimePicker_dueDate = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_add = new CCWin.SkinControl.SkinButton();
            this.btn_delete = new CCWin.SkinControl.SkinButton();
            this.btn_save = new CCWin.SkinControl.SkinButton();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_question = new System.Windows.Forms.Timer(this.components);
            this.btn_edit = new CCWin.SkinControl.SkinButton();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_level = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject:";
            // 
            // textBox_subject
            // 
            this.textBox_subject.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_subject.Location = new System.Drawing.Point(145, 56);
            this.textBox_subject.Name = "textBox_subject";
            this.textBox_subject.Size = new System.Drawing.Size(454, 32);
            this.textBox_subject.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Due:";
            // 
            // dateTimePicker_dueDate
            // 
            this.dateTimePicker_dueDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_dueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dueDate.Location = new System.Drawing.Point(694, 93);
            this.dateTimePicker_dueDate.Name = "dateTimePicker_dueDate";
            this.dateTimePicker_dueDate.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker_dueDate.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(67, 133);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(827, 349);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BaseColor = System.Drawing.Color.Gainsboro;
            this.btn_add.BorderColor = System.Drawing.Color.Silver;
            this.btn_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add.DownBack = null;
            this.btn_add.DownBaseColor = System.Drawing.SystemColors.Control;
            this.btn_add.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(67, 500);
            this.btn_add.MouseBack = null;
            this.btn_add.Name = "btn_add";
            this.btn_add.NormlBack = null;
            this.btn_add.Radius = 10;
            this.btn_add.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_add.Size = new System.Drawing.Size(81, 33);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BaseColor = System.Drawing.Color.Gainsboro;
            this.btn_delete.BorderColor = System.Drawing.Color.Silver;
            this.btn_delete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_delete.DownBack = null;
            this.btn_delete.DownBaseColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(170, 500);
            this.btn_delete.MouseBack = null;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.NormlBack = null;
            this.btn_delete.Radius = 10;
            this.btn_delete.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_delete.Size = new System.Drawing.Size(81, 33);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BaseColor = System.Drawing.Color.Gainsboro;
            this.btn_save.BorderColor = System.Drawing.Color.Silver;
            this.btn_save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_save.DownBack = null;
            this.btn_save.DownBaseColor = System.Drawing.SystemColors.Control;
            this.btn_save.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(813, 500);
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
            this.btn_cancel.BaseColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.BorderColor = System.Drawing.Color.Silver;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.DownBaseColor = System.Drawing.SystemColors.Control;
            this.btn_cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(710, 500);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Radius = 10;
            this.btn_cancel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
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
            // timer_question
            // 
            this.timer_question.Tick += new System.EventHandler(this.Timer_question_Tick);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BaseColor = System.Drawing.Color.Gainsboro;
            this.btn_edit.BorderColor = System.Drawing.Color.Silver;
            this.btn_edit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_edit.DownBack = null;
            this.btn_edit.DownBaseColor = System.Drawing.SystemColors.Control;
            this.btn_edit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(276, 500);
            this.btn_edit.MouseBack = null;
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.NormlBack = null;
            this.btn_edit.Radius = 10;
            this.btn_edit.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btn_edit.Size = new System.Drawing.Size(81, 33);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Level:";
            // 
            // comboBox_level
            // 
            this.comboBox_level.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_level.FormattingEnabled = true;
            this.comboBox_level.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.comboBox_level.Location = new System.Drawing.Point(694, 53);
            this.comboBox_level.Name = "comboBox_level";
            this.comboBox_level.Size = new System.Drawing.Size(200, 32);
            this.comboBox_level.TabIndex = 13;
            // 
            // QuizPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CaptionBackColorBottom = System.Drawing.Color.Silver;
            this.CaptionBackColorTop = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(963, 573);
            this.Controls.Add(this.comboBox_level);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dateTimePicker_dueDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_subject);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "QuizPage";
            this.Text = "QuizPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuizPage_FormClosed);
            this.Load += new System.EventHandler(this.QuizPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_subject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dueDate;
        private System.Windows.Forms.ListView listView1;
        private CCWin.SkinControl.SkinButton btn_add;
        private CCWin.SkinControl.SkinButton btn_delete;
        private CCWin.SkinControl.SkinButton btn_save;
        private CCWin.SkinControl.SkinButton btn_cancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer timer_question;
        private CCWin.SkinControl.SkinButton btn_edit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_level;
    }
}