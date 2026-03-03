using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019ED")]
public class ChainedBezierMotion
{
	[Token(Token = "0x400EF91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<BezierMotionSetting> motionList;

	[Token(Token = "0x400EF92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentMotionIndex;

	[Token(Token = "0x400EF93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private Vector3 currentOriginPosition;

	[Token(Token = "0x400EF94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Quaternion currentOriginRotation;

	[Token(Token = "0x400EF95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 originPosition;

	[Token(Token = "0x400EF96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Quaternion originRotation;

	[Token(Token = "0x400EF97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 targetPosition;

	[Token(Token = "0x400EF98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Quaternion targetRotation;

	[Token(Token = "0x170019C6")]
	public int motionNum
	{
		[Token(Token = "0x600A765")]
		[Address(RVA = "0xF37A10", Offset = "0xF36C10", VA = "0x180F37A10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019C7")]
	public float totalAnimationTime
	{
		[Token(Token = "0x600A766")]
		[Address(RVA = "0xF37A50", Offset = "0xF36C50", VA = "0x180F37A50")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600A754")]
	[Address(RVA = "0xF37350", Offset = "0xF36550", VA = "0x180F37350")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600A755")]
	[Address(RVA = "0xF37510", Offset = "0xF36710", VA = "0x180F37510")]
	public void Initialize(BezierMotionSetting[] motionList)
	{
	}

	[Token(Token = "0x600A756")]
	[Address(RVA = "0xF373B0", Offset = "0xF365B0", VA = "0x180F373B0")]
	public void Initialize(List<BezierMotionSetting> motionList)
	{
	}

	[Token(Token = "0x600A757")]
	[Address(RVA = "0xF365A0", Offset = "0xF357A0", VA = "0x180F365A0")]
	public void AddMotion(BezierMotionSetting motion)
	{
	}

	[Token(Token = "0x600A758")]
	[Address(RVA = "0xF364A0", Offset = "0xF356A0", VA = "0x180F364A0")]
	public void AddMotion(BezierMotionSetting[] motion)
	{
	}

	[Token(Token = "0x600A759")]
	[Address(RVA = "0xF36650", Offset = "0xF35850", VA = "0x180F36650")]
	public void Begin(Vector3 originPosition, Quaternion originRotation, Vector3 targetPosition, Quaternion targetRotation)
	{
	}

	[Token(Token = "0x600A75A")]
	[Address(RVA = "0xF37640", Offset = "0xF36840", VA = "0x180F37640")]
	public void SetOrigin(Vector3 originPosition, Quaternion originRotation)
	{
	}

	[Token(Token = "0x600A75B")]
	[Address(RVA = "0xF37660", Offset = "0xF36860", VA = "0x180F37660")]
	public void SetTarget(Vector3 targetPosition, Quaternion targetRotation)
	{
	}

	[Token(Token = "0x600A75C")]
	[Address(RVA = "0xF376F0", Offset = "0xF368F0", VA = "0x180F376F0")]
	public (Vector3, Quaternion) Update(float time)
	{
		return default((Vector3, Quaternion));
	}

	[Token(Token = "0x600A75D")]
	[Address(RVA = "0xF37680", Offset = "0xF36880", VA = "0x180F37680")]
	public (Vector3, Quaternion) UpdateByClampedTime(float clampedTime)
	{
		return default((Vector3, Quaternion));
	}

	[Token(Token = "0x600A75E")]
	[Address(RVA = "0xF370D0", Offset = "0xF362D0", VA = "0x180F370D0")]
	public (Vector3, Quaternion) Get(float time, [Optional] Camera camera)
	{
		return default((Vector3, Quaternion));
	}

	[Token(Token = "0x600A75F")]
	[Address(RVA = "0xF36860", Offset = "0xF35A60", VA = "0x180F36860")]
	public (Vector3, Quaternion) GetByClampedTime(float clampedTime, [Optional] Camera camera)
	{
		return default((Vector3, Quaternion));
	}

	[Token(Token = "0x600A760")]
	[Address(RVA = "0xF36D70", Offset = "0xF35F70", VA = "0x180F36D70")]
	public Vector3 GetStartPosition(int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A761")]
	[Address(RVA = "0xF36C80", Offset = "0xF35E80", VA = "0x180F36C80")]
	public Vector3 GetStartPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A762")]
	[Address(RVA = "0xF36AD0", Offset = "0xF35CD0", VA = "0x180F36AD0")]
	public Vector3 GetEndPosition(int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A763")]
	[Address(RVA = "0xF368E0", Offset = "0xF35AE0", VA = "0x180F368E0")]
	public Vector3 GetEndPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A764")]
	[Address(RVA = "0xF36F20", Offset = "0xF36120", VA = "0x180F36F20")]
	public Vector3 GetViaPosition(int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A767")]
	[Address(RVA = "0xF366A0", Offset = "0xF358A0", VA = "0x180F366A0")]
	public (int, float) GetBezierMotionInfo(float time)
	{
		return default((int, float));
	}

	[Token(Token = "0x600A768")]
	[Address(RVA = "0xF37990", Offset = "0xF36B90", VA = "0x180F37990")]
	public ChainedBezierMotion()
	{
	}
}
