using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace TZ 
{
	public class MainMenu : Panel 
	{
		public bool IsHidden = false;

		public MainMenu() 
		{
			StyleSheet.Load("ui/mainmenu/MainMenu.scss");

			Add.Panel("background");

			Add.Label("Open Options", "optionsbutton").AddEventListener("onclick", () => {
				Log.Info("Should Open the Settings Now!");
			});

			Add.Label("Start Game", "startgamebtn").AddEventListener("onclick", () => {
				Log.Info("Should be returning to the game now!");

				IsHidden = true;
			});
		}

		public override void Tick()
		{
			base.Tick();

			if (IsHidden)
				AddClass("hidden");
				return;
		}
	}
}
