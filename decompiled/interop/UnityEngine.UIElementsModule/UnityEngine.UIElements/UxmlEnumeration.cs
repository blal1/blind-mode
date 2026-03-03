using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004C1")]
public class UxmlEnumeration : UxmlTypeRestriction
{
	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0x10")]
	private List<string> m_Values;

	[Token(Token = "0x17000930")]
	public IEnumerable<string> values
	{
		[Token(Token = "0x60022D6")]
		[Address(RVA = "0x1B5CB80", Offset = "0x1B5BD80", VA = "0x181B5CB80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x2A1CE60", Offset = "0x2A1C060", VA = "0x182A1CE60")]
		set
		{
		}
	}

	[Token(Token = "0x60022D8")]
	[Address(RVA = "0x2A1CC80", Offset = "0x2A1BE80", VA = "0x182A1CC80", Slot = "5")]
	public override bool Equals(UxmlTypeRestriction other)
	{
		return default(bool);
	}

	[Token(Token = "0x60022D9")]
	[Address(RVA = "0x2A1CDE0", Offset = "0x2A1BFE0", VA = "0x182A1CDE0")]
	public UxmlEnumeration()
	{
	}
}
