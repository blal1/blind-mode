using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001AB6")]
public class TranslateScreenToWorldXZ : ITranslateScreenToWorld
{
	[Token(Token = "0x400F566")]
	[FieldOffset(Offset = "0x10")]
	private Camera cam;

	[Token(Token = "0x600ADB7")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public TranslateScreenToWorldXZ(Camera cam)
	{
	}

	[Token(Token = "0x600ADB8")]
	[Address(RVA = "0x44F130", Offset = "0x44E330", VA = "0x18044F130", Slot = "4")]
	public Vector3 TranslateScreenToWorld(Vector2 pos)
	{
		return default(Vector3);
	}
}
