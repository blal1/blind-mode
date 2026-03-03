using Il2CppDummyDll;
using YgomSystem.UI;

[Token(Token = "0x2000008")]
public class CardPictureSystemCheckLauncher : ViewController
{
	[Token(Token = "0x400000A")]
	private const string PREFAB_NAME = "Debug/CardPictureSystemCheck";

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x48")]
	private bool m_Boot;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x3D4F80", Offset = "0x3D4180", VA = "0x1803D4F80")]
	private void Start()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3D4F90", Offset = "0x3D4190", VA = "0x1803D4F90")]
	private void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3D5030", Offset = "0x3D4230", VA = "0x1803D5030")]
	public CardPictureSystemCheckLauncher()
	{
	}
}
