using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.MDMarkup;

[Serializable]
[Token(Token = "0x2000C7D")]
public class MDMarkupContentEmbedContainerTab : MDMarkupContentBase, IMDMarkupSourceRequireTextData, IMDMarkupContentAsyncLoader, IMDMarkupSourceSupportedInvalidMessage, IMDMarkupSupportedStrFormatByArgsModifier_OnPreload, IMDMarkupSupportedStrFormatByArgsModifier
{
	[Token(Token = "0x4009B32")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string mmaPath;

	[Token(Token = "0x4009B33")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public GlobalTextData overrideTitle;

	[Token(Token = "0x4009B34")]
	[FieldOffset(Offset = "0x38")]
	private TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x4009B36")]
	[FieldOffset(Offset = "0x48")]
	private int m_InvalidMessagePriority;

	[Token(Token = "0x4009B37")]
	[FieldOffset(Offset = "0x50")]
	private string m_InvalidMessageText;

	[Token(Token = "0x17000A54")]
	public override MDMarkupDef.MarkupType markupType
	{
		[Token(Token = "0x6004BA0")]
		[Address(RVA = "0x937680", Offset = "0x936880", VA = "0x180937680", Slot = "15")]
		get
		{
			return default(MDMarkupDef.MarkupType);
		}
	}

	[Token(Token = "0x17000A55")]
	public override int contentIndent
	{
		[Token(Token = "0x6004BA1")]
		[Address(RVA = "0x4C9EF0", Offset = "0x4C90F0", VA = "0x1804C9EF0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A56")]
	public MDMarkupAsset embedMarkupAsset
	{
		[Token(Token = "0x6004BA2")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6004BA3")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000A57")]
	public int invalidMessagePriority
	{
		[Token(Token = "0x6004BA4")]
		[Address(RVA = "0x49BDB0", Offset = "0x49AFB0", VA = "0x18049BDB0", Slot = "26")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A58")]
	public string invalidMessageText
	{
		[Token(Token = "0x6004BA5")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004BA6")]
	[Address(RVA = "0x937490", Offset = "0x936690", VA = "0x180937490", Slot = "28")]
	public void OnFormatByArgsModifier(object[] formatParams)
	{
	}

	[Token(Token = "0x6004BA7")]
	[Address(RVA = "0x937590", Offset = "0x936790", VA = "0x180937590", Slot = "24")]
	public void OnSetupTextGroupLoadHolder(TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6004BA8")]
	[Address(RVA = "0x937230", Offset = "0x936430", VA = "0x180937230", Slot = "25")]
	public void LoadAsync(Action onComplete)
	{
	}

	[Token(Token = "0x6004BA9")]
	[Address(RVA = "0x9373D0", Offset = "0x9365D0", VA = "0x1809373D0", Slot = "22")]
	protected override object OnExportJsonObj(object jsonObj)
	{
		return null;
	}

	[Token(Token = "0x6004BAA")]
	[Address(RVA = "0x9374C0", Offset = "0x9366C0", VA = "0x1809374C0", Slot = "23")]
	protected override void OnImportJsonObj(object jsonObj)
	{
	}

	[Token(Token = "0x6004BAB")]
	[Address(RVA = "0x9375D0", Offset = "0x9367D0", VA = "0x1809375D0")]
	public MDMarkupContentEmbedContainerTab()
	{
	}
}
