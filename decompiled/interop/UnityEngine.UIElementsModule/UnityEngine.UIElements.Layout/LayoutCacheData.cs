using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000590")]
internal struct LayoutCacheData
{
	[Token(Token = "0x40013E8")]
	[FieldOffset(Offset = "0x0")]
	public static LayoutCacheData Default;

	[Token(Token = "0x40013E9")]
	[FieldOffset(Offset = "0x0")]
	public uint NextCachedMeasurementsIndex;

	[Token(Token = "0x40013EA")]
	[FieldOffset(Offset = "0x4")]
	public FixedBuffer16<LayoutCachedMeasurement> cachedMeasurements;

	[Token(Token = "0x40013EB")]
	[FieldOffset(Offset = "0x204")]
	public LayoutCachedMeasurement CachedLayout;
}
