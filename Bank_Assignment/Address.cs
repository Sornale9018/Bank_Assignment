using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Address
    {
        private string roadNo;
        private string houseNo;
        private string city;
        private string country;

        public Address()
        {
            //this.houseNo = houseNo;
            //this.roadNo = roadNo;
            //this.city = city;
            //this.country = country;

        }
        public string HouseNo
        {
            set { this.houseNo = value; }
            get { return this.houseNo; }
        }
        public string RoadNo
        {
            set { this.roadNo = value; }
            get { return this.roadNo; }
        }

        public string City
        {
            set { this.city = value; }
            get { return this.city; }
        }

        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }
        public string GetAddress()
        {
            string x = "Road No=" + roadNo + "," + "House No=" + houseNo + "," + "City=" + city + "," + "Country=" + country;
            Console.WriteLine("Address:House No-{0},Road No-{1},City-{2},Country-{3}", this.houseNo, this.roadNo, this.city, this.country);
            return x;
        }

    }
}
