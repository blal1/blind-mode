using System;
using Il2CppDummyDll;
using UnityEngine.Video;

[Serializable]
[Token(Token = "0x2000016")]
public struct LocalMoviePath
{
	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x0")]
	public string path;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x10")]
	public VideoClip clip;
}
