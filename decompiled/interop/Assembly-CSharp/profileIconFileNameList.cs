using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200005D")]
[CreateAssetMenu(fileName = "ProfileIconFileNameList", menuName = "Scriptable Object/ProfileIconFileNameList")]
public class profileIconFileNameList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200005E")]
	public class ProfileIconFileNameInfoList
	{
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x18")]
		public string fileName;

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x3F42F0", Offset = "0x3F34F0", VA = "0x1803F42F0")]
		public ProfileIconFileNameInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ProfileIconFileNameInfoList()
		{
		}
	}

	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x18")]
	public List<ProfileIconFileNameInfoList> profileIconFileNameInfoList;

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x402B80", Offset = "0x401D80", VA = "0x180402B80")]
	public List<string> getFileNameList()
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x402B00", Offset = "0x401D00", VA = "0x180402B00")]
	public profileIconFileNameList()
	{
	}
}
