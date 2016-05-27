using Foundation;
using System;
using System.CodeDom.Compiler;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MenYappu.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UIKit;

namespace MenYappu_V1
{
	partial class VenpaaDetailViewController : UIViewController
	{
        public string ParseResult { get; set; }
        public Game SelectedGame { get; set; }
        public VenpaaDetailViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            ParseButton.TouchUpInside += async (object sender, EventArgs e) =>
            {


                string url = "http://menyappu.local/api/prosody";
                var result = await ParseVenpaaAsync(url, PaaText.Text);
                //Create Alert
                var okCancelAlertController = UIAlertController.Create("Venpaa Parser", result, UIAlertControllerStyle.Alert);
                //Add Actions
                okCancelAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, alert => Console.WriteLine("Okay was clicked")));
                okCancelAlertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, alert => Console.WriteLine("Cancel was clicked")));

                //Present Alert
                PresentViewController(okCancelAlertController, true, null);

            };

            HomeButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                this.DismissModalViewController(true);
            };
        }

        private async Task<string> ParseVenpaaAsync(string uri, string data)
        {
            var parseResult = string.Empty;
            if (string.IsNullOrEmpty(ParseResult))
            {
                var inputData = new JObject();
                inputData.Add("prosodyText", data);
                inputData.Add("shouldParseKutriyalukaram", "true");
                inputData.Add("shouldParseVilaangaaySeer", "true");
                inputData.Add("shouldCompareVenpaRules", "true");

                using (var httpClient = new HttpClient())
                {
                    try
                    {
                        var jsonData = JsonConvert.SerializeObject(inputData);
                        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                        HttpResponseMessage response = null;
                        response = await httpClient.PostAsync(new Uri(uri), content);

                        if (response.IsSuccessStatusCode)
                        {
                            parseResult = await response.Content.ReadAsStringAsync();
                            Console.WriteLine(parseResult);
                        }

                        return parseResult;
                    }
                    catch (Exception e)
                    {
                        parseResult = e.Message;
                    }
                }
            }

            return parseResult;
        }
        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
