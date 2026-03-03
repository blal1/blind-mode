using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000262")]
[AddComponentMenu("UI Toolkit/UI Document")]
[ExecuteAlways]
[DisallowMultipleComponent]
[DefaultExecutionOrder(-100)]
[HelpURL("UIE-get-started-with-runtime-ui")]
public sealed class UIDocument : MonoBehaviour
{
	[Token(Token = "0x2000263")]
	internal enum WorldSpaceSizeMode
	{
		[Token(Token = "0x4000975")]
		Dynamic,
		[Token(Token = "0x4000976")]
		Fixed
	}

	[Token(Token = "0x4000961")]
	internal const string k_RootStyleClassName = "unity-ui-document__root";

	[Token(Token = "0x4000962")]
	internal const string k_VisualElementNameSuffix = "-container";

	[Token(Token = "0x4000963")]
	private const int k_DefaultSortingOrder = 0;

	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x0")]
	private static int s_CurrentUIDocumentCounter;

	[Token(Token = "0x4000965")]
	[FieldOffset(Offset = "0x20")]
	internal readonly int m_UIDocumentCreationIndex;

	[Token(Token = "0x4000966")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PanelSettings m_PanelSettings;

	[Token(Token = "0x4000967")]
	[FieldOffset(Offset = "0x30")]
	private PanelSettings m_PreviousPanelSettings;

	[Token(Token = "0x4000968")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UIDocument m_ParentUI;

	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x40")]
	private UIDocumentList m_ChildrenContent;

	[Token(Token = "0x400096A")]
	[FieldOffset(Offset = "0x48")]
	private List<UIDocument> m_ChildrenContentCopy;

	[Token(Token = "0x400096B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private VisualTreeAsset sourceAsset;

	[Token(Token = "0x400096C")]
	[FieldOffset(Offset = "0x58")]
	private VisualElement m_RootVisualElement;

	[Token(Token = "0x400096D")]
	[FieldOffset(Offset = "0x60")]
	private RuntimePanel m_RuntimePanel;

	[Token(Token = "0x400096E")]
	[FieldOffset(Offset = "0x68")]
	private int m_FirstChildInsertIndex;

	[Token(Token = "0x400096F")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float m_SortingOrder;

	[Token(Token = "0x4000970")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private WorldSpaceSizeMode m_WorldSpaceSizeMode;

	[Token(Token = "0x4000971")]
	[FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float m_WorldSpaceWidth;

	[Token(Token = "0x4000972")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float m_WorldSpaceHeight;

	[Token(Token = "0x4000973")]
	[FieldOffset(Offset = "0x7C")]
	private bool m_RootHasWorldTransform;

	[Token(Token = "0x1700031A")]
	public PanelSettings panelSettings
	{
		[Token(Token = "0x60010AC")]
		[Address(RVA = "0x276AD30", Offset = "0x2769F30", VA = "0x18276AD30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010AD")]
		[Address(RVA = "0x2B406F0", Offset = "0x2B3F8F0", VA = "0x182B406F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700031B")]
	public UIDocument parentUI
	{
		[Token(Token = "0x60010AE")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010AF")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		private set
		{
		}
	}

	[Token(Token = "0x1700031C")]
	public VisualTreeAsset visualTreeAsset
	{
		[Token(Token = "0x60010B0")]
		[Address(RVA = "0x287DC80", Offset = "0x287CE80", VA = "0x18287DC80")]
		get
		{
			return null;
		}
		[Token(Token = "0x60010B1")]
		[Address(RVA = "0x2B409E0", Offset = "0x2B3FBE0", VA = "0x182B409E0")]
		set
		{
		}
	}

	[Token(Token = "0x1700031D")]
	public VisualElement rootVisualElement
	{
		[Token(Token = "0x60010B2")]
		[Address(RVA = "0x287DBC0", Offset = "0x287CDC0", VA = "0x18287DBC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700031E")]
	internal int firstChildInserIndex
	{
		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x6A9360", Offset = "0x6A8560", VA = "0x1806A9360")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700031F")]
	internal WorldSpaceSizeMode worldSpaceSizeMode
	{
		[Token(Token = "0x60010B4")]
		[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
		get
		{
			return default(WorldSpaceSizeMode);
		}
	}

	[Token(Token = "0x17000320")]
	public float sortingOrder
	{
		[Token(Token = "0x60010B5")]
		[Address(RVA = "0x152E900", Offset = "0x152DB00", VA = "0x18152E900")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60010B6")]
		[Address(RVA = "0x2B409C0", Offset = "0x2B3FBC0", VA = "0x182B409C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000321")]
	public IRuntimePanel runtimePanel
	{
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x2B406D0", Offset = "0x2B3F8D0", VA = "0x182B406D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000322")]
	private float pixelsPerUnit
	{
		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x2B406B0", Offset = "0x2B3F8B0", VA = "0x182B406B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60010B7")]
	[Address(RVA = "0x2B3D500", Offset = "0x2B3C700", VA = "0x182B3D500")]
	internal void ApplySortingOrder()
	{
	}

	[Token(Token = "0x60010B8")]
	[Address(RVA = "0x2B40610", Offset = "0x2B3F810", VA = "0x182B40610")]
	private UIDocument()
	{
	}

	[Token(Token = "0x60010B9")]
	[Address(RVA = "0x2B3D510", Offset = "0x2B3C710", VA = "0x182B3D510")]
	private void Awake()
	{
	}

	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x2B3E1B0", Offset = "0x2B3D3B0", VA = "0x182B3E1B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x2B3F070", Offset = "0x2B3E270", VA = "0x182B3F070")]
	private void ResolveRuntimePanel()
	{
	}

	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x2B3DEE0", Offset = "0x2B3D0E0", VA = "0x182B3DEE0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60010BE")]
	[Address(RVA = "0x2B3FE10", Offset = "0x2B3F010", VA = "0x182B3FE10")]
	private void UpdateRenderer()
	{
	}

	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x2B3F170", Offset = "0x2B3E370", VA = "0x182B3F170")]
	private Bounds SanitizeRendererBounds(Bounds b)
	{
		return default(Bounds);
	}

	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x2B3D2D0", Offset = "0x2B3C4D0", VA = "0x182B3D2D0")]
	private void AddOrRemoveRendererComponent()
	{
	}

	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x2B3FD80", Offset = "0x2B3EF80", VA = "0x182B3FD80")]
	private void UpdateCutRenderChainFlag()
	{
	}

	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x2B3F5D0", Offset = "0x2B3E7D0", VA = "0x182B3F5D0")]
	private void SetTransform()
	{
	}

	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x2B3D520", Offset = "0x2B3C720", VA = "0x182B3D520")]
	private void ClearTransform()
	{
	}

	[Token(Token = "0x60010C5")]
	[Address(RVA = "0x2B3D900", Offset = "0x2B3CB00", VA = "0x182B3D900")]
	private void ComputeTransform(Transform transform, out Matrix4x4 matrix)
	{
	}

	[Token(Token = "0x60010C6")]
	[Address(RVA = "0x2B3F2B0", Offset = "0x2B3E4B0", VA = "0x182B3F2B0")]
	private static void SetNoTransform(VisualElement visualElement)
	{
	}

	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x2B3FB30", Offset = "0x2B3ED30", VA = "0x182B3FB30")]
	private void SetupFromHierarchy()
	{
	}

	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x2B3DE30", Offset = "0x2B3D030", VA = "0x182B3DE30")]
	private UIDocument FindUIDocumentParent()
	{
		return null;
	}

	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x2B3EF60", Offset = "0x2B3E160", VA = "0x182B3EF60")]
	internal void Reset()
	{
	}

	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x2B3D1E0", Offset = "0x2B3C3E0", VA = "0x182B3D1E0")]
	private void AddChildAndInsertContentToVisualTree(UIDocument child)
	{
	}

	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x2B3EDE0", Offset = "0x2B3DFE0", VA = "0x182B3EDE0")]
	private void RemoveChild(UIDocument child)
	{
	}

	[Token(Token = "0x60010CC")]
	[Address(RVA = "0x2B3E570", Offset = "0x2B3D770", VA = "0x182B3E570")]
	private void RecreateUI()
	{
	}

	[Token(Token = "0x60010CD")]
	[Address(RVA = "0x2B3FCA0", Offset = "0x2B3EEA0", VA = "0x182B3FCA0")]
	private void SetupRootClassList()
	{
	}

	[Token(Token = "0x60010CE")]
	[Address(RVA = "0x2B40210", Offset = "0x2B3F410", VA = "0x182B40210")]
	private void UpdateWorldSpaceSize()
	{
	}

	[Token(Token = "0x60010CF")]
	[Address(RVA = "0x2B3D430", Offset = "0x2B3C630", VA = "0x182B3D430")]
	private void AddRootVisualElementToTree()
	{
	}

	[Token(Token = "0x60010D0")]
	[Address(RVA = "0x2B3EE50", Offset = "0x2B3E050", VA = "0x182B3EE50")]
	private void RemoveFromHierarchy()
	{
	}

	[Token(Token = "0x60010D1")]
	[Address(RVA = "0x2B3E120", Offset = "0x2B3D320", VA = "0x182B3E120")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60010D2")]
	[Address(RVA = "0x2B3E2C0", Offset = "0x2B3D4C0", VA = "0x182B3E2C0")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x60010D3")]
	[Address(RVA = "0x2B3E4B0", Offset = "0x2B3D6B0", VA = "0x182B3E4B0")]
	private void OnTransformParentChanged()
	{
	}

	[Token(Token = "0x60010D4")]
	[Address(RVA = "0x2B3E4C0", Offset = "0x2B3D6C0", VA = "0x182B3E4C0")]
	internal void ReactToHierarchyChanged()
	{
	}
}
