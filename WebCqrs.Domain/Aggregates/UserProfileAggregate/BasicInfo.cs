using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCqrs.Domain.Aggregates.UserProfileAggregate
{
    public class BasicInfo
    {
        public BasicInfo() { 
            
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string EmailAddress { get; private set; }
        public string Phone { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string CurrentCity { get; private set; }


        // Factory method
        public static BasicInfo CreatedBasicInfo(
            string firstName,
            string lastName,
            string phone,
            DateTime dateOfBirth,
            string currentCity)
        {
            return new BasicInfo()
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                DateOfBirth = dateOfBirth,
                CurrentCity = currentCity
            };
        }

        // public methods


    }
}
