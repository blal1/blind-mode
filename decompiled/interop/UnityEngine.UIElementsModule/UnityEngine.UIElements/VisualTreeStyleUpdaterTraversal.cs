using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000502")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
{
	[Token(Token = "0x4001074")]
	[FieldOffset(Offset = "0x10")]
	private StyleVariableContext m_ProcessVarContext;

	[Token(Token = "0x4001075")]
	[FieldOffset(Offset = "0x18")]
	private HashSet<VisualElement> m_UpdateList;

	[Token(Token = "0x4001076")]
	[FieldOffset(Offset = "0x20")]
	private HashSet<VisualElement> m_ParentList;

	[Token(Token = "0x4001077")]
	[FieldOffset(Offset = "0x28")]
	private List<SelectorMatchRecord> m_TempMatchResults;

	[Token(Token = "0x4001079")]
	[FieldOffset(Offset = "0x38")]
	private StyleMatchingContext m_StyleMatchingContext;

	[Token(Token = "0x400107A")]
	[FieldOffset(Offset = "0x40")]
	private StylePropertyReader m_StylePropertyReader;

	[Token(Token = "0x400107C")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<StylePropertyId> m_AnimatedProperties;

	[Token(Token = "0x17000967")]
	private float currentPixelsPerPoint
	{
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x649990", Offset = "0x648B90", VA = "0x180649990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x562E70", Offset = "0x562070", VA = "0x180562E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000968")]
	private BaseVisualElementPanel currentPanel
	{
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x6002402")]
	[Address(RVA = "0x2A40040", Offset = "0x2A3F240", VA = "0x182A40040")]
	public void PrepareTraversal(BaseVisualElementPanel panel, float pixelsPerPoint)
	{
	}

	[Token(Token = "0x6002403")]
	[Address(RVA = "0x2A3FA30", Offset = "0x2A3EC30", VA = "0x182A3FA30")]
	public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType)
	{
	}

	[Token(Token = "0x6002404")]
	[Address(RVA = "0x2A3FD20", Offset = "0x2A3EF20", VA = "0x182A3FD20")]
	public void Clear()
	{
	}

	[Token(Token = "0x6002405")]
	[Address(RVA = "0x2A40DC0", Offset = "0x2A3FFC0", VA = "0x182A40DC0")]
	private void PropagateToChildren(VisualElement ve)
	{
	}

	[Token(Token = "0x6002406")]
	[Address(RVA = "0x2A40EA0", Offset = "0x2A400A0", VA = "0x182A40EA0")]
	private void PropagateToParents(VisualElement ve)
	{
	}

	[Token(Token = "0x6002407")]
	[Address(RVA = "0x2A40000", Offset = "0x2A3F200", VA = "0x182A40000")]
	private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info)
	{
	}

	[Token(Token = "0x6002408")]
	[Address(RVA = "0x2A40FD0", Offset = "0x2A401D0", VA = "0x182A40FD0", Slot = "5")]
	public override void TraverseRecursive(VisualElement element, int depth)
	{
	}

	[Token(Token = "0x6002409")]
	[Address(RVA = "0x2A40C90", Offset = "0x2A3FE90", VA = "0x182A40C90")]
	private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle)
	{
	}

	[Token(Token = "0x600240A")]
	[Address(RVA = "0x2A3FDC0", Offset = "0x2A3EFC0", VA = "0x182A3FDC0")]
	private void ForceUpdateTransitions(VisualElement element)
	{
	}

	[Token(Token = "0x600240B")]
	[Address(RVA = "0x2A3FB40", Offset = "0x2A3ED40", VA = "0x182A3FB40")]
	internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle)
	{
	}

	[Token(Token = "0x600240C")]
	[Address(RVA = "0x2A40F50", Offset = "0x2A40150", VA = "0x182A40F50")]
	protected bool ShouldSkipElement(VisualElement element)
	{
		return default(bool);
	}

	[Token(Token = "0x600240D")]
	[Address(RVA = "0x2A40070", Offset = "0x2A3F270", VA = "0x182A40070")]
	private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors)
	{
		return default(ComputedStyle);
	}

	[Token(Token = "0x600240E")]
	[Address(RVA = "0x2A40B70", Offset = "0x2A3FD70", VA = "0x182A40B70")]
	private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule)
	{
	}

	[Token(Token = "0x600240F")]
	[Address(RVA = "0x2A41860", Offset = "0x2A40A60", VA = "0x182A41860")]
	public VisualTreeStyleUpdaterTraversal()
	{
	}
}
