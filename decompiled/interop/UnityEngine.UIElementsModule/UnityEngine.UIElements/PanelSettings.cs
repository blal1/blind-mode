using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200025B")]
[HelpURL("UIE-Runtime-Panel-Settings")]
public class PanelSettings : ScriptableObject
{
	[Token(Token = "0x200025C")]
	private class RuntimePanelAccess
	{
		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly PanelSettings m_Settings;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BaseRuntimePanel m_RuntimePanel;

		[Token(Token = "0x17000317")]
		internal bool isInitialized
		{
			[Token(Token = "0x6001095")]
			[Address(RVA = "0x5C4390", Offset = "0x5C3590", VA = "0x1805C4390")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000318")]
		internal BaseRuntimePanel panel
		{
			[Token(Token = "0x6001096")]
			[Address(RVA = "0x2B3A9A0", Offset = "0x2B39BA0", VA = "0x182B3A9A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001094")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		internal RuntimePanelAccess(PanelSettings settings)
		{
		}

		[Token(Token = "0x6001097")]
		[Address(RVA = "0x2B3A6F0", Offset = "0x2B398F0", VA = "0x182B3A6F0")]
		internal void DisposePanel()
		{
		}

		[Token(Token = "0x6001098")]
		[Address(RVA = "0x2B3A960", Offset = "0x2B39B60", VA = "0x182B3A960")]
		internal void SetTargetTexture()
		{
		}

		[Token(Token = "0x6001099")]
		[Address(RVA = "0x2B3A8F0", Offset = "0x2B39AF0", VA = "0x182B3A8F0")]
		internal void SetSortingPriority()
		{
		}

		[Token(Token = "0x600109A")]
		[Address(RVA = "0x2B3A930", Offset = "0x2B39B30", VA = "0x182B3A930")]
		internal void SetTargetDisplay()
		{
		}

		[Token(Token = "0x600109B")]
		[Address(RVA = "0x2B3A810", Offset = "0x2B39A10", VA = "0x182B3A810")]
		internal void SetPanelChangeReceiver()
		{
		}

		[Token(Token = "0x600109C")]
		[Address(RVA = "0x2B3A610", Offset = "0x2B39810", VA = "0x182B3A610")]
		private BaseRuntimePanel CreateRelatedRuntimePanel()
		{
			return null;
		}

		[Token(Token = "0x600109D")]
		[Address(RVA = "0x2B3A770", Offset = "0x2B39970", VA = "0x182B3A770")]
		private void DisposeRelatedPanel()
		{
		}

		[Token(Token = "0x600109E")]
		[Address(RVA = "0x2B3A7C0", Offset = "0x2B399C0", VA = "0x182B3A7C0")]
		internal void MarkPotentiallyEmpty()
		{
		}
	}

	[Token(Token = "0x400092F")]
	private const int k_DefaultSortingOrder = 0;

	[Token(Token = "0x4000930")]
	private const float k_DefaultScaleValue = 1f;

	[Token(Token = "0x4000931")]
	internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset";

	[Token(Token = "0x4000932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ThemeStyleSheet themeUss;

	[Token(Token = "0x4000933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool m_DisableNoThemeWarning;

	[Token(Token = "0x4000934")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RenderTexture m_TargetTexture;

	[Token(Token = "0x4000935")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private PanelRenderMode m_RenderMode;

	[Token(Token = "0x4000936")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private int m_WorldSpaceLayer;

	[Token(Token = "0x4000937")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PanelScaleMode m_ScaleMode;

	[Token(Token = "0x4000938")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float m_ReferenceSpritePixelsPerUnit;

	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float m_PixelsPerUnit;

	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float m_Scale;

	[Token(Token = "0x400093B")]
	private const float DefaultDpi = 96f;

	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float m_ReferenceDpi;

	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float m_FallbackDpi;

	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Vector2Int m_ReferenceResolution;

	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private PanelScreenMatchMode m_ScreenMatchMode;

	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[Range(0f, 1f)]
	[SerializeField]
	private float m_Match;

	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float m_SortingOrder;

	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private int m_TargetDisplay;

	[Token(Token = "0x4000943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private BindingLogLevel m_BindingLogLevel;

	[Token(Token = "0x4000944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private bool m_ClearDepthStencil;

	[Token(Token = "0x4000945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	[SerializeField]
	private bool m_ClearColor;

	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Color m_ColorClearValue;

	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private uint m_VertexBudget;

	[Token(Token = "0x4000948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private RuntimePanelAccess m_PanelAccess;

	[Token(Token = "0x4000949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	internal UIDocumentList m_AttachedUIDocumentsList;

	[Token(Token = "0x400094A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	[SerializeField]
	private DynamicAtlasSettings m_DynamicAtlasSettings;

	[Token(Token = "0x400094B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[HideInInspector]
	private Shader m_AtlasBlitShader;

	[Token(Token = "0x400094C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[HideInInspector]
	private Shader m_RuntimeShader;

	[Token(Token = "0x400094D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	[SerializeField]
	private Shader m_RuntimeWorldShader;

	[Token(Token = "0x400094E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[HideInInspector]
	private Shader m_SDFShader;

	[Token(Token = "0x400094F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[HideInInspector]
	private Shader m_BitmapShader;

	[Token(Token = "0x4000950")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	[HideInInspector]
	private Shader m_SpriteShader;

	[Token(Token = "0x4000951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	[HideInInspector]
	internal TextAsset m_ICUDataAsset;

	[Token(Token = "0x4000952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public bool forceGammaRendering;

	[Token(Token = "0x4000953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	public PanelTextSettings textSettings;

	[Token(Token = "0x4000954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Rect m_TargetRect;

	[Token(Token = "0x4000955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float m_ResolvedScale;

	[Token(Token = "0x4000956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private StyleSheet m_OldThemeUss;

	[Token(Token = "0x4000958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private IDebugPanelChangeReceiver m_PanelChangeReceiver;

	[Token(Token = "0x4000959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Func<Vector2, Vector2> m_AssignedScreenToPanel;

	[Token(Token = "0x170002FD")]
	public ThemeStyleSheet themeStyleSheet
	{
		[Token(Token = "0x6001052")]
		[Address(RVA = "0x1997BC0", Offset = "0x1996DC0", VA = "0x181997BC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001053")]
		[Address(RVA = "0x2B37400", Offset = "0x2B36600", VA = "0x182B37400")]
		set
		{
		}
	}

	[Token(Token = "0x170002FE")]
	public RenderTexture targetTexture
	{
		[Token(Token = "0x6001054")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001055")]
		[Address(RVA = "0x2B373A0", Offset = "0x2B365A0", VA = "0x182B373A0")]
		set
		{
		}
	}

	[Token(Token = "0x170002FF")]
	internal PanelRenderMode renderMode
	{
		[Token(Token = "0x6001056")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(PanelRenderMode);
		}
		[Token(Token = "0x6001057")]
		[Address(RVA = "0x49C0C0", Offset = "0x49B2C0", VA = "0x18049C0C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000300")]
	internal int worldSpaceLayer
	{
		[Token(Token = "0x6001058")]
		[Address(RVA = "0x6333C0", Offset = "0x6325C0", VA = "0x1806333C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001059")]
		[Address(RVA = "0x9941B0", Offset = "0x9933B0", VA = "0x1809941B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000301")]
	public PanelScaleMode scaleMode
	{
		[Token(Token = "0x600105A")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		get
		{
			return default(PanelScaleMode);
		}
		[Token(Token = "0x600105B")]
		[Address(RVA = "0x4A69B0", Offset = "0x4A5BB0", VA = "0x1804A69B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000302")]
	public float referenceSpritePixelsPerUnit
	{
		[Token(Token = "0x600105C")]
		[Address(RVA = "0x2684A60", Offset = "0x2683C60", VA = "0x182684A60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600105D")]
		[Address(RVA = "0x1FEC1B0", Offset = "0x1FEB3B0", VA = "0x181FEC1B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000303")]
	internal float pixelsPerUnit
	{
		[Token(Token = "0x600105E")]
		[Address(RVA = "0x28A00E0", Offset = "0x289F2E0", VA = "0x1828A00E0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600105F")]
		[Address(RVA = "0x5DC3D0", Offset = "0x5DB5D0", VA = "0x1805DC3D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000304")]
	public float scale
	{
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x416670", Offset = "0x415870", VA = "0x180416670")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x4166D0", Offset = "0x4158D0", VA = "0x1804166D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000305")]
	public float referenceDpi
	{
		[Token(Token = "0x6001062")]
		[Address(RVA = "0x1FEBF80", Offset = "0x1FEB180", VA = "0x181FEBF80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001063")]
		[Address(RVA = "0x2B372E0", Offset = "0x2B364E0", VA = "0x182B372E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000306")]
	public float fallbackDpi
	{
		[Token(Token = "0x6001064")]
		[Address(RVA = "0x44F110", Offset = "0x44E310", VA = "0x18044F110")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001065")]
		[Address(RVA = "0x2B372B0", Offset = "0x2B364B0", VA = "0x182B372B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000307")]
	public Vector2Int referenceResolution
	{
		[Token(Token = "0x6001066")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return default(Vector2Int);
		}
		[Token(Token = "0x6001067")]
		[Address(RVA = "0x994180", Offset = "0x993380", VA = "0x180994180")]
		set
		{
		}
	}

	[Token(Token = "0x17000308")]
	public PanelScreenMatchMode screenMatchMode
	{
		[Token(Token = "0x6001068")]
		[Address(RVA = "0x42D5A0", Offset = "0x42C7A0", VA = "0x18042D5A0")]
		get
		{
			return default(PanelScreenMatchMode);
		}
		[Token(Token = "0x6001069")]
		[Address(RVA = "0x42D670", Offset = "0x42C870", VA = "0x18042D670")]
		set
		{
		}
	}

	[Token(Token = "0x17000309")]
	public float match
	{
		[Token(Token = "0x600106A")]
		[Address(RVA = "0x1FEBF60", Offset = "0x1FEB160", VA = "0x181FEBF60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600106B")]
		[Address(RVA = "0x1FF41F0", Offset = "0x1FF33F0", VA = "0x181FF41F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700030A")]
	public float sortingOrder
	{
		[Token(Token = "0x600106C")]
		[Address(RVA = "0x1FFF0D0", Offset = "0x1FFE2D0", VA = "0x181FFF0D0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600106D")]
		[Address(RVA = "0x2B37310", Offset = "0x2B36510", VA = "0x182B37310")]
		set
		{
		}
	}

	[Token(Token = "0x1700030B")]
	public int targetDisplay
	{
		[Token(Token = "0x600106F")]
		[Address(RVA = "0x80A510", Offset = "0x809710", VA = "0x18080A510")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001070")]
		[Address(RVA = "0x2B37360", Offset = "0x2B36560", VA = "0x182B37360")]
		set
		{
		}
	}

	[Token(Token = "0x1700030C")]
	public BindingLogLevel bindingLogLevel
	{
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x6A9360", Offset = "0x6A8560", VA = "0x1806A9360")]
		get
		{
			return default(BindingLogLevel);
		}
		[Token(Token = "0x6001072")]
		[Address(RVA = "0x2B37260", Offset = "0x2B36460", VA = "0x182B37260")]
		set
		{
		}
	}

	[Token(Token = "0x1700030D")]
	public bool clearDepthStencil
	{
		[Token(Token = "0x6001073")]
		[Address(RVA = "0xF09E30", Offset = "0xF09030", VA = "0x180F09E30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001074")]
		[Address(RVA = "0xF09E60", Offset = "0xF09060", VA = "0x180F09E60")]
		set
		{
		}
	}

	[Token(Token = "0x1700030E")]
	public float depthClearValue
	{
		[Token(Token = "0x6001075")]
		[Address(RVA = "0x2B371B0", Offset = "0x2B363B0", VA = "0x182B371B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700030F")]
	public bool clearColor
	{
		[Token(Token = "0x6001076")]
		[Address(RVA = "0xF09E20", Offset = "0xF09020", VA = "0x180F09E20")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001077")]
		[Address(RVA = "0xF09E50", Offset = "0xF09050", VA = "0x180F09E50")]
		set
		{
		}
	}

	[Token(Token = "0x17000310")]
	public Color colorClearValue
	{
		[Token(Token = "0x6001078")]
		[Address(RVA = "0x2564BB0", Offset = "0x2563DB0", VA = "0x182564BB0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6001079")]
		[Address(RVA = "0x261C010", Offset = "0x261B210", VA = "0x18261C010")]
		set
		{
		}
	}

	[Token(Token = "0x17000311")]
	public uint vertexBudget
	{
		[Token(Token = "0x600107A")]
		[Address(RVA = "0x5889C0", Offset = "0x587BC0", VA = "0x1805889C0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600107B")]
		[Address(RVA = "0x588B20", Offset = "0x587D20", VA = "0x180588B20")]
		set
		{
		}
	}

	[Token(Token = "0x17000312")]
	internal BaseRuntimePanel panel
	{
		[Token(Token = "0x600107C")]
		[Address(RVA = "0x2B371E0", Offset = "0x2B363E0", VA = "0x182B371E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000313")]
	internal bool isInitialized
	{
		[Token(Token = "0x600107D")]
		[Address(RVA = "0x2B371C0", Offset = "0x2B363C0", VA = "0x182B371C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000314")]
	internal VisualElement visualTree
	{
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x2B37210", Offset = "0x2B36410", VA = "0x182B37210")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000315")]
	public DynamicAtlasSettings dynamicAtlasSettings
	{
		[Token(Token = "0x600107F")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x42FFD0", Offset = "0x42F1D0", VA = "0x18042FFD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000316")]
	private float ScreenDPI
	{
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x24B9F30", Offset = "0x24B9130", VA = "0x1824B9F30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6001087")]
		[Address(RVA = "0x2B37250", Offset = "0x2B36450", VA = "0x182B37250")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600106E")]
	[Address(RVA = "0x2B36350", Offset = "0x2B35550", VA = "0x182B36350")]
	internal void ApplySortingOrder()
	{
	}

	[Token(Token = "0x6001081")]
	[Address(RVA = "0x2B37020", Offset = "0x2B36220", VA = "0x182B37020")]
	private PanelSettings()
	{
	}

	[Token(Token = "0x6001082")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Reset()
	{
	}

	[Token(Token = "0x6001083")]
	[Address(RVA = "0x2B36C50", Offset = "0x2B35E50", VA = "0x182B36C50")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001084")]
	[Address(RVA = "0x2B36790", Offset = "0x2B35990", VA = "0x182B36790")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001085")]
	[Address(RVA = "0x2B36790", Offset = "0x2B35990", VA = "0x182B36790")]
	internal void DisposePanel()
	{
	}

	[Token(Token = "0x6001088")]
	[Address(RVA = "0x2B36E40", Offset = "0x2B36040", VA = "0x182B36E40")]
	[Conditional("ENABLE_PROFILER")]
	public void SetPanelChangeReceiver(IDebugPanelChangeReceiver value)
	{
	}

	[Token(Token = "0x6001089")]
	[Address(RVA = "0x2B36900", Offset = "0x2B35B00", VA = "0x182B36900")]
	internal IDebugPanelChangeReceiver GetPanelChangeReceiver()
	{
		return null;
	}

	[Token(Token = "0x600108A")]
	[Address(RVA = "0x2B37000", Offset = "0x2B36200", VA = "0x182B37000")]
	internal void UpdateScreenDPI()
	{
	}

	[Token(Token = "0x600108B")]
	[Address(RVA = "0x2B36390", Offset = "0x2B35590", VA = "0x182B36390")]
	private void ApplyThemeStyleSheet([Optional] VisualElement root)
	{
	}

	[Token(Token = "0x600108C")]
	[Address(RVA = "0xA2E980", Offset = "0xA2DB80", VA = "0x180A2E980")]
	internal bool AssignICUData()
	{
		return default(bool);
	}

	[Token(Token = "0x600108D")]
	[Address(RVA = "0x2B36910", Offset = "0x2B35B10", VA = "0x182B36910")]
	private void InitializeShaders()
	{
	}

	[Token(Token = "0x600108E")]
	[Address(RVA = "0x2B35700", Offset = "0x2B34900", VA = "0x182B35700")]
	internal void ApplyPanelSettings()
	{
	}

	[Token(Token = "0x600108F")]
	[Address(RVA = "0x2B36F40", Offset = "0x2B36140", VA = "0x182B36F40")]
	public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction)
	{
	}

	[Token(Token = "0x6001090")]
	[Address(RVA = "0x2B36D40", Offset = "0x2B35F40", VA = "0x182B36D40")]
	internal float ResolveScale(Rect targetRect, float screenDpi)
	{
		return default(float);
	}

	[Token(Token = "0x6001091")]
	[Address(RVA = "0x2B367C0", Offset = "0x2B359C0", VA = "0x182B367C0")]
	internal Rect GetDisplayRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6001092")]
	[Address(RVA = "0x2B36540", Offset = "0x2B35740", VA = "0x182B36540")]
	internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument)
	{
	}

	[Token(Token = "0x6001093")]
	[Address(RVA = "0x2B36670", Offset = "0x2B35870", VA = "0x182B36670")]
	internal void DetachUIDocument(UIDocument uiDocument)
	{
	}
}
