using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Serializable]
[Token(Token = "0x20005C4")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct ScalableImage
{
	[Token(Token = "0x4001550")]
	[FieldOffset(Offset = "0x0")]
	public Texture2D normalImage;

	[Token(Token = "0x4001551")]
	[FieldOffset(Offset = "0x8")]
	public Texture2D highResolutionImage;

	[Token(Token = "0x6002845")]
	[Address(RVA = "0x2A83FA0", Offset = "0x2A831A0", VA = "0x182A83FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
