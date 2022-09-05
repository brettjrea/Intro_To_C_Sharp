using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotManager
{
    public class robot
    {
        private int robotID;
        private string company;
        private string sector;
        private string model;
        private int arms;
        private string mobility;
        private string legs;
        private string vision;
        private string hearing;
        private string intelligence;
        private string specialty;
        private int quantity;
        private decimal price;

        public robot()
        {
        }

        public robot(int robotID, string company, string sector, string model, int arms, string mobility, string legs, string vision, string hearing, string intelligence, string specialty, int quantity, decimal price)
        {
            this.robotID = robotID;
            this.company = company;
            this.sector = sector;
            this.model = model;
            this.arms = arms;
            this.mobility = mobility;
            this.legs = legs;
            this.vision = vision;
            this.hearing = hearing;
            this.intelligence = intelligence;
            this.specialty = specialty;
            this.quantity = quantity;
            this.price = price;
        }

        public int RobotID
        {
            get
            {
                return robotID;
            }
            set
            {
                robotID = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }

        public string Sector
        {
            get
            {
                return sector;
            }
            set
            {
                sector = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        public int Arms
        {
            get
            {
                return arms;
            }
            set
            {
               arms = value;
            }
        }

        public string Mobility
        {
            get
            {
                return mobility;
            }
            set
            {
                mobility = value;
            }
        }
        public string Legs
        {
            get
            {
                return legs;
            }
            set
            {
               legs = value;
            }
        }

        public string Vision
        {
            get
            {
                return vision;
            }
            set
            {
                vision = value;
            }
        }
        public string Hearing
        {
            get
            {
                return hearing;
            }
            set
            {
               hearing = value;
            }
        }
        public string Intelligence 
        {
            get
            {
                return intelligence;
            }
            set
            {
                intelligence = value;
            }
        }

        public string Specialty
        {
            get
            {
                return specialty;
            }
            set
            {
                specialty = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public string GetDisplayText()
        {
            return " Company: " + company + "  Sector:  " + sector + "  Model:  " + model;
        }
        public string GetValues()
        {
            return robotID + company + sector + model + arms + mobility + legs + vision + hearing + intelligence + specialty + quantity + price;
        }
    }
}