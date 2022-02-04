using System;

namespace Lec_2_2_22
{   public class Person//public class name is person
    {
        //introduce characteristics of Person
        public string firstName;
        public string lastname;
        public int age;
        public double weight;
        private string id;

        public Person()
        {

        }
        public Person(string firstName, string l, int age, double w, string id)//can rename variables
        {   //creates new person
            this.firstName = firstName;
            this.lastname = l;
            this.age = age;
            this.weight = w;
            this.id = id;
        }
        public string GetPersonInfo()//return stringed message from below
        {
            string message = string.Format("name:{0} {1}, age:{2}, weight:{3:F2}, id{4}", this.firstName, this.lastname, this.age, this.weight);// change to "this". Refers to all subjects
            return message;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //assign values to variables
            int age;//computer creates aka simple
            age = 20;
            //Person oneP;//Defined Person//Person is class oneP is object
            //oneP = new Person();//created Person// oneP is complex variable

            Person annP;
            annP = new Person("ann", "ha", 21, 110, "10090");// creates Person


           // annP.firstName//input in immediate to get info

            //oneP.firstName = "Ann";//assign to fied
            //oneP.lastname = "Ha";
            //oneP.age = 20;
            //oneP.weight = 110;

            //Person adamP = new Person();
            //adamP.firstName = "Adam";
            //adamP.lastname = "Pearson";
            //adamP.age = 24;
            //adamP.weight = 150;


            //string message = string.Format("name:{0} {1}, age:{2}, weight:{3:F2}", oneP.firstName, oneP.lastname, oneP.age, oneP.weight);//assigned array numbers to input// F2 keeps 2 digits
            //string message;
            //message = adamP.GetPersonInfo();//calls Adam's info
            //Console.WriteLine(message);

            string newmessage = annP.GetPersonInfo();
            Console.WriteLine(newmessage);// print out annP info

           // Console.WriteLine(annP.id);//not accessible outside of class
        }
    }
}
