using Sandbox;
using System;
using System.Linq;

namespace TZ 
{
	public partial class TZGame : Game 
	{
		public TZGame() 
		{

		}

		public override void ClientJoined( Client cl )
		{
			base.ClientJoined( cl );

			var player = new TZPlayer();
			player.Respawn();

			cl.Pawn = player;
		}
	}
}
