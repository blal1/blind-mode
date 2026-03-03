using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004FD")]
public class TweenSpeedWriter : MonoBehaviour
{
	[Token(Token = "0x400189C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_Label;

	[Token(Token = "0x400189D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Tween[] m_TargetTweens;

	[Token(Token = "0x400189E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float[] m_OriginalDurations;

	[Token(Token = "0x400189F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_Speed;

	[Token(Token = "0x40018A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool m_Ready;

	[Token(Token = "0x60020C0")]
	[Address(RVA = "0x641220", Offset = "0x640420", VA = "0x180641220")]
	private void Initialize([Optional] string label)
	{
	}

	[Token(Token = "0x60020C1")]
	[Address(RVA = "0x6416C0", Offset = "0x6408C0", VA = "0x1806416C0")]
	private void WriteSpeed(float speed = 1f)
	{
	}

	[Token(Token = "0x60020C2")]
	[Address(RVA = "0x6413B0", Offset = "0x6405B0", VA = "0x1806413B0")]
	private static void InnerTargetWriteSpeed(GameObject target, float speed = 1f, [Optional] string label)
	{
	}

	[Token(Token = "0x60020C3")]
	[Address(RVA = "0x641590", Offset = "0x640790", VA = "0x180641590")]
	public static void TargetWriteSpeed(GameObject target, float speed = 1f, [Optional] string label, bool includeChildren = false)
	{
	}

	[Token(Token = "0x60020C4")]
	[Address(RVA = "0x641750", Offset = "0x640950", VA = "0x180641750")]
	public TweenSpeedWriter()
	{
	}
}
