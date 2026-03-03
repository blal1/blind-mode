using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open.Actor;

[Token(Token = "0x2001576")]
public class CardPackPackActorContainer : ActorContainerBase<CardPackPackActorContainer>
{
	[Token(Token = "0x400CD12")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelLocatorFormat;

	[Token(Token = "0x400CD13")]
	[FieldOffset(Offset = "0x30")]
	private ActorBindingRefs m_BindingRefs;

	[Token(Token = "0x400CD14")]
	[FieldOffset(Offset = "0x38")]
	private Transform[] m_Locators;

	[Token(Token = "0x400CD15")]
	[FieldOffset(Offset = "0x40")]
	private readonly Dictionary<int, CardPackPackActor> m_ActorMap;

	[Token(Token = "0x17001461")]
	public int locatorLength
	{
		[Token(Token = "0x60084D0")]
		[Address(RVA = "0xCD9720", Offset = "0xCD8920", VA = "0x180CD9720")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60084D1")]
	[Address(RVA = "0xCD8FE0", Offset = "0xCD81E0", VA = "0x180CD8FE0")]
	public static CardPackPackActorContainer Create(ElementObjectManager eom, ActorBindingRefs bindingRefs)
	{
		return null;
	}

	[Token(Token = "0x60084D2")]
	[Address(RVA = "0xCD8E20", Offset = "0xCD8020", VA = "0x180CD8E20", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x60084D3")]
	[Address(RVA = "0xCD9150", Offset = "0xCD8350", VA = "0x180CD9150")]
	public CardPackPackActor InsertActor(int idx, string packTexPath, ElementObjectManager pref)
	{
		return null;
	}

	[Token(Token = "0x60084D4")]
	[Address(RVA = "0xCD9050", Offset = "0xCD8250", VA = "0x180CD9050")]
	public CardPackPackActor GetActor(int idx)
	{
		return null;
	}

	[Token(Token = "0x60084D5")]
	[Address(RVA = "0xCD90B0", Offset = "0xCD82B0", VA = "0x180CD90B0")]
	public Renderer GetPackHighlight(int idx)
	{
		return null;
	}

	[Token(Token = "0x60084D6")]
	[Address(RVA = "0xCD94D0", Offset = "0xCD86D0", VA = "0x180CD94D0")]
	public void RemoveAllActors()
	{
	}

	[Token(Token = "0x60084D7")]
	[Address(RVA = "0xCD8E10", Offset = "0xCD8010", VA = "0x180CD8E10", Slot = "5")]
	public override void Cleanup(bool keepInfo)
	{
	}

	[Token(Token = "0x60084D8")]
	[Address(RVA = "0xCD9670", Offset = "0xCD8870", VA = "0x180CD9670")]
	public CardPackPackActorContainer()
	{
	}
}
