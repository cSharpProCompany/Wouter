// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace FoodDiary2.iOS.Controller
{
	public partial class FDJournalVC : UIViewController
	{
		public FDJournalVC (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			_tblView.Source = new JournalDataSource ();
			_tblView.ReloadData ();

			leftBarBtn.Title =  NSBundle.MainBundle.LocalizedString ("Menu", comment: "");
			rightBarBtn.Title =  NSBundle.MainBundle.LocalizedString ("Send_Week", comment: "");
		}

		partial void filteredReportBtnTapped (UIBarButtonItem sender)
		{
			
		}

		partial void menuBtnTapped (UIBarButtonItem sender)
		{
			AppDelegate.SidebarController.ToggleMenu ();		
		}
	}
}
