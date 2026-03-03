using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000580")]
[AttributeUsage(AttributeTargets.Field)]
public class DirectionalPropertyDrawAttribute : PropertyAttribute
{
	[Token(Token = "0x4001ACD")]
	[FieldOffset(Offset = "0x18")]
	public readonly DirectionalPropertyAttribute.Direction directionFlag;

	[Token(Token = "0x60023BE")]
	[Address(RVA = "0x65C4D0", Offset = "0x65B6D0", VA = "0x18065C4D0")]
	public DirectionalPropertyDrawAttribute(DirectionalPropertyAttribute.Direction directionFlag = DirectionalPropertyAttribute.Direction.All)
	{
	}
}
