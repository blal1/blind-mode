using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Download;

[Token(Token = "0x2000F85")]
public class TaskDownloadAssetManager
{
	[Token(Token = "0x2000F86")]
	private enum State
	{
		[Token(Token = "0x400A887")]
		None,
		[Token(Token = "0x400A888")]
		Progress,
		[Token(Token = "0x400A889")]
		Success,
		[Token(Token = "0x400A88A")]
		Cancel,
		[Token(Token = "0x400A88B")]
		Error,
		[Token(Token = "0x400A88C")]
		Wait
	}

	[Token(Token = "0x400A879")]
	private const int kEnableTaskMax = 4;

	[Token(Token = "0x400A87A")]
	[FieldOffset(Offset = "0x10")]
	private State m_state;

	[Token(Token = "0x400A87C")]
	[FieldOffset(Offset = "0x18")]
	private string m_baseUrl;

	[Token(Token = "0x400A87D")]
	[FieldOffset(Offset = "0x20")]
	private List<TaskDownloadAsset> m_tasks;

	[Token(Token = "0x400A87E")]
	[FieldOffset(Offset = "0x28")]
	private Queue<DLCList.DLCInfo> m_requestTask;

	[Token(Token = "0x400A87F")]
	[FieldOffset(Offset = "0x30")]
	private Action<DLCList.DLCInfo> m_updateHandler;

	[Token(Token = "0x400A880")]
	[FieldOffset(Offset = "0x38")]
	private Action m_completeHandler;

	[Token(Token = "0x400A881")]
	[FieldOffset(Offset = "0x40")]
	private Action m_errorHandler;

	[Token(Token = "0x400A882")]
	[FieldOffset(Offset = "0x48")]
	private Action m_cancelHandler;

	[Token(Token = "0x17000ED4")]
	public DownloadErrorCode errorCode
	{
		[Token(Token = "0x6005E1F")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		[CompilerGenerated]
		get
		{
			return default(DownloadErrorCode);
		}
		[Token(Token = "0x6005E20")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000ED5")]
	public int completeNum
	{
		[Token(Token = "0x6005E21")]
		[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005E22")]
		[Address(RVA = "0x49C4A0", Offset = "0x49B6A0", VA = "0x18049C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000ED6")]
	public long completeSize
	{
		[Token(Token = "0x6005E23")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005E24")]
		[Address(RVA = "0xA352F0", Offset = "0xA344F0", VA = "0x180A352F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000ED7")]
	public long totalSize
	{
		[Token(Token = "0x6005E25")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6005E26")]
		[Address(RVA = "0xA4A870", Offset = "0xA49A70", VA = "0x180A4A870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6005E27")]
	[Address(RVA = "0xA49B90", Offset = "0xA48D90", VA = "0x180A49B90")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E28")]
	[Address(RVA = "0xA49CD0", Offset = "0xA48ED0", VA = "0x180A49CD0")]
	public void SetRequest(string baseUrl, DLCList dlcList, Action<DLCList.DLCInfo> updateHandler, Action completeHandler, Action errorHandler, Action cancelHandler)
	{
	}

	[Token(Token = "0x6005E29")]
	[Address(RVA = "0xA4A780", Offset = "0xA49980", VA = "0x180A4A780")]
	public void Update()
	{
	}

	[Token(Token = "0x6005E2A")]
	[Address(RVA = "0xA4A200", Offset = "0xA49400", VA = "0x180A4A200")]
	private void UpdateProgress()
	{
	}

	[Token(Token = "0x6005E2B")]
	[Address(RVA = "0xA4A090", Offset = "0xA49290", VA = "0x180A4A090")]
	private void UpdateError()
	{
	}

	[Token(Token = "0x6005E2C")]
	[Address(RVA = "0xA49F20", Offset = "0xA49120", VA = "0x180A49F20")]
	private void UpdateCancel()
	{
	}

	[Token(Token = "0x6005E2D")]
	[Address(RVA = "0xA49BB0", Offset = "0xA48DB0", VA = "0x180A49BB0")]
	public void Retry()
	{
	}

	[Token(Token = "0x6005E2E")]
	[Address(RVA = "0xA49A60", Offset = "0xA48C60", VA = "0x180A49A60")]
	public void Cancel()
	{
	}

	[Token(Token = "0x6005E2F")]
	[Address(RVA = "0xA4A7B0", Offset = "0xA499B0", VA = "0x180A4A7B0")]
	public TaskDownloadAssetManager()
	{
	}
}
