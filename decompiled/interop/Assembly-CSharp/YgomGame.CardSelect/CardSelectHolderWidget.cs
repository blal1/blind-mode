using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.CardSelect;

[Token(Token = "0x2001525")]
public class CardSelectHolderWidget : ElementWidgetBase
{
	[Token(Token = "0x400CB63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_MinSelectCount;

	[Token(Token = "0x400CB64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int m_MaxSelectCount;

	[Token(Token = "0x400CB65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x400CB66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<int> m_SlotMRKs;

	[Token(Token = "0x400CB67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_CardpoolId;

	[Token(Token = "0x400CB68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SelectionButton openButton;

	[Token(Token = "0x400CB6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Func<SelectionItem, PadInputDirection, bool> onInputDirectionFunc;

	[Token(Token = "0x170013ED")]
	public int cardpoolId
	{
		[Token(Token = "0x60082AD")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60082AE")]
		[Address(RVA = "0x4A69B0", Offset = "0x4A5BB0", VA = "0x1804A69B0")]
		set
		{
		}
	}

	[Token(Token = "0x170013EE")]
	public int minSelectCount
	{
		[Token(Token = "0x60082AF")]
		[Address(RVA = "0xCBC340", Offset = "0xCBB540", VA = "0x180CBC340")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60082B0")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		set
		{
		}
	}

	[Token(Token = "0x170013EF")]
	public int maxSelectCount
	{
		[Token(Token = "0x60082B1")]
		[Address(RVA = "0xCBC2E0", Offset = "0xCBB4E0", VA = "0x180CBC2E0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60082B2")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		set
		{
		}
	}

	[Token(Token = "0x170013F0")]
	public bool isCompleteSlots
	{
		[Token(Token = "0x60082B3")]
		[Address(RVA = "0xCBC1A0", Offset = "0xCBB3A0", VA = "0x180CBC1A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170013F1")]
	public bool isFillSlots
	{
		[Token(Token = "0x60082B4")]
		[Address(RVA = "0xCBC240", Offset = "0xCBB440", VA = "0x180CBC240")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170013F2")]
	public Selector selector
	{
		[Token(Token = "0x60082B5")]
		[Address(RVA = "0xCBC3A0", Offset = "0xCBB5A0", VA = "0x180CBC3A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013F3")]
	public List<int> holderMRKs
	{
		[Token(Token = "0x60082B6")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60082B7")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		set
		{
		}
	}

	[Token(Token = "0x140000A6")]
	public event Action<int, int> onClickSlotEvent
	{
		[Token(Token = "0x60082B8")]
		[Address(RVA = "0xCBC0F0", Offset = "0xCBB2F0", VA = "0x180CBC0F0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60082B9")]
		[Address(RVA = "0xCBC490", Offset = "0xCBB690", VA = "0x180CBC490")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000A7")]
	public event Action onClickButtonEvent
	{
		[Token(Token = "0x60082BA")]
		[Address(RVA = "0xCBC050", Offset = "0xCBB250", VA = "0x180CBC050")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60082BB")]
		[Address(RVA = "0xCBC3F0", Offset = "0xCBB5F0", VA = "0x180CBC3F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60082BC")]
	[Address(RVA = "0xCBBF40", Offset = "0xCBB140", VA = "0x180CBBF40")]
	public CardSelectHolderWidget(ElementObjectManager eom, SelectionButton openButton)
	{
	}

	[Token(Token = "0x60082BD")]
	[Address(RVA = "0xCBB9B0", Offset = "0xCBABB0", VA = "0x180CBB9B0")]
	public void Initialize([Optional] Action onComplete)
	{
	}

	[Token(Token = "0x60082BE")]
	[Address(RVA = "0xCBB920", Offset = "0xCBAB20", VA = "0x180CBB920")]
	public void Apply()
	{
	}

	[Token(Token = "0x60082BF")]
	[Address(RVA = "0xCBBCF0", Offset = "0xCBAEF0", VA = "0x180CBBCF0")]
	private void OnUpdateEntity(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x60082C0")]
	[Address(RVA = "0xCBBCD0", Offset = "0xCBAED0", VA = "0x180CBBCD0")]
	private bool OnCustomEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x60082C1")]
	[Address(RVA = "0xCBBCB0", Offset = "0xCBAEB0", VA = "0x180CBBCB0")]
	private void OnClickEntity(int idx, int mrk)
	{
	}
}
