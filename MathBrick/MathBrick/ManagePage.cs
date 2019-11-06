using CCWin;
using System;
using System.Windows.Forms;

/* 
 * Author: Yu-Ting Tsao
 * Description: Administrator role only page. Manage all accounts authorization here.
*/

namespace MathBrick
{
    public partial class ManagePage : Skin_Color
    {
        private string[] headerTitle = { "Index", "User Name", "Level"};
        public ManagePage()
        {
            InitializeComponent();
            PeekUsersDatabase();
        }

        private void PeekUsersDatabase() {
            User[] users = DataBase.Instance.SeeAllUsers();
            DrawTheList(users);
        }

        private void DrawTheList(User[] users) {

            accoutListView.Columns.Add(headerTitle[0], -2, HorizontalAlignment.Center);
            accoutListView.Columns.Add(headerTitle[1], -2, HorizontalAlignment.Center);
            accoutListView.Columns.Add(headerTitle[2], -2, HorizontalAlignment.Center);

            for (int i = 0; i < users.Length; i++)
            {
                ListViewItem item = new ListViewItem((i+1).ToString(), i);
                item.SubItems.Add(users[i].userName);
                item.SubItems.Add(users[i].authorizeLevel.ToString());
                item.SubItems.Add(users[i].userName);
                accoutListView.Items.Add(item);
            }
            accoutListView.View = View.Details;
            accoutListView.FullRowSelect = true;
        }
    }
}
