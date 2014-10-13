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

namespace Lager_System
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
        }
       //#OVERRIDE Denne override slår Den røde kryds knap fra, det har vi gjort af den grund at når mainMenu formen bliver åbnet og man trykker på kryds knappen lukker det ikke hele processen med Connect.cs og mainMenu.cs.
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
       //#OVERRIDE
        
        // Denne "button" tilslutter os til vores Database
        private void button1_Click(object sender, EventArgs e)
        {
            
            //backgroundWorker1.RunWorkerAsync();
            //this.button1.Enabled = false;
            Con();
            
        }

        public void Con()
        {

            bool loginFail;
            SqlConnection Conn = new SqlConnection("user id=" + userNameBox.Text + ";" +
                                 "password=" + passWordBox.Text + ";server=LagerServer;" +
                                 "Trusted_Connection=no;" +
                                 "database=LagerDB; " +
                                 "connection timeout=10");


            try
            {
                Conn.Open();
                Conn.Close();
                loginFail = false;
            }catch
            {
                MessageBox.Show("Failed to login");
                loginFail = true;
            }
            if(loginFail == false)
            {
                mainMenu secondForm = new mainMenu();
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
