using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListViewExample
{
    public partial class _Default : System.Web.UI.Page
    {

        protected override void OnPreRender(EventArgs e)
        {

            //(1) put data in custom objects
            
            Flight flight01 = new Flight("KL0010", "Berlin", "Frankfurt", 15);
            Flight flight02 = new Flight("GX0021", "München", "Berlin", 30);
            Flight flight03 = new Flight("FM0030", "Frankfurt", "New York", 35);
            Flight flight04 = new Flight("DH0048", "Shanghai", "Peking", 73);
            Flight flight05 = new Flight("TR0054", "Frankfurt", "New York", 72);
            Flight flight06 = new Flight("VG0560", "Sydney", "Christchurch", 99);
            Flight flight07 = new Flight("ER0577", "Los Angeles", "San Francisco", 25);
            Flight flight08 = new Flight("SW4508", "Frankfurt", "London", 71);
            Flight flight09 = new Flight("QR0909", "Sydney", "Hongkong", 123);
            Flight flight10 = new Flight("TG1055", "München", "Salzburg", 73);
            Flight flight11 = new Flight("HH0112","Berlin", "Hamburg", 28);
            Flight flight12 = new Flight("HZ0124", "Luxemburg", "Paris", 55);


            //(2) put custom objects in list
            
            List<Flight> flights = new List<Flight>();

            flights.Add(flight01);
            flights.Add(flight02);
            flights.Add(flight03);
            flights.Add(flight04);
            flights.Add(flight05);
            flights.Add(flight06);
            flights.Add(flight07);
            flights.Add(flight08);
            flights.Add(flight09);
            flights.Add(flight10);
            flights.Add(flight11);
            flights.Add(flight12);

            //(3) bind list to listview

            ListView adminDataListView = (ListView)this.FindControl("flightListView");
            adminDataListView.DataSource = flights;
            adminDataListView.DataBind();
        }

       
    }
}