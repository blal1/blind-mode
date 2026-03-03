using System;
using Il2CppDummyDll;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001402")]
public class InputDigitViewController : DialogViewControllerBase, IBokeSupported
{
	[Token(Token = "0x2001403")]
	private enum ButtonLabel
	{
		[Token(Token = "0x400C4DA")]
		LargeMinusButton,
		[Token(Token = "0x400C4DB")]
		MinusButton,
		[Token(Token = "0x400C4DC")]
		PlusButton,
		[Token(Token = "0x400C4DD")]
		LargePlusButton
	}

	[Token(Token = "0x400C4CB")]
	internal const string ARG_TITLE = "title";

	[Token(Token = "0x400C4CC")]
	internal const string ARG_MESSAGE = "message";

	[Token(Token = "0x400C4CD")]
	internal const string ARG_INITVALUE = "initValue";

	[Token(Token = "0x400C4CE")]
	internal const string ARG_MAXVALUE = "maxValue";

	[Token(Token = "0x400C4CF")]
	internal const string ARG_MINVALUE = "minValue";

	[Token(Token = "0x400C4D0")]
	internal const string ARG_LARGECHANGE = "largeChangeAmount";

	[Token(Token = "0x400C4D1")]
	internal const string ARG_INPUTHANDLER = "inputHandler";

	[Token(Token = "0x400C4D2")]
	[FieldOffset(Offset = "0xE0")]
	private ExtendedTextMeshProUGUI _digitText;

	[Token(Token = "0x400C4D3")]
	[FieldOffset(Offset = "0xE8")]
	private SelectionButton[] _changeButtons;

	[Token(Token = "0x400C4D4")]
	[FieldOffset(Offset = "0xF0")]
	private Action<int> _onDecided;

	[Token(Token = "0x400C4D5")]
	[FieldOffset(Offset = "0xF8")]
	private int _maxValue;

	[Token(Token = "0x400C4D6")]
	[FieldOffset(Offset = "0xFC")]
	private int _minValue;

	[Token(Token = "0x400C4D7")]
	[FieldOffset(Offset = "0x100")]
	private int _largeChangeAmount;

	[Token(Token = "0x400C4D8")]
	[FieldOffset(Offset = "0x104")]
	private int _currentValue;

	[Token(Token = "0x6007C77")]
	[Address(RVA = "0xC63410", Offset = "0xC62610", VA = "0x180C63410", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007C78")]
	[Address(RVA = "0xC636F0", Offset = "0xC628F0", VA = "0x180C636F0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007C79")]
	[Address(RVA = "0xC639D0", Offset = "0xC62BD0", VA = "0x180C639D0", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x6007C7A")]
	[Address(RVA = "0xC63E40", Offset = "0xC63040", VA = "0x180C63E40")]
	private void SetupButton(string label, int changeValue, out SelectionButton button)
	{
	}

	[Token(Token = "0x6007C7B")]
	[Address(RVA = "0xC63D60", Offset = "0xC62F60", VA = "0x180C63D60")]
	private void OnValueAdded(int delta)
	{
	}

	[Token(Token = "0x6007C7C")]
	[Address(RVA = "0xC635D0", Offset = "0xC627D0", VA = "0x180C635D0")]
	private void OnCheckButtonPushable()
	{
	}

	[Token(Token = "0x6007C7D")]
	[Address(RVA = "0xC63FB0", Offset = "0xC631B0", VA = "0x180C63FB0")]
	public InputDigitViewController()
	{
	}
}
