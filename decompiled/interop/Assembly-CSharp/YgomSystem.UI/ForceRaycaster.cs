using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x200052F")]
[AddComponentMenu("Ygom/UI/uGUI/Force Raycaster")]
public class ForceRaycaster : Graphic
{
	[Token(Token = "0x600219E")]
	[Address(RVA = "0x648FE0", Offset = "0x6481E0", VA = "0x180648FE0", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600219F")]
	[Address(RVA = "0x649000", Offset = "0x648200", VA = "0x180649000")]
	public ForceRaycaster()
	{
	}
}
