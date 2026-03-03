using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000283")]
public class Request
{
	[Token(Token = "0x4000E75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Dictionary<string, EventHandler> s_commandHandle;

	[Token(Token = "0x14000011")]
	private static event EventHandler s_commonStartHandle
	{
		[Token(Token = "0x6000F53")]
		[Address(RVA = "0xE75380", Offset = "0xE74580", VA = "0x180E75380")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0xE75670", Offset = "0xE74870", VA = "0x180E75670")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000012")]
	private static event EventHandler s_commonCompleteHandle
	{
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0xE75180", Offset = "0xE74380", VA = "0x180E75180")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0xE75470", Offset = "0xE74670", VA = "0x180E75470")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000013")]
	private static event EventHandler s_commonErrorHandle
	{
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0xE75280", Offset = "0xE74480", VA = "0x180E75280")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0xE75570", Offset = "0xE74770", VA = "0x180E75570")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000F49")]
	[Address(RVA = "0xE74EF0", Offset = "0xE740F0", VA = "0x180E74EF0")]
	public static Handle SetCommonHandler(Handle handle)
	{
		return null;
	}

	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0xE74AD0", Offset = "0xE73CD0", VA = "0x180E74AD0")]
	public static void InvokeCommonStartHandle(Handle handle)
	{
	}

	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0xE74680", Offset = "0xE73880", VA = "0x180E74680")]
	public static void AddCommonStartEvent(EventHandler e)
	{
	}

	[Token(Token = "0x6000F4C")]
	[Address(RVA = "0xE74420", Offset = "0xE73620", VA = "0x180E74420")]
	public static void AddCommonCompleteEvent(EventHandler e)
	{
	}

	[Token(Token = "0x6000F4D")]
	[Address(RVA = "0xE74550", Offset = "0xE73750", VA = "0x180E74550")]
	public static void AddCommonErrorEvent(EventHandler e)
	{
	}

	[Token(Token = "0x6000F4E")]
	[Address(RVA = "0xE74DD0", Offset = "0xE73FD0", VA = "0x180E74DD0")]
	public static void RemoveCommonStartEvent(EventHandler e)
	{
	}

	[Token(Token = "0x6000F4F")]
	[Address(RVA = "0xE74B70", Offset = "0xE73D70", VA = "0x180E74B70")]
	public static void RemoveCommonCompleteEvent(EventHandler e)
	{
	}

	[Token(Token = "0x6000F50")]
	[Address(RVA = "0xE74CA0", Offset = "0xE73EA0", VA = "0x180E74CA0")]
	public static void RemoveCommonErrorEvent(EventHandler e)
	{
	}

	[Token(Token = "0x6000F51")]
	[Address(RVA = "0xE742A0", Offset = "0xE734A0", VA = "0x180E742A0")]
	public static void AddCommandEvent(string command, EventHandler e)
	{
	}

	[Token(Token = "0x6000F52")]
	[Address(RVA = "0xE74860", Offset = "0xE73A60", VA = "0x180E74860")]
	public static void DelCommandEvent(string command, EventHandler e)
	{
	}

	[Token(Token = "0x6000F59")]
	[Address(RVA = "0xE74A30", Offset = "0xE73C30", VA = "0x180E74A30")]
	public static Handle Entry(string command, [Optional] Dictionary<string, object> param, float timeOut = 30f)
	{
		return null;
	}

	[Token(Token = "0x6000F5A")]
	[Address(RVA = "0xE747A0", Offset = "0xE739A0", VA = "0x180E747A0")]
	public static void CommandEvent(string command, Handle handle)
	{
	}

	[Token(Token = "0x6000F5B")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Request()
	{
	}
}
