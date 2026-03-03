using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Movie;

[Token(Token = "0x20016D4")]
[CreateAssetMenu(menuName = "Scriptable Object/Movie/SubtitleBindAsset")]
public class SubtitleBindAsset : ScriptableObject
{
	[Token(Token = "0x400D8D3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<SubtitleInfo> Subtitles;

	[Token(Token = "0x400D8D4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int textSize;

	[Token(Token = "0x400D8D5")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int textSpacing;

	[Token(Token = "0x6008E1A")]
	[Address(RVA = "0xDA5550", Offset = "0xDA4750", VA = "0x180DA5550")]
	public SubtitleBindAsset()
	{
	}
}
