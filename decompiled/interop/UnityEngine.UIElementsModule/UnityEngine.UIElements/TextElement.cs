using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000461")]
public class TextElement : BindableElement, INotifyValueChanged<string>, ITextEdition, IExperimentalFeatures, ITextSelection
{
	[Token(Token = "0x2000462")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<TextElement, UxmlTraits>
	{
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x2A1CEC0", Offset = "0x2A1C0C0", VA = "0x182A1CEC0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000463")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x90")]
		private UxmlStringAttributeDescription m_Text;

		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x98")]
		private UxmlBoolAttributeDescription m_EnableRichText;

		[Token(Token = "0x4000ED6")]
		[FieldOffset(Offset = "0xA0")]
		private UxmlBoolAttributeDescription m_EmojiFallbackSupport;

		[Token(Token = "0x4000ED7")]
		[FieldOffset(Offset = "0xA8")]
		private UxmlBoolAttributeDescription m_ParseEscapeSequences;

		[Token(Token = "0x4000ED8")]
		[FieldOffset(Offset = "0xB0")]
		private UxmlBoolAttributeDescription m_Selectable;

		[Token(Token = "0x4000ED9")]
		[FieldOffset(Offset = "0xB8")]
		private UxmlBoolAttributeDescription m_SelectWordByDoubleClick;

		[Token(Token = "0x4000EDA")]
		[FieldOffset(Offset = "0xC0")]
		private UxmlBoolAttributeDescription m_SelectLineByTripleClick;

		[Token(Token = "0x4000EDB")]
		[FieldOffset(Offset = "0xC8")]
		private UxmlBoolAttributeDescription m_DisplayTooltipWhenElided;

