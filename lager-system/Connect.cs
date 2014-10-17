using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.Configuration;

namespace Lager_System
{
    public partial class Connect : Form
    {
        private string _Connstring = System.Configuration.ConfigurationManager.ConnectionStrings["lagerConn"].ToString();

        public Connect()
        {
            InitializeComponent();
        }

        private const int CP_NOCLOSE_BUTTON = 0x200; //#OVERRIDE Denne override slår Den røde kryds knap fra, det har vi gjort af den grund at når mainMenu formen bliver åbnet og man trykker på kryds knappen lukker det ikke hele processen med Connect.cs og mainMenu.cs.
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        
        // Denne "button" tilslutter os til vores Database
        private void button1_Click(object sender, EventArgs e)
        {
            Con();
        }

        public void Con()
        {

            string userName = userNameBox.Text;
            string passWord = passWordBox.Text;
            var userID = userName;
            var password = passWord;
            bool loginFail;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["lagerConn"].ConnectionString);

            builder.UserID = userID;
            builder.Password = password;

            SqlConnection Conn = new SqlConnection(builder.ConnectionString);

            try
            {
                Conn.Open();
                loginFail = false;
                Conn.Close();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                loginFail = true;
            }
            if(loginFail == false) //If login is successful it will change to the next form and hide the Connect form
            {
                mainMenu secondForm = new mainMenu();
                loginFail = false;
                secondForm.Show();
                this.Hide();
            
            }
            
        }

        private void userNameBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passWordBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Connect_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
                        

       
        }

        private void passWordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void userNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    }
}
