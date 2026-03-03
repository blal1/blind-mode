using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200144F")]
[RequireComponent(typeof(RawImage))]
public class BindingProtectorMaterial : MonoBehaviour, IAsyncProgressContent, ILoadingIconHandler
{
	[Token(Token = "0x400C64C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_ItemId;

	[Token(Token = "0x400C64D")]
	[FieldOffset(Offset = "0x28")]
	private RawImage m_TargetCache;

	[Token(Token = "0x400C64E")]
	[FieldOffset(Offset = "0x30")]
	private bool m_LoadOnStart;

	[Token(Token = "0x1700137E")]
	public int itemid
	{
		[Token(Token = "0x6007E88")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007E89")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700137F")]
	private RawImage target
	{
		[Token(Token = "0x6007E8A")]
		[Address(RVA = "0xC6E5D0", Offset = "0xC6D7D0", VA = "0x180C6E5D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001380")]
	public bool visible
	{
		[Token(Token = "0x6007E8B")]
		[Address(RVA = "0x521190", Offset = "0x520390", VA = "0x180521190", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x140000A2")]
	public event Action onReloadEvent
	{
		[Token(Token = "0x6007E8C")]
		[Address(RVA = "0xC6E530", Offset = "0xC6D730", VA = "0x180C6E530", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6007E8D")]
		[Address(RVA = "0xC6E660", Offset = "0xC6D860", VA = "0x180C6E660", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6007E8E")]
	[Address(RVA = "0xC6E130", Offset = "0xC6D330", VA = "0x180C6E130")]
	public static BindingProtectorMaterial Binding(RawImage target, int itemid)
	{
		return null;
	}

	[Token(Token = "0x6007E8F")]
	[Address(RVA = "0xC6E380", Offset = "0xC6D580", VA = "0x180C6E380")]
	private void Start()
	{
	}

	[Token(Token = "0x6007E90")]
	[Address(RVA = "0xC6E2D0", Offset = "0xC6D4D0", VA = "0x180C6E2D0", Slot = "7")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6007E91")]
	[Address(RVA = "0xC6E320", Offset = "0xC6D520", VA = "0x180C6E320", Slot = "5")]
	public void ProgressUpdate()
	{
	}

	[Token(Token = "0x6007E92")]
	[Address(RVA = "0xC6E1A0", Offset = "0xC6D3A0", VA = "0x180C6E1A0")]
	[ContextMenu("ExecuteBinding")]
	public void ExecuteBinding()
	{
	}

	[Token(Token = "0x6007E93")]
	[Address(RVA = "0x51AA40", Offset = "0x519C40", VA = "0x18051AA40")]
	public BindingProtectorMaterial()
	{
	}
}
