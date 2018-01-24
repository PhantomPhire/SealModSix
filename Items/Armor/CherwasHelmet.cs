using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace SealModSix.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class CherwasHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
            base.SetStaticDefaults();
            DisplayName.SetDefault("Cherwa's Helmet");
            Tooltip.SetDefault("Cherwa's helmet."
                               + "Pretty awesome for summoning!");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("CherwasBreastplate") && legs.type == mod.ItemType("CherwasLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "trollface.jpg";
			player.meleeDamage *= 0.8f;
			player.thrownDamage *= 0.8f;
			player.rangedDamage *= 0.8f;
			player.magicDamage *= 0.8f;
			player.minionDamage *= 0.8f;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}