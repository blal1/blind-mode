using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame;

[Serializable]
[Token(Token = "0x20006EC")]
public class CharacterCollisionData
{
	[Token(Token = "0x40022D4")]
	[FieldOffset(Offset = "0x10")]
	public GameObject target;

	[Token(Token = "0x40022D5")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 center;

	[Token(Token = "0x40022D6")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 size;

	[Token(Token = "0x6002E14")]
	[Address(RVA = "0x7193D0", Offset = "0x7185D0", VA = "0x1807193D0")]
	public CharacterCollisionData(GameObject target, Vector3 center, Vector3 size)
	{
	}
}
