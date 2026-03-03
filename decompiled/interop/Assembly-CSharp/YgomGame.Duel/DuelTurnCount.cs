using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x20018DF")]
public class DuelTurnCount : MonoBehaviour
{
	[Token(Token = "0x400E909")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager eom;

	[Token(Token = "0x400E90A")]
	[FieldOffset(Offset = "0x28")]
	private ExtendedTextMeshProUGUI count;

	[Token(Token = "0x400E90B")]
	[FieldOffset(Offset = "0x30")]
	private RawImage cardImg;

	[Token(Token = "0x400E90C")]
	[FieldOffset(Offset = "0x38")]
	private GameObject clockObj;

	[Token(Token = "0x400E90E")]
	[FieldOffset(Offset = "0x44")]
	private int targetNum;

	[Token(Token = "0x400E90F")]
	[FieldOffset(Offset = "0x48")]
	private int cardId;

	[Token(Token = "0x17001857")]
	public bool Finished
	{
		[Token(Token = "0x600A046")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A047")]
		[Address(RVA = "0x3D77B0", Offset = "0x3D69B0", VA = "0x1803D77B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A048")]
	[Address(RVA = "0xEDCB00", Offset = "0xEDBD00", VA = "0x180EDCB00")]
	private void Awake()
	{
	}

	[Token(Token = "0x600A049")]
	[Address(RVA = "0xEDCCF0", Offset = "0xEDBEF0", VA = "0x180EDCCF0")]
	public void Set(int mrk, int num)
	{
	}

	[Token(Token = "0x600A04A")]
	[Address(RVA = "0xEDCCC0", Offset = "0xEDBEC0", VA = "0x180EDCCC0")]
	public void OnFinishCard()
	{
	}

	[Token(Token = "0x600A04B")]
	[Address(RVA = "0xEDCC70", Offset = "0xEDBE70", VA = "0x180EDCC70")]
	public void OnFinishAnim()
	{
	}

	[Token(Token = "0x600A04C")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelTurnCount()
	{
	}
}
