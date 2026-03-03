using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.ElementWidget;

[Token(Token = "0x2000616")]
public class TextWrapper
{
	[Token(Token = "0x2000617")]
	private enum Mode
	{
		[Token(Token = "0x4001D53")]
		uGUI,
		[Token(Token = "0x4001D54")]
		TMP
	}

	[Token(Token = "0x4001D4F")]
	[FieldOffset(Offset = "0x10")]
	private Mode mode;

	[Token(Token = "0x4001D50")]
	[FieldOffset(Offset = "0x18")]
	private Text textComponent;

	[Token(Token = "0x4001D51")]
	[FieldOffset(Offset = "0x20")]
	private TMP_Text tmpTextComponent;

	[Token(Token = "0x170004FB")]
	public GameObject gameObject
	{
		[Token(Token = "0x6002810")]
		[Address(RVA = "0x6B08D0", Offset = "0x6AFAD0", VA = "0x1806B08D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004FC")]
	public string text
	{
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x6B0910", Offset = "0x6AFB10", VA = "0x1806B0910")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x6B0A10", Offset = "0x6AFC10", VA = "0x1806B0A10")]
		set
		{
		}
	}

	[Token(Token = "0x170004FD")]
	public Color color
	{
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x6B0830", Offset = "0x6AFA30", VA = "0x1806B0830")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x6B0980", Offset = "0x6AFB80", VA = "0x1806B0980")]
		set
		{
		}
	}

	[Token(Token = "0x170004FE")]
	public bool enabled
	{
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x6B0890", Offset = "0x6AFA90", VA = "0x1806B0890")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x6B09D0", Offset = "0x6AFBD0", VA = "0x1806B09D0")]
		set
		{
		}
	}

	[Token(Token = "0x600280E")]
	[Address(RVA = "0x6B07B0", Offset = "0x6AF9B0", VA = "0x1806B07B0")]
	public TextWrapper(Text text)
	{
	}

	[Token(Token = "0x600280F")]
	[Address(RVA = "0x6B07F0", Offset = "0x6AF9F0", VA = "0x1806B07F0")]
	public TextWrapper(TMP_Text text)
	{
	}
}
