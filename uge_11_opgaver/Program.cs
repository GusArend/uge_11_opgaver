namespace uge_11_opgaver
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string menuTitle = "My Menu";
			string[] menuItemTitles = ["MenuItem1", "MenuItem2", "MenuItem3"];

			Menu menu = new Menu(menuTitle, menuItemTitles.Length);
			menu.AddMenuItems(menuItemTitles);

			menu.ShowMenu();

			int itemId = 0;
			while (itemId <= 0)
			{
				itemId = menu.SelectMenuItem();
			}

            Console.WriteLine($"You have selected: {menu.menuItems[itemId - 1].Title}");

        }
	}
}
