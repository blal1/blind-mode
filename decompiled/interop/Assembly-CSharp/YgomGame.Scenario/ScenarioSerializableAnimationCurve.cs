using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Serializable]
[Token(Token = "0x2000A91")]
public class ScenarioSerializableAnimationCurve : IScenarioSerializableValue, ISerializationCallbackReceiver
{
	[Token(Token = "0x40092D7")]
	[FieldOffset(Offset = "0x10")]
	private AnimationCurve m_AnimationCurve;

	[Token(Token = "0x40092D8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string[] k;

	[Token(Token = "0x170008A8")]
	public AnimationCurve animationCurve
	{
		[Token(Token = "0x60040F6")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170008A9")]
	public static AnimationCurve defaultCurve
	{
		[Token(Token = "0x60040F7")]
		[Address(RVA = "0x8900C0", Offset = "0x88F2C0", VA = "0x1808900C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040F8")]
	[Address(RVA = "0x88FCB0", Offset = "0x88EEB0", VA = "0x18088FCB0")]
	public static AnimationCurve Deserialize(object jsonVal)
	{
		return null;
	}

	[Token(Token = "0x60040F9")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public ScenarioSerializableAnimationCurve(AnimationCurve animationCurve)
	{
	}

	[Token(Token = "0x60040FA")]
	[Address(RVA = "0x88FD70", Offset = "0x88EF70", VA = "0x18088FD70", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60040FB")]
	[Address(RVA = "0x88FF20", Offset = "0x88F120", VA = "0x18088FF20", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}
}
