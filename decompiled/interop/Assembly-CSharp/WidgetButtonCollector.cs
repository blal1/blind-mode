using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;
using YgomSystem.UI.FreeScroll;

[Token(Token = "0x200001B")]
public class WidgetButtonCollector : MonoBehaviour
{
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Selector selector;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public SelectionButton[] buttons;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x3EB9C0", Offset = "0x3EABC0", VA = "0x1803EB9C0")]
	public void SetButtons(FreeScrollView scroll)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public WidgetButtonCollector()
	{
	}
}
