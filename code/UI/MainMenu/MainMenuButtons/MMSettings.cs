using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace TZ 
{
	public class MMSettings : Panel 
	{
		public MMSettings() 
		{
			StyleSheet.Load("ui/mainmenu/mainmenubuttons/MMSettings.scss");

			Add.Label("Open Options", "optionsbutton").AddEventListener("onclick", () => {
				Log.Info("Should Open the Settings Now!");
			});
		}
	}
}
