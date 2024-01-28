using Randomly.Properties;
using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Windows.Forms;

namespace Randomly
{
    public partial class Login : Form
    {

        public Login() => InitializeComponent();

        public OleDbConnection Con { get; } = new OleDbConnection(Resources.ConnStrings);
        public OleDbCommand Cmd { get; set; } = new OleDbCommand();


        public string BiosNum { get; set; }
        public string BoardNum { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Authority { get; set; }
        public string RoleID { get; set; }
        public string RoleName { get; set; }

        private static Login _instance;

        public static Login Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Login();
                }

                return _instance;
            }
        }



        private void Login_Load(object sender, EventArgs e)
        {

            //OnInit();
            GetSer();
            _instance = this;
            try
            {
                if (BoardNum == "PF31089G" && BiosNum == "PF31089G")
                {
                    try
                    {
                        if (Con.State == ConnectionState.Closed)
                        {
                            Con.Open();
                        }

                        Conn_Status.ForeColor = Color.Lime;
                        Conn_Status.Text = "Good";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can't Connect to Server Please Recheck It or Call The System Administrator" + "\r\n" + ex.Message, "Login - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Conn_Status.ForeColor = Color.Red;
                        Conn_Status.Text = "No Connection";
                    }
            }
                else
            {
                MessageBox.Show("The App Not Legal Please Call The System Administrator", "Legal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Problem in Check license. Please Call The System Administrator" + "\r\n" + ex.Message, "Login - 1000", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn_Status.ForeColor = Color.Red;
                Conn_Status.Text = "No Connection";
            }
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                using (OleDbCommand Cmd = new OleDbCommand
                {

                    Connection = Con,

                    CommandText = "SELECT * FROM T_Users WHERE Pass= @0"
                })
                {
                    Cmd.Parameters.AddWithValue("@0", PassWord.Text);
                    OleDbDataReader Reader = Cmd.ExecuteReader();
                    var c = 0;
                    while (Reader.Read())
                    {
                        c += 1;
                        UserID = Reader[0].ToString();
                        RoleID = Reader[3].ToString();
                        UserName = Reader[1].ToString();
                    }
                    Cmd.Parameters.Clear();
                    Reader.Close();
                    Con.Close();
                    if (c == 1)
                    {
                        Hide();
                        PassWord.Text = null;
                        using (Main D = new Main())
                        {
                            D.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBoxEx.Show("Password Not Correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 1000);
                        PassWord.Text = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't Connect to Database, Please Recheck The Server or Call System Administrator" + "\r\n" + ex.Message, "Error Login - 1001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            Con.Dispose();
            MessageBoxEx.Show("GoodBye", "Exit", 700);
            Application.Exit();
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ChangePass D = new ChangePass())
            {
                D.ShowDialog();
            }
        }

        /* Function */

        public void Edit_Ico(Button Value, string Value2, Image Value3)
        {
            Value.Text = Value2;
            Value.Image = Value3;
            Value.ImageAlign = ContentAlignment.TopLeft;
            Value.TextImageRelation = TextImageRelation.ImageBeforeText;
        }






        public void GetSer()
        {
            ManagementObjectSearcher MOS = new ManagementObjectSearcher("Select * FROM Win32_BaseBoard");
            foreach (ManagementObject getserial in MOS.Get().Cast<ManagementObject>())
            {
                BoardNum = getserial["SerialNumber"].ToString();
            }
            ManagementObjectSearcher MOS1 = new ManagementObjectSearcher("Select * FROM WIN32_BIOS");
            foreach (ManagementObject management in MOS1.Get().Cast<ManagementObject>())
            {
                BiosNum = management["SerialNumber"].ToString();
            }
        }


    }
}
