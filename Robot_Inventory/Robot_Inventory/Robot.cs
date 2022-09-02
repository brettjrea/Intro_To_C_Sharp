using System;
using System.Management.Instrumentation;

namespace Robot_Inventory
{
    class Robot
    {
        // Constructor
        public Robot()
        {
            Company = "";
            Sector = "";
            Model = "";
            Arms = 0;
            Mobility = "";
            Legs = "";
            Vision = "";
            Hearing = "";
            Intelligence = "";
            Specialty = "";
            Price = 0m;
            Quantity = 0;
        }
        // Company property
        public string Company { get; set; }
        // Sector property
        public string Sector { get; set; }
        // Model property
        public string Model { get; set; }
        // Arms property
        public int Arms { get; set; }
        // Mobility property
        public string Mobility { get; set; }
        // Legs property
        public string Legs { get; set; }
        // Vision property
        public string Vision { get; set; }
        // Hearing property
        public string Hearing { get; set; }
        // Intelligence property
        public string Intelligence { get; set; }
        // Specialty property
        public string Specialty { get; set; }
        // Price property
        public decimal Price { get; set; }
        // Arms property
        public int Quantity { get; set; }

        public string GetListing
        {
            get { return string.Format(Company + " " +Sector); }
        }
    }
 
}