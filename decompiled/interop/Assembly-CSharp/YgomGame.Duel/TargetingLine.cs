using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001AB5")]
public class TargetingLine : MonoBehaviour
{
	[Token(Token = "0x400F55F")]
	[FieldOffset(Offset = "0x20")]
	private SimpleEffect effect;

	[Token(Token = "0x400F560")]
	[FieldOffset(Offset = "0x28")]
	private LineRenderer lineRendererMain;

	[Token(Token = "0x400F561")]
	[FieldOffset(Offset = "0x30")]
	private LineRenderer lineRendererSub;

	[Token(Token = "0x400F562")]
	[FieldOffset(Offset = "0x38")]
	private Vector3[] originPositionsMain;

	[Token(Token = "0x400F563")]
	[FieldOffset(Offset = "0x40")]
	private Vector3[] originPositionsSub;

	[Token(Token = "0x400F564")]
	[FieldOffset(Offset = "0x48")]
	private bool usePrefabHeight;

	[Token(Token = "0x17001AE3")]
	public float minLength
	{
		[Token(Token = "0x600ADAA")]
		[Address(RVA = "0x44F110", Offset = "0x44E310", VA = "0x18044F110")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600ADAB")]
		[Address(RVA = "0x44F120", Offset = "0x44E320", VA = "0x18044F120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600ADAC")]
	[Address(RVA = "0x44E4C0", Offset = "0x44D6C0", VA = "0x18044E4C0")]
	public static TargetingLine Create(DuelGameObjectManager goManager, DuelEffectPool.Type effectType, bool usePrefabHeight = true, bool setOver3DLayer = true)
	{
		return null;
	}

	[Token(Token = "0x600ADAD")]
	[Address(RVA = "0x44E5F0", Offset = "0x44D7F0", VA = "0x18044E5F0")]
	private void Initialize(bool setOver3DLayer)
	{
	}

	[Token(Token = "0x600ADAE")]
	[Address(RVA = "0x44F050", Offset = "0x44E250", VA = "0x18044F050")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600ADAF")]
	[Address(RVA = "0x44EE10", Offset = "0x44E010", VA = "0x18044EE10")]
	public void SetPosition(Vector3 tailPosition, Vector3 headPosition)
	{
	}

	[Token(Token = "0x600ADB0")]
	[Address(RVA = "0x44E9E0", Offset = "0x44DBE0", VA = "0x18044E9E0")]
	private void SetPositionMain(Vector3 tailPosition, Vector3 headPosition)
	{
	}

	[Token(Token = "0x600ADB1")]
	[Address(RVA = "0x44EC00", Offset = "0x44DE00", VA = "0x18044EC00")]
	private void SetPositionSub(Vector3 tailPosition, Vector3 headPosition)
	{
	}

	[Token(Token = "0x600ADB2")]
	[Address(RVA = "0x44E5A0", Offset = "0x44D7A0", VA = "0x18044E5A0")]
	public Vector3 GetOriginHeadPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600ADB3")]
	[Address(RVA = "0x44E9B0", Offset = "0x44DBB0", VA = "0x18044E9B0")]
	public void SetDisp(bool disp)
	{
	}

	[Token(Token = "0x600ADB4")]
	[Address(RVA = "0x44EF00", Offset = "0x44E100", VA = "0x18044EF00")]
	public void SetRollover(bool active)
	{
	}

	[Token(Token = "0x600ADB5")]
	[Address(RVA = "0x44EFE0", Offset = "0x44E1E0", VA = "0x18044EFE0")]
	public void SetTiling(float tiling)
	{
	}

	[Token(Token = "0x600ADB6")]
	[Address(RVA = "0x44F100", Offset = "0x44E300", VA = "0x18044F100")]
	public TargetingLine()
	{
	}
}
