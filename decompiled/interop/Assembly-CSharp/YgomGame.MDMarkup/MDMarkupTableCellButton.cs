using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.Events;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D05")]
public class MDMarkupTableCellButton : MDMarkupTableCellBase, IMDMarkupLinkWidget, IMDMarkupButtonWidget, IMDMarkupButtonContainWidget, IMDMarkupTMPWidget
{
	[Token(Token = "0x4009D30")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x4009D31")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelText;

	[Token(Token = "0x4009D32")]
	[FieldOffset(Offset = "0x40")]
	public readonly TMP_Text text;

	[Token(Token = "0x17000B21")]
	public SelectionButton button
	{
		[Token(Token = "0x6004E91")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004E92")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000B22")]
	public string link
	{
		[Token(Token = "0x6004E94")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004E93")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6004E95")]
	[Address(RVA = "0x95A700", Offset = "0x959900", VA = "0x18095A700")]
	public MDMarkupTableCellButton(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004E96")]
	[Address(RVA = "0x95A3D0", Offset = "0x9595D0", VA = "0x18095A3D0", Slot = "20")]
	public void OnSetupSelectionItem(IMDMarkupFreeScrollHandler freeScrollHandler)
	{
	}

	[Token(Token = "0x6004E97")]
	[Address(RVA = "0x95A6D0", Offset = "0x9598D0", VA = "0x18095A6D0")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x6004E98")]
	[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
	public void SetLink(string link)
	{
	}

	[Token(Token = "0x6004E99")]
	[Address(RVA = "0x95A490", Offset = "0x959690", VA = "0x18095A490")]
	public void SetOverrideWidth(float overrideWidth)
	{
	}

	[Token(Token = "0x6004E9A")]
	[Address(RVA = "0x95A430", Offset = "0x959630", VA = "0x18095A430", Slot = "19")]
	public void SetOnClick(UnityAction callback)
	{
	}

	[Token(Token = "0x6004E9B")]
	[Address(RVA = "0x95A340", Offset = "0x959540", VA = "0x18095A340", Slot = "21")]
	public void AssignTMPGlyphCreateBuffer(ITextMeshProGlyphCreateBuffer tmpGlyphCreateBuffer)
	{
	}
}
