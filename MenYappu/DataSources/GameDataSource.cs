using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using MenYappu.Core;
using MenYappu_V1;
using UIKit;

namespace MenYappu
{
    public class GameDataSource : UITableViewSource
    {
        private List<Game> gameItems;
        NSString cellIdentifier = new NSString("GameCell");
        private GameTableViewController callingController;
        public GameDataSource(List<Game> games, GameTableViewController callingController)
        {
            this.gameItems = games;
            this.callingController = callingController;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            //UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);

            //if (cell == null)
            //{
            //    cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            //}

            //Game gameItem = gameItems[indexPath.Row];
            //cell.TextLabel.Text = gameItem.Name;

            //cell.ImageView.Image = UIImage.FromFile("Images/games.jpg");
            //return cell;
            GameListCell cell = tableView.DequeueReusableCell(cellIdentifier) as GameListCell;

            if (cell == null)
            {
                cell = new GameListCell(cellIdentifier);
            }

            cell.UpdateCell(gameItems[indexPath.Row].Name,
                gameItems[indexPath.Row].Description,
                UIImage.FromFile("Images/games.jpg"));
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return gameItems.Count;
        }

        public Game GetItem(int id)
        {
            return gameItems[id];
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var selectedGame = gameItems[indexPath.Row];
            callingController.GameSelected(selectedGame);
            tableView.DeselectRow(indexPath, true);
        }
    }
}
