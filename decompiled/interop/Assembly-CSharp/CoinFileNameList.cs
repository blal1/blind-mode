using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200005A")]
[CreateAssetMenu(fileName = "CoinFileNameList", menuName = "Scriptable Objects/CoinFileNameList")]
public class CoinFileNameList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200005B")]
	public class CoinFileNameInfoList
	{
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x14")]
		public bool ex;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x18")]
		public string fileName;

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x3EC990", Offset = "0x3EBB90", VA = "0x1803EC990")]
		public CoinFileNameInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CoinFileNameInfoList()
		{
		}
	}

	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x18")]
	public List<CoinFileNameInfoList> CoinInfoList;

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x3ECA90", Offset = "0x3EBC90", VA = "0x1803ECA90")]
	public List<string> getFileNameList()
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x3ECA10", Offset = "0x3EBC10", VA = "0x1803ECA10")]
	public CoinFileNameList()
	{
	}
}
