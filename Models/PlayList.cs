
using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_MOM_33.Models
{
	public class PlayList
	{
		public int Id { get; set; }
		[Required]
		public string? Name { get; set; }
		[Required]
		public string? Artist { get; set; }
		[Required]
		public int Length { get; set; }
		[Required]
		public string? Genre { get; set; }
		public bool Favourite { get; set; } = false;

		public PlayList()
		{
		}
	}
}

