using System;

namespace ACM.BL
{
    public class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get { return firstName + "," + lastName; }
        }
    }
}
