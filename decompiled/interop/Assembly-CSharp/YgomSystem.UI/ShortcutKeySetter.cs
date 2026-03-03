using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomSystem.UI;

[Token(Token = "0x20004C6")]
public class ShortcutKeySetter : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20004C7")]
	public class Setting
	{
		[Token(Token = "0x40017A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Tooltip("ショートカットを割当てるSelectionButtonのラベル")]
		private string m_ButtonLabel;

		[Token(Token = "0x40017AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("ショートカットキーの指定")]
		private SelectorManager.KeyType m_KeyType;

		[Token(Token = "0x40017AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("ショートカットキー(サブ)の指定")]
		private SelectorManager.KeyType m_KeyTypeSub;

		[Token(Token = "0x40017AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("キーアイコンSpriteをセットするImageのラベル")]
		private string m_IconLabel;

		[Token(Token = "0x40017AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("キーアイコンで使用するバリエーション")]
		private GamePadIconUtil.Variation m_IconVariation;

		[Token(Token = "0x17000336")]
		public string buttonLabel
		{
			[Token(Token = "0x6001FCF")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD0")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			set
			{
			}
		}

		[Token(Token = "0x17000337")]
		public SelectorManager.KeyType keyType
		{
			[Token(Token = "0x6001FD1")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			get
			{
				return default(SelectorManager.KeyType);
			}
			[Token(Token = "0x6001FD2")]
			[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000338")]
		public SelectorManager.KeyType keyTypeSub
		{
			[Token(Token = "0x6001FD3")]
			[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
			get
			{
				return default(SelectorManager.KeyType);
			}
			[Token(Token = "0x6001FD4")]
			[Address(RVA = "0x62E250", Offset = "0x62D450", VA = "0x18062E250")]
			set
			{
			}
		}

		[Token(Token = "0x17000339")]
		public string iconLabel
		{
			[Token(Token = "0x6001FD5")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD6")]
			[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
			set
			{
			}
		}

		[Token(Token = "0x1700033A")]
		public GamePadIconUtil.Variation iconVariation
		{
			[Token(Token = "0x6001FD7")]
			[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
			get
			{
				return default(GamePadIconUtil.Variation);
			}
			[Token(Token = "0x6001FD8")]
			[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
			set
			{
			}
		}

		[Token(Token = "0x6001FD9")]
		[Address(RVA = "0x62E1B0", Offset = "0x62D3B0", VA = "0x18062E1B0")]
		public Setting()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20004C8")]
	public class MouseSetting
	{
		[Token(Token = "0x40017AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Tooltip("ショートカットを割当てるSelectionButtonのラベル")]
		private string m_ButtonLabel;

		[Token(Token = "0x40017AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("ショートカットキーの指定。Sub1:右クリック")]
		private SelectorManager.MouseType m_MouseType;

		[Token(Token = "0x1700033B")]
		public string buttonLabel
		{
			[Token(Token = "0x6001FDA")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FDB")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			set
			{
			}
		}

		[Token(Token = "0x1700033C")]
		public SelectorManager.MouseType mouseType
		{
			[Token(Token = "0x6001FDC")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			get
			{
				return default(SelectorManager.MouseType);
			}
			[Token(Token = "0x6001FDD")]
			[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
			set
			{
			}
		}

		[Token(Token = "0x6001FDE")]
		[Address(RVA = "0x615A60", Offset = "0x614C60", VA = "0x180615A60")]
		public MouseSetting()
		{
		}
	}

	[Token(Token = "0x40017A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_MouseCancelLabel;

	[Token(Token = "0x40017A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string[] m_MouseCancelAdditionalLabels;

	[Token(Token = "0x40017A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Setting[] m_Settings;

	[Token(Token = "0x40017A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_LoadingCount;

	[Token(Token = "0x17000335")]
	public bool isLoading
	{
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x62F1A0", Offset = "0x62E3A0", VA = "0x18062F1A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001FC6")]
	[Address(RVA = "0x62E260", Offset = "0x62D460", VA = "0x18062E260")]
	public void Initialize([Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6001FC7")]
	[Address(RVA = "0x62E2C0", Offset = "0x62D4C0", VA = "0x18062E2C0")]
	public void Initialize(ElementObjectManager eom, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6001FC8")]
	[Address(RVA = "0x62F0F0", Offset = "0x62E2F0", VA = "0x18062F0F0")]
	public static bool SetShortcut(ElementObjectManager eom, Setting setting, [Optional] Action onComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FC9")]
	[Address(RVA = "0x62F060", Offset = "0x62E260", VA = "0x18062F060")]
	public static bool SetShortcut(ElementObjectManager eom, string buttonLabel, string iconLabel, SelectorManager.KeyType keyType, SelectorManager.KeyType keyTypeSub = SelectorManager.KeyType.None, GamePadIconUtil.Variation iconVariation = GamePadIconUtil.Variation.Var00, [Optional] Action onComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FCA")]
	[Address(RVA = "0x62EFA0", Offset = "0x62E1A0", VA = "0x18062EFA0")]
	public static bool SetShortcutKey(ElementObjectManager eom, string buttonLabel, SelectorManager.KeyType keyType, SelectorManager.KeyType keyTypeSub = SelectorManager.KeyType.None)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FCB")]
	[Address(RVA = "0x62E6F0", Offset = "0x62D8F0", VA = "0x18062E6F0")]
	public static bool SetShortcutIcon(ElementObjectManager eom, string iconLabel, SelectorManager.KeyType keyType, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00, [Optional] Action onComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FCC")]
	[Address(RVA = "0x62E930", Offset = "0x62DB30", VA = "0x18062E930")]
	public static bool SetShortcutIcon(ElementObjectManager eom, string iconLabelMain, string iconLabelSub, string iconLabelPlus, SelectorManager.KeyType keyTypeMain, SelectorManager.KeyType keyTypeSub, GamePadIconUtil.Variation variationMain = GamePadIconUtil.Variation.Var00, GamePadIconUtil.Variation variationSub = GamePadIconUtil.Variation.Var00, [Optional] Action onComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FCD")]
	[Address(RVA = "0x62E640", Offset = "0x62D840", VA = "0x18062E640")]
	public static bool SetMouseCancelShortcutKey(ElementObjectManager eom, string buttonLabel)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ShortcutKeySetter()
	{
	}
}
