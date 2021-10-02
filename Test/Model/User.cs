using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
    class User
    {
        public string Name { get; set; }
        public List<Album> ListofAlbums { get; set; }

        public User()
        {
            Name = "Swati";
            ListofAlbums = new List<Album>(); 
        }

        public void addAlbum (Album newAlbum)
        {
            ListofAlbums.Add(newAlbum);
           
        }
        
    }
}
