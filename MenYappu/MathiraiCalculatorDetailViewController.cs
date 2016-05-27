using Foundation;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using MenYappu.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UIKit;

namespace MenYappu
{
	partial class MathiraiCalculatorDetailViewController : UIViewController
	{
        public Game SelectedGame { get; set; }
        public MathiraiCalculatorDetailViewController (IntPtr handle) : base (handle)
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
                TextMathiraiCount.BecomeFirstResponder();
            };

            ClearButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                TextWord.Text = "";
            };

            CheckAnswerButton.TouchUpInside += async (object sender, EventArgs e) =>
            {
                var jsonData = new JObject();
                jsonData.Add("inputText", TextWord.Text);

                var result =
                    await
                        MenYappuRestServiceWrapper.CalculateMathiraiAsync(
                            string.Format(MenYappuServiceUrls.BaseUrlFormat, MenYappuServiceUrls.MathiraiCount),
                            JsonConvert.SerializeObject(jsonData));

                var resultJsonObject = JObject.Parse(result);

                // Check if the entered Mathirai Count is the same as the one returned by MenYappu REST service
                if (TextMathiraiCount.Text == (string) resultJsonObject["totalMathiraiCount"])
                {
                    ResultTextView.Text = "சரியான விடை";
                }
                else
                {
                    ResultTextView.Text = "தவறான விடை";
                }
            };
        }
    }
}
