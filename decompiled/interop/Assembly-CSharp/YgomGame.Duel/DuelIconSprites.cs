using System;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;

namespace YgomGame.Duel;

[Token(Token = "0x200189C")]
public class DuelIconSprites : CardIconSprites
{
	[Serializable]
	[Token(Token = "0x200189D")]
	public struct PositionIconable
	{
		[Token(Token = "0x400E725")]
		[FieldOffset(Offset = "0x0")]
		public bool player;

		[Token(Token = "0x400E726")]
		[FieldOffset(Offset = "0x4")]
		public int position;

		[Token(Token = "0x400E727")]
		[FieldOffset(Offset = "0x8")]
		public Sprite icon;

		[Token(Token = "0x6009E8D")]
		[Address(RVA = "0xEC9FD0", Offset = "0xEC91D0", VA = "0x180EC9FD0")]
		public PositionIconable(bool _player, int _position, Sprite _icon)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200189E")]
	public struct CounterIconTable
	{
		[Token(Token = "0x400E728")]
		[FieldOffset(Offset = "0x0")]
		public Engine.CounterType counter;

		[Token(Token = "0x400E729")]
		[FieldOffset(Offset = "0x8")]
		public Sprite icon;

		[Token(Token = "0x6009E8E")]
		[Address(RVA = "0xD59140", Offset = "0xD58340", VA = "0x180D59140")]
		private CounterIconTable(Engine.CounterType _counter, Sprite _icon)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200189F")]
	public struct DuelLogIconTable
	{
		[Token(Token = "0x400E72A")]
		[FieldOffset(Offset = "0x0")]
		public LOGACTIONTYPE type;

		[Token(Token = "0x400E72B")]
		[FieldOffset(Offset = "0x8")]
		public Sprite icon;

		[Token(Token = "0x6009E8F")]
		[Address(RVA = "0xD59140", Offset = "0xD58340", VA = "0x180D59140")]
		private DuelLogIconTable(LOGACTIONTYPE _type, Sprite _icon)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20018A0")]
	public struct NumIconTable
	{
		[Token(Token = "0x400E72C")]
		[FieldOffset(Offset = "0x0")]
		public int number;

		[Token(Token = "0x400E72D")]
		[FieldOffset(Offset = "0x8")]
		public Sprite icon;

		[Token(Token = "0x6009E90")]
		[Address(RVA = "0xD59140", Offset = "0xD58340", VA = "0x180D59140")]
		private NumIconTable(int _number, Sprite _icon)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20018A1")]
	public struct BattleStepIcon
	{
		[Token(Token = "0x400E72E")]
		[FieldOffset(Offset = "0x0")]
		public Engine.StepType step;

		[Token(Token = "0x400E72F")]
		[FieldOffset(Offset = "0x8")]
		public Sprite icon;
	}

	[Serializable]
	[Token(Token = "0x20018A2")]
	public struct DamageStepIcon
	{
		[Token(Token = "0x400E730")]
		[FieldOffset(Offset = "0x0")]
		public Engine.DmgStepType step;

		[Token(Token = "0x400E731")]
		[FieldOffset(Offset = "0x8")]
		public Sprite icon;
	}

	[Serializable]
	[Token(Token = "0x20018A3")]
	public struct ListTypeIcon
	{
		[Token(Token = "0x400E732")]
		[FieldOffset(Offset = "0x0")]
		public GenericCardListController.ListType type;

		[Token(Token = "0x400E733")]
		[FieldOffset(Offset = "0x8")]
		public Sprite icon;
	}

	[Serializable]
	[Token(Token = "0x20018A4")]
	public struct DiceIconTable
	{
		[Token(Token = "0x400E734")]
		[FieldOffset(Offset = "0x0")]
		public int dicenum;

		[Token(Token = "0x400E735")]
		[FieldOffset(Offset = "0x4")]
		public bool isnear;

		[Token(Token = "0x400E736")]
		[FieldOffset(Offset = "0x8")]
		public Sprite sprite;
	}

	[Serializable]
	[Token(Token = "0x20018A5")]
	public struct CoinIconTable
	{
		[Token(Token = "0x400E737")]
		[FieldOffset(Offset = "0x0")]
		public bool face;

		[Token(Token = "0x400E738")]
		[FieldOffset(Offset = "0x1")]
		public bool isnear;

		[Token(Token = "0x400E739")]
		[FieldOffset(Offset = "0x8")]
		public Sprite sprite;
	}

	[Serializable]
	[Token(Token = "0x20018A6")]
	public struct FirstPlayerCoinIconTable
	{
		[Token(Token = "0x400E73A")]
		[FieldOffset(Offset = "0x0")]
		public bool face;

		[Token(Token = "0x400E73B")]
		[FieldOffset(Offset = "0x8")]
		public Sprite sprite;
	}

