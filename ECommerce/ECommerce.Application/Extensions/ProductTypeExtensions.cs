﻿using ECommerce.Application.UpdateModels;
using ECommerce.Application.Views;
using ECommerce.Models.Entities.ProductTypes;
using ECommerce.Models.Entities.Sellers;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Application.Extensions
{
	public static class ProductTypeExtensions
	{
		public static ProductTypeView ConvertToView(this ProductType productType)
			=> new ProductTypeView
			{
				Id = productType.Id.ToString(),
				Name = productType.Name,
				CategoryId = productType.CategoryId.ToString(),
				CategoryName = productType.Category.Name,
				Status = productType.Status,
				DateModified=productType.DateModified
			};

		public static IEnumerable<ProductTypeView> ConvertToViews(this IEnumerable<ProductType> productTypes)
			=> productTypes.Select(productType => productType.ConvertToView());

		public static ProductTypeUpdateModel ConvertToUpdateModel(this ProductType productType)
			=> new ProductTypeUpdateModel
			{
				CategoryId = productType.CategoryId,
				Name = productType.Name
			};

		public static ProductTypeUpdateRequestView ConvertToUpdateRequestView(this ProductType productType)
			=> new ProductTypeUpdateRequestView
			{
				CategoryId = productType.CategoryId.ToString(),
				CategoryName = productType.Category.Name,
				Name = productType.Name,
				ProductTypeId = productType.Id.ToString(),
				ProductTypeName = productType.Name
			};
	}
}