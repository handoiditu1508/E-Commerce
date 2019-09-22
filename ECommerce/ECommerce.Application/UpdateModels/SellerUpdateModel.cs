﻿using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.UpdateModels
{
	public class SellerUpdateModel
	{
		[Required]
		[MinLength(1)]
		[MaxLength(50)]
		public string Name { get; set; }

		[Required]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; }
	}
}