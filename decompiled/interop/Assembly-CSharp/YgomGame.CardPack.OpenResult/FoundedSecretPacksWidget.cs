using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Shop;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.CardPack.OpenResult;

[Token(Token = "0x2001543")]
public class FoundedSecretPacksWidget : ElementWidgetBase
{
	[Token(Token = "0x400CBDA")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelScrollView;

	[Token(Token = "0x400CBDB")]
	[FieldOffset(Offset = "0x28")]
	private readonly InfinityScrollView m_ScrollView;

	[Token(Token = "0x400CBDC")]
	[FieldOffset(Offset = "0x30")]
	private readonly Dictionary<GameObject, ProductWidget> m_EntityWidgetMap;

	[Token(Token = "0x400CBDD")]
	[FieldOffset(Offset = "0x38")]
	public List<ProductContext> productContexts;

	[Token(Token = "0x400CBDE")]
	[FieldOffset(Offset = "0x40")]
	public List<object> extraPackGroupsWork;

	[Token(Token = "0x17001409")]
	public InfinityScrollView scrollView
	{
		[Token(Token = "0x600835B")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x140000A8")]
	public event Action<ProductContext> onClickPackEvent
	{
		[Token(Token = "0x600835C")]
		[Address(RVA = "0xCBEF00", Offset = "0xCBE100", VA = "0x180CBEF00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600835D")]
		[Address(RVA = "0xCBEFB0", Offset = "0xCBE1B0", VA = "0x180CBEFB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600835E")]
	[Address(RVA = "0xCBEE10", Offset = "0xCBE010", VA = "0x180CBEE10")]
	public FoundedSecretPacksWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600835F")]
	[Address(RVA = "0xCBE260", Offset = "0xCBD460", VA = "0x180CBE260")]
	public void ActivateScroll(Action onConplete)
	{
	}

	[Token(Token = "0x6008360")]
	[Address(RVA = "0xCBE400", Offset = "0xCBD600", VA = "0x180CBE400")]
	public void OnCreatedEntity(GameObject gob)
	{
	}

	[Token(Token = "0x6008361")]
	[Address(RVA = "0xCBE5F0", Offset = "0xCBD7F0", VA = "0x180CBE5F0")]
	public void OnUpdateEntity(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6008362")]
	[Address(RVA = "0xCBECC0", Offset = "0xCBDEC0", VA = "0x180CBECC0")]
	public void OpenClickPackWidget(ProductWidget packWidget)
	{
	}

	[Token(Token = "0x6008363")]
	[Address(RVA = "0xCBED40", Offset = "0xCBDF40", VA = "0x180CBED40")]
	public void SelectBottomEntity()
	{
	}
}
