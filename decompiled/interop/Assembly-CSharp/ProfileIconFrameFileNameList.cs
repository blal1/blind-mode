using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000060")]
[CreateAssetMenu(fileName = "ProfileIconFrameFileNameList", menuName = "Scriptable Object/ProfileIconFrameFileNameList")]
public class ProfileIconFrameFileNameList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000061")]
	public class ProfileIconFrameFileNameInfoList
	{
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x18")]
		public string fileName;

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x3F4370", Offset = "0x3F3570", VA = "0x1803F4370")]
		public ProfileIconFrameFileNameInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ProfileIconFrameFileNameInfoList()
		{
		}
	}

	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x18")]
	public List<ProfileIconFrameFileNameInfoList> profileIconFrameFileNameInfoList;

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x3F4470", Offset = "0x3F3670", VA = "0x1803F4470")]
	public List<string> getFileNameList()
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x3F43F0", Offset = "0x3F35F0", VA = "0x1803F43F0")]
	public ProfileIconFrameFileNameList()
	{
	}
}
