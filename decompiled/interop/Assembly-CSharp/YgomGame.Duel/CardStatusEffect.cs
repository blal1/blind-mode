using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019E6")]
public class CardStatusEffect : DuelEffectHandle
{
	[Token(Token = "0x400EEF9")]
	[FieldOffset(Offset = "0x78")]
	private MeshAlphaFader alphaFader;

	[Token(Token = "0x400EEFA")]
	[FieldOffset(Offset = "0x80")]
	private TextMesh textMesh;

	[Token(Token = "0x400EEFB")]
	[FieldOffset(Offset = "0x88")]
	private bool m_isPlaying;

	[Token(Token = "0x400EEFC")]
	[FieldOffset(Offset = "0x8C")]
	private int m_order;

	[Token(Token = "0x400EEFD")]
	[FieldOffset(Offset = "0x90")]
	private bool m_showOrder;

	[Token(Token = "0x170019AC")]
	public override bool isPlaying
	{
		[Token(Token = "0x600A6FA")]
		[Address(RVA = "0x422F90", Offset = "0x422190", VA = "0x180422F90", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019AD")]
	public float fadeDulation
	{
		[Token(Token = "0x600A6FD")]
		[Address(RVA = "0xF2F210", Offset = "0xF2E410", VA = "0x180F2F210")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600A6FC")]
		[Address(RVA = "0xF2F220", Offset = "0xF2E420", VA = "0x180F2F220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170019AE")]
	public int order
	{
		[Token(Token = "0x600A701")]
		[Address(RVA = "0xCD3970", Offset = "0xCD2B70", VA = "0x180CD3970")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600A700")]
		[Address(RVA = "0xF2F230", Offset = "0xF2E430", VA = "0x180F2F230")]
		set
		{
		}
	}

	[Token(Token = "0x170019AF")]
	public bool showOrder
	{
		[Token(Token = "0x600A703")]
		[Address(RVA = "0xCC7E30", Offset = "0xCC7030", VA = "0x180CC7E30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A702")]
		[Address(RVA = "0xF2F2D0", Offset = "0xF2E4D0", VA = "0x180F2F2D0")]
		set
		{
		}
	}

	[Token(Token = "0x600A6F6")]
	[Address(RVA = "0xF2ECE0", Offset = "0xF2DEE0", VA = "0x180F2ECE0", Slot = "4")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x600A6F7")]
	[Address(RVA = "0xF2EF10", Offset = "0xF2E110", VA = "0x180F2EF10", Slot = "5")]
	protected override void OnTerminate()
	{
	}

	[Token(Token = "0x600A6F8")]
	[Address(RVA = "0xF2EE30", Offset = "0xF2E030", VA = "0x180F2EE30", Slot = "7")]
	protected override void OnPlay()
	{
	}

	[Token(Token = "0x600A6F9")]
	[Address(RVA = "0xF2EE70", Offset = "0xF2E070", VA = "0x180F2EE70", Slot = "8")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x600A6FB")]
	[Address(RVA = "0xF2EF80", Offset = "0xF2E180", VA = "0x180F2EF80", Slot = "11")]
	public virtual void SetTarget(ICardStatusIconAnchor anchor)
	{
	}

	[Token(Token = "0x600A6FE")]
	[Address(RVA = "0xF2F1B0", Offset = "0xF2E3B0", VA = "0x180F2F1B0")]
	public void Show(Action onFinished)
	{
	}

	[Token(Token = "0x600A6FF")]
	[Address(RVA = "0xF2ECA0", Offset = "0xF2DEA0", VA = "0x180F2ECA0")]
	public void Hide(Action onFinished)
	{
	}

	[Token(Token = "0x600A704")]
	[Address(RVA = "0x422F60", Offset = "0x422160", VA = "0x180422F60")]
	public CardStatusEffect()
	{
	}
}
