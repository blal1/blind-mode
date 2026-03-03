using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Colosseum;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Home;

[Token(Token = "0x2000D49")]
public class HomeDuelShortcutWidget : ElementWidgetBase
{
	[Token(Token = "0x2000D4A")]
	public enum PrefabType
	{
		[Token(Token = "0x4009E95")]
		EVENT,
		[Token(Token = "0x4009E96")]
		RANK,
		[Token(Token = "0x4009E97")]
		WCS
	}

	[Token(Token = "0x2000D4B")]
	private abstract class DuelShortcutBehaviourBase
	{
		[Token(Token = "0x4009E98")]
		[FieldOffset(Offset = "0x10")]
		protected ElementObjectManager eom;

		[Token(Token = "0x4009E99")]
		[FieldOffset(Offset = "0x18")]
		protected ElementObjectManager imageEom;

		[Token(Token = "0x4009E9A")]
		[FieldOffset(Offset = "0x20")]
		protected ColosseumUtil.PlayMode mode;

		[Token(Token = "0x4009E9B")]
		[FieldOffset(Offset = "0x28")]
		protected Dictionary<string, object> duelShortcutInfo;

		[Token(Token = "0x4009E9C")]
		[FieldOffset(Offset = "0x30")]
		protected int eventId;

		[Token(Token = "0x4009E9D")]
		[FieldOffset(Offset = "0x38")]
		protected readonly string k_ERootEvent;

		[Token(Token = "0x4009E9E")]
		[FieldOffset(Offset = "0x40")]
		protected readonly string k_ERootRank;

		[Token(Token = "0x4009E9F")]
		[FieldOffset(Offset = "0x48")]
		protected readonly string k_ERootWCS;

		[Token(Token = "0x4009EA0")]
		[FieldOffset(Offset = "0x50")]
		protected readonly string k_EImageLogo;

		[Token(Token = "0x4009EA1")]
		[FieldOffset(Offset = "0x58")]
		protected readonly string k_EImageBg;

		[Token(Token = "0x4009EA2")]
		[FieldOffset(Offset = "0x60")]
		protected readonly string k_ENextItem;

		[Token(Token = "0x4009EA3")]
		[FieldOffset(Offset = "0x68")]
		protected readonly string k_ETextHead;

		[Token(Token = "0x4009EA4")]
		[FieldOffset(Offset = "0x70")]
		protected readonly string k_EImageItem;

		[Token(Token = "0x4009EA5")]
		[FieldOffset(Offset = "0x78")]
		protected readonly string k_ETextBottom;

