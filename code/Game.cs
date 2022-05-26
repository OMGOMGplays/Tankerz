using Sandbox;
using System;
using System.Linq;

namespace TZ 
{
	public partial class TZGame : Game 
	{
		public TZGame() 
		{
			if (IsServer) 
			{
				// _ = new TZHud(); // I'll work on it at a later date - Lokiv
			}
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
