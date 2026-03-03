using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Download;

[Token(Token = "0x2000F6C")]
[CreateAssetMenu(menuName = "Scriptable Object/DontOpenCardList")]
public class DontOpenCardList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000F6D")]
	public class DontOpenInfoList
	{
		[Token(Token = "0x400A81D")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x400A81E")]
		[FieldOffset(Offset = "0x18")]
		public string Mrk;

		[Token(Token = "0x6005DAE")]
		[Address(RVA = "0xA44C30", Offset = "0xA43E30", VA = "0x180A44C30")]
		public DontOpenInfoList Copy()
		{
			return null;
		}

		[Token(Token = "0x6005DAF")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DontOpenInfoList()
		{
		}
	}

	[Token(Token = "0x400A819")]
	[FieldOffset(Offset = "0x0")]
	private static DontOpenCardList m_Instance;

	[Token(Token = "0x400A81A")]
	private const string path = "Download/ScriptableObject/DontOpenCardList";

	[Token(Token = "0x400A81B")]
	[FieldOffset(Offset = "0x18")]
	public List<DontOpenInfoList> dontOpenInfoList;

	[Token(Token = "0x400A81C")]
	[FieldOffset(Offset = "0x20")]
	public List<int> m_avoidList;

	[Token(Token = "0x6005DAC")]
	[Address(RVA = "0xA43280", Offset = "0xA42480", VA = "0x180A43280")]
	public List<int> GetCardList()
	{
		return null;
	}

	[Token(Token = "0x6005DAD")]
	[Address(RVA = "0xA43450", Offset = "0xA42650", VA = "0x180A43450")]
	public DontOpenCardList()
	{
	}
}
