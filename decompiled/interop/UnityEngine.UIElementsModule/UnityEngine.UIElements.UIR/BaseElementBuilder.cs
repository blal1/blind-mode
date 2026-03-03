using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200051B")]
internal abstract class BaseElementBuilder
{
	[Token(Token = "0x600248F")]
	public abstract bool RequiresStencilMask(VisualElement ve);

	[Token(Token = "0x6002490")]
	[Address(RVA = "0x2A29950", Offset = "0x2A28B50", VA = "0x182A29950")]
	public void Build(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x6002491")]
	protected abstract void DrawVisualElementBackground(MeshGenerationContext mgc);

	[Token(Token = "0x6002492")]
	protected abstract void DrawVisualElementBorder(MeshGenerationContext mgc);

	[Token(Token = "0x6002493")]
	protected abstract void DrawVisualElementStencilMask(MeshGenerationContext mgc);

	[Token(Token = "0x6002494")]
	public abstract void ScheduleMeshGenerationJobs(MeshGenerationContext mgc);

	[Token(Token = "0x6002495")]
	[Address(RVA = "0x2A2A0F0", Offset = "0x2A292F0", VA = "0x182A2A0F0")]
	private void PushVisualElementClipping(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x6002496")]
	[Address(RVA = "0x2A29FF0", Offset = "0x2A291F0", VA = "0x182A29FF0")]
	private static void PopVisualElementClipping(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x6002497")]
	[Address(RVA = "0x2A29EF0", Offset = "0x2A290F0", VA = "0x182A29EF0")]
	private static void InvokeGenerateVisualContent(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x6002498")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected BaseElementBuilder()
	{
	}
}
