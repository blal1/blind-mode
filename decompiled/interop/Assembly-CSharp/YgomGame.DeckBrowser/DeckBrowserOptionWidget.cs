using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x2001024")]
public class DeckBrowserOptionWidget : ElementWidgetBase
{
	[Token(Token = "0x400ACD8")]
	private const string k_PrefPath = "Prefabs/UI/DeckBrowser/Optionals/DeckBrowserOption";

	[Token(Token = "0x400ACD9")]
	[FieldOffset(Offset = "0x20")]
	protected string k_ELabelFiveDrawButton;

	[Token(Token = "0x400ACDA")]
	[FieldOffset(Offset = "0x28")]
	protected string k_ELabelRegulationButton;

	[Token(Token = "0x400ACDB")]
	[FieldOffset(Offset = "0x30")]
	protected string k_ELabelRegulationText;

	[Token(Token = "0x400ACDC")]
	[FieldOffset(Offset = "0x38")]
	protected string k_ELabelHasCardOnlyToggle;

	[Token(Token = "0x400ACDD")]
	[FieldOffset(Offset = "0x40")]
	protected string k_ELabelCopyButton;

	[Token(Token = "0x400ACDE")]
	[FieldOffset(Offset = "0x48")]
	protected string k_ELabelSelectButton;

	[Token(Token = "0x400ACDF")]
	[FieldOffset(Offset = "0x50")]
	protected string k_ELabelDeleteButton;

	[Token(Token = "0x400ACE0")]
	[FieldOffset(Offset = "0x58")]
	protected string k_ELabelDescText;

	[Token(Token = "0x400ACE1")]
	[FieldOffset(Offset = "0x60")]
	protected string k_ELabelUpperMenus;

	[Token(Token = "0x400ACE2")]
	[FieldOffset(Offset = "0x68")]
	protected string k_ELabelFooterMenus;

	[Token(Token = "0x400ACE3")]
	[FieldOffset(Offset = "0x70")]
	protected string k_ELabelExportButton;

	[Token(Token = "0x400ACE4")]
	[FieldOffset(Offset = "0x78")]
	protected string k_ELabelButtonIconCardDB;

	[Token(Token = "0x400ACE5")]
	[FieldOffset(Offset = "0x80")]
	protected ElementObjectManager m_Eom;

	[Token(Token = "0x400ACE6")]
	[FieldOffset(Offset = "0x88")]
	protected SelectionButton m_RegulationButton;

	[Token(Token = "0x400ACE7")]
	[FieldOffset(Offset = "0x90")]
	protected TextMeshProUGUI m_RegulationText;

	[Token(Token = "0x400ACE8")]
	[FieldOffset(Offset = "0x98")]
	protected SelectionButton m_HasCardOnlyButton;

	[Token(Token = "0x400ACE9")]
	[FieldOffset(Offset = "0xA0")]
	protected ToggleWidget m_HasCardOnlyToggle;

	[Token(Token = "0x400ACEA")]
	[FieldOffset(Offset = "0xA8")]
	protected SelectionButton m_CopyButton;

	[Token(Token = "0x400ACEB")]
	[FieldOffset(Offset = "0xB0")]
	protected TextMeshProUGUI m_CopyText;

	[Token(Token = "0x400ACEC")]
	[FieldOffset(Offset = "0xB8")]
	protected SelectionButton m_DeleteButton;

	[Token(Token = "0x400ACED")]
	[FieldOffset(Offset = "0xC0")]
	protected TextMeshProUGUI m_DeleteText;

	[Token(Token = "0x400ACEE")]
	[FieldOffset(Offset = "0xC8")]
	protected SelectionButton m_FiveDrawButton;

	[Token(Token = "0x400ACEF")]
	[FieldOffset(Offset = "0xD0")]
	protected TextMeshProUGUI m_FiveDrawText;

	[Token(Token = "0x400ACF0")]
	[FieldOffset(Offset = "0xD8")]
	protected SelectionButton m_ExportButton;

	[Token(Token = "0x400ACF1")]
	[FieldOffset(Offset = "0xE0")]
	protected TextMeshProUGUI m_ExportText;

	[Token(Token = "0x400ACF2")]
	[FieldOffset(Offset = "0xE8")]
	protected Image m_ExportIconCardDB;

	[Token(Token = "0x400ACF3")]
	[FieldOffset(Offset = "0xF0")]
	protected ElementObjectManager m_SelectButtonEom;

	[Token(Token = "0x400ACF4")]
	[FieldOffset(Offset = "0xF8")]
	protected SelectionButton m_SelectButton;

	[Token(Token = "0x400ACF5")]
	[FieldOffset(Offset = "0x100")]
	protected TextMeshProUGUI m_SelectText;

