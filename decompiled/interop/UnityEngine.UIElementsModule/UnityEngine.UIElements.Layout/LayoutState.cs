using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005B9")]
internal struct LayoutState
{
	[Token(Token = "0x40014B3")]
	[FieldOffset(Offset = "0x0")]
	public IntPtr measureFunctionCallback;

	[Token(Token = "0x40014B4")]
	[FieldOffset(Offset = "0x8")]
	public IntPtr baselineFunctionCallback;

	[Token(Token = "0x40014B5")]
	[FieldOffset(Offset = "0x10")]
	public IntPtr unusedExceptionPointer;

	[Token(Token = "0x40014B6")]
	[FieldOffset(Offset = "0x18")]
	public uint depth;

	[Token(Token = "0x40014B7")]
	[FieldOffset(Offset = "0x1C")]
	public uint currentGenerationCount;

	[Token(Token = "0x40014B8")]
	[FieldOffset(Offset = "0x20")]
	public bool error;

	[Token(Token = "0x17000A24")]
	public static LayoutState Default
	{
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x2A74150", Offset = "0x2A73350", VA = "0x182A74150")]
		get
		{
			return default(LayoutState);
		}
	}
}
