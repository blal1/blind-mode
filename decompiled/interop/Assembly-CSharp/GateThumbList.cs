using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200008C")]
[CreateAssetMenu(menuName = "Scriptable Object/Solo/GateThumbList")]
public class GateThumbList : ScriptableObject
{
	[Token(Token = "0x40002DE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<ThumbPath> gateThumbList;

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public GateThumbList()
	{
	}
}
