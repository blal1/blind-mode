using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004B0")]
[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
internal abstract class UxmlObjectTraits<T> : BaseUxmlTraits
{
	[Token(Token = "0x60022A3")]
	public virtual void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
	{
	}

	[Token(Token = "0x60022A4")]
	protected UxmlObjectTraits()
	{
	}
}
