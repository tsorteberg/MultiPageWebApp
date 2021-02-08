/***************************************************************
* Name        : ContactContext.cs
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
using Microsoft.EntityFrameworkCore;

namespace MultiPageWebApp.Models
{
    public class ContactContext : DbContext
    {
        // Default constructor.
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        { }

        // Create Contacts Table using Contact.cs model.
        public DbSet<Contact> Contacts { get; set; }

        // Initial seed.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().HasData(
                new Contact {
                    ContactId = 1,
                    Name = "Alfred E Neuman",
                    Phone = "800-462-3624",
                    Address = "MAD Magazine, PO Box 8537, Big Sandy, TX 75755 - 853",
                    Note = "Work"
                },
                new Contact {
                    ContactId = 2,
                    Name = "Dwayne Dibbley",
                    Phone = "020 8743 8000",
                    Address = "BBC London, 2nd Floor, Peel Wing, BBC Broadcasting House, Portland Place, London, W1A 1AA",
                    Note = "Personal"
                },
                new Contact {
                    ContactId = 3,
                    Name = "Bert and Ernie",
                    Phone = "212-595-3456",
                    Address = "1900 Broadway, (One Lincoln Plaza), New York, NY 10023",
                    Note = "Work"
                }
            );
        }
    }
}
