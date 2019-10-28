using System;

namespace MathBrick
{
    partial class HomePage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Resut_Listbox = new CCWin.SkinControl.SkinListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sideTabControl = new CCWin.SkinControl.SkinTabControl();
            this.IntermediateBox = new CCWin.SkinControl.SkinTabPage();
            this.closeParenthesisButton = new CCWin.SkinControl.SkinButton();
            this.openParenthesisButton = new CCWin.SkinControl.SkinButton();
            this.divideButton = new CCWin.SkinControl.SkinButton();
            this.multiplyButton = new CCWin.SkinControl.SkinButton();
            this.NumberBox = new CCWin.SkinControl.SkinTabPage();
            this.tenButton = new CCWin.SkinControl.SkinButton();
            this.oneButton = new CCWin.SkinControl.SkinButton();
            this.twoButton = new CCWin.SkinControl.SkinButton();
            this.nineButton = new CCWin.SkinControl.SkinButton();
            this.threeButton = new CCWin.SkinControl.SkinButton();
            this.eightButton = new CCWin.SkinControl.SkinButton();
            this.fourButton = new CCWin.SkinControl.SkinButton();
            this.sevenButton = new CCWin.SkinControl.SkinButton();
            this.sixButton = new CCWin.SkinControl.SkinButton();
            this.fiveButton = new CCWin.SkinControl.SkinButton();
            this.BasicBox = new CCWin.SkinControl.SkinTabPage();
            this.equalButton = new CCWin.SkinControl.SkinButton();
            this.minusButton = new CCWin.SkinControl.SkinButton();
            this.plusButton = new CCWin.SkinControl.SkinButton();
            this.AdvancedBox = new CCWin.SkinControl.SkinTabPage();
            this.squareButton = new CCWin.SkinControl.SkinButton();
            this.yButton = new CCWin.SkinControl.SkinButton();
            this.xButton = new CCWin.SkinControl.SkinButton();
            this.equationButton = new CCWin.SkinControl.SkinButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quizButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.manageButton = new System.Windows.Forms.Button();
            this.blockMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sideTabControl.SuspendLayout();
            this.IntermediateBox.SuspendLayout();
            this.NumberBox.SuspendLayout();
            this.BasicBox.SuspendLayout();
            this.AdvancedBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.skinGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 582);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.skinGroupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(745, 330);
            this.panel6.TabIndex = 4;
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
            this.skinGroupBox1.Size = new System.Drawing.Size(745, 330);
            this.skinGroupBox1.TabIndex = 4;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "Canvas";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.WhiteSmoke;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.skinGroupBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(745, 126);
            this.panel5.TabIndex = 3;
            // 
            // Resut_Listbox
            // 
            this.Resut_Listbox.Back = null;
            this.Resut_Listbox.BackColor = System.Drawing.Color.White;
            this.Resut_Listbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Resut_Listbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Resut_Listbox.FormattingEnabled = true;
            this.Resut_Listbox.ItemHeight = 18;
            this.Resut_Listbox.Location = new System.Drawing.Point(3, 23);
            this.Resut_Listbox.Margin = new System.Windows.Forms.Padding(0);
            this.Resut_Listbox.MouseColor = System.Drawing.Color.White;
            this.Resut_Listbox.Name = "Resut_Listbox";
            this.Resut_Listbox.RowBackColor2 = System.Drawing.Color.White;
            this.Resut_Listbox.SelectedColor = System.Drawing.Color.White;
            this.Resut_Listbox.Size = new System.Drawing.Size(739, 100);
            this.Resut_Listbox.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.skinGroupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(914, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 460);
            this.panel4.TabIndex = 2;
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
            this.skinGroupBox2.Size = new System.Drawing.Size(200, 460);
            this.skinGroupBox2.TabIndex = 5;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "Message";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.WhiteSmoke;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.sideTabControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 122);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 460);
            this.panel3.TabIndex = 1;
            // 
            // sideTabControl
            // 
            this.sideTabControl.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.sideTabControl.ArrowBaseColor = System.Drawing.Color.Gainsboro;
            this.sideTabControl.ArrowBorderColor = System.Drawing.Color.Silver;
            this.sideTabControl.ArrowColor = System.Drawing.Color.DarkGray;
            this.sideTabControl.BackColor = System.Drawing.Color.Silver;
            this.sideTabControl.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.sideTabControl.Controls.Add(this.NumberBox);
            this.sideTabControl.Controls.Add(this.BasicBox);
            this.sideTabControl.Controls.Add(this.IntermediateBox);
            this.sideTabControl.Controls.Add(this.AdvancedBox);
            this.sideTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideTabControl.HeadBack = null;
            this.sideTabControl.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.sideTabControl.ItemSize = new System.Drawing.Size(70, 36);
            this.sideTabControl.Location = new System.Drawing.Point(0, 0);
            this.sideTabControl.Name = "sideTabControl";
            this.sideTabControl.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("sideTabControl.PageArrowDown")));
            this.sideTabControl.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("sideTabControl.PageArrowHover")));
            this.sideTabControl.PageBaseColor = System.Drawing.Color.LightGray;
            this.sideTabControl.PageBorderColor = System.Drawing.Color.Gainsboro;
            this.sideTabControl.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("sideTabControl.PageCloseHover")));
            this.sideTabControl.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("sideTabControl.PageCloseNormal")));
            this.sideTabControl.PageDown = ((System.Drawing.Image)(resources.GetObject("sideTabControl.PageDown")));
            this.sideTabControl.PageHover = ((System.Drawing.Image)(resources.GetObject("sideTabControl.PageHover")));
            this.sideTabControl.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.sideTabControl.PageNorml = null;
            this.sideTabControl.SelectedIndex = 0;
            this.sideTabControl.Size = new System.Drawing.Size(169, 460);
            this.sideTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.sideTabControl.TabIndex = 12;
            // 
            // IntermediateBox
            // 
            this.IntermediateBox.BackColor = System.Drawing.Color.White;
            this.IntermediateBox.Controls.Add(this.closeParenthesisButton);
            this.IntermediateBox.Controls.Add(this.openParenthesisButton);
            this.IntermediateBox.Controls.Add(this.divideButton);
            this.IntermediateBox.Controls.Add(this.multiplyButton);
            this.IntermediateBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntermediateBox.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntermediateBox.Location = new System.Drawing.Point(0, 36);
            this.IntermediateBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.IntermediateBox.Name = "IntermediateBox";
            this.IntermediateBox.Size = new System.Drawing.Size(169, 424);
            this.IntermediateBox.TabIndex = 2;
            this.IntermediateBox.TabItemImage = null;
            this.IntermediateBox.Text = "Intermediate";
            // 
            // closeParenthesisButton
            // 
            this.closeParenthesisButton.BackColor = System.Drawing.Color.Transparent;
            this.closeParenthesisButton.BaseColor = System.Drawing.Color.LightGray;
            this.closeParenthesisButton.BorderColor = System.Drawing.Color.DimGray;
            this.closeParenthesisButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.closeParenthesisButton.DownBack = null;
            this.closeParenthesisButton.Location = new System.Drawing.Point(48, 110);
            this.closeParenthesisButton.MouseBack = null;
            this.closeParenthesisButton.Name = "closeParenthesisButton";
            this.closeParenthesisButton.NormlBack = null;
            this.closeParenthesisButton.Radius = 20;
            this.closeParenthesisButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.closeParenthesisButton.Size = new System.Drawing.Size(32, 35);
            this.closeParenthesisButton.TabIndex = 18;
            this.closeParenthesisButton.Text = "）";
            this.closeParenthesisButton.UseVisualStyleBackColor = false;
            // 
            // openParenthesisButton
            // 
            this.openParenthesisButton.BackColor = System.Drawing.Color.Transparent;
            this.openParenthesisButton.BaseColor = System.Drawing.Color.LightGray;
            this.openParenthesisButton.BorderColor = System.Drawing.Color.DimGray;
            this.openParenthesisButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.openParenthesisButton.DownBack = null;
            this.openParenthesisButton.Location = new System.Drawing.Point(9, 110);
            this.openParenthesisButton.MouseBack = null;
            this.openParenthesisButton.Name = "openParenthesisButton";
            this.openParenthesisButton.NormlBack = null;
            this.openParenthesisButton.Radius = 20;
            this.openParenthesisButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.openParenthesisButton.Size = new System.Drawing.Size(32, 35);
            this.openParenthesisButton.TabIndex = 17;
            this.openParenthesisButton.Text = "（";
            this.openParenthesisButton.UseVisualStyleBackColor = false;
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.Transparent;
            this.divideButton.BaseColor = System.Drawing.Color.LightGray;
            this.divideButton.BorderColor = System.Drawing.Color.DimGray;
            this.divideButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.divideButton.DownBack = null;
            this.divideButton.Location = new System.Drawing.Point(9, 60);
            this.divideButton.MouseBack = null;
            this.divideButton.Name = "divideButton";
            this.divideButton.NormlBack = null;
            this.divideButton.Radius = 20;
            this.divideButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.divideButton.Size = new System.Drawing.Size(32, 35);
            this.divideButton.TabIndex = 15;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = false;
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.Transparent;
            this.multiplyButton.BaseColor = System.Drawing.Color.LightGray;
            this.multiplyButton.BorderColor = System.Drawing.Color.DimGray;
            this.multiplyButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.multiplyButton.DownBack = null;
            this.multiplyButton.Location = new System.Drawing.Point(9, 12);
            this.multiplyButton.MouseBack = null;
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.NormlBack = null;
            this.multiplyButton.Radius = 20;
            this.multiplyButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.multiplyButton.Size = new System.Drawing.Size(32, 35);
            this.multiplyButton.TabIndex = 14;
            this.multiplyButton.Text = "×";
            this.multiplyButton.UseVisualStyleBackColor = false;
            // 
            // NumberBox
            // 
            this.NumberBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumberBox.Controls.Add(this.tenButton);
            this.NumberBox.Controls.Add(this.oneButton);
            this.NumberBox.Controls.Add(this.twoButton);
            this.NumberBox.Controls.Add(this.nineButton);
            this.NumberBox.Controls.Add(this.threeButton);
            this.NumberBox.Controls.Add(this.eightButton);
            this.NumberBox.Controls.Add(this.fourButton);
            this.NumberBox.Controls.Add(this.sevenButton);
            this.NumberBox.Controls.Add(this.sixButton);
            this.NumberBox.Controls.Add(this.fiveButton);
            this.NumberBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberBox.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberBox.Location = new System.Drawing.Point(0, 36);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(169, 424);
            this.NumberBox.TabIndex = 0;
            this.NumberBox.TabItemImage = null;
            this.NumberBox.Text = "Numbers";
            // 
            // tenButton
            // 
            this.tenButton.BackColor = System.Drawing.Color.Transparent;
            this.tenButton.BaseColor = System.Drawing.Color.LightGray;
            this.tenButton.BorderColor = System.Drawing.Color.DimGray;
            this.tenButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.tenButton.DownBack = null;
            this.tenButton.Location = new System.Drawing.Point(50, 138);
            this.tenButton.MouseBack = null;
            this.tenButton.Name = "tenButton";
            this.tenButton.NormlBack = null;
            this.tenButton.Radius = 20;
            this.tenButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.tenButton.Size = new System.Drawing.Size(32, 35);
            this.tenButton.TabIndex = 10;
            this.tenButton.Text = "0";
            this.tenButton.UseVisualStyleBackColor = false;
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.Transparent;
            this.oneButton.BaseColor = System.Drawing.Color.LightGray;
            this.oneButton.BorderColor = System.Drawing.Color.DimGray;
            this.oneButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.oneButton.DownBack = null;
            this.oneButton.Location = new System.Drawing.Point(11, 15);
            this.oneButton.MouseBack = null;
            this.oneButton.Name = "oneButton";
            this.oneButton.NormlBack = null;
            this.oneButton.Radius = 20;
            this.oneButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.oneButton.Size = new System.Drawing.Size(32, 35);
            this.oneButton.TabIndex = 0;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.Transparent;
            this.twoButton.BaseColor = System.Drawing.Color.LightGray;
            this.twoButton.BorderColor = System.Drawing.Color.DimGray;
            this.twoButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.twoButton.DownBack = null;
            this.twoButton.Location = new System.Drawing.Point(50, 15);
            this.twoButton.MouseBack = null;
            this.twoButton.Name = "twoButton";
            this.twoButton.NormlBack = null;
            this.twoButton.Radius = 20;
            this.twoButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.twoButton.Size = new System.Drawing.Size(32, 35);
            this.twoButton.TabIndex = 1;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.Transparent;
            this.nineButton.BaseColor = System.Drawing.Color.LightGray;
            this.nineButton.BorderColor = System.Drawing.Color.DimGray;
            this.nineButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.nineButton.DownBack = null;
            this.nineButton.Location = new System.Drawing.Point(89, 97);
            this.nineButton.MouseBack = null;
            this.nineButton.Name = "nineButton";
            this.nineButton.NormlBack = null;
            this.nineButton.Radius = 20;
            this.nineButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.nineButton.Size = new System.Drawing.Size(32, 35);
            this.nineButton.TabIndex = 8;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.Transparent;
            this.threeButton.BaseColor = System.Drawing.Color.LightGray;
            this.threeButton.BorderColor = System.Drawing.Color.DimGray;
            this.threeButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.threeButton.DownBack = null;
            this.threeButton.Location = new System.Drawing.Point(89, 15);
            this.threeButton.MouseBack = null;
            this.threeButton.Name = "threeButton";
            this.threeButton.NormlBack = null;
            this.threeButton.Radius = 20;
            this.threeButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.threeButton.Size = new System.Drawing.Size(32, 35);
            this.threeButton.TabIndex = 2;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.Transparent;
            this.eightButton.BaseColor = System.Drawing.Color.LightGray;
            this.eightButton.BorderColor = System.Drawing.Color.DimGray;
            this.eightButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.eightButton.DownBack = null;
            this.eightButton.Location = new System.Drawing.Point(50, 97);
            this.eightButton.MouseBack = null;
            this.eightButton.Name = "eightButton";
            this.eightButton.NormlBack = null;
            this.eightButton.Radius = 20;
            this.eightButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.eightButton.Size = new System.Drawing.Size(32, 35);
            this.eightButton.TabIndex = 7;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.Transparent;
            this.fourButton.BaseColor = System.Drawing.Color.LightGray;
            this.fourButton.BorderColor = System.Drawing.Color.DimGray;
            this.fourButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.fourButton.DownBack = null;
            this.fourButton.Location = new System.Drawing.Point(11, 56);
            this.fourButton.MouseBack = null;
            this.fourButton.Name = "fourButton";
            this.fourButton.NormlBack = null;
            this.fourButton.Radius = 20;
            this.fourButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.fourButton.Size = new System.Drawing.Size(32, 35);
            this.fourButton.TabIndex = 3;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.Transparent;
            this.sevenButton.BaseColor = System.Drawing.Color.LightGray;
            this.sevenButton.BorderColor = System.Drawing.Color.DimGray;
            this.sevenButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sevenButton.DownBack = null;
            this.sevenButton.Location = new System.Drawing.Point(11, 97);
            this.sevenButton.MouseBack = null;
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.NormlBack = null;
            this.sevenButton.Radius = 20;
            this.sevenButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.sevenButton.Size = new System.Drawing.Size(32, 35);
            this.sevenButton.TabIndex = 6;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.Transparent;
            this.sixButton.BaseColor = System.Drawing.Color.LightGray;
            this.sixButton.BorderColor = System.Drawing.Color.DimGray;
            this.sixButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sixButton.DownBack = null;
            this.sixButton.Location = new System.Drawing.Point(89, 56);
            this.sixButton.MouseBack = null;
            this.sixButton.Name = "sixButton";
            this.sixButton.NormlBack = null;
            this.sixButton.Radius = 20;
            this.sixButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.sixButton.Size = new System.Drawing.Size(32, 35);
            this.sixButton.TabIndex = 5;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.Transparent;
            this.fiveButton.BaseColor = System.Drawing.Color.LightGray;
            this.fiveButton.BorderColor = System.Drawing.Color.DimGray;
            this.fiveButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.fiveButton.DownBack = null;
            this.fiveButton.Location = new System.Drawing.Point(50, 56);
            this.fiveButton.MouseBack = null;
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.NormlBack = null;
            this.fiveButton.Radius = 20;
            this.fiveButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.fiveButton.Size = new System.Drawing.Size(32, 35);
            this.fiveButton.TabIndex = 4;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            // 
            // BasicBox
            // 
            this.BasicBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BasicBox.Controls.Add(this.equalButton);
            this.BasicBox.Controls.Add(this.minusButton);
            this.BasicBox.Controls.Add(this.plusButton);
            this.BasicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BasicBox.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicBox.Location = new System.Drawing.Point(0, 36);
            this.BasicBox.Name = "BasicBox";
            this.BasicBox.Size = new System.Drawing.Size(169, 424);
            this.BasicBox.TabIndex = 1;
            this.BasicBox.TabItemImage = null;
            this.BasicBox.Text = "Basic";
            // 
            // equalButton
            // 
            this.equalButton.BackColor = System.Drawing.Color.Transparent;
            this.equalButton.BaseColor = System.Drawing.Color.LightGray;
            this.equalButton.BorderColor = System.Drawing.Color.DimGray;
            this.equalButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.equalButton.DownBack = null;
            this.equalButton.Location = new System.Drawing.Point(11, 97);
            this.equalButton.MouseBack = null;
            this.equalButton.Name = "equalButton";
            this.equalButton.NormlBack = null;
            this.equalButton.Radius = 20;
            this.equalButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.equalButton.Size = new System.Drawing.Size(32, 35);
            this.equalButton.TabIndex = 15;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = false;
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Transparent;
            this.minusButton.BaseColor = System.Drawing.Color.LightGray;
            this.minusButton.BorderColor = System.Drawing.Color.DimGray;
            this.minusButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.minusButton.DownBack = null;
            this.minusButton.Location = new System.Drawing.Point(11, 56);
            this.minusButton.MouseBack = null;
            this.minusButton.Name = "minusButton";
            this.minusButton.NormlBack = null;
            this.minusButton.Radius = 20;
            this.minusButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.minusButton.Size = new System.Drawing.Size(32, 35);
            this.minusButton.TabIndex = 12;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.Transparent;
            this.plusButton.BaseColor = System.Drawing.Color.LightGray;
            this.plusButton.BorderColor = System.Drawing.Color.DimGray;
            this.plusButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.plusButton.DownBack = null;
            this.plusButton.Location = new System.Drawing.Point(11, 15);
            this.plusButton.MouseBack = null;
            this.plusButton.Name = "plusButton";
            this.plusButton.NormlBack = null;
            this.plusButton.Radius = 20;
            this.plusButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.plusButton.Size = new System.Drawing.Size(32, 35);
            this.plusButton.TabIndex = 11;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            // 
            // AdvancedBox
            // 
            this.AdvancedBox.BackColor = System.Drawing.Color.White;
            this.AdvancedBox.Controls.Add(this.squareButton);
            this.AdvancedBox.Controls.Add(this.yButton);
            this.AdvancedBox.Controls.Add(this.xButton);
            this.AdvancedBox.Controls.Add(this.equationButton);
            this.AdvancedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvancedBox.Font = new System.Drawing.Font("Calibri", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvancedBox.Location = new System.Drawing.Point(0, 36);
            this.AdvancedBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.AdvancedBox.Name = "AdvancedBox";
            this.AdvancedBox.Size = new System.Drawing.Size(200, 424);
            this.AdvancedBox.TabIndex = 3;
            this.AdvancedBox.TabItemImage = null;
            this.AdvancedBox.Text = "Advanced";
            // 
            // squareButton
            // 
            this.squareButton.BackColor = System.Drawing.Color.Transparent;
            this.squareButton.BaseColor = System.Drawing.Color.LightGray;
            this.squareButton.BorderColor = System.Drawing.Color.DimGray;
            this.squareButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.squareButton.DownBack = null;
            this.squareButton.Location = new System.Drawing.Point(43, 52);
            this.squareButton.MouseBack = null;
            this.squareButton.Name = "squareButton";
            this.squareButton.NormlBack = null;
            this.squareButton.Radius = 20;
            this.squareButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.squareButton.Size = new System.Drawing.Size(32, 35);
            this.squareButton.TabIndex = 19;
            this.squareButton.Text = "^2";
            this.squareButton.UseVisualStyleBackColor = false;
            // 
            // yButton
            // 
            this.yButton.BackColor = System.Drawing.Color.Transparent;
            this.yButton.BaseColor = System.Drawing.Color.LightGray;
            this.yButton.BorderColor = System.Drawing.Color.DimGray;
            this.yButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.yButton.DownBack = null;
            this.yButton.Location = new System.Drawing.Point(43, 10);
            this.yButton.MouseBack = null;
            this.yButton.Name = "yButton";
            this.yButton.NormlBack = null;
            this.yButton.Radius = 20;
            this.yButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.yButton.Size = new System.Drawing.Size(32, 35);
            this.yButton.TabIndex = 18;
            this.yButton.Text = "y";
            this.yButton.UseVisualStyleBackColor = false;
            // 
            // xButton
            // 
            this.xButton.BackColor = System.Drawing.Color.Transparent;
            this.xButton.BaseColor = System.Drawing.Color.LightGray;
            this.xButton.BorderColor = System.Drawing.Color.DimGray;
            this.xButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.xButton.DownBack = null;
            this.xButton.Location = new System.Drawing.Point(5, 10);
            this.xButton.MouseBack = null;
            this.xButton.Name = "xButton";
            this.xButton.NormlBack = null;
            this.xButton.Radius = 20;
            this.xButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.xButton.Size = new System.Drawing.Size(32, 35);
            this.xButton.TabIndex = 17;
            this.xButton.Text = "x";
            this.xButton.UseVisualStyleBackColor = false;
            // 
            // equationButton
            // 
            this.equationButton.BackColor = System.Drawing.Color.Transparent;
            this.equationButton.BaseColor = System.Drawing.Color.LightGray;
            this.equationButton.BorderColor = System.Drawing.Color.DimGray;
            this.equationButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.equationButton.DownBack = null;
            this.equationButton.Location = new System.Drawing.Point(5, 52);
            this.equationButton.MouseBack = null;
            this.equationButton.Name = "equationButton";
            this.equationButton.NormlBack = null;
            this.equationButton.Radius = 20;
            this.equationButton.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.equationButton.Size = new System.Drawing.Size(32, 35);
            this.equationButton.TabIndex = 16;
            this.equationButton.Text = "=";
            this.equationButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.quizButton);
            this.panel2.Controls.Add(this.logoutButton);
            this.panel2.Controls.Add(this.manageButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 122);
            this.panel2.TabIndex = 0;
            // 
            // quizButton
            // 
            this.quizButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quizButton.Location = new System.Drawing.Point(6, 75);
            this.quizButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.quizButton.Name = "quizButton";
            this.quizButton.Size = new System.Drawing.Size(80, 42);
            this.quizButton.TabIndex = 2;
            this.quizButton.Text = "Quizzes";
            this.quizButton.UseVisualStyleBackColor = true;
            this.quizButton.Click += new System.EventHandler(this.SelectQuiz);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Location = new System.Drawing.Point(1022, 75);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(86, 42);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.Logout);
            // 
            // manageButton
            // 
            this.manageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.manageButton.Location = new System.Drawing.Point(1022, 6);
            this.manageButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(86, 44);
            this.manageButton.TabIndex = 0;
            this.manageButton.Text = "Admin";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.ManageAccounts);
            // 
            // blockMoveTimer
            // 
            this.blockMoveTimer.Interval = 10;
            this.blockMoveTimer.Tick += new System.EventHandler(this.BlockMoveTimer_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(169, 122);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Size = new System.Drawing.Size(745, 460);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.TabIndex = 3;
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.BorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox3.Controls.Add(this.Resut_Listbox);
            this.skinGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinGroupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinGroupBox3.ForeColor = System.Drawing.Color.Black;
            this.skinGroupBox3.Location = new System.Drawing.Point(0, 0);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.WhiteSmoke;
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(745, 126);
            this.skinGroupBox3.TabIndex = 6;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.Text = "Result";
            this.skinGroupBox3.TitleBorderColor = System.Drawing.Color.DarkGray;
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.WhiteSmoke;
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionBackColorBottom = System.Drawing.Color.Silver;
            this.CaptionBackColorTop = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1130, 629);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "MathBrick";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.sideTabControl.ResumeLayout(false);
            this.IntermediateBox.ResumeLayout(false);
            this.NumberBox.ResumeLayout(false);
            this.BasicBox.ResumeLayout(false);
            this.AdvancedBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.skinGroupBox3.ResumeLayout(false);
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
        private CCWin.SkinControl.SkinTabControl sideTabControl;
        private CCWin.SkinControl.SkinTabPage NumberBox;
        private CCWin.SkinControl.SkinButton tenButton;
        private CCWin.SkinControl.SkinButton oneButton;
        private CCWin.SkinControl.SkinButton twoButton;
        private CCWin.SkinControl.SkinButton nineButton;
        private CCWin.SkinControl.SkinButton threeButton;
        private CCWin.SkinControl.SkinButton eightButton;
        private CCWin.SkinControl.SkinButton fourButton;
        private CCWin.SkinControl.SkinButton sevenButton;
        private CCWin.SkinControl.SkinButton sixButton;
        private CCWin.SkinControl.SkinButton fiveButton;
        private CCWin.SkinControl.SkinTabPage BasicBox;
        private CCWin.SkinControl.SkinButton equalButton;
        private CCWin.SkinControl.SkinButton minusButton;
        private CCWin.SkinControl.SkinButton plusButton;
        private CCWin.SkinControl.SkinTabPage IntermediateBox;
        private CCWin.SkinControl.SkinTabPage AdvancedBox;
        private CCWin.SkinControl.SkinButton closeParenthesisButton;
        private CCWin.SkinControl.SkinButton openParenthesisButton;
        private CCWin.SkinControl.SkinButton divideButton;
        private CCWin.SkinControl.SkinButton multiplyButton;
        private CCWin.SkinControl.SkinButton yButton;
        private CCWin.SkinControl.SkinButton xButton;
        private CCWin.SkinControl.SkinButton equationButton;
        private System.Windows.Forms.Button quizButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button manageButton;
        private CCWin.SkinControl.SkinButton squareButton;
        private System.Windows.Forms.Timer blockMoveTimer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox3;
    }
}