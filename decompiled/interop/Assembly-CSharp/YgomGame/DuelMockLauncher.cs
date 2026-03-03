using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame;

[Token(Token = "0x2000638")]
public class DuelMockLauncher : ViewController
{
	[Token(Token = "0x4001E49")]
	private const string PREFAB_NAME = "Debug/DuelSettingDialog";

	[Token(Token = "0x4001E4A")]
	[FieldOffset(Offset = "0x48")]
	private bool isBoot;

	[Token(Token = "0x6002925")]
	[Address(RVA = "0x6D8960", Offset = "0x6D7B60", VA = "0x1806D8960")]
	private void Start()
	{
	}

	[Token(Token = "0x6002926")]
	[Address(RVA = "0x6D89D0", Offset = "0x6D7BD0", VA = "0x1806D89D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002927")]
	[Address(RVA = "0x6D8AC0", Offset = "0x6D7CC0", VA = "0x1806D8AC0")]
	public DuelMockLauncher()
	{
	}
}
