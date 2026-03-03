using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomGame.Credit;

[Token(Token = "0x2001130")]
public class CreditEneconWidget
{
	[Token(Token = "0x400B546")]
	[FieldOffset(Offset = "0x10")]
	private readonly string BTN_ENECONICON_LABEL;

	[Token(Token = "0x400B547")]
	[FieldOffset(Offset = "0x18")]
	private readonly string IMAGE_CARD_LABEL;

	[Token(Token = "0x400B548")]
	[FieldOffset(Offset = "0x20")]
	private readonly string BTN_UP_LABEL;

	[Token(Token = "0x400B549")]
	[FieldOffset(Offset = "0x28")]
	private readonly string BTN_DOWN_LABEL;

	[Token(Token = "0x400B54A")]
	[FieldOffset(Offset = "0x30")]
	private readonly string BTN_RIGHT_LABEL;

	[Token(Token = "0x400B54B")]
	[FieldOffset(Offset = "0x38")]
	private readonly string BTN_LEFT_LABEL;

	[Token(Token = "0x400B54C")]
	[FieldOffset(Offset = "0x40")]
	private readonly string BTN_A_LABEL;

	[Token(Token = "0x400B54D")]
	[FieldOffset(Offset = "0x48")]
	private readonly string BTN_B_LABEL;

	[Token(Token = "0x400B54E")]
	[FieldOffset(Offset = "0x50")]
	private readonly string BTN_C_LABEL;

	[Token(Token = "0x400B54F")]
	[FieldOffset(Offset = "0x58")]
	private readonly string BTN_START_LABEL;

	[Token(Token = "0x400B550")]
	[FieldOffset(Offset = "0x60")]
	private readonly string ENECON_ROOT_LABEL;

	[Token(Token = "0x400B551")]
	[FieldOffset(Offset = "0x68")]
	private readonly string TLABEL_ENECONIN;

	[Token(Token = "0x400B552")]
	[FieldOffset(Offset = "0x70")]
	private readonly string TLABEL_ENECONOUT;

	[Token(Token = "0x400B553")]
	[FieldOffset(Offset = "0x78")]
	private readonly string TLABEL_ENECONUP;

	[Token(Token = "0x400B554")]
	[FieldOffset(Offset = "0x80")]
	private readonly string TLABEL_ENECONDOWN;

	[Token(Token = "0x400B555")]
	[FieldOffset(Offset = "0x88")]
	private readonly string TLABEL_ENECONRIGHT;

	[Token(Token = "0x400B556")]
	[FieldOffset(Offset = "0x90")]
	private readonly string TLABEL_ENECONLEFT;

	[Token(Token = "0x400B557")]
	[FieldOffset(Offset = "0x98")]
	private readonly string TLABEL_ENECONA;

	[Token(Token = "0x400B558")]
	[FieldOffset(Offset = "0xA0")]
	private readonly string TLABEL_ENECONB;

	[Token(Token = "0x400B559")]
	[FieldOffset(Offset = "0xA8")]
	private readonly string TLABEL_ENECONC;

	[Token(Token = "0x400B55A")]
	[FieldOffset(Offset = "0xB0")]
	private readonly string TLABEL_ENECONSTART;

	[Token(Token = "0x400B55B")]
	[FieldOffset(Offset = "0xB8")]
	private readonly string TLABEL_CARDIN;

	[Token(Token = "0x400B55C")]
	[FieldOffset(Offset = "0xC0")]
	private readonly string TLABEL_CARDOUT;

	[Token(Token = "0x400B55D")]
	[FieldOffset(Offset = "0xC8")]
	private readonly int ENECON_MRK;

	[Token(Token = "0x400B55E")]
	[FieldOffset(Offset = "0xD0")]
	private string m_tLabelEneconIn;

	[Token(Token = "0x400B55F")]
	[FieldOffset(Offset = "0xD8")]
	private string m_tLabelEneconOut;

	[Token(Token = "0x400B560")]
	[FieldOffset(Offset = "0xE0")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400B561")]
	[FieldOffset(Offset = "0xE8")]
	private GameObject m_eneconRootGO;

	[Token(Token = "0x400B562")]
	[FieldOffset(Offset = "0xF0")]
	private RawImage m_cardRawImage;

	[Token(Token = "0x400B563")]
	[FieldOffset(Offset = "0xF8")]
	private GameObject m_eneconObject;

	[Token(Token = "0x400B564")]
	[FieldOffset(Offset = "0x100")]
	private bool m_eneconIsActive;

	[Token(Token = "0x400B565")]
	[FieldOffset(Offset = "0x101")]
	private bool m_goIsActive;

	[Token(Token = "0x400B566")]
	[FieldOffset(Offset = "0x102")]
	private bool m_useVirtualEnecon;

	[Token(Token = "0x400B567")]
	[FieldOffset(Offset = "0x108")]
	public List<(string label, Action<KeyCommand.OnKeyResult> callBack)> labelCallBackPairs;

	[Token(Token = "0x400B568")]
	[FieldOffset(Offset = "0x110")]
	private List<KeyCommand> m_keyCommandList;

	[Token(Token = "0x400B569")]
	[FieldOffset(Offset = "0x118")]
	public Action<KeyCommand.OnKeyResult> OnKonamiCommandResultCallback;

	[Token(Token = "0x400B56A")]
	[FieldOffset(Offset = "0x120")]
	public Action<KeyCommand.OnKeyResult> OnEneconReleaseResultCallback;

	[Token(Token = "0x400B56B")]
	[FieldOffset(Offset = "0x128")]
	public Action<KeyCommand.OnKeyResult> OnEneconBreakResultCallback;

	[Token(Token = "0x400B56C")]
	[FieldOffset(Offset = "0x130")]
	private ElementObjectManager m_eneconEom;

	[Token(Token = "0x17001127")]
	public bool EneconIsActive
	{
		[Token(Token = "0x6006BC0")]
		[Address(RVA = "0x62D9D0", Offset = "0x62CBD0", VA = "0x18062D9D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006BC1")]
	[Address(RVA = "0xB294F0", Offset = "0xB286F0", VA = "0x180B294F0")]
	public CreditEneconWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6006BC2")]
	[Address(RVA = "0xB28CF0", Offset = "0xB27EF0", VA = "0x180B28CF0")]
	private void PlayButtonTween(string label)
	{
	}

	[Token(Token = "0x6006BC3")]
	[Address(RVA = "0xB28D70", Offset = "0xB27F70", VA = "0x180B28D70")]
	public void RegistCallbacks()
	{
	}

	[Token(Token = "0x6006BC4")]
	[Address(RVA = "0xB28AA0", Offset = "0xB27CA0", VA = "0x180B28AA0")]
	private void OnEneconIconClick()
	{
	}
}