		[Token(Token = "0x600211F")]
		[Address(RVA = "0x2A1F490", Offset = "0x2A1E690", VA = "0x182A1F490", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6002120")]
		[Address(RVA = "0x2A1FA30", Offset = "0x2A1EC30", VA = "0x182A1FA30")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000E8F")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId displayTooltipWhenElidedProperty;

	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId emojiFallbackSupportProperty;

	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId enableRichTextProperty;

	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x1C8")]
	internal static readonly BindingId isElidedProperty;

	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x260")]
	internal static readonly BindingId parseEscapeSequencesProperty;

	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x2F8")]
	internal static readonly BindingId textProperty;

	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x390")]
	internal static readonly BindingId valueProperty;

	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x428")]
	public static readonly string ussClassName;

	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x430")]
	public static readonly string selectableUssClassName;

	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0x4C0")]
	private string m_Text;

	[Token(Token = "0x4000E9A")]
	[FieldOffset(Offset = "0x4C8")]
	private bool m_EnableRichText;

	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0x4C9")]
	private bool m_EmojiFallbackSupport;

	[Token(Token = "0x4000E9C")]
	[FieldOffset(Offset = "0x4CA")]
	private bool m_ParseEscapeSequences;

	[Token(Token = "0x4000E9D")]
	[FieldOffset(Offset = "0x4CB")]
	private bool m_DisplayTooltipWhenElided;

	[Token(Token = "0x4000E9F")]
	[FieldOffset(Offset = "0x438")]
	internal static readonly string k_EllipsisText;

	[Token(Token = "0x4000EA0")]
	[FieldOffset(Offset = "0x4D0")]
	internal string elidedText;

	[Token(Token = "0x4000EA1")]
	[FieldOffset(Offset = "0x4D8")]
	private bool m_WasElided;

	[Token(Token = "0x4000EA2")]
	[FieldOffset(Offset = "0x440")]
	internal static readonly BindingId autoCorrectionProperty;

	[Token(Token = "0x4000EA3")]
	[FieldOffset(Offset = "0x4D8")]
	internal static readonly BindingId hideMobileInputProperty;

	[Token(Token = "0x4000EA4")]
	[FieldOffset(Offset = "0x570")]
	internal static readonly BindingId keyboardTypeProperty;

	[Token(Token = "0x4000EA5")]
	[FieldOffset(Offset = "0x608")]
	internal static readonly BindingId isReadOnlyProperty;

	[Token(Token = "0x4000EA6")]
	[FieldOffset(Offset = "0x6A0")]
	internal static readonly BindingId isPasswordProperty;

	[Token(Token = "0x4000EA7")]
	[FieldOffset(Offset = "0x738")]
	internal static readonly BindingId maxLengthProperty;

	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0x7D0")]
	internal static readonly BindingId maskCharProperty;

	[Token(Token = "0x4000EAA")]
	[FieldOffset(Offset = "0x4E8")]
	internal bool isInputField;

	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x4E9")]
	private bool m_Multiline;

	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x4F0")]
	internal TouchScreenKeyboard m_TouchScreenKeyboard;

	[Token(Token = "0x4000EAD")]
	[FieldOffset(Offset = "0x4F8")]
	internal Action<bool> onIsReadOnlyChanged;

	[Token(Token = "0x4000EAE")]
	[FieldOffset(Offset = "0x500")]
	internal TouchScreenKeyboardType m_KeyboardType;

	[Token(Token = "0x4000EAF")]
	[FieldOffset(Offset = "0x504")]
	private bool m_HideMobileInput;

	[Token(Token = "0x4000EB0")]
	[FieldOffset(Offset = "0x505")]
	private bool m_IsReadOnly;

	[Token(Token = "0x4000EB1")]
	[FieldOffset(Offset = "0x508")]
	private int m_MaxLength;

	[Token(Token = "0x4000EB2")]
	[FieldOffset(Offset = "0x510")]
	private string m_PlaceholderText;

	[Token(Token = "0x4000EBB")]
	private const string ZeroWidthSpace = "\u200b";

	[Token(Token = "0x4000EBC")]
	[FieldOffset(Offset = "0x558")]
	private string m_RenderedText;

	[Token(Token = "0x4000EBD")]
	[FieldOffset(Offset = "0x560")]
	private string m_OriginalText;

	[Token(Token = "0x4000EBE")]
	[FieldOffset(Offset = "0x568")]
	private char m_MaskChar;

	[Token(Token = "0x4000EBF")]
	[FieldOffset(Offset = "0x56A")]
	private bool m_IsPassword;

	[Token(Token = "0x4000EC0")]
	[FieldOffset(Offset = "0x56B")]
	private bool m_HidePlaceholderTextOnFocus;

	[Token(Token = "0x4000EC1")]
	[FieldOffset(Offset = "0x56C")]
	private bool m_AutoCorrection;

	[Token(Token = "0x4000EC2")]
	[FieldOffset(Offset = "0x868")]
	internal static readonly BindingId isSelectableProperty;

	[Token(Token = "0x4000EC3")]
	[FieldOffset(Offset = "0x900")]
	internal static readonly BindingId cursorIndexProperty;

	[Token(Token = "0x4000EC4")]
	[FieldOffset(Offset = "0x998")]
	internal static readonly BindingId selectIndexProperty;

	[Token(Token = "0x4000EC5")]
	[FieldOffset(Offset = "0xA30")]
	internal static readonly BindingId doubleClickSelectsWordProperty;

	[Token(Token = "0x4000EC6")]
	[FieldOffset(Offset = "0xAC8")]
	internal static readonly BindingId tripleClickSelectsLineProperty;

	[Token(Token = "0x4000EC7")]
	[FieldOffset(Offset = "0xB60")]
	internal static readonly BindingId cursorPositionProperty;

	[Token(Token = "0x4000EC8")]
	[FieldOffset(Offset = "0xBF8")]
	internal static readonly BindingId selectAllOnFocusProperty;

	[Token(Token = "0x4000EC9")]
	[FieldOffset(Offset = "0xC90")]
	internal static readonly BindingId selectAllOnMouseUpProperty;

	[Token(Token = "0x4000ECA")]
	[FieldOffset(Offset = "0xD28")]
	internal static readonly BindingId selectionProperty;

	[Token(Token = "0x4000ECB")]
	[FieldOffset(Offset = "0x570")]
	private TextSelectingManipulator m_SelectingManipulator;

	[Token(Token = "0x4000ECC")]
	[FieldOffset(Offset = "0x578")]
	private bool m_IsSelectable;

	[Token(Token = "0x4000ECD")]
	[FieldOffset(Offset = "0x579")]
	private bool m_DoubleClickSelectsWord;

	[Token(Token = "0x4000ECE")]
	[FieldOffset(Offset = "0x57A")]
	private bool m_TripleClickSelectsLine;

	[Token(Token = "0x4000ECF")]
	[FieldOffset(Offset = "0x57B")]
	private bool m_SelectAllOnFocus;

	[Token(Token = "0x4000ED0")]
	[FieldOffset(Offset = "0x57C")]
	private bool m_SelectAllOnMouseUp;

	[Token(Token = "0x4000ED1")]
	[FieldOffset(Offset = "0x580")]
	private Color m_SelectionColor;

	[Token(Token = "0x4000ED2")]
	[FieldOffset(Offset = "0x590")]
	private Color m_CursorColor;

	[Token(Token = "0x4000ED3")]
	[FieldOffset(Offset = "0x5A0")]
	private float m_CursorWidth;

	[Token(Token = "0x170008A2")]
	internal UITKTextHandle uitkTextHandle
	{
		[Token(Token = "0x6002088")]
		[Address(RVA = "0x29FCCC0", Offset = "0x29FBEC0", VA = "0x1829FCCC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002089")]
		[Address(RVA = "0x29FCCE0", Offset = "0x29FBEE0", VA = "0x1829FCCE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008A3")]
	[CreateProperty]
	public virtual string text
	{
		[Token(Token = "0x600208D")]
		[Address(RVA = "0x2A11300", Offset = "0x2A10500", VA = "0x182A11300", Slot = "201")]
		get
		{
			return null;
		}
		[Token(Token = "0x600208E")]
		[Address(RVA = "0x2A11C60", Offset = "0x2A10E60", VA = "0x182A11C60", Slot = "202")]
		set
		{
		}
	}

	[Token(Token = "0x170008A4")]
	[CreateProperty]
	public bool enableRichText
	{
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x2A109A0", Offset = "0x2A0FBA0", VA = "0x182A109A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x2A11690", Offset = "0x2A10890", VA = "0x182A11690")]
		set
		{
		}
	}

	[Token(Token = "0x170008A5")]
	[CreateProperty]
	public bool emojiFallbackSupport
	{
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x2A10990", Offset = "0x2A0FB90", VA = "0x182A10990")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x2A11600", Offset = "0x2A10800", VA = "0x182A11600")]
		set
		{
		}
	}

	[Token(Token = "0x170008A6")]
	[CreateProperty]
	public bool parseEscapeSequences
	{
		[Token(Token = "0x6002093")]
		[Address(RVA = "0x2A10CE0", Offset = "0x2A0FEE0", VA = "0x182A10CE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002094")]
		[Address(RVA = "0x2A11A30", Offset = "0x2A10C30", VA = "0x182A11A30")]
		set
		{
		}
	}

	[Token(Token = "0x170008A7")]
	[CreateProperty]
	public bool displayTooltipWhenElided
	{
		[Token(Token = "0x6002095")]
		[Address(RVA = "0x2A108D0", Offset = "0x2A0FAD0", VA = "0x182A108D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002096")]
		[Address(RVA = "0x2A11510", Offset = "0x2A10710", VA = "0x182A11510")]
		set
		{
		}
	}

	[Token(Token = "0x170008A8")]
	[CreateProperty(ReadOnly = true)]
	public bool isElided
	{
		[Token(Token = "0x6002097")]
		[Address(RVA = "0x2A10A80", Offset = "0x2A0FC80", VA = "0x182A10A80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x2A11780", Offset = "0x2A10980", VA = "0x182A11780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170008A9")]
	internal bool hasFocus
	{
		[Token(Token = "0x60020A0")]
		[Address(RVA = "0x2A109B0", Offset = "0x2A0FBB0", VA = "0x182A109B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008AA")]
	private string UnityEngine_002EUIElements_002EINotifyValueChanged_003CSystem_002EString_003E_002Evalue
	{
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x2A0D980", Offset = "0x2A0CB80", VA = "0x182A0D980", Slot = "139")]
		get
		{
			return null;
		}
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x2A0D9A0", Offset = "0x2A0CBA0", VA = "0x182A0D9A0", Slot = "140")]
		set
		{
		}
	}

	[Token(Token = "0x170008AB")]
	[CreateProperty]
	private string value
	{
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x2A11390", Offset = "0x2A10590", VA = "0x182A11390")]
		get
		{
			return null;
		}
		[Token(Token = "0x60020A6")]
		[Address(RVA = "0x2A11D10", Offset = "0x2A10F10", VA = "0x182A11D10")]
		set
		{
		}
	}

	[Token(Token = "0x170008AC")]
	internal ITextEdition edition
	{
		[Token(Token = "0x60020A8")]
		[Address(RVA = "0x52BB60", Offset = "0x52AD60", VA = "0x18052BB60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008AD")]
	internal TextEditingManipulator editingManipulator
	{
		[Token(Token = "0x60020A9")]
		[Address(RVA = "0x159B2E0", Offset = "0x159A4E0", VA = "0x18159B2E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60020AA")]
		[Address(RVA = "0x141FD60", Offset = "0x141EF60", VA = "0x18141FD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170008AE")]
	private bool UnityEngine_002EUIElements_002EITextEdition_002Emultiline
	{
		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x23D0DA0", Offset = "0x23CFFA0", VA = "0x1823D0DA0", Slot = "142")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x2A0E4A0", Offset = "0x2A0D6A0", VA = "0x182A0E4A0", Slot = "143")]
		set
		{
		}
	}

	[Token(Token = "0x170008AF")]
	private TouchScreenKeyboard UnityEngine_002EUIElements_002EITextEdition_002EtouchScreenKeyboard
	{
		[Token(Token = "0x60020AD")]
		[Address(RVA = "0x23D0AC0", Offset = "0x23CFCC0", VA = "0x1823D0AC0", Slot = "178")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008B0")]
	private TouchScreenKeyboardType UnityEngine_002EUIElements_002EITextEdition_002EkeyboardType
	{
		[Token(Token = "0x60020AE")]
		[Address(RVA = "0x137AB30", Offset = "0x1379D30", VA = "0x18137AB30", Slot = "179")]
		get
		{
			return default(TouchScreenKeyboardType);
		}
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x2A0E280", Offset = "0x2A0D480", VA = "0x182A0E280", Slot = "180")]
		set
		{
		}
	}

	[Token(Token = "0x170008B1")]
	[CreateProperty]
	private TouchScreenKeyboardType keyboardType
	{
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x2A10B80", Offset = "0x2A0FD80", VA = "0x182A10B80")]
		get
		{
			return default(TouchScreenKeyboardType);
		}
		[Token(Token = "0x60020B1")]
		[Address(RVA = "0x2A118B0", Offset = "0x2A10AB0", VA = "0x182A118B0")]
		set
		{
		}
	}

	[Token(Token = "0x170008B2")]
	private bool UnityEngine_002EUIElements_002EITextEdition_002EhideMobileInput
	{
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x2A0DE80", Offset = "0x2A0D080", VA = "0x182A0DE80", Slot = "176")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020B3")]
		[Address(RVA = "0x2A0E030", Offset = "0x2A0D230", VA = "0x182A0E030", Slot = "177")]
		set
		{
		}
	}

	[Token(Token = "0x170008B3")]
	[CreateProperty]
	private bool hideMobileInput
	{
		[Token(Token = "0x60020B4")]
		[Address(RVA = "0x2A10A30", Offset = "0x2A0FC30", VA = "0x182A10A30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020B5")]
		[Address(RVA = "0x2A11720", Offset = "0x2A10920", VA = "0x182A11720")]
		set
		{
		}
	}

	[Token(Token = "0x170008B4")]
	private bool UnityEngine_002EUIElements_002EITextEdition_002EisReadOnly
	{
		[Token(Token = "0x60020B6")]
		[Address(RVA = "0x2A0DEF0", Offset = "0x2A0D0F0", VA = "0x182A0DEF0", Slot = "144")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x2A0E170", Offset = "0x2A0D370", VA = "0x182A0E170", Slot = "145")]
		set
		{
		}
	}

	[Token(Token = "0x170008B5")]
	[CreateProperty]
	private bool isReadOnly
	{
		[Token(Token = "0x60020B8")]
		[Address(RVA = "0x2A10AE0", Offset = "0x2A0FCE0", VA = "0x182A10AE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020B9")]
		[Address(RVA = "0x2A117F0", Offset = "0x2A109F0", VA = "0x182A117F0")]
		set
		{
		}
	}

	[Token(Token = "0x170008B6")]
	private int UnityEngine_002EUIElements_002EITextEdition_002EmaxLength
	{
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x2A0DF30", Offset = "0x2A0D130", VA = "0x182A0DF30", Slot = "146")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x2A0E3C0", Offset = "0x2A0D5C0", VA = "0x182A0E3C0", Slot = "147")]
		set
		{
		}
	}

	[Token(Token = "0x170008B7")]
	[CreateProperty]
	private int maxLength
	{
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x2A10C90", Offset = "0x2A0FE90", VA = "0x182A10C90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60020C6")]
		[Address(RVA = "0x2A119D0", Offset = "0x2A10BD0", VA = "0x182A119D0")]
		set
		{
		}
	}

	[Token(Token = "0x170008B8")]
	private string UnityEngine_002EUIElements_002EITextEdition_002Eplaceholder
	{
		[Token(Token = "0x60020C7")]
		[Address(RVA = "0x2A0DF40", Offset = "0x2A0D140", VA = "0x182A0DF40", Slot = "148")]
		get
		{
			return null;
		}
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x2A0E520", Offset = "0x2A0D720", VA = "0x182A0E520", Slot = "149")]
		set
		{
		}
	}

	[Token(Token = "0x170008B9")]
	private bool UnityEngine_002EUIElements_002EITextEdition_002EisDelayed
	{
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x2A0DED0", Offset = "0x2A0D0D0", VA = "0x182A0DED0", Slot = "150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x2A0E0D0", Offset = "0x2A0D2D0", VA = "0x182A0E0D0", Slot = "151")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008BA")]
	private Func<char, bool> UnityEngine_002EUIElements_002EITextEdition_002EAcceptCharacter
	{
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x2A0DE60", Offset = "0x2A0D060", VA = "0x182A0DE60", Slot = "154")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x2A0DF50", Offset = "0x2A0D150", VA = "0x182A0DF50", Slot = "155")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008BB")]
	private Action<bool> UnityEngine_002EUIElements_002EITextEdition_002EUpdateScrollOffset
	{
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x1376BC0", Offset = "0x1375DC0", VA = "0x181376BC0", Slot = "156")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x2A0DF70", Offset = "0x2A0D170", VA = "0x182A0DF70", Slot = "157")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008BC")]
	private Action UnityEngine_002EUIElements_002EITextEdition_002EUpdateValueFromText
	{
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x1376BA0", Offset = "0x1375DA0", VA = "0x181376BA0", Slot = "158")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x2A0DF90", Offset = "0x2A0D190", VA = "0x182A0DF90", Slot = "159")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008BD")]
	private Action UnityEngine_002EUIElements_002EITextEdition_002EUpdateTextFromValue
	{
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x1376BB0", Offset = "0x1375DB0", VA = "0x181376BB0", Slot = "160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x14CA5C0", Offset = "0x14C97C0", VA = "0x1814CA5C0", Slot = "161")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008BE")]
	private Action UnityEngine_002EUIElements_002EITextEdition_002EMoveFocusToCompositeRoot
	{
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x1376B90", Offset = "0x1375D90", VA = "0x181376B90", Slot = "162")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x14CA5E0", Offset = "0x14C97E0", VA = "0x1814CA5E0", Slot = "163")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008BF")]
	internal Action OnPlaceholderChanged
	{
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x14CA280", Offset = "0x14C9480", VA = "0x1814CA280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x14CABC0", Offset = "0x14C9DC0", VA = "0x1814CABC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008C0")]
	private Func<string> UnityEngine_002EUIElements_002EITextEdition_002EGetDefaultValueType
	{
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x14CA1D0", Offset = "0x14C93D0", VA = "0x1814CA1D0", Slot = "164")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x14CA5A0", Offset = "0x14C97A0", VA = "0x1814CA5A0", Slot = "165")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170008C1")]
	private char UnityEngine_002EUIElements_002EITextEdition_002EmaskChar
	{
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x2A0DF20", Offset = "0x2A0D120", VA = "0x182A0DF20", Slot = "168")]
		get
		{
			return default(char);
		}
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x2A0E300", Offset = "0x2A0D500", VA = "0x182A0E300", Slot = "169")]
		set
		{
		}
	}

	[Token(Token = "0x170008C2")]
	[CreateProperty]
	private char maskChar
	{
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x2A10BD0", Offset = "0x2A0FDD0", VA = "0x182A10BD0")]
		get
		{
			return default(char);
		}
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x2A11910", Offset = "0x2A10B10", VA = "0x182A11910")]
		set
		{
		}
	}

	[Token(Token = "0x170008C3")]
	private char effectiveMaskChar
	{
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x2A10930", Offset = "0x2A0FB30", VA = "0x182A10930")]
		get
		{
			return default(char);
		}
	}

	[Token(Token = "0x170008C4")]
	private bool UnityEngine_002EUIElements_002EITextEdition_002EisPassword
	{
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x2A0DEE0", Offset = "0x2A0D0E0", VA = "0x182A0DEE0", Slot = "170")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x2A0E0E0", Offset = "0x2A0D2E0", VA = "0x182A0E0E0", Slot = "171")]
		set
		{
		}
	}

