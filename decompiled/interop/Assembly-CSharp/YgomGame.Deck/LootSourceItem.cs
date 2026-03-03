using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomGame.Card;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Deck;

[Token(Token = "0x20010FE")]
public class LootSourceItem : MonoBehaviour
{
	[Token(Token = "0x400B39D")]
	private const string LABEL_SBN_BUTTON = "Button";

	[Token(Token = "0x400B39E")]
	private const string LABEL_TXT_SOURCETEXT = "TextSource";

	[Token(Token = "0x400B39F")]
	private const string LABEL_TXT_TITLETEXT = "TextTitle";

	[Token(Token = "0x400B3A0")]
	private const string LABEL_RT_IMAGESUMMARY = "ImageSummary";

	[Token(Token = "0x400B3A1")]
	private const string LABEL_IMG_IMAGESUMMARY = "ImageSummary";

	[Token(Token = "0x400B3A2")]
	private const string LABEL_RT_ON = "On";

	[Token(Token = "0x400B3A3")]
	private const string LABEL_RT_OFF = "Off";

	[Token(Token = "0x400B3A4")]
	private const string LABEL_RT_MASK = "Mask";

	[Token(Token = "0x400B3A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected UnityAction m_OnClickAction;

	[Token(Token = "0x400B3A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected UnityAction m_OnSelectedAction;

	[Token(Token = "0x400B3AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected UnityAction m_OnDeselectedAction;

	[Token(Token = "0x400B3AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected UnityAction<bool> m_OnRightClickAction;

	[Token(Token = "0x400B3AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected UnityAction m_SelectedKeySub1Action;

	[Token(Token = "0x400B3AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected UnityAction m_SelectedKeyLeftAction;

	[Token(Token = "0x400B3AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected UnityAction m_SelectedKeyL2Action;

	[Token(Token = "0x17001105")]
	public LootSourceInfo.LootCategory m_Category
	{
		[Token(Token = "0x6006AAD")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		[CompilerGenerated]
		get
		{
			return default(LootSourceInfo.LootCategory);
		}
		[Token(Token = "0x6006AAE")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001106")]
	public string m_StringID
	{
		[Token(Token = "0x6006AAF")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006AB0")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001107")]
	public bool m_IsAvailable
	{
		[Token(Token = "0x6006AB1")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006AB2")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001108")]
	private ElementObjectManager m_eom
	{
		[Token(Token = "0x6006AB3")]
		[Address(RVA = "0xB1A960", Offset = "0xB19B60", VA = "0x180B1A960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001109")]
	private SelectionButton m_Button
	{
		[Token(Token = "0x6006AB4")]
		[Address(RVA = "0xB1A4E0", Offset = "0xB196E0", VA = "0x180B1A4E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700110A")]
	private ExtendedTextMeshProUGUI m_SourceText
	{
		[Token(Token = "0x6006AB5")]
		[Address(RVA = "0xB1A840", Offset = "0xB19A40", VA = "0x180B1A840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700110B")]
	private ExtendedTextMeshProUGUI m_TitleText
	{
		[Token(Token = "0x6006AB6")]
		[Address(RVA = "0xB1A8D0", Offset = "0xB19AD0", VA = "0x180B1A8D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700110C")]
	private RectTransform m_ImageSummary
	{
		[Token(Token = "0x6006AB7")]
		[Address(RVA = "0xB1A600", Offset = "0xB19800", VA = "0x180B1A600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700110D")]
	private Image m_ImageSummaryIMG
	{
		[Token(Token = "0x6006AB8")]
		[Address(RVA = "0xB1A570", Offset = "0xB19770", VA = "0x180B1A570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700110E")]
	private RectTransform m_On
	{
		[Token(Token = "0x6006AB9")]
		[Address(RVA = "0xB1A7B0", Offset = "0xB199B0", VA = "0x180B1A7B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700110F")]
	private RectTransform m_Off
	{
		[Token(Token = "0x6006ABA")]
		[Address(RVA = "0xB1A720", Offset = "0xB19920", VA = "0x180B1A720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001110")]
	private RectTransform m_Mask
	{
		[Token(Token = "0x6006ABB")]
		[Address(RVA = "0xB1A690", Offset = "0xB19890", VA = "0x180B1A690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006ABC")]
	[Address(RVA = "0xB1A250", Offset = "0xB19450", VA = "0x180B1A250")]
	private void Start()
	{
	}

	[Token(Token = "0x6006ABD")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Update()
	{
	}

	[Token(Token = "0x6006ABE")]
	[Address(RVA = "0xB19B70", Offset = "0xB18D70", VA = "0x180B19B70")]
	public void SetData(LootSourceInfo.LootCategory cat, string title, string source, int param, bool available, int iconType = 0, [Optional] string iconData, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6006ABF")]
	[Address(RVA = "0xB19EB0", Offset = "0xB190B0", VA = "0x180B19EB0")]
	private void SetImageSummary(LootSourceInfo.LootCategory cat, int param = 0, [Optional] string iconData)
	{
	}

	[Token(Token = "0x6006AC0")]
	[Address(RVA = "0xB1A3A0", Offset = "0xB195A0", VA = "0x180B1A3A0")]
	public void ToggleAvailability(bool b)
	{
	}

	[Token(Token = "0x6006AC1")]
	[Address(RVA = "0xB1A320", Offset = "0xB19520", VA = "0x180B1A320")]
	public void ToggleAllow()
	{
	}

	[Token(Token = "0x6006AC2")]
	[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
	public void SetOnSelectedCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AC3")]
	[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
	public void SetOnDeselectedCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AC4")]
	[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
	public void SetOnClickCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AC5")]
	[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
	public void SetOnRightClickCallback(UnityAction<bool> callback)
	{
	}

	[Token(Token = "0x6006AC6")]
	[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
	public void SetOnSelectedKeySub1Callback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AC7")]
	[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
	public void SetOnSelectedKeyLeftCallback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AC8")]
	[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
	public void SetOnSelectedKeyL2Callback(UnityAction callback)
	{
	}

	[Token(Token = "0x6006AC9")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public LootSourceItem()
	{
	}
}
