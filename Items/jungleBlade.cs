using Terraria.ID;
using Terraria.ModLoader;

namespace sharpaxemod.Items
{
	public class jungleBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jungle Blade");
			Tooltip.SetDefault("One day, Dasani said, spammer.  Didn't get the joke? Too bad.");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 5;
			item.crit = 5;
			item.value = 100000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BladeofGrass, 1);
			recipe.AddIngredient(ItemID.Emerald, 10);
			recipe.AddIngredient(ItemID.JungleSpores, 10);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}