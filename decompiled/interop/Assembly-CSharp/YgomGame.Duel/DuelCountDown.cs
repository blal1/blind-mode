using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001889")]
public class DuelCountDown : MonoBehaviour
{
	[Token(Token = "0x400E623")]
	private const int DEACTIVECOUJNTMAX = 120;

	[Token(Token = "0x400E624")]
	[FieldOffset(Offset = "0x0")]
	private static DuelCountDown m_Instance;

	[Token(Token = "0x400E625")]
	[FieldOffset(Offset = "0x8")]
	private static Queue<int> m_TaskQueue;

	[Token(Token = "0x400E626")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int m_FontSize_Text;

	[Token(Token = "0x400E627")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int m_FontSize_Number;

	[Token(Token = "0x400E628")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Color m_FontColor;

	[Token(Token = "0x400E629")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int m_CountDownStartLine;

	[Token(Token = "0x400E62A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int[] m_CountDownShowUpTime;

	[Token(Token = "0x400E62B")]
	[FieldOffset(Offset = "0x48")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400E62C")]
	[FieldOffset(Offset = "0x50")]
	private ExtendedTextMeshProUGUI m_CountDownText;

	[Token(Token = "0x400E62D")]
	[FieldOffset(Offset = "0x58")]
	private string m_Str_RestTime;

	[Token(Token = "0x400E62E")]
	[FieldOffset(Offset = "0x60")]
	private string m_Str_Seconds;

	[Token(Token = "0x400E62F")]
	[FieldOffset(Offset = "0x68")]
	private int m_DeactiveCount;

	[Token(Token = "0x6009D0E")]
	[Address(RVA = "0xEA3C40", Offset = "0xEA2E40", VA = "0x180EA3C40")]
	public static void Create(Transform parent)
	{
	}

	[Token(Token = "0x6009D0F")]
	[Address(RVA = "0xEA3BC0", Offset = "0xEA2DC0", VA = "0x180EA3BC0")]
	public static void AddCountDownCmd(int number)
	{
	}

	[Token(Token = "0x6009D10")]
	[Address(RVA = "0xEA3DF0", Offset = "0xEA2FF0", VA = "0x180EA3DF0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6009D11")]
	[Address(RVA = "0xEA4590", Offset = "0xEA3790", VA = "0x180EA4590")]
	private void Update()
	{
	}

	[Token(Token = "0x6009D12")]
	[Address(RVA = "0xEA3D70", Offset = "0xEA2F70", VA = "0x180EA3D70")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6009D13")]
	[Address(RVA = "0xEA4030", Offset = "0xEA3230", VA = "0x180EA4030")]
	private void ShowCountDownImpl(int number)
	{
	}

	[Token(Token = "0x6009D14")]
	[Address(RVA = "0xEA3F70", Offset = "0xEA3170", VA = "0x180EA3F70")]
	private void SetCountDownTextActive(bool active)
	{
	}

	[Token(Token = "0x6009D15")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelCountDown()
	{
	}
}
