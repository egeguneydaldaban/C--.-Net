using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgeGuneyDaldaban.Models
{
    public class Book
    {
		public long BookId { get; set; }
		public string Name { get; set; }
		public string Author { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }

		public string ReleaseDate { get; set; }
	}
}
