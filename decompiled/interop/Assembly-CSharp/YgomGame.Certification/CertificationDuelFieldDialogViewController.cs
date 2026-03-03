using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomGame.Menu.Common;

namespace YgomGame.Certification;

[Token(Token = "0x20014BB")]
public class CertificationDuelFieldDialogViewController : BaseMenuViewController
{
	[Token(Token = "0x400C7EC")]
	[FieldOffset(Offset = "0xD0")]
	private string prefPath;

	[Token(Token = "0x400C7ED")]
	[FieldOffset(Offset = "0xD8")]
	private GameObject root;

	[Token(Token = "0x400C7EE")]
	[FieldOffset(Offset = "0xE0")]
	private BindingDuelFieldCards _originalBindingDuelFieldCards;

	[Token(Token = "0x400C7EF")]
	[FieldOffset(Offset = "0xE8")]
	private BindingDuelFieldCards _bindingDuelFieldCards;

	[Token(Token = "0x400C7F0")]
	[FieldOffset(Offset = "0xF0")]
	private RectTransform rectTransform;

	[Token(Token = "0x400C7F1")]
	[FieldOffset(Offset = "0xF8")]
	public float scale;

	[Token(Token = "0x400C7F2")]
	[FieldOffset(Offset = "0x100")]
	private CertificationWritingViewController vc;

	[Token(Token = "0x400C7F3")]
	[FieldOffset(Offset = "0x108")]
	private CertificationUtil.CertificationTimer certificationTimer;

	[Token(Token = "0x6008088")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6008089")]
	[Address(RVA = "0xC899D0", Offset = "0xC88BD0", VA = "0x180C899D0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600808A")]
	[Address(RVA = "0xC8A2C0", Offset = "0xC894C0", VA = "0x180C8A2C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600808B")]
	[Address(RVA = "0xC8A060", Offset = "0xC89260", VA = "0x180C8A060")]
	private void OnloadedPref(GameObject go)
	{
	}

	[Token(Token = "0x600808C")]
	[Address(RVA = "0xC89830", Offset = "0xC88A30", VA = "0x180C89830", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600808D")]
	[Address(RVA = "0xC8A360", Offset = "0xC89560", VA = "0x180C8A360")]
	public CertificationDuelFieldDialogViewController()
	{
	}
}
