using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000057")]
[CreateAssetMenu(fileName = "BGMFileNameList", menuName = "Scriptable Object/BGMFileNameList")]
public class BGMFileNameList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000058")]
	public class BGMFileNameInfoList
	{
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x14")]
		public bool ex;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x18")]
		public string fileName;

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x3EBFD0", Offset = "0x3EB1D0", VA = "0x1803EBFD0")]
		public BGMFileNameInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public BGMFileNameInfoList()
		{
		}
	}

	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x18")]
	public List<BGMFileNameInfoList> BGMInfoList;

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x3EC0D0", Offset = "0x3EB2D0", VA = "0x1803EC0D0")]
	public List<string> getFileNameList()
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x3EC050", Offset = "0x3EB250", VA = "0x1803EC050")]
	public BGMFileNameList()
	{
	}
}
