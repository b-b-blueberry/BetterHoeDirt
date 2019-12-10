using StardewModdingAPI;
using StardewModdingAPI.Events;

namespace BetterHoeDirt
{
	public class ModEntry : Mod
	{
		public override void Entry(IModHelper helper)
		{
			Helper.Events.GameLoop.GameLaunched += OnGameLaunched;
		}

		private void OnGameLaunched(object sender, GameLaunchedEventArgs e)
		{
			Helper.Content.AssetEditors.Add(new NewAssetEditor1(Helper));
		}
	}
}
