using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame;

[Token(Token = "0x20006EA")]
public class SpecialAccountIcons : MonoBehaviour
{
	[Token(Token = "0x20006EB")]
	public enum TEAMTYPE
	{
		[Token(Token = "0x40022D2")]
		Team0,
		[Token(Token = "0x40022D3")]
		Team1
	}

	[Token(Token = "0x40022CE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TEAMTYPE teamtype;

	[Token(Token = "0x40022CF")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x40022D0")]
	private const int typeNum = 3;

	[Token(Token = "0x6002E0E")]
	[Address(RVA = "0x722720", Offset = "0x721920", VA = "0x180722720")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002E0F")]
	[Address(RVA = "0x722790", Offset = "0x721990", VA = "0x180722790")]
	public int GetPlayeridByTeam(TEAMTYPE team)
	{
		return default(int);
	}

	[Token(Token = "0x6002E10")]
	[Address(RVA = "0x722A50", Offset = "0x721C50", VA = "0x180722A50")]
	private void SetSpIconByPlayerid(int playerid)
	{
	}

	[Token(Token = "0x6002E11")]
	[Address(RVA = "0x7229E0", Offset = "0x721BE0", VA = "0x1807229E0")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6002E12")]
	[Address(RVA = "0x7228B0", Offset = "0x721AB0", VA = "0x1807228B0")]
	private void HideAll()
	{
	}

	[Token(Token = "0x6002E13")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SpecialAccountIcons()
	{
	}
}
