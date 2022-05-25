using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace TZ 
{
	public class MMStart : Panel 
	{
		public MMStart() 
		{
			StyleSheet.Load("ui/mainmenu/mainmenubuttons/MMStart.scss");

			Add.Label("Start Game", "startgamebtn").AddEventListener("onclick", () => {
				Log.Info("Should be returning to the game now!");
			})
		}
	}
}
