using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000501")]
[AddComponentMenu("Ygom/UI/Tween/Tween Stretch To")]
[RequireComponent(typeof(RectTransform))]
public class TweenStretchTo : Tween
{
	[Serializable]
	[Token(Token = "0x2000502")]
	public struct StretchOffset
	{
		[Token(Token = "0x40018B1")]
		[FieldOffset(Offset = "0x0")]
		public float left;

		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x4")]
		public float right;

		[Token(Token = "0x40018B3")]
		[FieldOffset(Offset = "0x8")]
		public float top;

		[Token(Token = "0x40018B4")]
		[FieldOffset(Offset = "0xC")]
		public float bottom;

		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
		public static StretchOffset operator +(StretchOffset a, StretchOffset b)
		{
			return default(StretchOffset);
		}

		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x638140", Offset = "0x637340", VA = "0x180638140")]
		public static StretchOffset operator *(StretchOffset a, StretchOffset b)
		{
			return default(StretchOffset);
		}

		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x638100", Offset = "0x637300", VA = "0x180638100")]
		public static StretchOffset operator *(StretchOffset a, float b)
		{
			return default(StretchOffset);
		}

		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x638190", Offset = "0x637390", VA = "0x180638190")]
		public static StretchOffset operator -(StretchOffset a, StretchOffset b)
		{
			return default(StretchOffset);
		}
	}

	[Token(Token = "0x40018AD")]
	[FieldOffset(Offset = "0x70")]
	protected StretchOffset m_From;

	[Token(Token = "0x40018AE")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	public StretchOffset to;

	[Token(Token = "0x40018AF")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	public bool ResetFromOnEnable;

	[Token(Token = "0x40018B0")]
	[FieldOffset(Offset = "0x98")]
	private RectTransform m_RectTransform_Field;

	[Token(Token = "0x17000355")]
	protected RectTransform m_RectTransform
	{
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x6425A0", Offset = "0x6417A0", VA = "0x1806425A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60020CE")]
	[Address(RVA = "0x6423D0", Offset = "0x6415D0", VA = "0x1806423D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60020CF")]
	[Address(RVA = "0x6422F0", Offset = "0x6414F0", VA = "0x1806422F0", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020D0")]
	[Address(RVA = "0x6423F0", Offset = "0x6415F0", VA = "0x1806423F0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020D1")]
	[Address(RVA = "0x642550", Offset = "0x641750", VA = "0x180642550")]
	public TweenStretchTo()
	{
	}
}
