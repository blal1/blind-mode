using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004A8")]
internal class UxmlObjectAttributeDescription<T> where T : new()
{
	[Token(Token = "0x17000921")]
	public T defaultValue
	{
		[Token(Token = "0x6002296")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
	}

	[Token(Token = "0x6002297")]
	public virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
	{
		return (T)null;
	}

	[Token(Token = "0x6002298")]
	public UxmlObjectAttributeDescription()
	{
	}
}