		[Token(Token = "0x17000B93")]
		protected virtual string eventIdName
		{
			[Token(Token = "0x6005055")]
			[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B94")]
		protected virtual string logoIdName
		{
			[Token(Token = "0x6005056")]
			[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005057")]
		[Address(RVA = "0x96BB20", Offset = "0x96AD20", VA = "0x18096BB20")]
		protected DuelShortcutBehaviourBase(ElementObjectManager eom, ColosseumUtil.PlayMode mode, Dictionary<string, object> duelShortcutInfo)
		{
		}

		[Token(Token = "0x6005058")]
		public abstract bool UpdateDisp();

		[Token(Token = "0x6005059")]
		[Address(RVA = "0x96BA40", Offset = "0x96AC40", VA = "0x18096BA40", Slot = "7")]
		protected virtual void SetRootPrefab(PrefabType prefabType)
		{
		}
	}

	[Token(Token = "0x2000D4C")]
	private abstract class DuelShortcutBehaviourEventBase : DuelShortcutBehaviourBase
	{
		[Token(Token = "0x4009EA6")]
		[FieldOffset(Offset = "0x80")]
		protected PrefabType prefabType;

		[Token(Token = "0x600505A")]
		[Address(RVA = "0x96B990", Offset = "0x96AB90", VA = "0x18096B990")]
		protected DuelShortcutBehaviourEventBase(ElementObjectManager eom, ColosseumUtil.PlayMode mode, Dictionary<string, object> duelShortcutInfo)
		{
		}

		[Token(Token = "0x600505B")]
		protected abstract void SetLogo(Dictionary<string, object> masterInfo);

		[Token(Token = "0x600505C")]
		protected abstract void OnClick();

		[Token(Token = "0x600505D")]
		[Address(RVA = "0x96BCF0", Offset = "0x96AEF0", VA = "0x18096BCF0", Slot = "10")]
		protected virtual void Init(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x600505E")]
		[Address(RVA = "0x96BD60", Offset = "0x96AF60", VA = "0x18096BD60", Slot = "6")]
		public override bool UpdateDisp()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000D4D")]
	private class StandardBehaviour : DuelShortcutBehaviourBase
	{
		[Token(Token = "0x4009EA7")]
		[FieldOffset(Offset = "0x80")]
		protected readonly string k_ETextTitle;

		[Token(Token = "0x4009EA8")]
		[FieldOffset(Offset = "0x88")]
		protected readonly string k_ETextTitleMargine;

		[Token(Token = "0x4009EA9")]
		[FieldOffset(Offset = "0x90")]
		protected readonly string k_ETextTitle_Center;

		[Token(Token = "0x600505F")]
		[Address(RVA = "0x9791C0", Offset = "0x9783C0", VA = "0x1809791C0")]
		public StandardBehaviour(ElementObjectManager eom, ColosseumUtil.PlayMode mode, Dictionary<string, object> duelShortcutInfo)
		{
		}

		[Token(Token = "0x6005060")]
		[Address(RVA = "0x9786F0", Offset = "0x9778F0", VA = "0x1809786F0", Slot = "6")]
		public override bool UpdateDisp()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000D4F")]
	private class DuelistCupBehaviour : DuelShortcutBehaviourEventBase
	{
		[Token(Token = "0x17000B95")]
		protected override string eventIdName
		{
			[Token(Token = "0x6005067")]
			[Address(RVA = "0x96C940", Offset = "0x96BB40", VA = "0x18096C940", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B96")]
		protected override string logoIdName
		{
			[Token(Token = "0x6005068")]
			[Address(RVA = "0x96C970", Offset = "0x96BB70", VA = "0x18096C970", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005069")]
		[Address(RVA = "0x96B990", Offset = "0x96AB90", VA = "0x18096B990")]
		public DuelistCupBehaviour(ElementObjectManager eom, ColosseumUtil.PlayMode mode, Dictionary<string, object> duelShortcutInfo)
		{
		}

		[Token(Token = "0x600506A")]
		[Address(RVA = "0x96C6B0", Offset = "0x96B8B0", VA = "0x18096C6B0", Slot = "8")]
		protected override void SetLogo(Dictionary<string, object> masterInfo)
		{
		}

		[Token(Token = "0x600506B")]
		[Address(RVA = "0x96C580", Offset = "0x96B780", VA = "0x18096C580", Slot = "9")]
		protected override void OnClick()
		{
		}
	}

	[Token(Token = "0x2000D51")]
	private class WcsBehaviour : DuelShortcutBehaviourEventBase
	{
		[Token(Token = "0x17000B97")]
		protected override string eventIdName
		{
			[Token(Token = "0x600506F")]
			[Address(RVA = "0x97DA00", Offset = "0x97CC00", VA = "0x18097DA00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B98")]
		protected override string logoIdName
		{
			[Token(Token = "0x6005070")]
			[Address(RVA = "0x97DA30", Offset = "0x97CC30", VA = "0x18097DA30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005071")]
		[Address(RVA = "0x96B990", Offset = "0x96AB90", VA = "0x18096B990")]
		public WcsBehaviour(ElementObjectManager eom, ColosseumUtil.PlayMode mode, Dictionary<string, object> duelShortcutInfo)
		{
		}

		[Token(Token = "0x6005072")]
		[Address(RVA = "0x97D5D0", Offset = "0x97C7D0", VA = "0x18097D5D0", Slot = "10")]
		protected override void Init(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6005073")]
		[Address(RVA = "0x97D770", Offset = "0x97C970", VA = "0x18097D770", Slot = "8")]
		protected override void SetLogo(Dictionary<string, object> masterInfo)
		{
		}

		[Token(Token = "0x6005074")]
		[Address(RVA = "0x97D640", Offset = "0x97C840", VA = "0x18097D640", Slot = "9")]
		protected override void OnClick()
		{
		}
	}

	[Token(Token = "0x2000D53")]
	private class RDCBehaviour : DuelShortcutBehaviourEventBase
	{
		[Token(Token = "0x17000B99")]
		protected override string eventIdName
		{
			[Token(Token = "0x6005078")]
			[Address(RVA = "0x9784D0", Offset = "0x9776D0", VA = "0x1809784D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B9A")]
		protected override string logoIdName
		{
			[Token(Token = "0x6005079")]
			[Address(RVA = "0x978500", Offset = "0x977700", VA = "0x180978500", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600507A")]
		[Address(RVA = "0x96B990", Offset = "0x96AB90", VA = "0x18096B990")]
		public RDCBehaviour(ElementObjectManager eom, ColosseumUtil.PlayMode mode, Dictionary<string, object> duelShortcutInfo)
		{
		}

		[Token(Token = "0x600507B")]
		[Address(RVA = "0x978240", Offset = "0x977440", VA = "0x180978240", Slot = "8")]
		protected override void SetLogo(Dictionary<string, object> masterInfo)
		{
		}

		[Token(Token = "0x600507C")]
		[Address(RVA = "0x978110", Offset = "0x977310", VA = "0x180978110", Slot = "9")]
		protected override void OnClick()
		{
		}
	}

	[Token(Token = "0x2000D55")]
	private class ExhibitionBehaviour : DuelShortcutBehaviourEventBase
	{
		[Token(Token = "0x17000B9B")]
		protected override string eventIdName
		{
			[Token(Token = "0x6005080")]
			[Address(RVA = "0x96CC40", Offset = "0x96BE40", VA = "0x18096CC40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B9C")]
		protected override string logoIdName
		{
			[Token(Token = "0x6005081")]
			[Address(RVA = "0x96CC70", Offset = "0x96BE70", VA = "0x18096CC70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005082")]
		[Address(RVA = "0x96B990", Offset = "0x96AB90", VA = "0x18096B990")]
		public ExhibitionBehaviour(ElementObjectManager eom, ColosseumUtil.PlayMode mode, Dictionary<string, object> duelShortcutInfo)
		{
		}

		[Token(Token = "0x6005083")]
		[Address(RVA = "0x96CAE0", Offset = "0x96BCE0", VA = "0x18096CAE0", Slot = "8")]
		protected override void SetLogo(Dictionary<string, object> masterInfo)
		{
		}

		[Token(Token = "0x6005084")]
		[Address(RVA = "0x96C9A0", Offset = "0x96BBA0", VA = "0x18096C9A0", Slot = "9")]
		protected override void OnClick()
		{
		}
	}

	[Token(Token = "0x2000D57")]
	private class VersusBehaviour : DuelShortcutBehaviourEventBase
	{
		[Token(Token = "0x17000B9D")]
		protected override string eventIdName
		{
			[Token(Token = "0x6005088")]
			[Address(RVA = "0x97D570", Offset = "0x97C770", VA = "0x18097D570", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000B9E")]
		protected override string logoIdName
		{
			[Token(Token = "0x6005089")]
			[Address(RVA = "0x97D5A0", Offset = "0x97C7A0", VA = "0x18097D5A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600508A")]
		[Address(RVA = "0x96B990", Offset = "0x96AB90", VA = "0x18096B990")]
		public VersusBehaviour(ElementObjectManager eom, ColosseumUtil.PlayMode mode, Dictionary<string, object> duelShortcutInfo)
		{
		}

		[Token(Token = "0x600508B")]
		[Address(RVA = "0x97D410", Offset = "0x97C610", VA = "0x18097D410", Slot = "8")]
		protected override void SetLogo(Dictionary<string, object> masterInfo)
		{
		}

		[Token(Token = "0x600508C")]
		[Address(RVA = "0x97D2D0", Offset = "0x97C4D0", VA = "0x18097D2D0", Slot = "9")]
		protected override void OnClick()
		{
		}
	}

	[Token(Token = "0x2000D59")]
	private class DuelTrialBehaviour : DuelShortcutBehaviourEventBase
	{
		[Token(Token = "0x17000B9F")]
		protected override string eventIdName
		{
			[Token(Token = "0x6005090")]
			[Address(RVA = "0x96C520", Offset = "0x96B720", VA = "0x18096C520", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA0")]
		protected override string logoIdName
		{
			[Token(Token = "0x6005091")]
			[Address(RVA = "0x96C550", Offset = "0x96B750", VA = "0x18096C550", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005092")]
		[Address(RVA = "0x96B990", Offset = "0x96AB90", VA = "0x18096B990")]
		public DuelTrialBehaviour(ElementObjectManager eom, ColosseumUtil.PlayMode mode, Dictionary<string, object> duelShortcutInfo)
		{
		}

		[Token(Token = "0x6005093")]
		[Address(RVA = "0x96C3C0", Offset = "0x96B5C0", VA = "0x18096C3C0", Slot = "8")]
		protected override void SetLogo(Dictionary<string, object> masterInfo)
		{
		}

		[Token(Token = "0x6005094")]
		[Address(RVA = "0x96C280", Offset = "0x96B480", VA = "0x18096C280", Slot = "9")]
		protected override void OnClick()
		{
		}
	}

	[Token(Token = "0x2000D5B")]
	private class DiceRallyBehaviour : DuelShortcutBehaviourEventBase
	{
		[Token(Token = "0x17000BA1")]
		protected override string eventIdName
		{
			[Token(Token = "0x6005098")]
			[Address(RVA = "0x96B9E0", Offset = "0x96ABE0", VA = "0x18096B9E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BA2")]
		protected override string logoIdName
		{
			[Token(Token = "0x6005099")]
			[Address(RVA = "0x96BA10", Offset = "0x96AC10", VA = "0x18096BA10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600509A")]
		[Address(RVA = "0x96B990", Offset = "0x96AB90", VA = "0x18096B990")]
		public DiceRallyBehaviour(ElementObjectManager eom, ColosseumUtil.PlayMode mode, Dictionary<string, object> duelShortcutInfo)
		{
		}

		[Token(Token = "0x600509B")]
		[Address(RVA = "0x96B830", Offset = "0x96AA30", VA = "0x18096B830", Slot = "8")]
		protected override void SetLogo(Dictionary<string, object> masterInfo)
		{
		}

		[Token(Token = "0x600509C")]
		[Address(RVA = "0x96B6F0", Offset = "0x96A8F0", VA = "0x18096B6F0", Slot = "9")]
		protected override void OnClick()
		{
		}
	}

	[Token(Token = "0x6005053")]
	[Address(RVA = "0x96E7C0", Offset = "0x96D9C0", VA = "0x18096E7C0")]
	public HomeDuelShortcutWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005054")]
	[Address(RVA = "0x96E4A0", Offset = "0x96D6A0", VA = "0x18096E4A0")]
	private void Init()
	{
	}
}
