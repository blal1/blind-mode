using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Scenario;

[Serializable]
[Token(Token = "0x2000A90")]
public class SerializableKeyFrame : ISerializationCallbackReceiver
{
	[Token(Token = "0x40092D4")]
	[FieldOffset(Offset = "0x10")]
	private Keyframe m_KeyFrame;

	[Token(Token = "0x40092D5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float[] p;

	[Token(Token = "0x40092D6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private WeightedMode m;

	[Token(Token = "0x170008A7")]
	public Keyframe keyFrame
	{
		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x891460", Offset = "0x890660", VA = "0x180891460")]
		get
		{
			return default(Keyframe);
		}
	}

	[Token(Token = "0x60040F3")]
	[Address(RVA = "0x891420", Offset = "0x890620", VA = "0x180891420")]
	public SerializableKeyFrame(Keyframe keyFrame)
	{
	}

	[Token(Token = "0x60040F4")]
	[Address(RVA = "0x8911E0", Offset = "0x8903E0", VA = "0x1808911E0", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60040F5")]
	[Address(RVA = "0x891310", Offset = "0x890510", VA = "0x180891310", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}
}
