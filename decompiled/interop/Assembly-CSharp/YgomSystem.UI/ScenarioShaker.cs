using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000432")]
public class ScenarioShaker : MonoBehaviour
{
	[Token(Token = "0x4001482")]
	[FieldOffset(Offset = "0x20")]
	private bool m_Playing;

	[Token(Token = "0x4001483")]
	[FieldOffset(Offset = "0x24")]
	private float m_CycleDuration;

	[Token(Token = "0x4001484")]
	[FieldOffset(Offset = "0x28")]
	private float m_Amount;

	[Token(Token = "0x4001485")]
	[FieldOffset(Offset = "0x2C")]
	private float m_AutoStopSec;

	[Token(Token = "0x4001486")]
	[FieldOffset(Offset = "0x30")]
	private float m_CycleSec;

	[Token(Token = "0x4001487")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform m_RectTran;

	[Token(Token = "0x4001488")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_StartPos;

	[Token(Token = "0x4001489")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 m_From;

	[Token(Token = "0x400148A")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_To;

	[Token(Token = "0x400148B")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 m_MoveMin;

	[Token(Token = "0x400148C")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 m_MoveMax;

	[Token(Token = "0x400148D")]
	[FieldOffset(Offset = "0x7C")]
	private int m_MoveDir;

	[Token(Token = "0x400148E")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsAutoStop;

	[Token(Token = "0x400148F")]
	[FieldOffset(Offset = "0x88")]
	private Action<float> m_OnShakeSetValueAction;

	[Token(Token = "0x6001AE4")]
	[Address(RVA = "0x5EBB00", Offset = "0x5EAD00", VA = "0x1805EBB00")]
	public static ScenarioShaker Attouch(GameObject target)
	{
		return null;
	}

	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x5EC560", Offset = "0x5EB760", VA = "0x1805EC560")]
	public void PlayShake(float cycleDuration, float amount, bool shakeX, bool shakeY, float stopSec = 0f)
	{
	}

	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x5EC7B0", Offset = "0x5EB9B0", VA = "0x1805EC7B0")]
	public void StopShake()
	{
	}

	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x5EC7C0", Offset = "0x5EB9C0", VA = "0x1805EC7C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001AE8")]
	[Address(RVA = "0x5EBED0", Offset = "0x5EB0D0", VA = "0x1805EBED0")]
	private void OnShakeXYSetValue(float par)
	{
	}

	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x5EBB60", Offset = "0x5EAD60", VA = "0x1805EBB60")]
	private void OnShakeXSetValue(float par)
	{
	}

	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x5EC250", Offset = "0x5EB450", VA = "0x1805EC250")]
	private void OnShakeYSetValue(float par)
	{
	}

	[Token(Token = "0x6001AEB")]
	[Address(RVA = "0x5EC920", Offset = "0x5EBB20", VA = "0x1805EC920")]
	public ScenarioShaker()
	{
	}
}
