using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000295")]
internal abstract class BaseRuntimePanel : Panel
{
	[Token(Token = "0x4000A68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private GameObject m_SelectableGameObject;

	[Token(Token = "0x4000A69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int s_CurrentRuntimePanelCounter;

	[Token(Token = "0x4000A6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	internal readonly int m_RuntimePanelCreationIndex;

	[Token(Token = "0x4000A6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	private float m_SortingPriority;

	[Token(Token = "0x4000A6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	internal int resolvedSortingIndex;

	[Token(Token = "0x4000A6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private bool m_DrawsInCameras;

	[Token(Token = "0x4000A70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
	private float m_PixelsPerUnit;

	[Token(Token = "0x4000A71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	internal RenderTexture targetTexture;

	[Token(Token = "0x4000A72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	internal int worldSpaceLayer;

	[Token(Token = "0x4000A74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	internal static readonly Func<Vector2, Vector2> DefaultScreenToPanelSpace;

	[Token(Token = "0x4000A75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private Func<Vector2, Vector2> m_ScreenToPanelSpace;

	[Token(Token = "0x1700036C")]
	public GameObject selectableGameObject
	{
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x49BEC0", Offset = "0x49B0C0", VA = "0x18049BEC0", Slot = "55")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x2B28660", Offset = "0x2B27860", VA = "0x182B28660", Slot = "56")]
		set
		{
		}
	}

	[Token(Token = "0x1700036D")]
	public float sortingPriority
	{
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x2B28400", Offset = "0x2B27600", VA = "0x182B28400")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60011FC")]
		[Address(RVA = "0x2B28700", Offset = "0x2B27900", VA = "0x182B28700")]
		set
		{
		}
	}

	[Token(Token = "0x1700036E")]
	internal bool drawsInCameras
	{
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x2B28340", Offset = "0x2B27540", VA = "0x182B28340")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x2B28580", Offset = "0x2B27780", VA = "0x182B28580")]
		set
		{
		}
	}

	[Token(Token = "0x1700036F")]
	internal float pixelsPerUnit
	{
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x2B28350", Offset = "0x2B27550", VA = "0x182B28350")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001207")]
		[Address(RVA = "0x2B285C0", Offset = "0x2B277C0", VA = "0x182B285C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000370")]
	internal int targetDisplay
	{
		[Token(Token = "0x6001208")]
		[Address(RVA = "0x2B28410", Offset = "0x2B27610", VA = "0x182B28410")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001209")]
		[Address(RVA = "0x2B28790", Offset = "0x2B27990", VA = "0x182B28790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000371")]
	internal int screenRenderingWidth
	{
		[Token(Token = "0x600120A")]
		[Address(RVA = "0x2B283B0", Offset = "0x2B275B0", VA = "0x182B283B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000372")]
	internal int screenRenderingHeight
	{
		[Token(Token = "0x600120B")]
		[Address(RVA = "0x2B28360", Offset = "0x2B27560", VA = "0x182B28360")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000373")]
	public Func<Vector2, Vector2> screenToPanelSpace
	{
		[Token(Token = "0x6001210")]
		[Address(RVA = "0x49BCD0", Offset = "0x49AED0", VA = "0x18049BCD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001211")]
		[Address(RVA = "0x2B285D0", Offset = "0x2B277D0", VA = "0x182B285D0")]
		set
		{
		}
	}

	[Token(Token = "0x1400002B")]
	public event Action destroyed
	{
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x2B28060", Offset = "0x2B27260", VA = "0x182B28060")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60011FE")]
		[Address(RVA = "0x2B28420", Offset = "0x2B27620", VA = "0x182B28420")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400002C")]
	internal event Action drawsInCamerasChanged
	{
		[Token(Token = "0x6001201")]
		[Address(RVA = "0x2B28110", Offset = "0x2B27310", VA = "0x182B28110")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6001202")]
		[Address(RVA = "0x2B284D0", Offset = "0x2B276D0", VA = "0x182B284D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x2B27F50", Offset = "0x2B27150", VA = "0x182B27F50")]
	protected BaseRuntimePanel(ScriptableObject ownerObject, [Optional] EventDispatcher dispatcher)
	{
	}

	[Token(Token = "0x6001200")]
	[Address(RVA = "0x2B27580", Offset = "0x2B26780", VA = "0x182B27580", Slot = "22")]
	protected override void Dispose(bool disposing)
	{
	}

	[Token(Token = "0x6001203")]
	[Address(RVA = "0x2B275E0", Offset = "0x2B267E0", VA = "0x182B275E0")]
	private void InvokeDrawsInCamerasChanged()
	{
	}

	[Token(Token = "0x600120C")]
	[Address(RVA = "0x2B27DA0", Offset = "0x2B26FA0", VA = "0x182B27DA0", Slot = "57")]
	internal virtual void Update()
	{
	}

	[Token(Token = "0x600120D")]
	[Address(RVA = "0x2B281C0", Offset = "0x2B273C0", VA = "0x182B281C0")]
	internal static int getScreenRenderingHeight(int display)
	{
		return default(int);
	}

	[Token(Token = "0x600120E")]
	[Address(RVA = "0x2B28280", Offset = "0x2B27480", VA = "0x182B28280")]
	internal static int getScreenRenderingWidth(int display)
	{
		return default(int);
	}

	[Token(Token = "0x600120F")]
	[Address(RVA = "0x2B27760", Offset = "0x2B26960", VA = "0x182B27760", Slot = "53")]
	public override void Render()
	{
	}

	[Token(Token = "0x6001212")]
	[Address(RVA = "0x2B27AA0", Offset = "0x2B26CA0", VA = "0x182B27AA0")]
	internal Vector2 ScreenToPanel(Vector2 screen)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001213")]
	[Address(RVA = "0x2B27B00", Offset = "0x2B26D00", VA = "0x182B27B00")]
	internal bool ScreenToPanel(Vector2 screenPosition, Vector2 screenDelta, out Vector2 panelPosition, out Vector2 panelDelta, bool allowOutside = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001214")]
	[Address(RVA = "0x2B27290", Offset = "0x2B26490", VA = "0x182B27290")]
	private void AssignPanelToComponents(BaseRuntimePanel panel)
	{
	}

	[Token(Token = "0x6001215")]
	[Address(RVA = "0x2B276A0", Offset = "0x2B268A0", VA = "0x182B276A0")]
	internal void PointerLeavesPanel(int pointerId, Vector2 position)
	{
	}

	[Token(Token = "0x6001216")]
	[Address(RVA = "0x2B27600", Offset = "0x2B26800", VA = "0x182B27600")]
	internal void PointerEntersPanel(int pointerId, Vector2 position)
	{
	}
}
