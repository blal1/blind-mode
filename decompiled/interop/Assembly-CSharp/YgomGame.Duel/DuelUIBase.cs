using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x20018E0")]
public abstract class DuelUIBase : MonoBehaviour
{
	[Token(Token = "0x400E910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected RunEffectWorker effectWorker;

	[Token(Token = "0x400E911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected UITransitionUtil uiTransition;

	[Token(Token = "0x400E912")]
	private const string tweenLabelOpen = "Open";

	[Token(Token = "0x400E913")]
	private const string tweenLabelClose = "Close";

	[Token(Token = "0x17001858")]
	protected abstract UITransitionUtil.BlockType openCloseBlockType
	{
		[Token(Token = "0x600A04E")]
		get;
	}

	[Token(Token = "0x17001859")]
	public bool isShowing
	{
		[Token(Token = "0x600A04F")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A050")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700185A")]
	public bool isOpening
	{
		[Token(Token = "0x600A051")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A052")]
		[Address(RVA = "0x768DE0", Offset = "0x767FE0", VA = "0x180768DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600A053")]
	[Address(RVA = "0xEDD050", Offset = "0xEDC250", VA = "0x180EDD050", Slot = "5")]
	public virtual void Initialize(RunEffectWorker effectWorker, bool createUI = true)
	{
	}

	[Token(Token = "0x600A054")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	protected virtual void CreateUI()
	{
	}

	[Token(Token = "0x600A055")]
	[Address(RVA = "0xEDD1B0", Offset = "0xEDC3B0", VA = "0x180EDD1B0", Slot = "7")]
	protected virtual void Open([Optional] Action openedCallback)
	{
	}

	[Token(Token = "0x600A056")]
	[Address(RVA = "0xEDCED0", Offset = "0xEDC0D0", VA = "0x180EDCED0", Slot = "8")]
	protected virtual void Close([Optional] Action closedCallback)
	{
	}

	[Token(Token = "0x600A057")]
	[Address(RVA = "0x477530", Offset = "0x476730", VA = "0x180477530", Slot = "9")]
	protected virtual void OnOpened()
	{
	}

	[Token(Token = "0x600A058")]
	[Address(RVA = "0x60A530", Offset = "0x609730", VA = "0x18060A530", Slot = "10")]
	protected virtual void OnClosed()
	{
	}

	[Token(Token = "0x600A059")]
	[Address(RVA = "0x439370", Offset = "0x438570", VA = "0x180439370", Slot = "11")]
	protected virtual void ShowUI()
	{
	}

	[Token(Token = "0x600A05A")]
	[Address(RVA = "0x5FDDF0", Offset = "0x5FCFF0", VA = "0x1805FDDF0", Slot = "12")]
	protected virtual void HideUI()
	{
	}

	[Token(Token = "0x600A05B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "13")]
	protected virtual void StartUI()
	{
	}

	[Token(Token = "0x600A05C")]
	[Address(RVA = "0xEDD310", Offset = "0xEDC510", VA = "0x180EDD310", Slot = "14")]
	protected virtual void UpdateUI()
	{
	}

	[Token(Token = "0x600A05D")]
	[Address(RVA = "0xEDD030", Offset = "0xEDC230", VA = "0x180EDD030", Slot = "15")]
	protected virtual void DestroyUI()
	{
	}

	[Token(Token = "0x600A05E")]
	[Address(RVA = "0x731260", Offset = "0x730460", VA = "0x180731260")]
	private void Start()
	{
	}

	[Token(Token = "0x600A05F")]
	[Address(RVA = "0xEDD330", Offset = "0xEDC530", VA = "0x180EDD330", Slot = "16")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600A060")]
	[Address(RVA = "0xEDD190", Offset = "0xEDC390", VA = "0x180EDD190")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600A061")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	protected DuelUIBase()
	{
	}
}
