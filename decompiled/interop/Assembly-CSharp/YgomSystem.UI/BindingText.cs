using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000521")]
[RequireComponent(typeof(Text))]
[AddComponentMenu("Ygom/UI/Binding/Binding Text")]
public class BindingText : BindingTextBase<BindingText, Text>
{
	[Token(Token = "0x6002147")]
	[Address(RVA = "0x634540", Offset = "0x633740", VA = "0x180634540", Slot = "8")]
	protected override string GetText(Text target)
	{
		return null;
	}

	[Token(Token = "0x6002148")]
	[Address(RVA = "0x634570", Offset = "0x633770", VA = "0x180634570", Slot = "7")]
	protected override void SetText(Text target, string text)
	{
	}

	[Token(Token = "0x6002149")]
	[Address(RVA = "0x6345C0", Offset = "0x6337C0", VA = "0x1806345C0")]
	public BindingText()
	{
	}
}
