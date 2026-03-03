using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005C6")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct ImageSource
{
	[Token(Token = "0x4001554")]
	[FieldOffset(Offset = "0x0")]
	public Texture2D texture;

	[Token(Token = "0x4001555")]
	[FieldOffset(Offset = "0x8")]
	public Sprite sprite;

	[Token(Token = "0x4001556")]
	[FieldOffset(Offset = "0x10")]
	public VectorImage vectorImage;

	[Token(Token = "0x4001557")]
	[FieldOffset(Offset = "0x18")]
	public RenderTexture renderTexture;

	[Token(Token = "0x6002846")]
	[Address(RVA = "0x2A82E30", Offset = "0x2A82030", VA = "0x182A82E30")]
	public bool IsNull()
	{
		return default(bool);
	}
}
