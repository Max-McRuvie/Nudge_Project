using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NVS_Project.Models
{
    public class userDetails
    {
         public int studentID { get; set; }
        
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string gender { get; set; }

        public DateTime DOB { get; set; }
       
        public string institutionName { get; set; }

        public string course { get; set; }

        public string gradYear { get; set; }





            public userDetails()
    {

        Regex r = new Regex("^[a-zA-Z]+$");
        Regex n = new Regex("[^0-9]");


        //no entries can be blank
        if (string.IsNullOrEmpty(this.studentID.ToString()))
        {
            Console.WriteLine("Student ID cannot be blank");
        }
        
        if (string.IsNullOrEmpty(this.firstName))
        {
            Console.WriteLine("First name cannot be blank");
        }

        if(string.IsNullOrEmpty(this.lastName))
        {
            Console.WriteLine("Last name cannot be blank");
        }

        if(string.IsNullOrEmpty(this.gender))
        {
            Console.WriteLine("Gender cannot be blank");
        }

        if(string.IsNullOrEmpty(this.DOB.ToString()))
        {
            Console.WriteLine("Date of Birth cannot be blank");
        }

        if(string.IsNullOrEmpty(this.institutionName))
        {
            Console.WriteLine("Institution name cannot be blank");
        }

        if(string.IsNullOrEmpty(this.course))
        {
            Console.WriteLine("Course name cannot be blank");
        }

        if(string.IsNullOrEmpty(this.gradYear))
        {
            Console.WriteLine("Graduation year cannot be blank");
        }



        //if first name or last name contains anything other than letters
        if (!r.IsMatch(this.firstName))
        {
            Console.WriteLine("Name must only contain letters");
        }

        if (!r.IsMatch(this.lastName))
        {
            Console.WriteLine("Last name must only contain letters");
        }



        //Student ID only contains numbers
        if (!n.IsMatch(this.studentID))
        {
            Console.WriteLine("Student ID must only contain numbers");
        }
    }
        


        

        
    }





    







}

    