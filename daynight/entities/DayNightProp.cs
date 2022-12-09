﻿using Sandbox;
using Editor;

namespace Gamelib.DayNight
{

	/// <summary>
	/// Sets the skin of a model depending on if it's day time or night time, example: a street lamp turning on and night time then turning off in the morning.
	/// </summary>
	[Library( "daynight_prop" )]
	[Title( "Day and Night Prop" )]
	[Model( Model = "", MaterialGroup = "default" )]
	[HammerEntity]
	public class DayNightProp : ModelEntity
	{
		[Property( Title = "Day Material Group" )]
		public int DayMaterialGroup { get; set; } = 0;
		[Property( Title = "Night Material Group" )]
		public int NightMaterialGroup { get; set; } = 1;

		public override void ClientSpawn()
		{
			base.ClientSpawn();

			DayNightManager.OnSectionChanged += HandleSectionChanged;
		}

		private void HandleSectionChanged( TimeSection section )
		{
			if ( section == TimeSection.Dawn )
			{
				SetMaterialGroup( DayMaterialGroup );
			}
			else if ( section == TimeSection.Dusk )
			{
				SetMaterialGroup( NightMaterialGroup );
			}
		}
	}
}
