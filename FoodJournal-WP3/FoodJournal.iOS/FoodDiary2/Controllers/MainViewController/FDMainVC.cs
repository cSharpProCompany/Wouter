// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;
using FoodJournal.Model;
using FoodJournal.Runtime;
using FoodJournal.Values;

namespace FoodDiary2.iOS.Controller
{
	public partial class FDMainVC : UIViewController
	{
		public FDMainVC (IntPtr handle) : base (handle)
		{
			
		}

		public DateTime Date { get; set; }
		public Period DefaultPeriod { get; set; }

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		
			tableview.Source = new FDMainDataSource ();
			tableview.ReloadData ();
		}


		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			constraintTopToolbar.Constant = this.View.Frame.Height;
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			//var items = tabbar.Items;

			Navigate.selectedDate = Date.Date;
			Navigate.selectedPeriod = Period.Breakfast;
			var current = 0;

//			foreach (var period in Cache.GetDatePeriods(Navigate.selectedDate)) {
//				items [0].Title = NSBundle.MainBundle.LocalizedString ("Breakfast","");
//			}

			UITabBarItem[] items = new UITabBarItem[Cache.GetDatePeriods (Navigate.selectedDate).Count];

			for (int i = 0; i < Cache.GetDatePeriods (Navigate.selectedDate).Count; i++) {
				items[i] = new UITabBarItem (Cache.GetDatePeriods (Navigate.selectedDate)[i].ToString(),null, i);

//				items [i].Title = Cache.GetDatePeriods (Navigate.selectedDate)[i].ToString();
			}

//			items [0].Title = NSBundle.MainBundle.LocalizedString ("Breakfast","");
//			items [0].SelectedImage = UIImage.FromBundle ("tab_breakfast_active");
//
//			items [1].Title = NSBundle.MainBundle.LocalizedString ("Lunch","");
//			items [1].SelectedImage = UIImage.FromBundle ("tab_lunch_active");
//
//			items [2].Title = NSBundle.MainBundle.LocalizedString ("Dinner","");
//			items [2].SelectedImage = UIImage.FromBundle ("tab_dinner_active");
//
//			items [3].Title = NSBundle.MainBundle.LocalizedString ("firstSnack","");
//			items [3].SelectedImage = UIImage.FromBundle ("tab_snack_active");
//
//			items [4].Title = NSBundle.MainBundle.LocalizedString ("secondSnack","");
//			items [4].SelectedImage = UIImage.FromBundle ("tab_snack_active");
			tabbar.Items = items;
			tabbar.SelectedItem = items [0];
		}


		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier.Equals ("SegueSelectItem")) {
				var ctrl = segue.DestinationViewController	as FDSelectItemVC;
			}
		}

		partial void menuBtnTapped (UIKit.UIBarButtonItem sender)
		{
			AppDelegate.SidebarController.ToggleMenu ();	
		}

		partial void selectItemBtnTapped (UIKit.UIBarButtonItem sender)
		{
			PerformSegue("SegueSelectItem", null);	
		}

		partial void btnDoneTapped (UIKit.UIButton sender)
		{
			
		}

		partial void btnTimePickerTapped (UIKit.UIButton sender)
		{
			
		}

		partial void handleSingleTap (UIKit.UIBarButtonItem sender)
		{
			
		}
	}
}