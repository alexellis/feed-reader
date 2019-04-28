using System;
using System.Text;
using CodeHollow.FeedReader;

namespace Function
{
    public class FunctionHandler
    {
        public string Handle(string input) {

            var feed = FeedReader.Read("http://feeds.bbci.co.uk/news/technology/rss.xml");

            var items ="";
            foreach(var item in feed.Items)
            {
                items = items + item.Title + " - " + item.Link+System.Environment.NewLine;
            }

            return items;
        }
    }
}
