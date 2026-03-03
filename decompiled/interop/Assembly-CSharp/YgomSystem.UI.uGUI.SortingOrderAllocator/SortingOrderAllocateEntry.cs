using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace YgomSystem.UI.uGUI.SortingOrderAllocator;

[Token(Token = "0x2000583")]
public class SortingOrderAllocateEntry : MonoBehaviour
{
	[Token(Token = "0x2000584")]
	public enum TargetMask
	{
		[Token(Token = "0x4001ADB")]
		None = 0,
		[Token(Token = "0x4001ADC")]
		Graphic = 2,
		[Token(Token = "0x4001ADD")]
		Renderer = 4,
		[Token(Token = "0x4001ADE")]
		All = 6
	}

	[Token(Token = "0x4001AD0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_GroupLabel;

	[Token(Token = "0x4001AD1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool m_RaycastTarget;

	[Token(Token = "0x4001AD2")]
	[FieldOffset(Offset = "0x29")]
	[SerializeField]
	private bool m_Maskable;

	[Token(Token = "0x4001AD3")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[EnumFlags]
	private TargetMask m_Targets;

	[Token(Token = "0x4001AD4")]
	[FieldOffset(Offset = "0x30")]
	[Header("Assign by runtime")]
	[SerializeField]
	private int m_AllocatedOrder;

	[Token(Token = "0x4001AD5")]
	[FieldOffset(Offset = "0x38")]
	private Canvas m_NestedCanvas;

	[Token(Token = "0x4001AD6")]
	[FieldOffset(Offset = "0x40")]
	private GraphicRaycaster m_GraphicRaycaster;

	[Token(Token = "0x4001AD7")]
	[FieldOffset(Offset = "0x48")]
	private RectClippingMaskUpdater m_RectClippingMaskUpdater;

	[Token(Token = "0x4001AD8")]
	[FieldOffset(Offset = "0x50")]
	private SortingGroup m_SortingGroup;

	[Token(Token = "0x4001AD9")]
	[FieldOffset(Offset = "0x58")]
	private CanvasToSpriteMask m_CanvasToSpriteMask;

	[Token(Token = "0x170003DB")]
	public string groupLabel
	{
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003DC")]
	public bool raycastTarget
	{
		[Token(Token = "0x60023C2")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003DD")]
	public bool maskable
	{
		[Token(Token = "0x60023C3")]
		[Address(RVA = "0x62E230", Offset = "0x62D430", VA = "0x18062E230")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60023C4")]
	[Address(RVA = "0x668C60", Offset = "0x667E60", VA = "0x180668C60")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60023C5")]
	[Address(RVA = "0x669A00", Offset = "0x668C00", VA = "0x180669A00")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60023C6")]
	[Address(RVA = "0x669B00", Offset = "0x668D00", VA = "0x180669B00")]
	public void OnOrderAllocated(int order)
	{
	}

	[Token(Token = "0x60023C7")]
	[Address(RVA = "0x669B40", Offset = "0x668D40", VA = "0x180669B40")]
	private void UpdateSortingOrderToGraphic(int order)
	{
	}

	[Token(Token = "0x60023C8")]
	[Address(RVA = "0x669E00", Offset = "0x669000", VA = "0x180669E00")]
	private void UpdateSortingOrderToRenderer(int order)
	{
	}

	[Token(Token = "0x60023C9")]
	[Address(RVA = "0x66A070", Offset = "0x669270", VA = "0x18066A070")]
	public SortingOrderAllocateEntry()
	{
	}
}
