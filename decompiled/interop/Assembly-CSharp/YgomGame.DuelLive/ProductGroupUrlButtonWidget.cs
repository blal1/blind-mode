using System;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F43")]
public class ProductGroupUrlButtonWidget : ElementWidgetBase
{
	[Token(Token = "0x2000F44")]
	public class Context
	{
		[Token(Token = "0x400A6F9")]
		[FieldOffset(Offset = "0x10")]
		public string lableIDs;

		[Token(Token = "0x400A6FA")]
		[FieldOffset(Offset = "0x18")]
		public string clickUrl;

		[Token(Token = "0x400A6FB")]
		[FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x400A6FC")]
		[FieldOffset(Offset = "0x28")]
		public string param;

		[Token(Token = "0x6005C78")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public Context()
		{
		}
	}

	[Token(Token = "0x400A6F4")]
	private const string k_ELabelButton = "Button";

	[Token(Token = "0x400A6F5")]
	private const string k_ELabelButtonText = "Label";

	[Token(Token = "0x400A6F6")]
	[FieldOffset(Offset = "0x20")]
	private SelectionButton m_button;

	[Token(Token = "0x400A6F7")]
	[FieldOffset(Offset = "0x28")]
	private string m_url;

	[Token(Token = "0x400A6F8")]
	[FieldOffset(Offset = "0x30")]
	public Action<string> onClickButtonCallback;

	[Token(Token = "0x17000E85")]
	public SelectionButton button
	{
		[Token(Token = "0x6005C74")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005C75")]
	[Address(RVA = "0xA21980", Offset = "0xA20B80", VA = "0x180A21980")]
	public ProductGroupUrlButtonWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005C76")]
	[Address(RVA = "0xA218C0", Offset = "0xA20AC0", VA = "0x180A218C0")]
	public void SetView(Context ctx)
	{
	}
}
