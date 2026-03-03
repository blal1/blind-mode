using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000581")]
internal readonly struct LayoutConfig
{
	[Token(Token = "0x40013C0")]
	[FieldOffset(Offset = "0x0")]
	private readonly LayoutDataAccess m_Access;

	[Token(Token = "0x40013C1")]
	[FieldOffset(Offset = "0x28")]
	private readonly LayoutHandle m_Handle;

	[Token(Token = "0x170009CB")]
	public static LayoutConfig Undefined
	{
		[Token(Token = "0x60026E3")]
		[Address(RVA = "0x2A6DC20", Offset = "0x2A6CE20", VA = "0x182A6DC20")]
		get
		{
			return default(LayoutConfig);
		}
	}

	[Token(Token = "0x170009CC")]
	public LayoutHandle Handle
	{
		[Token(Token = "0x60026E5")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return default(LayoutHandle);
		}
	}

	[Token(Token = "0x170009CD")]
	public unsafe ref float PointScaleFactor
	{
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0x2A6DC10", Offset = "0x2A6CE10", VA = "0x182A6DC10")]
		get
		{
			return ref *(float*)null;
		}
	}

	[Token(Token = "0x60026E4")]
	[Address(RVA = "0x2A6DBF0", Offset = "0x2A6CDF0", VA = "0x182A6DBF0")]
	internal LayoutConfig(LayoutDataAccess access, LayoutHandle handle)
	{
	}
}
