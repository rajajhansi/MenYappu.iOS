using Foundation;
using System;
using System.CodeDom.Compiler;
using MenYappu;
using MenYappu.Core;
using UIKit;

namespace MenYappu_V1
{
    public partial class GameTableViewController : UITableViewController
	{
        GameDataService dataService = new GameDataService();
		public GameTableViewController (IntPtr handle) : base (handle)
		{
		}

	    public override void ViewDidLoad()
	    {
	        var games = dataService.GetAllGames();
            var dataSource = new GameDataSource(games, this);

	        TableView.Source = dataSource;

	        this.NavigationItem.Title = "மென் யாப்பு செயலியின் சேவைகள்";

	    }

	    public async void GameSelected(Game selectedGame)
	    {
	        VenpaaDetailViewController venpaaDetailViewController =
                this.Storyboard.InstantiateViewController("VenpaaDetailViewController") as VenpaaDetailViewController;
	        if (venpaaDetailViewController != null)
	        {
	            venpaaDetailViewController.ModalTransitionStyle = UIModalTransitionStyle.PartialCurl;
	            venpaaDetailViewController.SelectedGame = selectedGame;

	            await PresentViewControllerAsync(venpaaDetailViewController, true);
	        }
	    }
	    //public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
	    //{
	    //    base.PrepareForSegue(segue, sender);

	    //    if (segue.Identifier == "GameDetailSegue")
	    //    {
	    //        var gameDetailViewController = segue.DestinationViewController as VenpaaDetailViewController;
	    //        if (gameDetailViewController != null)
	    //        {
	    //            var source = TableView.Source as GameDataSource;
	    //            var rowPath = TableView.IndexPathForSelectedRow;
	    //            var item = source.GetItem(rowPath.Row);
	    //            gameDetailViewController.SelectedGame = item;
	    //        }
	    //    }
	    //}
	}
}
