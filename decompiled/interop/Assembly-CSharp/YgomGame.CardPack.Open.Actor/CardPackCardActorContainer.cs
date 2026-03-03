using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.CardPack.Open.Actor;

[Token(Token = "0x2001574")]
public class CardPackCardActorContainer : ActorContainerBase<CardPackCardActorContainer>
{
	[Token(Token = "0x400CCFB")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelLocatorFormat;

	[Token(Token = "0x400CCFC")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelLocatorFoundKey;

	[Token(Token = "0x400CCFD")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelLocatorFrontModel;

	[Token(Token = "0x400CCFE")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelCardSlideEffectSet;

	[Token(Token = "0x400CCFF")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelPickUpSet;

	[Token(Token = "0x400CD00")]
	[FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelSelectHeadCardItem;

	[Token(Token = "0x400CD01")]
	private const string k_ELabelCardsCenteringLocator = "CardsCenteringLocator";

	[Token(Token = "0x400CD02")]
	private const string k_TLabelCardsCentering_Default = "Default";

	[Token(Token = "0x400CD03")]
	private const string k_TLabelCardsCentering_Modify = "Modify";

	[Token(Token = "0x400CD04")]
	private const string k_TLabelCardsCentering_Modify_01 = "Modify_01";

	[Token(Token = "0x400CD05")]
	[FieldOffset(Offset = "0x58")]
	private ActorBindingRefs m_BindingRefs;

	[Token(Token = "0x400CD06")]
	[FieldOffset(Offset = "0x60")]
	private Transform[] m_Locators;

	[Token(Token = "0x400CD07")]
	[FieldOffset(Offset = "0x68")]
	private GameObject[] m_SecretKeys;

	[Token(Token = "0x400CD08")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_CardSlideEffectSet;

	[Token(Token = "0x400CD09")]
	[FieldOffset(Offset = "0x78")]
	private GameObject m_PickUpGroupLabel;

	[Token(Token = "0x400CD0A")]
	[FieldOffset(Offset = "0x80")]
	private readonly Dictionary<int, CardPackCardActor> m_ActorMap;

	[Token(Token = "0x1700145B")]
	public IReadOnlyList<CardPackCardActor> allCardActors
	{
		[Token(Token = "0x60084B5")]
		[Address(RVA = "0xCD6CC0", Offset = "0xCD5EC0", VA = "0x180CD6CC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700145C")]
	public SelectionItem selectHeadCardItem
	{
		[Token(Token = "0x60084B6")]
		[Address(RVA = "0xCD6D70", Offset = "0xCD5F70", VA = "0x180CD6D70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700145D")]
	public GameObject[] secretKeys
	{
		[Token(Token = "0x60084B7")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700145E")]
	public bool cardSlideEffectVisible
	{
		[Token(Token = "0x60084B8")]
		[Address(RVA = "0xCD6D30", Offset = "0xCD5F30", VA = "0x180CD6D30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60084B9")]
		[Address(RVA = "0xA777E0", Offset = "0xA769E0", VA = "0x180A777E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700145F")]
	public bool pickUpGroupLabelVisible
	{
		[Token(Token = "0x60084BA")]
		[Address(RVA = "0xCD6D50", Offset = "0xCD5F50", VA = "0x180CD6D50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60084BB")]
		[Address(RVA = "0xCD6DE0", Offset = "0xCD5FE0", VA = "0x180CD6DE0")]
		set
		{
		}
	}

	[Token(Token = "0x17001460")]
	public int LocatorLength
	{
		[Token(Token = "0x60084BE")]
		[Address(RVA = "0xCD6CA0", Offset = "0xCD5EA0", VA = "0x180CD6CA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60084BC")]
	[Address(RVA = "0xCD5F80", Offset = "0xCD5180", VA = "0x180CD5F80")]
	public static CardPackCardActorContainer Create(ElementObjectManager eom, ActorBindingRefs bindingRefs)
	{
		return null;
	}

	[Token(Token = "0x60084BD")]
	[Address(RVA = "0xCD5C10", Offset = "0xCD4E10", VA = "0x180CD5C10", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x60084BF")]
	[Address(RVA = "0xCD6110", Offset = "0xCD5310", VA = "0x180CD6110")]
	public int IndexOf(CardPackCardActor cardActor)
	{
		return default(int);
	}

	[Token(Token = "0x60084C0")]
	[Address(RVA = "0xCD67B0", Offset = "0xCD59B0", VA = "0x180CD67B0")]
	public void SetCardCentering(bool isModify, int cardCnt)
	{
	}

	[Token(Token = "0x60084C1")]
	[Address(RVA = "0xCD62B0", Offset = "0xCD54B0", VA = "0x180CD62B0")]
	public CardPackCardActor InsertActor(int idx, ElementObjectManager pref)
	{
		return null;
	}

	[Token(Token = "0x60084C2")]
	[Address(RVA = "0xCD6080", Offset = "0xCD5280", VA = "0x180CD6080")]
	public Renderer GetFrontEffectRenderer(int idx)
	{
		return null;
	}

	[Token(Token = "0x60084C3")]
	[Address(RVA = "0xCD5FF0", Offset = "0xCD51F0", VA = "0x180CD5FF0")]
	public CardPackCardActor GetActorByIdx(int idx)
	{
		return null;
	}

	[Token(Token = "0x60084C4")]
	[Address(RVA = "0xCD6500", Offset = "0xCD5700", VA = "0x180CD6500")]
	public void RemoveAllActors()
	{
	}

	[Token(Token = "0x60084C5")]
	[Address(RVA = "0xCD66A0", Offset = "0xCD58A0", VA = "0x180CD66A0")]
	public bool SelectHeadActor()
	{
		return default(bool);
	}

	[Token(Token = "0x60084C6")]
	[Address(RVA = "0xCD5B30", Offset = "0xCD4D30", VA = "0x180CD5B30", Slot = "5")]
	public override void Cleanup(bool keepInfo)
	{
	}

	[Token(Token = "0x60084C7")]
	[Address(RVA = "0xCD6B20", Offset = "0xCD5D20", VA = "0x180CD6B20")]
	public CardPackCardActorContainer()
	{
	}
}
