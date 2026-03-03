using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000474")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class UIElementsUtility : IUIElementsUtility
{
	[Token(Token = "0x4000EF4")]
	[FieldOffset(Offset = "0x0")]
	private static Stack<IMGUIContainer> s_ContainerStack;

	[Token(Token = "0x4000EF5")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, Panel> s_UIElementsCache;

	[Token(Token = "0x4000EF6")]
	[FieldOffset(Offset = "0x10")]
	private static Event s_EventInstance;

	[Token(Token = "0x4000EF7")]
	[FieldOffset(Offset = "0x18")]
	internal static Color editorPlayModeTintColor;

	[Token(Token = "0x4000EF8")]
	[FieldOffset(Offset = "0x28")]
	internal static float singleLineHeight;

	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0x2C")]
	internal static bool s_EnableOSXContextualMenuEventsOnNonOSXPlatforms;

	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0x30")]
	private static UIElementsUtility s_Instance;

	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x38")]
	internal static List<Panel> s_PanelsIterationList;

	[Token(Token = "0x4000EFC")]
	[FieldOffset(Offset = "0x40")]
	internal static readonly string s_RepaintProfilerMarkerName;

	[Token(Token = "0x4000EFD")]
	[FieldOffset(Offset = "0x48")]
	internal static readonly string s_EventProfilerMarkerName;

	[Token(Token = "0x4000EFE")]
	[FieldOffset(Offset = "0x50")]
	private static readonly ProfilerMarker s_RepaintProfilerMarker;

	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x58")]
	private static readonly ProfilerMarker s_EventProfilerMarker;

	[Token(Token = "0x4000F00")]
	[FieldOffset(Offset = "0x60")]
	internal static char[] s_Modifiers;

	[Token(Token = "0x17000907")]
	public static bool isOSXContextualMenuPlatform
	{
		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x2A194A0", Offset = "0x2A186A0", VA = "0x182A194A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60021BA")]
	[Address(RVA = "0x2A193E0", Offset = "0x2A185E0", VA = "0x182A193E0")]
	private UIElementsUtility()
	{
	}

	[Token(Token = "0x60021BB")]
	[Address(RVA = "0x2A18D00", Offset = "0x2A17F00", VA = "0x182A18D00", Slot = "9")]
	private bool UnityEngine_002EUIElements_002EIUIElementsUtility_002EMakeCurrentIMGUIContainerDirty()
	{
		return default(bool);
	}

	[Token(Token = "0x60021BC")]
	[Address(RVA = "0x2A18F00", Offset = "0x2A18100", VA = "0x182A18F00", Slot = "4")]
	private bool UnityEngine_002EUIElements_002EIUIElementsUtility_002ETakeCapture()
	{
		return default(bool);
	}

	[Token(Token = "0x60021BD")]
	[Address(RVA = "0xA2E980", Offset = "0xA2DB80", VA = "0x180A2E980", Slot = "5")]
	private bool UnityEngine_002EUIElements_002EIUIElementsUtility_002EReleaseCapture()
	{
		return default(bool);
	}

	[Token(Token = "0x60021BE")]
	[Address(RVA = "0x2A18DC0", Offset = "0x2A17FC0", VA = "0x182A18DC0", Slot = "6")]
	private bool UnityEngine_002EUIElements_002EIUIElementsUtility_002EProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled)
	{
		return default(bool);
	}

	[Token(Token = "0x60021BF")]
	[Address(RVA = "0x2A18B50", Offset = "0x2A17D50", VA = "0x182A18B50", Slot = "7")]
	private bool UnityEngine_002EUIElements_002EIUIElementsUtility_002ECleanupRoots()
	{
		return default(bool);
	}

	[Token(Token = "0x60021C0")]
	[Address(RVA = "0x2A18C20", Offset = "0x2A17E20", VA = "0x182A18C20", Slot = "8")]
	private bool UnityEngine_002EUIElements_002EIUIElementsUtility_002EEndContainerGUIFromException(Exception exception)
	{
		return default(bool);
	}

	[Token(Token = "0x60021C1")]
	[Address(RVA = "0x2A189B0", Offset = "0x2A17BB0", VA = "0x182A189B0")]
	public static void RegisterCachedPanel(int instanceID, Panel panel)
	{
	}

	[Token(Token = "0x60021C2")]
	[Address(RVA = "0x2A18A40", Offset = "0x2A17C40", VA = "0x182A18A40")]
	public static void RemoveCachedPanel(int instanceID)
	{
	}

	[Token(Token = "0x60021C3")]
	[Address(RVA = "0x2A18AC0", Offset = "0x2A17CC0", VA = "0x182A18AC0")]
	public static bool TryGetPanel(int instanceID, out Panel panel)
	{
		return default(bool);
	}

	[Token(Token = "0x60021C4")]
	[Address(RVA = "0x2A17700", Offset = "0x2A16900", VA = "0x182A17700")]
	internal static void BeginContainerGUI(GUILayoutUtility.LayoutCache cache, Event evt, IMGUIContainer container)
	{
	}

	[Token(Token = "0x60021C5")]
	[Address(RVA = "0x2A18330", Offset = "0x2A17530", VA = "0x182A18330")]
	internal static void EndContainerGUI(Event evt, Rect layoutSize)
	{
	}

	[Token(Token = "0x60021C6")]
	[Address(RVA = "0x2A17960", Offset = "0x2A16B60", VA = "0x182A17960")]
	internal static EventBase CreateEvent(Event systemEvent)
	{
		return null;
	}

	[Token(Token = "0x60021C7")]
	[Address(RVA = "0x2A179D0", Offset = "0x2A16BD0", VA = "0x182A179D0")]
	internal static EventBase CreateEvent(Event systemEvent, EventType eventType)
	{
		return null;
	}

	[Token(Token = "0x60021C8")]
	[Address(RVA = "0x2A17D80", Offset = "0x2A16F80", VA = "0x182A17D80")]
	private static bool DoDispatch(BaseVisualElementPanel panel)
	{
		return default(bool);
	}

	[Token(Token = "0x60021C9")]
	[Address(RVA = "0x2A18570", Offset = "0x2A17770", VA = "0x182A18570")]
	internal static void GetAllPanels(List<Panel> panels, ContextType contextType)
	{
	}

	[Token(Token = "0x60021CA")]
	[Address(RVA = "0x2A186F0", Offset = "0x2A178F0", VA = "0x182A186F0")]
	internal static Dictionary<int, Panel>.Enumerator GetPanelsIterator()
	{
		return default(Dictionary<int, Panel>.Enumerator);
	}

	[Token(Token = "0x60021CB")]
	[Address(RVA = "0x2A188E0", Offset = "0x2A17AE0", VA = "0x182A188E0")]
	internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite)
	{
		return default(float);
	}

	[Token(Token = "0x60021CC")]
	[Address(RVA = "0x2A187A0", Offset = "0x2A179A0", VA = "0x182A187A0")]
	internal static string ParseMenuName(string menuName)
	{
		return null;
	}
}
