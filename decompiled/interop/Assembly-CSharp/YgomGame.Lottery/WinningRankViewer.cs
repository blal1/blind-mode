using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Lottery;

[Token(Token = "0x200173D")]
public class WinningRankViewer : MonoBehaviour
{
	[Token(Token = "0x400DB34")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_RankNum;

	[Token(Token = "0x400DB35")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_RankImageLabel;

	[Token(Token = "0x400DB36")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_RankTextLabel;

	[Token(Token = "0x400DB37")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_DetailTextLabel;

	[Token(Token = "0x400DB38")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400DB39")]
	[FieldOffset(Offset = "0x48")]
	private ExtendedTextMeshProUGUI m_RankText;

	[Token(Token = "0x400DB3A")]
	[FieldOffset(Offset = "0x50")]
	private ExtendedTextMeshProUGUI m_DetailText;

	[Token(Token = "0x400DB3B")]
	[FieldOffset(Offset = "0x58")]
	private List<GameObject> m_BackImages;

	[Token(Token = "0x60091BD")]
	[Address(RVA = "0xDD7E80", Offset = "0xDD7080", VA = "0x180DD7E80")]
	public void Inititialize()
	{
	}

	[Token(Token = "0x60091BE")]
	[Address(RVA = "0xDD80B0", Offset = "0xDD72B0", VA = "0x180DD80B0")]
	public void SetWinningInfo(int id, LotteryUtil.WinningInfo info)
	{
	}

	[Token(Token = "0x60091BF")]
	[Address(RVA = "0xDD84A0", Offset = "0xDD76A0", VA = "0x180DD84A0")]
	public WinningRankViewer()
	{
	}
}
