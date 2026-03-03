using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;

namespace YgomGame.Menu.AgeGate;

[Token(Token = "0x20013F0")]
internal abstract class AgeNumber
{
	[Token(Token = "0x400C497")]
	[FieldOffset(Offset = "0x10")]
	public string[] selectList;

	[Token(Token = "0x400C499")]
	protected const int NullIndex = -1;

	[Token(Token = "0x400C49A")]
	[FieldOffset(Offset = "0x20")]
	protected TMP_Text buttonText;

	[Token(Token = "0x1700130A")]
	public int currentIndex
	{
		[Token(Token = "0x6007C0F")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007C10")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700130B")]
	public bool isSelected
	{
		[Token(Token = "0x6007C15")]
		[Address(RVA = "0xC54BE0", Offset = "0xC53DE0", VA = "0x180C54BE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6007C11")]
	[Address(RVA = "0xC54B90", Offset = "0xC53D90", VA = "0x180C54B90")]
	public AgeNumber()
	{
	}

	[Token(Token = "0x6007C12")]
	protected abstract int indexToValue(int index);

	[Token(Token = "0x6007C13")]
	protected abstract string getUnselectText();

	[Token(Token = "0x6007C14")]
	[Address(RVA = "0xC54BF0", Offset = "0xC53DF0", VA = "0x180C54BF0")]
	protected void updateButtonText()
	{
	}

	[Token(Token = "0x6007C16")]
	[Address(RVA = "0xC54B40", Offset = "0xC53D40", VA = "0x180C54B40")]
	public int GetCurrentValue()
	{
		return default(int);
	}

	[Token(Token = "0x6007C17")]
	[Address(RVA = "0xC54B00", Offset = "0xC53D00", VA = "0x180C54B00")]
	public void AttachButtonText(TMP_Text textUI)
	{
	}

	[Token(Token = "0x6007C18")]
	[Address(RVA = "0xC54B30", Offset = "0xC53D30", VA = "0x180C54B30")]
	public void ChangeIndex(int index)
	{
	}
}
