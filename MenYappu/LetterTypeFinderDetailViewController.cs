using Foundation;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MenYappu.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UIKit;

namespace MenYappu
{

    public class Item
    {
        public string Seer { get; set; }
    }
    partial class LetterTypeFinderDetailViewController : UIViewController
    {


        public Game SelectedGame { get; set; }
        public LetterTypeFinderDetailViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SampleButton.TouchUpInside += async (object sender, EventArgs e) =>
            {
                var result =
                    await
                        MenYappuRestServiceWrapper.GetSampleSeerAsync(string.Format(MenYappuServiceUrls.BaseUrlFormat,
                            MenYappuServiceUrls.Seergal));
                var seergal = JsonConvert.DeserializeObject<List<Item>>(result);
                var randomIndex = new Random().Next(0, seergal.Count);
                TextWord.Text = seergal[randomIndex].Seer;
            };
        }
    }
}
