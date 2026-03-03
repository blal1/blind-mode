using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YgomGame.Duel;

[Token(Token = "0x2001A4C")]
public class InputProvider : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	[Token(Token = "0x2001A4D")]
	public delegate void onPointerDownDelegate(PointerEventData eventData);

	[Token(Token = "0x2001A4E")]
	public delegate void onPointerUpDelegate(PointerEventData eventData);

	[Token(Token = "0x2001A4F")]
	public delegate void onPointerClickDelegate(PointerEventData eventData);

	[Token(Token = "0x2001A50")]
	public delegate void onBeginDragDelegate(PointerEventData eventData);

	[Token(Token = "0x2001A51")]
	public delegate void onEndDragDelegate(PointerEventData eventData);

	[Token(Token = "0x2001A52")]
	public delegate void onDragDelegate(PointerEventData eventData);

	[Token(Token = "0x400F295")]
	[FieldOffset(Offset = "0x50")]
	private PointerEventData draggingEventData;

	[Token(Token = "0x17001A67")]
	public Dictionary<int, PointerEventData> touchings
	{
		[Token(Token = "0x600AACE")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600AACF")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x140000DB")]
	public event onPointerDownDelegate onPointerDown
	{
		[Token(Token = "0x600AAC0")]
		[Address(RVA = "0xF6F490", Offset = "0xF6E690", VA = "0x180F6F490")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600AAC1")]
		[Address(RVA = "0xF6F850", Offset = "0xF6EA50", VA = "0x180F6F850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000DC")]
	public event onPointerUpDelegate onPointerUp
	{
		[Token(Token = "0x600AAC2")]
		[Address(RVA = "0xF6F530", Offset = "0xF6E730", VA = "0x180F6F530")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600AAC3")]
		[Address(RVA = "0xF6F8F0", Offset = "0xF6EAF0", VA = "0x180F6F8F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000DD")]
	public event onPointerClickDelegate onPointerClick
	{
		[Token(Token = "0x600AAC4")]
		[Address(RVA = "0xF6F3F0", Offset = "0xF6E5F0", VA = "0x180F6F3F0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600AAC5")]
		[Address(RVA = "0xF6F7B0", Offset = "0xF6E9B0", VA = "0x180F6F7B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000DE")]
	public event onBeginDragDelegate onBeginDrag
	{
		[Token(Token = "0x600AAC6")]
		[Address(RVA = "0xF6F210", Offset = "0xF6E410", VA = "0x180F6F210")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600AAC7")]
		[Address(RVA = "0xF6F5D0", Offset = "0xF6E7D0", VA = "0x180F6F5D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000DF")]
	public event onEndDragDelegate onEndDrag
	{
		[Token(Token = "0x600AAC8")]
		[Address(RVA = "0xF6F350", Offset = "0xF6E550", VA = "0x180F6F350")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600AAC9")]
		[Address(RVA = "0xF6F710", Offset = "0xF6E910", VA = "0x180F6F710")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x140000E0")]
	public event onDragDelegate onDrag
	{
		[Token(Token = "0x600AACA")]
		[Address(RVA = "0xF6F2B0", Offset = "0xF6E4B0", VA = "0x180F6F2B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600AACB")]
		[Address(RVA = "0xF6F670", Offset = "0xF6E870", VA = "0x180F6F670")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600AACC")]
	[Address(RVA = "0xF6EEA0", Offset = "0xF6E0A0", VA = "0x180F6EEA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600AACD")]
	[Address(RVA = "0xF6F170", Offset = "0xF6E370", VA = "0x180F6F170")]
	private void Update()
	{
	}

	[Token(Token = "0x600AAD0")]
	[Address(RVA = "0x5CE6F0", Offset = "0x5CD8F0", VA = "0x1805CE6F0", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600AAD1")]
	[Address(RVA = "0xC0E530", Offset = "0xC0D730", VA = "0x180C0E530", Slot = "5")]
	public void OnPointerUp(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600AAD2")]
	[Address(RVA = "0xC0F2C0", Offset = "0xC0E4C0", VA = "0x180C0F2C0", Slot = "6")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600AAD3")]
	[Address(RVA = "0xF6F030", Offset = "0xF6E230", VA = "0x180F6F030", Slot = "7")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600AAD4")]
	[Address(RVA = "0xF6F100", Offset = "0xF6E300", VA = "0x180F6F100", Slot = "8")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600AAD5")]
	[Address(RVA = "0xF6F080", Offset = "0xF6E280", VA = "0x180F6F080", Slot = "9")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600AAD6")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public InputProvider()
	{
	}
}
