using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200006B")]
internal class ReusableTreeViewItem : ReusableCollectionItem
{
	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x48")]
	private Toggle m_Toggle;

	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x50")]
	private VisualElement m_Container;

	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x58")]
	internal VisualElement m_IndentElement;

	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x60")]
	private VisualElement m_BindableContainer;

	[Token(Token = "0x40001F8")]
	[FieldOffset(Offset = "0x68")]
	private VisualElement m_Checkmark;

	[Token(Token = "0x40001FB")]
	[FieldOffset(Offset = "0x80")]
	internal int m_Depth;

	[Token(Token = "0x40001FC")]
	[FieldOffset(Offset = "0x84")]
	private float m_IndentWidth;

	[Token(Token = "0x40001FD")]
	[FieldOffset(Offset = "0x88")]
	internal float? customIndentWidth;

	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x90")]
	private EventCallback<PointerUpEvent> m_PointerUpCallback;

	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x98")]
	private EventCallback<ChangeEvent<bool>> m_ToggleValueChangedCallback;

	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0xA0")]
	private EventCallback<GeometryChangedEvent> m_ToggleGeometryChangedCallback;

	[Token(Token = "0x1700007E")]
	public override VisualElement rootElement
	{
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x29AE520", Offset = "0x29AD720", VA = "0x1829AE520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700007F")]
	internal float indentWidth
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x29AE4C0", Offset = "0x29AD6C0", VA = "0x1829AE4C0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<PointerUpEvent> onPointerUp
	{
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x29AE360", Offset = "0x29AD560", VA = "0x1829AE360")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x29AE530", Offset = "0x29AD730", VA = "0x1829AE530")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event Action<ChangeEvent<bool>> onToggleValueChanged
	{
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x29AE410", Offset = "0x29AD610", VA = "0x1829AE410")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x29AE5E0", Offset = "0x29AD7E0", VA = "0x1829AE5E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x29AD5A0", Offset = "0x29AC7A0", VA = "0x1829AD5A0")]
	public ReusableTreeViewItem()
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x29ADD40", Offset = "0x29ACF40", VA = "0x1829ADD40", Slot = "5")]
	public override void Init(VisualElement item)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x29AD8B0", Offset = "0x29ACAB0", VA = "0x1829AD8B0")]
	protected void InitExpandHierarchy(VisualElement root, VisualElement item)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x29ADFA0", Offset = "0x29AD1A0", VA = "0x1829ADFA0", Slot = "6")]
	public override void PreAttachElement()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x29AD6D0", Offset = "0x29AC8D0", VA = "0x1829AD6D0", Slot = "7")]
	public override void DetachElement()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x29AD890", Offset = "0x29ACA90", VA = "0x1829AD890")]
	public void Indent(int depth)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x29AE160", Offset = "0x29AD360", VA = "0x1829AE160")]
	public void SetExpandedWithoutNotify(bool expanded)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x29AE180", Offset = "0x29AD380", VA = "0x1829AE180")]
	public void SetToggleVisibility(bool visible)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x29ADE50", Offset = "0x29AD050", VA = "0x1829ADE50")]
	private void OnToggleGeometryChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x29AE1A0", Offset = "0x29AD3A0", VA = "0x1829AE1A0")]
	private void UpdateIndentLayout()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x29ADE30", Offset = "0x29AD030", VA = "0x1829ADE30")]
	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x956780", Offset = "0x955980", VA = "0x180956780")]
	private void OnToggleValueChanged(ChangeEvent<bool> evt)
	{
	}
}
