using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x200002F")]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
public class ExcludeFromBurstCompatTestingAttribute : Attribute
{
	[Token(Token = "0x1700002B")]
	public string Reason
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x59D480", Offset = "0x59C680", VA = "0x18059D480")]
	public ExcludeFromBurstCompatTestingAttribute(string _reason)
	{
	}
}
