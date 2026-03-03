using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.FreeScroll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CD3")]
public class MDMarkupBoardContainerWidget : ElementWidgetBase, IMDMarkupContainerWidget, IMDMarkupContainerWidgetRequireOwner
{
	[Token(Token = "0x2000CD4")]
	private class Footer : ElementWidgetBase
	{
		[Token(Token = "0x4009C4A")]
		[FieldOffset(Offset = "0x20")]
		private readonly SelectionButton m_ButtonTemplate;

		[Token(Token = "0x4009C4B")]
		[FieldOffset(Offset = "0x28")]
		private readonly TMP_Text m_TextTemplate;

		[Token(Token = "0x6004D96")]
		[Address(RVA = "0x94DCB0", Offset = "0x94CEB0", VA = "0x18094DCB0")]
		public Footer(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6004D97")]
		[Address(RVA = "0x94DB30", Offset = "0x94CD30", VA = "0x18094DB30")]
		public SelectionButton InsertButton()
		{
			return null;
		}

		[Token(Token = "0x6004D98")]
		[Address(RVA = "0x94DBF0", Offset = "0x94CDF0", VA = "0x18094DBF0")]
		public TMP_Text InsertText()
		{
			return null;
		}
	}

	[Token(Token = "0x4009C3A")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelTitleText;

	[Token(Token = "0x4009C3B")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelBadge;

	[Token(Token = "0x4009C3C")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelOptionalText;

	[Token(Token = "0x4009C3D")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelScrollView;

	[Token(Token = "0x4009C3E")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelHeader;

	[Token(Token = "0x4009C3F")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelFooter;

	[Token(Token = "0x4009C40")]
	private const string k_OGLabel_ScrollBar_Default = "Default";

	[Token(Token = "0x4009C41")]
	private const string k_OGLabel_ScrollBar_OnFooter = "OnFooter";

	[Token(Token = "0x4009C42")]
	private const string k_OGLabel_ScrollBar_Dialog = "Dialog";

	[Token(Token = "0x4009C43")]
	[FieldOffset(Offset = "0x50")]
	private Footer m_Header;

	[Token(Token = "0x4009C44")]
	[FieldOffset(Offset = "0x58")]
	private Footer m_Footer;

	[Token(Token = "0x4009C45")]
	[FieldOffset(Offset = "0x60")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x4009C46")]
	[FieldOffset(Offset = "0x68")]
	private FreeScrollView m_FreeScrollView;

	[Token(Token = "0x4009C47")]
	[FieldOffset(Offset = "0x70")]
	private MDMarkupAssetViewController m_Owner;

	[Token(Token = "0x4009C48")]
	[FieldOffset(Offset = "0x78")]
	private MDMarkupBoardContainer m_ContainerData;

	[Token(Token = "0x4009C49")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<string, GameObject> m_IdMap;

	[Token(Token = "0x17000AFB")]
	public ScrollRect scrollRect
	{
		[Token(Token = "0x6004D8A")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AFC")]
	public bool existsFooter
	{
		[Token(Token = "0x6004D8B")]
		[Address(RVA = "0x951D50", Offset = "0x950F50", VA = "0x180951D50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000AFD")]
	public TextMeshProUGUI titleText
	{
		[Token(Token = "0x6004D8C")]
		[Address(RVA = "0x951E30", Offset = "0x951030", VA = "0x180951E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AFE")]
	public GameObject badge
	{
		[Token(Token = "0x6004D8D")]
		[Address(RVA = "0x88DAB0", Offset = "0x88CCB0", VA = "0x18088DAB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AFF")]
	public TextMeshProUGUI optionalText
	{
		[Token(Token = "0x6004D8E")]
		[Address(RVA = "0x951DE0", Offset = "0x950FE0", VA = "0x180951DE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004D8F")]
	[Address(RVA = "0x950960", Offset = "0x94FB60", VA = "0x180950960", Slot = "13")]
	public GameObject FindById(string id)
	{
		return null;
	}

	[Token(Token = "0x6004D90")]
	[Address(RVA = "0x951A10", Offset = "0x950C10", VA = "0x180951A10")]
	public MDMarkupBoardContainerWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004D91")]
	[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0", Slot = "14")]
	public void AssignOwner(MDMarkupAssetViewController owner)
	{
	}

	[Token(Token = "0x6004D92")]
	[Address(RVA = "0x9509E0", Offset = "0x94FBE0", VA = "0x1809509E0", Slot = "10")]
	public void Initialize(IMDMarkupContainer containerData)
	{
	}

	[Token(Token = "0x6004D93")]
	[Address(RVA = "0x951850", Offset = "0x950A50", VA = "0x180951850", Slot = "11")]
	public void Output(MDMarkupGraphFactory graphFactory, Action onComplete)
	{
	}

	[Token(Token = "0x6004D94")]
	[Address(RVA = "0x950AB0", Offset = "0x94FCB0", VA = "0x180950AB0")]
	private bool InsertFooter(Footer destFooter, MDMarkupBoardContainer.FooterContent footerContent)
	{
		return default(bool);
	}

	[Token(Token = "0x6004D95")]
	[Address(RVA = "0x951120", Offset = "0x950320", VA = "0x180951120", Slot = "12")]
	public void OnStart(Dictionary<string, object> args)
	{
	}
}
