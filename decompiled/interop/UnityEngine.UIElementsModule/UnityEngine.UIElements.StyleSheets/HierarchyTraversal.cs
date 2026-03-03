using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005BB")]
internal abstract class HierarchyTraversal
{
	[Token(Token = "0x60027C5")]
	[Address(RVA = "0x2A69E90", Offset = "0x2A69090", VA = "0x182A69E90", Slot = "4")]
	public virtual void Traverse(VisualElement element)
	{
	}

	[Token(Token = "0x60027C6")]
	public abstract void TraverseRecursive(VisualElement element, int depth);

	[Token(Token = "0x60027C7")]
	[Address(RVA = "0x2A69DC0", Offset = "0x2A68FC0", VA = "0x182A69DC0")]
	protected void Recurse(VisualElement element, int depth)
	{
	}

	[Token(Token = "0x60027C8")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected HierarchyTraversal()
	{
	}
}
