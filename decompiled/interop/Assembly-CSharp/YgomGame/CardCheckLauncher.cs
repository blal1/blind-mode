using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame;

[Token(Token = "0x2000629")]
public class CardCheckLauncher : ViewController
{
	[Token(Token = "0x4001DDB")]
	private const string PREFAB_NAME = "Debug/CardCheck";

	[Token(Token = "0x4001DDC")]
	[FieldOffset(Offset = "0x48")]
	private bool m_Boot;

	[Token(Token = "0x600289A")]
	[Address(RVA = "0x6A1480", Offset = "0x6A0680", VA = "0x1806A1480")]
	private void Start()
	{
	}

	[Token(Token = "0x600289B")]
	[Address(RVA = "0x6A14D0", Offset = "0x6A06D0", VA = "0x1806A14D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600289C")]
	[Address(RVA = "0x6A1570", Offset = "0x6A0770", VA = "0x1806A1570")]
	public CardCheckLauncher()
	{
	}
}
