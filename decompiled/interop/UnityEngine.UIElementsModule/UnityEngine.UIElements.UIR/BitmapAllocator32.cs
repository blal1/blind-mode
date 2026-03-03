using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057E")]
internal struct BitmapAllocator32
{
	[Token(Token = "0x200057F")]
	private struct Page
	{
		[Token(Token = "0x40013A1")]
		[FieldOffset(Offset = "0x0")]
		public ushort x;

		[Token(Token = "0x40013A2")]
		[FieldOffset(Offset = "0x2")]
		public ushort y;

		[Token(Token = "0x40013A3")]
		[FieldOffset(Offset = "0x4")]
		public int freeSlots;
	}

	[Token(Token = "0x400139C")]
	[FieldOffset(Offset = "0x0")]
	private int m_PageHeight;

	[Token(Token = "0x400139D")]
	[FieldOffset(Offset = "0x8")]
	private List<Page> m_Pages;

	[Token(Token = "0x400139E")]
	[FieldOffset(Offset = "0x10")]
	private List<uint> m_AllocMap;

	[Token(Token = "0x400139F")]
	[FieldOffset(Offset = "0x18")]
	private int m_EntryWidth;

	[Token(Token = "0x40013A0")]
	[FieldOffset(Offset = "0x1C")]
	private int m_EntryHeight;

	[Token(Token = "0x170009C6")]
	public int entryWidth
	{
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x138AC10", Offset = "0x1389E10", VA = "0x18138AC10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170009C7")]
	public int entryHeight
	{
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x1B5CB90", Offset = "0x1B5BD90", VA = "0x181B5CB90")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60026BB")]
	[Address(RVA = "0x2A57680", Offset = "0x2A56880", VA = "0x182A57680")]
	public void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1)
	{
	}

	[Token(Token = "0x60026BC")]
	[Address(RVA = "0x2A57820", Offset = "0x2A56A20", VA = "0x182A57820")]
	public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY)
	{
	}

	[Token(Token = "0x60026BD")]
	[Address(RVA = "0x2A571E0", Offset = "0x2A563E0", VA = "0x182A571E0")]
	public BMPAlloc Allocate(BaseShaderInfoStorage storage)
	{
		return default(BMPAlloc);
	}

	[Token(Token = "0x60026BE")]
	[Address(RVA = "0x2A579D0", Offset = "0x2A56BD0", VA = "0x182A579D0")]
	public void Free(BMPAlloc alloc)
	{
	}

	[Token(Token = "0x60026C1")]
	[Address(RVA = "0x2A57B10", Offset = "0x2A56D10", VA = "0x182A57B10")]
	internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y)
	{
	}

	[Token(Token = "0x60026C2")]
	[Address(RVA = "0x2A577A0", Offset = "0x2A569A0", VA = "0x182A577A0")]
	private static byte CountTrailingZeroes(uint val)
	{
		return default(byte);
	}
}
