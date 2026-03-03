using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000525")]
[RequireComponent(typeof(TextMeshPro))]
[AddComponentMenu("Ygom/UI/Binding/Binding TextMeshPro")]
public class BindingTextMeshPro : BindingTextBase<BindingTextMeshPro, TextMeshPro>
{
	[Token(Token = "0x600216F")]
	[Address(RVA = "0x6343D0", Offset = "0x6335D0", VA = "0x1806343D0", Slot = "8")]
	protected override string GetText(TextMeshPro target)
	{
		return null;
	}

	[Token(Token = "0x6002170")]
	[Address(RVA = "0x6344C0", Offset = "0x6336C0", VA = "0x1806344C0", Slot = "7")]
	protected override void SetText(TextMeshPro target, string text)
	{
	}

	[Token(Token = "0x6002171")]
	[Address(RVA = "0x634500", Offset = "0x633700", VA = "0x180634500")]
	public BindingTextMeshPro()
	{
	}
}
