using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace sharpaxemod.Items
{
	public class BubbleWrap : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Annoying Light");
			Tooltip.SetDefault("Summons an annoying light");
		}

		public override void SetDefaults() {
			item.damage = 0;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.shoot = ProjectileType<Projectiles.BalloonMaxPet>();
			item.width = 16;
			item.height = 30;
			item.UseSound = SoundID.Item2;
			item.useAnimation = 20;
			item.useTime = 20;
			item.rare = ItemRarityID.Yellow;
			item.noMelee = true;
			item.value = Item.sellPrice(0, 5, 50, 0);
			item.buffType = BuffType<Buffs.BalloonMaxBuff>();
		}


		// public override void AddRecipes() {
		// 	// ModRecipe recipe = new ModRecipe(mod);
		// 	// recipe.AddIngredient(ItemType<ExampleItem>(), 10);
		// 	// recipe.AddTile(TileType<ExampleWorkbench>());
		// 	// recipe.SetResult(this);
		// 	// recipe.AddRecipe();
		// }

		public override void UseStyle(Player player) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(item.buffType, 3600, true);
			}
		}
	}
}
