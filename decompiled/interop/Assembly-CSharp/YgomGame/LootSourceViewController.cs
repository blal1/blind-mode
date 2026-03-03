using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame;

[Token(Token = "0x20006AD")]
public class LootSourceViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x4002165")]
	private const string LABEL_IMG_IMAGECARD = "ImageCard";

	[Token(Token = "0x4002166")]
	private const string LABEL_SCV_SOURCESCROLL = "SourceScroll";

	[Token(Token = "0x4002167")]
	private const string LABEL_SBN_BACK = "Back";

	[Token(Token = "0x4002168")]
	private const string LABEL_EMPTY_MESSAGE_ROOT = "EmptyMessageRoot";

	[Token(Token = "0x4002169")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string LABEL_IMG_RARITY;

	[Token(Token = "0x400216A")]
	public const string argsKeyCardID = "CardID";

	[Token(Token = "0x400216B")]
	public const string argsKeyCallBack = "DecideCallback";

	[Token(Token = "0x400216C")]
	[FieldOffset(Offset = "0xD8")]
	private int m_CardID;

	[Token(Token = "0x400216D")]
	[FieldOffset(Offset = "0xE0")]
	private GameObject m_EmptyMessageRoot;

	[Token(Token = "0x400216E")]
	[FieldOffset(Offset = "0xE8")]
	private List<object> m_DataList;

	[Token(Token = "0x400216F")]
	[FieldOffset(Offset = "0xF0")]
	private List<int> m_ShopList;

	[Token(Token = "0x4002170")]
	[FieldOffset(Offset = "0xF8")]
	private Action<int, List<int>> decideCallback;

	[Token(Token = "0x17000581")]
	private RawImage m_CardImage
	{
		[Token(Token = "0x6002C72")]
		[Address(RVA = "0x7062D0", Offset = "0x7054D0", VA = "0x1807062D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000582")]
	private SelectionButton m_BackButton
	{
		[Token(Token = "0x6002C73")]
		[Address(RVA = "0x706270", Offset = "0x705470", VA = "0x180706270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000583")]
	private Image m_RarityIcon
	{
		[Token(Token = "0x6002C74")]
		[Address(RVA = "0x7063C0", Offset = "0x7055C0", VA = "0x1807063C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000584")]
	private GameObject m_RarityIconObj
	{
		[Token(Token = "0x6002C75")]
		[Address(RVA = "0x706390", Offset = "0x705590", VA = "0x180706390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000585")]
	public InfinityScrollView m_InfinityScroll
	{
		[Token(Token = "0x6002C76")]
		[Address(RVA = "0x706330", Offset = "0x705530", VA = "0x180706330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000586")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6002C77")]
		[Address(RVA = "0x706410", Offset = "0x705610", VA = "0x180706410", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002C78")]
	[Address(RVA = "0x705300", Offset = "0x704500", VA = "0x180705300", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002C79")]
	[Address(RVA = "0x705560", Offset = "0x704760", VA = "0x180705560", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002C7A")]
	[Address(RVA = "0x7054B0", Offset = "0x7046B0", VA = "0x1807054B0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002C7B")]
	[Address(RVA = "0x705080", Offset = "0x704280", VA = "0x180705080")]
	public void InitializeScroll()
	{
	}

	[Token(Token = "0x6002C7C")]
	[Address(RVA = "0x705530", Offset = "0x704730", VA = "0x180705530")]
	public void OnCreateEntity(GameObject obj)
	{
	}

	[Token(Token = "0x6002C7D")]
	[Address(RVA = "0x705B00", Offset = "0x704D00", VA = "0x180705B00")]
	public void OnUpdateEntity(GameObject obj, int idx)
	{
	}

	[Token(Token = "0x6002C7E")]
	[Address(RVA = "0x706210", Offset = "0x705410", VA = "0x180706210")]
	public LootSourceViewController()
	{
	}
}
