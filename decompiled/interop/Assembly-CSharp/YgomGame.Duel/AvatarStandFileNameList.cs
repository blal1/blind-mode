using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019F6")]
[CreateAssetMenu(fileName = "AvatarStandFileNameList", menuName = "Scriptable Object/AvatarStandFileNameList")]
public class AvatarStandFileNameList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20019F7")]
	public class AvatarStandFileNameInfoList
	{
		[Token(Token = "0x400EFDA")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400EFDB")]
		[FieldOffset(Offset = "0x18")]
		public string fileName;

		[Token(Token = "0x600A7C7")]
		[Address(RVA = "0xF2EA90", Offset = "0xF2DC90", VA = "0x180F2EA90")]
		public AvatarStandFileNameInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x600A7C8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AvatarStandFileNameInfoList()
		{
		}
	}

	[Token(Token = "0x400EFD9")]
	[FieldOffset(Offset = "0x18")]
	public List<AvatarStandFileNameInfoList> avatarStandInfoList;

	[Token(Token = "0x600A7C5")]
	[Address(RVA = "0xF2EB90", Offset = "0xF2DD90", VA = "0x180F2EB90")]
	public List<string> getFileNameList()
	{
		return null;
	}

	[Token(Token = "0x600A7C6")]
	[Address(RVA = "0xF2EB10", Offset = "0xF2DD10", VA = "0x180F2EB10")]
	public AvatarStandFileNameList()
	{
	}
}
