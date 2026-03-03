using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu.Common;
using YgomSystem.UI;

namespace YgomGame.Shop;

[Token(Token = "0x20009C0")]
public class BindingCardPackThumbMany : Binding, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x4008D8A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_ThumbName;

	[Token(Token = "0x4008D8B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Image> m_Targets;

	[Token(Token = "0x4008D8C")]
	[FieldOffset(Offset = "0x38")]
	private bool m_Dirty;

	[Token(Token = "0x4008D8D")]
	[FieldOffset(Offset = "0x40")]
	private List<IAsyncProgressContent> m_AsyncProgressContents;

	[Token(Token = "0x170007D9")]
	public string thumbName
	{
		[Token(Token = "0x6003B75")]
		[Address(RVA = "0x80AD80", Offset = "0x809F80", VA = "0x18080AD80")]
		set
		{
		}
	}

	[Token(Token = "0x170007DA")]
	public bool visible
	{
		[Token(Token = "0x6003B78")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000043")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6003B76")]
		[Address(RVA = "0x80AC40", Offset = "0x809E40", VA = "0x18080AC40", Slot = "11")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003B77")]
		[Address(RVA = "0x80ACE0", Offset = "0x809EE0", VA = "0x18080ACE0", Slot = "12")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003B79")]
	[Address(RVA = "0x80A6D0", Offset = "0x8098D0", VA = "0x18080A6D0", Slot = "10")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6003B7A")]
	[Address(RVA = "0x80AB80", Offset = "0x809D80", VA = "0x18080AB80", Slot = "4")]
	public override void OnRebind()
	{
	}

	[Token(Token = "0x6003B7B")]
	[Address(RVA = "0x80A810", Offset = "0x809A10", VA = "0x18080A810", Slot = "5")]
	public override bool OnBinding()
	{
		return default(bool);
	}

	[Token(Token = "0x6003B7C")]
	[Address(RVA = "0x80AC00", Offset = "0x809E00", VA = "0x18080AC00", Slot = "8")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6003B7D")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public BindingCardPackThumbMany()
	{
	}
}
