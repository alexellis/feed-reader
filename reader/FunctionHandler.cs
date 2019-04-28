using System;
using System.Text;
using CodeHollow.FeedReader;
using System.Linq;

namespace Function
{
    public class FunctionHandler
    {
        public string Handle(string input) {

            var feed = FeedReader.Read("http://feeds.bbci.co.uk/news/technology/rss.xml");

            var items = "";
            foreach(var item in feed.Items.Take(10))
            {
                items = items + item.Title + System.Environment.NewLine;
            }

            return items;
        }
    }
}
