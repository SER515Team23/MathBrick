using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace MathBrick
{
    public partial class Main1 : Skin_Color
    {
        private static System.Drawing.Size mouseOffset;
        private static Boolean isDraggable = false;
        public Main1()
        {
            InitializeComponent();
            AddButtonClickEventForDragDrop();
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
        /// This AddButtonClickEventForDragDrop function binds click event to all buttons in tabpage1 and 2 which are the numbers and operators
        /// </summary>
        private void AddButtonClickEventForDragDrop()
        {          
            foreach (Button button in this.NumberBox.Controls)
            {
                button.Click += new EventHandler(ClickToDuplicate);
            }
        }

        /// <summary>
        /// This ClickToDuplicate function enables block to duplicate themselve into canvas section when click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickToDuplicate(object sender, EventArgs e)
        {
            Control control = sender as Control;

            // Follow the same block design
            CCWin.SkinControl.SkinButton btn = this.SetupButtonStyle(control.Location, control.Text);
            this.skinGroupBox1.Controls.Add(btn);

            /* references that are used for the following code: 
             * https://www.codeproject.com/Tips/178587/Draggable-WinForms-Controls-2
             * https://social.msdn.microsoft.com/Forums/vstudio/en-US/3d23ad93-e70d-4076-bf50-3e17ec43d0e1/drag-and-drop-the-control-in-the-panel-in-c?forum=netfxbcl
             * https://stackoverflow.com/questions/3728870/drag-and-drop-windows-forms-button
             */

            this.skinGroupBox1.AllowDrop = true;

            btn.MouseDown += new MouseEventHandler(DragBlockMouseDown);
            //btn.MouseMove += new MouseEventHandler(DragBlockMouseMove);

            this.skinGroupBox1.DragOver += new DragEventHandler(BoxDropOver);
            this.skinGroupBox1.DragDrop += new DragEventHandler(BoxDragDrop);
        }

        /// <summary>
        /// This DragBlockMouseDown function saves the starting location of the button as offset for later calculation when mouse down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragBlockMouseDown(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;
            control.DoDragDrop(control, DragDropEffects.Move);
            isDraggable = true;
            mouseOffset = new System.Drawing.Size(e.Location);
            return;
        }

        /// <summary>
        /// This DragBlockMouseMove function mean to show block while dragging the block
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void DragBlockMouseMove(object sender, MouseEventArgs e)
        //{
        //    if(isDraggable == true)
        //    {
        //        Control control = sender as Control;
        //        control.Location = this.skinGroupBox1.PointToClient(new Point((e.Location - mouseOffset).X, (e.Location - mouseOffset).Y));
        //        this.skinGroupBox1.Controls.Add(control);
        //        //control.Left = (e.Location - mouseOffset).X;
        //        //control.Top = (e.Location - mouseOffset).Y;
        //    }
        //}

        void BoxDragDrop(object sender, DragEventArgs e)
        {
            Control control = e.Data.GetData(e.Data.GetFormats()[0]) as Control;
            if (control != null)
            {
                control.Location = this.skinGroupBox1.PointToClient(new Point(e.X, e.Y));
                this.skinGroupBox1.Controls.Add(control);
            }
            isDraggable = false;
        }

        void BoxDropOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        ///// <summary>
        ///// This DragBlockMouseUp function calculates the new location and moves the button to the new location
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void DragBlockMouseUp(object sender, MouseEventArgs e)
        //{
        //    Control control = sender as Control;
        //    // TODO: Limit boundary of the area where it can be dragged

        //    //////////////////////////////////////////////////////////////
        //    var boundaryX = this.skinGroupBox1.Size.Width;
        //    var boundaryY = this.skinGroupBox1.Size.Height;
        //    control.Left = (control.Left + (e.Location - mouseOffset).X > boundaryX) ? boundaryX : control.Left + (e.Location - mouseOffset).X;
        //    control.Top = (control.Top + (e.Location - mouseOffset).Y > boundaryY) ? boundaryY : control.Top + (e.Location - mouseOffset).Y;

        //    return;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void Btn_Cancel_Click(object sender, EventArgs e)
        //{
        //    this.Parent.Controls.Remove(this);
        //}

        private CCWin.SkinControl.SkinButton SetupButtonStyle(System.Drawing.Point point, string text)
        {
            var btn = new CCWin.SkinControl.SkinButton();
            btn.BackColor = System.Drawing.Color.Transparent;
            btn.BaseColor = System.Drawing.Color.LightGray;
            btn.BorderColor = System.Drawing.Color.DimGray;
            btn.ControlState = CCWin.SkinClass.ControlState.Normal;
            btn.Radius = 20;
            btn.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            btn.Size = new System.Drawing.Size(50, 57);
            btn.UseVisualStyleBackColor = false;
            btn.Location = point;
            btn.Text = text;

            return btn;
        }

        /// <summary>
        /// Funtion of calculate the equation and return result or error by string
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string CalculateEquation(string str)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(str, "");
                return result.ToString();
            }
            catch (Exception ex)
            {
                return "error";
            }
        }
    }
}
