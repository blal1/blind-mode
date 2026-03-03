using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x200044E")]
public class FreeTextFilter : MonoBehaviour
{
	[Token(Token = "0x4001509")]
	[FieldOffset(Offset = "0x20")]
	private FreeTextFilterCache m_FreeTextFilterCache;

	[Token(Token = "0x400150A")]
	[FieldOffset(Offset = "0x28")]
	private Text m_TargetText;

	[Token(Token = "0x400150B")]
	[FieldOffset(Offset = "0x30")]
	private TMP_Text m_TargetTMPText;

	[Token(Token = "0x400150C")]
	[FieldOffset(Offset = "0x38")]
	private string m_FreeText;

	[Token(Token = "0x400150D")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsFinishedCheck;

	[Token(Token = "0x1700028D")]
	public bool isFinishedCheck
	{
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001B8D")]
	[Address(RVA = "0x5E6590", Offset = "0x5E5790", VA = "0x1805E6590")]
	private void SetText(string text)
	{
	}

	[Token(Token = "0x6001B8E")]
	[Address(RVA = "0x5E63F0", Offset = "0x5E55F0", VA = "0x1805E63F0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001B8F")]
	[Address(RVA = "0x5E64B0", Offset = "0x5E56B0", VA = "0x1805E64B0")]
	public void SetFreeText(string freeText, string defaultText = "")
	{
	}

	[Token(Token = "0x6001B90")]
	[Address(RVA = "0x5E6470", Offset = "0x5E5670", VA = "0x1805E6470")]
	public void OnFilteredFreeText(string freeText, string filteredFreeText)
	{
	}

	[Token(Token = "0x6001B91")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FreeTextFilter()
	{
	}
}
