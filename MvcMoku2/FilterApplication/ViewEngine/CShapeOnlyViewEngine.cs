﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterApplication.ViewEngine
{
	public class CShapeOnlyViewEngine : RazorViewEngine
	{
		public CShapeOnlyViewEngine()
		{
			base.AreaViewLocationFormats = new string[]
			{
				"~/Views/{1}/{0}.cshtml",
				"~/Views/Shared/{0}.cshtml"
			};

			base.AreaPartialViewLocationFormats = new string[]
			{
				"~/Areas/{2}/Views/{1}/{0}.cshtml",
				"~/Areas/{2}/Views/Shared/{0}.cshtml"
			};
		}
	}
}