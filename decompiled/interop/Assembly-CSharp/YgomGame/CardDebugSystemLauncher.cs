using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame;

[Token(Token = "0x2000630")]
public class CardDebugSystemLauncher : ViewController
{
	[Token(Token = "0x4001E2A")]
	private const string PREFAB_NAME = "Debug/CardDebugSystem";

	[Token(Token = "0x4001E2B")]
	[FieldOffset(Offset = "0x48")]
	private bool m_Boot;

	[Token(Token = "0x6002906")]
	[Address(RVA = "0x6A5A70", Offset = "0x6A4C70", VA = "0x1806A5A70")]
	private void Start()
	{
	}

	[Token(Token = "0x6002907")]
	[Address(RVA = "0x6A5B40", Offset = "0x6A4D40", VA = "0x1806A5B40")]
	private void Update()
	{
	}

	[Token(Token = "0x6002908")]
	[Address(RVA = "0x6A5C30", Offset = "0x6A4E30", VA = "0x1806A5C30")]
	public CardDebugSystemLauncher()
	{
	}
}
