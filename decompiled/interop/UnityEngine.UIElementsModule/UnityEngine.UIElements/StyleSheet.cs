using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x200043D")]
[HelpURL("UIE-USS")]
public class StyleSheet : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200043E")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct ImportStruct
	{
		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x0")]
		public StyleSheet styleSheet;

		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x8")]
		public string[] mediaQueries;
	}

	[Token(Token = "0x200043F")]
	internal enum OrderedSelectorType
	{
		[Token(Token = "0x4000DE8")]
		None = -1,
		[Token(Token = "0x4000DE9")]
		Name,
		[Token(Token = "0x4000DEA")]
		Type,
		[Token(Token = "0x4000DEB")]
		Class,
		[Token(Token = "0x4000DEC")]
		Length
	}

	[Token(Token = "0x4000DD2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool m_ImportedWithErrors;

	[Token(Token = "0x4000DD3")]
	[FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool m_ImportedWithWarnings;

	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private StyleRule[] m_Rules;

	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private StyleComplexSelector[] m_ComplexSelectors;

	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal float[] floats;

	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Dimension[] dimensions;

	[Token(Token = "0x4000DD8")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Color[] colors;

	[Token(Token = "0x4000DD9")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal string[] strings;

	[Token(Token = "0x4000DDA")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Object[] assets;

	[Token(Token = "0x4000DDB")]
	[FieldOffset(Offset = "0x58")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	[SerializeField]
	internal ImportStruct[] imports;

	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<StyleSheet> m_FlattenedImportedStyleSheets;

	[Token(Token = "0x4000DDD")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private int m_ContentHash;

	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	internal ScalableImage[] scalableImages;

	[NonSerialized]
	[Token(Token = "0x4000DDF")]
	[FieldOffset(Offset = "0x78")]
	internal Dictionary<string, StyleComplexSelector>[] tables;

	[NonSerialized]
	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x80")]
	internal int nonEmptyTablesMask;

	[NonSerialized]
	[Token(Token = "0x4000DE1")]
	[FieldOffset(Offset = "0x88")]
	internal StyleComplexSelector firstRootSelector;

	[NonSerialized]
	[Token(Token = "0x4000DE2")]
	[FieldOffset(Offset = "0x90")]
	internal StyleComplexSelector firstWildCardSelector;

	[NonSerialized]
	[Token(Token = "0x4000DE3")]
	[FieldOffset(Offset = "0x98")]
	private bool m_IsDefaultStyleSheet;

	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x0")]
	private static string kCustomPropertyMarker;

	[Token(Token = "0x17000883")]
	public bool importedWithErrors
	{
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0x277C150", Offset = "0x277B350", VA = "0x18277C150")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000884")]
	public bool importedWithWarnings
	{
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x29FA960", Offset = "0x29F9B60", VA = "0x1829FA960")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F90")]
		[Address(RVA = "0xAA0C10", Offset = "0xA9FE10", VA = "0x180AA0C10")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000885")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal StyleRule[] rules
	{
		[Token(Token = "0x6001F91")]
		[Address(RVA = "0x276ACD0", Offset = "0x2769ED0", VA = "0x18276ACD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F92")]
		[Address(RVA = "0x29FAAC0", Offset = "0x29F9CC0", VA = "0x1829FAAC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000886")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal StyleComplexSelector[] complexSelectors
	{
		[Token(Token = "0x6001F93")]
		[Address(RVA = "0x276AD30", Offset = "0x2769F30", VA = "0x18276AD30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001F94")]
		[Address(RVA = "0x29FA980", Offset = "0x29F9B80", VA = "0x1829FA980")]
		set
		{
		}
	}

	[Token(Token = "0x17000887")]
	internal List<StyleSheet> flattenedRecursiveImports
	{
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x287DBB0", Offset = "0x287CDB0", VA = "0x18287DBB0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000888")]
	public int contentHash
	{
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x2855EA0", Offset = "0x28550A0", VA = "0x182855EA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F97")]
		[Address(RVA = "0xB2E810", Offset = "0xB2DA10", VA = "0x180B2E810")]
		set
		{
		}
	}

	[Token(Token = "0x17000889")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool isDefaultStyleSheet
	{
		[Token(Token = "0x6001F98")]
		[Address(RVA = "0x29FA970", Offset = "0x29F9B70", VA = "0x1829FA970")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001F99")]
		[Address(RVA = "0x29FA9B0", Offset = "0x29F9BB0", VA = "0x1829FA9B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001F9A")]
	private bool TryCheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle, out T value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F9B")]
	private T CheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle)
	{
		return (T)null;
	}

	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0x29F9550", Offset = "0x29F8750", VA = "0x1829F9550", Slot = "4")]
	internal virtual void OnEnable()
	{
	}

	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0x29F94D0", Offset = "0x29F86D0", VA = "0x1829F94D0")]
	internal void FlattenImportedStyleSheetsRecursive()
	{
	}

	[Token(Token = "0x6001F9E")]
	[Address(RVA = "0x29F93A0", Offset = "0x29F85A0", VA = "0x1829F93A0")]
	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet)
	{
	}

	[Token(Token = "0x6001F9F")]
	[Address(RVA = "0x29F9C70", Offset = "0x29F8E70", VA = "0x1829F9C70")]
	private void SetupReferences()
	{
	}

	[Token(Token = "0x6001FA0")]
	[Address(RVA = "0x29F9A60", Offset = "0x29F8C60", VA = "0x1829F9A60")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle)
	{
		return default(StyleValueKeyword);
	}

	[Token(Token = "0x6001FA1")]
	[Address(RVA = "0x29F9750", Offset = "0x29F8950", VA = "0x1829F9750")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal float ReadFloat(StyleValueHandle handle)
	{
		return default(float);
	}

	[Token(Token = "0x6001FA2")]
	[Address(RVA = "0x29FA6D0", Offset = "0x29F98D0", VA = "0x1829FA6D0")]
	internal bool TryReadFloat(StyleValueHandle handle, out float value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FA3")]
	[Address(RVA = "0x29F9640", Offset = "0x29F8840", VA = "0x1829F9640")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Dimension ReadDimension(StyleValueHandle handle)
	{
		return default(Dimension);
	}

	[Token(Token = "0x6001FA4")]
	[Address(RVA = "0x29FA570", Offset = "0x29F9770", VA = "0x1829FA570")]
	internal bool TryReadDimension(StyleValueHandle handle, out Dimension value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FA5")]
	[Address(RVA = "0x29F95C0", Offset = "0x29F87C0", VA = "0x1829F95C0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Color ReadColor(StyleValueHandle handle)
	{
		return default(Color);
	}

	[Token(Token = "0x6001FA6")]
	[Address(RVA = "0x29FA500", Offset = "0x29F9700", VA = "0x1829FA500")]
	internal bool TryReadColor(StyleValueHandle handle, out Color value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FA7")]
	[Address(RVA = "0x29F9BB0", Offset = "0x29F8DB0", VA = "0x1829F9BB0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal string ReadString(StyleValueHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6001FA8")]
	[Address(RVA = "0x29FA810", Offset = "0x29F9A10", VA = "0x1829FA810")]
	internal bool TryReadString(StyleValueHandle handle, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FA9")]
	[Address(RVA = "0x29F96F0", Offset = "0x29F88F0", VA = "0x1829F96F0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal string ReadEnum(StyleValueHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6001FAA")]
	[Address(RVA = "0x29FA660", Offset = "0x29F9860", VA = "0x1829FA660")]
	internal bool TryReadEnum(StyleValueHandle handle, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FAB")]
	[Address(RVA = "0x29F9C10", Offset = "0x29F8E10", VA = "0x1829F9C10")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal string ReadVariable(StyleValueHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6001FAC")]
	[Address(RVA = "0x29FA880", Offset = "0x29F9A80", VA = "0x1829FA880")]
	internal bool TryReadVariable(StyleValueHandle handle, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FAD")]
	[Address(RVA = "0x29F9AD0", Offset = "0x29F8CD0", VA = "0x1829F9AD0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal string ReadResourcePath(StyleValueHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6001FAE")]
	[Address(RVA = "0x29FA7A0", Offset = "0x29F99A0", VA = "0x1829FA7A0")]
	internal bool TryReadResourcePath(StyleValueHandle handle, out string value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0x29F9560", Offset = "0x29F8760", VA = "0x1829F9560")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal Object ReadAssetReference(StyleValueHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6001FB0")]
	[Address(RVA = "0x29F9A70", Offset = "0x29F8C70", VA = "0x1829F9A70")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0x29FA490", Offset = "0x29F9690", VA = "0x1829FA490")]
	internal bool TryReadAssetReference(StyleValueHandle handle, out Object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0x29F9A60", Offset = "0x29F8C60", VA = "0x1829F9A60")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal StyleValueFunction ReadFunction(StyleValueHandle handle)
	{
		return default(StyleValueFunction);
	}

	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x29F97F0", Offset = "0x29F89F0", VA = "0x1829F97F0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal string ReadFunctionName(StyleValueHandle handle)
	{
		return null;
	}

	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x29F9B30", Offset = "0x29F8D30", VA = "0x1829F9B30")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal ScalableImage ReadScalableImage(StyleValueHandle handle)
	{
		return default(ScalableImage);
	}

	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0x29F92D0", Offset = "0x29F84D0", VA = "0x1829F92D0")]
	private static bool CustomStartsWith(string originalString, string pattern)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FB6")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public StyleSheet()
	{
	}
}
