using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005C7")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class StylePropertyReader
{
	[Token(Token = "0x20005C8")]
	internal delegate int GetCursorIdFunction(StyleSheet sheet, StyleValueHandle handle);

	[Token(Token = "0x4001558")]
	[FieldOffset(Offset = "0x0")]
	internal static GetCursorIdFunction getCursorIdFunc;

	[Token(Token = "0x4001559")]
	[FieldOffset(Offset = "0x10")]
	private List<StylePropertyValue> m_Values;

	[Token(Token = "0x400155A")]
	[FieldOffset(Offset = "0x18")]
	private List<int> m_ValueCount;

	[Token(Token = "0x400155B")]
	[FieldOffset(Offset = "0x20")]
	private StyleVariableResolver m_Resolver;

	[Token(Token = "0x400155C")]
	[FieldOffset(Offset = "0x28")]
	private StyleSheet m_Sheet;

	[Token(Token = "0x400155D")]
	[FieldOffset(Offset = "0x30")]
	private StyleProperty[] m_Properties;

	[Token(Token = "0x400155E")]
	[FieldOffset(Offset = "0x38")]
	private StylePropertyId[] m_PropertyIds;

	[Token(Token = "0x400155F")]
	[FieldOffset(Offset = "0x40")]
	private int m_CurrentValueIndex;

	[Token(Token = "0x4001560")]
	[FieldOffset(Offset = "0x44")]
	private int m_CurrentPropertyIndex;

	[Token(Token = "0x17000A79")]
	public StyleProperty property
	{
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002848")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000A7A")]
	public StylePropertyId propertyId
	{
		[Token(Token = "0x6002849")]
		[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
		[CompilerGenerated]
		get
		{
			return default(StylePropertyId);
		}
		[Token(Token = "0x600284A")]
		[Address(RVA = "0x49C4A0", Offset = "0x49B6A0", VA = "0x18049C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000A7B")]
	public int valueCount
	{
		[Token(Token = "0x600284B")]
		[Address(RVA = "0x49BDA0", Offset = "0x49AFA0", VA = "0x18049BDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600284C")]
		[Address(RVA = "0x49C4B0", Offset = "0x49B6B0", VA = "0x18049C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000A7C")]
	public float dpiScaling
	{
		[Token(Token = "0x600284D")]
		[Address(RVA = "0x7DBBC0", Offset = "0x7DADC0", VA = "0x1807DBBC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600284E")]
		[Address(RVA = "0x7DBBE0", Offset = "0x7DADE0", VA = "0x1807DBBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600284F")]
	[Address(RVA = "0x2A883B0", Offset = "0x2A875B0", VA = "0x182A883B0")]
	public void SetContext(StyleSheet sheet, StyleComplexSelector selector, StyleVariableContext varContext, float dpiScaling = 1f)
	{
	}

	[Token(Token = "0x6002850")]
	[Address(RVA = "0x2A88580", Offset = "0x2A87780", VA = "0x182A88580")]
	public void SetInlineContext(StyleSheet sheet, StyleProperty[] properties, StylePropertyId[] propertyIds, float dpiScaling = 1f)
	{
	}

	[Token(Token = "0x6002851")]
	[Address(RVA = "0x2A849F0", Offset = "0x2A83BF0", VA = "0x182A849F0")]
	public StylePropertyId MoveNextProperty()
	{
		return default(StylePropertyId);
	}

	[Token(Token = "0x6002852")]
	[Address(RVA = "0x2A84410", Offset = "0x2A83610", VA = "0x182A84410")]
	public StylePropertyValue GetValue(int index)
	{
		return default(StylePropertyValue);
	}

	[Token(Token = "0x6002853")]
	[Address(RVA = "0x2A84390", Offset = "0x2A83590", VA = "0x182A84390")]
	public StyleValueType GetValueType(int index)
	{
		return default(StyleValueType);
	}

	[Token(Token = "0x6002854")]
	[Address(RVA = "0x2A84530", Offset = "0x2A83730", VA = "0x182A84530")]
	public bool IsValueType(int index, StyleValueType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6002855")]
	[Address(RVA = "0x2A84490", Offset = "0x2A83690", VA = "0x182A84490")]
	public bool IsKeyword(int index, StyleValueKeyword keyword)
	{
		return default(bool);
	}

	[Token(Token = "0x6002856")]
	[Address(RVA = "0x2A84B20", Offset = "0x2A83D20", VA = "0x182A84B20")]
	public string ReadAsString(int index)
	{
		return null;
	}

	[Token(Token = "0x6002857")]
	[Address(RVA = "0x2A86820", Offset = "0x2A85A20", VA = "0x182A86820")]
	public Length ReadLength(int index)
	{
		return default(Length);
	}

	[Token(Token = "0x6002858")]
	[Address(RVA = "0x2A87980", Offset = "0x2A86B80", VA = "0x182A87980")]
	public TimeValue ReadTimeValue(int index)
	{
		return default(TimeValue);
	}

	[Token(Token = "0x6002859")]
	[Address(RVA = "0x2A87F80", Offset = "0x2A87180", VA = "0x182A87F80")]
	public Translate ReadTranslate(int index)
	{
		return default(Translate);
	}

	[Token(Token = "0x600285A")]
	[Address(RVA = "0x2A87B80", Offset = "0x2A86D80", VA = "0x182A87B80")]
	public TransformOrigin ReadTransformOrigin(int index)
	{
		return default(TransformOrigin);
	}

	[Token(Token = "0x600285B")]
	[Address(RVA = "0x2A870C0", Offset = "0x2A862C0", VA = "0x182A870C0")]
	public Rotate ReadRotate(int index)
	{
		return default(Rotate);
	}

	[Token(Token = "0x600285C")]
	[Address(RVA = "0x2A87490", Offset = "0x2A86690", VA = "0x182A87490")]
	public Scale ReadScale(int index)
	{
		return default(Scale);
	}

	[Token(Token = "0x600285D")]
	[Address(RVA = "0x2A85F20", Offset = "0x2A85120", VA = "0x182A85F20")]
	public float ReadFloat(int index)
	{
		return default(float);
	}

	[Token(Token = "0x600285E")]
	[Address(RVA = "0x2A867A0", Offset = "0x2A859A0", VA = "0x182A867A0")]
	public int ReadInt(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600285F")]
	[Address(RVA = "0x2A85880", Offset = "0x2A84A80", VA = "0x182A85880")]
	public Color ReadColor(int index)
	{
		return default(Color);
	}

	[Token(Token = "0x6002860")]
	[Address(RVA = "0x2A85E20", Offset = "0x2A85020", VA = "0x182A85E20")]
	public int ReadEnum(StyleEnumType enumType, int index)
	{
		return default(int);
	}

	[Token(Token = "0x6002861")]
	[Address(RVA = "0x2A85FA0", Offset = "0x2A851A0", VA = "0x182A85FA0")]
	public FontDefinition ReadFontDefinition(int index)
	{
		return default(FontDefinition);
	}

	[Token(Token = "0x6002862")]
	[Address(RVA = "0x2A864B0", Offset = "0x2A856B0", VA = "0x182A864B0")]
	public Font ReadFont(int index)
	{
		return null;
	}

	[Token(Token = "0x6002863")]
	[Address(RVA = "0x2A85610", Offset = "0x2A84810", VA = "0x182A85610")]
	public Background ReadBackground(int index)
	{
		return default(Background);
	}

	[Token(Token = "0x6002864")]
	[Address(RVA = "0x2A859A0", Offset = "0x2A84BA0", VA = "0x182A859A0")]
	public Cursor ReadCursor(int index)
	{
		return default(Cursor);
	}

	[Token(Token = "0x6002865")]
	[Address(RVA = "0x2A875E0", Offset = "0x2A867E0", VA = "0x182A875E0")]
	public TextShadow ReadTextShadow(int index)
	{
		return default(TextShadow);
	}

	[Token(Token = "0x6002866")]
	[Address(RVA = "0x2A84B90", Offset = "0x2A83D90", VA = "0x182A84B90")]
	public BackgroundPosition ReadBackgroundPositionX(int index)
	{
		return default(BackgroundPosition);
	}

	[Token(Token = "0x6002867")]
	[Address(RVA = "0x2A84BD0", Offset = "0x2A83DD0", VA = "0x182A84BD0")]
	public BackgroundPosition ReadBackgroundPositionY(int index)
	{
		return default(BackgroundPosition);
	}

	[Token(Token = "0x6002868")]
	[Address(RVA = "0x2A84C10", Offset = "0x2A83E10", VA = "0x182A84C10")]
	private BackgroundPosition ReadBackgroundPosition(int index, BackgroundPositionKeyword keyword)
	{
		return default(BackgroundPosition);
	}

	[Token(Token = "0x6002869")]
	[Address(RVA = "0x2A84F10", Offset = "0x2A84110", VA = "0x182A84F10")]
	public BackgroundRepeat ReadBackgroundRepeat(int index)
	{
		return default(BackgroundRepeat);
	}

	[Token(Token = "0x600286A")]
	[Address(RVA = "0x2A852A0", Offset = "0x2A844A0", VA = "0x182A852A0")]
	public BackgroundSize ReadBackgroundSize(int index)
	{
		return default(BackgroundSize);
	}

	[Token(Token = "0x600286B")]
	[Address(RVA = "0x2A86920", Offset = "0x2A85B20", VA = "0x182A86920")]
	public void ReadListEasingFunction(List<EasingFunction> list, int index)
	{
	}

	[Token(Token = "0x600286C")]
	[Address(RVA = "0x2A86D00", Offset = "0x2A85F00", VA = "0x182A86D00")]
	public void ReadListTimeValue(List<TimeValue> list, int index)
	{
	}

	[Token(Token = "0x600286D")]
	[Address(RVA = "0x2A86B20", Offset = "0x2A85D20", VA = "0x182A86B20")]
	public void ReadListStylePropertyName(List<StylePropertyName> list, int index)
	{
	}

	[Token(Token = "0x600286E")]
	[Address(RVA = "0x2A845C0", Offset = "0x2A837C0", VA = "0x182A845C0")]
	private void LoadProperties()
	{
	}

	[Token(Token = "0x600286F")]
	[Address(RVA = "0x2A884B0", Offset = "0x2A876B0", VA = "0x182A884B0")]
	private void SetCurrentProperty()
	{
	}

	[Token(Token = "0x6002870")]
	[Address(RVA = "0x2A87CE0", Offset = "0x2A86EE0", VA = "0x182A87CE0")]
	public static TransformOrigin ReadTransformOrigin(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue zVvalue)
	{
		return default(TransformOrigin);
	}

	[Token(Token = "0x6002871")]
	[Address(RVA = "0x2A87A30", Offset = "0x2A86C30", VA = "0x182A87A30")]
	private static Length ReadTransformOriginEnum(StylePropertyValue value, out bool isVertical, out bool isHorizontal)
	{
		return default(Length);
	}

	[Token(Token = "0x6002872")]
	[Address(RVA = "0x2A880E0", Offset = "0x2A872E0", VA = "0x182A880E0")]
	public static Translate ReadTranslate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3)
	{
		return default(Translate);
	}

	[Token(Token = "0x6002873")]
	[Address(RVA = "0x2A87280", Offset = "0x2A86480", VA = "0x182A87280")]
	public static Scale ReadScale(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3)
	{
		return default(Scale);
	}

	[Token(Token = "0x6002874")]
	[Address(RVA = "0x2A86EB0", Offset = "0x2A860B0", VA = "0x182A86EB0")]
	public static Rotate ReadRotate(int valCount, StylePropertyValue val1, StylePropertyValue val2, StylePropertyValue val3, StylePropertyValue val4)
	{
		return default(Rotate);
	}

	[Token(Token = "0x6002875")]
	[Address(RVA = "0x2A88D50", Offset = "0x2A87F50", VA = "0x182A88D50")]
	private static bool TryReadEnum(StyleEnumType enumType, StylePropertyValue value, out int intValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6002876")]
	[Address(RVA = "0x2A85D50", Offset = "0x2A84F50", VA = "0x182A85D50")]
	private static int ReadEnum(StyleEnumType enumType, StylePropertyValue value)
	{
		return default(int);
	}

	[Token(Token = "0x6002877")]
	[Address(RVA = "0x2A84A20", Offset = "0x2A83C20", VA = "0x182A84A20")]
	public static Angle ReadAngle(StylePropertyValue value)
	{
		return default(Angle);
	}

	[Token(Token = "0x6002878")]
	[Address(RVA = "0x2A84D20", Offset = "0x2A83F20", VA = "0x182A84D20")]
	public static BackgroundPosition ReadBackgroundPosition(int valCount, StylePropertyValue val1, StylePropertyValue val2, BackgroundPositionKeyword keyword)
	{
		return default(BackgroundPosition);
	}

	[Token(Token = "0x6002879")]
	[Address(RVA = "0x2A85100", Offset = "0x2A84300", VA = "0x182A85100")]
	public static BackgroundRepeat ReadBackgroundRepeat(int valCount, StylePropertyValue val1, StylePropertyValue val2)
	{
		return default(BackgroundRepeat);
	}

	[Token(Token = "0x600287A")]
	[Address(RVA = "0x2A85390", Offset = "0x2A84590", VA = "0x182A85390")]
	public static BackgroundSize ReadBackgroundSize(int valCount, StylePropertyValue val1, StylePropertyValue val2)
	{
		return default(BackgroundSize);
	}

	[Token(Token = "0x600287B")]
	[Address(RVA = "0x2A885F0", Offset = "0x2A877F0", VA = "0x182A885F0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal static bool TryGetImageSourceFromValue(StylePropertyValue propertyValue, float dpiScaling, out ImageSource source)
	{
		return default(bool);
	}

	[Token(Token = "0x600287C")]
	[Address(RVA = "0x2A88E20", Offset = "0x2A88020", VA = "0x182A88E20")]
	public StylePropertyReader()
	{
	}
}
