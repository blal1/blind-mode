using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000519")]
internal static class CommandManipulator
{
	[Token(Token = "0x6002483")]
	[Address(RVA = "0x2A2D030", Offset = "0x2A2C230", VA = "0x182A2D030")]
	private static bool IsParentOrAncestorOf(this VisualElement ve, VisualElement child)
	{
		return default(bool);
	}

	[Token(Token = "0x6002484")]
	[Address(RVA = "0x2A2D600", Offset = "0x2A2C800", VA = "0x182A2D600")]
	public static void ReplaceCommands(RenderChain renderChain, VisualElement ve, EntryProcessor processor)
	{
	}

	[Token(Token = "0x6002485")]
	[Address(RVA = "0x2A2CA80", Offset = "0x2A2BC80", VA = "0x182A2CA80")]
	private static void FindHeadCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
	{
	}

	[Token(Token = "0x6002486")]
	[Address(RVA = "0x2A2CCF0", Offset = "0x2A2BEF0", VA = "0x182A2CCF0")]
	private static void FindTailCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
	{
	}

	[Token(Token = "0x6002487")]
	[Address(RVA = "0x2A2D0D0", Offset = "0x2A2C2D0", VA = "0x182A2D0D0")]
	private static void RemoveChain(RenderChain renderChain, RenderChainCommand first, RenderChainCommand last)
	{
	}

	[Token(Token = "0x6002488")]
	[Address(RVA = "0x2A2DB20", Offset = "0x2A2CD20", VA = "0x182A2DB20")]
	public static void ResetCommands(RenderChain renderChain, VisualElement ve)
	{
	}

	[Token(Token = "0x6002489")]
	[Address(RVA = "0x2A2CED0", Offset = "0x2A2C0D0", VA = "0x182A2CED0")]
	private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, RenderChainCommand prev, RenderChainCommand next)
	{
	}

	[Token(Token = "0x600248A")]
	[Address(RVA = "0x2A2BEC0", Offset = "0x2A2B0C0", VA = "0x182A2BEC0")]
	public static void DisableElementRendering(RenderChain renderChain, VisualElement ve, bool renderingDisabled)
	{
	}

	[Token(Token = "0x600248B")]
	[Address(RVA = "0x2A2D1F0", Offset = "0x2A2C3F0", VA = "0x182A2D1F0")]
	private static void RemoveSingleCommand(RenderChain renderChain, VisualElement ve, RenderChainCommand cmd)
	{
	}
}
