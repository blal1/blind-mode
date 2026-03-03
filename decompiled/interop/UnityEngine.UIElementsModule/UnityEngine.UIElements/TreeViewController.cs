using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200005F")]
public abstract class TreeViewController : BaseTreeViewController
{
	[Token(Token = "0x17000069")]
	protected TreeView treeView
	{
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x29AEA40", Offset = "0x29ADC40", VA = "0x1829AEA40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x29AE8A0", Offset = "0x29ADAA0", VA = "0x1829AE8A0", Slot = "20")]
	protected override VisualElement MakeItem()
	{
		return null;
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x29AE690", Offset = "0x29AD890", VA = "0x1829AE690", Slot = "21")]
	protected override void BindItem(VisualElement element, int index)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x29AE9A0", Offset = "0x29ADBA0", VA = "0x1829AE9A0", Slot = "22")]
	protected override void UnbindItem(VisualElement element, int index)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x29AE850", Offset = "0x29ADA50", VA = "0x1829AE850", Slot = "23")]
	protected override void DestroyItem(VisualElement element)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x29AE9F0", Offset = "0x29ADBF0", VA = "0x1829AE9F0")]
	protected TreeViewController()
	{
	}
}
