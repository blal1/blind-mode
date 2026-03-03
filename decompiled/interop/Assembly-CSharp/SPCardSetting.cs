using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000046")]
public class SPCardSetting : ScriptableObject
{
	[Token(Token = "0x400013D")]
	[FieldOffset(Offset = "0x0")]
	private static SPCardSetting m_Instance;

	[Token(Token = "0x400013E")]
	private const string PATH = "Card/ScriptableObjects/SPCardSetting";

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<int> m_SPMrksList;

	[Token(Token = "0x17000015")]
	protected static SPCardSetting Instance
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x3E3C50", Offset = "0x3E2E50", VA = "0x1803E3C50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x3E3B10", Offset = "0x3E2D10", VA = "0x1803E3B10")]
	public static bool IsSPIllust(int cardid)
	{
		return default(bool);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public SPCardSetting()
	{
	}
}
