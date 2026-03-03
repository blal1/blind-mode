using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;

namespace UnityEngine.UIElements;

[Token(Token = "0x200046E")]
internal static class UIElementsRuntimeUtility
{
	[Token(Token = "0x200046F")]
	public delegate BaseRuntimePanel CreateRuntimePanelDelegate(ScriptableObject ownerObject);

	[Token(Token = "0x4000EE6")]
	[FieldOffset(Offset = "0x8")]
	private static bool s_RegisteredPlayerloopCallback;

	[Token(Token = "0x4000EE7")]
	[FieldOffset(Offset = "0x10")]
	private static List<Panel> s_SortedRuntimePanels;

	[Token(Token = "0x4000EE8")]
	[FieldOffset(Offset = "0x18")]
	private static bool s_PanelOrderingDirty;

	[Token(Token = "0x4000EE9")]
	[FieldOffset(Offset = "0x1C")]
	internal static int s_ResolvedSortingIndexMax;

	[Token(Token = "0x4000EEA")]
	[FieldOffset(Offset = "0x20")]
	internal static readonly string s_RepaintProfilerMarkerName;

	[Token(Token = "0x4000EEB")]
	[FieldOffset(Offset = "0x28")]
	private static readonly ProfilerMarker s_RepaintProfilerMarker;

	[Token(Token = "0x4000EEC")]
	[FieldOffset(Offset = "0x30")]
	private static int currentOverlayIndex;

	[Token(Token = "0x4000EEE")]
	[FieldOffset(Offset = "0x40")]
	private static DefaultEventSystem s_DefaultEventSystem;

	[Token(Token = "0x4000EEF")]
	[FieldOffset(Offset = "0x48")]
	private static List<PanelSettings> s_PotentiallyEmptyPanelSettings;

