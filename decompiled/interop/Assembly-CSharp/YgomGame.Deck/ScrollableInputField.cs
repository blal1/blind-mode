using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x2001101")]
[RequireComponent(typeof(ExtendedInputField))]
public class ScrollableInputField : MonoBehaviour
{
	[Token(Token = "0x400B3C1")]
	[FieldOffset(Offset = "0x20")]
	public ExtendedInputField targetInputField;

	[Token(Token = "0x400B3C2")]
	[FieldOffset(Offset = "0x28")]
	public Text cardNameText;

	[Token(Token = "0x400B3C3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button _maskButton;

	[Token(Token = "0x400B3C4")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnFocus;

	[Token(Token = "0x6006AE5")]
	[Address(RVA = "0xB2E820", Offset = "0xB2DA20", VA = "0x180B2E820")]
	private void Start()
	{
	}

	[Token(Token = "0x6006AE6")]
	[Address(RVA = "0xB2E900", Offset = "0xB2DB00", VA = "0x180B2E900")]
	public ScrollableInputField()
	{
	}
}
