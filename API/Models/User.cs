using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
  public class User
  {
    public int Id { get; set; }
    public string Username { get; set; }

    public virtual ICollection<Artist> Artists { get; set; }
    public virtual ICollection<Genre> Genres { get; set; }
    public virtual ICollection<Song> Songs { get; set; }
        /* The ICollection<Artist>, ICollection<Genre> and ICollection<Song> properties imply a 
         * relationship between an artist, genre or song. 
         * 
         * The virtual keyword indicates that this property can be overridden 
         * by derived classes.*/
    }
}