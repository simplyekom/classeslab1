using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classeslab1.Humans
{
    internal class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine(personId + ": " + firstName + " " + lastName + "'s" + " " + "favorite color is" + " " + favoriteColour);
        }

        public override string ToString() 
        {
            return ($"PersonId: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavoriteColour: {favoriteColour}\nAge: {age}\nIsWorking: {isWorking}");
        }

        public void ChangeFavoriteColour() 
        {
            favoriteColour = "White";
            Console.WriteLine(personId + ": " + firstName + " " + lastName + "'s" + " " + "favorite color is:" + " " + favoriteColour);
        }

        public void GetAgeInTenYears()
        {
            age = age + 10;
            Console.WriteLine(firstName + " " + lastName + "'s" + " Age in 10 year is: " + age);
        }

    }
}
