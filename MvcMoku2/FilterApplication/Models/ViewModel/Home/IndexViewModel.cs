using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilterApplication.Models.ViewModel.Home
{
	public class IndexViewModel : ViewModelBase
	{
		public override void SetDisplayValue()
		{
			Title = "TOPページ";
			H1 = "TOP";
		}
	}
}