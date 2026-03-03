using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame;

[Token(Token = "0x20006A7")]
public class ItemExchangeViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x20006A8")]
	public struct ExchangeData
	{
		[Token(Token = "0x4002150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int invitationID;

		[Token(Token = "0x4002151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ExchangeItemInfo obtain;

		[Token(Token = "0x4002152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public ExchangeItemInfo consume;

		[Token(Token = "0x4002153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int haveNum;

		[Token(Token = "0x4002154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int maxNum;

		[Token(Token = "0x4002155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int count;
	}

	[Token(Token = "0x20006A9")]
	public struct ExchangeItemInfo
	{
		[Token(Token = "0x4002156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int category;

		[Token(Token = "0x4002157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int itemID;

		[Token(Token = "0x4002158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int num;

		[Token(Token = "0x4002159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool isPeriod;
	}

	[Token(Token = "0x4002147")]
	public const string k_PREF_PATH = "ItemExchange/ItemExchangeViewController";

	[Token(Token = "0x4002148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x4002149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private List<ExchangeData> m_ExchangeItemDataList;

	[Token(Token = "0x400214A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private ExtendedTextMeshProUGUI m_TitleField;

	[Token(Token = "0x400214B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private ExtendedTextMeshProUGUI m_MessageField;

	[Token(Token = "0x400214C")]
	public const string k_ArgsKeyTitle = "TitleText";

	[Token(Token = "0x400214D")]
	public const string k_ArgsKeyMessage = "MessageText";

	[Token(Token = "0x400214E")]
	public const string k_ArgsKeyDataList = "DataList";

	[Token(Token = "0x400214F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private List<ElementObjectManager> m_TemplateList;

	[Token(Token = "0x17000580")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6002C5A")]
		[Address(RVA = "0x6FC910", Offset = "0x6FBB10", VA = "0x1806FC910", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002C5B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C5C")]
	[Address(RVA = "0x6FB6E0", Offset = "0x6FA8E0", VA = "0x1806FB6E0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002C5D")]
	[Address(RVA = "0x6FB750", Offset = "0x6FA950", VA = "0x1806FB750", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6002C5E")]
	[Address(RVA = "0x6FC7D0", Offset = "0x6FB9D0", VA = "0x1806FC7D0")]
	public static void Open([Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6002C5F")]
	[Address(RVA = "0x6FB7C0", Offset = "0x6FA9C0", VA = "0x1806FB7C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002C60")]
	[Address(RVA = "0x6FBEB0", Offset = "0x6FB0B0", VA = "0x1806FBEB0")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x6002C61")]
	[Address(RVA = "0x6FBFE0", Offset = "0x6FB1E0", VA = "0x1806FBFE0")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6002C62")]
	[Address(RVA = "0x6FBE50", Offset = "0x6FB050", VA = "0x1806FBE50")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x6002C63")]
	[Address(RVA = "0x6FAD40", Offset = "0x6F9F40", VA = "0x1806FAD40")]
	private void CallExchangeAPI(int invitationID, bool isCheck = false, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6002C64")]
	[Address(RVA = "0x6FAEB0", Offset = "0x6FA0B0", VA = "0x1806FAEB0")]
	public static List<ExchangeData> GetExchangeDatas()
	{
		return null;
	}

	[Token(Token = "0x6002C65")]
	[Address(RVA = "0x6FAE50", Offset = "0x6FA050", VA = "0x1806FAE50")]
	public static bool ExistWorkData()
	{
		return default(bool);
	}

	[Token(Token = "0x6002C66")]
	[Address(RVA = "0x6FC840", Offset = "0x6FBA40", VA = "0x1806FC840")]
	public ItemExchangeViewController()
	{
	}
}
