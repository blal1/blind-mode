using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x200194B")]
[CreateAssetMenu(fileName = "BezierMotionSetting", menuName = "Scriptable Object/BezierMotionSetting")]
public class BezierMotionSetting : ScriptableObject
{
	[Token(Token = "0x200194C")]
	public enum InterporationType
	{
		[Token(Token = "0x400EBAC")]
		Bezier3Point,
		[Token(Token = "0x400EBAD")]
		Lerp2Point
	}

	[Serializable]
	[Token(Token = "0x200194D")]
	public class PositionOperation
	{
		[Token(Token = "0x400EBAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BasePositionSetting basePosition;

		[Token(Token = "0x400EBAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<OffsetSetting> offsetList;

		[Token(Token = "0x400EBB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<OverrideSetting> overrideList;

		[Token(Token = "0x600A2EC")]
		[Address(RVA = "0xEF8080", Offset = "0xEF7280", VA = "0x180EF8080")]
		public Vector3 Get(Vector3 origin_position, Vector3 target_position, [Optional] Camera camera)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600A2ED")]
		[Address(RVA = "0xEF7C00", Offset = "0xEF6E00", VA = "0x180EF7C00")]
		public PositionOperation Clone()
		{
			return null;
		}

		[Token(Token = "0x600A2EE")]
		[Address(RVA = "0xEF89A0", Offset = "0xEF7BA0", VA = "0x180EF89A0")]
		public PositionOperation()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200194E")]
	public class BasePositionSetting
	{
		[Token(Token = "0x400EBB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BaseVectorValueType type;

		[Token(Token = "0x400EBB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 designation;

		[Token(Token = "0x600A2EF")]
		[Address(RVA = "0xEFF310", Offset = "0xEFE510", VA = "0x180EFF310")]
		public BasePositionSetting Clone()
		{
			return null;
		}

		[Token(Token = "0x600A2F0")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public BasePositionSetting()
		{
		}
	}

	[Token(Token = "0x200194F")]
	public enum BaseVectorValueType
	{
		[Token(Token = "0x400EBB4")]
		OriginPosition,
		[Token(Token = "0x400EBB5")]
		TargetPosition,
		[Token(Token = "0x400EBB6")]
		Screen,
		[Token(Token = "0x400EBB7")]
		Designation
	}

	[Serializable]
	[Token(Token = "0x2001950")]
	public class OffsetSetting
	{
		[Token(Token = "0x400EBB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OffsetVectorValueType type;

		[Token(Token = "0x400EBB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 designation;

		[Token(Token = "0x400EBBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 rotationCorrection;

		[Token(Token = "0x400EBBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public OffsetIntensityType intensityType;

		[Token(Token = "0x400EBBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float intensity;

		[Token(Token = "0x600A2F1")]
		[Address(RVA = "0xF15440", Offset = "0xF14640", VA = "0x180F15440")]
		public OffsetSetting()
		{
		}

		[Token(Token = "0x600A2F2")]
		[Address(RVA = "0xF153C0", Offset = "0xF145C0", VA = "0x180F153C0")]
		public OffsetSetting Clone()
		{
			return null;
		}
	}

	[Token(Token = "0x2001951")]
	public enum OffsetVectorValueType
	{
		[Token(Token = "0x400EBBE")]
		NormalizedDeltaTargetOrigin,
		[Token(Token = "0x400EBBF")]
		Designation,
		[Token(Token = "0x400EBC0")]
		NormalizedDeltaTargetBase
	}

	[Token(Token = "0x2001952")]
	public enum OffsetIntensityType
	{
		[Token(Token = "0x400EBC2")]
		StartToTarget01,
		[Token(Token = "0x400EBC3")]
		Designation
	}

	[Serializable]
	[Token(Token = "0x2001953")]
	public class OverrideSetting
	{
		[Token(Token = "0x400EBC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OverrideType type;

		[Token(Token = "0x400EBC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public OverrideDirection directionFlag;

		[Token(Token = "0x400EBC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 designation;

		[Token(Token = "0x600A2F3")]
		[Address(RVA = "0xF154F0", Offset = "0xF146F0", VA = "0x180F154F0")]
		public OverrideSetting()
		{
		}

		[Token(Token = "0x600A2F4")]
		[Address(RVA = "0xF15470", Offset = "0xF14670", VA = "0x180F15470")]
		public OverrideSetting Clone()
		{
			return null;
		}
	}

	[Token(Token = "0x2001954")]
	public enum OverrideType
	{
		[Token(Token = "0x400EBC8")]
		OriginPosition,
		[Token(Token = "0x400EBC9")]
		TargetPosition,
		[Token(Token = "0x400EBCA")]
		Screen,
		[Token(Token = "0x400EBCB")]
		Designation
	}

	[Token(Token = "0x2001955")]
	public enum OverrideDirection
	{
		[Token(Token = "0x400EBCD")]
		X = 1,
		[Token(Token = "0x400EBCE")]
		Y = 2,
		[Token(Token = "0x400EBCF")]
		Z = 4
	}

	[Serializable]
	[Token(Token = "0x2001956")]
	public class LookElement
	{
		[Token(Token = "0x400EBD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LookElementType type;

		[Token(Token = "0x400EBD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public LookType fromType;

		[Token(Token = "0x400EBD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 fromDesignationPosition;

		[Token(Token = "0x400EBD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public LookType toType;

		[Token(Token = "0x400EBD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 toDesignationPosition;

		[Token(Token = "0x400EBD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 rotationAngle;

		[Token(Token = "0x600A2F5")]
		[Address(RVA = "0xF149B0", Offset = "0xF13BB0", VA = "0x180F149B0")]
		public LookElement Clone()
		{
			return null;
		}

		[Token(Token = "0x600A2F6")]
		[Address(RVA = "0xF14A30", Offset = "0xF13C30", VA = "0x180F14A30")]
		public Quaternion Get(Vector3 origin_position, Quaternion origin_rotation, Vector3 target_position, Quaternion target_rotation, Vector3 start_position, Vector3 via_position, Vector3 end_position, [Optional] Camera camera)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600A2F7")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public LookElement()
		{
		}
	}

	[Token(Token = "0x2001957")]
	public enum LookSettingType
	{
		[Token(Token = "0x400EBD7")]
		Single,
		[Token(Token = "0x400EBD8")]
		Lerp2,
		[Token(Token = "0x400EBD9")]
		Bezier3
	}

	[Token(Token = "0x2001958")]
	public enum LookElementType
	{
		[Token(Token = "0x400EBDB")]
		OriginRotation,
		[Token(Token = "0x400EBDC")]
		TargetRotation,
		[Token(Token = "0x400EBDD")]
		CameraRotation,
		[Token(Token = "0x400EBDE")]
		PositionDelta
	}

	[Token(Token = "0x2001959")]
	public enum LookType
	{
		[Token(Token = "0x400EBE0")]
		OriginPosition,
		[Token(Token = "0x400EBE1")]
		TargetPosition,
		[Token(Token = "0x400EBE2")]
		StartPosition,
		[Token(Token = "0x400EBE3")]
		ViaPosition,
		[Token(Token = "0x400EBE4")]
		EndPosition,
		[Token(Token = "0x400EBE5")]
		CameraPosition,
		[Token(Token = "0x400EBE6")]
		DesignationPosition
	}

	[Token(Token = "0x400EB9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InterporationType type;

	[Token(Token = "0x400EB9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PositionOperation startPositionOperation;

	[Token(Token = "0x400EB9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PositionOperation viaPositionOperation;

	[Token(Token = "0x400EBA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PositionOperation endPositionOperation;

	[Token(Token = "0x400EBA1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve accelerationCurve;

	[Token(Token = "0x400EBA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LookSettingType lookSetting;

	[Token(Token = "0x400EBA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LookElement lookElement1;

	[Token(Token = "0x400EBA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public LookElement lookElement2;

	[Token(Token = "0x400EBA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LookElement lookElement3;

	[Token(Token = "0x400EBA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AnimationCurve rotationAccelerationCurve;

	[Token(Token = "0x400EBA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int aditionalTurnNum;

	[Token(Token = "0x400EBA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 aditionalTurnDirection;

	[Token(Token = "0x400EBA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AnimationCurve aditionalTurnAccelerationCurve;

	[Token(Token = "0x400EBAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float animationTime;

	[Token(Token = "0x600A2E3")]
	[Address(RVA = "0xEEBEE0", Offset = "0xEEB0E0", VA = "0x180EEBEE0")]
	public BezierMotionSetting()
	{
	}

	[Token(Token = "0x600A2E4")]
	[Address(RVA = "0xEEB690", Offset = "0xEEA890", VA = "0x180EEB690")]
	public Vector3 GetStartPosition(Vector3 origin_position, Vector3 target_position, [Optional] Camera camera)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A2E5")]
	[Address(RVA = "0xEEB710", Offset = "0xEEA910", VA = "0x180EEB710")]
	public Vector3 GetViaPosition(Vector3 origin_position, Vector3 target_position, [Optional] Camera camera)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A2E6")]
	[Address(RVA = "0xEEAF70", Offset = "0xEEA170", VA = "0x180EEAF70")]
	public Vector3 GetEndPosition(Vector3 origin_position, Vector3 target_position, [Optional] Camera camera)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600A2E7")]
	[Address(RVA = "0xEEB790", Offset = "0xEEA990", VA = "0x180EEB790")]
	public (Vector3, Quaternion) Get(Vector3 origin_position, Quaternion origin_rotation, Vector3 target_position, Quaternion target_rotation, float current_time, [Optional] Camera camera)
	{
		return default((Vector3, Quaternion));
	}

	[Token(Token = "0x600A2E8")]
	[Address(RVA = "0xEEAFF0", Offset = "0xEEA1F0", VA = "0x180EEAFF0")]
	private Quaternion GetRotation(Vector3 origin_position, Quaternion origin_rotation, Vector3 target_position, Quaternion target_rotation, Vector3 start_position, Vector3 via_position, Vector3 end_position, float current_time, [Optional] Camera camera)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600A2E9")]
	[Address(RVA = "0xEEAD30", Offset = "0xEE9F30", VA = "0x180EEAD30")]
	private Quaternion GetAditionalTurn(float current_time)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600A2EA")]
	[Address(RVA = "0xEEAEA0", Offset = "0xEEA0A0", VA = "0x180EEAEA0")]
	public (Vector3, Quaternion) GetByClampedTime(Vector3 origin_position, Quaternion origin_rotation, Vector3 target_position, Quaternion target_rotation, float clamped_time, [Optional] Camera camera)
	{
		return default((Vector3, Quaternion));
	}

	[Token(Token = "0x600A2EB")]
	[Address(RVA = "0xEEAAE0", Offset = "0xEE9CE0", VA = "0x180EEAAE0")]
	public BezierMotionSetting Clone()
	{
		return null;
	}
}
