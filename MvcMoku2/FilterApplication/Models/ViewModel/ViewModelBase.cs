using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilterApplication.Models.ViewModel
{
	public abstract class ViewModelBase
	{
		public string Title { get; set; }
		public string H1 { get; set; }

		public abstract void SetDisplayValue();
	}
}