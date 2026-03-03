using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Credit;

[Token(Token = "0x2001134")]
[CreateAssetMenu(menuName = "Scriptable Object/CreditInfo")]
public class CreditInfoObject : ScriptableObject
{
	[Token(Token = "0x400B575")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public float scrollSpeed;

	[Token(Token = "0x400B576")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<CreditInfo> creditInfoList;

	[Token(Token = "0x6006BDD")]
	[Address(RVA = "0xB2A210", Offset = "0xB29410", VA = "0x180B2A210")]
	public CreditInfoObject()
	{
	}
}
