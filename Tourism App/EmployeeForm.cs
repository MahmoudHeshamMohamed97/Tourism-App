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
            IEnumerable<Journey> journeys = from j in Program._dbContext.Journeys
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
    }
}
