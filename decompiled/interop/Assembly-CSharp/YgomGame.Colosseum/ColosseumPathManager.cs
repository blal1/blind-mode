using Il2CppDummyDll;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001C81")]
public class ColosseumPathManager
{
	[Token(Token = "0x2001C82")]
	internal class PathBase
	{
		[Token(Token = "0x400FF2A")]
		[FieldOffset(Offset = "0x10")]
		internal string deck_list;

		[Token(Token = "0x400FF2B")]
		[FieldOffset(Offset = "0x18")]
		internal string accessory_box;

		[Token(Token = "0x400FF2C")]
		[FieldOffset(Offset = "0x20")]
		internal string accessory_sleeve;

		[Token(Token = "0x400FF2D")]
		[FieldOffset(Offset = "0x28")]
		internal string pickcards_ids;

		[Token(Token = "0x400FF2E")]
		[FieldOffset(Offset = "0x30")]
		internal string pickcards_r;

		[Token(Token = "0x400FF2F")]
		[FieldOffset(Offset = "0x38")]
		internal string id_name;

		[Token(Token = "0x400FF30")]
		[FieldOffset(Offset = "0x40")]
		internal string deck_list_accessory;

		[Token(Token = "0x400FF31")]
		[FieldOffset(Offset = "0x48")]
		internal string deck_list_pickcards_ids;

		[Token(Token = "0x400FF32")]
		[FieldOffset(Offset = "0x50")]
		internal string deck_list_pickcards_r;

		[Token(Token = "0x400FF33")]
		[FieldOffset(Offset = "0x58")]
		internal string name_reg_id;

		[Token(Token = "0x400FF34")]
		[FieldOffset(Offset = "0x60")]
		internal string ids;

		[Token(Token = "0x600B90A")]
		[Address(RVA = "0x546640", Offset = "0x545840", VA = "0x180546640")]
		public PathBase()
		{
		}
	}

	[Token(Token = "0x2001C83")]
	internal class PathStandard : PathBase
	{
		[Token(Token = "0x600B90B")]
		[Address(RVA = "0x5478F0", Offset = "0x546AF0", VA = "0x1805478F0")]
		internal PathStandard(int id, bool isRental)
		{
		}
	}

	[Token(Token = "0x2001C84")]
	internal class PathRateDuel : PathBase
	{
		[Token(Token = "0x600B90C")]
		[Address(RVA = "0x547740", Offset = "0x546940", VA = "0x180547740")]
		internal PathRateDuel(int id, bool isRental, int seasonID = 1)
		{
		}
	}

	[Token(Token = "0x2001C85")]
	internal class PathFree : PathBase
	{
		[Token(Token = "0x600B90D")]
		[Address(RVA = "0x547260", Offset = "0x546460", VA = "0x180547260")]
		internal PathFree(int id)
		{
		}
	}

	[Token(Token = "0x2001C86")]
	internal class PathTournament : PathBase
	{
		[Token(Token = "0x600B90E")]
		[Address(RVA = "0x547A80", Offset = "0x546C80", VA = "0x180547A80")]
		internal PathTournament(int id)
		{
		}
	}

	[Token(Token = "0x2001C87")]
	internal class PathExhibition : PathBase
	{
		[Token(Token = "0x600B90F")]
		[Address(RVA = "0x546F90", Offset = "0x546190", VA = "0x180546F90")]
		internal PathExhibition(int identifier, bool isRental)
		{
		}
	}

	[Token(Token = "0x2001C88")]
	internal class PathDuelistCup : PathBase
	{
		[Token(Token = "0x600B910")]
		[Address(RVA = "0x546E50", Offset = "0x546050", VA = "0x180546E50")]
		internal PathDuelistCup()
		{
		}
	}

	[Token(Token = "0x2001C89")]
	internal class PathRankEvent : PathBase
	{
		[Token(Token = "0x600B911")]
		[Address(RVA = "0x547560", Offset = "0x546760", VA = "0x180547560")]
		internal PathRankEvent(int id)
		{
		}
	}

	[Token(Token = "0x2001C8A")]
	internal class PathDuelTrial : PathBase
	{
		[Token(Token = "0x600B912")]
		[Address(RVA = "0x546AF0", Offset = "0x545CF0", VA = "0x180546AF0")]
		internal PathDuelTrial(int identifier, bool isRental, int deckNo = 1)
		{
		}
	}

