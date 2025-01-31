﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Application.WorkingModels.UpdateModels
{
	public class AdminUpdateModel
	{
		[Required]
		[MinLength(1)]
		[MaxLength(20)]
		[Column("FirstName")]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[MinLength(1)]
		[MaxLength(20)]
		[Column("MiddleName")]
		[Display(Name = "Middle Name")]
		public string MiddleName { get; set; }

		[Required]
		[MinLength(1)]
		[MaxLength(20)]
		[Column("LastName")]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }
	}
}