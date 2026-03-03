using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x200002E")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true)]
public class GenerateTestsForBurstCompatibilityAttribute : Attribute
{
	[Token(Token = "0x400018B")]
	[FieldOffset(Offset = "0x18")]
	public string RequiredUnityDefine;

	[Token(Token = "0x1700002A")]
	public Type[] GenericTypeArguments
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
	public GenerateTestsForBurstCompatibilityAttribute()
	{
	}
}
