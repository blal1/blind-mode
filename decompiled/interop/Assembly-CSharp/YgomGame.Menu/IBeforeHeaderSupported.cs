using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu;

[Token(Token = "0x20012BA")]
public interface IBeforeHeaderSupported
{
	[Token(Token = "0x6007446")]
	GameObject GetBeforeParts();

	[Token(Token = "0x6007447")]
	void SetBeforePartsVisible(bool visible);
}
