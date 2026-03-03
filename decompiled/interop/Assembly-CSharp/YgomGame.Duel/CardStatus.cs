using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019E5")]
public class CardStatus
{
	[Token(Token = "0x400EEF3")]
	[FieldOffset(Offset = "0x10")]
	private List<CardStatusEffect> dynamicAnchorEffs;

	[Token(Token = "0x400EEF4")]
	[FieldOffset(Offset = "0x18")]
	private CardStatusEffect chainOrderEff;

	[Token(Token = "0x400EEF5")]
	[FieldOffset(Offset = "0x20")]
	private CardStatusEffect sacrificeTgtEff;

	[Token(Token = "0x400EEF6")]
	[FieldOffset(Offset = "0x28")]
	private CardStatusLabel3D statusLabel3d;

	[Token(Token = "0x170019A5")]
	public bool IsShowing
	{
		[Token(Token = "0x600A6DF")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A6E0")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019A6")]
	public bool ShowFullStatus
	{
		[Token(Token = "0x600A6E2")]
		[Address(RVA = "0xF36410", Offset = "0xF35610", VA = "0x180F36410")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A6E1")]
		[Address(RVA = "0xF36460", Offset = "0xF35660", VA = "0x180F36460")]
		set
		{
		}
	}

	[Token(Token = "0x170019A7")]
	public bool isTerminated
	{
		[Token(Token = "0x600A6E6")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170019A8")]
	public CardRoot cardRoot
	{
		[Token(Token = "0x600A6EA")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A6EB")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170019A9")]
	private DuelEffectPool pool
	{
		[Token(Token = "0x600A6F1")]
		[Address(RVA = "0xF36430", Offset = "0xF35630", VA = "0x180F36430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019AA")]
	private ICardStatusIconAnchor dynamicAnchor
	{
		[Token(Token = "0x600A6F2")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019AB")]
	private ICardStatusIconAnchor cardAnchor
	{
		[Token(Token = "0x600A6F3")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600A6E3")]
	[Address(RVA = "0xF35F60", Offset = "0xF35160", VA = "0x180F35F60")]
	public static CardStatus Create(CardRoot cardRoot)
	{
		return null;
	}

	[Token(Token = "0x600A6E4")]
	[Address(RVA = "0xF361F0", Offset = "0xF353F0", VA = "0x180F361F0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600A6E5")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A6E7")]
	[Address(RVA = "0xF362B0", Offset = "0xF354B0", VA = "0x180F362B0")]
	public void Update()
	{
	}

	[Token(Token = "0x600A6E8")]
	[Address(RVA = "0xF36290", Offset = "0xF35490", VA = "0x180F36290")]
	private void UpdateStatusLabel3d()
	{
	}

	[Token(Token = "0x600A6E9")]
	[Address(RVA = "0xF36310", Offset = "0xF35510", VA = "0x180F36310")]
	private Vector2 World2ScreenPos(Vector3 pos)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600A6EC")]
	[Address(RVA = "0xF36260", Offset = "0xF35460", VA = "0x180F36260")]
	public void StartStatusLabel3D(bool immediate = false)
	{
	}

	[Token(Token = "0x600A6ED")]
	[Address(RVA = "0xF361A0", Offset = "0xF353A0", VA = "0x180F361A0")]
	public void EndStatusLabel3D(bool immediate = false)
	{
	}

	[Token(Token = "0x600A6EE")]
	[Address(RVA = "0xF361D0", Offset = "0xF353D0", VA = "0x180F361D0")]
	public void InitParameters()
	{
	}

	[Token(Token = "0x600A6EF")]
	[Address(RVA = "0xF35E40", Offset = "0xF35040", VA = "0x180F35E40")]
	public void AtkToDefEffect()
	{
	}

	[Token(Token = "0x600A6F0")]
	[Address(RVA = "0xF36080", Offset = "0xF35280", VA = "0x180F36080")]
	public void DefToAtkEffect()
	{
	}

	[Token(Token = "0x600A6F4")]
	[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
	public CardStatusLabel3D GetStatusLabel3d()
	{
		return null;
	}

	[Token(Token = "0x600A6F5")]
	[Address(RVA = "0xF36390", Offset = "0xF35590", VA = "0x180F36390")]
	public CardStatus()
	{
	}
}
