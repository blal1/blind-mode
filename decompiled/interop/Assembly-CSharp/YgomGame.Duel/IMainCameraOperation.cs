using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001A4B")]
public interface IMainCameraOperation
{
	[Token(Token = "0x600AABE")]
	void UpdateOperation(MainCameraOrganizer mainCamera);

	[Token(Token = "0x600AABF")]
	void LateUpdateOperation(MainCameraOrganizer mainCamera);
}
