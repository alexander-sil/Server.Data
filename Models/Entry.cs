using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Server.Data.Models
{
    [Table("Entries")]
    public class Entry
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey(nameof(Person))]
        public int BorrowingPersonId { get; set; }

        [Column]
        public State State { get; set; }

        // Client 180
        [Column]
        [StringLength(192)]
        public string Name { get; set; }

        [Column]
        public uint Quantity { get; set; }

        // Client 10
        [Column]
        [StringLength(16)]
        public string Unit { get; set; }

        // Client 500
        [Column(TypeName = "nvarchar(512)")]
        public string Description { get; set; }

        // Client 100
        [Column]
        [StringLength(128)]
        public string Owner { get; set; }

        [InverseProperty(nameof(Person.BorrowedItem))]
        public virtual ICollection<Person> BorrowingPeople { get; set; } = new List<Person>();

    }
}
