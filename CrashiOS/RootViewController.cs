namespace CrashiOS
{
	public class RootViewController : UIViewController
	{
        private readonly List<string> _itemsSource = new List<string>();

        public RootViewController()
        {
            View!.BackgroundColor = UIColor.SystemBackground;
            NavigationItem.RightBarButtonItems = new UIBarButtonItem[]
            {
                new UIBarButtonItem("SynCrash", UIBarButtonItemStyle.Plain, (_, _) => GetItem()),
                new UIBarButtonItem("AsynCrash", UIBarButtonItemStyle.Plain, async (_, _) => await GetItemAsync()),
            };
        }

        private string GetItem()
        {
            return _itemsSource[10];
        }

        private async Task<string> GetItemAsync()
        {
            return await Task.Run(() => GetItem());
        }
    }
}

