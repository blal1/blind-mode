using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20000CF")]
public class GenericDropdownMenu : IGenericMenu
{
	[Token(Token = "0x20000D0")]
	internal class MenuItem
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VisualElement element;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action action;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<object> actionUserData;

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public MenuItem()
		{
		}
	}

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string ussClassName;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string itemUssClassName;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string itemContentUssClassName;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static readonly string labelUssClassName;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static readonly string containerInnerUssClassName;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly string containerOuterUssClassName;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly string checkmarkUssClassName;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static readonly string separatorUssClassName;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static readonly string contentWidthUssClassName;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<MenuItem> m_Items;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private VisualElement m_MenuContainer;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VisualElement m_OuterContainer;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ScrollView m_ScrollView;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private VisualElement m_PanelRootVisualContainer;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private VisualElement m_TargetElement;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Rect m_DesiredRect;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private KeyboardNavigationManipulator m_NavigationManipulator;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float m_PositionTop;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float m_PositionLeft;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float m_ContentWidth;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool m_FitContentWidth;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	private bool m_ShownAboveTarget;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector2 m_MousePosition;

	[Token(Token = "0x170000EF")]
	internal bool isSingleSelectionDropdown
	{
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x2AB2C40", Offset = "0x2AB1E40", VA = "0x182AB2C40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x2AB2C60", Offset = "0x2AB1E60", VA = "0x182AB2C60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000F0")]
	internal bool closeOnParentResize
	{
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x2AB2C00", Offset = "0x2AB1E00", VA = "0x182AB2C00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x2AB2C50", Offset = "0x2AB1E50", VA = "0x182AB2C50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170000F1")]
	public VisualElement contentContainer
	{
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x2AB2C10", Offset = "0x2AB1E10", VA = "0x182AB2C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x2AB28A0", Offset = "0x2AB1AA0", VA = "0x182AB28A0")]
	public GenericDropdownMenu()
	{
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x2AB1670", Offset = "0x2AB0870", VA = "0x182AB1670")]
	private void OnAttachToPanel(AttachToPanelEvent evt)
	{
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0x2AB1A90", Offset = "0x2AB0C90", VA = "0x182AB1A90")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt)
	{
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x2AB1530", Offset = "0x2AB0730", VA = "0x182AB1530")]
	private void Hide(bool giveFocusBack = false)
	{
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x2AAF4A0", Offset = "0x2AAE6A0", VA = "0x182AAF4A0")]
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x2AAF160", Offset = "0x2AAE360", VA = "0x182AAF160")]
	private bool Apply(KeyboardNavigationOperation op)
	{
		return default(bool);
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x2AB1F30", Offset = "0x2AB1130", VA = "0x182AB1F30")]
	private void OnPointerDown(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x2AB2040", Offset = "0x2AB1240", VA = "0x182AB2040")]
	private void OnPointerMove(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x2AB2150", Offset = "0x2AB1350", VA = "0x182AB2150")]
	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x2AB1DB0", Offset = "0x2AB0FB0", VA = "0x182AB1DB0")]
	private void OnFocusOut(FocusOutEvent evt)
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x2AB1F10", Offset = "0x2AB1110", VA = "0x182AB1F10")]
	private void OnParentResized(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x2AB2410", Offset = "0x2AB1610", VA = "0x182AB2410")]
	private void UpdateSelection(VisualElement target)
	{
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x2AAF4E0", Offset = "0x2AAE6E0", VA = "0x182AAF4E0")]
	private void ChangeSelectedIndex(int newIndex, int previousIndex)
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x2AB1490", Offset = "0x2AB0690", VA = "0x182AB1490")]
	private int GetSelectedIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x2AAEBD0", Offset = "0x2AADDD0", VA = "0x182AAEBD0", Slot = "4")]
	public void AddItem(string itemName, bool isChecked, Action action)
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x2AAF050", Offset = "0x2AAE250", VA = "0x182AAF050", Slot = "5")]
	public void AddItem(string itemName, bool isChecked, Action<object> action, object data)
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x2AAF0A0", Offset = "0x2AAE2A0", VA = "0x182AAF0A0", Slot = "7")]
	public void AddSeparator(string path)
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x2AAEC10", Offset = "0x2AADE10", VA = "0x182AAEC10")]
	private MenuItem AddItem(string itemName, bool isChecked, bool isEnabled, [Optional] object data)
	{
		return null;
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x2AAF610", Offset = "0x2AAE810", VA = "0x182AAF610", Slot = "6")]
	public void DropDown(Rect position, [Optional] VisualElement targetElement, bool anchored = false)
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x2AB22B0", Offset = "0x2AB14B0", VA = "0x182AB22B0")]
	private void OnTargetElementDetachFromPanel(DetachFromPanelEvent evt)
	{
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0x2AB1A80", Offset = "0x2AB0C80", VA = "0x182AB1A80")]
	private void OnContainerGeometryChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x2AB1EE0", Offset = "0x2AB10E0", VA = "0x182AB1EE0")]
	private void OnInitialDisplay(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x2AB02A0", Offset = "0x2AAF4A0", VA = "0x182AB02A0")]
	private void EnsureVisibilityInParent()
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x2AB0E10", Offset = "0x2AB0010", VA = "0x182AB0E10")]
	private float GetLargestItemWidth()
	{
		return default(float);
	}
}
