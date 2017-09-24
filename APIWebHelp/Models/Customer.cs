using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIWebHelp.Models
{
    /// <summary>
    /// All operations related to Customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// First name of the customer
        /// <![CDATA["Omer"]]>
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the customer
        /// <c>"Tahir"</c>
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// ID assigned at the time of sign-up
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Date of Birth of the Customer
        /// </summary>
        public DateTime DateofBirth { get; set; }

        /// <summary>
        /// Current residential address of the customer. Include City and Country
        /// </summary>
        public string Address { get; set; }
    }
}