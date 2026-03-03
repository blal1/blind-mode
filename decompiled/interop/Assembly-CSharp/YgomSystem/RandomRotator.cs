using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x20001DB")]
public class RandomRotator : MonoBehaviour
{
	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector3 axis;

	[Token(Token = "0x4000A33")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float angleMin;

	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float angleMax;

	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool playOnStart;

	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x45")]
	[SerializeField]
	private bool playOnEnabled;

	[Token(Token = "0x17000128")]
	public Quaternion rotation
	{
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0xC11AD0", Offset = "0xC10CD0", VA = "0x180C11AD0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0xC11AE0", Offset = "0xC10CE0", VA = "0x180C11AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000B12")]
	[Address(RVA = "0xC11A60", Offset = "0xC10C60", VA = "0x180C11A60")]
	public void Start()
	{
	}

	[Token(Token = "0x6000B13")]
	[Address(RVA = "0xC11A50", Offset = "0xC10C50", VA = "0x180C11A50")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000B14")]
	[Address(RVA = "0xC119D0", Offset = "0xC10BD0", VA = "0x180C119D0")]
	public void Apply()
	{
	}

	[Token(Token = "0x6000B15")]
	[Address(RVA = "0xC11A70", Offset = "0xC10C70", VA = "0x180C11A70")]
	public RandomRotator()
	{
	}
}
