using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000054")]
[CreateAssetMenu(fileName = "AvatarFileNameList", menuName = "Scriptable Object/AvatarFileNameList")]
public class AvatarFileNameList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000055")]
	public class AvatarFileNameInfoList
	{
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x18")]
		public string fileName;

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x3EBDC0", Offset = "0x3EAFC0", VA = "0x1803EBDC0")]
		public AvatarFileNameInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AvatarFileNameInfoList()
		{
		}
	}

	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x18")]
	public List<AvatarFileNameInfoList> avatarInfoList;

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x3EBEC0", Offset = "0x3EB0C0", VA = "0x1803EBEC0")]
	public List<string> getFileNameList()
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x3EBE40", Offset = "0x3EB040", VA = "0x1803EBE40")]
	public AvatarFileNameList()
	{
	}
}
