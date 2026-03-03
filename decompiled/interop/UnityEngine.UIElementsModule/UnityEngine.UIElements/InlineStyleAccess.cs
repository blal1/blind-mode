using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002DA")]
internal class InlineStyleAccess : StyleValueCollection, IStyle
{
	[Token(Token = "0x20002DB")]
	internal struct InlineRule
	{
		[Token(Token = "0x4000B8D")]
		[FieldOffset(Offset = "0x0")]
		public StyleSheet sheet;

		[Token(Token = "0x4000B8E")]
		[FieldOffset(Offset = "0x8")]
		public StyleRule rule;

		[Token(Token = "0x4000B8F")]
		[FieldOffset(Offset = "0x10")]
		public StylePropertyId[] propertyIds;
	}

	[Token(Token = "0x4000B7B")]
	[FieldOffset(Offset = "0x0")]
	private static StylePropertyReader s_StylePropertyReader;

	[Token(Token = "0x4000B7C")]
	[FieldOffset(Offset = "0x18")]
	private List<StyleValueManaged> m_ValuesManaged;

	[Token(Token = "0x4000B7E")]
	[FieldOffset(Offset = "0x28")]
	private bool m_HasInlineCursor;

	[Token(Token = "0x4000B7F")]
	[FieldOffset(Offset = "0x30")]
	private StyleCursor m_InlineCursor;

	[Token(Token = "0x4000B80")]
	[FieldOffset(Offset = "0x50")]
	private bool m_HasInlineTextShadow;

	[Token(Token = "0x4000B81")]
	[FieldOffset(Offset = "0x54")]
	private StyleTextShadow m_InlineTextShadow;

	[Token(Token = "0x4000B82")]
	[FieldOffset(Offset = "0x74")]
	private bool m_HasInlineTransformOrigin;

	[Token(Token = "0x4000B83")]
	[FieldOffset(Offset = "0x78")]
	private StyleTransformOrigin m_InlineTransformOrigin;

	[Token(Token = "0x4000B84")]
	[FieldOffset(Offset = "0x90")]
	private bool m_HasInlineTranslate;

	[Token(Token = "0x4000B85")]
	[FieldOffset(Offset = "0x94")]
	private StyleTranslate m_InlineTranslateOperation;

	[Token(Token = "0x4000B86")]
	[FieldOffset(Offset = "0xB0")]
	private bool m_HasInlineRotate;

	[Token(Token = "0x4000B87")]
	[FieldOffset(Offset = "0xB4")]
	private StyleRotate m_InlineRotateOperation;

