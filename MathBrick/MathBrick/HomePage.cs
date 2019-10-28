using System;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace MathBrick
{
    public partial class HomePage : Skin_Color
    {
        Control moveBtn;
        public static Point startingPoint = new Point(50, 50);
        public HomePage()
        {
            InitializeComponent();
            AddEventForDragDrop();
            sideTabControl.SelectedIndex = 0;
            CustomizeTabControl();
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit？", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Dispose();
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// The AddEventForDragDrop function binds click event to all buttons in tabpage1 and 2 which are the numbers and operators
        /// </summary>
        private void AddEventForDragDrop()
        {
            foreach (Button button in this.NumberBox.Controls)
            {
                button.Click += new EventHandler(ClickToDuplicate);
            }
            foreach (Button button in this.BasicBox.Controls)
            {
                button.Click += new EventHandler(ClickToDuplicate);
            }
            foreach (Button button in this.IntermediateBox.Controls)
            {
                button.Click += new EventHandler(ClickToDuplicate);
            }
            foreach (Button button in this.AdvancedBox.Controls)
            {
                button.Click += new EventHandler(ClickToDuplicate);
            }
        }

        /// <summary>
        /// The ClickToDuplicate function enables block to duplicate themselve into canvas section when click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickToDuplicate(object sender, EventArgs e)
        {
            Control control = sender as Control;

            // Follow the same block design
            CCWin.SkinControl.SkinButton btn = this.SetupButtonStyle(control.Location, control.Text);
            CCWin.SkinControl.SkinButton deleteIcon = this.SetupDeleteIcon();

            btn.Controls.Add(deleteIcon);
            deleteIcon.Click += new EventHandler(TriggerDeleteEvent);
            this.skinGroupBox1.Controls.Add(btn);               
            this.skinGroupBox1.AllowDrop = true;

            btn.MouseDown += new MouseEventHandler(DragBlockMouseDown);
            this.skinGroupBox1.DragOver += new DragEventHandler(BlockDropOver);
            this.skinGroupBox1.DragDrop += new DragEventHandler(BlockDragDrop);        
        }

        /// <summary>
        /// The TriggerDeleteEvent is used to delete unwanted block
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TriggerDeleteEvent(object sender, EventArgs e)
        {
            Control control = sender as Control;
            DialogResult result = MessageBox.Show("Delete this block?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                if (this.skinGroupBox1.Controls.Contains(control.Parent))
                {
                    this.skinGroupBox1.Controls.Remove(control.Parent);
                }
            }
        }

        /// <summary>
        /// The DragBlockMouseDown function starts a dragdrop operation when mouse down
        /// reference: Microsoft tutorial about drag drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragBlockMouseDown(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;
            moveBtn = control;
            blockMoveTimer.Enabled = true;
            control.DoDragDrop(control, DragDropEffects.Move);
        }

        /// <summary>
        /// The BlockDragDrop function displays the new location of the block after dragging is finished
        /// reference: https://social.msdn.microsoft.com/Forums/vstudio/en-US/3d23ad93-e70d-4076-bf50-3e17ec43d0e1/drag-and-drop-the-control-in-the-panel-in-c?forum=netfxbcl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlockDragDrop(object sender, DragEventArgs e)
        {
            Control control = e.Data.GetData(e.Data.GetFormats()[0]) as Control;
            if (control != null)
            {
                control.Location = this.skinGroupBox1.PointToClient(new Point(e.X - control.Size.Width/2, e.Y - control.Size.Height/2));
                this.skinGroupBox1.Controls.Add(control);
                blockMoveTimer.Enabled = false;
            }
        }

        /// <summary>
        /// The BlockDropOver function set the effect when drag over the bound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BlockDropOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        /// <summary>
        /// The SetupButtonStyle function is used to put reusable code when creating a new block
        /// </summary>
        /// <param name="point"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private CCWin.SkinControl.SkinButton SetupButtonStyle(System.Drawing.Point point, string text)
        {
            var btn = new CCWin.SkinControl.SkinButton();
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.BaseColor = System.Drawing.Color.LightGray;
            btn.BorderColor = System.Drawing.Color.DimGray;
            btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            btn.Radius = 20;
            btn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            // Update to the new size of block
            btn.Size = new System.Drawing.Size(32, 38);
            btn.UseVisualStyleBackColor = false;
            btn.Location = startingPoint;
            btn.Text = text;
            btn.Anchor = AnchorStyles.Left | AnchorStyles.Top; 
            startingPoint.X += 40;

            return btn;
        }

        /// <summary>
        /// The SetupDeleteIcon function is to create a delete icon for button to delete itself
        /// </summary>
        /// <returns></returns>
        private CCWin.SkinControl.SkinButton SetupDeleteIcon()
        {
            var btn = new CCWin.SkinControl.SkinButton();
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.BorderColor = System.Drawing.Color.DimGray;
            btn.BaseColor = System.Drawing.Color.Red;
            btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            btn.Size = new System.Drawing.Size(10, 10);
            btn.ForeColor = Color.White;
            btn.Font = new Font(btn.Font.FontFamily, 5, FontStyle.Bold);
            btn.Text = "x";
            // TODO: change the position to top right instead
            return btn;
        }

        private void SelectQuiz(object sender, EventArgs e)
        {
            QuizList quizList = new QuizList();
            quizList.Show();
        }

        private void Logout(object sender, EventArgs e)
        {
            DataBase.Instance.UserLogout();
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void ManageAccounts(object sender, EventArgs e)
        {
            ManagePage managePage = new ManagePage();
            managePage.Show();
        }

        private void CustomizeTabControl()
        {
            User nowUser = DataBase.Instance.activeUser;
            switch (nowUser.authorizeLevel)
            {
                case -1:
                    break;
                case 1:
                    Console.Out.WriteLine("Login as: " + "Beginner");
                    sideTabControl.TabPages.RemoveByKey("IntermediateBox");
                    sideTabControl.TabPages.RemoveByKey("AdvancedBox");
                    manageButton.Hide();
                    break;
                case 2:
                    Console.Out.WriteLine("Login as: " + "Intermediate");
                    sideTabControl.TabPages.RemoveByKey("AdvancedBox");
                    manageButton.Hide();
                    break;
                case 3:
                    Console.Out.WriteLine("Login as: " + "Advanced");
                    manageButton.Hide();
                    break;
                case 4:
                    Console.Out.WriteLine("Login as: " + "Teacher");
                    break;
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
        }

        private void BlockMoveTimer_Tick(object sender, EventArgs e)
        {
            moveBtn.Location = this.skinGroupBox1.PointToClient(new Point(MousePosition.X - moveBtn.Size.Width / 2, MousePosition.Y - moveBtn.Size.Height / 2));
        }

        private void SortButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {          

        }

        private void ResultButton_Click(object sender, EventArgs e)
        {

        }
    }
}
