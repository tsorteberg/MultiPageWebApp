/***************************************************************
* Name        : Contact.cs
* Author      : Tom Sorteberg
* Created     : 02/07/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 2 Topic 3
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using System.ComponentModel.DataAnnotations;

namespace MultiPageWebApp.Models
{
    public class Contact
    {
        // Primary Key Attribute.
        public int ContactId { get; set; }

        // Required Attributes.
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string Phone { get; set; }

        // Nullable Attributes.
        public string Address { get; set; }

        public string Note { get; set; }
    }
}
