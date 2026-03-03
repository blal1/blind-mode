using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000071")]
public class RadarChart : Graphic
{
	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0xA8")]
	private byte vertexNum;

	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0xAC")]
	private float maxLength;

	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0xB0")]
	private float deltaTheta;

	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0xB4")]
	private float yRate;

	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0xB8")]
	private float yOffset;

	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0xC0")]
	[HideInInspector]
	public float[] rates;

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x3F7D90", Offset = "0x3F6F90", VA = "0x1803F7D90")]
	public void Initialize(byte _vertexNum = 5)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x3F7FB0", Offset = "0x3F71B0", VA = "0x1803F7FB0", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x3F83D0", Offset = "0x3F75D0", VA = "0x1803F83D0")]
	public RadarChart()
	{
	}
}
