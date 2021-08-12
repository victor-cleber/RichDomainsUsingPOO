using System;
using System.Collections.Generic;

namespace RichDomainsUsingPOO.Domain {
    public class Customer : Base {
        public string FirstName{
            get; set;
        }

        public string LastName {
            get; set;
        }

        public Int64 Document{
            get; set;
        }

        public string Email{
            get; set;
        }
        public DateTime BirthDate {
            get; set;
        }
        public List<Address> Address{
            get; set;
        }

        public List<Phone> Phone{
            get; set;
        }

        public string FullName {
            get {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(LastName)) {
                    //fullName = string.Concat(' ', LastName); 
                    fullName = $"{FirstName} {LastName}";
                }
                return fullName;
            }
        }

        public override string ToString() => $"Complete Name: {FullName} E-mail: {Email} Birth Date {BirthDate}";

        public override bool Validate() {
            return !string.IsNullOrWhiteSpace(FullName);
        }
    }
}
