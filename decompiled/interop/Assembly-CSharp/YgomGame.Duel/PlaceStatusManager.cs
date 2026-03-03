using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001921")]
public class PlaceStatusManager
{
	[Token(Token = "0x400EAD1")]
	[FieldOffset(Offset = "0x10")]
	private GameObject root;

	[Token(Token = "0x400EAD2")]
	[FieldOffset(Offset = "0x18")]
	private Object labelPrefab;

	[Token(Token = "0x400EAD3")]
	[FieldOffset(Offset = "0x20")]
	private Object handLabelPrefab;

	[Token(Token = "0x170018C8")]
	public bool visibleAll
	{
		[Token(Token = "0x600A1FE")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A1FF")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A200")]
	[Address(RVA = "0xEF76A0", Offset = "0xEF68A0", VA = "0x180EF76A0")]
	public void Initialize(GameObject parent, GameObject labelPrefab, GameObject handLabelPrefab, GameObject rootPrefab)
	{
	}

	[Token(Token = "0x600A201")]
	[Address(RVA = "0xEF7420", Offset = "0xEF6620", VA = "0x180EF7420")]
	private PlaceStatusLabel Create()
	{
		return null;
	}

	[Token(Token = "0x600A202")]
	[Address(RVA = "0xEF7330", Offset = "0xEF6530", VA = "0x180EF7330")]
	private PlaceStatusLabel CreateHand()
	{
		return null;
	}

	[Token(Token = "0x600A203")]
	[Address(RVA = "0xEF7A10", Offset = "0xEF6C10", VA = "0x180EF7A10")]
	public PlaceStatusLabel Use(SharedDefinition.Location location, bool lieDown, bool hand)
	{
		return null;
	}

	[Token(Token = "0x600A204")]
	[Address(RVA = "0xEF79A0", Offset = "0xEF6BA0", VA = "0x180EF79A0")]
	public void Unuse(PlaceStatusLabel instance)
	{
	}

	[Token(Token = "0x600A205")]
	[Address(RVA = "0xEF77C0", Offset = "0xEF69C0", VA = "0x180EF77C0")]
	public void ShowAll()
	{
	}

	[Token(Token = "0x600A206")]
	[Address(RVA = "0xEF7510", Offset = "0xEF6710", VA = "0x180EF7510")]
	public void HideAll()
	{
	}

	[Token(Token = "0x600A207")]
	[Address(RVA = "0xEF78E0", Offset = "0xEF6AE0", VA = "0x180EF78E0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A208")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PlaceStatusManager()
	{
	}
}
