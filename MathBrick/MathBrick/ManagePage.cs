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
            DrawComboBox();
            RegularColumn();
            PeekUsersDatabase();
        }

        private void RegularColumn()
        {
            accoutListView.Columns.Add(headerTitle[0], -2, HorizontalAlignment.Center);
            accoutListView.Columns.Add(headerTitle[1], -2, HorizontalAlignment.Center);
            accoutListView.Columns.Add(headerTitle[2], -2, HorizontalAlignment.Center);
        }

        private void DrawComboBox()
        {
            actComboBox.Items.Add("Set as BEGINNER");
            actComboBox.Items.Add("Set as INTERMEDIATE");
            actComboBox.Items.Add("Set as ADVANCED");
            actComboBox.Items.Add("Set as TEACHER");
            actComboBox.Items.Add("REMOVE from System");
        }

        private void PeekUsersDatabase() {
            User[] users = DataBase.Instance.SeeAllUsers();
            DrawTheList(users);
        }

        private void DrawTheList(User[] users)
        {
            accoutListView.Items.Clear();

            for (int i = 0; i < users.Length; i++)
            {
                ListViewItem item = new ListViewItem((i+1).ToString(), i);
                item.SubItems.Add(users[i].userName);
                string showing = ShowLevelText(users[i].authorizeLevel);
                item.SubItems.Add(showing);
                accoutListView.Items.Add(item);
            }
            accoutListView.View = View.Details;
            accoutListView.FullRowSelect = true;
        }

        private string ShowLevelText(int level)
        {
            if (level == 1)
            {
                return "BEGINNER";
            }
            else if (level == 2)
            {
                return "INTERMEDIATE";
            }
            else if (level == 3)
            {
                return "ADVANCED";
            }
            else if (level == 4)
            {
                return "TEACHER";
            }
            return "N/A";
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection accounts =
                this.accoutListView.SelectedItems;

            var targetName = String.Empty;
            foreach (ListViewItem item in accounts)
            {
                targetName = item.SubItems[1].Text;
            }
            if (string.IsNullOrEmpty(targetName))
            {
                MessageBox.Show("Please select an user to continue.", "Oops"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = actComboBox.SelectedIndex;
            var changeInfo = (level: 0, text: String.Empty);
            switch (selectedIndex)
            {
                case 0:
                    changeInfo = (1, "BEGINNER");
                    break;
                case 1:
                    changeInfo = (2, "INTERMEDIATE");
                    break;
                case 2:
                    changeInfo = (3, "ADVANCED");
                    break;
                case 3:
                    changeInfo = (4, "TEACHER");
                    break;
                case 4:
                    changeInfo = (-1, "REMOVAL");
                    break;
                default:
                    MessageBox.Show("Please select an action to this account.", "Oops"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            bool success = DataBase.Instance.ChangeAuthorizeLevel(targetName, changeInfo.level);
            if (success)
            {
                string information = "Account: " + targetName + " is now change to " + changeInfo.text;
                MessageBox.Show(information, "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PeekUsersDatabase();
            }
            else
            {
                MessageBox.Show("Something went wrong.", "Oops"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
