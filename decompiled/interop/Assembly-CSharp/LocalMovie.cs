using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000015")]
[CreateAssetMenu(menuName = "Scriptable Object/MovieTest/LocalMovieList")]
public class LocalMovie : ScriptableObject
{
	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public List<LocalMoviePath> moviePath;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public LocalMovie()
	{
	}
}
