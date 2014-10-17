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
using System.Net.Mail;
using System.Configuration;

namespace Lager_System
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        
        //private const int CP_NOCLOSE_BUTTON = 0x200;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams myCp = base.CreateParams;
        //        myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
        //        return myCp;
        //    }
        //}

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


        private void btn_Close2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool validFornavn()
        {
            if (txtBox_Fornavn.Text == "")
            {
                MessageBox.Show("Indskriv kundens fornavn !");
                return false;
            }else
            {
                return true;
            }

        }//method til at validere om feltet er tomt
        
        private bool validEfternavn()
        {
            if (txtBox_Efternavn.Text == "")
            {
                MessageBox.Show("Indskriv kundens fornavn !");
                return false;
            }else
            {
                return true;
            }

        }//method til at validere om feltet er tomt

        private bool validEmail()
        {
            bool isValid = false;
            try
            {
                var email = new MailAddress(txtBox_Email.Text);
                isValid = true;
            }
            catch
            {
                MessageBox.Show("Invalid Email");
                isValid = false;
            }
            if(isValid != true)
            {
                return false;
            }else
            {
                return true;
            }

        }//method til at validere om det er en rigtig Email

        private bool validTlfNr()
        {
            int number;
            bool isValidNumber;
            if(int.TryParse(txtBox_TlfNr.Text, out number))
            {
                isValidNumber = true;
            }else
            {
                isValidNumber = false;
            }

            if(isValidNumber != true)
            {
                return false;
            }else
            {
                return true;
            }
        }//method til at validere om det er numre der indtastes

        private void opret_Btn_Click(object sender, EventArgs e)
        {
                         
                insert();
            
        }

        
        private void insert() //Denne method bruges til at indsætte bruger dataen fra felterne i vores Database.
        {
            bool insertSuccess;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Lager_System.Properties.Settings.LagerDBConnectionString"].ConnectionString);
            //SqlConnection con = new SqlConnection("user id=sa;" +
            //                     "password=Andreas1212;server=LagerServer;" +
            //                     "Trusted_Connection=no;" +
            //                     "database=LagerDB;" +
            //                     "connection timeout=10");
            
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
            if (validEmail() == true && validEfternavn() == true && validFornavn() == true && validTlfNr() == true)
            {
                try //udføre og tester om bruger data er gemt i databasen, hvis den er successful så viser den "User Data Saved"
                {

                    con.Open();

                    myReader = queryInsert.ExecuteReader(); //Her bliver insert into udført
                    MessageBox.Show("User data saved"); // denne besked bliver vist ved udførelse
                    while (myReader.Read()) //læser data
                    {

                    }
                    insertSuccess = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    insertSuccess = false;
                }
                if (insertSuccess == true)
                {
                    txtBox_Fornavn.Text = "";
                    txtBox_Efternavn.Text = "";
                    txtBox_Email.Text = "";
                    txtBox_Uni.Text = "";
                    txtBox_TlfNr.Text = "";
                }            
            }else
            {
                MessageBox.Show("U r rong, git rekt m8");
            }
            con.Close();
        }

        private void AddItemToDb()
        {
            bool AddSuccess;
            int itemIdInt;
            int itemAmountInt;
            itemAmountInt = Convert.ToInt32(itemAmount_txtBox.Text);
            itemAmountInt = int.Parse(itemAmount_txtBox.Text);
            itemIdInt = Convert.ToInt32(itemID_txtBox.Text);
            itemIdInt = int.Parse(itemID_txtBox.Text);

            string addItemConnectionString = ConfigurationManager.ConnectionStrings["Lager_System.Properties.Settings.LagerDBConnectionString"].ConnectionString;
            SqlConnection dbConn = new SqlConnection(addItemConnectionString);
            SqlCommand queryAddItem = new SqlCommand(addItemConnectionString, dbConn);
            SqlDataReader myReader;
            string addItem = "INSERT INTO Items (" +
                            "ItemID," +
                            "ItemName," +
                            "Amount," +
                            "Category," +
                            "SubCategory," +
                            "Location," +
                            "Description,)" +
                            "VALUES ('" +
                            itemIdInt + "','" +
                            itemName_txtBox.Text + "','" +
                            itemAmountInt + "','" +
                            //itemCategory_txtBox.Text + "','" +
                            //itemSubCategory_txtBox.Text + "','" +
                            itemLocation_txtBox.Text + "','" + 
                            itemDescription_txtBox.Text + "' )";
            try 
            {

                dbConn.Open();

                myReader = queryAddItem.ExecuteReader(); //Her bliver insert into udført
                MessageBox.Show("User data saved"); // denne besked bliver vist ved udførelse
                while (myReader.Read()) //læser data
                {

                }
                AddSuccess = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                AddSuccess = false;
            }
            if(AddSuccess == true)
            {
                //itemID_txtBox.Text = "";
                itemName_txtBox.Text = "";
                //itemAmount_txtBox.Text = "";
                //itemCategory_txtBox.Text = "";
                //itemSubCategory_txtBox.Text = "";
                itemLocation_txtBox.Text = "";
                itemDescription_txtBox.Text = "";
            }else
            {
                MessageBox.Show("Something went wrong");
            }
            dbConn.Close();
        }

              
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ShowGroup_Click(object sender, EventArgs e)
        {
            add_ItemGroup.Visible = true;
            btn_ShowGroup.Visible = false;
        }

        private void btn_GrpMenuClose_Click(object sender, EventArgs e)
        {
            add_ItemGroup.Visible = false;
            btn_ShowGroup.Visible = true;
        }

        private void btn_CanelItemAdd_Click(object sender, EventArgs e)
        {
            btn_ShowGroup.Visible = true;
            add_ItemGroup.Visible = false;

        }

        private void btn_showUsers_Click(object sender, EventArgs e)
        {
            userDataGrid.Visible = true;
            btn_showUsers.Visible = false;
            btn_hideUsers.Visible = true;
        }

        private void btn_hideUsers_Click(object sender, EventArgs e)
        {
            userDataGrid.Visible = false;
            btn_showUsers.Visible = true;
            btn_hideUsers.Visible = false;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {

        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            AddItemToDb();
        }

        private void categoryMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.categoryMenu.GetItemText(this.categoryMenu.SelectedItem);
            if (selected == "Hardware" || selected == "Software" || selected == "Bøger" || selected == "Netværk" || selected == "Andet")
            {
                subCategoryMenu.Enabled = true;
            }

        }

        private void mainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



    }
}