	[Token(Token = "0x17000904")]
	internal static Object activeEventSystem
	{
		[Token(Token = "0x6002188")]
		[Address(RVA = "0x2A173B0", Offset = "0x2A165B0", VA = "0x182A173B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002189")]
		[Address(RVA = "0x2A17690", Offset = "0x2A16890", VA = "0x182A17690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000905")]
	internal static bool useDefaultEventSystem
	{
		[Token(Token = "0x600218A")]
		[Address(RVA = "0x2A174D0", Offset = "0x2A166D0", VA = "0x182A174D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000906")]
	internal static DefaultEventSystem defaultEventSystem
	{
		[Token(Token = "0x600218D")]
		[Address(RVA = "0x2A17400", Offset = "0x2A16600", VA = "0x182A17400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400002F")]
	public static event Action<BaseRuntimePanel> onCreatePanel
	{
		[Token(Token = "0x6002179")]
		[Address(RVA = "0x2A172A0", Offset = "0x2A164A0", VA = "0x182A172A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600217A")]
		[Address(RVA = "0x2A17580", Offset = "0x2A16780", VA = "0x182A17580")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600217B")]
	[Address(RVA = "0x2A16F20", Offset = "0x2A16120", VA = "0x182A16F20")]
	static UIElementsRuntimeUtility()
	{
	}

	[Token(Token = "0x600217C")]
	[Address(RVA = "0x2A145E0", Offset = "0x2A137E0", VA = "0x182A145E0")]
	public static EventBase CreateEvent(Event systemEvent)
	{
		return null;
	}

	[Token(Token = "0x600217D")]
	[Address(RVA = "0x2A147E0", Offset = "0x2A139E0", VA = "0x182A147E0")]
	public static BaseRuntimePanel FindOrCreateRuntimePanel(ScriptableObject ownerObject, CreateRuntimePanelDelegate createDelegate)
	{
		return null;
	}

	[Token(Token = "0x600217E")]
	[Address(RVA = "0x2A14650", Offset = "0x2A13850", VA = "0x182A14650")]
	public static void DisposeRuntimePanel(ScriptableObject ownerObject)
	{
	}

	[Token(Token = "0x600217F")]
	[Address(RVA = "0x2A15140", Offset = "0x2A14340", VA = "0x182A15140")]
	private static void RegisterCachedPanelInternal(int instanceID, IPanel panel)
	{
	}

	[Token(Token = "0x6002180")]
	[Address(RVA = "0x2A157C0", Offset = "0x2A149C0", VA = "0x182A157C0")]
	private static void RemoveCachedPanelInternal(int instanceID)
	{
	}

	[Token(Token = "0x6002181")]
	[Address(RVA = "0x2A15C40", Offset = "0x2A14E40", VA = "0x182A15C40")]
	public static void RenderOffscreenPanels()
	{
	}

	[Token(Token = "0x6002182")]
	[Address(RVA = "0x2A161A0", Offset = "0x2A153A0", VA = "0x182A161A0")]
	public static void RepaintPanel(BaseRuntimePanel panel)
	{
	}

	[Token(Token = "0x6002183")]
	[Address(RVA = "0x2A160C0", Offset = "0x2A152C0", VA = "0x182A160C0")]
	public static void RenderPanel(BaseRuntimePanel panel, bool restoreState = true)
	{
	}

	[Token(Token = "0x6002184")]
	[Address(RVA = "0x2A14580", Offset = "0x2A13780", VA = "0x182A14580")]
	internal static void BeginRenderOverlays(int displayIndex)
	{
	}

	[Token(Token = "0x6002185")]
	[Address(RVA = "0x2A15E90", Offset = "0x2A15090", VA = "0x182A15E90")]
	internal static void RenderOverlaysBeforePriority(int displayIndex, float maxPriority)
	{
	}

	[Token(Token = "0x6002186")]
	[Address(RVA = "0x2A14770", Offset = "0x2A13970", VA = "0x182A14770")]
	internal static void EndRenderOverlays(int displayIndex)
	{
	}

	[Token(Token = "0x6002187")]
	[Address(RVA = "0x2A162D0", Offset = "0x2A154D0", VA = "0x182A162D0")]
	public static void RepaintPanels(bool onlyOffscreen)
	{
	}

	[Token(Token = "0x600218B")]
	[Address(RVA = "0x2A15410", Offset = "0x2A14610", VA = "0x182A15410")]
	public static void RegisterEventSystem(Object eventSystem)
	{
	}

	[Token(Token = "0x600218C")]
	[Address(RVA = "0x2A16990", Offset = "0x2A15B90", VA = "0x182A16990")]
	public static void UnregisterEventSystem(Object eventSystem)
	{
	}

	[Token(Token = "0x600218E")]
	[Address(RVA = "0x2A16C00", Offset = "0x2A15E00", VA = "0x182A16C00")]
	public static void UpdatePanels()
	{
	}

	[Token(Token = "0x600218F")]
	[Address(RVA = "0x2A14B80", Offset = "0x2A13D80", VA = "0x182A14B80")]
	internal static void MarkPotentiallyEmpty(PanelSettings settings)
	{
	}

	[Token(Token = "0x6002190")]
	[Address(RVA = "0x2A15A60", Offset = "0x2A14C60", VA = "0x182A15A60")]
	internal static void RemoveUnusedPanels()
	{
	}

	[Token(Token = "0x6002191")]
	[Address(RVA = "0x2A15660", Offset = "0x2A14860", VA = "0x182A15660")]
	public static void RegisterPlayerloopCallback()
	{
	}

	[Token(Token = "0x6002192")]
	[Address(RVA = "0x2A16AD0", Offset = "0x2A15CD0", VA = "0x182A16AD0")]
	public static void UnregisterPlayerloopCallback()
	{
	}

	[Token(Token = "0x6002193")]
	[Address(RVA = "0x2A16640", Offset = "0x2A15840", VA = "0x182A16640")]
	internal static void SetPanelOrderingDirty()
	{
	}

	[Token(Token = "0x6002194")]
	[Address(RVA = "0x2A14AE0", Offset = "0x2A13CE0", VA = "0x182A14AE0")]
	internal static List<Panel> GetSortedPlayerPanels()
	{
		return null;
	}

	[Token(Token = "0x6002195")]
	[Address(RVA = "0x2A16690", Offset = "0x2A15890", VA = "0x182A16690")]
	private static void SortPanels()
	{
	}

	[Token(Token = "0x6002196")]
	[Address(RVA = "0x2A14CB0", Offset = "0x2A13EB0", VA = "0x182A14CB0")]
	internal static Vector2 MultiDisplayBottomLeftToPanelPosition(Vector2 position, out int? targetDisplay)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6002197")]
	[Address(RVA = "0x2A14F90", Offset = "0x2A14190", VA = "0x182A14F90")]
	internal static Vector2 MultiDisplayToLocalScreenPosition(Vector2 position, out int? targetDisplay)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6002198")]
	[Address(RVA = "0x2A16540", Offset = "0x2A15740", VA = "0x182A16540")]
	internal static Vector2 ScreenBottomLeftToPanelPosition(Vector2 position, int targetDisplay)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6002199")]
	[Address(RVA = "0x2A164E0", Offset = "0x2A156E0", VA = "0x182A164E0")]
	internal static Vector2 ScreenBottomLeftToPanelDelta(Vector2 delta)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600219A")]
	[Address(RVA = "0x2A14A00", Offset = "0x2A13C00", VA = "0x182A14A00")]
	internal static Vector2 FlipY(Vector2 p, float displayHeight)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600219B")]
	[Address(RVA = "0x289A780", Offset = "0x2899980", VA = "0x18289A780")]
	private static Vector2 FlipDeltaY(Vector2 delta)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600219C")]
	[Address(RVA = "0x2A14A20", Offset = "0x2A13C20", VA = "0x182A14A20")]
	private static float GetRuntimeDisplayHeight(int targetDisplay)
	{
		return default(float);
	}
}
