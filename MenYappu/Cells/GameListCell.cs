using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Foundation;
using UIKit;

namespace MenYappu
{
    public class GameListCell : UITableViewCell
    {
        UILabel nameLabel;
        UILabel descriptionLabel;
        UIImageView imageView;

        public GameListCell()
        {

        }

        public GameListCell(NSString cellId): base(UITableViewCellStyle.Default, cellId)
        {
            SelectionStyle = UITableViewCellSelectionStyle.Gray;
            ContentView.BackgroundColor = UIColor.FromRGB(188, 219, 247);

            imageView  = new UIImageView();

            nameLabel = new UILabel
            {
                Font = UIFont.FromName("Cochin-BoldItalic", 18f),
                TextColor = UIColor.FromRGB(0, 0x78, 0xD7),
                BackgroundColor = UIColor.Clear
            };

            //descriptionLabel = new UILabel
            //{
            //    Font = UIFont.FromName("AmericanTypewriter", 12f),
            //    TextColor = UIColor.FromRGB(0, 0x78, 0xD7),
            //    //TextAlignment = UITextAlignment.Center,
            //    BackgroundColor = UIColor.Clear
            //};
            ContentView.Add(imageView);
            ContentView.Add(nameLabel);
            //ContentView.Add(descriptionLabel);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            imageView.Frame = new RectangleF((float)ContentView.Bounds.Width - 63, 5, 33, 33);
            nameLabel.Frame = new RectangleF(5, 4, (float)ContentView.Bounds.Width - 63, 25);
            //descriptionLabel.Frame = new RectangleF(200, 10, 100, 20);
        }

        public void UpdateCell(string caption, string subtitle, UIImage image)
        {
            imageView.Image = image;
            nameLabel.Text = caption;
            //descriptionLabel.Text = subtitle;
        }
    }
}
