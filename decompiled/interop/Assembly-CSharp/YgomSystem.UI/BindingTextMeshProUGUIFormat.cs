using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000527")]
[RequireComponent(typeof(TextMeshProUGUI))]
[AddComponentMenu("Ygom/UI/Binding/Binding TextMeshProUGUIFormat")]
public class BindingTextMeshProUGUIFormat : BindingTextMeshProUGUI
{
	[Token(Token = "0x400192A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string[] m_Args;

	[Token(Token = "0x1700036B")]
	public string[] args
	{
		[Token(Token = "0x6002175")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002176")]
	[Address(RVA = "0x6343D0", Offset = "0x6335D0", VA = "0x1806343D0", Slot = "8")]
	protected override string GetText(TextMeshProUGUI target)
	{
		return null;
	}

	[Token(Token = "0x6002177")]
	[Address(RVA = "0x634400", Offset = "0x633600", VA = "0x180634400", Slot = "7")]
	protected override void SetText(TextMeshProUGUI target, string text)
	{
	}

	[Token(Token = "0x6002178")]
	[Address(RVA = "0x634480", Offset = "0x633680", VA = "0x180634480")]
	public BindingTextMeshProUGUIFormat()
	{
	}
}
