using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000599")]
internal struct LayoutConfigData
{
	[Token(Token = "0x4001408")]
	[FieldOffset(Offset = "0x0")]
	public float PointScaleFactor;

	[Token(Token = "0x4001409")]
	[FieldOffset(Offset = "0x4")]
	public bool ShouldLog;

	[Token(Token = "0x17000A18")]
	public static LayoutConfigData Default
	{
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x2A6DBD0", Offset = "0x2A6CDD0", VA = "0x182A6DBD0")]
		get
		{
			return default(LayoutConfigData);
		}
	}
}
