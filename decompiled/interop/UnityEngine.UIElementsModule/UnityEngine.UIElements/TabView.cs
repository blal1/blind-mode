using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000153")]
[UxmlElement(null, new Type[] { typeof(Tab) })]
public class TabView : VisualElement
{
	[Token(Token = "0x2000154")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<TabView, UxmlTraits>
	{
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x2B0BF80", Offset = "0x2B0B180", VA = "0x182B0BF80")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000155")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0x88")]
		private readonly UxmlBoolAttributeDescription m_Reorderable;

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x2B0C320", Offset = "0x2B0B520", VA = "0x182B0C320", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x2B0CB60", Offset = "0x2B0BD60", VA = "0x182B0CB60")]
		public UxmlTraits()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000156")]
	private class ViewState : ISerializationCallbackReceiver
	{
		[Token(Token = "0x40006D4")]
		[FieldOffset(Offset = "0x10")]
		private bool m_HasPersistedData;

		[Token(Token = "0x40006D5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> m_TabOrder;

		[Token(Token = "0x40006D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_ActiveTabKey;

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x2B0CF10", Offset = "0x2B0C110", VA = "0x182B0CF10")]
		internal void Save(TabView tabView)
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x2B0CD70", Offset = "0x2B0BF70", VA = "0x182B0CD70")]
		internal void Apply(TabView tabView)
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x2B0D120", Offset = "0x2B0C320", VA = "0x182B0D120")]
		public ViewState()
		{
		}
	}

	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId reorderableProperty;

	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x98")]
	public static readonly string ussClassName;

	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0xA0")]
	public static readonly string headerContainerClassName;

	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0xA8")]
	public static readonly string contentContainerUssClassName;

	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0xB0")]
	public static readonly string reorderableUssClassName;

	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0xB8")]
	public static readonly string verticalUssClassName;

	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0x4A8")]
	private VisualElement m_HeaderContainer;

	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x4B0")]
	private VisualElement m_ContentContainer;

	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x4B8")]
	private List<Tab> m_Tabs;

	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x4C0")]
	private List<VisualElement> m_TabHeaders;

	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x4C8")]
	private Tab m_ActiveTab;

	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x4D0")]
	private ViewState m_ViewState;

	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x4D8")]
	private bool m_ApplyingViewState;

	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x4D9")]
	private bool m_Reordering;

	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x4E0")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<Tab, Tab> activeTabChanged;

	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0x4E8")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<int, int> tabReordered;

	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0x4F0")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<Tab, int> tabClosed;

	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0x4F8")]
	private bool m_Reorderable;

	[Token(Token = "0x170001C2")]
	public override VisualElement contentContainer
	{
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x2A999A0", Offset = "0x2A98BA0", VA = "0x182A999A0", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C3")]
	internal VisualElement header
	{
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x154C3B0", Offset = "0x154B5B0", VA = "0x18154C3B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C4")]
	internal List<Tab> tabs
	{
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x29FCCC0", Offset = "0x29FBEC0", VA = "0x1829FCCC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C5")]
	internal List<VisualElement> tabHeaders
	{
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x2AAE730", Offset = "0x2AAD930", VA = "0x182AAE730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C6")]
	public Tab activeTab
	{
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x29FCCD0", Offset = "0x29FBED0", VA = "0x1829FCCD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x2B004E0", Offset = "0x2AFF6E0", VA = "0x182B004E0")]
		set
		{
		}
	}

	[Token(Token = "0x170001C7")]
	[CreateProperty]
	public bool reorderable
	{
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x2B004D0", Offset = "0x2AFF6D0", VA = "0x182B004D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x2B00690", Offset = "0x2AFF890", VA = "0x182B00690")]
		set
		{
		}
	}

	[Token(Token = "0x6000A5F")]
	[Address(RVA = "0x2B000C0", Offset = "0x2AFF2C0", VA = "0x182B000C0")]
	public TabView()
	{
	}

	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x2AFF9E0", Offset = "0x2AFEBE0", VA = "0x182AFF9E0", Slot = "133")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x2AFFCF0", Offset = "0x2AFEEF0", VA = "0x182AFFCF0")]
	private void SaveViewState()
	{
	}

	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x2AFFD30", Offset = "0x2AFEF30", VA = "0x182AFFD30")]
	private void UpdateIndexes()
	{
	}

	[Token(Token = "0x6000A63")]
	[Address(RVA = "0x2AFF5D0", Offset = "0x2AFE7D0", VA = "0x182AFF5D0")]
	private void OnElementAdded(VisualElement ve, int index)
	{
	}

	[Token(Token = "0x6000A64")]
	[Address(RVA = "0x2AFF7B0", Offset = "0x2AFE9B0", VA = "0x182AFF7B0")]
	private void OnElementRemoved(VisualElement ve)
	{
	}

	[Token(Token = "0x6000A65")]
	[Address(RVA = "0x2AFF9D0", Offset = "0x2AFEBD0", VA = "0x182AFF9D0")]
	private void OnTabSelected(Tab tab)
	{
	}

	[Token(Token = "0x6000A66")]
	[Address(RVA = "0x2AFF990", Offset = "0x2AFEB90", VA = "0x182AFF990")]
	private void OnTabClosed(Tab tab)
	{
	}

	[Token(Token = "0x6000A67")]
	[Address(RVA = "0x2AFFAD0", Offset = "0x2AFECD0", VA = "0x182AFFAD0")]
	public void ReorderTab(int from, int to)
	{
	}

	[Token(Token = "0x6000A68")]
	[Address(RVA = "0x2AFF4F0", Offset = "0x2AFE6F0", VA = "0x182AFF4F0")]
	internal Tab FindTabByKey(string key)
	{
		return null;
	}
}
