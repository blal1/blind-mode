using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Menu;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Room;

[Token(Token = "0x2000B03")]
public class RoomReplayViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2000B04")]
	public enum BattleStatus
	{
		[Token(Token = "0x4009508")]
		WIN = 1,
		[Token(Token = "0x4009509")]
		LOSE,
		[Token(Token = "0x400950A")]
		DRAW
	}

	[Token(Token = "0x2000B05")]
	internal class ReplayData
	{
		[Token(Token = "0x400950B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MemberData[] members;

		[Token(Token = "0x400950C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal long did;

		[Token(Token = "0x60043BA")]
		[Address(RVA = "0x8C93B0", Offset = "0x8C85B0", VA = "0x1808C93B0")]
		public ReplayData(MemberData[] members, long did)
		{
		}
	}

	[Token(Token = "0x2000B06")]
	internal class MemberData
	{
		[Token(Token = "0x400950D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal long pcode;

		[Token(Token = "0x400950E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string name;

		[Token(Token = "0x400950F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal int iconID;

		[Token(Token = "0x4009510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal int iconFrameID;

		[Token(Token = "0x4009511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal BattleStatus batteStatus;

		[Token(Token = "0x4009512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal bool isResistedPlatform;

		[Token(Token = "0x4009513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		internal bool isSamePlatform;

		[Token(Token = "0x4009514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal string platformName;

		[Token(Token = "0x60043BB")]
		[Address(RVA = "0x8C9310", Offset = "0x8C8510", VA = "0x1808C9310")]
		public MemberData()
		{
		}
	}

	[Token(Token = "0x40094FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x40094FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string TXT_WIN_LABEL;

	[Token(Token = "0x40094FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string TXT_LOSE_LABEL;

	[Token(Token = "0x40094FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string TXT_DRAW_LABEL;

	[Token(Token = "0x4009500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string IMG_ICON_LABEL;

	[Token(Token = "0x4009501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string PLATFORM_NAME_LABEL;

	[Token(Token = "0x4009502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string PLATFORM_ICON_LABEL;

	[Token(Token = "0x4009503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string TXT_EMPTY_LABEL;

	[Token(Token = "0x4009504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private InfinityScrollView isv;

	[Token(Token = "0x4009505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private List<ReplayData> dataList;

	[Token(Token = "0x4009506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool isReplay;

	[Token(Token = "0x17000909")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60043B1")]
		[Address(RVA = "0x8D8580", Offset = "0x8D7780", VA = "0x1808D8580", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60043B2")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60043B3")]
	[Address(RVA = "0x8D7010", Offset = "0x8D6210", VA = "0x1808D7010", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60043B4")]
	[Address(RVA = "0x8D7EB0", Offset = "0x8D70B0", VA = "0x1808D7EB0")]
	private void UpdateEntity(GameObject gob, int index)
	{
	}

	[Token(Token = "0x60043B5")]
	[Address(RVA = "0x8D7210", Offset = "0x8D6410", VA = "0x1808D7210")]
	private void SetData()
	{
	}

	[Token(Token = "0x60043B6")]
	[Address(RVA = "0x8D6F20", Offset = "0x8D6120", VA = "0x1808D6F20")]
	private void CallAPIRoomGetResultList([Optional] UnityAction onSuccess)
	{
	}

	[Token(Token = "0x60043B7")]
	[Address(RVA = "0x8D8390", Offset = "0x8D7590", VA = "0x1808D8390")]
	public RoomReplayViewController()
	{
	}
}
