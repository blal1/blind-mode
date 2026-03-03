using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000ED")]
public abstract class TextInputBaseField<TValueType> : BaseField<TValueType>, IDelayedField
{
	[Token(Token = "0x20000EE")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseFieldTraits<string, UxmlStringAttributeDescription>
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlIntAttributeDescription m_MaxLength;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_Password;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_MaskCharacter;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_PlaceholderText;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_HidePlaceholderOnFocus;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_IsReadOnly;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_IsDelayed;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_SelectAllOnMouseUp;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_SelectAllOnFocus;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_SelectWordByDoubleClick;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_SelectLineByTripleClick;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_EmojiFallbackSupport;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_HideMobileInput;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlEnumAttributeDescription<TouchScreenKeyboardType> m_KeyboardType;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_AutoCorrection;

		[Token(Token = "0x600076B")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x600076C")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x20000EF")]
	protected internal abstract class TextInputBase : VisualElement
	{
		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ScrollView scrollView;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal VisualElement multilineContainer;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string innerComponentsModifierName;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string innerTextElementUssClassName;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly string innerTextElementWithScrollViewUssClassName;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string horizontalVariantInnerTextElementUssClassName;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string verticalVariantInnerTextElementUssClassName;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string verticalHorizontalVariantInnerTextElementUssClassName;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string innerScrollviewUssClassName;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string innerViewportUssClassName;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string innerContentContainerUssClassName;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal Vector2 scrollOffset;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_ScrollViewWasClamped;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Vector2 lastCursorPos;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal ScrollerVisibility verticalScrollerVisibility;

