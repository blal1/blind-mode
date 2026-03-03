using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200051C")]
internal class DefaultElementBuilder : BaseElementBuilder
{
	[Token(Token = "0x40010D4")]
	[FieldOffset(Offset = "0x10")]
	private RenderChain m_RenderChain;

	[Token(Token = "0x6002499")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public DefaultElementBuilder(RenderChain renderChain)
	{
	}

	[Token(Token = "0x600249A")]
	[Address(RVA = "0x2A30990", Offset = "0x2A2FB90", VA = "0x182A30990", Slot = "4")]
	public override bool RequiresStencilMask(VisualElement ve)
	{
		return default(bool);
	}

	[Token(Token = "0x600249B")]
	[Address(RVA = "0x2A2E5D0", Offset = "0x2A2D7D0", VA = "0x182A2E5D0", Slot = "5")]
	protected override void DrawVisualElementBackground(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600249C")]
	[Address(RVA = "0x2A2FAE0", Offset = "0x2A2ECE0", VA = "0x182A2FAE0", Slot = "6")]
	protected override void DrawVisualElementBorder(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600249D")]
	[Address(RVA = "0x2A30250", Offset = "0x2A2F450", VA = "0x182A30250", Slot = "7")]
	protected override void DrawVisualElementStencilMask(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600249E")]
	[Address(RVA = "0x2A30300", Offset = "0x2A2F500", VA = "0x182A30300")]
	private static void GenerateStencilClipEntryForRoundedRectBackground(MeshGenerationContext mgc)
	{
	}

	[Token(Token = "0x600249F")]
	[Address(RVA = "0x2A30A10", Offset = "0x2A2FC10", VA = "0x182A30A10", Slot = "8")]
	public override void ScheduleMeshGenerationJobs(MeshGenerationContext mgc)
	{
	}
}
