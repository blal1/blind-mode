using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000582")]
internal readonly struct LayoutHandle
{
	[Token(Token = "0x40013C2")]
	[FieldOffset(Offset = "0x0")]
	public readonly int Index;

	[Token(Token = "0x40013C3")]
	[FieldOffset(Offset = "0x4")]
	public readonly int Version;

	[Token(Token = "0x170009CE")]
	public static LayoutHandle Undefined
	{
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
		get
		{
			return default(LayoutHandle);
		}
	}

	[Token(Token = "0x60026E8")]
	[Address(RVA = "0xB684C0", Offset = "0xB676C0", VA = "0x180B684C0")]
	internal LayoutHandle(int index, int version)
	{
	}

	[Token(Token = "0x60026E9")]
	[Address(RVA = "0x27CA5D0", Offset = "0x27C97D0", VA = "0x1827CA5D0")]
	public bool Equals(LayoutHandle other)
	{
		return default(bool);
	}

	[Token(Token = "0x60026EA")]
	[Address(RVA = "0x2A6F470", Offset = "0x2A6E670", VA = "0x182A6F470", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60026EB")]
	[Address(RVA = "0x2855780", Offset = "0x2854980", VA = "0x182855780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
