using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Scenario;

[Token(Token = "0x2000A5F")]
public class ScenarioCardPopActor : ElementWidgetBase
{
	[Token(Token = "0x40091BA")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelSprite;

	[Token(Token = "0x40091BB")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelSubSprite;

	[Token(Token = "0x40091BC")]
	private const string k_PopResourceFormat = "Scenarios/CardPop/<_CARD_ILLUST_>/CardPop{0:D4}";

	[Token(Token = "0x40091BD")]
	[FieldOffset(Offset = "0x30")]
	public readonly SpriteRenderer spriteRenderer;

	[Token(Token = "0x40091BE")]
	[FieldOffset(Offset = "0x38")]
	public readonly SpriteRenderer subSpriteRenderer;

	[Token(Token = "0x40091BF")]
	[FieldOffset(Offset = "0x40")]
	private int m_LoadingCnt;

	[Token(Token = "0x17000885")]
	public int mrk
	{
		[Token(Token = "0x6003FDA")]
		[Address(RVA = "0x5FA7A0", Offset = "0x5F99A0", VA = "0x1805FA7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003FDB")]
		[Address(RVA = "0x86B170", Offset = "0x86A370", VA = "0x18086B170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000886")]
	public int subMrk
	{
		[Token(Token = "0x6003FDC")]
		[Address(RVA = "0x49BDB0", Offset = "0x49AFB0", VA = "0x18049BDB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003FDD")]
		[Address(RVA = "0x49C4C0", Offset = "0x49B6C0", VA = "0x18049C4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000887")]
	public bool ready
	{
		[Token(Token = "0x6003FDE")]
		[Address(RVA = "0x86B160", Offset = "0x86A360", VA = "0x18086B160")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003FDF")]
	[Address(RVA = "0x86B070", Offset = "0x86A270", VA = "0x18086B070")]
	public ScenarioCardPopActor(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003FE0")]
	[Address(RVA = "0x86ADE0", Offset = "0x869FE0", VA = "0x18086ADE0")]
	public static string GetCardPopPath(int mrk)
	{
		return null;
	}

	[Token(Token = "0x6003FE1")]
	[Address(RVA = "0x86AD70", Offset = "0x869F70", VA = "0x18086AD70", Slot = "9")]
	public override void Clear()
	{
	}

	[Token(Token = "0x6003FE2")]
	[Address(RVA = "0x86AD20", Offset = "0x869F20", VA = "0x18086AD20")]
	public void ClearSub()
	{
	}

	[Token(Token = "0x6003FE3")]
	[Address(RVA = "0x86AC50", Offset = "0x869E50", VA = "0x18086AC50")]
	public void CaptureSub()
	{
	}

	[Token(Token = "0x6003FE4")]
	[Address(RVA = "0x86AB50", Offset = "0x869D50", VA = "0x18086AB50")]
	public void Binding(int mrk)
	{
	}

	[Token(Token = "0x6003FE5")]
	[Address(RVA = "0x86AEB0", Offset = "0x86A0B0", VA = "0x18086AEB0")]
	public void Show()
	{
	}

	[Token(Token = "0x6003FE6")]
	[Address(RVA = "0x86AE70", Offset = "0x86A070", VA = "0x18086AE70")]
	public void Hide()
	{
	}

	[Token(Token = "0x6003FE7")]
	[Address(RVA = "0x86AE40", Offset = "0x86A040", VA = "0x18086AE40")]
	public void HideFront()
	{
	}
}
