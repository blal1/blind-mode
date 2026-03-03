using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000481")]
public struct UQueryBuilder<T> : IEquatable<UQueryBuilder<T>> where T : VisualElement
{
	[Token(Token = "0x4000F12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<StyleSelector> m_StyleSelectors;

	[Token(Token = "0x4000F13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<StyleSelectorPart> m_Parts;

	[Token(Token = "0x4000F14")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private VisualElement m_Element;

	[Token(Token = "0x4000F15")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private List<RuleMatcher> m_Matchers;

	[Token(Token = "0x4000F16")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private StyleSelectorRelationship m_Relationship;

	[Token(Token = "0x4000F17")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int pseudoStatesMask;

	[Token(Token = "0x4000F18")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private int negatedPseudoStatesMask;

	[Token(Token = "0x1700090D")]
	private List<StyleSelector> styleSelectors
	{
		[Token(Token = "0x6002203")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700090E")]
	private List<StyleSelectorPart> parts
	{
		[Token(Token = "0x6002204")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002205")]
	public UQueryBuilder(VisualElement visualElement)
	{
	}

	[Token(Token = "0x6002206")]
	public UQueryBuilder<T> Class(string classname)
	{
		return default(UQueryBuilder<T>);
	}

	[Token(Token = "0x6002207")]
	public UQueryBuilder<T> Name(string id)
	{
		return default(UQueryBuilder<T>);
	}

	[Token(Token = "0x6002208")]
	public UQueryBuilder<T2> OfType<T2>([Optional] string name, params string[] classes) where T2 : VisualElement
	{
		return default(UQueryBuilder<T2>);
	}

	[Token(Token = "0x6002209")]
	public UQueryBuilder<T2> OfType<T2>([Optional] string name, [Optional] string className) where T2 : VisualElement
	{
		return default(UQueryBuilder<T2>);
	}

	[Token(Token = "0x600220A")]
	internal UQueryBuilder<T> SingleBaseType()
	{
		return default(UQueryBuilder<T>);
	}

	[Token(Token = "0x600220B")]
	private void AddClass(string c)
	{
	}

	[Token(Token = "0x600220C")]
	private void AddClasses(params string[] classes)
	{
	}

	[Token(Token = "0x600220D")]
	private void AddName(string id)
	{
	}

	[Token(Token = "0x600220E")]
	private void AddType<T2>() where T2 : VisualElement
	{
	}

	[Token(Token = "0x600220F")]
	private UQueryBuilder<T2> AddRelationship<T2>(StyleSelectorRelationship relationship) where T2 : VisualElement
	{
		return default(UQueryBuilder<T2>);
	}

	[Token(Token = "0x6002210")]
	private void AddPseudoStatesRuleIfNecessasy()
	{
	}

	[Token(Token = "0x6002211")]
	private void FinishSelector()
	{
	}

	[Token(Token = "0x6002212")]
	private bool CurrentSelectorEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6002213")]
	private void FinishCurrentSelector()
	{
	}

	[Token(Token = "0x6002214")]
	public UQueryState<T> Build()
	{
		return default(UQueryState<T>);
	}

	[Token(Token = "0x6002215")]
	public List<T> ToList()
	{
		return null;
	}

	[Token(Token = "0x6002216")]
	public void ForEach(Action<T> funcCall)
	{
	}

	[Token(Token = "0x6002217")]
	public bool Equals(UQueryBuilder<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002218")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6002219")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
