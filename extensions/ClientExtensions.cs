using Sandbox;
using System.Collections.Generic;
using System.Linq;

namespace Gamelib.Extensions
{
	public static class ClientExtensions
	{
		public static Client ByPlayerId( this IReadOnlyList<Client> self, long playerId )
		{
			return self.FirstOrDefault( p => p.PlayerId == playerId );
		}
	}
}