	[Token(Token = "0x400ACF6")]
	[FieldOffset(Offset = "0x108")]
	protected TextMeshProUGUI m_DescText;

	[Token(Token = "0x400ACF7")]
	[FieldOffset(Offset = "0x110")]
	protected Transform m_UpperMenus;

	[Token(Token = "0x400ACF8")]
	[FieldOffset(Offset = "0x118")]
	protected Transform m_FooterMenus;

	[Token(Token = "0x400ACF9")]
	[FieldOffset(Offset = "0x120")]
	private ShortcutKeySetter m_ShortcutSettings;

	[Token(Token = "0x400ACFA")]
	[FieldOffset(Offset = "0x128")]
	public Action onClickFiveDrawCallback;

	[Token(Token = "0x400ACFB")]
	[FieldOffset(Offset = "0x130")]
	public Action onClickExportCallback;

	[Token(Token = "0x400ACFC")]
	[FieldOffset(Offset = "0x138")]
	public Action onClickRegulationCallback;

	[Token(Token = "0x400ACFD")]
	[FieldOffset(Offset = "0x140")]
	public Action<bool> onClickHasCardOnlyCallback;

	[Token(Token = "0x400ACFE")]
	[FieldOffset(Offset = "0x148")]
	public Action onClickCopyCallback;

	[Token(Token = "0x400ACFF")]
	[FieldOffset(Offset = "0x150")]
	public Action onClickDeleteCallback;

	[Token(Token = "0x400AD00")]
	[FieldOffset(Offset = "0x158")]
	public Action onClickSelectCallback;

