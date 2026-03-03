using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x2000433")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class StyleComplexSelector : ISerializationCallbackReceiver
{
	[Token(Token = "0x2000434")]
	private struct PseudoStateData
	{
		[Token(Token = "0x4000DAF")]
		[FieldOffset(Offset = "0x0")]
		public readonly PseudoStates state;

		[Token(Token = "0x4000DB0")]
		[FieldOffset(Offset = "0x4")]
		public readonly bool negate;

		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x1697E60", Offset = "0x1697060", VA = "0x181697E60")]
		public PseudoStateData(PseudoStates state, bool negate)
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x4000DA5")]
	[FieldOffset(Offset = "0x10")]
	public Hashes ancestorHashes;

	[Token(Token = "0x4000DA6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_Specificity;

	[NonSerialized]
	[Token(Token = "0x4000DA8")]
	[FieldOffset(Offset = "0x30")]
	private bool m_isSimple;

	[Token(Token = "0x4000DA9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private StyleSelector[] m_Selectors;

	[Token(Token = "0x4000DAA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal int ruleIndex;

	[NonSerialized]
	[Token(Token = "0x4000DAB")]
	[FieldOffset(Offset = "0x48")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal StyleComplexSelector nextInTable;

	[NonSerialized]
	[Token(Token = "0x4000DAC")]
	[FieldOffset(Offset = "0x50")]
	internal int orderInStyleSheet;

	[Token(Token = "0x4000DAD")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, PseudoStateData> s_PseudoStates;

	[Token(Token = "0x4000DAE")]
	[FieldOffset(Offset = "0x8")]
	private static List<StyleSelectorPart> m_HashList;

	[Token(Token = "0x17000878")]
	public int specificity
	{
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x158E340", Offset = "0x158D540", VA = "0x18158E340")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000879")]
	public StyleRule rule
	{
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x1700087A")]
	public bool isSimple
	{
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x2805F70", Offset = "0x2805170", VA = "0x182805F70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700087B")]
	public StyleSelector[] selectors
	{
		[Token(Token = "0x6001F69")]
		[Address(RVA = "0x2844C00", Offset = "0x2843E00", VA = "0x182844C00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F6A")]
		[Address(RVA = "0x29F8BC0", Offset = "0x29F7DC0", VA = "0x1829F8BC0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal set
		{
		}
	}

	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6001F6C")]
	[Address(RVA = "0x29F8920", Offset = "0x29F7B20", VA = "0x1829F8920", Slot = "6")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0x29F7C80", Offset = "0x29F6E80", VA = "0x1829F7C80")]
	internal void CachePseudoStateMasks()
	{
	}

	[Token(Token = "0x6001F6E")]
	[Address(RVA = "0x29F89A0", Offset = "0x29F7BA0", VA = "0x1829F89A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001F6F")]
	[Address(RVA = "0x29F8950", Offset = "0x29F7B50", VA = "0x1829F8950")]
	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y)
	{
		return default(int);
	}

	[Token(Token = "0x6001F70")]
	[Address(RVA = "0x29F8350", Offset = "0x29F7550", VA = "0x1829F8350")]
	internal void CalculateHashes()
	{
	}

	[Token(Token = "0x6001F71")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public StyleComplexSelector()
	{
	}
}
