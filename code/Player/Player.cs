using Sandbox;

namespace TZ 
{
	public partial class TZPlayer : Player 
	{
		public override void Respawn()
		{
			base.Respawn();

			SetModel("models/citizen/citizen.vmdl"); // TEMP \\ Switch to tank model when imported - Lokiv

			CameraMode = new ThirdPersonCamera();
			Animator = new StandardPlayerAnimator();
			Controller = new WalkController();
		}
	}
}
