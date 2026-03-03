using Il2CppDummyDll;
using UnityEngine;

namespace DiceRallyMapEditor;

[Token(Token = "0x2000150")]
public class SelectionArea : MonoBehaviour
{
	[Token(Token = "0x4000819")]
	[FieldOffset(Offset = "0x20")]
	private MaptipWidgetManager manager;

	[Token(Token = "0x400081A")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 start;

	[Token(Token = "0x400081B")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 end;

	[Token(Token = "0x6000872")]
	[Address(RVA = "0xB04420", Offset = "0xB03620", VA = "0x180B04420")]
	private void Start()
	{
	}

	[Token(Token = "0x6000873")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void Initialize(MaptipWidgetManager manager)
	{
	}

	[Token(Token = "0x6000874")]
	[Address(RVA = "0xB03F30", Offset = "0xB03130", VA = "0x180B03F30")]
	public void OnClicked()
	{
	}

	[Token(Token = "0x6000875")]
	[Address(RVA = "0xB03F50", Offset = "0xB03150", VA = "0x180B03F50")]
	public void OnDragBegin(Vector2 pos)
	{
	}

	[Token(Token = "0x6000876")]
	[Address(RVA = "0xB041B0", Offset = "0xB033B0", VA = "0x180B041B0")]
	public void OnDraging(Vector2 pos)
	{
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0xB040F0", Offset = "0xB032F0", VA = "0x180B040F0")]
	public void OnDragEnd(Vector2 pos)
	{
	}

	[Token(Token = "0x6000878")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SelectionArea()
	{
	}
}
