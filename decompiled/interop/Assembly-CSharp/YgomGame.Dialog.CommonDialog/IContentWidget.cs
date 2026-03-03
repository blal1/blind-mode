using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FDD")]
public interface IContentWidget
{
	[Token(Token = "0x17000F1F")]
	GameObject gameObject
	{
		[Token(Token = "0x600601B")]
		get;
	}

	[Token(Token = "0x17000F20")]
	Transform transform
	{
		[Token(Token = "0x600601C")]
		get;
	}

	[Token(Token = "0x17000F21")]
	CommonDialogContentContainerWidget parentWidget
	{
		[Token(Token = "0x600601F")]
		get;
	}

	[Token(Token = "0x600601D")]
	IContentWidget DuplicateInstantiate();

	[Token(Token = "0x600601E")]
	void Binding(IEntryData entryData);

	[Token(Token = "0x6006020")]
	void Initialize(CommonDialogContentContainerWidget parentWidget);
}
