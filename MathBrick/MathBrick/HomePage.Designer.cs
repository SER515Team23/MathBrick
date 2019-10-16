namespace MathBrick
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.NumberOperator = new CCWin.SkinControl.SkinTabControl();
            this.NumberBox = new CCWin.SkinControl.SkinTabPage();
            this.skinButton10 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton9 = new CCWin.SkinControl.SkinButton();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinButton8 = new CCWin.SkinControl.SkinButton();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinButton7 = new CCWin.SkinControl.SkinButton();
            this.skinButton6 = new CCWin.SkinControl.SkinButton();
            this.skinButton5 = new CCWin.SkinControl.SkinButton();
            this.OperatorBox = new CCWin.SkinControl.SkinTabPage();
            this.skinButton17 = new CCWin.SkinControl.SkinButton();
            this.skinButton16 = new CCWin.SkinControl.SkinButton();
            this.skinButton15 = new CCWin.SkinControl.SkinButton();
            this.skinButton14 = new CCWin.SkinControl.SkinButton();
            this.skinButton13 = new CCWin.SkinControl.SkinButton();
            this.skinButton12 = new CCWin.SkinControl.SkinButton();
            this.skinButton11 = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.Resut_Listbox = new CCWin.SkinControl.SkinListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.NumberOperator.SuspendLayout();
            this.NumberBox.SuspendLayout();
            this.OperatorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 523);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 122);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NumberOperator);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 401);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.skinGroupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(665, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 401);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Resut_Listbox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(200, 423);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(465, 100);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.skinGroupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(200, 122);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(465, 301);
            this.panel6.TabIndex = 4;
            // 
            // NumberOperator
            // 
            this.NumberOperator.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.NumberOperator.ArrowBaseColor = System.Drawing.Color.Gainsboro;
            this.NumberOperator.ArrowBorderColor = System.Drawing.Color.Silver;
            this.NumberOperator.ArrowColor = System.Drawing.Color.DarkGray;
            this.NumberOperator.BackColor = System.Drawing.Color.Silver;
            this.NumberOperator.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.NumberOperator.Controls.Add(this.NumberBox);
            this.NumberOperator.Controls.Add(this.OperatorBox);
            this.NumberOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberOperator.HeadBack = null;
            this.NumberOperator.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.NumberOperator.ItemSize = new System.Drawing.Size(70, 36);
            this.NumberOperator.Location = new System.Drawing.Point(0, 0);
            this.NumberOperator.Name = "NumberOperator";
            this.NumberOperator.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("NumberOperator.PageArrowDown")));
            this.NumberOperator.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("NumberOperator.PageArrowHover")));
            this.NumberOperator.PageBaseColor = System.Drawing.Color.LightGray;
            this.NumberOperator.PageBorderColor = System.Drawing.Color.Gainsboro;
            this.NumberOperator.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("NumberOperator.PageCloseHover")));
            this.NumberOperator.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("NumberOperator.PageCloseNormal")));
            this.NumberOperator.PageDown = ((System.Drawing.Image)(resources.GetObject("NumberOperator.PageDown")));
            this.NumberOperator.PageHover = ((System.Drawing.Image)(resources.GetObject("NumberOperator.PageHover")));
            this.NumberOperator.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.NumberOperator.PageNorml = null;
            this.NumberOperator.SelectedIndex = 1;
            this.NumberOperator.Size = new System.Drawing.Size(200, 401);
            this.NumberOperator.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.NumberOperator.TabIndex = 12;
            // 
            // NumberBox
            // 
            this.NumberBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumberBox.Controls.Add(this.skinButton10);
            this.NumberBox.Controls.Add(this.skinButton1);
            this.NumberBox.Controls.Add(this.skinButton2);
            this.NumberBox.Controls.Add(this.skinButton9);
            this.NumberBox.Controls.Add(this.skinButton3);
            this.NumberBox.Controls.Add(this.skinButton8);
            this.NumberBox.Controls.Add(this.skinButton4);
            this.NumberBox.Controls.Add(this.skinButton7);
            this.NumberBox.Controls.Add(this.skinButton6);
            this.NumberBox.Controls.Add(this.skinButton5);
            this.NumberBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberBox.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox.Location = new System.Drawing.Point(0, 36);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(200, 367);
            this.NumberBox.TabIndex = 0;
            this.NumberBox.TabItemImage = null;
            this.NumberBox.Text = "Numbers";
            // 
            // skinButton10
            // 
            this.skinButton10.BackColor = System.Drawing.Color.Transparent;
            this.skinButton10.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton10.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton10.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton10.DownBack = null;
            this.skinButton10.Location = new System.Drawing.Point(121, 306);
            this.skinButton10.MouseBack = null;
            this.skinButton10.Name = "skinButton10";
            this.skinButton10.NormlBack = null;
            this.skinButton10.Radius = 20;
            this.skinButton10.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton10.Size = new System.Drawing.Size(50, 53);
            this.skinButton10.TabIndex = 10;
            this.skinButton10.Text = "10";
            this.skinButton10.UseVisualStyleBackColor = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton1.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(23, 15);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 20;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(50, 53);
            this.skinButton1.TabIndex = 0;
            this.skinButton1.Text = "1";
            this.skinButton1.UseVisualStyleBackColor = false;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton2.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.Location = new System.Drawing.Point(121, 15);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Radius = 20;
            this.skinButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton2.Size = new System.Drawing.Size(50, 53);
            this.skinButton2.TabIndex = 1;
            this.skinButton2.Text = "2";
            this.skinButton2.UseVisualStyleBackColor = false;
            // 
            // skinButton9
            // 
            this.skinButton9.BackColor = System.Drawing.Color.Transparent;
            this.skinButton9.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton9.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton9.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton9.DownBack = null;
            this.skinButton9.Location = new System.Drawing.Point(23, 306);
            this.skinButton9.MouseBack = null;
            this.skinButton9.Name = "skinButton9";
            this.skinButton9.NormlBack = null;
            this.skinButton9.Radius = 20;
            this.skinButton9.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton9.Size = new System.Drawing.Size(50, 53);
            this.skinButton9.TabIndex = 8;
            this.skinButton9.Text = "9";
            this.skinButton9.UseVisualStyleBackColor = false;
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton3.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.Location = new System.Drawing.Point(23, 90);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Radius = 20;
            this.skinButton3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton3.Size = new System.Drawing.Size(50, 53);
            this.skinButton3.TabIndex = 2;
            this.skinButton3.Text = "3";
            this.skinButton3.UseVisualStyleBackColor = false;
            // 
            // skinButton8
            // 
            this.skinButton8.BackColor = System.Drawing.Color.Transparent;
            this.skinButton8.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton8.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton8.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton8.DownBack = null;
            this.skinButton8.Location = new System.Drawing.Point(121, 230);
            this.skinButton8.MouseBack = null;
            this.skinButton8.Name = "skinButton8";
            this.skinButton8.NormlBack = null;
            this.skinButton8.Radius = 20;
            this.skinButton8.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton8.Size = new System.Drawing.Size(50, 53);
            this.skinButton8.TabIndex = 7;
            this.skinButton8.Text = "8";
            this.skinButton8.UseVisualStyleBackColor = false;
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton4.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton4.DownBack = null;
            this.skinButton4.Location = new System.Drawing.Point(121, 90);
            this.skinButton4.MouseBack = null;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Radius = 20;
            this.skinButton4.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton4.Size = new System.Drawing.Size(50, 53);
            this.skinButton4.TabIndex = 3;
            this.skinButton4.Text = "4";
            this.skinButton4.UseVisualStyleBackColor = false;
            // 
            // skinButton7
            // 
            this.skinButton7.BackColor = System.Drawing.Color.Transparent;
            this.skinButton7.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton7.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton7.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton7.DownBack = null;
            this.skinButton7.Location = new System.Drawing.Point(23, 230);
            this.skinButton7.MouseBack = null;
            this.skinButton7.Name = "skinButton7";
            this.skinButton7.NormlBack = null;
            this.skinButton7.Radius = 20;
            this.skinButton7.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton7.Size = new System.Drawing.Size(50, 53);
            this.skinButton7.TabIndex = 6;
            this.skinButton7.Text = "7";
            this.skinButton7.UseVisualStyleBackColor = false;
            // 
            // skinButton6
            // 
            this.skinButton6.BackColor = System.Drawing.Color.Transparent;
            this.skinButton6.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton6.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton6.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton6.DownBack = null;
            this.skinButton6.Location = new System.Drawing.Point(121, 161);
            this.skinButton6.MouseBack = null;
            this.skinButton6.Name = "skinButton6";
            this.skinButton6.NormlBack = null;
            this.skinButton6.Radius = 20;
            this.skinButton6.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton6.Size = new System.Drawing.Size(50, 53);
            this.skinButton6.TabIndex = 5;
            this.skinButton6.Text = "6";
            this.skinButton6.UseVisualStyleBackColor = false;
            // 
            // skinButton5
            // 
            this.skinButton5.BackColor = System.Drawing.Color.Transparent;
            this.skinButton5.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton5.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton5.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton5.DownBack = null;
            this.skinButton5.Location = new System.Drawing.Point(23, 161);
            this.skinButton5.MouseBack = null;
            this.skinButton5.Name = "skinButton5";
            this.skinButton5.NormlBack = null;
            this.skinButton5.Radius = 20;
            this.skinButton5.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton5.Size = new System.Drawing.Size(50, 53);
            this.skinButton5.TabIndex = 4;
            this.skinButton5.Text = "5";
            this.skinButton5.UseVisualStyleBackColor = false;
            // 
            // OperatorBox
            // 
            this.OperatorBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OperatorBox.Controls.Add(this.skinButton17);
            this.OperatorBox.Controls.Add(this.skinButton16);
            this.OperatorBox.Controls.Add(this.skinButton15);
            this.OperatorBox.Controls.Add(this.skinButton14);
            this.OperatorBox.Controls.Add(this.skinButton13);
            this.OperatorBox.Controls.Add(this.skinButton12);
            this.OperatorBox.Controls.Add(this.skinButton11);
            this.OperatorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperatorBox.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperatorBox.Location = new System.Drawing.Point(0, 36);
            this.OperatorBox.Name = "OperatorBox";
            this.OperatorBox.Size = new System.Drawing.Size(200, 365);
            this.OperatorBox.TabIndex = 1;
            this.OperatorBox.TabItemImage = null;
            this.OperatorBox.Text = "Operateors";
            // 
            // skinButton17
            // 
            this.skinButton17.BackColor = System.Drawing.Color.Transparent;
            this.skinButton17.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton17.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton17.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton17.DownBack = null;
            this.skinButton17.Location = new System.Drawing.Point(27, 288);
            this.skinButton17.MouseBack = null;
            this.skinButton17.Name = "skinButton17";
            this.skinButton17.NormlBack = null;
            this.skinButton17.Radius = 20;
            this.skinButton17.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton17.Size = new System.Drawing.Size(50, 53);
            this.skinButton17.TabIndex = 17;
            this.skinButton17.Text = "）";
            this.skinButton17.UseVisualStyleBackColor = false;
            // 
            // skinButton16
            // 
            this.skinButton16.BackColor = System.Drawing.Color.Transparent;
            this.skinButton16.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton16.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton16.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton16.DownBack = null;
            this.skinButton16.Location = new System.Drawing.Point(117, 200);
            this.skinButton16.MouseBack = null;
            this.skinButton16.Name = "skinButton16";
            this.skinButton16.NormlBack = null;
            this.skinButton16.Radius = 20;
            this.skinButton16.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton16.Size = new System.Drawing.Size(50, 53);
            this.skinButton16.TabIndex = 16;
            this.skinButton16.Text = "（";
            this.skinButton16.UseVisualStyleBackColor = false;
            // 
            // skinButton15
            // 
            this.skinButton15.BackColor = System.Drawing.Color.Transparent;
            this.skinButton15.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton15.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton15.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton15.DownBack = null;
            this.skinButton15.Location = new System.Drawing.Point(27, 200);
            this.skinButton15.MouseBack = null;
            this.skinButton15.Name = "skinButton15";
            this.skinButton15.NormlBack = null;
            this.skinButton15.Radius = 20;
            this.skinButton15.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton15.Size = new System.Drawing.Size(50, 53);
            this.skinButton15.TabIndex = 15;
            this.skinButton15.Text = "=";
            this.skinButton15.UseVisualStyleBackColor = false;
            // 
            // skinButton14
            // 
            this.skinButton14.BackColor = System.Drawing.Color.Transparent;
            this.skinButton14.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton14.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton14.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton14.DownBack = null;
            this.skinButton14.Location = new System.Drawing.Point(117, 117);
            this.skinButton14.MouseBack = null;
            this.skinButton14.Name = "skinButton14";
            this.skinButton14.NormlBack = null;
            this.skinButton14.Radius = 20;
            this.skinButton14.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton14.Size = new System.Drawing.Size(50, 53);
            this.skinButton14.TabIndex = 14;
            this.skinButton14.Text = "÷";
            this.skinButton14.UseVisualStyleBackColor = false;
            // 
            // skinButton13
            // 
            this.skinButton13.BackColor = System.Drawing.Color.Transparent;
            this.skinButton13.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton13.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton13.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton13.DownBack = null;
            this.skinButton13.Location = new System.Drawing.Point(27, 117);
            this.skinButton13.MouseBack = null;
            this.skinButton13.Name = "skinButton13";
            this.skinButton13.NormlBack = null;
            this.skinButton13.Radius = 20;
            this.skinButton13.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton13.Size = new System.Drawing.Size(50, 53);
            this.skinButton13.TabIndex = 13;
            this.skinButton13.Text = "×";
            this.skinButton13.UseVisualStyleBackColor = false;
            // 
            // skinButton12
            // 
            this.skinButton12.BackColor = System.Drawing.Color.Transparent;
            this.skinButton12.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton12.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton12.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton12.DownBack = null;
            this.skinButton12.Location = new System.Drawing.Point(117, 33);
            this.skinButton12.MouseBack = null;
            this.skinButton12.Name = "skinButton12";
            this.skinButton12.NormlBack = null;
            this.skinButton12.Radius = 20;
            this.skinButton12.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton12.Size = new System.Drawing.Size(50, 53);
            this.skinButton12.TabIndex = 12;
            this.skinButton12.Text = "-";
            this.skinButton12.UseVisualStyleBackColor = false;
            // 
            // skinButton11
            // 
            this.skinButton11.BackColor = System.Drawing.Color.Transparent;
            this.skinButton11.BaseColor = System.Drawing.Color.LightGray;
            this.skinButton11.BorderColor = System.Drawing.Color.DimGray;
            this.skinButton11.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton11.DownBack = null;
            this.skinButton11.Location = new System.Drawing.Point(27, 33);
            this.skinButton11.MouseBack = null;
            this.skinButton11.Name = "skinButton11";
            this.skinButton11.NormlBack = null;
            this.skinButton11.Radius = 20;
            this.skinButton11.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton11.Size = new System.Drawing.Size(50, 53);
            this.skinButton11.TabIndex = 11;
            this.skinButton11.Text = "+";
            this.skinButton11.UseVisualStyleBackColor = false;
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinGroupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(465, 301);
            this.skinGroupBox1.TabIndex = 4;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "Canvas";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.WhiteSmoke;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinGroupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.WhiteSmoke;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(200, 401);
            this.skinGroupBox2.TabIndex = 5;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "Message";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.WhiteSmoke;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // Resut_Listbox
            // 
            this.Resut_Listbox.Back = null;
            this.Resut_Listbox.BackColor = System.Drawing.SystemColors.Menu;
            this.Resut_Listbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Resut_Listbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Resut_Listbox.FormattingEnabled = true;
            this.Resut_Listbox.Location = new System.Drawing.Point(0, 0);
            this.Resut_Listbox.MouseColor = System.Drawing.Color.Black;
            this.Resut_Listbox.Name = "Resut_Listbox";
            this.Resut_Listbox.RowBackColor1 = System.Drawing.Color.Black;
            this.Resut_Listbox.RowBackColor2 = System.Drawing.Color.Black;
            this.Resut_Listbox.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Resut_Listbox.Size = new System.Drawing.Size(465, 100);
            this.Resut_Listbox.TabIndex = 6;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.Silver;
            this.CaptionBackColorTop = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(881, 570);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "MathBrick";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.NumberOperator.ResumeLayout(false);
            this.NumberBox.ResumeLayout(false);
            this.OperatorBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinListBox Resut_Listbox;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CCWin.SkinControl.SkinTabControl NumberOperator;
        private CCWin.SkinControl.SkinTabPage NumberBox;
        private CCWin.SkinControl.SkinButton skinButton10;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton9;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinButton skinButton8;
        private CCWin.SkinControl.SkinButton skinButton4;
        private CCWin.SkinControl.SkinButton skinButton7;
        private CCWin.SkinControl.SkinButton skinButton6;
        private CCWin.SkinControl.SkinButton skinButton5;
        private CCWin.SkinControl.SkinTabPage OperatorBox;
        private CCWin.SkinControl.SkinButton skinButton17;
        private CCWin.SkinControl.SkinButton skinButton16;
        private CCWin.SkinControl.SkinButton skinButton15;
        private CCWin.SkinControl.SkinButton skinButton14;
        private CCWin.SkinControl.SkinButton skinButton13;
        private CCWin.SkinControl.SkinButton skinButton12;
        private CCWin.SkinControl.SkinButton skinButton11;
    }
}