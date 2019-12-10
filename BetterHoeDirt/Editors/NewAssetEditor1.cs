using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using StardewModdingAPI;
using StardewValley;

namespace BetterHoeDirt
{
	class NewAssetEditor1 : IAssetEditor
	{
		private IModHelper Helper;

		public NewAssetEditor1(IModHelper helper)
		{
			Helper = helper;
		}

		public bool CanEdit<T>(IAssetInfo asset)
		{
			return asset.AssetNameEquals(@"LooseSprites/boardGame")
				|| asset.AssetNameEquals(@"LooseSprites/Cursors")
				|| asset.AssetNameEquals(@"LooseSprites/SeaMonster")
				|| asset.AssetNameEquals(@"LooseSprites/temporary_sprites_1")
				|| asset.AssetNameEquals(@"Maps/Festivals")
				|| asset.AssetNameEquals(@"TerrainFeatures/mushroom_tree")
				|| asset.AssetNameEquals(@"TileSheets/Craftables")
				|| asset.AssetNameEquals(@"TileSheets/furniture");
		}

		public void Edit<T>(IAssetData asset)
		{
			var source = Helper.Content.Load<Texture2D>(Path.Combine("assets", asset.AssetName));
			var target = asset.AsImage();
			var area = Rectangle.Empty;

			if (asset.AssetNameEquals(@"LooseSprites/boardGame")
				|| asset.AssetNameEquals(@"LooseSprites/SeaMonster")
				|| asset.AssetNameEquals(@"TerrainFeatures/mushroom_tree"))
			{
				target.PatchImage(source, null, null, PatchMode.Replace);
			}
			else if (asset.AssetNameEquals(@"LooseSprites/Cursors"))
			{
				// TV Programs
				area = new Rectangle(518, 362, 169, 28);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// 50/50 Spinner Fair Minigame
				area = new Rectangle(128, 1184, 160, 112);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Witch Event
				area = new Rectangle(276, 1886, 40, 60);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Fishing Targets
				area = new Rectangle(615, 1840, 40, 20);
				target.PatchImage(source, area, area, PatchMode.Replace);
			}
			else if (asset.AssetNameEquals(@"LooseSprites/temporary_sprites_1"))
			{
				// Blue Girl Painting
				area = new Rectangle(172, 200, 28, 14);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Snake Painting
				area = new Rectangle(312, 200, 28, 14);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Portrait Painting
				area = new Rectangle(476, 394, 25, 22);
				target.PatchImage(source, area, area, PatchMode.Replace);
			}
			else if (asset.AssetNameEquals(@"Maps/Festivals"))
			{
				// 50/50 Spinner Fair Minigame
				area = new Rectangle(464, 0, 32, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Foroguemon Totem
				area = new Rectangle(128, 96, 16, 48);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Fair Mom and Doll
				area = new Rectangle(288, 128, 32, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Halloween Skull
				area = new Rectangle(288, 288, 16, 16);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Halloween TV
				area = new Rectangle(320, 336, 64, 16);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Winter Pear Ice Sculpture
				area = new Rectangle(96, 352, 32, 48);
				target.PatchImage(source, area, area, PatchMode.Replace);
			}
			else if (asset.AssetNameEquals(@"TileSheets/Craftables"))
			{
				// House Plant
				area = new Rectangle(96, 0, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Skeleton Model
				area = Game1.getSourceRectForStandardTileSheet(asset.AsImage().Data, 28, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Chicken Statue
				area = Game1.getSourceRectForStandardTileSheet(asset.AsImage().Data, 31, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Lawn Flamingo
				area = Game1.getSourceRectForStandardTileSheet(asset.AsImage().Data, 36, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Seasonal Decor
				area = new Rectangle(16, 192, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace); 
				// Sloth Skeleton L
				area = Game1.getSourceRectForStandardTileSheet(asset.AsImage().Data, 85, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Sloth Skeleton M
				area = Game1.getSourceRectForStandardTileSheet(asset.AsImage().Data, 86, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Sloth Skeleton R
				area = Game1.getSourceRectForStandardTileSheet(asset.AsImage().Data, 87, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
			}
			else if (asset.AssetNameEquals(@"TileSheets/furniture"))
			{
				// Long Cactus
				area = new Rectangle(384, 480, 16, 48);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Artist Bookcase
				area = new Rectangle(48, 640, 32, 48);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Totem Pole
				area = new Rectangle(240, 640, 16, 48);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Sloth Skeleton L
				area = new Rectangle(336, 640, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Sloth Skeleton M
				area = new Rectangle(352, 640, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Sloth Skeleton R
				area = new Rectangle(368, 640, 16, 32); 
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Skeleton Model
				area = new Rectangle(384, 640, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Chicken Statue
				area = new Rectangle(400, 640, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// House Plant
				area = new Rectangle(144, 688, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// House Plant
				area = new Rectangle(208, 688, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// 'The Muzzamaroo'
				area = new Rectangle(48, 768, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Wallflower Pal
				area = new Rectangle(368, 768, 32, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Skull Poster
				area = new Rectangle(0, 800, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// 'Little Tree'
				area = new Rectangle(32, 800, 16, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// Lg.Futan Bear
				area = new Rectangle(80, 832, 32, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// My First Painting
				area = new Rectangle(160, 900, 32, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// 'Portrait Of A Mermaid'
				area = new Rectangle(256, 912, 32, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// 'The Serpent'
				area = new Rectangle(416, 912, 32, 32);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// 'The Brave Little Sapling'
				area = new Rectangle(0, 976, 16, 48);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// 'Wumbus'
				area = new Rectangle(48, 976, 16, 48);
				target.PatchImage(source, area, area, PatchMode.Replace);
				// 'The Zuzu City Express'
				area = new Rectangle(64, 976, 16, 48);
				target.PatchImage(source, area, area, PatchMode.Replace);
			}
		}
	}
}
