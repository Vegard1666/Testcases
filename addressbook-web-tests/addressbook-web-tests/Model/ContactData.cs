﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookWebTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string allPhones;

        public ContactData(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;            
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return Firstname == other.Firstname &&
                   Lastname == other.Lastname;
        }

        public override int GetHashCode()
        {
            return (Firstname + " " + Lastname).GetHashCode();
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            int result = Lastname.CompareTo(other.Lastname);
            if (result != 0)
            {
                return result;
            }
            else
            {
                return Firstname.CompareTo(other.Firstname);
            }
                        
        }

        public string Firstname { get; set; }
       
        public string Lastname { get; set; }
        
        public string Middlename { get; set; }
        
        public string Nickname { get; set; }

        public string Title { get; set; }
                
        public string Address { get; set; }
       
        public string Home { get; set; }
       
        public string Mobile { get; set; }

        public string AllPhones 
        { 
            get 
            {
                if (allPhones != null)
                {
                    return allPhones;
                }
                else
                {
                    return (CleanUp(Home) + CleanUp(Mobile) + CleanUp(Work)).Trim();
                }
            } 
            set 
            {
                allPhones = value;
            } 
        }

        private string CleanUp(string phone)
        {
            if (phone == null || phone == "")
            {
                return "";
            }
            return phone.Replace(" ", "").Replace("-", "").Replace("(", "").Replace(")", "") + "\r\n";            
        }

        public string Work { get; set; }

        public string Fax { get; set; }

        public string Email { get; set; }

        public string Byear { get; set; }

        public string Company { get; set; }

        public string Ayear { get; set; }
        
        public string Address2 { get; set; }

        public string Notes { get; set; }        
    }
}
