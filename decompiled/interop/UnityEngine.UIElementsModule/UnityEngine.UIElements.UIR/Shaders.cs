using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200056C")]
internal static class Shaders
{
	[Token(Token = "0x4001345")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string k_AtlasBlit;

	[Token(Token = "0x4001346")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string k_Editor;

	[Token(Token = "0x4001347")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string k_Runtime;

	[Token(Token = "0x4001348")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string k_RuntimeWorld;

	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string k_ColorConversionBlit;

	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string k_ForceGammaKeyword;

	[Token(Token = "0x400134B")]
	[FieldOffset(Offset = "0x30")]
	private static Material s_RuntimeMaterial;

	[Token(Token = "0x400134C")]
	[FieldOffset(Offset = "0x38")]
	private static Material s_RuntimeWorldMaterial;

	[Token(Token = "0x400134D")]
	[FieldOffset(Offset = "0x40")]
	private static Material s_EditorMaterial;

	[Token(Token = "0x400134E")]
	[FieldOffset(Offset = "0x48")]
	private static int s_RefCount;

	[Token(Token = "0x170009BD")]
	public static Material runtimeMaterial
	{
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x2A627E0", Offset = "0x2A619E0", VA = "0x182A627E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009BE")]
	public static Material runtimeWorldMaterial
	{
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x2A62840", Offset = "0x2A61A40", VA = "0x182A62840")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009BF")]
	public static Material editorMaterial
	{
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x2A62780", Offset = "0x2A61980", VA = "0x182A62780")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600266F")]
	[Address(RVA = "0x2A62270", Offset = "0x2A61470", VA = "0x182A62270")]
	private static Material GetOrCreateMaterial(ref Material material, string shaderName)
	{
		return null;
	}

	[Token(Token = "0x6002670")]
	[Address(RVA = "0x2A62210", Offset = "0x2A61410", VA = "0x182A62210")]
	public static void Acquire()
	{
	}

	[Token(Token = "0x6002671")]
	[Address(RVA = "0x2A623E0", Offset = "0x2A615E0", VA = "0x182A623E0")]
	public static void Release()
	{
	}
}
