using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000447")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class StyleVariableContext
{
	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0x0")]
	public static readonly StyleVariableContext none;

	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0x10")]
	private int m_VariableHash;

	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0x18")]
	private List<StyleVariable> m_Variables;

	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x20")]
	private List<int> m_SortedHash;

	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0x28")]
	private List<int> m_UnsortedHash;

	[Token(Token = "0x6001FBE")]
	[Address(RVA = "0x29FAEF0", Offset = "0x29FA0F0", VA = "0x1829FAEF0")]
	public void Add(StyleVariable sv)
	{
	}

	[Token(Token = "0x6001FBF")]
	[Address(RVA = "0x29FADE0", Offset = "0x29F9FE0", VA = "0x1829FADE0")]
	public void AddInitialRange(StyleVariableContext other)
	{
	}

	[Token(Token = "0x6001FC0")]
	[Address(RVA = "0x29FB1D0", Offset = "0x29FA3D0", VA = "0x1829FB1D0")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001FC1")]
	[Address(RVA = "0x29FB610", Offset = "0x29FA810", VA = "0x1829FB610")]
	public StyleVariableContext()
	{
	}

	[Token(Token = "0x6001FC2")]
	[Address(RVA = "0x29FB4E0", Offset = "0x29FA6E0", VA = "0x1829FB4E0")]
	public StyleVariableContext(StyleVariableContext other)
	{
	}

	[Token(Token = "0x6001FC3")]
	[Address(RVA = "0x29FB280", Offset = "0x29FA480", VA = "0x1829FB280")]
	public bool TryFindVariable(string name, out StyleVariable v)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FC4")]
	[Address(RVA = "0x27BFAA0", Offset = "0x27BECA0", VA = "0x1827BFAA0")]
	public int GetVariableHash()
	{
		return default(int);
	}
}
