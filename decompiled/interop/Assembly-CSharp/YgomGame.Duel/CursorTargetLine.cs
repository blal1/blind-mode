using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x20019F5")]
public class CursorTargetLine : MonoBehaviour
{
	[Token(Token = "0x400EFD3")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 point1;

	[Token(Token = "0x400EFD4")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 point2;

	[Token(Token = "0x400EFD5")]
	[FieldOffset(Offset = "0x38")]
	private int middlePoints;

	[Token(Token = "0x400EFD6")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 controlPoint;

	[Token(Token = "0x400EFD7")]
	[FieldOffset(Offset = "0x48")]
	private LineRenderer render;

	[Token(Token = "0x400EFD8")]
	[FieldOffset(Offset = "0x50")]
	private bool isActive;

	[Token(Token = "0x600A7BC")]
	[Address(RVA = "0xF3BED0", Offset = "0xF3B0D0", VA = "0x180F3BED0")]
	public static CursorTargetLine Create()
	{
		return null;
	}

	[Token(Token = "0x600A7BD")]
	[Address(RVA = "0xF3C270", Offset = "0xF3B470", VA = "0x180F3C270")]
	private void Start()
	{
	}

	[Token(Token = "0x600A7BE")]
	[Address(RVA = "0xF3C2E0", Offset = "0xF3B4E0", VA = "0x180F3C2E0")]
	private void Update()
	{
	}

	[Token(Token = "0x600A7BF")]
	[Address(RVA = "0xF3C000", Offset = "0xF3B200", VA = "0x180F3C000")]
	private void LineRendererUpdate()
	{
	}

	[Token(Token = "0x600A7C0")]
	[Address(RVA = "0xF3C210", Offset = "0xF3B410", VA = "0x180F3C210")]
	public void SetBase(Vector3 pos1)
	{
	}

	[Token(Token = "0x600A7C1")]
	[Address(RVA = "0xF3C220", Offset = "0xF3B420", VA = "0x180F3C220")]
	public void SetMoving(Vector3 pos2)
	{
	}

	[Token(Token = "0x600A7C2")]
	[Address(RVA = "0xF3C230", Offset = "0xF3B430", VA = "0x180F3C230")]
	public void ShowLine()
	{
	}

	[Token(Token = "0x600A7C3")]
	[Address(RVA = "0xF3BFC0", Offset = "0xF3B1C0", VA = "0x180F3BFC0")]
	public void HideLine()
	{
	}

	[Token(Token = "0x600A7C4")]
	[Address(RVA = "0xF3C2F0", Offset = "0xF3B4F0", VA = "0x180F3C2F0")]
	public CursorTargetLine()
	{
	}
}
