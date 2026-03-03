using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Utility;

[Token(Token = "0x200091A")]
public class LerpMover : MonoBehaviour
{
	[Token(Token = "0x400899B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float lerpTime;

	[Token(Token = "0x400899C")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 preParentPosition;

	[Token(Token = "0x400899D")]
	[FieldOffset(Offset = "0x30")]
	private Quaternion preParentRotation;

	[Token(Token = "0x400899E")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 targetPosition;

	[Token(Token = "0x400899F")]
	[FieldOffset(Offset = "0x4C")]
	private Quaternion targetRotation;

	[Token(Token = "0x40089A0")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 startPosition;

	[Token(Token = "0x40089A1")]
	[FieldOffset(Offset = "0x68")]
	private Quaternion startRotation;

	[Token(Token = "0x40089A2")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 currentPosition;

	[Token(Token = "0x40089A3")]
	[FieldOffset(Offset = "0x84")]
	private Quaternion currentRotation;

	[Token(Token = "0x40089A4")]
	[FieldOffset(Offset = "0x94")]
	private float time;

	[Token(Token = "0x600369E")]
	[Address(RVA = "0x7C5780", Offset = "0x7C4980", VA = "0x1807C5780")]
	private void Start()
	{
	}

	[Token(Token = "0x600369F")]
	[Address(RVA = "0x7C5320", Offset = "0x7C4520", VA = "0x1807C5320")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60036A0")]
	[Address(RVA = "0x5E2110", Offset = "0x5E1310", VA = "0x1805E2110")]
	public LerpMover()
	{
	}
}
