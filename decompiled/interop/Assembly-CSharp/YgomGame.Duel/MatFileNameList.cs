using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019FC")]
[CreateAssetMenu(fileName = "MatFileNameList", menuName = "Scriptable Object/MatFileNameList")]
public class MatFileNameList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20019FD")]
	public class MatFileNameInfoList
	{
		[Token(Token = "0x400EFE2")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400EFE3")]
		[FieldOffset(Offset = "0x18")]
		public string fileName;

		[Token(Token = "0x600A7D3")]
		[Address(RVA = "0xF41E40", Offset = "0xF41040", VA = "0x180F41E40")]
		public MatFileNameInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x600A7D4")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public MatFileNameInfoList()
		{
		}
	}

	[Token(Token = "0x400EFE1")]
	[FieldOffset(Offset = "0x18")]
	public List<MatFileNameInfoList> matInfoList;

	[Token(Token = "0x600A7D1")]
	[Address(RVA = "0xF41F40", Offset = "0xF41140", VA = "0x180F41F40")]
	public List<string> getFileNameList()
	{
		return null;
	}

	[Token(Token = "0x600A7D2")]
	[Address(RVA = "0xF41EC0", Offset = "0xF410C0", VA = "0x180F41EC0")]
	public MatFileNameList()
	{
	}
}
