using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.CardPack.Open.Widget;

[Token(Token = "0x2001552")]
[ExecuteInEditMode]
public class FromToObjMover : MonoBehaviour
{
	[Token(Token = "0x400CC54")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_From;

	[Token(Token = "0x400CC55")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_To;

	[Token(Token = "0x400CC56")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_Normal;

	[Token(Token = "0x400CC57")]
	[FieldOffset(Offset = "0x34")]
	private float m_LastNormal;

	[Token(Token = "0x17001418")]
	public float normal
	{
		[Token(Token = "0x60083C9")]
		[Address(RVA = "0x649990", Offset = "0x648B90", VA = "0x180649990")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60083CA")]
		[Address(RVA = "0xCBF1B0", Offset = "0xCBE3B0", VA = "0x180CBF1B0")]
		set
		{
		}
	}

	[Token(Token = "0x60083CB")]
	[Address(RVA = "0xCBF190", Offset = "0xCBE390", VA = "0x180CBF190")]
	private void Update()
	{
	}

	[Token(Token = "0x60083CC")]
	[Address(RVA = "0xCBF060", Offset = "0xCBE260", VA = "0x180CBF060")]
	[ContextMenu("UpdateLayout")]
	public void UpdateLocation()
	{
	}

	[Token(Token = "0x60083CD")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FromToObjMover()
	{
	}
}
