using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.CardPack.Open.Actor;
using YgomGame.CardPack.Open.Sequence;
using YgomGame.HeaderFooter;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomGame.CardPack.Open;

[Token(Token = "0x200154E")]
public class CardPackOpenViewController : BaseMenuViewController
{
	[Token(Token = "0x400CC2C")]
	private const string k_PrefPath = "CardPack/CardPackOpen";

	[Token(Token = "0x400CC2D")]
	private const string k_SECategory = "SE_PACK";

	[Token(Token = "0x400CC2E")]
	internal const string k_ArgKey_ForwardResultArgs = "ForwardResultArgs";

	[Token(Token = "0x400CC2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string k_ELabelRoot3D;

	[Token(Token = "0x400CC30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string k_ELabelRootCanvas;

	[Token(Token = "0x400CC31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelRootUI;

	[Token(Token = "0x400CC32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelRenderTextureCamera;

	[Token(Token = "0x400CC33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelBackKey;

	[Token(Token = "0x400CC34")]
	private const int s_WaitUnloadUnuseLimit = 128;

	[Token(Token = "0x400CC35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Dictionary<string, object> m_GachaDrawInfoWork;

	[Token(Token = "0x400CC36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int m_DrawPackTotal;

	[Token(Token = "0x400CC37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private CardPackRootActorContainer m_RootActorContainer;

	[Token(Token = "0x400CC38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private OutGameFooter m_Footer;

	[Token(Token = "0x400CC39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private SequenceController m_SequenceController;

	[Token(Token = "0x400CC3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Selector m_Selector3D;

	[Token(Token = "0x400CC3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private int m_OverridedCullingMaskBefore;

	[Token(Token = "0x400CC3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Camera m_OverridedCullingMaskCamera;

	[Token(Token = "0x400CC3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private int m_WaitUnloadUnuseCnt;

	[Token(Token = "0x17001412")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x600839E")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001413")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600839F")]
		[Address(RVA = "0xCB9E70", Offset = "0xCB9070", VA = "0x180CB9E70", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001414")]
	protected override int outGameBgId
	{
		[Token(Token = "0x60083A0")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60083A1")]
	[Address(RVA = "0xCB97D0", Offset = "0xCB89D0", VA = "0x180CB97D0")]
	public static void Open([Optional] ViewController swapTarget, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x60083A2")]
	[Address(RVA = "0xCB6DD0", Offset = "0xCB5FD0", VA = "0x180CB6DD0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60083A3")]
	[Address(RVA = "0xCB7E60", Offset = "0xCB7060", VA = "0x180CB7E60", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60083A4")]
	[Address(RVA = "0xCB9A20", Offset = "0xCB8C20", VA = "0x180CB9A20")]
	private void Start()
	{
	}

	[Token(Token = "0x60083A5")]
	[Address(RVA = "0xCB9D00", Offset = "0xCB8F00", VA = "0x180CB9D00")]
	private void Update()
	{
	}

	[Token(Token = "0x60083A6")]
	[Address(RVA = "0xCB9D00", Offset = "0xCB8F00", VA = "0x180CB9D00")]
	private void UpdateSequence()
	{
	}

	[Token(Token = "0x60083A7")]
	[Address(RVA = "0xCB7720", Offset = "0xCB6920", VA = "0x180CB7720", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60083A8")]
	[Address(RVA = "0xCB97A0", Offset = "0xCB89A0", VA = "0x180CB97A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60083A9")]
	[Address(RVA = "0xCB9BF0", Offset = "0xCB8DF0", VA = "0x180CB9BF0")]
	private void ToResult()
	{
	}

	[Token(Token = "0x60083AA")]
	[Address(RVA = "0xCB98A0", Offset = "0xCB8AA0", VA = "0x180CB98A0")]
	private void Skip()
	{
	}

	[Token(Token = "0x60083AB")]
	[Address(RVA = "0xCB7C60", Offset = "0xCB6E60", VA = "0x180CB7C60")]
	private void OnClickSkip()
	{
	}

	[Token(Token = "0x60083AC")]
	[Address(RVA = "0xCB7C30", Offset = "0xCB6E30", VA = "0x180CB7C30")]
	private void OnClickOk()
	{
	}

	[Token(Token = "0x60083AD")]
	[Address(RVA = "0xCB7B80", Offset = "0xCB6D80", VA = "0x180CB7B80", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60083AE")]
	[Address(RVA = "0xCB9D60", Offset = "0xCB8F60", VA = "0x180CB9D60")]
	public CardPackOpenViewController()
	{
	}
}
