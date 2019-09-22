﻿using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.MVC.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult GetBreadCrumb(int categoryId)
			=> ViewComponent("CategoryBreadCrumb", new { categoryId });
	}
}