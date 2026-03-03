using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x200019C")]
public class ThreadBase
{
	[Token(Token = "0x40009B4")]
	private const int WaitOneFrame = 16;

	[Token(Token = "0x40009B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private Thread ThreadInstance;

	[Token(Token = "0x40009B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool IsExec;

	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0xC16A50", Offset = "0xC15C50", VA = "0x180C16A50", Slot = "4")]
	public virtual bool Run([Optional] object parameter)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0xC16BB0", Offset = "0xC15DB0", VA = "0x180C16BB0", Slot = "5")]
	public virtual void Terminate()
	{
	}

	[Token(Token = "0x6000A50")]
	[Address(RVA = "0xC169F0", Offset = "0xC15BF0", VA = "0x180C169F0", Slot = "6")]
	public virtual bool IsRun()
	{
		return default(bool);
	}

	[Token(Token = "0x6000A51")]
	[Address(RVA = "0xC16A10", Offset = "0xC15C10", VA = "0x180C16A10", Slot = "7")]
	public virtual void Join()
	{
	}

	[Token(Token = "0x6000A52")]
	[Address(RVA = "0xC16B70", Offset = "0xC15D70", VA = "0x180C16B70", Slot = "8")]
	protected virtual void Sleep(int msec)
	{
	}

	[Token(Token = "0x6000A53")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "9")]
	protected virtual bool InitThread(object parameter)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A54")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "10")]
	protected virtual bool ExecThread(object parameter)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A55")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	protected virtual void ExitThread(object parameter)
	{
	}

	[Token(Token = "0x6000A56")]
	[Address(RVA = "0xC16BD0", Offset = "0xC15DD0", VA = "0x180C16BD0")]
	private void ThreadProc(object parameter)
	{
	}

	[Token(Token = "0x6000A57")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ThreadBase()
	{
	}
}
