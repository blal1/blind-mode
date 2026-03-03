using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x20004F6")]
[AddComponentMenu("Ygom/UI/Tween/Tween Set")]
public class TweenSet : Tween
{
	[Token(Token = "0x20004F7")]
	[Flags]
	public enum Target
	{
		[Token(Token = "0x4001878")]
		position = 1,
		[Token(Token = "0x4001879")]
		scale = 2,
		[Token(Token = "0x400187A")]
		rotation = 4,
		[Token(Token = "0x400187B")]
		color = 8,
		[Token(Token = "0x400187C")]
		gameObject = 0x10
	}

	[Serializable]
	[Token(Token = "0x20004F8")]
	public class Param
	{
		[Token(Token = "0x400187D")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x400187E")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 scale;

		[Token(Token = "0x400187F")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion rotation;

		[Token(Token = "0x4001880")]
		[FieldOffset(Offset = "0x38")]
		public Color color;

		[Token(Token = "0x4001881")]
		[FieldOffset(Offset = "0x48")]
		public GameObject gameObject;

		[Token(Token = "0x60020AD")]
		[Address(RVA = "0x636D80", Offset = "0x635F80", VA = "0x180636D80")]
		public Param()
		{
		}
	}

	[Token(Token = "0x400186F")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public Param from;

	[Token(Token = "0x4001870")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	public Param to;

	[Token(Token = "0x4001871")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	[EnumFlags]
	public Target target;

	[Token(Token = "0x4001872")]
	[FieldOffset(Offset = "0x84")]
	private Color fromColor;

	[Token(Token = "0x4001873")]
	[FieldOffset(Offset = "0x98")]
	private RectTransform rtrans;

	[Token(Token = "0x4001874")]
	[FieldOffset(Offset = "0xA0")]
	private Graphic graphic;

	[Token(Token = "0x4001875")]
	[FieldOffset(Offset = "0xA8")]
	private int crntParam;

	[Token(Token = "0x4001876")]
	[FieldOffset(Offset = "0xB0")]
	private List<KeyValuePair<Graphic, Color>> childGraps;

	[Token(Token = "0x60020A9")]
	[Address(RVA = "0x63F9D0", Offset = "0x63EBD0", VA = "0x18063F9D0")]
	private void ScanChildGraphic(GameObject obj)
	{
	}

	[Token(Token = "0x60020AA")]
	[Address(RVA = "0x63EE00", Offset = "0x63E000", VA = "0x18063EE00", Slot = "5")]
	protected override void CaptureFrom()
	{
	}

	[Token(Token = "0x60020AB")]
	[Address(RVA = "0x63EFB0", Offset = "0x63E1B0", VA = "0x18063EFB0", Slot = "6")]
	protected override void OnSetValue(float par)
	{
	}

	[Token(Token = "0x60020AC")]
	[Address(RVA = "0x63FBC0", Offset = "0x63EDC0", VA = "0x18063FBC0")]
	public TweenSet()
	{
	}
}
