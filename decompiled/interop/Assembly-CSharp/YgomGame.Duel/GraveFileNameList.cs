using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019F9")]
[CreateAssetMenu(fileName = "GraveFileNameList", menuName = "Scriptable Object/GraveFileNameList")]
public class GraveFileNameList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20019FA")]
	public class GraveFileNameInfoList
	{
		[Token(Token = "0x400EFDE")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400EFDF")]
		[FieldOffset(Offset = "0x18")]
		public string fileName;

		[Token(Token = "0x600A7CD")]
		[Address(RVA = "0xF41C30", Offset = "0xF40E30", VA = "0x180F41C30")]
		public GraveFileNameInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x600A7CE")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public GraveFileNameInfoList()
		{
		}
	}

	[Token(Token = "0x400EFDD")]
	[FieldOffset(Offset = "0x18")]
	public List<GraveFileNameInfoList> graveInfoList;

	[Token(Token = "0x600A7CB")]
	[Address(RVA = "0xF41D30", Offset = "0xF40F30", VA = "0x180F41D30")]
	public List<string> getFileNameList()
	{
		return null;
	}

	[Token(Token = "0x600A7CC")]
	[Address(RVA = "0xF41CB0", Offset = "0xF40EB0", VA = "0x180F41CB0")]
	public GraveFileNameList()
	{
	}
}
