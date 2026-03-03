using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001875")]
public class CardSelectionListGroupLabel : MonoBehaviour
{
	[Token(Token = "0x400E5D0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color m_ColorMyself;

	[Token(Token = "0x400E5D1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Color m_ColorRIval;

	[Token(Token = "0x400E5D2")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Color m_ColorDefault;

	[Token(Token = "0x6009CA5")]
	[Address(RVA = "0xE9DBC0", Offset = "0xE9CDC0", VA = "0x180E9DBC0")]
	public void SetLabel(int player, CardSelectionList.CardLocateType locate)
	{
	}

	[Token(Token = "0x6009CA6")]
	[Address(RVA = "0xE9DDD0", Offset = "0xE9CFD0", VA = "0x180E9DDD0")]
	public void UpdatePosition(Vector2 position)
	{
	}

	[Token(Token = "0x6009CA7")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardSelectionListGroupLabel()
	{
	}
}
