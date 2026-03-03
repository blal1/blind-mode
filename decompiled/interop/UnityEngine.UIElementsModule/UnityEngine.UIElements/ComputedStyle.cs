using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002CC")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct ComputedStyle
{
	[Token(Token = "0x4000B32")]
	[FieldOffset(Offset = "0x0")]
	public StyleDataRef<InheritedData> inheritedData;

	[Token(Token = "0x4000B33")]
	[FieldOffset(Offset = "0x8")]
	public StyleDataRef<LayoutData> layoutData;

	[Token(Token = "0x4000B34")]
	[FieldOffset(Offset = "0x10")]
	public StyleDataRef<RareData> rareData;

	[Token(Token = "0x4000B35")]
	[FieldOffset(Offset = "0x18")]
	public StyleDataRef<TransformData> transformData;

	[Token(Token = "0x4000B36")]
	[FieldOffset(Offset = "0x20")]
	public StyleDataRef<TransitionData> transitionData;

	[Token(Token = "0x4000B37")]
	[FieldOffset(Offset = "0x28")]
	public StyleDataRef<VisualData> visualData;

	[Token(Token = "0x4000B38")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<string, StylePropertyValue> customProperties;

	[Token(Token = "0x4000B39")]
	[FieldOffset(Offset = "0x38")]
	public long matchingRulesHash;

	[Token(Token = "0x4000B3A")]
	[FieldOffset(Offset = "0x40")]
	public float dpiScaling;

	[Token(Token = "0x4000B3B")]
	[FieldOffset(Offset = "0x48")]
	public ComputedTransitionProperty[] computedTransitions;

	[Token(Token = "0x170003B7")]
	public int customPropertiesCount
	{
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x2B57ED0", Offset = "0x2B570D0", VA = "0x182B57ED0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003B8")]
	public bool hasTransition
	{
		[Token(Token = "0x600136F")]
		[Address(RVA = "0x2B580E0", Offset = "0x2B572E0", VA = "0x182B580E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003B9")]
	public Align alignContent
	{
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x2B57770", Offset = "0x2B56970", VA = "0x182B57770")]
		get
		{
			return default(Align);
		}
	}

	[Token(Token = "0x170003BA")]
	public Align alignItems
	{
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x2B577B0", Offset = "0x2B569B0", VA = "0x182B577B0")]
		get
		{
			return default(Align);
		}
	}

	[Token(Token = "0x170003BB")]
	public Align alignSelf
	{
		[Token(Token = "0x600137F")]
		[Address(RVA = "0x2B577F0", Offset = "0x2B569F0", VA = "0x182B577F0")]
		get
		{
			return default(Align);
		}
	}

	[Token(Token = "0x170003BC")]
	public Color backgroundColor
	{
		[Token(Token = "0x6001380")]
		[Address(RVA = "0x2B57830", Offset = "0x2B56A30", VA = "0x182B57830")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170003BD")]
	public Background backgroundImage
	{
		[Token(Token = "0x6001381")]
		[Address(RVA = "0x2B57880", Offset = "0x2B56A80", VA = "0x182B57880")]
		get
		{
			return default(Background);
		}
	}

	[Token(Token = "0x170003BE")]
	public BackgroundPosition backgroundPositionX
	{
		[Token(Token = "0x6001382")]
		[Address(RVA = "0x2B578E0", Offset = "0x2B56AE0", VA = "0x182B578E0")]
		get
		{
			return default(BackgroundPosition);
		}
	}

	[Token(Token = "0x170003BF")]
	public BackgroundPosition backgroundPositionY
	{
		[Token(Token = "0x6001383")]
		[Address(RVA = "0x2B57940", Offset = "0x2B56B40", VA = "0x182B57940")]
		get
		{
			return default(BackgroundPosition);
		}
	}

	[Token(Token = "0x170003C0")]
	public BackgroundRepeat backgroundRepeat
	{
		[Token(Token = "0x6001384")]
		[Address(RVA = "0x2B579A0", Offset = "0x2B56BA0", VA = "0x182B579A0")]
		get
		{
			return default(BackgroundRepeat);
		}
	}

	[Token(Token = "0x170003C1")]
	public BackgroundSize backgroundSize
	{
		[Token(Token = "0x6001385")]
		[Address(RVA = "0x2B579E0", Offset = "0x2B56BE0", VA = "0x182B579E0")]
		get
		{
			return default(BackgroundSize);
		}
	}

	[Token(Token = "0x170003C2")]
	public Color borderBottomColor
	{
		[Token(Token = "0x6001386")]
		[Address(RVA = "0x2B57A40", Offset = "0x2B56C40", VA = "0x182B57A40")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170003C3")]
	public Length borderBottomLeftRadius
	{
		[Token(Token = "0x6001387")]
		[Address(RVA = "0x2B57AA0", Offset = "0x2B56CA0", VA = "0x182B57AA0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003C4")]
	public Length borderBottomRightRadius
	{
		[Token(Token = "0x6001388")]
		[Address(RVA = "0x2B57AE0", Offset = "0x2B56CE0", VA = "0x182B57AE0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003C5")]
	public float borderBottomWidth
	{
		[Token(Token = "0x6001389")]
		[Address(RVA = "0x2B57B20", Offset = "0x2B56D20", VA = "0x182B57B20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003C6")]
	public Color borderLeftColor
	{
		[Token(Token = "0x600138A")]
		[Address(RVA = "0x2B57B60", Offset = "0x2B56D60", VA = "0x182B57B60")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170003C7")]
	public float borderLeftWidth
	{
		[Token(Token = "0x600138B")]
		[Address(RVA = "0x2B57BC0", Offset = "0x2B56DC0", VA = "0x182B57BC0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003C8")]
	public Color borderRightColor
	{
		[Token(Token = "0x600138C")]
		[Address(RVA = "0x2B57C00", Offset = "0x2B56E00", VA = "0x182B57C00")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170003C9")]
	public float borderRightWidth
	{
		[Token(Token = "0x600138D")]
		[Address(RVA = "0x2B57C60", Offset = "0x2B56E60", VA = "0x182B57C60")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003CA")]
	public Color borderTopColor
	{
		[Token(Token = "0x600138E")]
		[Address(RVA = "0x2B57CA0", Offset = "0x2B56EA0", VA = "0x182B57CA0")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170003CB")]
	public Length borderTopLeftRadius
	{
		[Token(Token = "0x600138F")]
		[Address(RVA = "0x2B57D00", Offset = "0x2B56F00", VA = "0x182B57D00")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003CC")]
	public Length borderTopRightRadius
	{
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x2B57D50", Offset = "0x2B56F50", VA = "0x182B57D50")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003CD")]
	public float borderTopWidth
	{
		[Token(Token = "0x6001391")]
		[Address(RVA = "0x2B57DA0", Offset = "0x2B56FA0", VA = "0x182B57DA0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003CE")]
	public Length bottom
	{
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x2B57DE0", Offset = "0x2B56FE0", VA = "0x182B57DE0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003CF")]
	public Color color
	{
		[Token(Token = "0x6001393")]
		[Address(RVA = "0x2B57E20", Offset = "0x2B57020", VA = "0x182B57E20")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170003D0")]
	public Cursor cursor
	{
		[Token(Token = "0x6001394")]
		[Address(RVA = "0x2B57E70", Offset = "0x2B57070", VA = "0x182B57E70")]
		get
		{
			return default(Cursor);
		}
	}

	[Token(Token = "0x170003D1")]
	public DisplayStyle display
	{
		[Token(Token = "0x6001395")]
		[Address(RVA = "0x2B57F20", Offset = "0x2B57120", VA = "0x182B57F20")]
		get
		{
			return default(DisplayStyle);
		}
	}

	[Token(Token = "0x170003D2")]
	public Length flexBasis
	{
		[Token(Token = "0x6001396")]
		[Address(RVA = "0x2B57F60", Offset = "0x2B57160", VA = "0x182B57F60")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003D3")]
	public FlexDirection flexDirection
	{
		[Token(Token = "0x6001397")]
		[Address(RVA = "0x2B57FA0", Offset = "0x2B571A0", VA = "0x182B57FA0")]
		get
		{
			return default(FlexDirection);
		}
	}

	[Token(Token = "0x170003D4")]
	public float flexGrow
	{
		[Token(Token = "0x6001398")]
		[Address(RVA = "0x2B57FE0", Offset = "0x2B571E0", VA = "0x182B57FE0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003D5")]
	public float flexShrink
	{
		[Token(Token = "0x6001399")]
		[Address(RVA = "0x2B58020", Offset = "0x2B57220", VA = "0x182B58020")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003D6")]
	public Wrap flexWrap
	{
		[Token(Token = "0x600139A")]
		[Address(RVA = "0x2B58060", Offset = "0x2B57260", VA = "0x182B58060")]
		get
		{
			return default(Wrap);
		}
	}

	[Token(Token = "0x170003D7")]
	public Length fontSize
	{
		[Token(Token = "0x600139B")]
		[Address(RVA = "0x2B580A0", Offset = "0x2B572A0", VA = "0x182B580A0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003D8")]
	public Length height
	{
		[Token(Token = "0x600139C")]
		[Address(RVA = "0x2B58100", Offset = "0x2B57300", VA = "0x182B58100")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003D9")]
	public Justify justifyContent
	{
		[Token(Token = "0x600139D")]
		[Address(RVA = "0x2B58140", Offset = "0x2B57340", VA = "0x182B58140")]
		get
		{
			return default(Justify);
		}
	}

	[Token(Token = "0x170003DA")]
	public Length left
	{
		[Token(Token = "0x600139E")]
		[Address(RVA = "0x2B58180", Offset = "0x2B57380", VA = "0x182B58180")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003DB")]
	public Length letterSpacing
	{
		[Token(Token = "0x600139F")]
		[Address(RVA = "0x2B581C0", Offset = "0x2B573C0", VA = "0x182B581C0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003DC")]
	public Length marginBottom
	{
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x2B58200", Offset = "0x2B57400", VA = "0x182B58200")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003DD")]
	public Length marginLeft
	{
		[Token(Token = "0x60013A1")]
		[Address(RVA = "0x2B58240", Offset = "0x2B57440", VA = "0x182B58240")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003DE")]
	public Length marginRight
	{
		[Token(Token = "0x60013A2")]
		[Address(RVA = "0x2B58280", Offset = "0x2B57480", VA = "0x182B58280")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003DF")]
	public Length marginTop
	{
		[Token(Token = "0x60013A3")]
		[Address(RVA = "0x2B582C0", Offset = "0x2B574C0", VA = "0x182B582C0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003E0")]
	public Length maxHeight
	{
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x2B58300", Offset = "0x2B57500", VA = "0x182B58300")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003E1")]
	public Length maxWidth
	{
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x2B58340", Offset = "0x2B57540", VA = "0x182B58340")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003E2")]
	public Length minHeight
	{
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x2B58380", Offset = "0x2B57580", VA = "0x182B58380")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003E3")]
	public Length minWidth
	{
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x2B583D0", Offset = "0x2B575D0", VA = "0x182B583D0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003E4")]
	public float opacity
	{
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x2B58420", Offset = "0x2B57620", VA = "0x182B58420")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003E5")]
	public OverflowInternal overflow
	{
		[Token(Token = "0x60013A9")]
		[Address(RVA = "0x2B58470", Offset = "0x2B57670", VA = "0x182B58470")]
		get
		{
			return default(OverflowInternal);
		}
	}

	[Token(Token = "0x170003E6")]
	public Length paddingBottom
	{
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x2B584C0", Offset = "0x2B576C0", VA = "0x182B584C0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003E7")]
	public Length paddingLeft
	{
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x2B58510", Offset = "0x2B57710", VA = "0x182B58510")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003E8")]
	public Length paddingRight
	{
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x2B58560", Offset = "0x2B57760", VA = "0x182B58560")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003E9")]
	public Length paddingTop
	{
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x2B585B0", Offset = "0x2B577B0", VA = "0x182B585B0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003EA")]
	public Position position
	{
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x2B58600", Offset = "0x2B57800", VA = "0x182B58600")]
		get
		{
			return default(Position);
		}
	}

	[Token(Token = "0x170003EB")]
	public Length right
	{
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x2B58650", Offset = "0x2B57850", VA = "0x182B58650")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003EC")]
	public Rotate rotate
	{
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x2B586A0", Offset = "0x2B578A0", VA = "0x182B586A0")]
		get
		{
			return default(Rotate);
		}
	}

	[Token(Token = "0x170003ED")]
	public Scale scale
	{
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x2B58700", Offset = "0x2B57900", VA = "0x182B58700")]
		get
		{
			return default(Scale);
		}
	}

	[Token(Token = "0x170003EE")]
	public TextOverflow textOverflow
	{
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x2B58760", Offset = "0x2B57960", VA = "0x182B58760")]
		get
		{
			return default(TextOverflow);
		}
	}

	[Token(Token = "0x170003EF")]
	public TextShadow textShadow
	{
		[Token(Token = "0x60013B3")]
		[Address(RVA = "0x2B587A0", Offset = "0x2B579A0", VA = "0x182B587A0")]
		get
		{
			return default(TextShadow);
		}
	}

	[Token(Token = "0x170003F0")]
	public Length top
	{
		[Token(Token = "0x60013B4")]
		[Address(RVA = "0x2B58800", Offset = "0x2B57A00", VA = "0x182B58800")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003F1")]
	public TransformOrigin transformOrigin
	{
		[Token(Token = "0x60013B5")]
		[Address(RVA = "0x2B58850", Offset = "0x2B57A50", VA = "0x182B58850")]
		get
		{
			return default(TransformOrigin);
		}
	}

	[Token(Token = "0x170003F2")]
	public List<TimeValue> transitionDelay
	{
		[Token(Token = "0x60013B6")]
		[Address(RVA = "0x2B588B0", Offset = "0x2B57AB0", VA = "0x182B588B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F3")]
	public List<TimeValue> transitionDuration
	{
		[Token(Token = "0x60013B7")]
		[Address(RVA = "0x2B588F0", Offset = "0x2B57AF0", VA = "0x182B588F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F4")]
	public List<StylePropertyName> transitionProperty
	{
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x2B58930", Offset = "0x2B57B30", VA = "0x182B58930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F5")]
	public List<EasingFunction> transitionTimingFunction
	{
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x2B58970", Offset = "0x2B57B70", VA = "0x182B58970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003F6")]
	public Translate translate
	{
		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x2B589B0", Offset = "0x2B57BB0", VA = "0x182B589B0")]
		get
		{
			return default(Translate);
		}
	}

	[Token(Token = "0x170003F7")]
	public Color unityBackgroundImageTintColor
	{
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x2B58A10", Offset = "0x2B57C10", VA = "0x182B58A10")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x170003F8")]
	public EditorTextRenderingMode unityEditorTextRenderingMode
	{
		[Token(Token = "0x60013BC")]
		[Address(RVA = "0x2B58A70", Offset = "0x2B57C70", VA = "0x182B58A70")]
		get
		{
			return default(EditorTextRenderingMode);
		}
	}

	[Token(Token = "0x170003F9")]
	public Font unityFont
	{
		[Token(Token = "0x60013BD")]
		[Address(RVA = "0x2B58B40", Offset = "0x2B57D40", VA = "0x182B58B40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003FA")]
	public FontDefinition unityFontDefinition
	{
		[Token(Token = "0x60013BE")]
		[Address(RVA = "0x2B58AB0", Offset = "0x2B57CB0", VA = "0x182B58AB0")]
		get
		{
			return default(FontDefinition);
		}
	}

	[Token(Token = "0x170003FB")]
	public FontStyle unityFontStyleAndWeight
	{
		[Token(Token = "0x60013BF")]
		[Address(RVA = "0x2B58B00", Offset = "0x2B57D00", VA = "0x182B58B00")]
		get
		{
			return default(FontStyle);
		}
	}

	[Token(Token = "0x170003FC")]
	public OverflowClipBox unityOverflowClipBox
	{
		[Token(Token = "0x60013C0")]
		[Address(RVA = "0x2B58B80", Offset = "0x2B57D80", VA = "0x182B58B80")]
		get
		{
			return default(OverflowClipBox);
		}
	}

	[Token(Token = "0x170003FD")]
	public Length unityParagraphSpacing
	{
		[Token(Token = "0x60013C1")]
		[Address(RVA = "0x2B58BC0", Offset = "0x2B57DC0", VA = "0x182B58BC0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x170003FE")]
	public int unitySliceBottom
	{
		[Token(Token = "0x60013C2")]
		[Address(RVA = "0x2B58C00", Offset = "0x2B57E00", VA = "0x182B58C00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003FF")]
	public int unitySliceLeft
	{
		[Token(Token = "0x60013C3")]
		[Address(RVA = "0x2B58C40", Offset = "0x2B57E40", VA = "0x182B58C40")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000400")]
	public int unitySliceRight
	{
		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x2B58C80", Offset = "0x2B57E80", VA = "0x182B58C80")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000401")]
	public float unitySliceScale
	{
		[Token(Token = "0x60013C5")]
		[Address(RVA = "0x2B58CC0", Offset = "0x2B57EC0", VA = "0x182B58CC0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000402")]
	public int unitySliceTop
	{
		[Token(Token = "0x60013C6")]
		[Address(RVA = "0x2B58D00", Offset = "0x2B57F00", VA = "0x182B58D00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000403")]
	public SliceType unitySliceType
	{
		[Token(Token = "0x60013C7")]
		[Address(RVA = "0x2B58D40", Offset = "0x2B57F40", VA = "0x182B58D40")]
		get
		{
			return default(SliceType);
		}
	}

	[Token(Token = "0x17000404")]
	public TextAnchor unityTextAlign
	{
		[Token(Token = "0x60013C8")]
		[Address(RVA = "0x2B58D80", Offset = "0x2B57F80", VA = "0x182B58D80")]
		get
		{
			return default(TextAnchor);
		}
	}

	[Token(Token = "0x17000405")]
	public TextGeneratorType unityTextGenerator
	{
		[Token(Token = "0x60013C9")]
		[Address(RVA = "0x2B58DC0", Offset = "0x2B57FC0", VA = "0x182B58DC0")]
		get
		{
			return default(TextGeneratorType);
		}
	}

	[Token(Token = "0x17000406")]
	public Color unityTextOutlineColor
	{
		[Token(Token = "0x60013CA")]
		[Address(RVA = "0x2B58E00", Offset = "0x2B58000", VA = "0x182B58E00")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000407")]
	public float unityTextOutlineWidth
	{
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x2B58E50", Offset = "0x2B58050", VA = "0x182B58E50")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000408")]
	public TextOverflowPosition unityTextOverflowPosition
	{
		[Token(Token = "0x60013CC")]
		[Address(RVA = "0x2B58E90", Offset = "0x2B58090", VA = "0x182B58E90")]
		get
		{
			return default(TextOverflowPosition);
		}
	}

	[Token(Token = "0x17000409")]
	public Visibility visibility
	{
		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x2B58ED0", Offset = "0x2B580D0", VA = "0x182B58ED0")]
		get
		{
			return default(Visibility);
		}
	}

	[Token(Token = "0x1700040A")]
	public WhiteSpace whiteSpace
	{
		[Token(Token = "0x60013CE")]
		[Address(RVA = "0x2B58F10", Offset = "0x2B58110", VA = "0x182B58F10")]
		get
		{
			return default(WhiteSpace);
		}
	}

	[Token(Token = "0x1700040B")]
	public Length width
	{
		[Token(Token = "0x60013CF")]
		[Address(RVA = "0x2B58F50", Offset = "0x2B58150", VA = "0x182B58F50")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x1700040C")]
	public Length wordSpacing
	{
		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x2B58FA0", Offset = "0x2B581A0", VA = "0x182B58FA0")]
		get
		{
			return default(Length);
		}
	}

	[Token(Token = "0x6001370")]
	[Address(RVA = "0x2B4C7B0", Offset = "0x2B4B9B0", VA = "0x182B4C7B0")]
	public void FinalizeApply(ref ComputedStyle parentStyle)
	{
	}

	[Token(Token = "0x6001371")]
	[Address(RVA = "0x2B42A70", Offset = "0x2B41C70", VA = "0x182B42A70")]
	private bool ApplyGlobalKeyword(StylePropertyReader reader, ref ComputedStyle parentStyle)
	{
		return default(bool);
	}

	[Token(Token = "0x6001372")]
	[Address(RVA = "0x2B42B30", Offset = "0x2B41D30", VA = "0x182B42B30")]
	private bool ApplyGlobalKeyword(StylePropertyId id, StyleKeyword keyword, ref ComputedStyle parentStyle)
	{
		return default(bool);
	}

	[Token(Token = "0x6001373")]
	[Address(RVA = "0x2B4C9B0", Offset = "0x2B4BBB0", VA = "0x182B4C9B0")]
	private void RemoveCustomStyleProperty(StylePropertyReader reader)
	{
	}

	[Token(Token = "0x6001374")]
	[Address(RVA = "0x2B41180", Offset = "0x2B40380", VA = "0x182B41180")]
	private void ApplyCustomStyleProperty(StylePropertyReader reader)
	{
	}

	[Token(Token = "0x6001375")]
	[Address(RVA = "0x2B41120", Offset = "0x2B40320", VA = "0x182B41120")]
	private void ApplyAllPropertyInitial()
	{
	}

	[Token(Token = "0x6001376")]
	[Address(RVA = "0x2B4CA50", Offset = "0x2B4BC50", VA = "0x182B4CA50")]
	private void ResetComputedTransitions()
	{
	}

	[Token(Token = "0x6001377")]
	[Address(RVA = "0x2B50120", Offset = "0x2B4F320", VA = "0x182B50120")]
	public static bool StartAnimationInlineTextShadow(VisualElement element, ref ComputedStyle computedStyle, StyleTextShadow textShadow, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001378")]
	[Address(RVA = "0x2B4FD00", Offset = "0x2B4EF00", VA = "0x182B4FD00")]
	public static bool StartAnimationInlineRotate(VisualElement element, ref ComputedStyle computedStyle, StyleRotate rotate, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x6001379")]
	[Address(RVA = "0x2B504C0", Offset = "0x2B4F6C0", VA = "0x182B504C0")]
	public static bool StartAnimationInlineTranslate(VisualElement element, ref ComputedStyle computedStyle, StyleTranslate translate, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x600137A")]
	[Address(RVA = "0x2B4FF30", Offset = "0x2B4F130", VA = "0x182B4FF30")]
	public static bool StartAnimationInlineScale(VisualElement element, ref ComputedStyle computedStyle, StyleScale scale, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x600137B")]
	[Address(RVA = "0x2B502B0", Offset = "0x2B4F4B0", VA = "0x182B502B0")]
	public static bool StartAnimationInlineTransformOrigin(VisualElement element, ref ComputedStyle computedStyle, StyleTransformOrigin transformOrigin, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x600137C")]
	[Address(RVA = "0x2B4FB20", Offset = "0x2B4ED20", VA = "0x182B4FB20")]
	public static bool StartAnimationInlineBackgroundSize(VisualElement element, ref ComputedStyle computedStyle, StyleBackgroundSize backgroundSize, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x2B4C5D0", Offset = "0x2B4B7D0", VA = "0x182B4C5D0")]
	public static ComputedStyle Create(ref ComputedStyle parentStyle)
	{
		return default(ComputedStyle);
	}

	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x2B4C440", Offset = "0x2B4B640", VA = "0x182B4C440")]
	public static ComputedStyle CreateInitial()
	{
		return default(ComputedStyle);
	}

	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x2B41000", Offset = "0x2B40200", VA = "0x182B41000")]
	public ComputedStyle Acquire()
	{
		return default(ComputedStyle);
	}

	[Token(Token = "0x60013D4")]
	[Address(RVA = "0x2B4C8E0", Offset = "0x2B4BAE0", VA = "0x182B4C8E0")]
	public void Release()
	{
	}

	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x2B4C320", Offset = "0x2B4B520", VA = "0x182B4C320")]
	public void CopyFrom(ref ComputedStyle other)
	{
	}

	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x2B44D20", Offset = "0x2B43F20", VA = "0x182B44D20")]
	public void ApplyProperties(StylePropertyReader reader, ref ComputedStyle parentStyle)
	{
	}

	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x2B49460", Offset = "0x2B48660", VA = "0x182B49460")]
	public void ApplyStyleValue(StyleValue sv, ref ComputedStyle parentStyle)
	{
	}

	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x2B48F10", Offset = "0x2B48110", VA = "0x182B48F10")]
	public void ApplyStyleValueManaged(StyleValueManaged sv, ref ComputedStyle parentStyle)
	{
	}

	[Token(Token = "0x60013D9")]
	[Address(RVA = "0x2B48CE0", Offset = "0x2B47EE0", VA = "0x182B48CE0")]
	public void ApplyStyleCursor(Cursor cursor)
	{
	}

	[Token(Token = "0x60013DA")]
	[Address(RVA = "0x2B48DF0", Offset = "0x2B47FF0", VA = "0x182B48DF0")]
	public void ApplyStyleTextShadow(TextShadow st)
	{
	}

	[Token(Token = "0x60013DB")]
	[Address(RVA = "0x2B41290", Offset = "0x2B40490", VA = "0x182B41290")]
	public void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle other)
	{
	}

	[Token(Token = "0x60013DC")]
	[Address(RVA = "0x2B46C90", Offset = "0x2B45E90", VA = "0x182B46C90")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Length newValue)
	{
	}

	[Token(Token = "0x60013DD")]
	[Address(RVA = "0x2B467B0", Offset = "0x2B459B0", VA = "0x182B467B0")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, float newValue)
	{
	}

	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x2B476C0", Offset = "0x2B468C0", VA = "0x182B476C0")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, int newValue)
	{
	}

	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x2B484D0", Offset = "0x2B476D0", VA = "0x182B484D0")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundPosition newValue)
	{
	}

	[Token(Token = "0x60013E0")]
	[Address(RVA = "0x2B48060", Offset = "0x2B47260", VA = "0x182B48060")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundRepeat newValue)
	{
	}

	[Token(Token = "0x60013E1")]
	[Address(RVA = "0x2B46B40", Offset = "0x2B45D40", VA = "0x182B46B40")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, BackgroundSize newValue)
	{
	}

	[Token(Token = "0x60013E2")]
	[Address(RVA = "0x2B489D0", Offset = "0x2B47BD0", VA = "0x182B489D0")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Color newValue)
	{
	}

	[Token(Token = "0x60013E3")]
	[Address(RVA = "0x2B48320", Offset = "0x2B47520", VA = "0x182B48320")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Background newValue)
	{
	}

	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x2B47520", Offset = "0x2B46720", VA = "0x182B47520")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Font newValue)
	{
	}

	[Token(Token = "0x60013E5")]
	[Address(RVA = "0x2B486F0", Offset = "0x2B478F0", VA = "0x182B486F0")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, FontDefinition newValue)
	{
	}

	[Token(Token = "0x60013E6")]
	[Address(RVA = "0x2B48880", Offset = "0x2B47A80", VA = "0x182B48880")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TextShadow newValue)
	{
	}

	[Token(Token = "0x60013E7")]
	[Address(RVA = "0x2B47DD0", Offset = "0x2B46FD0", VA = "0x182B47DD0")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Translate newValue)
	{
	}

	[Token(Token = "0x60013E8")]
	[Address(RVA = "0x2B481D0", Offset = "0x2B473D0", VA = "0x182B481D0")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, TransformOrigin newValue)
	{
	}

	[Token(Token = "0x60013E9")]
	[Address(RVA = "0x2B46660", Offset = "0x2B45860", VA = "0x182B46660")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Rotate newValue)
	{
	}

	[Token(Token = "0x60013EA")]
	[Address(RVA = "0x2B47F20", Offset = "0x2B47120", VA = "0x182B47F20")]
	public void ApplyPropertyAnimation(VisualElement ve, StylePropertyId id, Scale newValue)
	{
	}

	[Token(Token = "0x60013EB")]
	[Address(RVA = "0x2B539B0", Offset = "0x2B52BB0", VA = "0x182B539B0")]
	public static bool StartAnimation(VisualElement element, StylePropertyId id, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x60013EC")]
	[Address(RVA = "0x2B4CA70", Offset = "0x2B4BC70", VA = "0x182B4CA70")]
	public static bool StartAnimationAllProperty(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x60013ED")]
	[Address(RVA = "0x2B506F0", Offset = "0x2B4F8F0", VA = "0x182B506F0")]
	public static bool StartAnimationInline(VisualElement element, StylePropertyId id, ref ComputedStyle computedStyle, StyleValue sv, int durationMs, int delayMs, Func<float, float> easingCurve)
	{
		return default(bool);
	}

	[Token(Token = "0x60013EE")]
	[Address(RVA = "0x2B48E50", Offset = "0x2B48050", VA = "0x182B48E50")]
	public void ApplyStyleTransformOrigin(TransformOrigin st)
	{
	}

	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x2B48EB0", Offset = "0x2B480B0", VA = "0x182B48EB0")]
	public void ApplyStyleTranslate(Translate translateValue)
	{
	}

	[Token(Token = "0x60013F0")]
	[Address(RVA = "0x2B48D40", Offset = "0x2B47F40", VA = "0x182B48D40")]
	public void ApplyStyleRotate(Rotate rotateValue)
	{
	}

	[Token(Token = "0x60013F1")]
	[Address(RVA = "0x2B48DA0", Offset = "0x2B47FA0", VA = "0x182B48DA0")]
	public void ApplyStyleScale(Scale scaleValue)
	{
	}

	[Token(Token = "0x60013F2")]
	[Address(RVA = "0x2B48C80", Offset = "0x2B47E80", VA = "0x182B48C80")]
	public void ApplyStyleBackgroundSize(BackgroundSize backgroundSizeValue)
	{
	}

	[Token(Token = "0x60013F3")]
	[Address(RVA = "0x2B42B50", Offset = "0x2B41D50", VA = "0x182B42B50")]
	public void ApplyInitialValue(StylePropertyReader reader)
	{
	}

	[Token(Token = "0x60013F4")]
	[Address(RVA = "0x2B42C70", Offset = "0x2B41E70", VA = "0x182B42C70")]
	public void ApplyInitialValue(StylePropertyId id)
	{
	}

	[Token(Token = "0x60013F5")]
	[Address(RVA = "0x2B4A2A0", Offset = "0x2B494A0", VA = "0x182B4A2A0")]
	public void ApplyUnsetValue(StylePropertyReader reader, ref ComputedStyle parentStyle)
	{
	}

	[Token(Token = "0x60013F6")]
	[Address(RVA = "0x2B4A360", Offset = "0x2B49560", VA = "0x182B4A360")]
	public void ApplyUnsetValue(StylePropertyId id, ref ComputedStyle parentStyle)
	{
	}

	[Token(Token = "0x60013F7")]
	[Address(RVA = "0x2B4A7E0", Offset = "0x2B499E0", VA = "0x182B4A7E0")]
	public static VersionChangeType CompareChanges(ref ComputedStyle x, ref ComputedStyle y)
	{
		return default(VersionChangeType);
	}
}
