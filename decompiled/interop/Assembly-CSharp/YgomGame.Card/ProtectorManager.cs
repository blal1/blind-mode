using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card;

[Token(Token = "0x200162F")]
public class ProtectorManager
{
	[Token(Token = "0x400D529")]
	private const string PATH_PROTECORFOLD = "Protector/<_CARD_ILLUST_>";

	[Token(Token = "0x400D52A")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, Material> m_PidMatTable;

	[Token(Token = "0x400D52B")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, Queue<UnityAction<Material, int>>> m_PidTaskTable;

	[Token(Token = "0x400D52C")]
	[FieldOffset(Offset = "0x20")]
	private bool m_ForUI;

	[Token(Token = "0x6008A16")]
	[Address(RVA = "0xD577D0", Offset = "0xD569D0", VA = "0x180D577D0")]
	public static ProtectorManager Create(bool isforui)
	{
		return null;
	}

	[Token(Token = "0x6008A17")]
	[Address(RVA = "0xD578D0", Offset = "0xD56AD0", VA = "0x180D578D0")]
	public void GetProtectorMatAsync(int protectorId, UnityAction<Material, int> action)
	{
	}

	[Token(Token = "0x6008A18")]
	[Address(RVA = "0xD57D20", Offset = "0xD56F20", VA = "0x180D57D20")]
	public void ResetTable()
	{
	}

	[Token(Token = "0x6008A19")]
	[Address(RVA = "0xD57C60", Offset = "0xD56E60", VA = "0x180D57C60")]
	private void Initialize(bool isforui)
	{
	}

	[Token(Token = "0x6008A1A")]
	[Address(RVA = "0xD577A0", Offset = "0xD569A0", VA = "0x180D577A0")]
	private int CheckProtectorId(int protectorId)
	{
		return default(int);
	}

	[Token(Token = "0x6008A1B")]
	[Address(RVA = "0xD57BD0", Offset = "0xD56DD0", VA = "0x180D57BD0")]
	private string GetProtectorPath(int protectorId)
	{
		return null;
	}

	[Token(Token = "0x6008A1C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ProtectorManager()
	{
	}
}
