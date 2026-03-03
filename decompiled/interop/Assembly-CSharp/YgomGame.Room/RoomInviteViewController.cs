using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Friend;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room;

[Token(Token = "0x2000AFC")]
public class RoomInviteViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000AFD")]
	internal class Data
	{
		[Token(Token = "0x40094D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal long pcode;

		[Token(Token = "0x40094DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object playerInfo;

		[Token(Token = "0x40094DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool isOnline;

		[Token(Token = "0x40094DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		internal bool isSelected;

		[Token(Token = "0x6004397")]
		[Address(RVA = "0x8C8A40", Offset = "0x8C7C40", VA = "0x1808C8A40")]
		public Data(long pcode, object playerInfo, bool isOnline, bool isSelected = false)
		{
		}
	}

	[Token(Token = "0x40094CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x40094D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string BTN_INVITE_LABEL;

	[Token(Token = "0x40094D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string INPUT_LABEL;

	[Token(Token = "0x40094D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string TXT_EMPTY_LABEL;

	[Token(Token = "0x40094D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string TXT_INVITE_COUNT_LABEL;

	[Token(Token = "0x40094D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private InfinityScrollView isv;

	[Token(Token = "0x40094D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Dictionary<GameObject, FriendWidget> m_EntityWidgetMap;

	[Token(Token = "0x40094D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<Data> dataList;

	[Token(Token = "0x40094D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private int currentInvite;

	[Token(Token = "0x40094D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private int maxInvite;

	[Token(Token = "0x17000907")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6004388")]
		[Address(RVA = "0x8D5B90", Offset = "0x8D4D90", VA = "0x1808D5B90", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004389")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600438A")]
	[Address(RVA = "0x8D4540", Offset = "0x8D3740", VA = "0x1808D4540", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600438B")]
	[Address(RVA = "0x8D48E0", Offset = "0x8D3AE0", VA = "0x1808D48E0", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x600438C")]
	[Address(RVA = "0x8D4170", Offset = "0x8D3370", VA = "0x1808D4170")]
	private void CallAPIFriendGetList([Optional] UnityAction onSuccess)
	{
	}

	[Token(Token = "0x600438D")]
	[Address(RVA = "0x8D4450", Offset = "0x8D3650", VA = "0x1808D4450")]
	private void OnCreatedEntity(GameObject gob)
	{
	}

	[Token(Token = "0x600438E")]
	[Address(RVA = "0x8D5660", Offset = "0x8D4860", VA = "0x1808D5660")]
	private void UpdateEntity(GameObject gob, int index)
	{
	}

	[Token(Token = "0x600438F")]
	[Address(RVA = "0x8D4950", Offset = "0x8D3B50", VA = "0x1808D4950")]
	private void SetData()
	{
	}

	[Token(Token = "0x6004390")]
	[Address(RVA = "0x8D4410", Offset = "0x8D3610", VA = "0x1808D4410")]
	private int CompareData(Data a, Data b)
	{
		return default(int);
	}

	[Token(Token = "0x6004391")]
	[Address(RVA = "0x8D42E0", Offset = "0x8D34E0", VA = "0x1808D42E0")]
	private void CallAPIRoomInvite(long[] pcodes)
	{
	}

	[Token(Token = "0x6004392")]
	[Address(RVA = "0x8D4120", Offset = "0x8D3320", VA = "0x1808D4120")]
	private Handle APIRoomFriendInvite(long[] _invite_list_)
	{
		return null;
	}

	[Token(Token = "0x6004393")]
	[Address(RVA = "0x8D5A30", Offset = "0x8D4C30", VA = "0x1808D5A30")]
	public RoomInviteViewController()
	{
	}
}
