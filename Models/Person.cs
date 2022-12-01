using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Server.Data.Models
{
    [Table("People")]
    public class Person
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column]
        [StringLength(255)]
        public string Name { get; set; }

        [Column]
        [StringLength(255)]
        public string Class { get; set; }

        [Column]
        [StringLength(255)]
        public string Building { get; set; }

        public virtual Entry BorrowedItem { get; set; }
    }
}

