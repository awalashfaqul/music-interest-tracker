using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class Artist
  {
        public int Id { get; set; } // artist's unique Id
        public string Name { get; set; } // artist's Name
        public string? Description { get; set; }

        /* A nullable string property representing a description or additional 
         * information about the artist. The ? after string in indicates that 
         * the Description property can be nullable. */

        public virtual ICollection<User> Users { get; set; }

        /* The ICollection<User> and ICollection<Song> properties imply a 
         * one-to-many relationship between an artist and users or songs. 
         * An artist can be associated with multiple users and songs.
         * 
         * The virtual keyword indicates that this property can be overridden 
         * by derived classes.*/

        public virtual ICollection<Song> Songs { get; set; }
  }
}