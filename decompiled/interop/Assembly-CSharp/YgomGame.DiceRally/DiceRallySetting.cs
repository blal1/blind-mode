using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000F97")]
[CreateAssetMenu(menuName = "Scriptable Object/DiceRallySetting")]
public class DiceRallySetting : ScriptableObject
{
	[Token(Token = "0x400A925")]
	[FieldOffset(Offset = "0x18")]
	public int distanceSpace;

	[Token(Token = "0x400A926")]
	[FieldOffset(Offset = "0x1C")]
	public int distanceEdge;

	[Token(Token = "0x400A927")]
	[FieldOffset(Offset = "0x20")]
	public float zoomRatioSmall;

	[Token(Token = "0x400A928")]
	[FieldOffset(Offset = "0x24")]
	public float zoomRatioMedium;

	[Token(Token = "0x400A929")]
	[FieldOffset(Offset = "0x28")]
	public float zoomRatioLarge;

	[Token(Token = "0x400A92A")]
	[FieldOffset(Offset = "0x2C")]
	public float miniMapRatio;

	[Token(Token = "0x400A92B")]
	[FieldOffset(Offset = "0x30")]
	public float analogSpeed;

	[Token(Token = "0x400A92C")]
	[FieldOffset(Offset = "0x34")]
	public float wheelSpeed;

	[Token(Token = "0x400A92D")]
	[FieldOffset(Offset = "0x38")]
	public float popIconRatioSmall;

	[Token(Token = "0x400A92E")]
	[FieldOffset(Offset = "0x3C")]
	public float popIconRatioMedium;

	[Token(Token = "0x400A92F")]
	[FieldOffset(Offset = "0x40")]
	public float popIconRatioLarge;

	[Token(Token = "0x400A930")]
	[FieldOffset(Offset = "0x44")]
	public float diceRatio;

	[Token(Token = "0x400A931")]
	[FieldOffset(Offset = "0x48")]
	public float mapCreateTime;

	[Token(Token = "0x400A932")]
	[FieldOffset(Offset = "0x4C")]
	public float startFocusTime;

	[Token(Token = "0x400A933")]
	[FieldOffset(Offset = "0x50")]
	public float mapAngle;

	[Token(Token = "0x400A934")]
	[FieldOffset(Offset = "0x54")]
	public Vector3 playerIconRelativePosition;

	[Token(Token = "0x400A935")]
	[FieldOffset(Offset = "0x60")]
	public Color bgColorLap1;

	[Token(Token = "0x400A936")]
	[FieldOffset(Offset = "0x70")]
	public Color bgColorLap2;

	[Token(Token = "0x400A937")]
	[FieldOffset(Offset = "0x80")]
	public Color bgColorLap3;

	[Token(Token = "0x400A938")]
	[FieldOffset(Offset = "0x90")]
	public Color bgColorLap4;

	[Token(Token = "0x6005EA5")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public DiceRallySetting()
	{
	}
}