	[Token(Token = "0x2001C8B")]
	internal class PathWCS : PathBase
	{
		[Token(Token = "0x600B913")]
		[Address(RVA = "0x547FC0", Offset = "0x5471C0", VA = "0x180547FC0")]
		internal PathWCS()
		{
		}
	}

	[Token(Token = "0x2001C8C")]
	internal class PathVersus : PathBase
	{
		[Token(Token = "0x600B914")]
		[Address(RVA = "0x547C60", Offset = "0x546E60", VA = "0x180547C60")]
		internal PathVersus(int identifier, bool isRental, int deckNo = 1)
		{
		}
	}

	[Token(Token = "0x2001C8D")]
	internal class PathDiceRally : PathBase
	{
		[Token(Token = "0x600B915")]
		[Address(RVA = "0x546820", Offset = "0x545A20", VA = "0x180546820")]
		internal PathDiceRally(int identifier, bool isRental)
		{
		}
	}

	[Token(Token = "0x2001C8E")]
	internal class PathRDC : PathBase
	{
		[Token(Token = "0x600B916")]
		[Address(RVA = "0x5473B0", Offset = "0x5465B0", VA = "0x1805473B0")]
		internal PathRDC(bool isRental)
		{
		}
	}

	[Token(Token = "0x400FF24")]
	public const int BASE_CUP_LOGO_ID = 700;

	[Token(Token = "0x400FF25")]
	public const int BASE_DUELTRIAL_LOGO_ID = 110;

	[Token(Token = "0x400FF26")]
	public const int BASE_WCS_LOGO_ID = 300;

	[Token(Token = "0x400FF27")]
	public const int BASE_VERSUS_LOGO_ID = 401;

	[Token(Token = "0x400FF28")]
	public const int BASE_RDC_LOGO_ID = 500;

	[Token(Token = "0x400FF29")]
	[FieldOffset(Offset = "0x10")]
	private PathBase path;

	[Token(Token = "0x17001BD6")]
	public string DECK_LIST
	{
		[Token(Token = "0x600B8FF")]
		[Address(RVA = "0x5343D0", Offset = "0x5335D0", VA = "0x1805343D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BD7")]
	public string ACCESSORY_BOX
	{
		[Token(Token = "0x600B900")]
		[Address(RVA = "0x534310", Offset = "0x533510", VA = "0x180534310")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BD8")]
	public string ACCESSORY_SLEEVE
	{
		[Token(Token = "0x600B901")]
		[Address(RVA = "0x534330", Offset = "0x533530", VA = "0x180534330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BD9")]
	public string PICKCARDS_IDS
	{
		[Token(Token = "0x600B902")]
		[Address(RVA = "0x534430", Offset = "0x533630", VA = "0x180534430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDA")]
	public string PICKCARDS_R
	{
		[Token(Token = "0x600B903")]
		[Address(RVA = "0x534450", Offset = "0x533650", VA = "0x180534450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDB")]
	public string ARGKEY_ID_NAME
	{
		[Token(Token = "0x600B904")]
		[Address(RVA = "0x534350", Offset = "0x533550", VA = "0x180534350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDC")]
	public string DECK_LIST_ACCESSORY
	{
		[Token(Token = "0x600B905")]
		[Address(RVA = "0x534370", Offset = "0x533570", VA = "0x180534370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDD")]
	public string DECK_LIST_PICKCARDS_IDS
	{
		[Token(Token = "0x600B906")]
		[Address(RVA = "0x534390", Offset = "0x533590", VA = "0x180534390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDE")]
	public string DECK_LIST_PICKCARDS_R
	{
		[Token(Token = "0x600B907")]
		[Address(RVA = "0x5343B0", Offset = "0x5335B0", VA = "0x1805343B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BDF")]
	public string NAME_REG_ID
	{
		[Token(Token = "0x600B908")]
		[Address(RVA = "0x534410", Offset = "0x533610", VA = "0x180534410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BE0")]
	public object IDS
	{
		[Token(Token = "0x600B909")]
		[Address(RVA = "0x5343F0", Offset = "0x5335F0", VA = "0x1805343F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B8FD")]
	[Address(RVA = "0x533A30", Offset = "0x532C30", VA = "0x180533A30")]
	public ColosseumPathManager(ColosseumUtil.PlayMode playMode, int identifier)
	{
	}

	[Token(Token = "0x600B8FE")]
	[Address(RVA = "0x5340D0", Offset = "0x5332D0", VA = "0x1805340D0")]
	public ColosseumPathManager(ColosseumUtil.PlayMode playMode, bool isRental, int identifier, int identifier2 = 1)
	{
	}
}
