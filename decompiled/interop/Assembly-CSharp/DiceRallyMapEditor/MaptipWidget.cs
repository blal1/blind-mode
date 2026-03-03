using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace DiceRallyMapEditor;

[Token(Token = "0x2000143")]
public class MaptipWidget : MonoBehaviour
{
	[Token(Token = "0x40007BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private MaptipWidgetManager manager;

	[Token(Token = "0x40007BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public MapEditorUtil.MaptipType type;

	[Token(Token = "0x40007BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_EOM;

	[Token(Token = "0x40007BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SelectionButton m_Button;

	[Token(Token = "0x40007C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private RectTransform m_RectTransform;

	[Token(Token = "0x40007C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 m_PastPos;

	[Token(Token = "0x40007C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_RarityArea;

	[Token(Token = "0x40007C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float m_BaseEdgeWidth;

	[Token(Token = "0x40007C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject m_AreaSelected;

	[Token(Token = "0x40007C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int onGridId;

	[Token(Token = "0x40007C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int id;

	[Token(Token = "0x40007C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject edge;

	[Token(Token = "0x40007C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject edgeShadow;

	[Token(Token = "0x40007C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3 absoluteEdgeScale;

	[Token(Token = "0x40007CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool isTemplate;

	[Token(Token = "0x40007CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool isClicked;

	[Token(Token = "0x40007CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool isDestroy;

	[Token(Token = "0x40007CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Action onDestroyIn;

	[Token(Token = "0x40007CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Action onDestroyOut;

	[Token(Token = "0x40007D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public MaptipWidget next;

	[Token(Token = "0x40007D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public MaptipWidget prev;

	[Token(Token = "0x170000E2")]
	public bool isAreaSelected
	{
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x9E2EB0", Offset = "0x9E20B0", VA = "0x1809E2EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x9E2EC0", Offset = "0x9E20C0", VA = "0x1809E2EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600081D")]
	[Address(RVA = "0x9E2E20", Offset = "0x9E2020", VA = "0x1809E2E20")]
	private void Start()
	{
	}

	[Token(Token = "0x600081E")]
	[Address(RVA = "0x9CC3A0", Offset = "0x9CB5A0", VA = "0x1809CC3A0")]
	private bool DragStarter(Vector2 start, Vector2 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600081F")]
	[Address(RVA = "0x9E1F60", Offset = "0x9E1160", VA = "0x1809E1F60")]
	public void OnDragBegin()
	{
	}

	[Token(Token = "0x6000820")]
	[Address(RVA = "0x9E2420", Offset = "0x9E1620", VA = "0x1809E2420")]
	public void OnDraging(Vector2 pos, Vector2 delta)
	{
	}

	[Token(Token = "0x6000821")]
	[Address(RVA = "0x9E2000", Offset = "0x9E1200", VA = "0x1809E2000")]
	public void OnDragEnd(Vector2 pos, Vector2 delta)
	{
	}

	[Token(Token = "0x6000822")]
	[Address(RVA = "0x9E1EF0", Offset = "0x9E10F0", VA = "0x1809E1EF0")]
	public void MoveOnGrid(int gridId)
	{
	}

	[Token(Token = "0x6000823")]
	[Address(RVA = "0x9E1EB0", Offset = "0x9E10B0", VA = "0x1809E1EB0")]
	public void Initialize(int id, int onGridId)
	{
	}

	[Token(Token = "0x6000824")]
	[Address(RVA = "0x9E1920", Offset = "0x9E0B20", VA = "0x1809E1920")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000825")]
	[Address(RVA = "0x9E29A0", Offset = "0x9E1BA0", VA = "0x1809E29A0")]
	public void SetAreaSelected(bool isSelected)
	{
	}

	[Token(Token = "0x6000826")]
	[Address(RVA = "0x9E26D0", Offset = "0x9E18D0", VA = "0x1809E26D0")]
	public MaptipWidget PrepareConnection(MaptipWidget from)
	{
		return null;
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0x9E15E0", Offset = "0x9E07E0", VA = "0x1809E15E0")]
	private void ConnectMaptip(MaptipWidget source, MaptipWidget destination)
	{
	}

	[Token(Token = "0x6000828")]
	[Address(RVA = "0x9E28E0", Offset = "0x9E1AE0", VA = "0x1809E28E0")]
	public void RefreshEdge()
	{
	}

	[Token(Token = "0x6000829")]
	[Address(RVA = "0x9E2820", Offset = "0x9E1A20", VA = "0x1809E2820")]
	public void RebuildEdge()
	{
	}

	[Token(Token = "0x600082A")]
	[Address(RVA = "0x9E10C0", Offset = "0x9E02C0", VA = "0x1809E10C0")]
	private void ConnectEdge(MaptipWidget source, MaptipWidget destination)
	{
	}

	[Token(Token = "0x600082B")]
	[Address(RVA = "0x9E16F0", Offset = "0x9E08F0", VA = "0x1809E16F0")]
	public void ConnectPointer(Vector2 target)
	{
	}

	[Token(Token = "0x600082C")]
	[Address(RVA = "0x9E0F90", Offset = "0x9E0190", VA = "0x1809E0F90")]
	private Vector3 CalculateAbsoluteScale(GameObject target, [Optional] GameObject stop)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600082D")]
	[Address(RVA = "0x9E2A10", Offset = "0x9E1C10", VA = "0x1809E2A10")]
	public void SetRarity(MapEditorUtil.MaptipType type)
	{
	}

	[Token(Token = "0x600082E")]
	[Address(RVA = "0x9E2E90", Offset = "0x9E2090", VA = "0x1809E2E90")]
	public MaptipWidget()
	{
	}
}
