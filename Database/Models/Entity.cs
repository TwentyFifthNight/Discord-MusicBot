﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remelites.Database.Models
{
	public abstract class Entity
	{
		[Key]
		public int Id { get; set; }
	}
}