		[Token(Token = "0x1700012D")]
		internal TextElement textElement
		{
			[Token(Token = "0x600076D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600076E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public ITextSelection textSelection
		{
			[Token(Token = "0x6000770")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012F")]
		public ITextEdition textEdition
		{
			[Token(Token = "0x6000771")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000130")]
		internal bool isDragging
		{
			[Token(Token = "0x6000772")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public string text
		{
			[Token(Token = "0x6000773")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000774")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		internal string originalText
		{
			[Token(Token = "0x6000775")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076F")]
		internal TextInputBase()
		{
		}

		[Token(Token = "0x6000776")]
		protected virtual TValueType StringToValue(string str)
		{
			return (TValueType)null;
		}

		[Token(Token = "0x6000777")]
		internal void UpdateValueFromText()
		{
		}

		[Token(Token = "0x6000778")]
		internal void UpdateTextFromValue()
		{
		}

		[Token(Token = "0x6000779")]
		internal void MoveFocusToCompositeRoot()
		{
		}

		[Token(Token = "0x600077A")]
		private void MakeSureScrollViewDoesNotLeakEvents(ChangeEvent<float> evt)
		{
		}

		[Token(Token = "0x600077B")]
		internal void SetSingleLine()
		{
		}

		[Token(Token = "0x600077C")]
		internal void SetMultiline()
		{
		}

		[Token(Token = "0x600077D")]
		private void ScrollViewOnGeometryChangedEvent(GeometryChangedEvent e)
		{
		}

		[Token(Token = "0x600077E")]
		private void TextElementOnGeometryChangedEvent(GeometryChangedEvent e)
		{
		}

		[Token(Token = "0x600077F")]
		internal void OnInputCustomStyleResolved(CustomStyleResolvedEvent e)
		{
		}

		[Token(Token = "0x6000780")]
		private string GetDefaultValueType()
		{
			return null;
		}

		[Token(Token = "0x6000781")]
		internal virtual bool AcceptCharacter(char c)
		{
			return default(bool);
		}

		[Token(Token = "0x6000782")]
		internal void UpdateScrollOffset(bool isBackspace = false)
		{
		}

		[Token(Token = "0x6000783")]
		internal void UpdateScrollOffset(bool isBackspace, bool widthChanged)
		{
		}

		[Token(Token = "0x6000784")]
		private Vector2 GetScrollOffset(float xOffset, float yOffset, float contentViewportWidth, bool isBackspace, bool widthChanged)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000785")]
		internal void SetScrollViewMode()
		{
		}

		[Token(Token = "0x6000786")]
		private void SetMultilineContainerStyle()
		{
		}

		[Token(Token = "0x6000787")]
		private void RemoveSingleLineComponents()
		{
		}

		[Token(Token = "0x6000788")]
		private void RemoveMultilineComponents()
		{
		}

		[Token(Token = "0x6000789")]
		internal bool SetVerticalScrollerVisibility(ScrollerVisibility sv)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId autoCorrectionProperty;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId hideMobileInputProperty;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId hidePlaceholderOnFocusProperty;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId keyboardTypeProperty;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId isReadOnlyProperty;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId isPasswordFieldProperty;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId textSelectionProperty;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId textEditionProperty;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId placeholderTextProperty;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId cursorIndexProperty;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId cursorPositionProperty;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId selectIndexProperty;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId selectAllOnFocusProperty;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId selectAllOnMouseUpProperty;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId maxLengthProperty;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId doubleClickSelectsWordProperty;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId tripleClickSelectsLineProperty;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId emojiFallbackSupportProperty;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId isDelayedProperty;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId maskCharProperty;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId verticalScrollerVisibilityProperty;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CustomStyleProperty<Color> s_SelectionColorProperty;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CustomStyleProperty<Color> s_CursorColorProperty;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static readonly string ussClassName;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly string multilineContainerClassName;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string singleLineInputUssClassName;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string multilineInputUssClassName;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string placeholderUssClassName;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly string multilineInputWithScrollViewUssClassName;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string textInputUssName;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private TextInputBase m_TextInputBase;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal bool m_UpdateTextFromValue;

	[Token(Token = "0x17000112")]
	internal bool password
	{
		[Token(Token = "0x6000731")]
		set
		{
		}
	}

	[Token(Token = "0x17000113")]
	internal bool readOnly
	{
		[Token(Token = "0x6000732")]
		set
		{
		}
	}

	[Token(Token = "0x17000114")]
	[CreateProperty]
	internal string placeholderText
	{
		[Token(Token = "0x6000733")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000734")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		set
		{
		}
	}

	[Token(Token = "0x17000115")]
	[CreateProperty]
	internal bool hidePlaceholderOnFocus
	{
		[Token(Token = "0x6000735")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000736")]
		set
		{
		}
	}

	[Token(Token = "0x17000116")]
	protected internal TextInputBase textInputBase
	{
		[Token(Token = "0x6000738")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000117")]
	[CreateProperty(ReadOnly = true)]
	public ITextSelection textSelection
	{
		[Token(Token = "0x6000739")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000118")]
	[CreateProperty(ReadOnly = true)]
	public ITextEdition textEdition
	{
		[Token(Token = "0x600073A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000119")]
	protected Action<bool> onIsReadOnlyChanged
	{
		[Token(Token = "0x600073B")]
		get
		{
			return null;
		}
		[Token(Token = "0x600073C")]
		set
		{
		}
	}

	[Token(Token = "0x1700011A")]
	[CreateProperty]
	public bool isReadOnly
	{
		[Token(Token = "0x600073D")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600073E")]
		set
		{
		}
	}

	[Token(Token = "0x1700011B")]
	[CreateProperty]
	public bool isPasswordField
	{
		[Token(Token = "0x600073F")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000740")]
		set
		{
		}
	}

	[Token(Token = "0x1700011C")]
	[CreateProperty]
	public bool autoCorrection
	{
		[Token(Token = "0x6000741")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000742")]
		set
		{
		}
	}

	[Token(Token = "0x1700011D")]
	[CreateProperty]
	public bool hideMobileInput
	{
		[Token(Token = "0x6000743")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000744")]
		set
		{
		}
	}

	[Token(Token = "0x1700011E")]
	[CreateProperty]
	public TouchScreenKeyboardType keyboardType
	{
		[Token(Token = "0x6000745")]
		get
		{
			return default(TouchScreenKeyboardType);
		}
		[Token(Token = "0x6000746")]
		set
		{
		}
	}

	[Token(Token = "0x1700011F")]
	[CreateProperty]
	public int maxLength
	{
		[Token(Token = "0x6000747")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000748")]
		set
		{
		}
	}

	[Token(Token = "0x17000120")]
	[CreateProperty]
	public bool isDelayed
	{
		[Token(Token = "0x6000749")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600074A")]
		set
		{
		}
	}

	[Token(Token = "0x17000121")]
	[CreateProperty]
	public char maskChar
	{
		[Token(Token = "0x600074B")]
		get
		{
			return default(char);
		}
		[Token(Token = "0x600074C")]
		set
		{
		}
	}

	[Token(Token = "0x17000122")]
	[CreateProperty]
	public int cursorIndex
	{
		[Token(Token = "0x600074D")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600074E")]
		set
		{
		}
	}

	[Token(Token = "0x17000123")]
	[CreateProperty(ReadOnly = true)]
	public Vector2 cursorPosition
	{
		[Token(Token = "0x600074F")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000124")]
	[CreateProperty]
	public int selectIndex
	{
		[Token(Token = "0x6000750")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000751")]
		set
		{
		}
	}

	[Token(Token = "0x17000125")]
	[CreateProperty]
	public bool selectAllOnFocus
	{
		[Token(Token = "0x6000752")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000753")]
		set
		{
		}
	}

	[Token(Token = "0x17000126")]
	[CreateProperty]
	public bool selectAllOnMouseUp
	{
		[Token(Token = "0x6000754")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000755")]
		set
		{
		}
	}

	[Token(Token = "0x17000127")]
	[CreateProperty]
	public bool doubleClickSelectsWord
	{
		[Token(Token = "0x6000756")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000757")]
		set
		{
		}
	}

	[Token(Token = "0x17000128")]
	[CreateProperty]
	public bool tripleClickSelectsLine
	{
		[Token(Token = "0x6000758")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000759")]
		set
		{
		}
	}

	[Token(Token = "0x17000129")]
	public string text
	{
		[Token(Token = "0x600075A")]
		get
		{
			return null;
		}
		[Token(Token = "0x600075B")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		protected internal set
		{
		}
	}

	[Token(Token = "0x1700012A")]
	[CreateProperty]
	public bool emojiFallbackSupport
	{
		[Token(Token = "0x600075C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600075D")]
		set
		{
		}
	}

	[Token(Token = "0x1700012B")]
	[CreateProperty]
	public ScrollerVisibility verticalScrollerVisibility
	{
		[Token(Token = "0x600075E")]
		get
		{
			return default(ScrollerVisibility);
		}
		[Token(Token = "0x600075F")]
		set
		{
		}
	}

	[Token(Token = "0x1700012C")]
	private protected override bool canSwitchToMixedValue
	{
		[Token(Token = "0x6000763")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000737")]
	protected TextInputBaseField(string label, int maxLength, char maskChar, TextInputBase textInputBase)
	{
	}

	[Token(Token = "0x6000760")]
	[EventInterest(new Type[]
	{
		typeof(NavigationSubmitEvent),
		typeof(FocusInEvent),
		typeof(FocusEvent),
		typeof(FocusOutEvent),
		typeof(BlurEvent)
	})]
	protected override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x6000761")]
	protected abstract string ValueToString(TValueType value);

	[Token(Token = "0x6000762")]
	protected abstract TValueType StringToValue(string str);

	[Token(Token = "0x6000764")]
	protected override void UpdateMixedValueContent()
	{
	}

	[Token(Token = "0x6000765")]
	internal void OnPlaceholderChanged()
	{
	}

	[Token(Token = "0x6000766")]
	internal void UpdatePlaceholderClassList([Optional] ChangeEvent<TValueType> evt)
	{
	}

	[Token(Token = "0x6000767")]
	internal virtual void UpdateValueFromText()
	{
	}

	[Token(Token = "0x6000768")]
	internal virtual void UpdateTextFromValue()
	{
	}

	[Token(Token = "0x6000769")]
	private void OnFieldCustomStyleResolved(CustomStyleResolvedEvent e)
	{
	}
}
