using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Effect;

[Token(Token = "0x2000323")]
public static class ScreenEffectUtil
{
	[Token(Token = "0x400111E")]
	[FieldOffset(Offset = "0x0")]
	public static int layer3DOnUI;

	[Token(Token = "0x400111F")]
	[FieldOffset(Offset = "0x8")]
	private static Camera _defaultCamera3DOnUI;

	[Token(Token = "0x4001120")]
	[FieldOffset(Offset = "0x10")]
	public static int layer2DOnUI;

	[Token(Token = "0x4001121")]
	[FieldOffset(Offset = "0x18")]
	private static Camera _defaultCamera2DOnUI;

	[Token(Token = "0x4001122")]
	[FieldOffset(Offset = "0x20")]
	public static int layer3D;

	[Token(Token = "0x4001123")]
	[FieldOffset(Offset = "0x28")]
	private static Camera _defaultCamera3D;

	[Token(Token = "0x4001124")]
	[FieldOffset(Offset = "0x30")]
	public static int layer2D;

	[Token(Token = "0x4001125")]
	[FieldOffset(Offset = "0x38")]
	private static Camera _defaultCamera2D;

	[Token(Token = "0x170001F1")]
	public static Camera defaultCamera3DOnUI
	{
		[Token(Token = "0x6001392")]
		[Address(RVA = "0x413DE0", Offset = "0x412FE0", VA = "0x180413DE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001393")]
		[Address(RVA = "0x413FC0", Offset = "0x4131C0", VA = "0x180413FC0")]
		set
		{
		}
	}

	[Token(Token = "0x170001F2")]
	public static Camera defaultCamera2DOnUI
	{
		[Token(Token = "0x6001394")]
		[Address(RVA = "0x413CC0", Offset = "0x412EC0", VA = "0x180413CC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001395")]
		[Address(RVA = "0x413F00", Offset = "0x413100", VA = "0x180413F00")]
		set
		{
		}
	}

	[Token(Token = "0x170001F3")]
	public static Camera defaultCamera3D
	{
		[Token(Token = "0x6001396")]
		[Address(RVA = "0x413E70", Offset = "0x413070", VA = "0x180413E70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001397")]
		[Address(RVA = "0x414020", Offset = "0x413220", VA = "0x180414020")]
		set
		{
		}
	}

	[Token(Token = "0x170001F4")]
	public static Camera defaultCamera2D
	{
		[Token(Token = "0x6001398")]
		[Address(RVA = "0x413D50", Offset = "0x412F50", VA = "0x180413D50")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001399")]
		[Address(RVA = "0x413F60", Offset = "0x413160", VA = "0x180413F60")]
		set
		{
		}
	}
}