	[Token(Token = "0x170008C5")]
	[CreateProperty]
	private bool isPassword
	{
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x2A10A90", Offset = "0x2A0FC90", VA = "0x182A10A90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x2A11790", Offset = "0x2A10990", VA = "0x182A11790")]
		set
		{
		}
	}

	[Token(Token = "0x170008C6")]
	private bool UnityEngine_002EUIElements_002EITextEdition_002EhidePlaceholderOnFocus
	{
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x2A0DEC0", Offset = "0x2A0D0C0", VA = "0x182A0DEC0", Slot = "172")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x2A0E0C0", Offset = "0x2A0D2C0", VA = "0x182A0E0C0", Slot = "173")]
		set
		{
		}
	}

	[Token(Token = "0x170008C7")]
	internal bool showPlaceholderText
	{
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x2A111F0", Offset = "0x2A103F0", VA = "0x182A111F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008C8")]
	private bool UnityEngine_002EUIElements_002EITextEdition_002EautoCorrection
	{
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x2A0DE70", Offset = "0x2A0D070", VA = "0x182A0DE70", Slot = "174")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x2A0DFB0", Offset = "0x2A0D1B0", VA = "0x182A0DFB0", Slot = "175")]
		set
		{
		}
	}

	[Token(Token = "0x170008C9")]
	[CreateProperty]
	private bool autoCorrection
	{
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x2A107D0", Offset = "0x2A0F9D0", VA = "0x182A107D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020EC")]
		[Address(RVA = "0x2A113D0", Offset = "0x2A105D0", VA = "0x182A113D0")]
		set
		{
		}
	}

	[Token(Token = "0x170008CA")]
	internal UnityEngine.TextCore.Text.RenderedText renderedText
	{
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x2A10CF0", Offset = "0x2A0FEF0", VA = "0x182A10CF0")]
		get
		{
			return default(UnityEngine.TextCore.Text.RenderedText);
		}
	}

	[Token(Token = "0x170008CB")]
	internal string originalText
	{
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x14CA1E0", Offset = "0x14C93E0", VA = "0x1814CA1E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008CC")]
	[CreateProperty(ReadOnly = true)]
	public ITextSelection selection
	{
		[Token(Token = "0x60020F0")]
		[Address(RVA = "0x52BB60", Offset = "0x52AD60", VA = "0x18052BB60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008CD")]
	private bool UnityEngine_002EUIElements_002EITextSelection_002EisSelectable
	{
		[Token(Token = "0x60020F1")]
		[Address(RVA = "0x2A0E9A0", Offset = "0x2A0DBA0", VA = "0x182A0E9A0", Slot = "181")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x2A0EC90", Offset = "0x2A0DE90", VA = "0x182A0EC90", Slot = "182")]
		set
		{
		}
	}

	[Token(Token = "0x170008CE")]
	[CreateProperty]
	internal bool isSelectable
	{
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x2A10B30", Offset = "0x2A0FD30", VA = "0x182A10B30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x2A11850", Offset = "0x2A10A50", VA = "0x182A11850")]
		set
		{
		}
	}

	[Token(Token = "0x170008CF")]
	private int UnityEngine_002EUIElements_002EITextSelection_002EcursorIndex
	{
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x2A0E840", Offset = "0x2A0DA40", VA = "0x182A0E840", Slot = "183")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x2A0EB10", Offset = "0x2A0DD10", VA = "0x182A0EB10", Slot = "184")]
		set
		{
		}
	}

	[Token(Token = "0x170008D0")]
	[CreateProperty]
	private int cursorIndex
	{
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x2A10830", Offset = "0x2A0FA30", VA = "0x182A10830")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x2A114B0", Offset = "0x2A106B0", VA = "0x182A114B0")]
		set
		{
		}
	}

	[Token(Token = "0x170008D1")]
	private int UnityEngine_002EUIElements_002EITextSelection_002EselectIndex
	{
		[Token(Token = "0x60020F9")]
		[Address(RVA = "0x2A0EA90", Offset = "0x2A0DC90", VA = "0x182A0EA90", Slot = "187")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60020FA")]
		[Address(RVA = "0x2A0EE50", Offset = "0x2A0E050", VA = "0x182A0EE50", Slot = "188")]
		set
		{
		}
	}

	[Token(Token = "0x170008D2")]
	[CreateProperty]
	private int selectIndex
	{
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x2A11110", Offset = "0x2A10310", VA = "0x182A11110")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x2A11B80", Offset = "0x2A10D80", VA = "0x182A11B80")]
		set
		{
		}
	}

	[Token(Token = "0x170008D3")]
	private bool UnityEngine_002EUIElements_002EITextSelection_002EdoubleClickSelectsWord
	{
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x2A0E990", Offset = "0x2A0DB90", VA = "0x182A0E990", Slot = "185")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x2A0EC10", Offset = "0x2A0DE10", VA = "0x182A0EC10", Slot = "186")]
		set
		{
		}
	}

	[Token(Token = "0x170008D4")]
	[CreateProperty]
	internal bool doubleClickSelectsWord
	{
		[Token(Token = "0x6002102")]
		[Address(RVA = "0x2A108E0", Offset = "0x2A0FAE0", VA = "0x182A108E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002103")]
		[Address(RVA = "0x2A115A0", Offset = "0x2A107A0", VA = "0x182A115A0")]
		set
		{
		}
	}

	[Token(Token = "0x170008D5")]
	private bool UnityEngine_002EUIElements_002EITextSelection_002EtripleClickSelectsLine
	{
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x2A0EB00", Offset = "0x2A0DD00", VA = "0x182A0EB00", Slot = "189")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x2A0EF50", Offset = "0x2A0E150", VA = "0x182A0EF50", Slot = "190")]
		set
		{
		}
	}

	[Token(Token = "0x170008D6")]
	[CreateProperty]
	internal bool tripleClickSelectsLine
	{
		[Token(Token = "0x6002106")]
		[Address(RVA = "0x2A11340", Offset = "0x2A10540", VA = "0x182A11340")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002107")]
		[Address(RVA = "0x2A11CB0", Offset = "0x2A10EB0", VA = "0x182A11CB0")]
		set
		{
		}
	}

	[Token(Token = "0x170008D7")]
	private bool UnityEngine_002EUIElements_002EITextSelection_002EselectAllOnFocus
	{
		[Token(Token = "0x6002108")]
		[Address(RVA = "0x2A0EA70", Offset = "0x2A0DC70", VA = "0x182A0EA70", Slot = "194")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x2A0ED50", Offset = "0x2A0DF50", VA = "0x182A0ED50", Slot = "195")]
		set
		{
		}
	}

	[Token(Token = "0x170008D8")]
	[CreateProperty]
	private bool selectAllOnFocus
	{
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x2A11070", Offset = "0x2A10270", VA = "0x182A11070")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x2A11AC0", Offset = "0x2A10CC0", VA = "0x182A11AC0")]
		set
		{
		}
	}

	[Token(Token = "0x170008D9")]
	private bool UnityEngine_002EUIElements_002EITextSelection_002EselectAllOnMouseUp
	{
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x2A0EA80", Offset = "0x2A0DC80", VA = "0x182A0EA80", Slot = "196")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600210D")]
		[Address(RVA = "0x2A0EDD0", Offset = "0x2A0DFD0", VA = "0x182A0EDD0", Slot = "197")]
		set
		{
		}
	}

	[Token(Token = "0x170008DA")]
	[CreateProperty]
	private bool selectAllOnMouseUp
	{
		[Token(Token = "0x600210E")]
		[Address(RVA = "0x2A110C0", Offset = "0x2A102C0", VA = "0x182A110C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600210F")]
		[Address(RVA = "0x2A11B20", Offset = "0x2A10D20", VA = "0x182A11B20")]
		set
		{
		}
	}

	[Token(Token = "0x170008DB")]
	private Vector2 UnityEngine_002EUIElements_002EITextSelection_002EcursorPosition
	{
		[Token(Token = "0x6002110")]
		[Address(RVA = "0x2A0E8B0", Offset = "0x2A0DAB0", VA = "0x182A0E8B0", Slot = "198")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170008DC")]
	[CreateProperty(ReadOnly = true)]
	private Vector2 cursorPosition
	{
		[Token(Token = "0x6002111")]
		[Address(RVA = "0x2A10880", Offset = "0x2A0FA80", VA = "0x182A10880")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x170008DD")]
	private float UnityEngine_002EUIElements_002EITextSelection_002ElineHeightAtCursorPosition
	{
		[Token(Token = "0x6002112")]
		[Address(RVA = "0x2A0E9E0", Offset = "0x2A0DBE0", VA = "0x182A0E9E0", Slot = "199")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008DE")]
	internal Color selectionColor
	{
		[Token(Token = "0x6002113")]
		[Address(RVA = "0x2A111E0", Offset = "0x2A103E0", VA = "0x182A111E0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6002114")]
		[Address(RVA = "0x2A11BE0", Offset = "0x2A10DE0", VA = "0x182A11BE0")]
		set
		{
		}
	}

	[Token(Token = "0x170008DF")]
	internal Color cursorColor
	{
		[Token(Token = "0x6002115")]
		[Address(RVA = "0x2A10820", Offset = "0x2A0FA20", VA = "0x182A10820")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x2A11430", Offset = "0x2A10630", VA = "0x182A11430")]
		set
		{
		}
	}

	[Token(Token = "0x170008E0")]
	private float UnityEngine_002EUIElements_002EITextSelection_002EcursorWidth
	{
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x2A0E980", Offset = "0x2A0DB80", VA = "0x182A0E980", Slot = "200")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170008E1")]
	internal TextSelectingManipulator selectingManipulator
	{
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x2A11160", Offset = "0x2A10360", VA = "0x182A11160")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002086")]
	[Address(RVA = "0x2A104D0", Offset = "0x2A0F6D0", VA = "0x182A104D0")]
	public TextElement()
	{
	}

	[Token(Token = "0x6002087")]
	[Address(RVA = "0x2A0CCA0", Offset = "0x2A0BEA0", VA = "0x182A0CCA0")]
	private string GetDefaultValueType()
	{
		return null;
	}

	[Token(Token = "0x600208A")]
	[Address(RVA = "0x2A0CFA0", Offset = "0x2A0C1A0", VA = "0x182A0CFA0", Slot = "8")]
	[EventInterest(new Type[]
	{
		typeof(ContextualMenuPopulateEvent),
		typeof(KeyDownEvent),
		typeof(KeyUpEvent),
		typeof(ValidateCommandEvent),
		typeof(ExecuteCommandEvent),
		typeof(FocusEvent),
		typeof(BlurEvent),
		typeof(FocusInEvent),
		typeof(FocusOutEvent),
		typeof(PointerDownEvent),
		typeof(PointerUpEvent),
		typeof(PointerMoveEvent),
		typeof(NavigationMoveEvent),
		typeof(NavigationSubmitEvent),
		typeof(NavigationCancelEvent),
		typeof(IMEEvent),
		typeof(GeometryChangedEvent),
		typeof(AttachToPanelEvent),
		typeof(DetachFromPanelEvent)
	})]
	protected override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x600208B")]
	[Address(RVA = "0x2A0D5D0", Offset = "0x2A0C7D0", VA = "0x182A0D5D0")]
	private void OnGeometryChanged(GeometryChangedEvent e)
	{
	}

	[Token(Token = "0x600208C")]
	[Address(RVA = "0x2A0D160", Offset = "0x2A0C360", VA = "0x182A0D160")]
	private void OnDetachFromPanel(DetachFromPanelEvent detachEvent)
	{
	}

	[Token(Token = "0x6002099")]
	[Address(RVA = "0x2A0D470", Offset = "0x2A0C670", VA = "0x182A0D470")]
	internal static void OnGenerateVisualContent(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600209A")]
	[Address(RVA = "0x2A0D2A0", Offset = "0x2A0C4A0", VA = "0x182A0D2A0")]
	internal void OnGenerateTextOver(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600209B")]
	[Address(RVA = "0x2A0D1A0", Offset = "0x2A0C3A0", VA = "0x182A0D1A0")]
	internal void OnGenerateTextOverNative(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600209C")]
	[Address(RVA = "0x2A0C7C0", Offset = "0x2A0B9C0", VA = "0x182A0C7C0")]
	internal string ElideText(string drawText, string ellipsisText, float width, TextOverflowPosition textOverflowPosition)
	{
		return null;
	}

	[Token(Token = "0x600209D")]
	[Address(RVA = "0x2A0EFD0", Offset = "0x2A0E1D0", VA = "0x182A0EFD0")]
	private void UpdateTooltip()
	{
	}

	[Token(Token = "0x600209E")]
	[Address(RVA = "0x2A0F050", Offset = "0x2A0E250", VA = "0x182A0F050")]
	private void UpdateVisibleText()
	{
	}

	[Token(Token = "0x600209F")]
	[Address(RVA = "0x2A0D790", Offset = "0x2A0C990", VA = "0x182A0D790")]
	private bool ShouldElide()
	{
		return default(bool);
	}

	[Token(Token = "0x60020A1")]
	[Address(RVA = "0x2A0D0C0", Offset = "0x2A0C2C0", VA = "0x182A0D0C0")]
	public Vector2 MeasureTextSize(string textToMeasure, float width, MeasureMode widthMode, float height, MeasureMode heightMode)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x2A0B3C0", Offset = "0x2A0A5C0", VA = "0x182A0B3C0", Slot = "135")]
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60020A7")]
	[Address(RVA = "0x2A0D7E0", Offset = "0x2A0C9E0", VA = "0x182A0D7E0", Slot = "141")]
	private void UnityEngine_002EUIElements_002EINotifyValueChanged_003CSystem_002EString_003E_002ESetValueWithoutNotify(string newValue)
	{
	}

	[Token(Token = "0x60020BA")]
	[Address(RVA = "0x2A0D690", Offset = "0x2A0C890", VA = "0x182A0D690")]
	private void ProcessMenuCommand(string command)
	{
	}

	[Token(Token = "0x60020BB")]
	[Address(RVA = "0x2A0B380", Offset = "0x2A0A580", VA = "0x182A0B380")]
	private void Cut(DropdownMenuAction a)
	{
	}

	[Token(Token = "0x60020BC")]
	[Address(RVA = "0x2A0B2B0", Offset = "0x2A0A4B0", VA = "0x182A0B2B0")]
	private void Copy(DropdownMenuAction a)
	{
	}

	[Token(Token = "0x60020BD")]
	[Address(RVA = "0x2A0D650", Offset = "0x2A0C850", VA = "0x182A0D650")]
	private void Paste(DropdownMenuAction a)
	{
	}

	[Token(Token = "0x60020BE")]
	[Address(RVA = "0x2A0AEE0", Offset = "0x2A0A0E0", VA = "0x182A0AEE0")]
	private void BuildContextualMenu(ContextualMenuPopulateEvent evt)
	{
	}

	[Token(Token = "0x60020BF")]
	[Address(RVA = "0x2A0B2F0", Offset = "0x2A0A4F0", VA = "0x182A0B2F0")]
	private DropdownMenuAction.Status CutActionStatus(DropdownMenuAction a)
	{
		return default(DropdownMenuAction.Status);
	}

	[Token(Token = "0x60020C0")]
	[Address(RVA = "0x2A0B220", Offset = "0x2A0A420", VA = "0x182A0B220")]
	private DropdownMenuAction.Status CopyActionStatus(DropdownMenuAction a)
	{
		return default(DropdownMenuAction.Status);
	}

	[Token(Token = "0x60020C1")]
	[Address(RVA = "0x2A0D5E0", Offset = "0x2A0C7E0", VA = "0x182A0D5E0")]
	private DropdownMenuAction.Status PasteActionStatus(DropdownMenuAction a)
	{
		return default(DropdownMenuAction.Status);
	}

	[Token(Token = "0x60020C2")]
	[Address(RVA = "0x2A0C510", Offset = "0x2A0B710", VA = "0x182A0C510")]
	private void EditionHandleEvent(EventBase evt)
	{
	}

	[Token(Token = "0x60020CB")]
	[Address(RVA = "0x2A0DC40", Offset = "0x2A0CE40", VA = "0x182A0DC40", Slot = "152")]
	private void UnityEngine_002EUIElements_002EITextEdition_002ESaveValueAndText()
	{
	}

	[Token(Token = "0x60020CC")]
	[Address(RVA = "0x2A0DC20", Offset = "0x2A0CE20", VA = "0x182A0DC20", Slot = "153")]
	private void UnityEngine_002EUIElements_002EITextEdition_002ERestoreValueAndText()
	{
	}

	[Token(Token = "0x60020DB")]
	[Address(RVA = "0x2A0DC80", Offset = "0x2A0CE80", VA = "0x182A0DC80", Slot = "166")]
	private void UnityEngine_002EUIElements_002EITextEdition_002EUpdateText(string value)
	{
	}

	[Token(Token = "0x60020DC")]
	[Address(RVA = "0x2A0DBA0", Offset = "0x2A0CDA0", VA = "0x182A0DBA0", Slot = "167")]
	private string UnityEngine_002EUIElements_002EITextEdition_002ECullString(string s)
	{
		return null;
	}

	[Token(Token = "0x60020EE")]
	[Address(RVA = "0x14CA860", Offset = "0x14C9A60", VA = "0x1814CA860")]
	private void SetRenderedText(string value)
	{
	}

	[Token(Token = "0x60020FD")]
	[Address(RVA = "0x2A0E760", Offset = "0x2A0D960", VA = "0x182A0E760", Slot = "192")]
	private void UnityEngine_002EUIElements_002EITextSelection_002ESelectAll()
	{
	}

	[Token(Token = "0x60020FE")]
	[Address(RVA = "0x2A0E7D0", Offset = "0x2A0D9D0", VA = "0x182A0E7D0", Slot = "193")]
	private void UnityEngine_002EUIElements_002EITextSelection_002ESelectNone()
	{
	}

	[Token(Token = "0x60020FF")]
	[Address(RVA = "0x2A0E6F0", Offset = "0x2A0D8F0", VA = "0x182A0E6F0", Slot = "191")]
	private bool UnityEngine_002EUIElements_002EITextSelection_002EHasSelection()
	{
		return default(bool);
	}

	[Token(Token = "0x6002119")]
	[Address(RVA = "0x2A0B750", Offset = "0x2A0A950", VA = "0x182A0B750")]
	private void DrawHighlighting(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600211A")]
	[Address(RVA = "0x2A0C050", Offset = "0x2A0B250", VA = "0x182A0C050")]
	private void DrawNativeHighlighting(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600211B")]
	[Address(RVA = "0x2A0B460", Offset = "0x2A0A660", VA = "0x182A0B460")]
	internal void DrawCaret(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600211C")]
	[Address(RVA = "0x2A0CCC0", Offset = "0x2A0BEC0", VA = "0x182A0CCC0")]
	private int GetLastCharacterAt(int lineIndex)
	{
		return default(int);
	}
}
