using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourism_App
{
    public partial class Booked : Form
    {
        Data_Context Context = new Data_Context();
        Passenger p = new Passenger();
        int Passenger_ID;
        Reserve R = new Reserve();
        public int Journeys_id;
        int avilable;
        public Booked()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Name = textBox1.Text;
            p.Age = int.Parse(textBox2.Text);
            p.Phone = textBox3.Text;
            p.NationalID = textBox4.Text;

            // Context.Passengers.Add(p);
            //Context.SaveChanges();

            Passenger_ID = p.ID;
            R.JourneyID = 1;
            R.PassengerID = Passenger_ID;
            R.NumOfTickets = int.Parse(textBox5.Text);
            R.EmployeeID = LoginForm.EmpID;
            //R.Passenger = p;

            // Context.Reserves.Add(R);
            Journey J = (from j in Context.Journeys
                         where j.ID == 1
                         select j).FirstOrDefault();
            avilable = J.MaxNumber - J.NumOfReservedChairs;
            if (avilable < int.Parse(textBox5.Text))
            {
                MessageBox.Show("Number of Tickets are more than avilable \n avilable= " + avilable);
            }
            else
            {
                Context.Passengers.Add(p);
                Context.SaveChanges();
                J.NumOfReservedChairs += int.Parse(textBox5.Text);
                R.PassengerID = p.ID;
                Context.Reserves.Add(R);
                Context.SaveChanges();
                MessageBox.Show("Booked Done");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.EmptyString(textBox1.Text))
            {
                if (Validation.NameValidation(textBox1.Text))
                {
                    label6.Text = "";
                    label6.Visible = false;
                }
                else
                {
                    label6.Text = " invalid Name format";
                    label6.Visible = true;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.EmptyString(textBox2.Text))
            {
                label7.Text = "";
                label7.Visible = false;
            }

            else
            {
                label7.Text = " requird";
                label7.Visible = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.EmptyString(textBox3.Text))
            {
                if (Validation.MobileValidation(textBox3.Text))
                {
                    label5.Text = "";
                    label5.Visible = false;
                }
                else
                {
                    label5.Text = " invalid Mobile format";
                    label5.Visible = true;
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!Validation.EmptyString(textBox4.Text))
            {
                if (Validation.NationalIDValidation(textBox4.Text))
                {
                    label8.Text = "";
                    label8.Visible = false;
                }
                else
                {
                    label8.Text = " invalid National ID";
                    label8.Visible = true;
                }
            }
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
