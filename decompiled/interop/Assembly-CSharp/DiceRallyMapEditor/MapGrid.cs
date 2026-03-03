using Il2CppDummyDll;
using UnityEngine;

namespace DiceRallyMapEditor;

[Token(Token = "0x2000142")]
public class MapGrid : MonoBehaviour
{
	[Token(Token = "0x40007B9")]
	[FieldOffset(Offset = "0x20")]
	public int id;

	[Token(Token = "0x40007BA")]
	[FieldOffset(Offset = "0x24")]
	public int x;

	[Token(Token = "0x40007BB")]
	[FieldOffset(Offset = "0x28")]
	public int y;

	[Token(Token = "0x600081A")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public MapGrid()
	{
	}
}
