using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000592")]
internal struct LayoutComputedData
{
	[Token(Token = "0x40013F5")]
	[FieldOffset(Offset = "0x0")]
	public unsafe fixed float Position[4];

	[Token(Token = "0x40013F6")]
	[FieldOffset(Offset = "0x10")]
	public unsafe fixed float Dimensions[2];

	[Token(Token = "0x40013F7")]
	[FieldOffset(Offset = "0x18")]
	public unsafe fixed float Margin[6];

	[Token(Token = "0x40013F8")]
	[FieldOffset(Offset = "0x30")]
	public unsafe fixed float Border[6];

	[Token(Token = "0x40013F9")]
	[FieldOffset(Offset = "0x48")]
	public unsafe fixed float Padding[6];

	[Token(Token = "0x40013FA")]
	[FieldOffset(Offset = "0x60")]
	public LayoutDirection Direction;

	[Token(Token = "0x40013FB")]
	[FieldOffset(Offset = "0x64")]
	public uint ComputedFlexBasisGeneration;

	[Token(Token = "0x40013FC")]
	[FieldOffset(Offset = "0x68")]
	public float ComputedFlexBasis;

	[Token(Token = "0x40013FD")]
	[FieldOffset(Offset = "0x6C")]
	public bool HadOverflow;

	[Token(Token = "0x40013FE")]
	[FieldOffset(Offset = "0x70")]
	public uint GenerationCount;

	[Token(Token = "0x40013FF")]
	[FieldOffset(Offset = "0x74")]
	public LayoutDirection LastParentDirection;

	[Token(Token = "0x4001400")]
	[FieldOffset(Offset = "0x78")]
	public float LastPointScaleFactor;

	[Token(Token = "0x4001401")]
	[FieldOffset(Offset = "0x7C")]
	public unsafe fixed float MeasuredDimensions[2];

	[Token(Token = "0x17000A14")]
	public static LayoutComputedData Default
	{
		[Token(Token = "0x600277B")]
		[Address(RVA = "0x2A6DA00", Offset = "0x2A6CC00", VA = "0x182A6DA00")]
		get
		{
			return default(LayoutComputedData);
		}
	}

	[Token(Token = "0x17000A15")]
	public unsafe float* MarginBuffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x600277C")]
		[Address(RVA = "0x2A6DBB0", Offset = "0x2A6CDB0", VA = "0x182A6DBB0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (float*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x17000A16")]
	public unsafe float* BorderBuffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x600277D")]
		[Address(RVA = "0x2A6D9F0", Offset = "0x2A6CBF0", VA = "0x182A6D9F0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (float*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x17000A17")]
	public unsafe float* PaddingBuffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x2A6DBC0", Offset = "0x2A6CDC0", VA = "0x182A6DBC0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (float*)unchecked((nint)null);
		}
	}
}
