using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000492")]
public abstract class TypedUxmlAttributeDescription<T> : UxmlAttributeDescription
{
	[Token(Token = "0x17000920")]
	public T defaultValue
	{
		[Token(Token = "0x600224D")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x600224E")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600224C")]
	public abstract T GetValueFromBag(IUxmlAttributes bag, CreationContext cc);

	[Token(Token = "0x600224F")]
	protected TypedUxmlAttributeDescription()
	{
	}
}
