using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200005B")]
public class ListViewController : BaseListViewController
{
	[Token(Token = "0x17000066")]
	protected ListView listView
	{
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x29AA910", Offset = "0x29A9B10", VA = "0x1829AA910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x29AA7C0", Offset = "0x29A99C0", VA = "0x1829AA7C0", Slot = "20")]
	protected override VisualElement MakeItem()
	{
		return null;
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x29AA520", Offset = "0x29A9720", VA = "0x1829AA520", Slot = "21")]
	protected override void BindItem(VisualElement element, int index)
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x29AA8C0", Offset = "0x29A9AC0", VA = "0x1829AA8C0", Slot = "22")]
	protected override void UnbindItem(VisualElement element, int index)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x29AA770", Offset = "0x29A9970", VA = "0x1829AA770", Slot = "23")]
	protected override void DestroyItem(VisualElement element)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ListViewController()
	{
	}
}
