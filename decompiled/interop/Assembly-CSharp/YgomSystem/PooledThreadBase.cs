using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x200019B")]
public class PooledThreadBase
{
	[Token(Token = "0x40009B2")]
	private const int WaitOneFrame = 16;

	[Token(Token = "0x40009B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private bool IsExec;

	[Token(Token = "0x6000A44")]
	[Address(RVA = "0xC113E0", Offset = "0xC105E0", VA = "0x180C113E0", Slot = "4")]
	public virtual bool Run([Optional] object parameter)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A45")]
	[Address(RVA = "0xC114F0", Offset = "0xC106F0", VA = "0x180C114F0", Slot = "5")]
	public virtual void Terminate()
	{
	}

	[Token(Token = "0x6000A46")]
	[Address(RVA = "0xC113C0", Offset = "0xC105C0", VA = "0x180C113C0", Slot = "6")]
	public virtual bool IsRun()
	{
		return default(bool);
	}

	[Token(Token = "0x6000A47")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	public virtual void Join()
	{
	}

	[Token(Token = "0x6000A48")]
	[Address(RVA = "0xC114B0", Offset = "0xC106B0", VA = "0x180C114B0", Slot = "8")]
	protected virtual void Sleep(int msec)
	{
	}

	[Token(Token = "0x6000A49")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "9")]
	protected virtual bool InitThread(object parameter)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "10")]
	protected virtual bool ExecThread(object parameter)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	protected virtual void ExitThread(object parameter)
	{
	}

	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0xC11510", Offset = "0xC10710", VA = "0x180C11510")]
	private void ThreadProc([Optional] object parameter)
	{
	}

	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PooledThreadBase()
	{
	}
}
