using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.Utility;

namespace YgomGame.Credit;

[Token(Token = "0x2001135")]
public class CreditViewController : BaseMenuViewController, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x400B577")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string BTN_BACK_SHORTCUT_LABEL;

	[Token(Token = "0x400B578")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string CREDIT_LIST_LABEL;

	[Token(Token = "0x400B579")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string ENECONWIDGET_LABEL;

	[Token(Token = "0x400B57A")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string TEXT_GROUPNAME_LABEL;

	[Token(Token = "0x400B57B")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string TEXT_POSITIONNAME_LABEL;

	[Token(Token = "0x400B57C")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string TEXT_NAME_LABEL;

	[Token(Token = "0x400B57D")]
	[FieldOffset(Offset = "0x100")]
	private readonly string TEXT_NAMEFONTCHANGED_LABEL;

	[Token(Token = "0x400B57E")]
	[FieldOffset(Offset = "0x108")]
	private readonly string TEXT_NAMEFONTCHANGED2_LABEL;

	[Token(Token = "0x400B57F")]
	[FieldOffset(Offset = "0x110")]
	private readonly string TEXT_POSITIONNAMEFONTCHANGED_LABEL;

	[Token(Token = "0x400B580")]
	[FieldOffset(Offset = "0x118")]
	private readonly string TEXT_GROUPNAMEFONTCHANGED_LABEL;

	[Token(Token = "0x400B581")]
	[FieldOffset(Offset = "0x120")]
	private readonly string TEXT_NAME2_LABEL;

	[Token(Token = "0x400B582")]
	[FieldOffset(Offset = "0x128")]
	private readonly string TEMPLATE_SPACERM_LABEL;

	[Token(Token = "0x400B583")]
	[FieldOffset(Offset = "0x130")]
	private readonly string TEMPLATE_GROUP_LABEL;

	[Token(Token = "0x400B584")]
	[FieldOffset(Offset = "0x138")]
	private readonly string TEMPLATE_NAMEONLY_LABEL;

	[Token(Token = "0x400B585")]
	[FieldOffset(Offset = "0x140")]
	private readonly string CONTENT_LABEL;

	[Token(Token = "0x400B586")]
	[FieldOffset(Offset = "0x148")]
	private readonly string OBJ_MATE_LABEL;

	[Token(Token = "0x400B587")]
	[FieldOffset(Offset = "0x150")]
	private readonly string TLABEL_MATEIN;

	[Token(Token = "0x400B588")]
	[FieldOffset(Offset = "0x158")]
	private readonly string TLABEL_FONTCHANGE;

	[Token(Token = "0x400B589")]
	[FieldOffset(Offset = "0x160")]
	private InfinityScrollView m_infinityScrollView;

	[Token(Token = "0x400B58A")]
	[FieldOffset(Offset = "0x168")]
	private ExtendedScrollRect m_extendedScrollRect;

	[Token(Token = "0x400B58B")]
	[FieldOffset(Offset = "0x170")]
	private List<int> m_templates;

	[Token(Token = "0x400B58C")]
	[FieldOffset(Offset = "0x178")]
	private readonly int k_GroupTNo;

	[Token(Token = "0x400B58D")]
	[FieldOffset(Offset = "0x17C")]
	private readonly int k_PositionAndNameTNo;

	[Token(Token = "0x400B58E")]
	[FieldOffset(Offset = "0x180")]
	private readonly int k_NameOnlyTNo;

	[Token(Token = "0x400B58F")]
	[FieldOffset(Offset = "0x184")]
	private readonly int k_Member2TNo;

	[Token(Token = "0x400B590")]
	[FieldOffset(Offset = "0x188")]
	private readonly int k_SpacerSTNo;

	[Token(Token = "0x400B591")]
	[FieldOffset(Offset = "0x18C")]
	private readonly int k_SpacerMTNo;

	[Token(Token = "0x400B592")]
	[FieldOffset(Offset = "0x190")]
	private readonly int k_SpacerLTNo;

	[Token(Token = "0x400B593")]
	[FieldOffset(Offset = "0x194")]
	private float m_scrollSpeed;

	[Token(Token = "0x400B594")]
	[FieldOffset(Offset = "0x198")]
	private bool m_mateIsActive;

	[Token(Token = "0x400B595")]
	[FieldOffset(Offset = "0x199")]
	private bool isFontChanged;

	[Token(Token = "0x400B596")]
	[FieldOffset(Offset = "0x1A0")]
	private CreditBGTimeline m_creditBGTimeline;

	[Token(Token = "0x400B597")]
	[FieldOffset(Offset = "0x1A8")]
	private CreditEneconWidget m_eneconWidget;

	[Token(Token = "0x400B598")]
	[FieldOffset(Offset = "0x1B0")]
	private bool isStarted;

	[Token(Token = "0x400B599")]
	[FieldOffset(Offset = "0x1B1")]
	private bool isEnd;

	[Token(Token = "0x400B59A")]
	[FieldOffset(Offset = "0x1B8")]
	private List<CreditInfo> m_creditInfoList;

	[Token(Token = "0x400B59B")]
	[FieldOffset(Offset = "0x1C0")]
	private int presentedCounter;

	[Token(Token = "0x17001128")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006BDE")]
		[Address(RVA = "0xB2C700", Offset = "0xB2B900", VA = "0x180B2C700", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006BDF")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006BE0")]
	[Address(RVA = "0xB2A7D0", Offset = "0xB299D0", VA = "0x180B2A7D0")]
	private void OnBackCommand()
	{
	}

	[Token(Token = "0x6006BE1")]
	[Address(RVA = "0xB2A880", Offset = "0xB29A80", VA = "0x180B2A880", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6006BE2")]
	[Address(RVA = "0xB2A8C0", Offset = "0xB29AC0", VA = "0x180B2A8C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006BE3")]
	[Address(RVA = "0xB2BED0", Offset = "0xB2B0D0", VA = "0x180B2BED0")]
	private void OnKonamiCommandResultCallback(KeyCommand.OnKeyResult result)
	{
	}

	[Token(Token = "0x6006BE4")]
	[Address(RVA = "0x3D5200", Offset = "0x3D4400", VA = "0x1803D5200")]
	private void OnEneconBreakResultCallback(KeyCommand.OnKeyResult result)
	{
	}

	[Token(Token = "0x6006BE5")]
	[Address(RVA = "0xB2B830", Offset = "0xB2AA30", VA = "0x180B2B830")]
	private void OnEneconReleaseResultCallback(KeyCommand.OnKeyResult result)
	{
	}

	[Token(Token = "0x6006BE6")]
	[Address(RVA = "0xB2C1B0", Offset = "0xB2B3B0", VA = "0x180B2C1B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6006BE7")]
	[Address(RVA = "0xB2B280", Offset = "0xB2A480", VA = "0x180B2B280")]
	public void OnCreditTemplateSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6006BE8")]
	[Address(RVA = "0xB2A6C0", Offset = "0xB298C0", VA = "0x180B2A6C0")]
	private void LoadInfoFromScriptableObject(UnityAction callBack)
	{
	}

	[Token(Token = "0x6006BE9")]
	[Address(RVA = "0xB2C2C0", Offset = "0xB2B4C0", VA = "0x180B2C2C0")]
	public CreditViewController()
	{
	}
}
