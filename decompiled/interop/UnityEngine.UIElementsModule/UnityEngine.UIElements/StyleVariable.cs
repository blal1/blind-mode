using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000446")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct StyleVariable
{
	[Token(Token = "0x4000E0D")]
	[FieldOffset(Offset = "0x0")]
	public readonly string name;

	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x8")]
	public readonly StyleSheet sheet;

	[Token(Token = "0x4000E0F")]
	[FieldOffset(Offset = "0x10")]
	public readonly StyleValueHandle[] handles;

	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0xC21A70", Offset = "0xC20C70", VA = "0x180C21A70")]
	public StyleVariable(string name, StyleSheet sheet, StyleValueHandle[] handles)
	{
	}

	[Token(Token = "0x6001FBD")]
	[Address(RVA = "0x29FC8C0", Offset = "0x29FBAC0", VA = "0x1829FC8C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
