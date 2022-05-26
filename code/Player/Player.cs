using Sandbox;

namespace TZ 
{
	public partial class TZPlayer : Player 
	{
		public override void Respawn()
		{
			base.Respawn();

			SetModel("models/tanks/lilwillie.vmdl");

			CameraMode = new ThirdPersonCamera();
			Animator = new TZPlayerAnimator();
			Controller = new WalkController();
		}
	}
}
