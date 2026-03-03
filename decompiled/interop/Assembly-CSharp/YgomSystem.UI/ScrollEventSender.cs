using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YgomSystem.UI;

[Token(Token = "0x2000551")]
public class ScrollEventSender : MonoBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IScrollHandler
{
	[Token(Token = "0x40019CF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ExtendedScrollRect m_TargetScrollRect;

	[Token(Token = "0x600227E")]
	[Address(RVA = "0x64FB40", Offset = "0x64ED40", VA = "0x18064FB40", Slot = "4")]
	public void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600227F")]
	[Address(RVA = "0x64FB60", Offset = "0x64ED60", VA = "0x18064FB60", Slot = "5")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002280")]
	[Address(RVA = "0x64FB00", Offset = "0x64ED00", VA = "0x18064FB00", Slot = "7")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002281")]
	[Address(RVA = "0x64FAE0", Offset = "0x64ECE0", VA = "0x18064FAE0", Slot = "6")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002282")]
	[Address(RVA = "0x64FB20", Offset = "0x64ED20", VA = "0x18064FB20", Slot = "8")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002283")]
	[Address(RVA = "0x64FB80", Offset = "0x64ED80", VA = "0x18064FB80", Slot = "9")]
	public void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002284")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ScrollEventSender()
	{
	}
}
