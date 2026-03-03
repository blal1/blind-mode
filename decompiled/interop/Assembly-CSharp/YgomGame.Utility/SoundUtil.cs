using Il2CppDummyDll;

namespace YgomGame.Utility;

[Token(Token = "0x2000915")]
public class SoundUtil
{
	[Token(Token = "0x4008992")]
	private const string BGM_MENU_MAIN = "BGM_MENU_01";

	[Token(Token = "0x6003688")]
	[Address(RVA = "0x7C9460", Offset = "0x7C8660", VA = "0x1807C9460")]
	public static string MenuBGMLabel()
	{
		return null;
	}

	[Token(Token = "0x6003689")]
	[Address(RVA = "0x7C93F0", Offset = "0x7C85F0", VA = "0x1807C93F0")]
	public static string MenuBGMLabelOrNoChange(string label)
	{
		return null;
	}

	[Token(Token = "0x600368A")]
	[Address(RVA = "0x7C9490", Offset = "0x7C8690", VA = "0x1807C9490")]
	public static void PlayBGMSeamlessly(string label)
	{
	}

	[Token(Token = "0x600368B")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SoundUtil()
	{
	}
}
