using Sandbox;
using System.Collections.Generic;
using System.Linq;

namespace Gamelib.Extensions
{
	public static class ClientExtensions
	{
		public static IClient ByPlayerId( this IReadOnlyList<IClient> self, long playerId )
		{
			return self.FirstOrDefault( p => p.SteamId == playerId );
		}
	}
}
