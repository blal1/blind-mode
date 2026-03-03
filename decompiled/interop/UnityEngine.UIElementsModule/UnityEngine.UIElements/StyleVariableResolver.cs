using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000449")]
internal class StyleVariableResolver
{
	[Token(Token = "0x200044A")]
	private enum Result
	{
		[Token(Token = "0x4000E20")]
		Valid,
		[Token(Token = "0x4000E21")]
		Invalid,
		[Token(Token = "0x4000E22")]
		NotFound
	}

	[Token(Token = "0x200044B")]
	private struct ResolveContext
	{
		[Token(Token = "0x4000E23")]
		[FieldOffset(Offset = "0x0")]
		public StyleSheet sheet;

		[Token(Token = "0x4000E24")]
		[FieldOffset(Offset = "0x8")]
		public StyleValueHandle[] handles;
	}

	[Token(Token = "0x4000E16")]
	internal const int kMaxResolves = 100;

	[Token(Token = "0x4000E17")]
	[FieldOffset(Offset = "0x0")]
	private static StyleSyntaxParser s_SyntaxParser;

	[Token(Token = "0x4000E18")]
	[FieldOffset(Offset = "0x10")]
	private StylePropertyValueMatcher m_Matcher;

	[Token(Token = "0x4000E19")]
	[FieldOffset(Offset = "0x18")]
	private List<StylePropertyValue> m_ResolvedValues;

	[Token(Token = "0x4000E1A")]
	[FieldOffset(Offset = "0x20")]
	private Stack<string> m_ResolvedVarStack;

	[Token(Token = "0x4000E1B")]
	[FieldOffset(Offset = "0x28")]
	private StyleProperty m_Property;

	[Token(Token = "0x4000E1C")]
	[FieldOffset(Offset = "0x30")]
	private Stack<ResolveContext> m_ContextStack;

	[Token(Token = "0x4000E1D")]
	[FieldOffset(Offset = "0x38")]
	private ResolveContext m_CurrentContext;

	[Token(Token = "0x1700088B")]
	private StyleSheet currentSheet
	{
		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088C")]
	private StyleValueHandle[] currentHandles
	{
		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088D")]
	public List<StylePropertyValue> resolvedValues
	{
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700088E")]
	public StyleVariableContext variableContext
	{
		[Token(Token = "0x6001FCA")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001FCB")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6001FCC")]
	[Address(RVA = "0x29FB830", Offset = "0x29FAA30", VA = "0x1829FB830")]
	public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles)
	{
	}

	[Token(Token = "0x6001FCD")]
	[Address(RVA = "0x29FBAE0", Offset = "0x29FACE0", VA = "0x1829FBAE0")]
	private void PushContext(StyleSheet sheet, StyleValueHandle[] handles)
	{
	}

	[Token(Token = "0x6001FCE")]
	[Address(RVA = "0x29FBA50", Offset = "0x29FAC50", VA = "0x1829FBA50")]
	private void PopContext()
	{
	}

	[Token(Token = "0x6001FCF")]
	[Address(RVA = "0x29FB710", Offset = "0x29FA910", VA = "0x1829FB710")]
	public void AddValue(StyleValueHandle handle)
	{
	}

	[Token(Token = "0x6001FD0")]
	[Address(RVA = "0x29FBF30", Offset = "0x29FB130", VA = "0x1829FBF30")]
	public bool ResolveVarFunction(ref int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FD1")]
	[Address(RVA = "0x29FBDF0", Offset = "0x29FAFF0", VA = "0x1829FBDF0")]
	private Result ResolveVarFunction(ref int index, int argc, string varName)
	{
		return default(Result);
	}

	[Token(Token = "0x6001FD2")]
	[Address(RVA = "0x29FC580", Offset = "0x29FB780", VA = "0x1829FC580")]
	public bool ValidateResolvedValues()
	{
		return default(bool);
	}

	[Token(Token = "0x6001FD3")]
	[Address(RVA = "0x29FC200", Offset = "0x29FB400", VA = "0x1829FC200")]
	private Result ResolveVariable(string variableName)
	{
		return default(Result);
	}

	[Token(Token = "0x6001FD4")]
	[Address(RVA = "0x29FBB90", Offset = "0x29FAD90", VA = "0x1829FBB90")]
	private Result ResolveFallback(ref int index, bool appendValues)
	{
		return default(Result);
	}

	[Token(Token = "0x6001FD5")]
	[Address(RVA = "0x29FB900", Offset = "0x29FAB00", VA = "0x1829FB900")]
	private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName)
	{
	}

	[Token(Token = "0x6001FD6")]
	[Address(RVA = "0x29FC780", Offset = "0x29FB980", VA = "0x1829FC780")]
	public StyleVariableResolver()
	{
	}
}
