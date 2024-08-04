using Microsoft.EntityFrameworkCore;
using Remelites.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Remelites.Database.Context
{
	public class MyDbContext : DbContext
	{
		public DbSet<PlayerEntity> Players { get; set; }

		public MyDbContext(DbContextOptions options) :
			base(options)
		{
		}
	}
}
