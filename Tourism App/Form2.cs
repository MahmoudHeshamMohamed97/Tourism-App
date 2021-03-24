﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_App
{
    public partial class Form2 : Form
    {
        static bool fname = false;
        public static  int  ID = 0;
        static bool email = false;
        static bool password = false;
        static bool confirmPassword = false;
        static bool mobile = false;
        static bool address = false;
        static bool NationId = false;
        private static Data_Context _dbContext;
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //dataGridview Employee
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].HeaderText = "ID";

            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[1].HeaderText = "Name";

            dataGridView1.Columns[2].Name = "Gender";
            dataGridView1.Columns[2].HeaderText = "Gender";

            dataGridView1.Columns[3].Name = "Age";
            dataGridView1.Columns[3].HeaderText = "Age";

            dataGridView1.Columns[4].Name = "Email";
            dataGridView1.Columns[4].HeaderText = "Email";

            dataGridView1.Columns[5].Name = "Password";
            dataGridView1.Columns[5].HeaderText = "Password";

            dataGridView1.Columns[6].Name = "Phone";
            dataGridView1.Columns[6].HeaderText = "Phone";

            dataGridView1.Columns[7].Name = "IsAdmin";
            dataGridView1.Columns[7].HeaderText = "IsAdmin";

            dataGridView1.Columns[8].Name = "NationalID";
            dataGridView1.Columns[8].HeaderText = "NationalID";


            //dataGridview2 Journary
            dataGridView2.ColumnCount = 10;
            dataGridView2.Columns[0].Name = "ID";
            dataGridView2.Columns[0].HeaderText = "ID";

            dataGridView2.Columns[1].Name = "Title";
            dataGridView2.Columns[1].HeaderText = "Title";

            dataGridView2.Columns[2].Name = "Description";
            dataGridView2.Columns[2].HeaderText = "Description";

            dataGridView2.Columns[3].Name = "MaxNumber";
            dataGridView2.Columns[3].HeaderText = "MaxNumber";

            dataGridView2.Columns[4].Name = "TravelWay";
            dataGridView2.Columns[4].HeaderText = "TravelWay";

            dataGridView2.Columns[5].Name = "TicketCost";
            dataGridView2.Columns[5].HeaderText = "TicketCost";

            dataGridView2.Columns[6].Name = "NumOfDays";
            dataGridView2.Columns[6].HeaderText = "NumOfDays";

            dataGridView2.Columns[7].Name = "Location";
            dataGridView2.Columns[7].HeaderText = "Location";

            dataGridView2.Columns[8].Name = "Date";
            dataGridView2.Columns[8].HeaderText = "Date";

            dataGridView2.Columns[9].Name = "NumOfReservedChairs";
            dataGridView2.Columns[9].HeaderText = "NumOfReservedChairs";



            //Create Object from DtaContext
            _dbContext = new Data_Context();
            Database.SetInitializer<Data_Context>(new MigrateDatabaseToLatestVersion<Data_Context, Migrations.Configuration>());

            //read information Employee
            var Emp = (from s in _dbContext.Employees
                       select s).ToList();

             
            foreach (var item in Emp)
            {

                dataGridView1.Rows.Add(new String[] { item.ID.ToString(), item.Name, item.Gender, item.Age.ToString(), item.Email, item.Password, item.Phone, item.IsAdmin.ToString(), item.NationalID.ToString() });

            }


            //Read Information Journary 

            var Journ = (from s in _dbContext.Journeys
                       select s).ToList();


            foreach (var item in Journ)
            {

                dataGridView2.Rows.Add(new String[] { item.ID.ToString(), item.Title, item.Description, item.MaxNumber.ToString(), item.TravelWay, item.TicketCost.ToString(), item.NumOfDays.ToString(), item.Location, item.Date.ToString(),item.NumOfReservedChairs.ToString() });

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dbContext = new Data_Context();
            Database.SetInitializer<Data_Context>(new MigrateDatabaseToLatestVersion<Data_Context, Migrations.Configuration>());

            string Name = textBox2.Text.ToString();
            string Gendertxt = textBox3.Text.ToString();
            Gender gender= Gender.female;
            if(Gendertxt.ToLower()== "male")
            {
                gender = Gender.male;
            }
            int Age = int.Parse(textBox4.Text);
            string Email = textBox5.Text.ToString();
            string Password = textBox6.Text.ToString();
            string Phone = textBox7.Text.ToString();
            bool IsAdmin = checkBox1.Checked;
            string NationalID = textBox9.Text;

            

            Employee emp = new Employee()
            {

               Name=Name,
               Gender= gender,
               Age=Age,
               Email=Email,
               Password=Password,
               Phone=Phone,
               IsAdmin=IsAdmin,
               NationalID=NationalID




            };


            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();

            //show message  

            MessageBox.Show("Added Success ");


            //Clear Text

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            checkBox1.Checked = false;
            textBox9.Text = "";


            // clear datagridview and refresh 
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            //read all Data

            var Emp = (from s in _dbContext.Employees
                       select s).ToList();



            foreach (var item in Emp)
            {

                dataGridView1.Rows.Add(new String[] { item.ID.ToString(), item.Name, item.Gender, item.Age.ToString(), item.Email, item.Password, item.Phone, item.IsAdmin.ToString(), item.NationalID.ToString() });

            }



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update
            string Name = textBox2.Text.ToString();
            string Gender = textBox3.Text.ToString();
            int Age = int.Parse(textBox4.Text);
            string Email = textBox5.Text.ToString();
            string Password = textBox6.Text.ToString();
            string Phone = textBox7.Text.ToString();
            bool IsAdmin = checkBox1.Checked;
            string NationalID = textBox9.Text;

            //read all Data
            Employee D_Emp = (from s in _dbContext.Employees
                         where s.ID == ID
                         select s).FirstOrDefault();




            //Update Data

            D_Emp.Name = Name;
            D_Emp.Gender = Gender;
            D_Emp.Age = Age;
            D_Emp.Email = Email;
            D_Emp.Password = Password;
            D_Emp.Phone = Phone;
            D_Emp.IsAdmin = IsAdmin;
            D_Emp.NationalID = NationalID;

            _dbContext.SaveChanges();

            //show message  

            MessageBox.Show("Updated Success ");

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            checkBox1.Checked = false;
            textBox9.Text = "";

            // clear datagridview and refresh 
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            //read all Data

            var Emp = (from s in _dbContext.Employees
                       select s).ToList();


            foreach (var item in Emp)
            {

                dataGridView1.Rows.Add(new String[] { item.ID.ToString(), item.Name, item.Gender, item.Age.ToString(), item.Email, item.Password, item.Phone, item.IsAdmin.ToString(), item.NationalID.ToString() });

            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
          


           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Delete

            string Name = textBox2.Text.ToString();
            string Gender = textBox3.Text.ToString();
            int Age = int.Parse(textBox4.Text);
            string Email = textBox5.Text.ToString();
            string Password = textBox6.Text.ToString();
            string Phone = textBox7.Text.ToString();
            bool IsAdmin = checkBox1.Checked;
            string NationalID = textBox9.Text;

            //read all Data
            var D_Emp = (from s in _dbContext.Employees
                        where s.ID == ID
                        select s).FirstOrDefault();

            //Remove Data
            _dbContext.Employees.Remove(D_Emp);
            _dbContext.SaveChanges();

            //show message  

            MessageBox.Show("Deleted Success ");

            textBox2.Text="";
            textBox3.Text="";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            checkBox1.Checked = false;
            textBox9.Text = "";

            // clear datagridview and refresh 
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            //read all Data

            var Emp = (from s in _dbContext.Employees
                       select s).ToList();


            foreach (var item in Emp)
            {

                dataGridView1.Rows.Add(new String[] { item.ID.ToString(), item.Name, item.Gender, item.Age.ToString(), item.Email, item.Password, item.Phone, item.IsAdmin.ToString(), item.NationalID.ToString() });

            }



        }

        private void button8_Click(object sender, EventArgs e)
        {
           


            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 3)
            {
                lblvalidName.Text = "Your Name must at least 3 char";
                fname = false;
            }
            else
            {
                lblvalidName.Text = "";
                fname = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells["Name"].Value.ToString();
                textBox3.Text = row.Cells["Gender"].Value.ToString();
                textBox4.Text = row.Cells["Age"].Value.ToString();
                textBox5.Text = row.Cells["Email"].Value.ToString();
                textBox6.Text = row.Cells["Password"].Value.ToString();
                textBox7.Text = row.Cells["Phone"].Value.ToString();
                textBox9.Text = row.Cells["NationalID"].Value.ToString();
                ID= int.Parse(row.Cells["ID"].Value.ToString());

                if (row.Cells["IsAdmin"].Value.ToString()=="True")
                {

                    checkBox1.Checked = true;
                }
             


            }





        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                textBox11.Text = row.Cells["Title"].Value.ToString();
                textBox12.Text = row.Cells["Description"].Value.ToString();
                textBox13.Text = row.Cells["MaxNumber"].Value.ToString();
                textBox14.Text = row.Cells["TravelWay"].Value.ToString();
                textBox15.Text = row.Cells["TicketCost"].Value.ToString();
                textBox16.Text = row.Cells["NumOfDays"].Value.ToString();
                textBox17.Text = row.Cells["Location"].Value.ToString();
                textBox18.Text = row.Cells["Date"].Value.ToString();
                textBox19.Text = row.Cells["NumOfReservedChairs"].Value.ToString();

                ID = int.Parse(row.Cells["ID"].Value.ToString());
            }


            }

            private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!textBox5.Text.Contains('@'))
            {
                lblemailValid.Text = "Email must containt @";
                email = false;
            }
            else
            {
                lblemailValid.Text = "";
                email = true;
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text.Length <= 11)
            {
                LblPhoneValid.Text = "Last name must be 11 number";
                mobile = false;
            }
            else
            {
                LblPhoneValid.Text = "";
                mobile = true;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Journary Added
            _dbContext = new Data_Context();
            Database.SetInitializer<Data_Context>(new MigrateDatabaseToLatestVersion<Data_Context, Migrations.Configuration>());

            string Title = textBox11.Text.ToString();
            string Descrption =textBox12.Text.ToString();
            int Maxnumber = int.Parse(textBox13.Text);
            string Travalway = textBox14.Text.ToString();
            int tickectcost =int.Parse( textBox15.Text.ToString());
            int  NDay = int.Parse(textBox16.Text.ToString());
            string Location = textBox17.Text.ToString();
            DateTime dtime = DateTime.Parse(textBox18.Text.ToString());
            int numchair =int.Parse( textBox19.Text.ToString());



            Journey Jour = new Journey()
            {

                Title = Title,
                Description = Descrption,
                MaxNumber = Maxnumber,
                TravelWay = Travalway,
                TicketCost = tickectcost,
                NumOfDays = NDay,
                Location = Location,
                Date = dtime,
                NumOfReservedChairs = numchair
                



            };


            _dbContext.Journeys.Add(Jour);
            _dbContext.SaveChanges();

            //show message  

            MessageBox.Show("Added Success ");


            //Clear Text

            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";



            // clear datagridview and refresh 
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();


            //read all Data

            var Jo = (from s in _dbContext.Journeys
                       select s).ToList();



            foreach (var item in Jo)
            {

                dataGridView2.Rows.Add(new String[] { item.ID.ToString(), item.Title, item.Description, item.MaxNumber.ToString(), item.TravelWay, item.TicketCost.ToString(), item.NumOfDays.ToString(), item.Location, item.Date.ToString(), item.NumOfReservedChairs.ToString() });

            }




        }

        private void button6_Click(object sender, EventArgs e)
        {
            //delete Journary


            string Title = textBox11.Text.ToString();
            string Descrption = textBox12.Text.ToString();
            int Maxnumber = int.Parse(textBox13.Text);
            string Travalway = textBox14.Text.ToString();
            int tickectcost = int.Parse(textBox15.Text.ToString());
            int NDay = int.Parse(textBox16.Text.ToString());
            string Location = textBox17.Text.ToString();
            DateTime dtime = DateTime.Parse(textBox18.Text.ToString());
            int numchair = int.Parse(textBox19.Text.ToString());


            //read all Data
            var D_jour = (from s in _dbContext.Journeys
                         where s.ID == ID
                         select s).FirstOrDefault();

            //Remove Data
            _dbContext.Journeys.Remove(D_jour);
            _dbContext.SaveChanges();

            //show message  

            MessageBox.Show("Deleted Success ");

            //Clear Text

            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";

            // clear datagridview and refresh 
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            //read all Data

            var Emp = (from s in _dbContext.Journeys
                       select s).ToList();


            foreach (var item in Emp)
            {

                dataGridView2.Rows.Add(new String[] { item.ID.ToString(), item.Title, item.Description, item.MaxNumber.ToString(), item.TravelWay, item.TicketCost.ToString(), item.NumOfDays.ToString(), item.Location, item.Date.ToString(), item.NumOfReservedChairs.ToString() });

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Update Journary


            string Title = textBox11.Text.ToString();
            string Descrption = textBox12.Text.ToString();
            int Maxnumber = int.Parse(textBox13.Text.ToString());
            string Travalway = textBox14.Text.ToString();
            int tickectcost = int.Parse(textBox15.Text.ToString());
            int NDay = int.Parse(textBox16.Text.ToString());
            string Location = textBox17.Text.ToString();
            DateTime dtime = DateTime.Parse(textBox18.Text.ToString());
            int numchair = int.Parse(textBox19.Text.ToString());


            //read all Data
            var D_jour = (from s in _dbContext.Journeys
                          where s.ID == ID
                          select s).FirstOrDefault();

            //Update Data

            D_jour.Title = Title;
            D_jour.Description = Descrption;
            D_jour.MaxNumber = Maxnumber;
            D_jour.TravelWay = Travalway;
            D_jour.TicketCost = tickectcost;
            D_jour.NumOfDays = NDay;
            D_jour.Location = Location;
            D_jour.Date = dtime;
            D_jour.NumOfReservedChairs = numchair;

            _dbContext.SaveChanges();

            //show message  

            MessageBox.Show("Updated Success ");

            //Clear Text

            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";

            // clear datagridview and refresh 
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            //read all Data

            var Emp = (from s in _dbContext.Journeys
                       select s).ToList();


            foreach (var item in Emp)
            {

                dataGridView2.Rows.Add(new String[] { item.ID.ToString(), item.Title, item.Description, item.MaxNumber.ToString(), item.TravelWay, item.TicketCost.ToString(), item.NumOfDays.ToString(), item.Location, item.Date.ToString(), item.NumOfReservedChairs.ToString() });

            }


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text.Length <= 14)
            {
                lblNationValid.Text = "Last name must be 14 num";
                NationId = false;
            }
            else
            {
                lblNationValid.Text = "";
                NationId = true;
            }
        }
    }
}