﻿using ECommerce.Application.WorkingModels.UpdateModels;
using ECommerce.Models.Entities.Sellers;

namespace ECommerce.Application.Extensions.UpdateModels
{
	public static class ProductUpdateModelExtensions
	{
		public static Product ConvertToEntity(this ProductUpdateModel updateModel)
		{
			Product product = new Product
			{
				Price = updateModel.Price,
				Images = updateModel.Images,
				RepresentativeImage = updateModel.RepresentativeImage
			};
			return product;
		}
	}
}