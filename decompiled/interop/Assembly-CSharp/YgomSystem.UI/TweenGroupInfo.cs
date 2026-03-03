using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200050B")]
[CreateAssetMenu(menuName = "Tween Info/Tween Group")]
public class TweenGroupInfo : TweenInfo
{
	[Token(Token = "0x40018D3")]
	[FieldOffset(Offset = "0x18")]
	public string prefix;

	[Token(Token = "0x40018D4")]
	[FieldOffset(Offset = "0x20")]
	public string suffix;

	[Token(Token = "0x40018D5")]
	[FieldOffset(Offset = "0x28")]
	public List<TweenInfo> infoList;

	[Token(Token = "0x60020E4")]
	[Address(RVA = "0x63B9B0", Offset = "0x63ABB0", VA = "0x18063B9B0")]
	public TweenGroupInfo()
	{
	}
}
