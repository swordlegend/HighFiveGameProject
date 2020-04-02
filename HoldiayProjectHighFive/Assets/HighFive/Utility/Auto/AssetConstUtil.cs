namespace HighFive.Utility
{
	/// <summary>
	/// 这个类提供了Resources下文件名和路径字典访问方式，同名资源可能引起bug
	/// </summary>
	public class AssetConstUtil : ReadyGamerOne.MemorySystem.AssetConstUtil<AssetConstUtil>
	{
		private System.Collections.Generic.Dictionary<string,string> nameToPath 
			= new System.Collections.Generic.Dictionary<string,string>{
					{ @"ImpuseGenerator Raw Signal" , @"CinemachineNoiseSetting\ImpuseGenerator Raw Signal" },
					{ @"Au1" , @"ClassAudio\Au1" },
					{ @"Au2" , @"ClassAudio\Au2" },
					{ @"Au3" , @"ClassAudio\Au3" },
					{ @"Au4" , @"ClassAudio\Au4" },
					{ @"Au5" , @"ClassAudio\Au5" },
					{ @"beiji" , @"ClassAudio\beiji" },
					{ @"Bg" , @"ClassAudio\Bg" },
					{ @"Fuck" , @"ClassAudio\Fuck" },
					{ @"CharacterData_CharacterData" , @"ClassFile\CharacterData_CharacterData" },
					{ @"DataConfig" , @"ClassFile\DataConfig" },
					{ @"DragData_1" , @"ClassFile\DragData_1" },
					{ @"DragData_2" , @"ClassFile\DragData_2" },
					{ @"DropData_DropData" , @"ClassFile\DropData_DropData" },
					{ @"EnemyData_EnemyData" , @"ClassFile\EnemyData_EnemyData" },
					{ @"GemData_1" , @"ClassFile\GemData_1" },
					{ @"GemData_2" , @"ClassFile\GemData_2" },
					{ @"ItemData_ItemData" , @"ClassFile\ItemData_ItemData" },
					{ @"PersonData_PersonData" , @"ClassFile\PersonData_PersonData" },
					{ @"RankData_RankData" , @"ClassFile\RankData_RankData" },
					{ @"Medkit" , @"ClassItem\Drag\Medkit" },
					{ @"Mushroom" , @"ClassItem\Drag\Mushroom" },
					{ @"Snail" , @"ClassItem\Drag\Snail" },
					{ @"Soda" , @"ClassItem\Drag\Soda" },
					{ @"StickyBomb" , @"ClassItem\Drag\StickyBomb" },
					{ @"Syringe" , @"ClassItem\Drag\Syringe" },
					{ @"AlienHead" , @"ClassItem\Gem\AlienHead" },
					{ @"Bear" , @"ClassItem\Gem\Bear" },
					{ @"Hook" , @"ClassItem\Gem\Hook" },
					{ @"Knife" , @"ClassItem\Gem\Knife" },
					{ @"Leave" , @"ClassItem\Gem\Leave" },
					{ @"Snowflower" , @"ClassItem\Gem\Snowflower" },
					{ @"texGravBootsIcon" , @"ClassItem\Gem\texGravBootsIcon" },
					{ @"texTeslaCoilIcon" , @"ClassItem\Gem\texTeslaCoilIcon" },
					{ @"GoldHeart" , @"ClassItem\GoldHeart" },
					{ @"LittleBoy" , @"ClassItem\LittleBoy" },
					{ @"texKnurlIcon" , @"ClassItem\texKnurlIcon" },
					{ @"BattlePanel" , @"ClassPanel\BattlePanel" },
					{ @"LoadingPanel" , @"ClassPanel\LoadingPanel" },
					{ @"PackagePanel" , @"ClassPanel\PackagePanel" },
					{ @"ShopPanel" , @"ClassPanel\ShopPanel" },
					{ @"WelcomePanel" , @"ClassPanel\WelcomePanel" },
					{ @"Sworder" , @"ClassPerson\TypeCharacter\Sworder" },
					{ @"Boner" , @"ClassPerson\TypeEnemy\Boner" },
					{ @"Spider" , @"ClassPerson\TypeEnemy\Spider" },
					{ @"bullet_1" , @"ClassPrefab\Bullet\bullet_1" },
					{ @"DropItem" , @"ClassPrefab\GameObjects\DropItem" },
					{ @"ImpuseGenerator" , @"ClassPrefab\GameObjects\ImpuseGenerator" },
					{ @"OnHitParticle" , @"ClassPrefab\GameObjects\OnHitParticle" },
					{ @"SwordLight" , @"ClassPrefab\GameObjects\SwordLight" },
					{ @"Slot" , @"ClassPrefab\Ui\Slot" },
					{ @"Image_ItemBk" , @"ClassUi\Image_ItemBk" },
					{ @"Image_ItemInfo" , @"ClassUi\Image_ItemInfo" },
					{ @"Image_ItemUI" , @"ClassUi\Image_ItemUI" },
					{ @"Image_MiniMapBackGround" , @"ClassUi\Image_MiniMapBackGround" },
					{ @"Image_Slot" , @"ClassUi\Image_Slot" },
					{ @"Slider" , @"ClassUi\Slider" },
					{ @"Text_Number" , @"ClassUi\Text_Number" },
					{ @"DOTweenSettings" , @"DOTweenSettings" },
					{ @"OnHitParticleMat" , @"Materials\OnHitParticleMat" },
				};
		public override System.Collections.Generic.Dictionary<string,string> NameToPath => nameToPath;
	}
}
