using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002D0")]
public interface IResTypeChecker
{
	[Token(Token = "0x6001133")]
	void Initialize();

	[Token(Token = "0x6001134")]
	void Destroy();

	[Token(Token = "0x6001135")]
	void ClearCache();

	[Token(Token = "0x6001136")]
	ResTypeData GetResType(string path);

	[Token(Token = "0x6001137")]
	ResTypeData GetResTypeSimpleCheck(string path);
}
