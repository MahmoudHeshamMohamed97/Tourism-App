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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // Insert Filterations into Combo Boxes

            //List<string> TravelWayList = new List<string>();
            //TravelWayList.Add("");
            //TravelWayList.Add(Type.Bus.ToString());
            //TravelWayList.Add(Type.Plane.ToString());

            //List<string> numOfDaysList = new List<string>();
            //numOfDaysList.Add("");
            //numOfDaysList.Add("1-3");
            //numOfDaysList.Add("3-7");
            //numOfDaysList.Add("7-15");

            IEnumerable<string> TravelWayList = from t in Program._dbContext.Journeys
                                                select t.TravelWay.ToString();
            TravelWayList = TravelWayList.Distinct().ToList();
            List<string> TravelWayListUpdated = new List<string>();
            TravelWayListUpdated.Add("");
            TravelWayListUpdated.AddRange(TravelWayList);


            IEnumerable<string> numOfDaysList = from numofdays in Program._dbContext.Journeys
                                             select numofdays.NumOfDays.ToString();
            numOfDaysList = numOfDaysList.Distinct().ToList();
            List<string> numOfDaysListUpdated = new List<string>();
            numOfDaysListUpdated.Add("");
            numOfDaysListUpdated.AddRange(numOfDaysList);



            IEnumerable<string> LocationsList = from l in Program._dbContext.Journeys
                                                select l.Location;
            LocationsList = LocationsList.Distinct().ToList();
            List<string> LocationsListUpdated = new List<string>();
            LocationsListUpdated.Add("");
            LocationsListUpdated.AddRange(LocationsList);


            IEnumerable<string> DateList = from d in Program._dbContext.Journeys
                                             select d.Date.ToString();
            DateList = DateList.Distinct().ToList();
            List<string> DateListUpdated = new List<string>();
            DateListUpdated.Add("");
            DateListUpdated.AddRange(DateList);

            cmb_Date.DataSource = DateListUpdated;
            cmb_location.DataSource = LocationsListUpdated;
            cmb_numOfDays.DataSource = numOfDaysListUpdated;
            cmb_travelWay.DataSource = TravelWayListUpdated;


            // Insert Jouneys into DataGridView
            IEnumerable< Journey > journeys = from j in Program._dbContext.Journeys
                                               where (j.MaxNumber - j.NumOfReservedChairs) > 0
                                               select j;


            data_Journeys.ColumnCount = 7;

            data_Journeys.Columns[0].HeaderText = "Title";
            data_Journeys.Columns[0].Name = "Title";

            data_Journeys.Columns[1].HeaderText = "Description";
            data_Journeys.Columns[1].Name = "Description";

            data_Journeys.Columns[2].HeaderText = "Travel Way";
            data_Journeys.Columns[2].Name = "TravelWay";

            data_Journeys.Columns[3].HeaderText = "Cost";
            data_Journeys.Columns[3].Name = "TicketCost";

            data_Journeys.Columns[4].HeaderText = "Duration";
            data_Journeys.Columns[4].Name = "NumOfDays";

            data_Journeys.Columns[5].HeaderText = "Start Date";
            data_Journeys.Columns[5].Name = "Date";

            data_Journeys.Columns[6].HeaderText = "Available Seats";
            data_Journeys.Columns[6].Name = "AvailableSeats";



            foreach (var item in journeys)
            {
                data_Journeys.Rows.Add(new string[]
                {
                    item.Title,
                    item.Description,
                    item.TravelWay.ToString(),
                    item.TicketCost.ToString(),
                    item.NumOfDays.ToString(),
                    item.Date.ToString(),
                    (item.MaxNumber - item.NumOfReservedChairs).ToString()
                });
                //data_Journeys.Columns[0] = item.Title;
                //data_Journeys.Columns[1] = item.Description;
                //data_Journeys.Columns[2] = item.TravelWay;
                //data_Journeys.Columns[3] = item.TicketCost;
                //data_Journeys.Columns[4] = item.NumOfDays;
                //data_Journeys.Columns[5] = item.Date;
                //data_Journeys.Columns[6] = (item.MaxNumber - item.NumOfReservedChairs);

            }

        }

        private void data_Journeys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void data_Journeys_MouseEnter(object sender, EventArgs e)
        {

        }

        private void data_Journeys_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void data_Journeys_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_book.Visible = true;

        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            /*
                Transfer the num of seats available to roqaia's page and display it
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int budget = 0;
            if (int.TryParse(txt_budget.Text, out budget) || txt_budget.Text == "")
            {
                lbl_budget.Visible = false;
                IEnumerable<Journey> journeys = from j in Program._dbContext.Journeys
                                                select j;

                
                if( cmb_travelWay.SelectedItem.ToString() != "")
                    journeys = journeys.Where(j => j.TravelWay.ToString() == cmb_travelWay.SelectedItem.ToString());
                
                if( cmb_location.SelectedItem.ToString() != "" )
                    journeys = journeys.Where(j => j.Location == cmb_location.SelectedItem.ToString());

                if( cmb_numOfDays.SelectedItem.ToString() != "" )
                    journeys = journeys.Where(j => j.NumOfDays.ToString() == cmb_numOfDays.SelectedItem.ToString());

                if( cmb_Date.SelectedItem.ToString() != "" )
                    journeys = journeys.Where(j => j.Date == DateTime.Parse(cmb_Date.SelectedItem.ToString())  );

                

                if (budget > 0)
                    journeys = journeys.Where( j => j.TicketCost <= budget );


                data_Journeys.Rows.Clear();
                foreach (var item in journeys)
                {
                    data_Journeys.Rows.Add(new string[]
                    {
                        item.Title,
                        item.Description,
                        item.TravelWay.ToString(),
                        item.TicketCost.ToString(),
                        item.NumOfDays.ToString(),
                        item.Date.ToString(),
                        (item.MaxNumber - item.NumOfReservedChairs).ToString()
                    });
                }


            }
            else
                lbl_budget.Visible = true;
        }
    }
}
