using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000025")]
public class ConverterGroup
{
	[Token(Token = "0x1700002A")]
	internal TypeConverterRegistry registry
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return default(TypeConverterRegistry);
		}
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x29794B0", Offset = "0x29786B0", VA = "0x1829794B0")]
	public ConverterGroup(string id, [Optional] string displayName, [Optional] string description)
	{
	}

	[Token(Token = "0x60000B8")]
	public bool TryConvert<TSource, TDestination>(ref TSource source, out TDestination destination)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B9")]
	public bool TrySetValue<TContainer, TValue>(ref TContainer container, in PropertyPath path, TValue value, out VisitReturnCode returnCode)
	{
		return default(bool);
	}
}
