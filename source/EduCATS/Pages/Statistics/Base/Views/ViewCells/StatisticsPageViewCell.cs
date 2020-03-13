﻿using EduCATS.Themes;
using Xamarin.Forms;

namespace EduCATS.Pages.Statistics.Base.Views.ViewCells
{
	public class StatisticsPageViewCell : ViewCell
	{
		public StatisticsPageViewCell()
		{
			var menuLabel = new Label();
			menuLabel.SetBinding(Label.TextProperty, "Title");

			View = new StackLayout {
				BackgroundColor = Color.FromHex(Theme.Current.CommonBlockColor),
				Padding = new Thickness(20),
				Children = {
					menuLabel
				}
			};
		}
	}
}
