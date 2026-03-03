using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Properties.Internal;

[Token(Token = "0x200006E")]
internal interface IAttributes
{
	[Token(Token = "0x17000050")]
	List<Attribute> Attributes
	{
		[Token(Token = "0x6000265")]
		get;
		[Token(Token = "0x6000266")]
		set;
	}

	[Token(Token = "0x6000267")]
	void AddAttribute(Attribute attribute);

	[Token(Token = "0x6000268")]
	void AddAttributes(IEnumerable<Attribute> attributes);

	[Token(Token = "0x6000269")]
	AttributesScope CreateAttributesScope(IAttributes attributes);
}
