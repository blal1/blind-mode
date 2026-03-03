using System;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000CB")]
public class Foldout : BindableElement, INotifyValueChanged<bool>
{
	[Token(Token = "0x20000CC")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Foldout, UxmlTraits>
	{
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x2AB5AE0", Offset = "0x2AB4CE0", VA = "0x182AB5AE0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x20000CD")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x90")]
		private UxmlStringAttributeDescription m_Text;

		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x98")]
		private UxmlBoolAttributeDescription m_Value;

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x2AB61C0", Offset = "0x2AB53C0", VA = "0x182AB61C0", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x2AB9440", Offset = "0x2AB8640", VA = "0x182AB9440")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId textProperty;

	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId toggleOnLabelClickProperty;

	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId valueProperty;

	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x4B8")]
	private readonly Toggle m_Toggle;

	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x4C0")]
	private VisualElement m_Container;

	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x4C8")]
	[DontCreateProperty]
	[SerializeField]
	private bool m_Value;

	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x1C8")]
	public static readonly string ussClassName;

	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x1D0")]
	public static readonly string toggleUssClassName;

	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x1D8")]
	public static readonly string contentUssClassName;

	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x1E0")]
	public static readonly string inputUssClassName;

	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x1E8")]
	public static readonly string checkmarkUssClassName;

	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x1F0")]
	public static readonly string textUssClassName;

	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x1F8")]
	internal static readonly string toggleInspectorUssClassName;

	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x200")]
	internal static readonly string ussFoldoutDepthClassName;

	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x208")]
	internal static readonly int ussFoldoutMaxDepth;

	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x4D0")]
	private KeyboardNavigationManipulator m_NavigationManipulator;

	[Token(Token = "0x170000E9")]
	internal Toggle toggle
	{
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x29FCCC0", Offset = "0x29FBEC0", VA = "0x1829FCCC0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000EA")]
	public override VisualElement contentContainer
	{
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x2AAE730", Offset = "0x2AAD930", VA = "0x182AAE730", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000EB")]
	public override bool focusable
	{
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680", Slot = "16")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x2AAE7A0", Offset = "0x2AAD9A0", VA = "0x182AAE7A0", Slot = "17")]
		set
		{
		}
	}

	[Token(Token = "0x170000EC")]
	[CreateProperty]
	public bool toggleOnLabelClick
	{
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x2AAE770", Offset = "0x2AAD970", VA = "0x182AAE770")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x2AAE9A0", Offset = "0x2AADBA0", VA = "0x182AAE9A0")]
		set
		{
		}
	}

	[Token(Token = "0x170000ED")]
	[CreateProperty]
	public string text
	{
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x2AAE740", Offset = "0x2AAD940", VA = "0x182AAE740")]
		get
		{
			return null;
		}
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x2AAE7F0", Offset = "0x2AAD9F0", VA = "0x182AAE7F0")]
		set
		{
		}
	}

	[Token(Token = "0x170000EE")]
	[CreateProperty]
	public bool value
	{
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x2A109A0", Offset = "0x2A0FBA0", VA = "0x182A109A0", Slot = "139")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x2AAEA40", Offset = "0x2AADC40", VA = "0x182AAEA40", Slot = "140")]
		set
		{
		}
	}

	[Token(Token = "0x600065F")]
	[Address(RVA = "0x2AADB50", Offset = "0x2AACD50", VA = "0x182AADB50", Slot = "141")]
	public void SetValueWithoutNotify(bool newValue)
	{
	}

	[Token(Token = "0x6000660")]
	[Address(RVA = "0x2AADB00", Offset = "0x2AACD00", VA = "0x182AADB00", Slot = "133")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x6000661")]
	[Address(RVA = "0x2AAD7B0", Offset = "0x2AAC9B0", VA = "0x182AAD7B0")]
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
	{
	}

	[Token(Token = "0x6000662")]
	[Address(RVA = "0x2AAD6A0", Offset = "0x2AAC8A0", VA = "0x182AAD6A0")]
	private bool Apply(KeyboardNavigationOperation op)
	{
		return default(bool);
	}

	[Token(Token = "0x6000663")]
	[Address(RVA = "0x2AAE2E0", Offset = "0x2AAD4E0", VA = "0x182AAE2E0")]
	public Foldout()
	{
	}

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x2AAD8F0", Offset = "0x2AACAF0", VA = "0x182AAD8F0")]
	private void OnAttachToPanel(AttachToPanelEvent evt)
	{
	}
}
