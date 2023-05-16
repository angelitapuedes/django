using System;
using System.Threading.Tasks;


namespace ObjectOriented
{
    class Customer
    {
        //Private variables
        /*Only can be referred to inside of this class
         To use these then you would call methods that would
         call the values*/
        private int savings = 0;
        private int ssn = 0;
        private string actName = "";
        private string gender = "";

        //Constructor
        /*In this constructor you would intialize the value
         and assign them to these variables once you create an dobject
         it will call this constructor to perform this*/
        public Customer(int savings, int ssn, string actName, string gender)
        {
            //This is referring to itself
            this.savings = savings;
            this.ssn = ssn;
            this.actName = actName;
            this.gender = gender;

        }
        //Getters for Encapsulation
        //Encapsulation to make sure you are not changing the variables by using
        //This method by using the setters and getters and keeping the
        //variables private
        public string getName()
        {
            return this.actName;
        }
        public int getSavings()
        {
            return this.savings;
        }
        public int getSSN()
        {
            return this.ssn;
        }
        public string getGender()
        {
            return this.gender;
        }

        //Setters by using Encapsulation
        public void setName(string name)
        {
            this.actName = name;
        }
        public void setSavings(int amount)
        {
            this.savings = amount;
        }
        public void addMoney(int amount)
        {
            this.savings += amount;
        }
        public void removeMoney(int negamount)
        {
            this.savings -= negamount;
        }
        public void setSSN(int soc)
        {
            this.ssn = soc;
        }
        public string toString()
        {
            return "Name:" +getGender()+ this.actName + ", Savings $" + this.savings + ", Social Security Number " + this.ssn;
        }
    }
}
