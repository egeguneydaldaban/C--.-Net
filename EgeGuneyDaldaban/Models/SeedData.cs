using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgeGuneyDaldaban.Models
{
	public class SeedData
	{
		/*
		 IApplicationBuilder argument, which is the interface used in the 
		 Configure method of the Startup class to register middleware 
		 components to handle HTTP requests. 
		 IApplicationBuilder also provides access to the application’s 
		 services, including the Entity Framework Core database 
		 context service
		 */
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			BookDBContext context = app.ApplicationServices.CreateScope().
										ServiceProvider.GetRequiredService<BookDBContext>();
			if (!context.Books.Any())
			{
				context.Books.AddRange(
			new Book
			{
				
				Name = "Kaşağı",
				Author = "Ömer Seyfettin",
				Description = "A novel about a horse and children",
				Category = "Novel",
				ReleaseDate = "02/03/1926"
			},
				new Book
				{
					
					Name = "The Silence of the Lambs",
					Author = "Thomas Harris",
					Description = "Dr. Hannibal Lecter is a cannibal...",
					Category = "Novel",
					ReleaseDate = "03/05/1991"
				},
				new Book
				{
					
					Name = "Red Dragon",
					Author = "Thomas Harris",
					Description = "Feed your fears with this terrifying classic that introduced cannibalistic serial killer Hannibal Lecter.",
					Category = "Novel",
					ReleaseDate = "01/06/2009"
				},
				new Book
				{
					
					Name = "Hannibal",
					Author = "Thomas Harris",
					Description = "Is it as good as Red Dragon and Silence of the Lambs? No . . . this one is better.",
					Category = "Kindle",
					ReleaseDate = "23/05/2000"
				},
				new Book
				{
					
					Name = "Hannibal Rising",
					Author = "Thomas Harris",
					Description = "He is one of the most haunting characters in all of literature. At last the evolution of his evil is revealed.",
					Category = "Novel",
					ReleaseDate = "29/05/2007"
				},
				 new Book
				 {
					 
					 Name = "Pet Sematary",
					 Author = "Stephen King",
					 Description = "The road in front of Dr. Louis Creed's rural Maine home frequently claims the lives of neighborhood pets. ",
					 Category = "Novel",
					 ReleaseDate = "29/11/1983"
				 },
				 new Book
				 {
					 
					 Name = "The Outsider",
					 Author = "Stephen King",
					 Description = "An unspeakable crime. A confounding investigation. At a time when the King brand has never been stronger, he has delivered one of his most unsettling and compulsively readable stories. ",
					 Category = "Novel",
					 ReleaseDate = "29/5/2018"
				 },

				  new Book
				  {
					  
					  Name = "IT",
					  Author = "Stephen King",
					  Description = "Children are being murdered again and their repressed memories of that summer return as they prepare to do battle with the monster lurking in Derry's sewers once more.",
					  Category = "Novel",
					  ReleaseDate = "11/7/1986"
				  }

				 );
				context.SaveChanges();
			}
		}
	}
}
