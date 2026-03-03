using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Jobs;

[Token(Token = "0x2000004")]
public class EarlyInitHelpers
{
	[Token(Token = "0x2000005")]
	public delegate void EarlyInitFunction();

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private static List<EarlyInitFunction> s_PendingDelegates;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x22FCAE0", Offset = "0x22FBCE0", VA = "0x1822FCAE0")]
	static EarlyInitHelpers()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x22FC900", Offset = "0x22FBB00", VA = "0x1822FC900")]
	public static void FlushEarlyInits()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x22FCA70", Offset = "0x22FBC70", VA = "0x1822FCA70")]
	public static void JobReflectionDataCreationFailed(Exception ex)
	{
	}
}