	[Serializable]
	[Token(Token = "0x20018A7")]
	public struct StateIconTable
	{
		[Token(Token = "0x400E73C")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x400E73D")]
		[FieldOffset(Offset = "0x8")]
		public int stateID;

		[Token(Token = "0x400E73E")]
		[FieldOffset(Offset = "0x10")]
		public Sprite sprite;
	}

	[Token(Token = "0x400E700")]
	[FieldOffset(Offset = "0x0")]
	private static DuelIconSprites m_Instance;

	[Token(Token = "0x400E701")]
	private const string PATH = "Duel/ScriptableObject/DuelIconObject";

	[Token(Token = "0x400E702")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Sprite[] circle;

	[Token(Token = "0x400E703")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PositionIconable[] positionIcons;

	[Token(Token = "0x400E704")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Sprite iconFieldAreaNear;

	[Token(Token = "0x400E705")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Sprite iconFieldAreaFar;

	[Token(Token = "0x400E706")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Sprite iconFieldZone;

	[Token(Token = "0x400E707")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Sprite iconCheckTiming;

	[Token(Token = "0x400E708")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Sprite iconTuner;

	[Token(Token = "0x400E709")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Sprite iconOverlay;

	[Token(Token = "0x400E70A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Sprite iconCardMoveArrow;

	[Token(Token = "0x400E70B")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Sprite iconAttackArrow;

	[Token(Token = "0x400E70C")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Sprite iconCslGroupBgI;

	[Token(Token = "0x400E70D")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Sprite iconCslGroupBgO;

	[Token(Token = "0x400E70E")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Sprite iconCslGroupBgL;

	[Token(Token = "0x400E70F")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Sprite iconCslGroupBgR;

	[Token(Token = "0x400E710")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Sprite iconLevel;

	[Token(Token = "0x400E711")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Sprite iconRank;

	[Token(Token = "0x400E712")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	private Sprite iconScale;

	[Token(Token = "0x400E713")]
	[FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private Sprite iconTurnCount;

	[Token(Token = "0x400E714")]
	[FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private CounterIconTable[] counterIcons;

	[Token(Token = "0x400E715")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private Sprite disableIcon;

	[Token(Token = "0x400E716")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private Sprite unAttackableIcon;

	[Token(Token = "0x400E717")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private DuelLogIconTable[] duellogIcons;

	[Token(Token = "0x400E718")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private NumIconTable[] numberIcons;

	[Token(Token = "0x400E719")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private NumIconTable[] numberIconsForDuelChain;

	[Token(Token = "0x400E71A")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private BattleStepIcon[] battleStepIcons;

	[Token(Token = "0x400E71B")]
	[FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private DamageStepIcon[] damageStepIcons;

	[Token(Token = "0x400E71C")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	private ListTypeIcon[] listTypeIcon;

	[Token(Token = "0x400E71D")]
	[FieldOffset(Offset = "0x108")]
	[SerializeField]
	private DiceIconTable[] diceIcons;

	[Token(Token = "0x400E71E")]
	[FieldOffset(Offset = "0x110")]
	[SerializeField]
	private CoinIconTable[] coinIcons;

	[Token(Token = "0x400E71F")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private FirstPlayerCoinIconTable[] firstCoinIcons;

	[Token(Token = "0x400E720")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private StateIconTable[] stateIcons;

	[Token(Token = "0x400E721")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private StateIconTable[] attachedStateIcons;

	[Token(Token = "0x400E722")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	private Sprite attachedIconBGBlue;

	[Token(Token = "0x400E723")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private Sprite attachedIconBGRed;

	[Token(Token = "0x400E724")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private Sprite attachedIconBGBoth;

	[Token(Token = "0x1700181F")]
	public new static DuelIconSprites instance
	{
		[Token(Token = "0x6009E6F")]
		[Address(RVA = "0xEB7320", Offset = "0xEB6520", VA = "0x180EB7320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009E70")]
	[Address(RVA = "0xEB6D10", Offset = "0xEB5F10", VA = "0x180EB6D10")]
	public Sprite GetCircle(bool myself)
	{
		return null;
	}

	[Token(Token = "0x6009E71")]
	[Address(RVA = "0xEB71C0", Offset = "0xEB63C0", VA = "0x180EB71C0")]
	public Sprite GetPosIcon(int player, int position)
	{
		return null;
	}

	[Token(Token = "0x6009E72")]
	[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
	public Sprite GetLevelIcon()
	{
		return null;
	}

	[Token(Token = "0x6009E73")]
	[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
	public Sprite GetRankIcon()
	{
		return null;
	}

	[Token(Token = "0x6009E74")]
	[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
	public Sprite GetScaleIcon()
	{
		return null;
	}

	[Token(Token = "0x6009E75")]
	[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
	public Sprite GetTunerIcon()
	{
		return null;
	}

	[Token(Token = "0x6009E76")]
	[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
	public Sprite GetOverlayIcon()
	{
		return null;
	}

	[Token(Token = "0x6009E77")]
	[Address(RVA = "0xEB6F90", Offset = "0xEB6190", VA = "0x180EB6F90")]
	public Sprite GetFieldAreaIcon(int player)
	{
		return null;
	}

	[Token(Token = "0x6009E78")]
	[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
	public Sprite GetFieldZoneIcon()
	{
		return null;
	}

	[Token(Token = "0x6009E79")]
	[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
	public Sprite GetCheckTimingIcon()
	{
		return null;
	}

	[Token(Token = "0x6009E7A")]
	[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
	public Sprite GetTurnCountIcon()
	{
		return null;
	}

	[Token(Token = "0x6009E7B")]
	[Address(RVA = "0xEB6AF0", Offset = "0xEB5CF0", VA = "0x180EB6AF0")]
	public Sprite GetArrowIcon(bool isbattlearrow)
	{
		return null;
	}

	[Token(Token = "0x6009E7C")]
	[Address(RVA = "0xEB6DC0", Offset = "0xEB5FC0", VA = "0x180EB6DC0")]
	public Sprite GetCounterIcon(Engine.CounterType counter)
	{
		return null;
	}

	[Token(Token = "0x6009E7D")]
	[Address(RVA = "0xEB6EB0", Offset = "0xEB60B0", VA = "0x180EB6EB0")]
	public Sprite GetDiceIcon(int dicenum, bool isnear)
	{
		return null;
	}

	[Token(Token = "0x6009E7E")]
	[Address(RVA = "0xEB6F20", Offset = "0xEB6120", VA = "0x180EB6F20")]
	public Sprite GetDuelLogIcon(LOGACTIONTYPE type)
	{
		return null;
	}

	[Token(Token = "0x6009E7F")]
	[Address(RVA = "0xEB7150", Offset = "0xEB6350", VA = "0x180EB7150")]
	public Sprite GetNumberIcon(int number)
	{
		return null;
	}

	[Token(Token = "0x6009E80")]
	[Address(RVA = "0xEB70E0", Offset = "0xEB62E0", VA = "0x180EB70E0")]
	public Sprite GetNumberIconForDuelChain(int number)
	{
		return null;
	}

	[Token(Token = "0x6009E81")]
	[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
	public Sprite GetDisableIcon()
	{
		return null;
	}

	[Token(Token = "0x6009E82")]
	[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
	public Sprite GetUnAttackableIcon()
	{
		return null;
	}

	[Token(Token = "0x6009E83")]
	[Address(RVA = "0xEB6C60", Offset = "0xEB5E60", VA = "0x180EB6C60")]
	public Sprite GetBattleStepIcon(Engine.StepType step)
	{
		return null;
	}

	[Token(Token = "0x6009E84")]
	[Address(RVA = "0xEB6E40", Offset = "0xEB6040", VA = "0x180EB6E40")]
	public Sprite GetDamageStepIcon(Engine.DmgStepType step)
	{
		return null;
	}

	[Token(Token = "0x6009E85")]
	[Address(RVA = "0xEB7070", Offset = "0xEB6270", VA = "0x180EB7070")]
	public Sprite GetListTypeIcon(GenericCardListController.ListType type)
	{
		return null;
	}

	[Token(Token = "0x6009E86")]
	[Address(RVA = "0xEB6CD0", Offset = "0xEB5ED0", VA = "0x180EB6CD0")]
	public Sprite GetCardSelectionListGroupBg(int index)
	{
		return null;
	}

	[Token(Token = "0x6009E87")]
	[Address(RVA = "0xEB6D50", Offset = "0xEB5F50", VA = "0x180EB6D50")]
	public Sprite GetCoinIcon(bool face, bool isnear = false)
	{
		return null;
	}

	[Token(Token = "0x6009E88")]
	[Address(RVA = "0xEB7000", Offset = "0xEB6200", VA = "0x180EB7000")]
	public Sprite GetFirstPlayerCoinIcon(bool face)
	{
		return null;
	}

	[Token(Token = "0x6009E89")]
	[Address(RVA = "0xEB72B0", Offset = "0xEB64B0", VA = "0x180EB72B0")]
	public Sprite GetStateIcon(int stateID)
	{
		return null;
	}

	[Token(Token = "0x6009E8A")]
	[Address(RVA = "0xEB6BF0", Offset = "0xEB5DF0", VA = "0x180EB6BF0")]
	public Sprite GetAttachedIcon(int stateID)
	{
		return null;
	}

	[Token(Token = "0x6009E8B")]
	[Address(RVA = "0xEB6B50", Offset = "0xEB5D50", VA = "0x180EB6B50")]
	public Sprite GetAttachedIconBG(int player, bool rival, bool both)
	{
		return null;
	}

	[Token(Token = "0x6009E8C")]
	[Address(RVA = "0x567800", Offset = "0x566A00", VA = "0x180567800")]
	public DuelIconSprites()
	{
	}
}
