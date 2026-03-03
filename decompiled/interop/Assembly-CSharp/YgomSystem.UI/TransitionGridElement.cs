using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004D6")]
[RequireComponent(typeof(SelectionItem))]
public class TransitionGridElement : MonoBehaviour, IComparable<TransitionGridElement>
{
	[Token(Token = "0x40017D7")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_PosX;

	[Token(Token = "0x40017D8")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int m_PosY;

	[Token(Token = "0x40017D9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int m_SubPriority;

	[Token(Token = "0x40017DA")]
	[FieldOffset(Offset = "0x30")]
	private SelectionItem m_SelectionItemCache;

	[Token(Token = "0x17000346")]
	public SelectionItem selectionItem
	{
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x638610", Offset = "0x637810", VA = "0x180638610")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000347")]
	public int posX
	{
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000348")]
	public int posY
	{
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		set
		{
		}
	}

	[Token(Token = "0x17000349")]
	public int subPriority
	{
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
		set
		{
		}
	}

	[Token(Token = "0x6002017")]
	[Address(RVA = "0x638580", Offset = "0x637780", VA = "0x180638580")]
	public int Compare(TransitionGridElement a, TransitionGridElement b)
	{
		return default(int);
	}

	[Token(Token = "0x6002018")]
	[Address(RVA = "0x6384F0", Offset = "0x6376F0", VA = "0x1806384F0", Slot = "4")]
	public int CompareTo(TransitionGridElement other)
	{
		return default(int);
	}

	[Token(Token = "0x6002019")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public TransitionGridElement()
	{
	}
}
