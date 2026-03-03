using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace Unity.Properties;

[Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class CreatePropertyAttribute : RequiredMemberAttribute
{
	[Token(Token = "0x17000002")]
	public bool ReadOnly
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x28D86F0", Offset = "0x28D78F0", VA = "0x1828D86F0")]
	public CreatePropertyAttribute()
	{
	}
}
