using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D1D")]
public abstract class MDMarkupWidgetBase : ElementWidgetBase, IMDMarkupWidget, IMDMarkupAsyncWidget
{
	[Token(Token = "0x4009D7C")]
	[FieldOffset(Offset = "0x20")]
	public readonly MDMarkupIndentWidget indentWidget;

	[Token(Token = "0x17000B54")]
	private MDMarkupIndentWidget YgomGame_002EMDMarkup_002EIMDMarkupWidget_002EindentWidget
	{
		[Token(Token = "0x6004F15")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B55")]
	public virtual bool isReady
	{
		[Token(Token = "0x6004F16")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004F17")]
	[Address(RVA = "0x975170", Offset = "0x974370", VA = "0x180975170")]
	public MDMarkupWidgetBase(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
	{
	}

	[Token(Token = "0x6004F18")]
	public abstract void BindContentData(IMDMarkupContent mdMarkupContent);

	[Token(Token = "0x6004F19")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "18")]
	public virtual void OnReady()
	{
	}
}
