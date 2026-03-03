using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004B2")]
[Obsolete("IUxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
public interface IUxmlFactory : IBaseUxmlFactory
{
	[Token(Token = "0x60022A8")]
	VisualElement Create(IUxmlAttributes bag, CreationContext cc);
}
