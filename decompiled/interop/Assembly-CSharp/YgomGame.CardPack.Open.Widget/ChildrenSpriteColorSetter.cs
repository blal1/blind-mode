using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.CardPack.Open.Widget;

[Token(Token = "0x2001551")]
[ExecuteInEditMode]
public class ChildrenSpriteColorSetter : MonoBehaviour
{
	[Token(Token = "0x400CC4E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color m_Color;

	[Token(Token = "0x400CC4F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool m_UpdateEveryFrame;

	[Token(Token = "0x400CC50")]
	[FieldOffset(Offset = "0x34")]
	private Color m_LastColor;

	[Token(Token = "0x400CC51")]
	[FieldOffset(Offset = "0x44")]
	private bool m_Dirty;

	[Token(Token = "0x400CC52")]
	[FieldOffset(Offset = "0x48")]
	private List<SpriteRenderer> m_Children;

	[Token(Token = "0x400CC53")]
	[FieldOffset(Offset = "0x50")]
	private int m_LastChildCount;

	[Token(Token = "0x17001417")]
	public Color color
	{
		[Token(Token = "0x60083C3")]
		[Address(RVA = "0xA49A40", Offset = "0xA48C40", VA = "0x180A49A40")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x60083C4")]
		[Address(RVA = "0xCBD780", Offset = "0xCBC980", VA = "0x180CBD780")]
		set
		{
		}
	}

	[Token(Token = "0x60083C5")]
	[Address(RVA = "0xCBD370", Offset = "0xCBC570", VA = "0x180CBD370")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60083C6")]
	[Address(RVA = "0xCBD5B0", Offset = "0xCBC7B0", VA = "0x180CBD5B0")]
	[ContextMenu("UpdateLayoutColor")]
	public void UpdateColor()
	{
	}

	[Token(Token = "0x60083C7")]
	[Address(RVA = "0xCBD440", Offset = "0xCBC640", VA = "0x180CBD440")]
	private void UpdateChildren()
	{
	}

	[Token(Token = "0x60083C8")]
	[Address(RVA = "0xCBD6F0", Offset = "0xCBC8F0", VA = "0x180CBD6F0")]
	public ChildrenSpriteColorSetter()
	{
	}
}
