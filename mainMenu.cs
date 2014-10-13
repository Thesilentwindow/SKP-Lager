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
using System.Text.RegularExpressions;

namespace Lager_System
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        
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

        private void Index_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lagerDBDataSet1.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.lagerDBDataSet1.Users);
            // TODO: This line of code loads data into the 'lagerDBDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this.lagerDBDataSet.Items);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Items_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Close2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void validation()
        {
            bool validEmail;
            bool validfornavn;
            bool validefternavn;
            
            Regex emailValidation = new Regex(@" ^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.(?:[A-Z]{2}|com|org|net|edu|gov|mil|biz|info|mobi|name|aero|asia|jobs|museum)$");

            if(txtBox_Fornavn.Text == "")
            {
                MessageBox.Show("Indskriv kundens fornavn !");
                validfornavn = false;
            }else
            {
                validfornavn = true;
            }
            
            if(txtBox_Efternavn.Text == "")
            {
                MessageBox.Show("Indskriv kundens Efternavn !");
                validefternavn = false;
            }else
            {
                validefternavn = true;
            }
            if(txtBox_Email.Text == "")
            {
                validEmail = false;
            }
            if(emailValidation.IsMatch(txtBox_Email.Text))
            {
                
                validEmail = true;
                
            }
        }
        private void opret_Btn_Click(object sender, EventArgs e)
        {
            
                insert();

        }
        
        public void insert() //Denne method bruges til at indsætte bruger dataen fra felterne i vores Database.
        {
            bool insertSuccess; 
            
            
            SqlConnection con = new SqlConnection("user id=sa;" +
                                 "password=Andreas1212;server=LagerServer;" +
                                 "Trusted_Connection=no;" +
                                 "database=LagerDB;" +
                                 "connection timeout=10");
            
            string query = "INSERT INTO Users (" +
                            "Fornavn," + 
                            "Efternavn," +
                            "Unilogin," +
                            "Email," +
                            "TlfNr)" +
                            "VALUES ('" +
                            txtBox_Fornavn.Text + "','" +
                            txtBox_Efternavn.Text + "','" +
                            txtBox_Uni.Text + "','" +
                            txtBox_Email.Text + "','" +
                            txtBox_TlfNr.Text + "')";
            
            
                        
            SqlCommand queryInsert = new SqlCommand(query, con);
            SqlDataReader myReader;
            try //udføre og tester om bruger data er gemt i databasen, hvis den er successful så viser den "User Data Saved"
            {
                validation();
                con.Open();

                myReader = queryInsert.ExecuteReader(); //Her bliver insert into udført
                MessageBox.Show("User data saved"); // denne besked bliver vist ved udførelse
                while(myReader.Read()) //læser data
                {

                }
                insertSuccess = true;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                insertSuccess = false;
            }
            if(insertSuccess == true)
            {
                txtBox_Fornavn.Text = "";
                txtBox_Efternavn.Text = "";
                txtBox_Email.Text = "";
                txtBox_Uni.Text = "";
                txtBox_TlfNr.Text = "";
            }            
            
            

            
            
         



            
        }


    }
}
