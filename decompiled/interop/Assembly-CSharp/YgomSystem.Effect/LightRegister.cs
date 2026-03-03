using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.Effect;

[Token(Token = "0x200031E")]
public class LightRegister : ComponentsRegisterBase<Light>
{
	[Token(Token = "0x4001108")]
	[FieldOffset(Offset = "0x28")]
	private int m_RegistedLayer;

	[Token(Token = "0x600136F")]
	[Address(RVA = "0x409210", Offset = "0x408410", VA = "0x180409210")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001370")]
	[Address(RVA = "0x4093C0", Offset = "0x4085C0", VA = "0x1804093C0")]
	public LightRegister()
	{
	}
}
