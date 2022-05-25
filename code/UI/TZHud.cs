using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace TZ 
{
	public partial class TZHud : HudEntity<RootPanel> 
	{
		public TZHud Instance {get; set;}

		public TZHud() 
		{
			Instance = this;
		}

		public override void CreateRootPanel()
		{
			RootPanel?.Delete();

			base.CreateRootPanel();
			CreateHudElements();
		}
	
		public void CreateHudElements()
		{
			// Main Menu \\
			RootPanel.AddChild<MainMenuBackground>();

			// Main Menu Buttons \\
			RootPanel.AddChild<MMSettings>();

		}
	}
}