	[Token(Token = "0x4000B88")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_HasInlineScale;

	[Token(Token = "0x4000B89")]
	[FieldOffset(Offset = "0xD4")]
	private StyleScale m_InlineScale;

	[Token(Token = "0x4000B8A")]
	[FieldOffset(Offset = "0xE8")]
	private bool m_HasInlineBackgroundSize;

	[Token(Token = "0x4000B8B")]
	[FieldOffset(Offset = "0xEC")]
	public StyleBackgroundSize m_InlineBackgroundSize;

	[Token(Token = "0x4000B8C")]
	[FieldOffset(Offset = "0x108")]
	private InlineRule m_InlineRule;

	[Token(Token = "0x17000417")]
	private StyleEnum<Align> UnityEngine_002EUIElements_002EIStyle_002EalignContent
	{
		[Token(Token = "0x6001453")]
		[Address(RVA = "0x2B63750", Offset = "0x2B62950", VA = "0x182B63750", Slot = "4")]
		get
		{
			return default(StyleEnum<Align>);
		}
		[Token(Token = "0x6001454")]
		[Address(RVA = "0x2B650F0", Offset = "0x2B642F0", VA = "0x182B650F0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000418")]
	private StyleEnum<Align> UnityEngine_002EUIElements_002EIStyle_002EalignItems
	{
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x2B637D0", Offset = "0x2B629D0", VA = "0x182B637D0", Slot = "6")]
		get
		{
			return default(StyleEnum<Align>);
		}
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x2B651A0", Offset = "0x2B643A0", VA = "0x182B651A0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x17000419")]
	private StyleEnum<Align> UnityEngine_002EUIElements_002EIStyle_002EalignSelf
	{
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x2B63850", Offset = "0x2B62A50", VA = "0x182B63850", Slot = "8")]
		get
		{
			return default(StyleEnum<Align>);
		}
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x2B65250", Offset = "0x2B64450", VA = "0x182B65250", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x1700041A")]
	private StyleColor UnityEngine_002EUIElements_002EIStyle_002EbackgroundColor
	{
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x2B638D0", Offset = "0x2B62AD0", VA = "0x182B638D0", Slot = "10")]
		get
		{
			return default(StyleColor);
		}
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x2B65300", Offset = "0x2B64500", VA = "0x182B65300", Slot = "11")]
		set
		{
		}
	}

	[Token(Token = "0x1700041B")]
	private StyleBackground UnityEngine_002EUIElements_002EIStyle_002EbackgroundImage
	{
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x2B63910", Offset = "0x2B62B10", VA = "0x182B63910", Slot = "12")]
		get
		{
			return default(StyleBackground);
		}
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x2B65360", Offset = "0x2B64560", VA = "0x182B65360", Slot = "13")]
		set
		{
		}
	}

	[Token(Token = "0x1700041C")]
	private StyleBackgroundPosition UnityEngine_002EUIElements_002EIStyle_002EbackgroundPositionX
	{
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x2B63960", Offset = "0x2B62B60", VA = "0x182B63960", Slot = "14")]
		get
		{
			return default(StyleBackgroundPosition);
		}
		[Token(Token = "0x600145E")]
		[Address(RVA = "0x2B653D0", Offset = "0x2B645D0", VA = "0x182B653D0", Slot = "15")]
		set
		{
		}
	}

	[Token(Token = "0x1700041D")]
	private StyleBackgroundPosition UnityEngine_002EUIElements_002EIStyle_002EbackgroundPositionY
	{
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x2B639A0", Offset = "0x2B62BA0", VA = "0x182B639A0", Slot = "16")]
		get
		{
			return default(StyleBackgroundPosition);
		}
		[Token(Token = "0x6001460")]
		[Address(RVA = "0x2B65420", Offset = "0x2B64620", VA = "0x182B65420", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x1700041E")]
	private StyleBackgroundRepeat UnityEngine_002EUIElements_002EIStyle_002EbackgroundRepeat
	{
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x2B639E0", Offset = "0x2B62BE0", VA = "0x182B639E0", Slot = "18")]
		get
		{
			return default(StyleBackgroundRepeat);
		}
		[Token(Token = "0x6001462")]
		[Address(RVA = "0x2B65470", Offset = "0x2B64670", VA = "0x182B65470", Slot = "19")]
		set
		{
		}
	}

	[Token(Token = "0x1700041F")]
	private StyleColor UnityEngine_002EUIElements_002EIStyle_002EborderBottomColor
	{
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x2B63A90", Offset = "0x2B62C90", VA = "0x182B63A90", Slot = "22")]
		get
		{
			return default(StyleColor);
		}
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x2B65750", Offset = "0x2B64950", VA = "0x182B65750", Slot = "23")]
		set
		{
		}
	}

	[Token(Token = "0x17000420")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EborderBottomLeftRadius
	{
		[Token(Token = "0x6001465")]
		[Address(RVA = "0x2B63AD0", Offset = "0x2B62CD0", VA = "0x182B63AD0", Slot = "24")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x6001466")]
		[Address(RVA = "0x2B657B0", Offset = "0x2B649B0", VA = "0x182B657B0", Slot = "25")]
		set
		{
		}
	}

	[Token(Token = "0x17000421")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EborderBottomRightRadius
	{
		[Token(Token = "0x6001467")]
		[Address(RVA = "0x2B63B10", Offset = "0x2B62D10", VA = "0x182B63B10", Slot = "26")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x6001468")]
		[Address(RVA = "0x2B65810", Offset = "0x2B64A10", VA = "0x182B65810", Slot = "27")]
		set
		{
		}
	}

	[Token(Token = "0x17000422")]
	private StyleFloat UnityEngine_002EUIElements_002EIStyle_002EborderBottomWidth
	{
		[Token(Token = "0x6001469")]
		[Address(RVA = "0x2B63B50", Offset = "0x2B62D50", VA = "0x182B63B50", Slot = "28")]
		get
		{
			return default(StyleFloat);
		}
		[Token(Token = "0x600146A")]
		[Address(RVA = "0x2B65870", Offset = "0x2B64A70", VA = "0x182B65870", Slot = "29")]
		set
		{
		}
	}

	[Token(Token = "0x17000423")]
	private StyleColor UnityEngine_002EUIElements_002EIStyle_002EborderLeftColor
	{
		[Token(Token = "0x600146B")]
		[Address(RVA = "0x2B63B60", Offset = "0x2B62D60", VA = "0x182B63B60", Slot = "30")]
		get
		{
			return default(StyleColor);
		}
		[Token(Token = "0x600146C")]
		[Address(RVA = "0x2B65900", Offset = "0x2B64B00", VA = "0x182B65900", Slot = "31")]
		set
		{
		}
	}

	[Token(Token = "0x17000424")]
	private StyleFloat UnityEngine_002EUIElements_002EIStyle_002EborderLeftWidth
	{
		[Token(Token = "0x600146D")]
		[Address(RVA = "0x2B63BA0", Offset = "0x2B62DA0", VA = "0x182B63BA0", Slot = "32")]
		get
		{
			return default(StyleFloat);
		}
		[Token(Token = "0x600146E")]
		[Address(RVA = "0x2B65960", Offset = "0x2B64B60", VA = "0x182B65960", Slot = "33")]
		set
		{
		}
	}

	[Token(Token = "0x17000425")]
	private StyleColor UnityEngine_002EUIElements_002EIStyle_002EborderRightColor
	{
		[Token(Token = "0x600146F")]
		[Address(RVA = "0x2B63BB0", Offset = "0x2B62DB0", VA = "0x182B63BB0", Slot = "34")]
		get
		{
			return default(StyleColor);
		}
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x2B659F0", Offset = "0x2B64BF0", VA = "0x182B659F0", Slot = "35")]
		set
		{
		}
	}

	[Token(Token = "0x17000426")]
	private StyleFloat UnityEngine_002EUIElements_002EIStyle_002EborderRightWidth
	{
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x2B63BF0", Offset = "0x2B62DF0", VA = "0x182B63BF0", Slot = "36")]
		get
		{
			return default(StyleFloat);
		}
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x2B65A50", Offset = "0x2B64C50", VA = "0x182B65A50", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x17000427")]
	private StyleColor UnityEngine_002EUIElements_002EIStyle_002EborderTopColor
	{
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x2B63C00", Offset = "0x2B62E00", VA = "0x182B63C00", Slot = "38")]
		get
		{
			return default(StyleColor);
		}
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x2B65AE0", Offset = "0x2B64CE0", VA = "0x182B65AE0", Slot = "39")]
		set
		{
		}
	}

	[Token(Token = "0x17000428")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EborderTopLeftRadius
	{
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x2B63C40", Offset = "0x2B62E40", VA = "0x182B63C40", Slot = "40")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x6001476")]
		[Address(RVA = "0x2B65B40", Offset = "0x2B64D40", VA = "0x182B65B40", Slot = "41")]
		set
		{
		}
	}

	[Token(Token = "0x17000429")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EborderTopRightRadius
	{
		[Token(Token = "0x6001477")]
		[Address(RVA = "0x2B63C80", Offset = "0x2B62E80", VA = "0x182B63C80", Slot = "42")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x6001478")]
		[Address(RVA = "0x2B65BA0", Offset = "0x2B64DA0", VA = "0x182B65BA0", Slot = "43")]
		set
		{
		}
	}

	[Token(Token = "0x1700042A")]
	private StyleFloat UnityEngine_002EUIElements_002EIStyle_002EborderTopWidth
	{
		[Token(Token = "0x6001479")]
		[Address(RVA = "0x2B63CC0", Offset = "0x2B62EC0", VA = "0x182B63CC0", Slot = "44")]
		get
		{
			return default(StyleFloat);
		}
		[Token(Token = "0x600147A")]
		[Address(RVA = "0x2B65C00", Offset = "0x2B64E00", VA = "0x182B65C00", Slot = "45")]
		set
		{
		}
	}

	[Token(Token = "0x1700042B")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002Ebottom
	{
		[Token(Token = "0x600147B")]
		[Address(RVA = "0x2B63CD0", Offset = "0x2B62ED0", VA = "0x182B63CD0", Slot = "46")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x600147C")]
		[Address(RVA = "0x2B65C90", Offset = "0x2B64E90", VA = "0x182B65C90", Slot = "47")]
		set
		{
		}
	}

	[Token(Token = "0x1700042C")]
	private StyleColor UnityEngine_002EUIElements_002EIStyle_002Ecolor
	{
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x2B63D10", Offset = "0x2B62F10", VA = "0x182B63D10", Slot = "48")]
		get
		{
			return default(StyleColor);
		}
		[Token(Token = "0x600147E")]
		[Address(RVA = "0x2B65D40", Offset = "0x2B64F40", VA = "0x182B65D40", Slot = "49")]
		set
		{
		}
	}

	[Token(Token = "0x1700042D")]
	private StyleEnum<DisplayStyle> UnityEngine_002EUIElements_002EIStyle_002Edisplay
	{
		[Token(Token = "0x600147F")]
		[Address(RVA = "0x2B63DE0", Offset = "0x2B62FE0", VA = "0x182B63DE0", Slot = "52")]
		get
		{
			return default(StyleEnum<DisplayStyle>);
		}
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x2B65F80", Offset = "0x2B65180", VA = "0x182B65F80", Slot = "53")]
		set
		{
		}
	}

	[Token(Token = "0x1700042E")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EflexBasis
	{
		[Token(Token = "0x6001481")]
		[Address(RVA = "0x2B63E60", Offset = "0x2B63060", VA = "0x182B63E60", Slot = "54")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x2B66030", Offset = "0x2B65230", VA = "0x182B66030", Slot = "55")]
		set
		{
		}
	}

	[Token(Token = "0x1700042F")]
	private StyleEnum<FlexDirection> UnityEngine_002EUIElements_002EIStyle_002EflexDirection
	{
		[Token(Token = "0x6001483")]
		[Address(RVA = "0x2B63EA0", Offset = "0x2B630A0", VA = "0x182B63EA0", Slot = "56")]
		get
		{
			return default(StyleEnum<FlexDirection>);
		}
		[Token(Token = "0x6001484")]
		[Address(RVA = "0x2B660E0", Offset = "0x2B652E0", VA = "0x182B660E0", Slot = "57")]
		set
		{
		}
	}

	[Token(Token = "0x17000430")]
	private StyleFloat UnityEngine_002EUIElements_002EIStyle_002EflexGrow
	{
		[Token(Token = "0x6001485")]
		[Address(RVA = "0x2B63F20", Offset = "0x2B63120", VA = "0x182B63F20", Slot = "58")]
		get
		{
			return default(StyleFloat);
		}
		[Token(Token = "0x6001486")]
		[Address(RVA = "0x2B66190", Offset = "0x2B65390", VA = "0x182B66190", Slot = "59")]
		set
		{
		}
	}

	[Token(Token = "0x17000431")]
	private StyleFloat UnityEngine_002EUIElements_002EIStyle_002EflexShrink
	{
		[Token(Token = "0x6001487")]
		[Address(RVA = "0x2B63F30", Offset = "0x2B63130", VA = "0x182B63F30", Slot = "60")]
		get
		{
			return default(StyleFloat);
		}
		[Token(Token = "0x6001488")]
		[Address(RVA = "0x2B66220", Offset = "0x2B65420", VA = "0x182B66220", Slot = "61")]
		set
		{
		}
	}

	[Token(Token = "0x17000432")]
	private StyleEnum<Wrap> UnityEngine_002EUIElements_002EIStyle_002EflexWrap
	{
		[Token(Token = "0x6001489")]
		[Address(RVA = "0x2B63F40", Offset = "0x2B63140", VA = "0x182B63F40", Slot = "62")]
		get
		{
			return default(StyleEnum<Wrap>);
		}
		[Token(Token = "0x600148A")]
		[Address(RVA = "0x2B662B0", Offset = "0x2B654B0", VA = "0x182B662B0", Slot = "63")]
		set
		{
		}
	}

	[Token(Token = "0x17000433")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EfontSize
	{
		[Token(Token = "0x600148B")]
		[Address(RVA = "0x2B63FC0", Offset = "0x2B631C0", VA = "0x182B63FC0", Slot = "64")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x600148C")]
		[Address(RVA = "0x2B66360", Offset = "0x2B65560", VA = "0x182B66360", Slot = "65")]
		set
		{
		}
	}

	[Token(Token = "0x17000434")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002Eheight
	{
		[Token(Token = "0x600148D")]
		[Address(RVA = "0x2B64000", Offset = "0x2B63200", VA = "0x182B64000", Slot = "66")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x600148E")]
		[Address(RVA = "0x2B663C0", Offset = "0x2B655C0", VA = "0x182B663C0", Slot = "67")]
		set
		{
		}
	}

	[Token(Token = "0x17000435")]
	private StyleEnum<Justify> UnityEngine_002EUIElements_002EIStyle_002EjustifyContent
	{
		[Token(Token = "0x600148F")]
		[Address(RVA = "0x2B64040", Offset = "0x2B63240", VA = "0x182B64040", Slot = "68")]
		get
		{
			return default(StyleEnum<Justify>);
		}
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x2B66470", Offset = "0x2B65670", VA = "0x182B66470", Slot = "69")]
		set
		{
		}
	}

	[Token(Token = "0x17000436")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002Eleft
	{
		[Token(Token = "0x6001491")]
		[Address(RVA = "0x2B640C0", Offset = "0x2B632C0", VA = "0x182B640C0", Slot = "70")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x2B66520", Offset = "0x2B65720", VA = "0x182B66520", Slot = "71")]
		set
		{
		}
	}

	[Token(Token = "0x17000437")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EletterSpacing
	{
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x2B64100", Offset = "0x2B63300", VA = "0x182B64100", Slot = "72")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x2B665D0", Offset = "0x2B657D0", VA = "0x182B665D0", Slot = "73")]
		set
		{
		}
	}

	[Token(Token = "0x17000438")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EmarginBottom
	{
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x2B64140", Offset = "0x2B63340", VA = "0x182B64140", Slot = "74")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x2B66630", Offset = "0x2B65830", VA = "0x182B66630", Slot = "75")]
		set
		{
		}
	}

	[Token(Token = "0x17000439")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EmarginLeft
	{
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x2B64180", Offset = "0x2B63380", VA = "0x182B64180", Slot = "76")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x2B666E0", Offset = "0x2B658E0", VA = "0x182B666E0", Slot = "77")]
		set
		{
		}
	}

	[Token(Token = "0x1700043A")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EmarginRight
	{
		[Token(Token = "0x6001499")]
		[Address(RVA = "0x2B641C0", Offset = "0x2B633C0", VA = "0x182B641C0", Slot = "78")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x2B66790", Offset = "0x2B65990", VA = "0x182B66790", Slot = "79")]
		set
		{
		}
	}

	[Token(Token = "0x1700043B")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EmarginTop
	{
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x2B64200", Offset = "0x2B63400", VA = "0x182B64200", Slot = "80")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x2B66840", Offset = "0x2B65A40", VA = "0x182B66840", Slot = "81")]
		set
		{
		}
	}

	[Token(Token = "0x1700043C")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EmaxHeight
	{
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x2B64240", Offset = "0x2B63440", VA = "0x182B64240", Slot = "82")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x600149E")]
		[Address(RVA = "0x2B668F0", Offset = "0x2B65AF0", VA = "0x182B668F0", Slot = "83")]
		set
		{
		}
	}

	[Token(Token = "0x1700043D")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EmaxWidth
	{
		[Token(Token = "0x600149F")]
		[Address(RVA = "0x2B64280", Offset = "0x2B63480", VA = "0x182B64280", Slot = "84")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014A0")]
		[Address(RVA = "0x2B669A0", Offset = "0x2B65BA0", VA = "0x182B669A0", Slot = "85")]
		set
		{
		}
	}

	[Token(Token = "0x1700043E")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EminHeight
	{
		[Token(Token = "0x60014A1")]
		[Address(RVA = "0x2B642C0", Offset = "0x2B634C0", VA = "0x182B642C0", Slot = "86")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014A2")]
		[Address(RVA = "0x2B66A50", Offset = "0x2B65C50", VA = "0x182B66A50", Slot = "87")]
		set
		{
		}
	}

	[Token(Token = "0x1700043F")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EminWidth
	{
		[Token(Token = "0x60014A3")]
		[Address(RVA = "0x2B64300", Offset = "0x2B63500", VA = "0x182B64300", Slot = "88")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x2B66B00", Offset = "0x2B65D00", VA = "0x182B66B00", Slot = "89")]
		set
		{
		}
	}

	[Token(Token = "0x17000440")]
	private StyleFloat UnityEngine_002EUIElements_002EIStyle_002Eopacity
	{
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x2B64340", Offset = "0x2B63540", VA = "0x182B64340", Slot = "90")]
		get
		{
			return default(StyleFloat);
		}
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x2B66BB0", Offset = "0x2B65DB0", VA = "0x182B66BB0", Slot = "91")]
		set
		{
		}
	}

	[Token(Token = "0x17000441")]
	private StyleEnum<Overflow> UnityEngine_002EUIElements_002EIStyle_002Eoverflow
	{
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x2B64350", Offset = "0x2B63550", VA = "0x182B64350", Slot = "92")]
		get
		{
			return default(StyleEnum<Overflow>);
		}
		[Token(Token = "0x60014A8")]
		[Address(RVA = "0x2B66C00", Offset = "0x2B65E00", VA = "0x182B66C00", Slot = "93")]
		set
		{
		}
	}

	[Token(Token = "0x17000442")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EpaddingBottom
	{
		[Token(Token = "0x60014A9")]
		[Address(RVA = "0x2B643D0", Offset = "0x2B635D0", VA = "0x182B643D0", Slot = "94")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014AA")]
		[Address(RVA = "0x2B66D20", Offset = "0x2B65F20", VA = "0x182B66D20", Slot = "95")]
		set
		{
		}
	}

	[Token(Token = "0x17000443")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EpaddingLeft
	{
		[Token(Token = "0x60014AB")]
		[Address(RVA = "0x2B64410", Offset = "0x2B63610", VA = "0x182B64410", Slot = "96")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x2B66DD0", Offset = "0x2B65FD0", VA = "0x182B66DD0", Slot = "97")]
		set
		{
		}
	}

	[Token(Token = "0x17000444")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EpaddingRight
	{
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x2B64450", Offset = "0x2B63650", VA = "0x182B64450", Slot = "98")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x2B66E80", Offset = "0x2B66080", VA = "0x182B66E80", Slot = "99")]
		set
		{
		}
	}

	[Token(Token = "0x17000445")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EpaddingTop
	{
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x2B64490", Offset = "0x2B63690", VA = "0x182B64490", Slot = "100")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x2B66F30", Offset = "0x2B66130", VA = "0x182B66F30", Slot = "101")]
		set
		{
		}
	}

	[Token(Token = "0x17000446")]
	private StyleEnum<Position> UnityEngine_002EUIElements_002EIStyle_002Eposition
	{
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x2B644D0", Offset = "0x2B636D0", VA = "0x182B644D0", Slot = "102")]
		get
		{
			return default(StyleEnum<Position>);
		}
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x2B66FE0", Offset = "0x2B661E0", VA = "0x182B66FE0", Slot = "103")]
		set
		{
		}
	}

	[Token(Token = "0x17000447")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002Eright
	{
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x2B64550", Offset = "0x2B63750", VA = "0x182B64550", Slot = "104")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x2B67090", Offset = "0x2B66290", VA = "0x182B67090", Slot = "105")]
		set
		{
		}
	}

	[Token(Token = "0x17000448")]
	private StyleEnum<TextOverflow> UnityEngine_002EUIElements_002EIStyle_002EtextOverflow
	{
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x2B64670", Offset = "0x2B63870", VA = "0x182B64670", Slot = "110")]
		get
		{
			return default(StyleEnum<TextOverflow>);
		}
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x2B67460", Offset = "0x2B66660", VA = "0x182B67460", Slot = "111")]
		set
		{
		}
	}

	[Token(Token = "0x17000449")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002Etop
	{
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x2B64750", Offset = "0x2B63950", VA = "0x182B64750", Slot = "114")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x2B676A0", Offset = "0x2B668A0", VA = "0x182B676A0", Slot = "115")]
		set
		{
		}
	}

	[Token(Token = "0x1700044A")]
	private StyleList<TimeValue> UnityEngine_002EUIElements_002EIStyle_002EtransitionDelay
	{
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x2B64800", Offset = "0x2B63A00", VA = "0x182B64800", Slot = "118")]
		get
		{
			return default(StyleList<TimeValue>);
		}
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x2B678B0", Offset = "0x2B66AB0", VA = "0x182B678B0", Slot = "119")]
		set
		{
		}
	}

	[Token(Token = "0x1700044B")]
	private StyleList<TimeValue> UnityEngine_002EUIElements_002EIStyle_002EtransitionDuration
	{
		[Token(Token = "0x60014BB")]
		[Address(RVA = "0x2B64870", Offset = "0x2B63A70", VA = "0x182B64870", Slot = "120")]
		get
		{
			return default(StyleList<TimeValue>);
		}
		[Token(Token = "0x60014BC")]
		[Address(RVA = "0x2B67930", Offset = "0x2B66B30", VA = "0x182B67930", Slot = "121")]
		set
		{
		}
	}

	[Token(Token = "0x1700044C")]
	private StyleList<StylePropertyName> UnityEngine_002EUIElements_002EIStyle_002EtransitionProperty
	{
		[Token(Token = "0x60014BD")]
		[Address(RVA = "0x2B648E0", Offset = "0x2B63AE0", VA = "0x182B648E0", Slot = "122")]
		get
		{
			return default(StyleList<StylePropertyName>);
		}
		[Token(Token = "0x60014BE")]
		[Address(RVA = "0x2B679B0", Offset = "0x2B66BB0", VA = "0x182B679B0", Slot = "123")]
		set
		{
		}
	}

	[Token(Token = "0x1700044D")]
	private StyleList<EasingFunction> UnityEngine_002EUIElements_002EIStyle_002EtransitionTimingFunction
	{
		[Token(Token = "0x60014BF")]
		[Address(RVA = "0x2B64950", Offset = "0x2B63B50", VA = "0x182B64950", Slot = "124")]
		get
		{
			return default(StyleList<EasingFunction>);
		}
		[Token(Token = "0x60014C0")]
		[Address(RVA = "0x2B67A30", Offset = "0x2B66C30", VA = "0x182B67A30", Slot = "125")]
		set
		{
		}
	}

	[Token(Token = "0x1700044E")]
	private StyleColor UnityEngine_002EUIElements_002EIStyle_002EunityBackgroundImageTintColor
	{
		[Token(Token = "0x60014C1")]
		[Address(RVA = "0x2B64A40", Offset = "0x2B63C40", VA = "0x182B64A40", Slot = "128")]
		get
		{
			return default(StyleColor);
		}
		[Token(Token = "0x60014C2")]
		[Address(RVA = "0x2B67C60", Offset = "0x2B66E60", VA = "0x182B67C60", Slot = "129")]
		set
		{
		}
	}

	[Token(Token = "0x1700044F")]
	private StyleEnum<EditorTextRenderingMode> UnityEngine_002EUIElements_002EIStyle_002EunityEditorTextRenderingMode
	{
		[Token(Token = "0x60014C3")]
		[Address(RVA = "0x2B64A80", Offset = "0x2B63C80", VA = "0x182B64A80", Slot = "130")]
		get
		{
			return default(StyleEnum<EditorTextRenderingMode>);
		}
		[Token(Token = "0x60014C4")]
		[Address(RVA = "0x2B67CC0", Offset = "0x2B66EC0", VA = "0x182B67CC0", Slot = "131")]
		set
		{
		}
	}

	[Token(Token = "0x17000450")]
	private StyleFont UnityEngine_002EUIElements_002EIStyle_002EunityFont
	{
		[Token(Token = "0x60014C5")]
		[Address(RVA = "0x2B64BD0", Offset = "0x2B63DD0", VA = "0x182B64BD0", Slot = "132")]
		get
		{
			return default(StyleFont);
		}
		[Token(Token = "0x60014C6")]
		[Address(RVA = "0x2B67E00", Offset = "0x2B67000", VA = "0x182B67E00", Slot = "133")]
		set
		{
		}
	}

	[Token(Token = "0x17000451")]
	private StyleFontDefinition UnityEngine_002EUIElements_002EIStyle_002EunityFontDefinition
	{
		[Token(Token = "0x60014C7")]
		[Address(RVA = "0x2B64B00", Offset = "0x2B63D00", VA = "0x182B64B00", Slot = "134")]
		get
		{
			return default(StyleFontDefinition);
		}
		[Token(Token = "0x60014C8")]
		[Address(RVA = "0x2B67D30", Offset = "0x2B66F30", VA = "0x182B67D30", Slot = "135")]
		set
		{
		}
	}

	[Token(Token = "0x17000452")]
	private StyleEnum<FontStyle> UnityEngine_002EUIElements_002EIStyle_002EunityFontStyleAndWeight
	{
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x2B64B50", Offset = "0x2B63D50", VA = "0x182B64B50", Slot = "136")]
		get
		{
			return default(StyleEnum<FontStyle>);
		}
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x2B67D90", Offset = "0x2B66F90", VA = "0x182B67D90", Slot = "137")]
		set
		{
		}
	}

	[Token(Token = "0x17000453")]
	private StyleEnum<OverflowClipBox> UnityEngine_002EUIElements_002EIStyle_002EunityOverflowClipBox
	{
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x2B64C10", Offset = "0x2B63E10", VA = "0x182B64C10", Slot = "138")]
		get
		{
			return default(StyleEnum<OverflowClipBox>);
		}
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x2B67E50", Offset = "0x2B67050", VA = "0x182B67E50", Slot = "139")]
		set
		{
		}
	}

	[Token(Token = "0x17000454")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EunityParagraphSpacing
	{
		[Token(Token = "0x60014CD")]
		[Address(RVA = "0x2B64C90", Offset = "0x2B63E90", VA = "0x182B64C90", Slot = "140")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014CE")]
		[Address(RVA = "0x2B67EC0", Offset = "0x2B670C0", VA = "0x182B67EC0", Slot = "141")]
		set
		{
		}
	}

	[Token(Token = "0x17000455")]
	private StyleInt UnityEngine_002EUIElements_002EIStyle_002EunitySliceBottom
	{
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x2B64CD0", Offset = "0x2B63ED0", VA = "0x182B64CD0", Slot = "142")]
		get
		{
			return default(StyleInt);
		}
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x2B67F20", Offset = "0x2B67120", VA = "0x182B67F20", Slot = "143")]
		set
		{
		}
	}

	[Token(Token = "0x17000456")]
	private StyleInt UnityEngine_002EUIElements_002EIStyle_002EunitySliceLeft
	{
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x2B64CE0", Offset = "0x2B63EE0", VA = "0x182B64CE0", Slot = "144")]
		get
		{
			return default(StyleInt);
		}
		[Token(Token = "0x60014D2")]
		[Address(RVA = "0x2B67F70", Offset = "0x2B67170", VA = "0x182B67F70", Slot = "145")]
		set
		{
		}
	}

	[Token(Token = "0x17000457")]
	private StyleInt UnityEngine_002EUIElements_002EIStyle_002EunitySliceRight
	{
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x2B64CF0", Offset = "0x2B63EF0", VA = "0x182B64CF0", Slot = "146")]
		get
		{
			return default(StyleInt);
		}
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x2B67FC0", Offset = "0x2B671C0", VA = "0x182B67FC0", Slot = "147")]
		set
		{
		}
	}

	[Token(Token = "0x17000458")]
	private StyleFloat UnityEngine_002EUIElements_002EIStyle_002EunitySliceScale
	{
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x2B64D00", Offset = "0x2B63F00", VA = "0x182B64D00", Slot = "148")]
		get
		{
			return default(StyleFloat);
		}
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x2B68010", Offset = "0x2B67210", VA = "0x182B68010", Slot = "149")]
		set
		{
		}
	}

	[Token(Token = "0x17000459")]
	private StyleInt UnityEngine_002EUIElements_002EIStyle_002EunitySliceTop
	{
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x2B64D10", Offset = "0x2B63F10", VA = "0x182B64D10", Slot = "150")]
		get
		{
			return default(StyleInt);
		}
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x2B68060", Offset = "0x2B67260", VA = "0x182B68060", Slot = "151")]
		set
		{
		}
	}

	[Token(Token = "0x1700045A")]
	private StyleEnum<SliceType> UnityEngine_002EUIElements_002EIStyle_002EunitySliceType
	{
		[Token(Token = "0x60014D9")]
		[Address(RVA = "0x2B64D20", Offset = "0x2B63F20", VA = "0x182B64D20", Slot = "152")]
		get
		{
			return default(StyleEnum<SliceType>);
		}
		[Token(Token = "0x60014DA")]
		[Address(RVA = "0x2B680B0", Offset = "0x2B672B0", VA = "0x182B680B0", Slot = "153")]
		set
		{
		}
	}

	[Token(Token = "0x1700045B")]
	private StyleEnum<TextAnchor> UnityEngine_002EUIElements_002EIStyle_002EunityTextAlign
	{
		[Token(Token = "0x60014DB")]
		[Address(RVA = "0x2B64DA0", Offset = "0x2B63FA0", VA = "0x182B64DA0", Slot = "154")]
		get
		{
			return default(StyleEnum<TextAnchor>);
		}
		[Token(Token = "0x60014DC")]
		[Address(RVA = "0x2B68120", Offset = "0x2B67320", VA = "0x182B68120", Slot = "155")]
		set
		{
		}
	}

	[Token(Token = "0x1700045C")]
	private StyleEnum<TextGeneratorType> UnityEngine_002EUIElements_002EIStyle_002EunityTextGenerator
	{
		[Token(Token = "0x60014DD")]
		[Address(RVA = "0x2B64E20", Offset = "0x2B64020", VA = "0x182B64E20", Slot = "156")]
		get
		{
			return default(StyleEnum<TextGeneratorType>);
		}
		[Token(Token = "0x60014DE")]
		[Address(RVA = "0x2B68190", Offset = "0x2B67390", VA = "0x182B68190", Slot = "157")]
		set
		{
		}
	}

	[Token(Token = "0x1700045D")]
	private StyleColor UnityEngine_002EUIElements_002EIStyle_002EunityTextOutlineColor
	{
		[Token(Token = "0x60014DF")]
		[Address(RVA = "0x2B64EA0", Offset = "0x2B640A0", VA = "0x182B64EA0", Slot = "158")]
		get
		{
			return default(StyleColor);
		}
		[Token(Token = "0x60014E0")]
		[Address(RVA = "0x2B68200", Offset = "0x2B67400", VA = "0x182B68200", Slot = "159")]
		set
		{
		}
	}

	[Token(Token = "0x1700045E")]
	private StyleFloat UnityEngine_002EUIElements_002EIStyle_002EunityTextOutlineWidth
	{
		[Token(Token = "0x60014E1")]
		[Address(RVA = "0x2B64EE0", Offset = "0x2B640E0", VA = "0x182B64EE0", Slot = "160")]
		get
		{
			return default(StyleFloat);
		}
		[Token(Token = "0x60014E2")]
		[Address(RVA = "0x2B68260", Offset = "0x2B67460", VA = "0x182B68260", Slot = "161")]
		set
		{
		}
	}

	[Token(Token = "0x1700045F")]
	private StyleEnum<TextOverflowPosition> UnityEngine_002EUIElements_002EIStyle_002EunityTextOverflowPosition
	{
		[Token(Token = "0x60014E3")]
		[Address(RVA = "0x2B64EF0", Offset = "0x2B640F0", VA = "0x182B64EF0", Slot = "162")]
		get
		{
			return default(StyleEnum<TextOverflowPosition>);
		}
		[Token(Token = "0x60014E4")]
		[Address(RVA = "0x2B682B0", Offset = "0x2B674B0", VA = "0x182B682B0", Slot = "163")]
		set
		{
		}
	}

	[Token(Token = "0x17000460")]
	private StyleEnum<Visibility> UnityEngine_002EUIElements_002EIStyle_002Evisibility
	{
		[Token(Token = "0x60014E5")]
		[Address(RVA = "0x2B64F70", Offset = "0x2B64170", VA = "0x182B64F70", Slot = "164")]
		get
		{
			return default(StyleEnum<Visibility>);
		}
		[Token(Token = "0x60014E6")]
		[Address(RVA = "0x2B68320", Offset = "0x2B67520", VA = "0x182B68320", Slot = "165")]
		set
		{
		}
	}

	[Token(Token = "0x17000461")]
	private StyleEnum<WhiteSpace> UnityEngine_002EUIElements_002EIStyle_002EwhiteSpace
	{
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x2B64FF0", Offset = "0x2B641F0", VA = "0x182B64FF0", Slot = "166")]
		get
		{
			return default(StyleEnum<WhiteSpace>);
		}
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x2B68390", Offset = "0x2B67590", VA = "0x182B68390", Slot = "167")]
		set
		{
		}
	}

	[Token(Token = "0x17000462")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002Ewidth
	{
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x2B65070", Offset = "0x2B64270", VA = "0x182B65070", Slot = "168")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x2B68400", Offset = "0x2B67600", VA = "0x182B68400", Slot = "169")]
		set
		{
		}
	}

	[Token(Token = "0x17000463")]
	private StyleLength UnityEngine_002EUIElements_002EIStyle_002EwordSpacing
	{
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x2B650B0", Offset = "0x2B642B0", VA = "0x182B650B0", Slot = "170")]
		get
		{
			return default(StyleLength);
		}
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x2B684B0", Offset = "0x2B676B0", VA = "0x182B684B0", Slot = "171")]
		set
		{
		}
	}

	[Token(Token = "0x17000464")]
	private VisualElement ve
	{
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000465")]
	private StyleCursor UnityEngine_002EUIElements_002EIStyle_002Ecursor
	{
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x2B63D50", Offset = "0x2B62F50", VA = "0x182B63D50", Slot = "50")]
		get
		{
			return default(StyleCursor);
		}
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x2B65DA0", Offset = "0x2B64FA0", VA = "0x182B65DA0", Slot = "51")]
		set
		{
		}
	}

	[Token(Token = "0x17000466")]
	private StyleTextShadow UnityEngine_002EUIElements_002EIStyle_002EtextShadow
	{
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x2B646F0", Offset = "0x2B638F0", VA = "0x182B646F0", Slot = "112")]
		get
		{
			return default(StyleTextShadow);
		}
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x2B674D0", Offset = "0x2B666D0", VA = "0x182B674D0", Slot = "113")]
		set
		{
		}
	}

	[Token(Token = "0x17000467")]
	private StyleBackgroundSize UnityEngine_002EUIElements_002EIStyle_002EbackgroundSize
	{
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x2B63A20", Offset = "0x2B62C20", VA = "0x182B63A20", Slot = "20")]
		get
		{
			return default(StyleBackgroundSize);
		}
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x2B655E0", Offset = "0x2B647E0", VA = "0x182B655E0", Slot = "21")]
		set
		{
		}
	}

	[Token(Token = "0x17000468")]
	private StyleTransformOrigin UnityEngine_002EUIElements_002EIStyle_002EtransformOrigin
	{
		[Token(Token = "0x60014FD")]
		[Address(RVA = "0x2B64790", Offset = "0x2B63990", VA = "0x182B64790", Slot = "116")]
		get
		{
			return default(StyleTransformOrigin);
		}
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x2B67750", Offset = "0x2B66950", VA = "0x182B67750", Slot = "117")]
		set
		{
		}
	}

	[Token(Token = "0x17000469")]
	private StyleTranslate UnityEngine_002EUIElements_002EIStyle_002Etranslate
	{
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x2B649C0", Offset = "0x2B63BC0", VA = "0x182B649C0", Slot = "126")]
		get
		{
			return default(StyleTranslate);
		}
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x2B67AB0", Offset = "0x2B66CB0", VA = "0x182B67AB0", Slot = "127")]
		set
		{
		}
	}

	[Token(Token = "0x1700046A")]
	private StyleRotate UnityEngine_002EUIElements_002EIStyle_002Erotate
	{
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x2B64590", Offset = "0x2B63790", VA = "0x182B64590", Slot = "106")]
		get
		{
			return default(StyleRotate);
		}
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x2B67140", Offset = "0x2B66340", VA = "0x182B67140", Slot = "107")]
		set
		{
		}
	}

	[Token(Token = "0x1700046B")]
	private StyleScale UnityEngine_002EUIElements_002EIStyle_002Escale
	{
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x2B64610", Offset = "0x2B63810", VA = "0x182B64610", Slot = "108")]
		get
		{
			return default(StyleScale);
		}
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x2B672F0", Offset = "0x2B664F0", VA = "0x182B672F0", Slot = "109")]
		set
		{
		}
	}

	[Token(Token = "0x60014EF")]
	[Address(RVA = "0x2B68590", Offset = "0x2B67790", VA = "0x182B68590")]
	public InlineStyleAccess(VisualElement ve)
	{
	}

	[Token(Token = "0x60014F0")]
	[Address(RVA = "0x2B60EC0", Offset = "0x2B600C0", VA = "0x182B60EC0", Slot = "1")]
	~InlineStyleAccess()
	{
	}

	[Token(Token = "0x60014F1")]
	[Address(RVA = "0x2B61850", Offset = "0x2B60A50", VA = "0x182B61850")]
	public void SetInlineRule(StyleSheet sheet, StyleRule rule)
	{
	}

	[Token(Token = "0x60014F2")]
	[Address(RVA = "0x2B60F80", Offset = "0x2B60180", VA = "0x182B60F80")]
	public bool IsValueSet(StylePropertyId id)
	{
		return default(bool);
	}

	[Token(Token = "0x60014F3")]
	[Address(RVA = "0x2B5ED70", Offset = "0x2B5DF70", VA = "0x182B5ED70")]
	public void ApplyInlineStyles(ref ComputedStyle computedStyle)
	{
	}

	[Token(Token = "0x60014FA")]
	private StyleList<T> GetStyleList<T>(StylePropertyId id)
	{
		return default(StyleList<T>);
	}

	[Token(Token = "0x60014FB")]
	[Address(RVA = "0x2B61F60", Offset = "0x2B61160", VA = "0x182B61F60")]
	private void SetStyleValueManaged(StyleValueManaged value)
	{
	}

	[Token(Token = "0x60014FC")]
	[Address(RVA = "0x2B63610", Offset = "0x2B62810", VA = "0x182B63610")]
	private bool TryGetStyleValueManaged(StylePropertyId id, ref StyleValueManaged value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001505")]
	[Address(RVA = "0x2B62170", Offset = "0x2B61370", VA = "0x182B62170")]
	private bool SetStyleValue(StylePropertyId id, StyleBackgroundPosition inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6001506")]
	[Address(RVA = "0x2B62780", Offset = "0x2B61980", VA = "0x182B62780")]
	private bool SetStyleValue(StylePropertyId id, StyleBackgroundRepeat inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6001507")]
	[Address(RVA = "0x2B622F0", Offset = "0x2B614F0", VA = "0x182B622F0")]
	private bool SetStyleValue(StylePropertyId id, StyleLength inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6001508")]
	[Address(RVA = "0x2B62E30", Offset = "0x2B62030", VA = "0x182B62E30")]
	private bool SetStyleValue(StylePropertyId id, StyleFloat inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6001509")]
	[Address(RVA = "0x2B62AB0", Offset = "0x2B61CB0", VA = "0x182B62AB0")]
	private bool SetStyleValue(StylePropertyId id, StyleInt inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600150A")]
	[Address(RVA = "0x2B628F0", Offset = "0x2B61AF0", VA = "0x182B628F0")]
	private bool SetStyleValue(StylePropertyId id, StyleColor inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600150B")]
	private bool SetStyleValue<T>(StylePropertyId id, StyleEnum<T> inlineValue) where T : struct, IConvertible
	{
		return default(bool);
	}

	[Token(Token = "0x600150C")]
	[Address(RVA = "0x2B62F70", Offset = "0x2B62170", VA = "0x182B62F70")]
	private bool SetStyleValue(StylePropertyId id, StyleBackground inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600150D")]
	[Address(RVA = "0x2B62450", Offset = "0x2B61650", VA = "0x182B62450")]
	private bool SetStyleValue(StylePropertyId id, StyleFontDefinition inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600150E")]
	[Address(RVA = "0x2B62C00", Offset = "0x2B61E00", VA = "0x182B62C00")]
	private bool SetStyleValue(StylePropertyId id, StyleFont inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600150F")]
	private bool SetStyleValue<T>(StylePropertyId id, StyleList<T> inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6001510")]
	[Address(RVA = "0x2B614C0", Offset = "0x2B606C0", VA = "0x182B614C0")]
	private bool SetInlineCursor(StyleCursor inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6001511")]
	[Address(RVA = "0x2B5FCF0", Offset = "0x2B5EEF0", VA = "0x182B5FCF0")]
	private void ApplyStyleCursor(StyleCursor cursor)
	{
	}

	[Token(Token = "0x6001512")]
	[Address(RVA = "0x2B61A90", Offset = "0x2B60C90", VA = "0x182B61A90")]
	private bool SetInlineTextShadow(StyleTextShadow inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6001513")]
	[Address(RVA = "0x2B603E0", Offset = "0x2B5F5E0", VA = "0x182B603E0")]
	private void ApplyStyleTextShadow(StyleTextShadow textShadow)
	{
	}

	[Token(Token = "0x6001514")]
	[Address(RVA = "0x2B61C40", Offset = "0x2B60E40", VA = "0x182B61C40")]
	private bool SetInlineTransformOrigin(StyleTransformOrigin inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6001515")]
	[Address(RVA = "0x2B60630", Offset = "0x2B5F830", VA = "0x182B60630")]
	private void ApplyStyleTransformOrigin(StyleTransformOrigin transformOrigin)
	{
	}

	[Token(Token = "0x6001516")]
	[Address(RVA = "0x2B61D90", Offset = "0x2B60F90", VA = "0x182B61D90")]
	private bool SetInlineTranslate(StyleTranslate inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6001517")]
	[Address(RVA = "0x2B60870", Offset = "0x2B5FA70", VA = "0x182B60870")]
	private void ApplyStyleTranslate(StyleTranslate translate)
	{
	}

	[Token(Token = "0x6001518")]
	[Address(RVA = "0x2B61920", Offset = "0x2B60B20", VA = "0x182B61920")]
	private bool SetInlineScale(StyleScale inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6001519")]
	[Address(RVA = "0x2B601B0", Offset = "0x2B5F3B0", VA = "0x182B601B0")]
	private void ApplyStyleScale(StyleScale scale)
	{
	}

	[Token(Token = "0x600151A")]
	[Address(RVA = "0x2B61680", Offset = "0x2B60880", VA = "0x182B61680")]
	private bool SetInlineRotate(StyleRotate inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600151B")]
	[Address(RVA = "0x2B5FEF0", Offset = "0x2B5F0F0", VA = "0x182B5FEF0")]
	private void ApplyStyleRotate(StyleRotate rotate)
	{
	}

	[Token(Token = "0x600151C")]
	[Address(RVA = "0x2B61360", Offset = "0x2B60560", VA = "0x182B61360")]
	private bool SetInlineBackgroundSize(StyleBackgroundSize inlineValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600151D")]
	[Address(RVA = "0x2B5FAB0", Offset = "0x2B5ECB0", VA = "0x182B5FAB0")]
	private void ApplyStyleBackgroundSize(StyleBackgroundSize backgroundSize)
	{
	}

	[Token(Token = "0x600151E")]
	[Address(RVA = "0x2B60AC0", Offset = "0x2B5FCC0", VA = "0x182B60AC0")]
	private void ApplyStyleValue(StyleValue value)
	{
	}

	[Token(Token = "0x600151F")]
	[Address(RVA = "0x2B60DE0", Offset = "0x2B5FFE0", VA = "0x182B60DE0")]
	private void ApplyStyleValue(StyleValueManaged value)
	{
	}

	[Token(Token = "0x6001520")]
	[Address(RVA = "0x2B61260", Offset = "0x2B60460", VA = "0x182B61260")]
	private bool RemoveInlineStyle(StylePropertyId id)
	{
		return default(bool);
	}

	[Token(Token = "0x6001521")]
	[Address(RVA = "0x2B5EB40", Offset = "0x2B5DD40", VA = "0x182B5EB40")]
	private void ApplyFromComputedStyle(StylePropertyId id, ref ComputedStyle newStyle)
	{
	}

	[Token(Token = "0x6001522")]
	[Address(RVA = "0x2B63500", Offset = "0x2B62700", VA = "0x182B63500")]
	public bool TryGetInlineCursor(ref StyleCursor value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001523")]
	[Address(RVA = "0x2B635A0", Offset = "0x2B627A0", VA = "0x182B635A0")]
	public bool TryGetInlineTextShadow(ref StyleTextShadow value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001524")]
	[Address(RVA = "0x2B635C0", Offset = "0x2B627C0", VA = "0x182B635C0")]
	public bool TryGetInlineTransformOrigin(ref StyleTransformOrigin value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001525")]
	[Address(RVA = "0x2B635E0", Offset = "0x2B627E0", VA = "0x182B635E0")]
	public bool TryGetInlineTranslate(ref StyleTranslate value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001526")]
	[Address(RVA = "0x2B63540", Offset = "0x2B62740", VA = "0x182B63540")]
	public bool TryGetInlineRotate(ref StyleRotate value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001527")]
	[Address(RVA = "0x2B63570", Offset = "0x2B62770", VA = "0x182B63570")]
	public bool TryGetInlineScale(ref StyleScale value)
	{
		return default(bool);
	}

	[Token(Token = "0x6001528")]
	[Address(RVA = "0x2B634D0", Offset = "0x2B626D0", VA = "0x182B634D0")]
	public bool TryGetInlineBackgroundSize(ref StyleBackgroundSize value)
	{
		return default(bool);
	}
}
