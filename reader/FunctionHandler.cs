using System;
using System.Text;

namespace Function
{
    public class FunctionHandler
    {
        public string Handle(string input) {

            var feed = FeedReader.Read("https://codehollow.com/feed");

            // Console.WriteLine("Feed Title: " + feed.Title);
            // Console.WriteLine("Feed Description: " + feed.Description);
            // Console.WriteLine("Feed Image: " + feed.ImageUrl);
            // ...
            var items ="";
            foreach(var item in feed.Items)
            {
                items = items + item.Title + " - " + item.Link+System.Environment.NewLine;
            }

            return items;
        }
    }
}
