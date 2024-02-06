using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class Genre
  {
    public int Id { get; set; }
    public string Title { get; set; }

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