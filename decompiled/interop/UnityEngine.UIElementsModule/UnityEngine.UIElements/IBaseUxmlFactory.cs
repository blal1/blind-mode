using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004B1")]
[Obsolete("IUxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
public interface IBaseUxmlFactory
{
	[Token(Token = "0x17000923")]
	string uxmlQualifiedName
	{
		[Token(Token = "0x60022A5")]
		get;
	}

	[Token(Token = "0x17000924")]
	Type uxmlType
	{
		[Token(Token = "0x60022A6")]
		get;
	}

	[Token(Token = "0x60022A7")]
	bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc);
}
