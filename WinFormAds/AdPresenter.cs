using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAds;

namespace WinFormAdsLibrary
{
	public class AdPresenter
	{
		public Ad model;
		public FormISA View;
		public AdPresenter(FormISA view, Ad adModel)
		{
			View = view;
			model = adModel;
		}

	}
}
