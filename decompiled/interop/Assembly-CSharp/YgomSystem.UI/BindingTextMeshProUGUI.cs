using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000526")]
[RequireComponent(typeof(TextMeshProUGUI))]
[AddComponentMenu("Ygom/UI/Binding/Binding TextMeshProUGUI")]
public class BindingTextMeshProUGUI : BindingTextBase<BindingTextMeshProUGUI, TextMeshProUGUI>
{
	[Token(Token = "0x6002172")]
	[Address(RVA = "0x6343D0", Offset = "0x6335D0", VA = "0x1806343D0", Slot = "8")]
	protected override string GetText(TextMeshProUGUI target)
	{
		return null;
	}

	[Token(Token = "0x6002173")]
	[Address(RVA = "0x6344C0", Offset = "0x6336C0", VA = "0x1806344C0", Slot = "7")]
	protected override void SetText(TextMeshProUGUI target, string text)
	{
	}

	[Token(Token = "0x6002174")]
	[Address(RVA = "0x634480", Offset = "0x633680", VA = "0x180634480")]
	public BindingTextMeshProUGUI()
	{
	}
}
