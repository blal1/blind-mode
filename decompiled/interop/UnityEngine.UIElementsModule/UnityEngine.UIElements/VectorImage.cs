using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x20004D7")]
public sealed class VectorImage : ScriptableObject
{
	[Token(Token = "0x4000FD9")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	internal int version;

	[Token(Token = "0x4000FDA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	internal Texture2D atlas;

	[Token(Token = "0x4000FDB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal VectorImageVertex[] vertices;

	[Token(Token = "0x4000FDC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	internal ushort[] indices;

	[Token(Token = "0x4000FDD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	internal GradientSettings[] settings;

	[Token(Token = "0x4000FDE")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	internal Vector2 size;

	[Token(Token = "0x17000956")]
	public float width
	{
		[Token(Token = "0x6002360")]
		[Address(RVA = "0x8A9B10", Offset = "0x8A8D10", VA = "0x1808A9B10")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000957")]
	public float height
	{
		[Token(Token = "0x6002361")]
		[Address(RVA = "0x416670", Offset = "0x415870", VA = "0x180416670")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002362")]
	[Address(RVA = "0x2A3B8B0", Offset = "0x2A3AAB0", VA = "0x182A3B8B0")]
	public VectorImage()
	{
	}
}
