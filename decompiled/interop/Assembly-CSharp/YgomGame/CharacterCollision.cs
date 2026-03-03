using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame;

[Token(Token = "0x20006ED")]
public class CharacterCollision : MonoBehaviour
{
	[Token(Token = "0x40022D7")]
	[FieldOffset(Offset = "0x20")]
	public List<CharacterCollisionData> list;

	[Token(Token = "0x6002E15")]
	[Address(RVA = "0x719440", Offset = "0x718640", VA = "0x180719440")]
	public CharacterCollision()
	{
	}
}
