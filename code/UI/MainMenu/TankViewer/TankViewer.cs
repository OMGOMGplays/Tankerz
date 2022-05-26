using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

namespace TZ 
{
	public class TankViewer : Panel 
	{
		readonly ScenePanel scenePanel;

		Angles CamAngles = new(0.0f, 0.0f, 0.0f);
		float CamDistance = 200;
		Vector3 CamPos => Vector3.Up * 25 + CamAngles.Direction * -CamDistance;

		public TankViewer() 
		{
			Style.FlexWrap = Wrap.Wrap;
			Style.JustifyContent = Justify.Center;
			Style.AlignItems = Align.Center;
			Style.AlignContent = Align.Center;
			Style.Padding = 0;

			var transform = new Transform(Vector3.Zero, Rotation.FromYaw(180));

			var world = new SceneWorld();

			scenePanel = Add.ScenePanel( world, CamPos, Rotation.From( CamAngles ), 70 );
			scenePanel.Style.Width = Length.Percent( 100 );
			scenePanel.Style.Height = Length.Percent( 100 );

			new SceneModel(world, "models/citizen/citizen.vmdl" /* TEMP */, transform);
			
			new SceneLight( world, Vector3.Up * 15.0f + Vector3.Forward * 100.0f, 200, Color.White * 15.0f );
			new SceneLight( world, Vector3.Up * 15.0f + Vector3.Forward * -50.0f, 200, Color.White * 15.0f );
		}
	}
}
