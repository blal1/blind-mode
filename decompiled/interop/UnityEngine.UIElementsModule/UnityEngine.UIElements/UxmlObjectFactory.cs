using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004B7")]
[Obsolete("UxmlObjectFactory<TCreatedType, TTraits> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
internal class UxmlObjectFactory<TCreatedType, TTraits> : BaseUxmlFactory<TCreatedType, TTraits>, IUxmlObjectFactory<TCreatedType>, IBaseUxmlObjectFactory, IBaseUxmlFactory where TCreatedType : new() where TTraits : UxmlObjectTraits<TCreatedType>, new()
{
	[Token(Token = "0x60022B2")]
	public virtual TCreatedType CreateObject(IUxmlAttributes bag, CreationContext cc)
	{
		return (TCreatedType)null;
	}

	[Token(Token = "0x60022B3")]
	public UxmlObjectFactory()
	{
	}
}
