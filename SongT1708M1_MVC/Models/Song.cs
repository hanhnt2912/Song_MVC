using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongT1708M1_MVC.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
         public List<SongCategory> SongCategories { get; set; }
    }
}
