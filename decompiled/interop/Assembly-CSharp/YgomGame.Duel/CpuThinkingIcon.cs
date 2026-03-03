using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Duel;

[Token(Token = "0x200187C")]
public class CpuThinkingIcon : MonoBehaviour
{
	[Token(Token = "0x400E5EC")]
	[FieldOffset(Offset = "0x20")]
	private float MAXTHINKINGTIME;

	[Token(Token = "0x400E5ED")]
	[FieldOffset(Offset = "0x24")]
	private float m_CpuThinkingCount;

	[Token(Token = "0x400E5EE")]
	[FieldOffset(Offset = "0x28")]
	private bool m_ShowIcon;

	[Token(Token = "0x400E5EF")]
	[FieldOffset(Offset = "0x30")]
	private CanvasGroup m_CanvasGroup;

	[Token(Token = "0x6009CC0")]
	[Address(RVA = "0xEA0810", Offset = "0xE9FA10", VA = "0x180EA0810")]
	public static void Create(Transform parent, UnityAction<CpuThinkingIcon> onFinish)
	{
	}

	[Token(Token = "0x6009CC1")]
	[Address(RVA = "0xEA0A50", Offset = "0xE9FC50", VA = "0x180EA0A50")]
	public void OnCpuThinkingBegin()
	{
	}

	[Token(Token = "0x6009CC2")]
	[Address(RVA = "0xEA0AB0", Offset = "0xE9FCB0", VA = "0x180EA0AB0")]
	public void OnCpuThinkingEnd()
	{
	}

	[Token(Token = "0x6009CC3")]
	[Address(RVA = "0xEA0900", Offset = "0xE9FB00", VA = "0x180EA0900")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x6009CC4")]
	[Address(RVA = "0xEA0B20", Offset = "0xE9FD20", VA = "0x180EA0B20")]
	private void ResetMenbers()
	{
	}

	[Token(Token = "0x6009CC5")]
	[Address(RVA = "0xEA0BB0", Offset = "0xE9FDB0", VA = "0x180EA0BB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6009CC6")]
	[Address(RVA = "0xEA0C10", Offset = "0xE9FE10", VA = "0x180EA0C10")]
	public CpuThinkingIcon()
	{
	}
}
