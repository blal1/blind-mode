using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YgomSystem.UI;

[Token(Token = "0x2000445")]
[AddComponentMenu("Ygom/UI/uGUI/Nested Scroll Rect")]
public class NestedScrollRect : ExtendedScrollRect
{
	[Token(Token = "0x40014E9")]
	[FieldOffset(Offset = "0x1A8")]
	public bool alwaysRouteToParent;

	[Token(Token = "0x40014EA")]
	[FieldOffset(Offset = "0x1A9")]
	private bool routeToParent;

	[Token(Token = "0x6001B6E")]
	[Address(RVA = "0x5EB740", Offset = "0x5EA940", VA = "0x1805EB740", Slot = "43")]
	public override void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001B6F")]
	[Address(RVA = "0x5EB400", Offset = "0x5EA600", VA = "0x1805EB400", Slot = "46")]
	public override void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001B70")]
	[Address(RVA = "0x5EB100", Offset = "0x5EA300", VA = "0x1805EB100", Slot = "44")]
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001B71")]
	[Address(RVA = "0x5EB5A0", Offset = "0x5EA7A0", VA = "0x1805EB5A0", Slot = "45")]
	public override void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001B72")]
	[Address(RVA = "0x5EB940", Offset = "0x5EAB40", VA = "0x1805EB940", Slot = "42")]
	public override void OnScroll(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6001B73")]
	[Address(RVA = "0x5E5470", Offset = "0x5E4670", VA = "0x1805E5470")]
	public NestedScrollRect()
	{
	}
}
