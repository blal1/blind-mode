using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A53")]
public interface ITranslateScreenToWorld
{
	[Token(Token = "0x600AAEF")]
	Vector3 TranslateScreenToWorld(Vector2 pos);
}
