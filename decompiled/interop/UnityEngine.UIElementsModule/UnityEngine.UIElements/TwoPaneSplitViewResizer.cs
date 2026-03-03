using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x200016C")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class TwoPaneSplitViewResizer : PointerManipulator
{
	[Token(Token = "0x4000732")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_Start;

	[Token(Token = "0x4000733")]
	[FieldOffset(Offset = "0x34")]
	protected bool m_Active;

	[Token(Token = "0x4000734")]
	[FieldOffset(Offset = "0x38")]
	private TwoPaneSplitView m_SplitView;

	[Token(Token = "0x4000735")]
	[FieldOffset(Offset = "0x40")]
	private int m_Direction;

	[Token(Token = "0x4000736")]
	[FieldOffset(Offset = "0x44")]
	private float m_Delta;

	[Token(Token = "0x170001E4")]
	private TwoPaneSplitViewOrientation orientation
	{
		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x2B05C30", Offset = "0x2B04E30", VA = "0x182B05C30")]
		get
		{
			return default(TwoPaneSplitViewOrientation);
		}
	}

	[Token(Token = "0x170001E5")]
	private VisualElement fixedPane
	{
		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x2B05A30", Offset = "0x2B04C30", VA = "0x182B05A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E6")]
	private VisualElement flexedPane
	{
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x2B05C10", Offset = "0x2B04E10", VA = "0x182B05C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E7")]
	private float fixedPaneMinDimension
	{
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x2B05990", Offset = "0x2B04B90", VA = "0x182B05990")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170001E8")]
	private float fixedPaneMargins
	{
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x2B05870", Offset = "0x2B04A70", VA = "0x182B05870")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170001E9")]
	private float flexedPaneMinDimension
	{
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x2B05B70", Offset = "0x2B04D70", VA = "0x182B05B70")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170001EA")]
	private float flexedPaneMargin
	{
		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x2B05A50", Offset = "0x2B04C50", VA = "0x182B05A50")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x2B05750", Offset = "0x2B04950", VA = "0x182B05750")]
	public TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir)
	{
	}

	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x2B05430", Offset = "0x2B04630", VA = "0x182B05430", Slot = "5")]
	protected override void RegisterCallbacksOnTarget()
	{
	}

	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x2B055C0", Offset = "0x2B047C0", VA = "0x182B055C0", Slot = "6")]
	protected override void UnregisterCallbacksFromTarget()
	{
	}

	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x2B04560", Offset = "0x2B03760", VA = "0x182B04560")]
	public void ApplyDelta(float delta)
	{
	}

	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x2B04F10", Offset = "0x2B04110", VA = "0x182B04F10")]
	protected void OnPointerDown(PointerDownEvent e)
	{
	}

	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x2B04FD0", Offset = "0x2B041D0", VA = "0x182B04FD0")]
	protected void OnPointerMove(PointerMoveEvent e)
	{
	}

	[Token(Token = "0x6000B05")]
	[Address(RVA = "0x2B05380", Offset = "0x2B04580", VA = "0x182B05380")]
	protected void OnPointerUp(PointerUpEvent e)
	{
	}

	[Token(Token = "0x6000B06")]
	[Address(RVA = "0x2B04E90", Offset = "0x2B04090", VA = "0x182B04E90")]
	protected void InterruptPointerMove(PointerMoveEvent e)
	{
	}
}
