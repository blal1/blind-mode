using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000ED2")]
public class DuelpassBulkRecieveButtonWidget
{
	[Token(Token = "0x400A4E4")]
	[FieldOffset(Offset = "0x10")]
	private SelectionButton button;

	[Token(Token = "0x400A4E5")]
	[FieldOffset(Offset = "0x18")]
	private GameObject numBadge;

	[Token(Token = "0x400A4E6")]
	[FieldOffset(Offset = "0x20")]
	private TMP_Text numBadgeText;

	[Token(Token = "0x60059E3")]
	[Address(RVA = "0x9ECED0", Offset = "0x9EC0D0", VA = "0x1809ECED0")]
	public DuelpassBulkRecieveButtonWidget(ElementObjectManager bulkRecieveEom)
	{
	}

	[Token(Token = "0x60059E4")]
	[Address(RVA = "0x9ECE00", Offset = "0x9EC000", VA = "0x1809ECE00")]
	private void Update()
	{
	}

	[Token(Token = "0x60059E5")]
	[Address(RVA = "0x9ECD10", Offset = "0x9EBF10", VA = "0x1809ECD10")]
	public void UpdateNumBadge()
	{
	}
}
