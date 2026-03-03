using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.InfinityScroll;

[Token(Token = "0x2000587")]
public class EntityPoolController
{
	[Token(Token = "0x2000588")]
	public class WaitFocusData
	{
		[Token(Token = "0x17000407")]
		public bool isExists
		{
			[Token(Token = "0x6002454")]
			[Address(RVA = "0x671000", Offset = "0x670200", VA = "0x180671000")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000408")]
		public int dataIndex
		{
			[Token(Token = "0x6002455")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6002456")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000409")]
		public SelectionItem currentItem
		{
			[Token(Token = "0x6002457")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002458")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700040A")]
		public bool isSelectItem
		{
			[Token(Token = "0x6002459")]
			[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600245A")]
			[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700040B")]
		public bool isInitializeSelect
		{
			[Token(Token = "0x600245B")]
			[Address(RVA = "0x5D7890", Offset = "0x5D6A90", VA = "0x1805D7890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600245C")]
			[Address(RVA = "0x671010", Offset = "0x670210", VA = "0x180671010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700040C")]
		public Action onComplete
		{
			[Token(Token = "0x600245D")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600245E")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6002452")]
		[Address(RVA = "0x670FF0", Offset = "0x6701F0", VA = "0x180670FF0")]
		public WaitFocusData()
		{
		}

		[Token(Token = "0x6002453")]
		[Address(RVA = "0x670F60", Offset = "0x670160", VA = "0x180670F60")]
		public WaitFocusData Clone()
		{
			return null;
		}

		[Token(Token = "0x600245F")]
		[Address(RVA = "0x670F40", Offset = "0x670140", VA = "0x180670F40")]
		public void Clear()
		{
		}

		[Token(Token = "0x6002460")]
		[Address(RVA = "0x670F00", Offset = "0x670100", VA = "0x180670F00")]
		public void Assign(int dataIndex, bool isSelectItem, bool isInitializeSelect, Action onComplete, SelectionItem currentItem)
		{
		}
	}

	[Token(Token = "0x2000589")]
	private enum LayoutType
	{
		[Token(Token = "0x4001B12")]
		Grid,
		[Token(Token = "0x4001B13")]
		Horizontal,
		[Token(Token = "0x4001B14")]
		Vertical
	}

	[Token(Token = "0x200058A")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass149_0
	{
		[Token(Token = "0x4001B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool updateDataDone;

		[Token(Token = "0x6002461")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass149_0()
		{
		}

		[Token(Token = "0x6002462")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CyInnerUpdateDataCountAsync_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200058B")]
	[CompilerGenerated]
	private sealed class _003CReadRectSize_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EntityPoolController _003C_003E4__this;

		[Token(Token = "0x4001B19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<GameObject> templates;

		[Token(Token = "0x4001B1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EntityPoolSettings entityPoolSettings;

		[Token(Token = "0x4001B1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onCompleteCallback;

		[Token(Token = "0x1700040D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002466")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700040E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002468")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002463")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CReadRectSize_003Ed__116(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002464")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002465")]
		[Address(RVA = "0x66A1A0", Offset = "0x6693A0", VA = "0x18066A1A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002467")]
		[Address(RVA = "0x66AAC0", Offset = "0x669CC0", VA = "0x18066AAC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200058C")]
	[CompilerGenerated]
	private sealed class _003CyInnerUpdateDataCountAsync_003Ed__149 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EntityPoolController _003C_003E4__this;

		[Token(Token = "0x4001B1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<int> templateList;

		[Token(Token = "0x4001B20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int dataCount;

		[Token(Token = "0x4001B21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int updatePerFrame;

		[Token(Token = "0x4001B22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass149_0 _003C_003E8__1;

		[Token(Token = "0x4001B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action onComplete;

		[Token(Token = "0x4001B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _003CwaitCnt_003E5__2;

		[Token(Token = "0x1700040F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600246C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000410")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600246E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002469")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInnerUpdateDataCountAsync_003Ed__149(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600246A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600246B")]
		[Address(RVA = "0x66B0A0", Offset = "0x66A2A0", VA = "0x18066B0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600246D")]
		[Address(RVA = "0x66B840", Offset = "0x66AA40", VA = "0x18066B840", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200058D")]
	[CompilerGenerated]
	private sealed class _003CyReserveTemplate_003Ed__112 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int asyncPerFrame;

		[Token(Token = "0x4001B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EntityPoolController _003C_003E4__this;

		[Token(Token = "0x4001B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int templateIdx;

		[Token(Token = "0x4001B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action onComplete;

		[Token(Token = "0x4001B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _003CasyncCnt_003E5__2;

		[Token(Token = "0x17000411")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002472")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000412")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002474")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600246F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyReserveTemplate_003Ed__112(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002470")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002471")]
		[Address(RVA = "0x66B880", Offset = "0x66AA80", VA = "0x18066B880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002473")]
		[Address(RVA = "0x66B950", Offset = "0x66AB50", VA = "0x18066B950", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200058E")]
	[CompilerGenerated]
	private sealed class _003CyUpdateDataAsync_003Ed__153 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EntityPoolController _003C_003E4__this;

		[Token(Token = "0x4001B2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int updatePerFrame;

		[Token(Token = "0x4001B30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x4001B31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _003CwaitCnt_003E5__2;

		[Token(Token = "0x4001B32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x17000413")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002478")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000414")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600247A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002475")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyUpdateDataAsync_003Ed__153(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002476")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002477")]
		[Address(RVA = "0x66B990", Offset = "0x66AB90", VA = "0x18066B990", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002479")]
		[Address(RVA = "0x66BB50", Offset = "0x66AD50", VA = "0x18066BB50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001AE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private InfinityScrollView m_Owner;

	[Token(Token = "0x4001AE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GridLayoutGroup.Axis m_ScrollAxis;

	[Token(Token = "0x4001AE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectOffset m_Padding;

	[Token(Token = "0x4001AEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector2 m_ViewportSize;

	[Token(Token = "0x4001AEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ExtendedScrollRect m_ScrollRect;

	[Token(Token = "0x4001AEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GridLayoutGroup m_LayoutGroup;

	[Token(Token = "0x4001AED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private HorizontalLayoutGroup m_HorizontalLayoutGroup;

	[Token(Token = "0x4001AEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private VerticalLayoutGroup m_VerticallLayoutGroup;

	[Token(Token = "0x4001AEF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private LayoutType m_LayoutType;

	[Token(Token = "0x4001AF0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int m_ConstraintCount;

	[Token(Token = "0x4001AF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2 m_Spacing;

	[Token(Token = "0x4001AF2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<GameObject> m_Templates;

	[Token(Token = "0x4001AF3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int m_NumTemplates;

	[Token(Token = "0x4001AF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<int> m_TemplateList;

	[Token(Token = "0x4001AF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<int> m_PrevTemplateList;

	[Token(Token = "0x4001AF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Vector2> m_UnitSize;

	[Token(Token = "0x4001AF7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Dictionary<GameObject, int> m_EntityDataIndexTable;

	[Token(Token = "0x4001AF8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Stack<GameObject>> m_FreeEntityStack;

	[Token(Token = "0x4001AF9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<GameObject> m_ActiveEntityList;

	[Token(Token = "0x4001AFA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int m_DataCount;

	[Token(Token = "0x4001AFB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private bool m_IsReady;

	[Token(Token = "0x4001AFC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private WaitFocusData m_WaitFocusData;

	[Token(Token = "0x4001AFD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public bool useViewportSize;

	[Token(Token = "0x4001AFE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Action<GameObject> m_OnCreatedEntityCallback;

	[Token(Token = "0x4001AFF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Action<GameObject> m_OnActivateEntityCallback;

	[Token(Token = "0x4001B00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Action<GameObject, int> m_OnUpdateEntityCallback;

	[Token(Token = "0x4001B01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Action<GameObject, int, bool, bool> m_OnFocusEntityCallback;

	[Token(Token = "0x4001B02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Action<GameObject> m_OnDeactivateEntityCallback;

	[Token(Token = "0x4001B03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Action<GameObject, int, bool> m_OnRemoveEntityCallback;

	[Token(Token = "0x4001B04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Func<int, (bool customized, float targetPos)> m_CustomMoveContentToFitDataFunc;

	[Token(Token = "0x4001B05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private bool m_IsInstantiateAllTemplates;

	[Token(Token = "0x4001B06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private List<int> itemCount;

	[Token(Token = "0x4001B07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<int> itemLimmit;

	[Token(Token = "0x4001B08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected int m_LastLineItemCountInViewCache;

	[Token(Token = "0x4001B09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private IEnumerator m_ReserveTemplateRoutine;

	[Token(Token = "0x4001B0A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private IEnumerator m_UpdateDataCountAsync;

	[Token(Token = "0x4001B0B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private IEnumerator m_UpdateDataAsync;

	[Token(Token = "0x170003E4")]
	public WaitFocusData waitFocusData
	{
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003E5")]
	public bool isExistsFocusWaitData
	{
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x662150", Offset = "0x661350", VA = "0x180662150")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003E6")]
	public int dataCount
	{
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x662060", Offset = "0x661260", VA = "0x180662060")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003E7")]
	protected int m_LastLineItemCount
	{
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x662310", Offset = "0x661510", VA = "0x180662310")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003E8")]
	protected int m_LastLineItemCountInView
	{
		[Token(Token = "0x60023E1")]
		[Address(RVA = "0x6622D0", Offset = "0x6614D0", VA = "0x1806622D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003E9")]
	protected bool m_IsHorizontalScroll
	{
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x425570", Offset = "0x424770", VA = "0x180425570")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003EA")]
	public bool isHorizontalScroll
	{
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x425570", Offset = "0x424770", VA = "0x180425570")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003EB")]
	protected float m_CurrentContentPos
	{
		[Token(Token = "0x60023E4")]
		[Address(RVA = "0x6621B0", Offset = "0x6613B0", VA = "0x1806621B0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003EC")]
	protected float m_ViewSizeAlongScrollDirection
	{
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x662450", Offset = "0x661650", VA = "0x180662450")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003ED")]
	protected float m_SpacingAlongScrollDirection
	{
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x662420", Offset = "0x661620", VA = "0x180662420")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170003EE")]
	public int beginDataIndex
	{
		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x661FB0", Offset = "0x6611B0", VA = "0x180661FB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003EF")]
	protected int m_DataIndexOfListBegin
	{
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x661FB0", Offset = "0x6611B0", VA = "0x180661FB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F0")]
	protected int m_VerticalOffset
	{
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x662440", Offset = "0x661640", VA = "0x180662440")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F1")]
	protected int m_HorizontalOffset
	{
		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x6622C0", Offset = "0x6614C0", VA = "0x1806622C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F2")]
	public int endDataIndex
	{
		[Token(Token = "0x60023EC")]
		[Address(RVA = "0x662070", Offset = "0x661270", VA = "0x180662070")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F3")]
	protected int m_DataIndexOfListEnd
	{
		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x662210", Offset = "0x661410", VA = "0x180662210")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F4")]
	protected int m_PaddingBias
	{
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x662360", Offset = "0x661560", VA = "0x180662360")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F5")]
	protected int m_PaddingBegin
	{
		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x662330", Offset = "0x661530", VA = "0x180662330")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F6")]
	protected int m_PaddingEnd
	{
		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x6623F0", Offset = "0x6615F0", VA = "0x1806623F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003F7")]
	public bool isReady
	{
		[Token(Token = "0x60023F1")]
		[Address(RVA = "0x6621A0", Offset = "0x6613A0", VA = "0x1806621A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003F8")]
	public bool isCompletedReserve
	{
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x662080", Offset = "0x661280", VA = "0x180662080")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003F9")]
	public bool isMoving
	{
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x662180", Offset = "0x661380", VA = "0x180662180")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003FA")]
	public IReadOnlyList<GameObject> activeEntityList
	{
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003FB")]
	public int activeEntityLineCount
	{
		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x661F10", Offset = "0x661110", VA = "0x180661F10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003FC")]
	public int DataIndexOfItemBegin
	{
		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x661DD0", Offset = "0x660FD0", VA = "0x180661DD0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003FD")]
	public int DataIndexOfItemEnd
	{
		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x661E70", Offset = "0x661070", VA = "0x180661E70")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170003FE")]
	public int constraintCount
	{
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x49BDA0", Offset = "0x49AFA0", VA = "0x18049BDA0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x49C4B0", Offset = "0x49B6B0", VA = "0x18049C4B0")]
		set
		{
		}
	}

	[Token(Token = "0x170003FF")]
	public int contentCount
	{
		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x662020", Offset = "0x661220", VA = "0x180662020")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000400")]
	public Action<GameObject> onCreatedEntityCallback
	{
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
		set
		{
		}
	}

	[Token(Token = "0x17000401")]
	public Action<GameObject> onActivateEntityCallback
	{
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		set
		{
		}
	}

	[Token(Token = "0x17000402")]
	public Action<GameObject, int> onUpdateEntityCallback
	{
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
		set
		{
		}
	}

	[Token(Token = "0x17000403")]
	public Action<GameObject, int, bool, bool> onFocusEntityCallback
	{
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000404")]
	public Action<GameObject> onDeactivateEntityCallback
	{
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
		set
		{
		}
	}

	[Token(Token = "0x17000405")]
	public Action<GameObject, int, bool> onRemoveEntityCallback
	{
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x662520", Offset = "0x661720", VA = "0x180662520")]
		set
		{
		}
	}

	[Token(Token = "0x17000406")]
	public Func<int, (bool customized, float targetPos)> customMoveContentToFitDataFunc
	{
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x49C200", Offset = "0x49B400", VA = "0x18049C200")]
		set
		{
		}
	}

	[Token(Token = "0x60023E6")]
	[Address(RVA = "0x662470", Offset = "0x661670", VA = "0x180662470")]
	protected float m_UnitSizeAlongScrollDirection(int templateIdx)
	{
		return default(float);
	}

	[Token(Token = "0x6002402")]
	[Address(RVA = "0x65EE30", Offset = "0x65E030", VA = "0x18065EE30")]
	public void Initialize(EntityPoolSettings entityPoolSettings, InfinityScrollView owner, ExtendedScrollRect scrollRect, List<GameObject> templates, [Optional] Action onCompleteCallback)
	{
	}

	[Token(Token = "0x6002403")]
	[Address(RVA = "0x6608F0", Offset = "0x65FAF0", VA = "0x1806608F0")]
	public void ReserveTemplate(int templateIdx = 0, int asyncPerFrame = 0, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6002404")]
	[Address(RVA = "0x660B10", Offset = "0x65FD10", VA = "0x180660B10")]
	public void TerminateReserve()
	{
	}

	[Token(Token = "0x6002405")]
	[Address(RVA = "0x662600", Offset = "0x661800", VA = "0x180662600")]
	[IteratorStateMachine(typeof(_003CyReserveTemplate_003Ed__112))]
	private IEnumerator yReserveTemplate(int templateIdx = 0, int asyncPerFrame = 0, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6002406")]
	[Address(RVA = "0x6618C0", Offset = "0x660AC0", VA = "0x1806618C0")]
	public void UpdatePaddingSize()
	{
	}

	[Token(Token = "0x6002407")]
	[Address(RVA = "0x6619E0", Offset = "0x660BE0", VA = "0x1806619E0")]
	public void UpdateViewportRectSize()
	{
	}

	[Token(Token = "0x6002408")]
	[Address(RVA = "0x65E550", Offset = "0x65D750", VA = "0x18065E550")]
	protected void InitContentRT(EntityPoolSettings entityPoolSettings)
	{
	}

	[Token(Token = "0x6002409")]
	[Address(RVA = "0x6600A0", Offset = "0x65F2A0", VA = "0x1806600A0")]
	[IteratorStateMachine(typeof(_003CReadRectSize_003Ed__116))]
	protected IEnumerator ReadRectSize(EntityPoolSettings entityPoolSettings, List<GameObject> templates, [Optional] Action onCompleteCallback)
	{
		return null;
	}

	[Token(Token = "0x600240A")]
	[Address(RVA = "0x660090", Offset = "0x65F290", VA = "0x180660090")]
	private void OnScrollValueChanged(Vector2 bias)
	{
	}

	[Token(Token = "0x600240B")]
	[Address(RVA = "0x65F620", Offset = "0x65E820", VA = "0x18065F620")]
	protected void InstantiateTemplate(GameObject template, int templateIdx = 0)
	{
	}

	[Token(Token = "0x600240C")]
	[Address(RVA = "0x65C830", Offset = "0x65BA30", VA = "0x18065C830")]
	protected bool AddTemplateInstantance(int templateIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x600240D")]
	[Address(RVA = "0x65E780", Offset = "0x65D980", VA = "0x18065E780")]
	protected void InitLayout(EntityPoolSettings entityPoolSettings, object layout)
	{
	}

	[Token(Token = "0x600240E")]
	[Address(RVA = "0x660160", Offset = "0x65F360", VA = "0x180660160")]
	protected void RemakeLayout(GridLayoutGroup gridLayoutGroup)
	{
	}

	[Token(Token = "0x600240F")]
	[Address(RVA = "0x65CAD0", Offset = "0x65BCD0", VA = "0x18065CAD0")]
	protected bool AddTopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6002410")]
	[Address(RVA = "0x65C500", Offset = "0x65B700", VA = "0x18065C500")]
	protected bool AddBottomItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6002411")]
	[Address(RVA = "0x660890", Offset = "0x65FA90", VA = "0x180660890")]
	protected bool RemoveTopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6002412")]
	[Address(RVA = "0x660560", Offset = "0x65F760", VA = "0x180660560")]
	protected bool RemoveBottomItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6002413")]
	[Address(RVA = "0x660DA0", Offset = "0x65FFA0", VA = "0x180660DA0")]
	public void UpdateContentPos(bool withRebuildLayout = false)
	{
	}

	[Token(Token = "0x6002414")]
	[Address(RVA = "0x65D080", Offset = "0x65C280", VA = "0x18065D080")]
	public void CheckWaitFocusData()
	{
	}

	[Token(Token = "0x6002415")]
	[Address(RVA = "0x65C590", Offset = "0x65B790", VA = "0x18065C590")]
	protected bool AddItem(int dataindex, int posInHierachy)
	{
		return default(bool);
	}

	[Token(Token = "0x6002416")]
	[Address(RVA = "0x6605F0", Offset = "0x65F7F0", VA = "0x1806605F0")]
	protected bool RemoveItem(int itemindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002417")]
	[Address(RVA = "0x660290", Offset = "0x65F490", VA = "0x180660290")]
	protected void RemoveAllItem()
	{
	}

	[Token(Token = "0x6002418")]
	[Address(RVA = "0x660550", Offset = "0x65F750", VA = "0x180660550")]
	public void RemoveAll()
	{
	}

	[Token(Token = "0x6002419")]
	[Address(RVA = "0x65CB90", Offset = "0x65BD90", VA = "0x18065CB90")]
	protected void ChangeContentSize()
	{
	}

	[Token(Token = "0x600241A")]
	[Address(RVA = "0x65FC20", Offset = "0x65EE20", VA = "0x18065FC20")]
	protected bool MoveContentToFitDataPos(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600241B")]
	[Address(RVA = "0x65CB30", Offset = "0x65BD30", VA = "0x18065CB30")]
	public void CancelMoving()
	{
	}

	[Token(Token = "0x600241C")]
	[Address(RVA = "0x65FFE0", Offset = "0x65F1E0", VA = "0x18065FFE0")]
	protected void MoveContent(float targetpos)
	{
	}

	[Token(Token = "0x600241D")]
	[Address(RVA = "0x65D2C0", Offset = "0x65C4C0", VA = "0x18065D2C0")]
	private int ClampDataIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600241E")]
	[Address(RVA = "0x65FBF0", Offset = "0x65EDF0", VA = "0x18065FBF0")]
	protected bool IsIndexInSameLine(int index0, int index1)
	{
		return default(bool);
	}

	[Token(Token = "0x600241F")]
	[Address(RVA = "0x65D020", Offset = "0x65C220", VA = "0x18065D020")]
	protected bool CheckItemIndexCorrect(int itemindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002420")]
	[Address(RVA = "0x65CF60", Offset = "0x65C160", VA = "0x18065CF60")]
	protected bool CheckDataIndexCorrect(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002421")]
	[Address(RVA = "0x65CF80", Offset = "0x65C180", VA = "0x18065CF80")]
	protected bool CheckItemInViewByDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002422")]
	[Address(RVA = "0x65D480", Offset = "0x65C680", VA = "0x18065D480")]
	protected float GetContentPosByDataLine(int lineindex)
	{
		return default(float);
	}

	[Token(Token = "0x6002423")]
	[Address(RVA = "0x65D910", Offset = "0x65CB10", VA = "0x18065D910")]
	protected int GetDataLineByContentPos(float pos)
	{
		return default(int);
	}

	[Token(Token = "0x6002424")]
	[Address(RVA = "0x65DA80", Offset = "0x65CC80", VA = "0x18065DA80")]
	protected int GetDataLineByDataIndex(int dataindex)
	{
		return default(int);
	}

	[Token(Token = "0x6002425")]
	[Address(RVA = "0x65D470", Offset = "0x65C670", VA = "0x18065D470")]
	protected int GetBeginDataIndexByDataLine(int dataline)
	{
		return default(int);
	}

	[Token(Token = "0x6002426")]
	[Address(RVA = "0x661730", Offset = "0x660930", VA = "0x180661730", Slot = "4")]
	public virtual void UpdateDataCount(int dataCount, [Optional] List<int> templateList)
	{
	}

	[Token(Token = "0x6002427")]
	[Address(RVA = "0x661520", Offset = "0x660720", VA = "0x180661520", Slot = "5")]
	public virtual void UpdateDataCountAsync(int dataCount, [Optional] List<int> templateList, int updatePerFrame = 1, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6002428")]
	[Address(RVA = "0x65F330", Offset = "0x65E530", VA = "0x18065F330")]
	private void InnerUpdateDataCount(int dataCount, [Optional] List<int> templateList)
	{
	}

	[Token(Token = "0x6002429")]
	[Address(RVA = "0x662540", Offset = "0x661740", VA = "0x180662540")]
	[IteratorStateMachine(typeof(_003CyInnerUpdateDataCountAsync_003Ed__149))]
	private IEnumerator yInnerUpdateDataCountAsync(int dataCount, [Optional] List<int> templateList, int updatePerFrame = 1, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x600242A")]
	[Address(RVA = "0x661760", Offset = "0x660960", VA = "0x180661760")]
	public void UpdateData(bool withUpdateContentPos = false)
	{
	}

	[Token(Token = "0x600242B")]
	[Address(RVA = "0x661450", Offset = "0x660650", VA = "0x180661450")]
	public void UpdateDataAsync(int updatePerFrame, Action onComplete)
	{
	}

	[Token(Token = "0x600242C")]
	[Address(RVA = "0x6626B0", Offset = "0x6618B0", VA = "0x1806626B0")]
	[IteratorStateMachine(typeof(_003CyUpdateDataAsync_003Ed__153))]
	private IEnumerator yUpdateDataAsync(int updatePerFrame, Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x600242D")]
	[Address(RVA = "0x65D2E0", Offset = "0x65C4E0", VA = "0x18065D2E0")]
	public bool FocusItemByDataIndex(int dataindex, bool selectItem = true, bool isInitializeSelect = false, [Optional] Action onComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x600242E")]
	[Address(RVA = "0x660B60", Offset = "0x65FD60", VA = "0x180660B60")]
	public bool TryFocusInnerViewport(bool selectItem, bool isInitializeSelect = false, [Optional] Action onComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x600242F")]
	[Address(RVA = "0x660A20", Offset = "0x65FC20", VA = "0x180660A20")]
	public void ResetContentPosition()
	{
	}

	[Token(Token = "0x6002430")]
	[Address(RVA = "0x65E3A0", Offset = "0x65D5A0", VA = "0x18065E3A0")]
	public void ImmediateApplyMovement()
	{
	}

	[Token(Token = "0x6002431")]
	[Address(RVA = "0x65E390", Offset = "0x65D590", VA = "0x18065E390")]
	public float GetTemplateSizeAlongScrollDirection(int templateIdx)
	{
		return default(float);
	}

	[Token(Token = "0x6002432")]
	[Address(RVA = "0x65DC50", Offset = "0x65CE50", VA = "0x18065DC50")]
	public GameObject GetItemByListPos(int x, int y)
	{
		return null;
	}

	[Token(Token = "0x6002433")]
	[Address(RVA = "0x65DD60", Offset = "0x65CF60", VA = "0x18065DD60")]
	public (int, int) GetListPosByItemIndex(int itemIndex)
	{
		return default((int, int));
	}

	[Token(Token = "0x6002434")]
	[Address(RVA = "0x65DCD0", Offset = "0x65CED0", VA = "0x18065DCD0")]
	public int GetItemIndexByListPos(int x, int y)
	{
		return default(int);
	}

	[Token(Token = "0x6002435")]
	[Address(RVA = "0x65D7E0", Offset = "0x65C9E0", VA = "0x18065D7E0")]
	public int GetDataIndexByItemIndex(int itemIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6002436")]
	[Address(RVA = "0x65D870", Offset = "0x65CA70", VA = "0x18065D870")]
	public int GetDataIndexByListPos(int x, int y)
	{
		return default(int);
	}

	[Token(Token = "0x6002437")]
	[Address(RVA = "0x65DD60", Offset = "0x65CF60", VA = "0x18065DD60")]
	public (int, int) GetListPosByDataIndex(int dataIdx)
	{
		return default((int, int));
	}

	[Token(Token = "0x6002438")]
	[Address(RVA = "0x65DB80", Offset = "0x65CD80", VA = "0x18065DB80")]
	public int GetEntityIndexByDataIndex(int dataindex)
	{
		return default(int);
	}

	[Token(Token = "0x6002439")]
	[Address(RVA = "0x65DD50", Offset = "0x65CF50", VA = "0x18065DD50")]
	public int GetLineByDataIndex(int dataindex)
	{
		return default(int);
	}

	[Token(Token = "0x600243A")]
	[Address(RVA = "0x65DAF0", Offset = "0x65CCF0", VA = "0x18065DAF0")]
	public GameObject GetEntityByDataIndex(int dataindex)
	{
		return null;
	}

	[Token(Token = "0x600243B")]
	public T GetEntityByDataIndex<T>(int dataindex)
	{
		return (T)null;
	}

	[Token(Token = "0x600243C")]
	[Address(RVA = "0x65D640", Offset = "0x65C840", VA = "0x18065D640")]
	public int GetDataIndexByEntity(GameObject entity)
	{
		return default(int);
	}

	[Token(Token = "0x600243D")]
	[Address(RVA = "0x65E030", Offset = "0x65D230", VA = "0x18065E030")]
	public int GetTemplateIndexByDataIndex(int dataindex)
	{
		return default(int);
	}

	[Token(Token = "0x600243E")]
	[Address(RVA = "0x65E0B0", Offset = "0x65D2B0", VA = "0x18065E0B0")]
	public int GetTemplateIndexByEntity(GameObject entity)
	{
		return default(int);
	}

	[Token(Token = "0x600243F")]
	[Address(RVA = "0x65E1F0", Offset = "0x65D3F0", VA = "0x18065E1F0")]
	public string GetTemplateLabelByDataIndex(int dataindex)
	{
		return null;
	}

	[Token(Token = "0x6002440")]
	[Address(RVA = "0x65E2F0", Offset = "0x65D4F0", VA = "0x18065E2F0")]
	public string GetTemplateLabelByTemplateIndex(int templateindex)
	{
		return null;
	}

	[Token(Token = "0x6002441")]
	[Address(RVA = "0x65DF50", Offset = "0x65D150", VA = "0x18065DF50")]
	public int GetSideIndex(int baseIdx, PadInputDirection direction)
	{
		return default(int);
	}

	[Token(Token = "0x6002442")]
	[Address(RVA = "0x65DF00", Offset = "0x65D100", VA = "0x18065DF00")]
	public int GetSideIndexUp(int baseIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6002443")]
	[Address(RVA = "0x65DDE0", Offset = "0x65CFE0", VA = "0x18065DDE0")]
	public int GetSideIndexDown(int baseIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6002444")]
	[Address(RVA = "0x65DE40", Offset = "0x65D040", VA = "0x18065DE40")]
	public int GetSideIndexLeft(int baseIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6002445")]
	[Address(RVA = "0x65DEA0", Offset = "0x65D0A0", VA = "0x18065DEA0")]
	public int GetSideIndexRight(int baseIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6002446")]
	[Address(RVA = "0x65F9D0", Offset = "0x65EBD0", VA = "0x18065F9D0")]
	public bool IsEdgeByDataIndex(int dataindex, PadInputDirection checkDirection)
	{
		return default(bool);
	}

	[Token(Token = "0x6002447")]
	[Address(RVA = "0x65FB10", Offset = "0x65ED10", VA = "0x18065FB10")]
	public bool IsEdgeLeftDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002448")]
	[Address(RVA = "0x65FB30", Offset = "0x65ED30", VA = "0x18065FB30")]
	public bool IsEdgeRightDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002449")]
	[Address(RVA = "0x65FB90", Offset = "0x65ED90", VA = "0x18065FB90")]
	public bool IsEdgeUpDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600244A")]
	[Address(RVA = "0x65FA90", Offset = "0x65EC90", VA = "0x18065FA90")]
	public bool IsEdgeDownDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600244B")]
	[Address(RVA = "0x65FB00", Offset = "0x65ED00", VA = "0x18065FB00")]
	public bool IsEdgeHeadItemIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600244C")]
	[Address(RVA = "0x65FB80", Offset = "0x65ED80", VA = "0x18065FB80")]
	public bool IsEdgeTailItemIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600244D")]
	[Address(RVA = "0x65FB70", Offset = "0x65ED70", VA = "0x18065FB70")]
	public bool IsEdgeStartSideItemIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600244E")]
	[Address(RVA = "0x65FAD0", Offset = "0x65ECD0", VA = "0x18065FAD0")]
	public bool IsEdgeEndSideItemIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x600244F")]
	[Address(RVA = "0x65FBB0", Offset = "0x65EDB0", VA = "0x18065FBB0")]
	public bool IsFractionItemIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002450")]
	[Address(RVA = "0x661CC0", Offset = "0x660EC0", VA = "0x180661CC0")]
	public EntityPoolController()
	{
	}
}
