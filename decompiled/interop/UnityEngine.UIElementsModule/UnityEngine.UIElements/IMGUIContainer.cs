using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200026A")]
public class IMGUIContainer : VisualElement, IDisposable
{
	[Token(Token = "0x200026B")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<IMGUIContainer, UxmlTraits>
	{
		[Token(Token = "0x6001112")]
		[Address(RVA = "0x2B40F50", Offset = "0x2B40150", VA = "0x182B40F50")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200026C")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		[Token(Token = "0x6001113")]
		[Address(RVA = "0x2B40F90", Offset = "0x2B40190", VA = "0x182B40F90")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x200026D")]
	private struct GUIGlobals
	{
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x0")]
		public Matrix4x4 matrix;

		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x40")]
		public Color color;

		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x50")]
		public Color contentColor;

		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x60")]
		public Color backgroundColor;

		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x70")]
		public bool enabled;

		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x71")]
		public bool changed;

		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x74")]
		public int displayIndex;

		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x78")]
		public float pixelsPerPoint;
	}

	[Token(Token = "0x400097D")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId cullingEnabledProperty;

	[Token(Token = "0x400097E")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId contextTypeProperty;

	[Token(Token = "0x400097F")]
	[FieldOffset(Offset = "0x4A8")]
	private Action m_OnGUIHandler;

	[Token(Token = "0x4000980")]
	[FieldOffset(Offset = "0x4B0")]
	private UnityEngine.ObjectGUIState m_ObjectGUIState;

	[Token(Token = "0x4000981")]
	[FieldOffset(Offset = "0x4B8")]
	internal bool useOwnerObjectGUIState;

	[Token(Token = "0x4000983")]
	[FieldOffset(Offset = "0x4CC")]
	private bool m_CullingEnabled;

	[Token(Token = "0x4000984")]
	[FieldOffset(Offset = "0x4CD")]
	private bool m_IsFocusDelegated;

	[Token(Token = "0x4000985")]
	[FieldOffset(Offset = "0x4CE")]
	private bool m_RefreshCachedLayout;

	[Token(Token = "0x4000986")]
	[FieldOffset(Offset = "0x4D0")]
	private GUILayoutUtility.LayoutCache m_Cache;

	[Token(Token = "0x4000987")]
	[FieldOffset(Offset = "0x4D8")]
	private Rect m_CachedClippingRect;

	[Token(Token = "0x4000988")]
	[FieldOffset(Offset = "0x4E8")]
	private Matrix4x4 m_CachedTransform;

	[Token(Token = "0x4000989")]
	[FieldOffset(Offset = "0x528")]
	private ContextType m_ContextType;

	[Token(Token = "0x400098A")]
	[FieldOffset(Offset = "0x52C")]
	private bool lostFocus;

	[Token(Token = "0x400098B")]
	[FieldOffset(Offset = "0x52D")]
	private bool receivedFocus;

	[Token(Token = "0x400098C")]
	[FieldOffset(Offset = "0x530")]
	private FocusChangeDirection focusChangeDirection;

	[Token(Token = "0x400098D")]
	[FieldOffset(Offset = "0x538")]
	private bool hasFocusableControls;

	[Token(Token = "0x400098E")]
	[FieldOffset(Offset = "0x53C")]
	private int newKeyboardFocusControlID;

	[Token(Token = "0x4000990")]
	[FieldOffset(Offset = "0x130")]
	public static readonly string ussClassName;

	[Token(Token = "0x4000991")]
	[FieldOffset(Offset = "0x138")]
	internal static readonly string ussFoldoutChildDepthClassName;

	[Token(Token = "0x4000992")]
	[FieldOffset(Offset = "0x140")]
	internal static readonly List<string> ussFoldoutChildDepthClassNames;

	[Token(Token = "0x4000993")]
	[FieldOffset(Offset = "0x544")]
	private GUIGlobals m_GUIGlobals;

	[Token(Token = "0x4000994")]
	[FieldOffset(Offset = "0x148")]
	private static readonly ProfilerMarker k_OnGUIMarker;

	[Token(Token = "0x4000995")]
	[FieldOffset(Offset = "0x150")]
	private static readonly ProfilerMarker k_ImmediateCallbackMarker;

	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x158")]
	private static Event s_DefaultMeasureEvent;

	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x160")]
	private static Event s_MeasureEvent;

	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x168")]
	private static Event s_CurrentEvent;

	[Token(Token = "0x17000323")]
	public Action onGUIHandler
	{
		[Token(Token = "0x60010E8")]
		[Address(RVA = "0x2B32DB0", Offset = "0x2B31FB0", VA = "0x182B32DB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010E9")]
		[Address(RVA = "0x2B32EE0", Offset = "0x2B320E0", VA = "0x182B32EE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000324")]
	internal UnityEngine.ObjectGUIState guiState
	{
		[Token(Token = "0x60010EA")]
		[Address(RVA = "0x2B32C80", Offset = "0x2B31E80", VA = "0x182B32C80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000325")]
	internal Rect lastWorldClip
	{
		[Token(Token = "0x60010EB")]
		[Address(RVA = "0x2B32D40", Offset = "0x2B31F40", VA = "0x182B32D40")]
		[CompilerGenerated]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x60010EC")]
		[Address(RVA = "0x2B32ED0", Offset = "0x2B320D0", VA = "0x182B32ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000326")]
	[CreateProperty]
	public bool cullingEnabled
	{
		[Token(Token = "0x60010ED")]
		[Address(RVA = "0x2B32C70", Offset = "0x2B31E70", VA = "0x182B32C70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60010EE")]
		[Address(RVA = "0x2B32E40", Offset = "0x2B32040", VA = "0x182B32E40")]
		set
		{
		}
	}

	[Token(Token = "0x17000327")]
	private GUILayoutUtility.LayoutCache cache
	{
		[Token(Token = "0x60010EF")]
		[Address(RVA = "0x2B32BC0", Offset = "0x2B31DC0", VA = "0x182B32BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000328")]
	private float layoutMeasuredWidth
	{
		[Token(Token = "0x60010F0")]
		[Address(RVA = "0x2B32D80", Offset = "0x2B31F80", VA = "0x182B32D80")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000329")]
	private float layoutMeasuredHeight
	{
		[Token(Token = "0x60010F1")]
		[Address(RVA = "0x2B32D50", Offset = "0x2B31F50", VA = "0x182B32D50")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700032A")]
	[CreateProperty]
	public ContextType contextType
	{
		[Token(Token = "0x60010F2")]
		[Address(RVA = "0x2AEE780", Offset = "0x2AED980", VA = "0x182AEE780")]
		get
		{
			return default(ContextType);
		}
		[Token(Token = "0x60010F3")]
		[Address(RVA = "0x2B32DC0", Offset = "0x2B31FC0", VA = "0x182B32DC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700032B")]
	internal bool focusOnlyIfHasFocusableControls
	{
		[Token(Token = "0x60010F4")]
		[Address(RVA = "0x2AAC9C0", Offset = "0x2AABBC0", VA = "0x182AAC9C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700032C")]
	public override bool canGrabFocus
	{
		[Token(Token = "0x60010F5")]
		[Address(RVA = "0x2B32C40", Offset = "0x2B31E40", VA = "0x182B32C40", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x2B32180", Offset = "0x2B31380", VA = "0x182B32180")]
	static IMGUIContainer()
	{
	}

	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x2B32BB0", Offset = "0x2B31DB0", VA = "0x182B32BB0")]
	public IMGUIContainer()
	{
	}

	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x2B32870", Offset = "0x2B31A70", VA = "0x182B32870")]
	public IMGUIContainer(Action onGUIHandler)
	{
	}

	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x2B31640", Offset = "0x2B30840", VA = "0x182B31640")]
	private void OnGenerateVisualContent(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x60010FA")]
	[Address(RVA = "0x2B31940", Offset = "0x2B30B40", VA = "0x182B31940")]
	private void SaveGlobals()
	{
	}

	[Token(Token = "0x60010FB")]
	[Address(RVA = "0x2B317C0", Offset = "0x2B309C0", VA = "0x182B317C0")]
	private void RestoreGlobals()
	{
	}

	[Token(Token = "0x60010FC")]
	[Address(RVA = "0x2B2ED40", Offset = "0x2B2DF40", VA = "0x182B2ED40")]
	private void DoOnGUI(Event evt, Matrix4x4 parentTransform, Rect clippingRect, bool isComputingLayout, Rect layoutSize, Action onGUIHandler, bool canAffectFocus = true)
	{
	}

	[Token(Token = "0x60010FD")]
	[Address(RVA = "0x2B31620", Offset = "0x2B30820", VA = "0x182B31620")]
	public void MarkDirtyLayout()
	{
	}

	[Token(Token = "0x60010FE")]
	[Address(RVA = "0x2B2E600", Offset = "0x2B2D800", VA = "0x182B2E600")]
	private void DoIMGUIRepaint()
	{
	}

	[Token(Token = "0x60010FF")]
	[Address(RVA = "0x2B31B60", Offset = "0x2B30D60", VA = "0x182B31B60")]
	internal bool SendEventToIMGUI(EventBase evt, bool canAffectFocus = true, bool verifyBounds = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6001100")]
	[Address(RVA = "0x2B31A80", Offset = "0x2B30C80", VA = "0x182B31A80")]
	private bool SendEventToIMGUIRaw(EventBase evt, bool canAffectFocus, bool verifyBounds)
	{
		return default(bool);
	}

	[Token(Token = "0x6001101")]
	[Address(RVA = "0x2B31F90", Offset = "0x2B31190", VA = "0x182B31F90")]
	private bool VerifyBounds(EventBase evt)
	{
		return default(bool);
	}

	[Token(Token = "0x6001102")]
	[Address(RVA = "0x2B31020", Offset = "0x2B30220", VA = "0x182B31020")]
	private bool IsContainerCapturingTheMouse()
	{
		return default(bool);
	}

	[Token(Token = "0x6001103")]
	[Address(RVA = "0x2B31440", Offset = "0x2B30640", VA = "0x182B31440")]
	private bool IsLocalEvent(EventBase evt)
	{
		return default(bool);
	}

	[Token(Token = "0x6001104")]
	[Address(RVA = "0x2B311E0", Offset = "0x2B303E0", VA = "0x182B311E0")]
	private bool IsEventInsideLocalWindow(EventBase evt)
	{
		return default(bool);
	}

	[Token(Token = "0x6001105")]
	[Address(RVA = "0x2B310F0", Offset = "0x2B302F0", VA = "0x182B310F0")]
	private static bool IsDockAreaMouseUp(EventBase evt)
	{
		return default(bool);
	}

	[Token(Token = "0x6001106")]
	[Address(RVA = "0x2B30910", Offset = "0x2B2FB10", VA = "0x182B30910")]
	internal bool HandleIMGUIEvent(Event e, bool canAffectFocus)
	{
		return default(bool);
	}

	[Token(Token = "0x6001107")]
	[Address(RVA = "0x2B30640", Offset = "0x2B2F840", VA = "0x182B30640")]
	internal bool HandleIMGUIEvent(Event e, Action onGUIHandler, bool canAffectFocus)
	{
		return default(bool);
	}

	[Token(Token = "0x6001108")]
	[Address(RVA = "0x2B30BE0", Offset = "0x2B2FDE0", VA = "0x182B30BE0")]
	private bool HandleIMGUIEvent(Event e, Matrix4x4 worldTransform, Rect clippingRect, Action onGUIHandler, bool canAffectFocus)
	{
		return default(bool);
	}

	[Token(Token = "0x6001109")]
	[Address(RVA = "0x21186B0", Offset = "0x21178B0", VA = "0x1821186B0", Slot = "9")]
	[EventInterest(new Type[]
	{
		typeof(NavigationMoveEvent),
		typeof(NavigationSubmitEvent),
		typeof(NavigationCancelEvent),
		typeof(BlurEvent),
		typeof(FocusEvent),
		typeof(DetachFromPanelEvent),
		typeof(AttachToPanelEvent)
	})]
	[EventInterest(EventInterestOptionsInternal.TriggeredByOS)]
	internal override void HandleEventBubbleUpDisabled(EventBase evt)
	{
	}

	[Token(Token = "0x600110A")]
	[Address(RVA = "0x2B2FFD0", Offset = "0x2B2F1D0", VA = "0x182B2FFD0", Slot = "8")]
	[EventInterest(new Type[]
	{
		typeof(NavigationMoveEvent),
		typeof(NavigationSubmitEvent),
		typeof(NavigationCancelEvent),
		typeof(BlurEvent),
		typeof(FocusEvent),
		typeof(DetachFromPanelEvent),
		typeof(AttachToPanelEvent)
	})]
	[EventInterest(EventInterestOptionsInternal.TriggeredByOS)]
	protected override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x600110B")]
	[Address(RVA = "0x2B31E00", Offset = "0x2B31000", VA = "0x182B31E00")]
	private void SetFoldoutDepthClass()
	{
	}

	[Token(Token = "0x600110C")]
	[Address(RVA = "0x2B2EA30", Offset = "0x2B2DC30", VA = "0x182B2EA30", Slot = "135")]
	protected internal override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600110D")]
	[Address(RVA = "0x2B2FD30", Offset = "0x2B2EF30", VA = "0x182B2FD30")]
	private Rect GetCurrentClipRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x600110E")]
	[Address(RVA = "0x2B2FDB0", Offset = "0x2B2EFB0", VA = "0x182B2FDB0")]
	private static void GetCurrentTransformAndClip(IMGUIContainer container, Event evt, out Matrix4x4 transform, out Rect clipRect)
	{
	}

	[Token(Token = "0x600110F")]
	[Address(RVA = "0x2B2E570", Offset = "0x2B2D770", VA = "0x182B2E570", Slot = "137")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6001110")]
	[Address(RVA = "0x2B2E5E0", Offset = "0x2B2D7E0", VA = "0x182B2E5E0", Slot = "138")]
	protected virtual void Dispose(bool disposeManaged)
	{
	}
}
