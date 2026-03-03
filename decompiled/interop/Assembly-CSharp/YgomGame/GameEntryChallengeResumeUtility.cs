using Il2CppDummyDll;
using YgomSystem.LocalFileSystem;

namespace YgomGame;

[Token(Token = "0x200070F")]
public static class GameEntryChallengeResumeUtility
{
	[Token(Token = "0x400233E")]
	private const Storage k_FileStorage = Storage.LocalData;

	[Token(Token = "0x400233F")]
	private const string k_FilePath = "GameEntryResumeData";

	[Token(Token = "0x6002EA6")]
	[Address(RVA = "0x71D230", Offset = "0x71C430", VA = "0x18071D230")]
	public static void SaveToFile(GameEntryChallengeResumeData data)
	{
	}

	[Token(Token = "0x6002EA7")]
	[Address(RVA = "0x71CD40", Offset = "0x71BF40", VA = "0x18071CD40")]
	public static GameEntryChallengeResumeData LoadFromFile()
	{
		return null;
	}

	[Token(Token = "0x6002EA8")]
	[Address(RVA = "0x71CCE0", Offset = "0x71BEE0", VA = "0x18071CCE0")]
	public static void DeleteFile()
	{
	}
}
