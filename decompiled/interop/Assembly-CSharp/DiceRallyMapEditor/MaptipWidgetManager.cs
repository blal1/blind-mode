using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace DiceRallyMapEditor;

[Token(Token = "0x2000145")]
public class MaptipWidgetManager : MonoBehaviour
{
	[Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class _003CWaitSeconds_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _003Csum_003E5__2;

		[Token(Token = "0x170000E3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CWaitSeconds_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xB0D000", Offset = "0xB0C200", VA = "0x180B0D000", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xB0D090", Offset = "0xB0C290", VA = "0x180B0D090", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40007D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly int minZ;

	[Token(Token = "0x40007D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private readonly int maxZ;

	[Token(Token = "0x40007D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly float wheelSensitive;

	[Token(Token = "0x40007D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private readonly float waitDoubleClickTime;

	[Token(Token = "0x40007D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string PATH_DICERALLY_MAP;

	[Token(Token = "0x40007D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly int undoStackSize;

	[Token(Token = "0x40007DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<MaptipWidget> m_MaptipList;

	[Token(Token = "0x40007DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private List<MaptipWidget> m_SelectedMaptips;

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<MapGrid> m_GridList;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject m_GridArea;

	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject m_StockArea;

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject m_StockOpenButton;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int m_MaptipID;

	[Token(Token = "0x40007E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Vector2 mousePos;

	[Token(Token = "0x40007E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private MaptipWidget m_ConnectingMaptip;

	[Token(Token = "0x40007E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Coroutine waitingDoubleClick;

	[Token(Token = "0x40007E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Dictionary<MapEditorUtil.MaptipType, GameObject> m_MaptipTemplates;

	[Token(Token = "0x40007E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public MapEditorUtil.ClickMode clickMode;

	[Token(Token = "0x40007E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Camera vcCamera;

	[Token(Token = "0x40007E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Action onMaptipChanged;

	[Token(Token = "0x40007E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Action onDestroyIn;

	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Action onDestroyOut;

	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public bool isOpenStock;

	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public DropOutStack<Action> undoStack;

	[Token(Token = "0x40007EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public DropOutStack<Action> redoStack;

	[Token(Token = "0x6000833")]
	[Address(RVA = "0x9DCF90", Offset = "0x9DC190", VA = "0x1809DCF90")]
	public void Initialize(GameObject gridArea, GameObject stockArea)
	{
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0x9DB120", Offset = "0x9DA320", VA = "0x1809DB120")]
	public void AddMaptipTemplate(GameObject maptipObj, MapEditorUtil.MaptipType type)
	{
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0x9DC570", Offset = "0x9DB770", VA = "0x1809DC570")]
	public MaptipWidget CreateMaptip(GameObject template, Vector3 pos, int gridId)
	{
		return null;
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0x9DC5B0", Offset = "0x9DB7B0", VA = "0x1809DC5B0")]
	public MaptipWidget CreateMaptip(GameObject template, Vector3 pos, int gridId, int maptipId)
	{
		return null;
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0x9DC7E0", Offset = "0x9DB9E0", VA = "0x1809DC7E0")]
	public void DestroyMaptip(MaptipWidget maptip)
	{
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0x9DF8E0", Offset = "0x9DEAE0", VA = "0x1809DF8E0")]
	public void OnMaptipClicked(MaptipWidget maptip)
	{
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0x9E0DC0", Offset = "0x9DFFC0", VA = "0x1809E0DC0")]
	[IteratorStateMachine(typeof(_003CWaitSeconds_003Ed__31))]
	private IEnumerator WaitSeconds(float time, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x600083A")]
	[Address(RVA = "0x9DFCA0", Offset = "0x9DEEA0", VA = "0x1809DFCA0")]
	private void OnMaptipSingleClicked(MaptipWidget maptip)
	{
	}

	[Token(Token = "0x600083B")]
	[Address(RVA = "0x9DFBB0", Offset = "0x9DEDB0", VA = "0x1809DFBB0")]
	private void OnMaptipDoubleClicked(MaptipWidget maptip)
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0x9DB3C0", Offset = "0x9DA5C0", VA = "0x1809DB3C0")]
	public void CancelConectMode([Optional] MaptipWidget maptip)
	{
	}

	[Token(Token = "0x600083D")]
	[Address(RVA = "0x9DEDA0", Offset = "0x9DDFA0", VA = "0x1809DEDA0")]
	public void OnDrag(SelectionItem.DragStatus status, Vector2 pos, MaptipWidget target)
	{
	}

	[Token(Token = "0x600083E")]
	[Address(RVA = "0x9E0860", Offset = "0x9DFA60", VA = "0x1809E0860")]
	private void Update()
	{
	}

	[Token(Token = "0x600083F")]
	[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
	public void SetGrids(List<MapGrid> grids)
	{
	}

	[Token(Token = "0x6000840")]
	[Address(RVA = "0x9DED40", Offset = "0x9DDF40", VA = "0x1809DED40")]
	public void OnDrag(MaptipWidget maptip, bool isDraging)
	{
	}

	[Token(Token = "0x6000841")]
	[Address(RVA = "0x9E0420", Offset = "0x9DF620", VA = "0x1809E0420")]
	public int SearchNearestGrid(Vector3 pos, bool isOverlap = true)
	{
		return default(int);
	}

	[Token(Token = "0x6000842")]
	[Address(RVA = "0x9DCCE0", Offset = "0x9DBEE0", VA = "0x1809DCCE0")]
	public MaptipWidget GetMaptip(int id)
	{
		return null;
	}

	[Token(Token = "0x6000843")]
	[Address(RVA = "0x9DCB00", Offset = "0x9DBD00", VA = "0x1809DCB00")]
	public Vector3 GetGridPosition(int id)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000844")]
	[Address(RVA = "0x9DC970", Offset = "0x9DBB70", VA = "0x1809DC970")]
	public Vector2 GetGridPosID(int id)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0x9DCE20", Offset = "0x9DC020", VA = "0x1809DCE20")]
	public int GridPosToID(Vector2 pos)
	{
		return default(int);
	}

	[Token(Token = "0x6000846")]
	[Address(RVA = "0x9DC2B0", Offset = "0x9DB4B0", VA = "0x1809DC2B0")]
	public Dictionary<MapEditorUtil.MaptipType, int> CountupMaptip()
	{
		return null;
	}

	[Token(Token = "0x6000847")]
	[Address(RVA = "0x9DD150", Offset = "0x9DC350", VA = "0x1809DD150")]
	public bool IsOverlapDeleteArea(Vector3 pointer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000848")]
	[Address(RVA = "0x9DB1C0", Offset = "0x9DA3C0", VA = "0x1809DB1C0")]
	public void AreaSelectMaptips(RectTransform selectionArea)
	{
	}

	[Token(Token = "0x6000849")]
	[Address(RVA = "0x9E0280", Offset = "0x9DF480", VA = "0x1809E0280")]
	public void ResetAreaSelect()
	{
	}

	[Token(Token = "0x600084A")]
	[Address(RVA = "0x9DB540", Offset = "0x9DA740", VA = "0x1809DB540")]
	public bool Convert(string fileName, int gridListId, [Optional] Action onComplete, [Optional] Action onError)
	{
		return default(bool);
	}

	[Token(Token = "0x600084B")]
	[Address(RVA = "0x9DE4F0", Offset = "0x9DD6F0", VA = "0x1809DE4F0")]
	private Dictionary<string, object> MakeGridDictionary([Optional] Action onComplete, [Optional] Action onError)
	{
		return null;
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0x9DE0A0", Offset = "0x9DD2A0", VA = "0x1809DE0A0")]
	private Dictionary<string, object> MakeDummyDetail([Optional] Action onComplete, [Optional] Action onError)
	{
		return null;
	}

	[Token(Token = "0x600084D")]
	[Address(RVA = "0x9E00C0", Offset = "0x9DF2C0", VA = "0x1809E00C0")]
	public void OpenPreview(ViewControllerManager manager)
	{
	}

	[Token(Token = "0x600084E")]
	[Address(RVA = "0x9DD1E0", Offset = "0x9DC3E0", VA = "0x1809DD1E0")]
	public bool LoadPrepare(string fileName, int gridListId, [Optional] Action onComplete, [Optional] Action onError)
	{
		return default(bool);
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0x9DD3F0", Offset = "0x9DC5F0", VA = "0x1809DD3F0")]
	private bool Load(string fileName, int gridListId, [Optional] Action onComplete, [Optional] Action onError)
	{
		return default(bool);
	}

	[Token(Token = "0x6000850")]
	[Address(RVA = "0x9E0E40", Offset = "0x9E0040", VA = "0x1809E0E40")]
	public MaptipWidgetManager()
	{
	}
}
