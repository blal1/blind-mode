using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x20010E2")]
public class DropArea : MonoBehaviour
{
	[Token(Token = "0x400B259")]
	[FieldOffset(Offset = "0x20")]
	private UnityAction m_OnDropAction;

	[Token(Token = "0x400B25A")]
	[FieldOffset(Offset = "0x28")]
	public string label;

	[Token(Token = "0x400B25B")]
	[FieldOffset(Offset = "0x30")]
	private RectSelectionItem item;

	[Token(Token = "0x400B25C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<string> LABEL;

	[Token(Token = "0x400B25D")]
	[FieldOffset(Offset = "0x38")]
	private bool isDeckList;

	[Token(Token = "0x400B25E")]
	[FieldOffset(Offset = "0x39")]
	private bool setup;

	[Token(Token = "0x60069F5")]
	[Address(RVA = "0xB0E3D0", Offset = "0xB0D5D0", VA = "0x180B0E3D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60069F6")]
	[Address(RVA = "0xB0E5C0", Offset = "0xB0D7C0", VA = "0x180B0E5C0")]
	private void Setup()
	{
	}

	[Token(Token = "0x60069F7")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void SetOnDropAction(UnityAction callback)
	{
	}

	[Token(Token = "0x60069F8")]
	[Address(RVA = "0xB0E480", Offset = "0xB0D680", VA = "0x180B0E480")]
	public void OnDropAction()
	{
	}

	[Token(Token = "0x60069F9")]
	[Address(RVA = "0xB0E4B0", Offset = "0xB0D6B0", VA = "0x180B0E4B0")]
	public void SetActiveDropArea(bool canDrop)
	{
	}

	[Token(Token = "0x60069FA")]
	[Address(RVA = "0xB0E430", Offset = "0xB0D630", VA = "0x180B0E430")]
	public bool IsContainsPoint(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x60069FB")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DropArea()
	{
	}
}
