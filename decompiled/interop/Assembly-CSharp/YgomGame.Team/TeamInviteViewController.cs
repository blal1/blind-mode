using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Friend;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Team;

[Token(Token = "0x2001653")]
public class TeamInviteViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001654")]
	private class Data
	{
		[Token(Token = "0x400D5E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal long pcode;

		[Token(Token = "0x400D5E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object playerInfo;

		[Token(Token = "0x400D5E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal bool isOnline;

		[Token(Token = "0x400D5E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		internal bool isSelected;

		[Token(Token = "0x6008AF5")]
		[Address(RVA = "0x8C8A40", Offset = "0x8C7C40", VA = "0x1808C8A40")]
		public Data(long pcode, object playerInfo, bool isOnline, bool isSelected = false)
		{
		}
	}

	[Token(Token = "0x400D5DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string VC_PATH;

	[Token(Token = "0x400D5DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly string SCROLL_LABEL;

	[Token(Token = "0x400D5DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string BTN_INVITE_LABEL;

	[Token(Token = "0x400D5DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly string TXT_EMPTY_LABEL;

	[Token(Token = "0x400D5DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly string TXT_INVITE_COUNT_LABEL;

	[Token(Token = "0x400D5DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private InfinityScrollView isv;

	[Token(Token = "0x400D5E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Dictionary<GameObject, FriendWidget> m_EntityWidgetMap;

	[Token(Token = "0x400D5E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private List<Data> dataList;

	[Token(Token = "0x400D5E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int currentInvite;

	[Token(Token = "0x400D5E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private int maxInvite;

	[Token(Token = "0x17001536")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6008AE5")]
		[Address(RVA = "0xD654D0", Offset = "0xD646D0", VA = "0x180D654D0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008AE6")]
	[Address(RVA = "0xD63D10", Offset = "0xD62F10", VA = "0x180D63D10")]
	public static void Open(ViewControllerManager manager)
	{
	}

	[Token(Token = "0x6008AE7")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008AE8")]
	[Address(RVA = "0xD63A10", Offset = "0xD62C10", VA = "0x180D63A10", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6008AE9")]
	[Address(RVA = "0xD636F0", Offset = "0xD628F0", VA = "0x180D636F0")]
	private void CallAPIFriendGetList([Optional] UnityAction onSuccess)
	{
	}

	[Token(Token = "0x6008AEA")]
	[Address(RVA = "0xD63CA0", Offset = "0xD62EA0", VA = "0x180D63CA0", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x6008AEB")]
	[Address(RVA = "0xD63920", Offset = "0xD62B20", VA = "0x180D63920")]
	private void OnCreatedEntity(GameObject gob)
	{
	}

	[Token(Token = "0x6008AEC")]
	[Address(RVA = "0xD64F10", Offset = "0xD64110", VA = "0x180D64F10")]
	private void UpdateEntity(GameObject gob, int index)
	{
	}

	[Token(Token = "0x6008AED")]
	[Address(RVA = "0xD63D80", Offset = "0xD62F80", VA = "0x180D63D80")]
	private void SetData()
	{
	}

	[Token(Token = "0x6008AEE")]
	[Address(RVA = "0xD63860", Offset = "0xD62A60", VA = "0x180D63860")]
	private void CallAPITeamInvite(long[] pcodes)
	{
	}

	[Token(Token = "0x6008AEF")]
	[Address(RVA = "0xD65450", Offset = "0xD64650", VA = "0x180D65450")]
	public TeamInviteViewController()
	{
	}
}
