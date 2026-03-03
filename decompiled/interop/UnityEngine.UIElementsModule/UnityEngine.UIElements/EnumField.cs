using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000C3")]
[MovedFrom(true, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
public class EnumField : BaseField<Enum>
{
	[Token(Token = "0x20000C4")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<EnumField, UxmlTraits>
	{
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x2AB59A0", Offset = "0x2AB4BA0", VA = "0x182AB59A0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000C5")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseField<Enum>.UxmlTraits
	{
		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private UxmlTypeAttributeDescription<Enum> m_Type;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UxmlStringAttributeDescription m_Value;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private UxmlBoolAttributeDescription m_IncludeObsoleteValues;

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x2AB6C50", Offset = "0x2AB5E50", VA = "0x182AB6C50", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x2AB9F20", Offset = "0x2AB9120", VA = "0x182AB9F20")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static readonly BindingId textProperty;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
	private Type m_EnumType;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
	private bool m_IncludeObsoleteValues;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
	private TextElement m_TextElement;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
	private VisualElement m_ArrowElement;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
	private UnityEngine.EnumData m_EnumData;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
	internal Func<IGenericMenu> createMenuCallback;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public new static readonly string ussClassName;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static readonly string textUssClassName;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static readonly string arrowUssClassName;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public new static readonly string labelUssClassName;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public new static readonly string inputUssClassName;

	[Token(Token = "0x170000E4")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool includeObsoleteValues
	{
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x2AAC9C0", Offset = "0x2AABBC0", VA = "0x182AAC9C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000E5")]
	[CreateProperty(ReadOnly = true)]
	public string text
	{
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x2AAC9D0", Offset = "0x2AABBD0", VA = "0x182AAC9D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0x2AAB8D0", Offset = "0x2AAAAD0", VA = "0x182AAB8D0")]
	private void Initialize(Enum defaultValue)
	{
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0x2AAC9B0", Offset = "0x2AABBB0", VA = "0x182AAC9B0")]
	public EnumField()
	{
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0x2AAC660", Offset = "0x2AAB860", VA = "0x182AAC660")]
	public EnumField(string label, [Optional] Enum defaultValue)
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0x2AAB7B0", Offset = "0x2AAA9B0", VA = "0x182AAB7B0")]
	public void Init(Enum defaultValue)
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0x2AAB7C0", Offset = "0x2AAA9C0", VA = "0x182AAB7C0")]
	public void Init(Enum defaultValue, bool includeObsoleteValues)
	{
	}

	[Token(Token = "0x6000631")]
	[Address(RVA = "0x2AABBB0", Offset = "0x2AAADB0", VA = "0x182AABBB0")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal void PopulateDataFromType(Type enumType)
	{
	}

	[Token(Token = "0x6000632")]
	[Address(RVA = "0x2AABCD0", Offset = "0x2AAAED0", VA = "0x182AABCD0", Slot = "155")]
	public override void SetValueWithoutNotify(Enum newValue)
	{
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x2AAC270", Offset = "0x2AAB470", VA = "0x182AAC270")]
	private void UpdateValueLabel(Enum value)
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x2AABAE0", Offset = "0x2AAACE0", VA = "0x182AABAE0")]
	private void OnPointerDownEvent(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x2AABB30", Offset = "0x2AAAD30", VA = "0x182AABB30")]
	private void OnPointerMoveEvent(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x2AAB720", Offset = "0x2AAA920", VA = "0x182AAB720")]
	private bool ContainsPointer(int pointerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000637")]
	private void ProcessPointerDown<T>(PointerEventBase<T> evt) where T : PointerEventBase<T>, new()
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x2AABAB0", Offset = "0x2AAACB0", VA = "0x182AABAB0")]
	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x2AABD90", Offset = "0x2AAAF90", VA = "0x182AABD90")]
	internal void ShowMenu()
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x2AAB6C0", Offset = "0x2AAA8C0", VA = "0x182AAB6C0")]
	private void ChangeValueFromMenu(object menuItem)
	{
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x2AAC100", Offset = "0x2AAB300", VA = "0x182AAC100", Slot = "154")]
	protected override void UpdateMixedValueContent()
	{
	}
}
