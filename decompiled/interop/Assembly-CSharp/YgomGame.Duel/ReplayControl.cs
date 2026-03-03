using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001922")]
public class ReplayControl : MonoBehaviour
{
	[Token(Token = "0x400EAD5")]
	[FieldOffset(Offset = "0x20")]
	private DuelHUD duelHUD;

	[Token(Token = "0x400EAD6")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager ui;

	[Token(Token = "0x400EAD7")]
	[FieldOffset(Offset = "0x30")]
	private SelectionButton playButton;

	[Token(Token = "0x400EAD8")]
	[FieldOffset(Offset = "0x38")]
	private SelectionButton pauseButton;

	[Token(Token = "0x400EAD9")]
	[FieldOffset(Offset = "0x40")]
	private GameObject message;

	[Token(Token = "0x400EADA")]
	[FieldOffset(Offset = "0x48")]
	private GameObject realtimeReplay;

	[Token(Token = "0x400EADB")]
	[FieldOffset(Offset = "0x50")]
	private GameObject ffIconOn;

	[Token(Token = "0x400EADC")]
	[FieldOffset(Offset = "0x58")]
	private GameObject ffIconOff;

	[Token(Token = "0x400EAE0")]
	[FieldOffset(Offset = "0x71")]
	private bool initialized;

	[Token(Token = "0x170018C9")]
	public Action<bool> OnChangeReplayPause
	{
		[Token(Token = "0x600A20A")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A209")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170018CA")]
	public Action OnFastReplay
	{
		[Token(Token = "0x600A20C")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A20B")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170018CB")]
	public bool IsPause
	{
		[Token(Token = "0x600A20D")]
		[Address(RVA = "0x49BE90", Offset = "0x49B090", VA = "0x18049BE90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A20E")]
		[Address(RVA = "0x49C580", Offset = "0x49B780", VA = "0x18049C580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A20F")]
	[Address(RVA = "0xCB3BB0", Offset = "0xCB2DB0", VA = "0x180CB3BB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600A210")]
	[Address(RVA = "0xEF8AA0", Offset = "0xEF7CA0", VA = "0x180EF8AA0")]
	public void Initialize(ElementObjectManager ui, DuelHUD duelHUD, GameObject replayMessage)
	{
	}

	[Token(Token = "0x600A211")]
	[Address(RVA = "0xEF9220", Offset = "0xEF8420", VA = "0x180EF9220")]
	private void Update()
	{
	}

	[Token(Token = "0x600A212")]
	[Address(RVA = "0xEF8EE0", Offset = "0xEF80E0", VA = "0x180EF8EE0")]
	public void OnTapPause()
	{
	}

	[Token(Token = "0x600A213")]
	[Address(RVA = "0xEF9060", Offset = "0xEF8260", VA = "0x180EF9060")]
	public void OnTapPlay()
	{
	}

	[Token(Token = "0x600A214")]
	[Address(RVA = "0xEF8E70", Offset = "0xEF8070", VA = "0x180EF8E70")]
	public void OnTapFast()
	{
	}

	[Token(Token = "0x600A215")]
	[Address(RVA = "0xEF91C0", Offset = "0xEF83C0", VA = "0x180EF91C0")]
	private void UpdateFFIcon()
	{
	}

	[Token(Token = "0x600A216")]
	[Address(RVA = "0xEF9140", Offset = "0xEF8340", VA = "0x180EF9140")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x600A217")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ReplayControl()
	{
	}
}
