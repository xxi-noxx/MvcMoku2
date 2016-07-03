using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterApplication.Models.ViewModel
{
	public class ErrorViewModel : ViewModelBase
	{
		public HandleErrorInfo ErrorInfo { get; set; }

		public override void SetDisplayValue()
		{
			Title = "MVC もくもく会 エラーページ";
			H1 = "システムエラー";
		}
	}
}