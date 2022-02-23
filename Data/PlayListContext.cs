using System;
using ASP_MOM_33.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_MOM_33.Data
{
	public class PlayListContext : DbContext
	{
		public PlayListContext(DbContextOptions<PlayListContext> options) : base(options)
		{
		}
		public DbSet<PlayList>? PlayList { get; set; }
	}
}

