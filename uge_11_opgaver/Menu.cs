
namespace uge_11_opgaver
{
	internal class Menu
	{
		public string Title { get; set; }
		private int itemCount = 0;
		public MenuItem[] menuItems;

		public Menu(string title, int itemCount)
		{
			this.Title = title;
			this.itemCount = itemCount;
			menuItems = new MenuItem[itemCount];
			
		}

		public void ShowMenu() 
		{
			Console.WriteLine(this.Title);
            for (int i = 0; i<menuItems.Length; i++)
			{
				Console.WriteLine(menuItems[i].Title);
            }
		}
		public void AddMenuItems(string[] menuItemTitle) {
			for (int i = 0; i < menuItemTitle.Length; i++)
			{
				menuItems[i] = new MenuItem(menuItemTitle[i]);
			}
		}
		public int SelectMenuItem() {
			int itemId = 0;
            try
            {
                Console.WriteLine($"Choose from 1 to {menuItems.Length}");
                itemId = int.Parse(Console.ReadLine());
                if (itemId > menuItems.Length)
                {
                    itemId = 0;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only numbers!");
				itemId = 0;
            }
			return itemId;
        }
	}
}
