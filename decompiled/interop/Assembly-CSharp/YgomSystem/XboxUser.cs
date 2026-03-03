using System;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x200018B")]
public class XboxUser
{
	[Token(Token = "0x200018C")]
	public enum Privilege
	{
		[Token(Token = "0x400094D")]
		MULTIPLAY,
		[Token(Token = "0x400094E")]
		CROSSPLAY,
		[Token(Token = "0x400094F")]
		ADD_FRIEND,
		[Token(Token = "0x4000950")]
		COMMUNICATION
	}

	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
	public static ulong GetMyUserId()
	{
		return default(ulong);
	}

	[Token(Token = "0x60009CE")]
	[Address(RVA = "0xAFCE40", Offset = "0xAFC040", VA = "0x180AFCE40")]
	public static void ShowGamerCard(ulong xuid, Action<bool> onEnd)
	{
	}

	[Token(Token = "0x60009CF")]
	[Address(RVA = "0xAFCE20", Offset = "0xAFC020", VA = "0x180AFCE20")]
	public static void ShowMyGamerCard(Action<bool> onEnd)
	{
	}

	[Token(Token = "0x60009D0")]
	[Address(RVA = "0xAFCE40", Offset = "0xAFC040", VA = "0x180AFCE40")]
	public static void ResolvePriviledgeProblem(Privilege target, Action<bool> onEnd)
	{
	}

	[Token(Token = "0x60009D1")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public XboxUser()
	{
	}
}
