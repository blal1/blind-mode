using Il2CppDummyDll;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002A9")]
internal struct ColorPage
{
	[Token(Token = "0x4000ABC")]
	[FieldOffset(Offset = "0x0")]
	public bool isValid;

	[Token(Token = "0x4000ABD")]
	[FieldOffset(Offset = "0x4")]
	public Color32 pageAndID;

	[Token(Token = "0x6001282")]
	[Address(RVA = "0x2B5AC10", Offset = "0x2B59E10", VA = "0x182B5AC10")]
	public static ColorPage Init(RenderChain renderChain, BMPAlloc alloc)
	{
		return default(ColorPage);
	}

	[Token(Token = "0x6001283")]
	[Address(RVA = "0x2B5ACA0", Offset = "0x2B59EA0", VA = "0x182B5ACA0")]
	public MeshBuilderNative.NativeColorPage ToNativeColorPage()
	{
		return default(MeshBuilderNative.NativeColorPage);
	}
}
