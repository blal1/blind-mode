using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Movie;

[Token(Token = "0x20016C2")]
[CreateAssetMenu(menuName = "Scriptable Object/Movie/FrameMarkAsset")]
public class FrameMarkAsset : ScriptableObject
{
	[Token(Token = "0x400D863")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<Marker> markers;

	[Token(Token = "0x6008DA0")]
	[Address(RVA = "0xD79D00", Offset = "0xD78F00", VA = "0x180D79D00")]
	public void SortFrame()
	{
	}

	[Token(Token = "0x6008DA1")]
	[Address(RVA = "0xD79E20", Offset = "0xD79020", VA = "0x180D79E20")]
	public FrameMarkAsset()
	{
	}
}
