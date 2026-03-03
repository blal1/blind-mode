using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000063")]
[CreateAssetMenu(fileName = "ProtectorFileNameList", menuName = "Scriptable Object/ProtectorFileNameList")]
public class ProtectorFileNameList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000064")]
	public class ProtectorFileNameInfoList
	{
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x18")]
		public string fileName;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x3F4580", Offset = "0x3F3780", VA = "0x1803F4580")]
		public ProtectorFileNameInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ProtectorFileNameInfoList()
		{
		}
	}

	[Token(Token = "0x40001C2")]
	[FieldOffset(Offset = "0x18")]
	public List<ProtectorFileNameInfoList> protectorInfoList;

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x3F4680", Offset = "0x3F3880", VA = "0x1803F4680")]
	public List<string> getFileNameList()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x3F4600", Offset = "0x3F3800", VA = "0x1803F4600")]
	public ProtectorFileNameList()
	{
	}
}