	[Token(Token = "0x17000F3B")]
	public bool fiveDrawButtonEnable
	{
		[Token(Token = "0x60061A4")]
		[Address(RVA = "0xA75B00", Offset = "0xA74D00", VA = "0x180A75B00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061A5")]
		[Address(RVA = "0xA760E0", Offset = "0xA752E0", VA = "0x180A760E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F3C")]
	public string fiveDrawText
	{
		[Token(Token = "0x60061A6")]
		[Address(RVA = "0xA75B30", Offset = "0xA74D30", VA = "0x180A75B30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60061A7")]
		[Address(RVA = "0xA76120", Offset = "0xA75320", VA = "0x180A76120")]
		set
		{
		}
	}

	[Token(Token = "0x17000F3D")]
	public bool m_ExportButtonEnable
	{
		[Token(Token = "0x60061A8")]
		[Address(RVA = "0xA75BE0", Offset = "0xA74DE0", VA = "0x180A75BE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061A9")]
		[Address(RVA = "0xA76550", Offset = "0xA75750", VA = "0x180A76550")]
		set
		{
		}
	}

	[Token(Token = "0x17000F3E")]
	public string ExportText
	{
		[Token(Token = "0x60061AA")]
		[Address(RVA = "0xA759B0", Offset = "0xA74BB0", VA = "0x180A759B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60061AB")]
		[Address(RVA = "0xA75D00", Offset = "0xA74F00", VA = "0x180A75D00")]
		set
		{
		}
	}

	[Token(Token = "0x17000F3F")]
	public Sprite ExportIcon
	{
		[Token(Token = "0x60061AC")]
		[Address(RVA = "0xA75CD0", Offset = "0xA74ED0", VA = "0x180A75CD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F40")]
	public bool regulationButtonEnable
	{
		[Token(Token = "0x60061AD")]
		[Address(RVA = "0xA75C10", Offset = "0xA74E10", VA = "0x180A75C10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061AE")]
		[Address(RVA = "0xA76590", Offset = "0xA75790", VA = "0x180A76590")]
		set
		{
		}
	}

	[Token(Token = "0x17000F41")]
	public string regulationText
	{
		[Token(Token = "0x60061AF")]
		[Address(RVA = "0xA75C40", Offset = "0xA74E40", VA = "0x180A75C40")]
		get
		{
			return null;
		}
		[Token(Token = "0x60061B0")]
		[Address(RVA = "0xA765D0", Offset = "0xA757D0", VA = "0x180A765D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F42")]
	public bool hasCardOnlyToggleEnable
	{
		[Token(Token = "0x60061B1")]
		[Address(RVA = "0xA75B90", Offset = "0xA74D90", VA = "0x180A75B90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061B2")]
		[Address(RVA = "0xA76290", Offset = "0xA75490", VA = "0x180A76290")]
		set
		{
		}
	}

	[Token(Token = "0x17000F43")]
	public bool hasCardOnlyToggleIsOn
	{
		[Token(Token = "0x60061B3")]
		[Address(RVA = "0xA75BC0", Offset = "0xA74DC0", VA = "0x180A75BC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061B4")]
		[Address(RVA = "0xA762D0", Offset = "0xA754D0", VA = "0x180A762D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F44")]
	public bool copyButtonEnable
	{
		[Token(Token = "0x60061B5")]
		[Address(RVA = "0xA759E0", Offset = "0xA74BE0", VA = "0x180A759E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061B6")]
		[Address(RVA = "0xA75DD0", Offset = "0xA74FD0", VA = "0x180A75DD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F45")]
	public string copyButtonText
	{
		[Token(Token = "0x60061B7")]
		[Address(RVA = "0xA75A10", Offset = "0xA74C10", VA = "0x180A75A10")]
		get
		{
			return null;
		}
		[Token(Token = "0x60061B8")]
		[Address(RVA = "0xA75E10", Offset = "0xA75010", VA = "0x180A75E10")]
		set
		{
		}
	}

	[Token(Token = "0x17000F46")]
	public bool deleteButtonEnable
	{
		[Token(Token = "0x60061B9")]
		[Address(RVA = "0xA75A40", Offset = "0xA74C40", VA = "0x180A75A40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061BA")]
		[Address(RVA = "0xA75EE0", Offset = "0xA750E0", VA = "0x180A75EE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F47")]
	public string deleteButtonText
	{
		[Token(Token = "0x60061BB")]
		[Address(RVA = "0xA75A70", Offset = "0xA74C70", VA = "0x180A75A70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60061BC")]
		[Address(RVA = "0xA75F20", Offset = "0xA75120", VA = "0x180A75F20")]
		set
		{
		}
	}

	[Token(Token = "0x17000F48")]
	public bool selectButtonEnable
	{
		[Token(Token = "0x60061BD")]
		[Address(RVA = "0xA75C70", Offset = "0xA74E70", VA = "0x180A75C70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061BE")]
		[Address(RVA = "0xA766A0", Offset = "0xA758A0", VA = "0x180A766A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F49")]
	public bool isRentalDeckSelect
	{
		[Token(Token = "0x60061BF")]
		[Address(RVA = "0xA76380", Offset = "0xA75580", VA = "0x180A76380")]
		set
		{
		}
	}

	[Token(Token = "0x17000F4A")]
	public bool descTextEnable
	{
		[Token(Token = "0x60061C0")]
		[Address(RVA = "0xA75AA0", Offset = "0xA74CA0", VA = "0x180A75AA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061C1")]
		[Address(RVA = "0xA75FF0", Offset = "0xA751F0", VA = "0x180A75FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F4B")]
	public string descText
	{
		[Token(Token = "0x60061C2")]
		[Address(RVA = "0xA75AD0", Offset = "0xA74CD0", VA = "0x180A75AD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60061C3")]
		[Address(RVA = "0xA76090", Offset = "0xA75290", VA = "0x180A76090")]
		set
		{
		}
	}

	[Token(Token = "0x17000F4C")]
	public bool upperMenuEnable
	{
		[Token(Token = "0x60061C4")]
		[Address(RVA = "0xA75CA0", Offset = "0xA74EA0", VA = "0x180A75CA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061C5")]
		[Address(RVA = "0xA766E0", Offset = "0xA758E0", VA = "0x180A766E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F4D")]
	public bool footerMenuEnable
	{
		[Token(Token = "0x60061C6")]
		[Address(RVA = "0xA75B60", Offset = "0xA74D60", VA = "0x180A75B60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60061C7")]
		[Address(RVA = "0xA761F0", Offset = "0xA753F0", VA = "0x180A761F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000F4E")]
	public ShortcutKeySetter ShortcutSettings
	{
		[Token(Token = "0x60061C8")]
		[Address(RVA = "0x9538F0", Offset = "0x952AF0", VA = "0x1809538F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60061C9")]
	[Address(RVA = "0xA74A40", Offset = "0xA73C40", VA = "0x180A74A40")]
	public static void Create(Transform parent, Action<DeckBrowserOptionWidget> onCreated)
	{
	}

	[Token(Token = "0x60061CA")]
	[Address(RVA = "0xA74C90", Offset = "0xA73E90", VA = "0x180A74C90")]
	public DeckBrowserOptionWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60061CB")]
	[Address(RVA = "0xA749B0", Offset = "0xA73BB0", VA = "0x180A749B0")]
	public void CopyButtonUpdate()
	{
	}

	[Token(Token = "0x60061CC")]
	[Address(RVA = "0xA74970", Offset = "0xA73B70", VA = "0x180A74970")]
	public void CopyButtonSetColor(bool active)
	{
	}
}
