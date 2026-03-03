using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001AB2")]
public class SwitchingDeckModel : MonoBehaviour
{
	[Token(Token = "0x2001AB3")]
	public enum MoveType
	{
		[Token(Token = "0x400F559")]
		Outgoing,
		[Token(Token = "0x400F55A")]
		Incoming
	}

	[Token(Token = "0x2001AB4")]
	private enum Step
	{
		[Token(Token = "0x400F55C")]
		Idle,
		[Token(Token = "0x400F55D")]
		WaitOutgoing,
		[Token(Token = "0x400F55E")]
		WaitIncoming
	}

	[Token(Token = "0x400F550")]
	[FieldOffset(Offset = "0x20")]
	private Step step;

	[Token(Token = "0x400F551")]
	[FieldOffset(Offset = "0x24")]
	private float time;

	[Token(Token = "0x400F552")]
	[FieldOffset(Offset = "0x28")]
	private MeshAlphaFader alphaFader;

	[Token(Token = "0x400F553")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 posFrom;

	[Token(Token = "0x400F554")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 posTo;

	[Token(Token = "0x400F555")]
	[FieldOffset(Offset = "0x48")]
	private Material frontMtrl;

	[Token(Token = "0x400F556")]
	private const float dulation = 0.5f;

	[Token(Token = "0x400F557")]
	private const float sideOffset = 5.9f;

	[Token(Token = "0x600ADA1")]
	[Address(RVA = "0x44BC10", Offset = "0x44AE10", VA = "0x18044BC10")]
	private void Awake()
	{
	}

	[Token(Token = "0x600ADA2")]
	[Address(RVA = "0x44BF60", Offset = "0x44B160", VA = "0x18044BF60")]
	public void SetTopTexture(Texture texture)
	{
	}

	[Token(Token = "0x600ADA3")]
	[Address(RVA = "0x44BF80", Offset = "0x44B180", VA = "0x18044BF80")]
	public void StartSwitching(MoveType moveType, Action onFinished)
	{
	}

	[Token(Token = "0x600ADA4")]
	[Address(RVA = "0x44C140", Offset = "0x44B340", VA = "0x18044C140")]
	private void Update()
	{
	}

	[Token(Token = "0x600ADA5")]
	[Address(RVA = "0x44BEC0", Offset = "0x44B0C0", VA = "0x18044BEC0")]
	private void InitOutgoing(Vector3 pos, Action onFinished)
	{
	}

	[Token(Token = "0x600ADA6")]
	[Address(RVA = "0x44C1A0", Offset = "0x44B3A0", VA = "0x18044C1A0")]
	private void WaitOutgoingStep()
	{
	}

	[Token(Token = "0x600ADA7")]
	[Address(RVA = "0x44BE20", Offset = "0x44B020", VA = "0x18044BE20")]
	private void InitIncoming(Vector3 pos, Action onFinished)
	{
	}

	[Token(Token = "0x600ADA8")]
	[Address(RVA = "0x44C190", Offset = "0x44B390", VA = "0x18044C190")]
	private void WaitIncomingStep()
	{
	}

	[Token(Token = "0x600ADA9")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SwitchingDeckModel()
	{
	}
}
