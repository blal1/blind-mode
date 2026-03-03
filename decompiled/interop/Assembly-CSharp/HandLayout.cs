using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000031")]
public class HandLayout : HorizontalLayoutGroup
{
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	public bool isReverse;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x74")]
	public float startPosY;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x78")]
	public float baseAngle;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x7C")]
	public float Angleoffset;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x80")]
	public float scaleZ;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x84")]
	public float flabellateRadiusPerScreen;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public float parentHeight;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x8C")]
	private int totalCount;

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x3DE1D0", Offset = "0x3DD3D0", VA = "0x1803DE1D0")]
	public void ApplyImmediate(float flexFlabellateRadiusPerScreen = 0f)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "38")]
	public override void SetLayoutVertical()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "29")]
	public override void CalculateLayoutInputVertical()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x3DE700", Offset = "0x3DD900", VA = "0x1803DE700", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x3DE1E0", Offset = "0x3DD3E0", VA = "0x1803DE1E0")]
	private void Apply(float flexFlabellateRadiusPerScreen = 0f)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x3DEBE0", Offset = "0x3DDDE0", VA = "0x1803DEBE0", Slot = "37")]
	public override void SetLayoutHorizontal()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x3DEB10", Offset = "0x3DDD10", VA = "0x1803DEB10")]
	private void ResetTrans(Transform transform, bool isLocal = false)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x3DE790", Offset = "0x3DD990", VA = "0x1803DE790")]
	private void GetPosture(RectTransform center, int index, int card_num, RectTransform child, float flexFlabellateRadiusPerScreen = 0f)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x3DE710", Offset = "0x3DD910", VA = "0x1803DE710")]
	protected float GetFlabellateAngle(int viewIndex, int handNum, bool origin, bool clamp180 = true)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x3DEBF0", Offset = "0x3DDDF0", VA = "0x1803DEBF0")]
	public HandLayout()
	{
	}
}
