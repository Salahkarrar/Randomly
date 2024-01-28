using Randomly.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Randomly
{
    public partial class Main : Form
    {

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.ConnStrings);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, System.EventArgs e)
        {
            T_PassMangerTabAd.Fill(randomSet.T_PassManger);
        }

        private void New_Btn_Click(object sender, EventArgs e)
        {
            Edit(false, true);
            Edit_Btn.Enabled = false;

            randomSet.T_PassManger.AddT_PassMangerRow(randomSet.T_PassManger.NewT_PassMangerRow());
            T_PassMangerBindSour.MoveLast();
            Websites_Txt.Focus();
            Date_Txt.Text = DateTime.Now.ToString("G");
            Edit_Btn.Enabled = true;
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Websites_Txt.Text.ToString()) && !string.IsNullOrEmpty(UserName_Txt.Text.ToString())
                    && !string.IsNullOrEmpty(Pass_Txt.Text) && !string.IsNullOrEmpty(Date_Txt.Text))
                {
                    Edit(true, false);
                    T_PassMangerTabAd.Insert(Convert.ToString(Websites_Txt.Text), UserName_Txt.Text.ToString(), Pass_Txt.Text, DateTime.Now);
                    MessageBoxEx.Show("Data Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                    T_PassMangerTabAd.Fill(randomSet.T_PassManger);
                    T_PassMangerBindSour.MoveLast();
                }
                else
                {
                    MessageBoxEx.Show("Please Check Your Data and Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Please Recheck The Entery Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Edit_Btn.Text == "Edit")
                {
                    Edit(false, true);
                    New_Btn.Enabled = false;
                    Save_Btn.Enabled = false;
                    Edit_Ico(Edit_Btn, "Update", Resources.Dark_Send_18);
                }
                else if (Edit_Btn.Text == "Update")
                {
                    Edit(true, false);
                    New_Btn.Enabled = true;
                    Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                    T_PassMangerBindSour.EndEdit();
                    T_PassMangerTabAd.Update(randomSet.T_PassManger);
                    MessageBoxEx.Show("Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                else
                {
                    Edit(true, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Update Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Edit_Ico(Edit_Btn, "Edit", Resources.Dark_Edit_18);
                Edit(true, false);
                New_Btn.Enabled = true;
                T_PassMangerBindSour.CancelEdit();
                T_PassMangerTabAd.Fill(randomSet.T_PassManger);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Database, Can't Cancel Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            dynamic dialog = MessageBox.Show("Are You Sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    if (Con.State == ConnectionState.Closed)
                    {
                        Con.Open();
                    }

                    Cmd.Connection = Con;
                    Cmd.CommandText = "DELETE FROM T_PassManger WHERE ID=@0";
                    Cmd.Parameters.AddWithValue("@0", Pass_Grid.CurrentRow.Cells[0].Value);
                    Cmd.ExecuteNonQuery();
                    Cmd.Parameters.Clear();
                    Con.Close();
                    T_PassMangerTabAd.Fill(randomSet.T_PassManger);
                    T_PassMangerBindSour.MoveFirst();
                    MessageBoxEx.Show("Data Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information, 1000);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem in Database, Can't Delete Your Data." + "\r\n" + "Call System Administrator" + "\r\n" + ex.Message, "Error Users - 1005", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Random_Btn_Click(object sender, EventArgs e)
        {
            if (Pass_Txt.ReadOnly == false)
            {
                int length = 25; // Set the desired length of the password

                string password = GenerateRandomPassword(length);

                Pass_Txt.Text = password;
            }
            else
            {
                MessageBoxEx.Show("The Data is Blocked", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
            }
        }

        private void Copy_Btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Pass_Txt.Text);
        }

        private void Eye_Btn_Click(object sender, EventArgs e)
        {
            if (Pass_Txt.UseSystemPasswordChar == true)
            {
                Eye_Btn.Image = Resources.hide;
                Pass_Txt.UseSystemPasswordChar = false;
            }
            else
            {
                Eye_Btn.Image = Resources.show;
                Pass_Txt.UseSystemPasswordChar = true;
            }
        }
        //Functions

        private void Edit(bool Value, bool Value2)
        {
            Save_Btn.Enabled = Value2;
            Websites_Txt.ReadOnly = Value;
            UserName_Txt.ReadOnly = Value;
            Pass_Txt.ReadOnly = Value;
        }
        private void Edit_Ico(Button Value, string Value2, Image Value3)
        {
            Value.Text = Value2;
            Value.Image = Value3;
            Value.ImageAlign = ContentAlignment.TopLeft;
            Value.TextImageRelation = TextImageRelation.ImageBeforeText;
        }

        static string GenerateRandomPassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+-=[]{}|;:'\",.<>?/"; // Add or remove characters as needed
            Random random = new Random();

            StringBuilder password = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(chars.Length);
                password.Append(chars[index]);
            }

            return password.ToString();
        }

        private void Pass_Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void Pass_Txt_Enter(object sender, EventArgs e)
        {
            Random_Btn_Click(sender, e);
        }
    }


}
