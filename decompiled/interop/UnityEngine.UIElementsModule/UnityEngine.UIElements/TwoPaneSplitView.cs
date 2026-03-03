using System;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000168")]
public class TwoPaneSplitView : VisualElement
{
	[Token(Token = "0x2000169")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits>
	{
		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x2B0BF00", Offset = "0x2B0B100", VA = "0x182B0BF00")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200016A")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		[Token(Token = "0x400072C")]
		[FieldOffset(Offset = "0x88")]
		private UxmlIntAttributeDescription m_FixedPaneIndex;

		[Token(Token = "0x400072D")]
		[FieldOffset(Offset = "0x90")]
		private UxmlIntAttributeDescription m_FixedPaneInitialDimension;

		[Token(Token = "0x400072E")]
		[FieldOffset(Offset = "0x98")]
		private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation;

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x2B0C110", Offset = "0x2B0B310", VA = "0x182B0C110", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x2B0C840", Offset = "0x2B0BA40", VA = "0x182B0C840")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000710")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId fixedPaneIndexProperty;

	[Token(Token = "0x4000711")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId fixedPaneInitialDimensionProperty;

	[Token(Token = "0x4000712")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId orientationProperty;

	[Token(Token = "0x4000713")]
	[FieldOffset(Offset = "0x1C8")]
	private static readonly string s_UssClassName;

	[Token(Token = "0x4000714")]
	[FieldOffset(Offset = "0x1D0")]
	private static readonly string s_ContentContainerClassName;

	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0x1D8")]
	private static readonly string s_HandleDragLineClassName;

	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0x1E0")]
	private static readonly string s_HandleDragLineVerticalClassName;

	[Token(Token = "0x4000717")]
	[FieldOffset(Offset = "0x1E8")]
	private static readonly string s_HandleDragLineHorizontalClassName;

	[Token(Token = "0x4000718")]
	[FieldOffset(Offset = "0x1F0")]
	private static readonly string s_HandleDragLineAnchorClassName;

	[Token(Token = "0x4000719")]
	[FieldOffset(Offset = "0x1F8")]
	private static readonly string s_HandleDragLineAnchorVerticalClassName;

	[Token(Token = "0x400071A")]
	[FieldOffset(Offset = "0x200")]
	private static readonly string s_HandleDragLineAnchorHorizontalClassName;

	[Token(Token = "0x400071B")]
	[FieldOffset(Offset = "0x208")]
	private static readonly string s_VerticalClassName;

	[Token(Token = "0x400071C")]
	[FieldOffset(Offset = "0x210")]
	private static readonly string s_HorizontalClassName;

	[Token(Token = "0x400071D")]
	[FieldOffset(Offset = "0x4A8")]
	private VisualElement m_LeftPane;

	[Token(Token = "0x400071E")]
	[FieldOffset(Offset = "0x4B0")]
	private VisualElement m_RightPane;

	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x4B8")]
	private VisualElement m_FixedPane;

	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x4C0")]
	private VisualElement m_FlexedPane;

	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x4C8")]
	[SerializeField]
	[DontCreateProperty]
	private float m_FixedPaneDimension;

	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x4D0")]
	private VisualElement m_DragLine;

	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x4D8")]
	private VisualElement m_DragLineAnchor;

	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x4E0")]
	private bool m_CollapseMode;

	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x4E1")]
	private bool m_PendingCollapseToExecute;

	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x4E4")]
	private int m_CollapsedChildIndex;

	[Token(Token = "0x4000727")]
	[FieldOffset(Offset = "0x4E8")]
	private VisualElement m_Content;

	[Token(Token = "0x4000728")]
	[FieldOffset(Offset = "0x4F0")]
	private TwoPaneSplitViewOrientation m_Orientation;

	[Token(Token = "0x4000729")]
	[FieldOffset(Offset = "0x4F4")]
	private int m_FixedPaneIndex;

	[Token(Token = "0x400072A")]
	[FieldOffset(Offset = "0x4F8")]
	private float m_FixedPaneInitialDimension;

	[Token(Token = "0x400072B")]
	[FieldOffset(Offset = "0x500")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal TwoPaneSplitViewResizer m_Resizer;

	[Token(Token = "0x170001DC")]
	public VisualElement fixedPane
	{
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x29FCCC0", Offset = "0x29FBEC0", VA = "0x1829FCCC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DD")]
	public VisualElement flexedPane
	{
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x2AAE730", Offset = "0x2AAD930", VA = "0x182AAE730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DE")]
	internal VisualElement dragLine
	{
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x2A9D200", Offset = "0x2A9C400", VA = "0x182A9D200")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001DF")]
	[CreateProperty]
	public int fixedPaneIndex
	{
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x2B08FA0", Offset = "0x2B081A0", VA = "0x182B08FA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x2B08FE0", Offset = "0x2B081E0", VA = "0x182B08FE0")]
		set
		{
		}
	}

	[Token(Token = "0x170001E0")]
	[CreateProperty]
	public float fixedPaneInitialDimension
	{
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x2B08FB0", Offset = "0x2B081B0", VA = "0x182B08FB0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x2B09080", Offset = "0x2B08280", VA = "0x182B09080")]
		set
		{
		}
	}

	[Token(Token = "0x170001E1")]
	[CreateProperty]
	public TwoPaneSplitViewOrientation orientation
	{
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x137AB40", Offset = "0x1379D40", VA = "0x18137AB40")]
		get
		{
			return default(TwoPaneSplitViewOrientation);
		}
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x2B09130", Offset = "0x2B08330", VA = "0x182B09130")]
		set
		{
		}
	}

	[Token(Token = "0x170001E2")]
	internal float fixedPaneDimension
	{
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x2B08F60", Offset = "0x2B08160", VA = "0x182B08F60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x2B08FC0", Offset = "0x2B081C0", VA = "0x182B08FC0")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		set
		{
		}
	}

	[Token(Token = "0x170001E3")]
	public override VisualElement contentContainer
	{
		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x2B08F50", Offset = "0x2B08150", VA = "0x182B08F50", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000AE6")]
	[Address(RVA = "0x2B08EA0", Offset = "0x2B080A0", VA = "0x182B08EA0")]
	public TwoPaneSplitView()
	{
	}

	[Token(Token = "0x6000AE7")]
	[Address(RVA = "0x2B07E30", Offset = "0x2B07030", VA = "0x182B07E30")]
	private void SetupSplitView()
	{
	}

	[Token(Token = "0x6000AE8")]
	[Address(RVA = "0x2B05C50", Offset = "0x2B04E50", VA = "0x182B05C50")]
	public void CollapseChild(int index)
	{
	}

	[Token(Token = "0x6000AE9")]
	[Address(RVA = "0x2B06110", Offset = "0x2B05310", VA = "0x182B06110", Slot = "137")]
	internal virtual void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation)
	{
	}

	[Token(Token = "0x6000AEA")]
	[Address(RVA = "0x2B06520", Offset = "0x2B05720", VA = "0x182B06520")]
	private void OnPostDisplaySetup(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x6000AEB")]
	[Address(RVA = "0x2B07930", Offset = "0x2B06B30", VA = "0x182B07930")]
	private void ReplacePanesBasedOnAnchor()
	{
	}

	[Token(Token = "0x6000AEC")]
	[Address(RVA = "0x2B06020", Offset = "0x2B05220", VA = "0x182B06020")]
	private void IdentifyLeftAndRightPane()
	{
	}

	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x2B066A0", Offset = "0x2B058A0", VA = "0x182B066A0")]
	private void PostDisplaySetup()
	{
	}

	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x2B06650", Offset = "0x2B05850", VA = "0x182B06650")]
	private void OnSizeChange(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x2B080A0", Offset = "0x2B072A0", VA = "0x182B080A0")]
	private void UpdateLayout(bool updateFixedPane, bool updateDragLine)
	{
	}

	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x2B06660", Offset = "0x2B05860", VA = "0x182B06660", Slot = "133")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0x2B07B10", Offset = "0x2B06D10", VA = "0x182B07B10")]
	private void SetDragLineOffset(float offset)
	{
	}

	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x2B07CA0", Offset = "0x2B06EA0", VA = "0x182B07CA0")]
	private void SetFixedPaneDimension(float dimension)
	{
	}
}
