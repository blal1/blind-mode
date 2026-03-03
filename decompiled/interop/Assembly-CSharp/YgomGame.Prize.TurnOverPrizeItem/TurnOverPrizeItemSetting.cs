using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Prize.TurnOverPrizeItem;

[Token(Token = "0x2000B9A")]
[CreateAssetMenu(menuName = "Scriptable Object/Turn Over Prize/Turn Over Prize ItemSetting")]
public class TurnOverPrizeItemSetting : ScriptableObject
{
	[Token(Token = "0x400975D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<ItemSetting> category;

	[Token(Token = "0x400975E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public List<ItemSetting> itemID;

	[Token(Token = "0x60046BB")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public TurnOverPrizeItemSetting()
	{
	}
}
