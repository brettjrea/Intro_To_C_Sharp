using System.Collections.Generic;

namespace RobotManager
{
    public class RobotList
    {
        private List<robot> robotsList;

        public RobotList()
        {
            robotsList = new List<robot>();
        }

        public int Count
        {
            get
            {
                return robotsList.Count;
            }
        }
        public robot GetRobotByIndex(int i)
        {
            return robotsList[i];
        }

        public void Add(robot robot)
        {
            robotsList.Add(robot);
        }

        public void Add(int robotID, string company, string sector, string model, int arms, string mobility, string legs, string vision, string hearing, string intelligence, string specialty, int quantity, decimal price)
        {
            robot i = new robot(robotID, company, sector, model, arms, mobility, legs, vision, hearing, intelligence, specialty, quantity, price);
            robotsList.Add(i);
        }
     
        public void Remove(robot robot)
        {
            robotsList.Remove(robot);
        }

        public void Fill()
        {
            robotsList = RobotStorage.GetRobots();
        }

        public void Save()
        {
            RobotStorage.SaveRobots(robotsList);
        }
    }
}