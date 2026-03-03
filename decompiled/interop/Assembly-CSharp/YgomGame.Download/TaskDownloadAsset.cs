using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace YgomGame.Download;

[Token(Token = "0x2000F81")]
public class TaskDownloadAsset : TaskWebRequest
{
	[Token(Token = "0x2000F82")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x400A86C")]
		[FieldOffset(Offset = "0x10")]
		public string path;

		[Token(Token = "0x400A86D")]
		[FieldOffset(Offset = "0x18")]
		public byte[] data;

		[Token(Token = "0x400A86E")]
		[FieldOffset(Offset = "0x20")]
		public bool isCompleted;

		[Token(Token = "0x400A86F")]
		[FieldOffset(Offset = "0x28")]
		public TaskDownloadAsset _003C_003E4__this;

		[Token(Token = "0x6005E10")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6005E11")]
		[Address(RVA = "0xA4B7E0", Offset = "0xA4A9E0", VA = "0x180A4B7E0")]
		internal void _003CInstallDataAsync_003Eb__0()
		{
		}

		[Token(Token = "0x6005E12")]
		[Address(RVA = "0xA4B850", Offset = "0xA4AA50", VA = "0x180A4B850")]
		internal void _003CInstallDataAsync_003Eb__1(Task t)
		{
		}
	}

	[Token(Token = "0x2000F83")]
	[CompilerGenerated]
	private sealed class _003CInstallDataAsync_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A870")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A871")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A872")]
		[FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x400A873")]
		[FieldOffset(Offset = "0x28")]
		public byte[] data;

		[Token(Token = "0x400A874")]
		[FieldOffset(Offset = "0x30")]
		public TaskDownloadAsset _003C_003E4__this;

		[Token(Token = "0x400A875")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		[Token(Token = "0x17000ED0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005E16")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ED1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005E18")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E13")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInstallDataAsync_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005E14")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005E15")]
		[Address(RVA = "0xA4B390", Offset = "0xA4A590", VA = "0x180A4B390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005E17")]
		[Address(RVA = "0xA4B590", Offset = "0xA4A790", VA = "0x180A4B590", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000F84")]
	[CompilerGenerated]
	private sealed class _003CyProgress_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A876")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A877")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A878")]
		[FieldOffset(Offset = "0x20")]
		public TaskDownloadAsset _003C_003E4__this;

		[Token(Token = "0x17000ED2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005E1C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ED3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005E1E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E19")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyProgress_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005E1A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005E1B")]
		[Address(RVA = "0xA4E300", Offset = "0xA4D500", VA = "0x180A4E300", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005E1D")]
		[Address(RVA = "0xA4E490", Offset = "0xA4D690", VA = "0x180A4E490", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A86A")]
	[FieldOffset(Offset = "0x58")]
	private DLCList.DLCInfo m_info;

	[Token(Token = "0x400A86B")]
	[FieldOffset(Offset = "0x78")]
	private Action<DLCList.DLCInfo> m_completeAction;

	[Token(Token = "0x17000ECE")]
	private bool IsEnableTask
	{
		[Token(Token = "0x6005E08")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000ECF")]
	public long size
	{
		[Token(Token = "0x6005E09")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x6005E0A")]
	[Address(RVA = "0xA4A9C0", Offset = "0xA49BC0", VA = "0x180A4A9C0")]
	public TaskDownloadAsset(string _baseUrl, string _path)
	{
	}

	[Token(Token = "0x6005E0B")]
	[Address(RVA = "0xA4AA20", Offset = "0xA49C20", VA = "0x180A4AA20")]
	public TaskDownloadAsset(string _baseUrl, DLCList.DLCInfo _info)
	{
	}

	[Token(Token = "0x6005E0C")]
	[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
	public void SetCompleteHandler(Action<DLCList.DLCInfo> callback)
	{
	}

	[Token(Token = "0x6005E0D")]
	[Address(RVA = "0xA4AAF0", Offset = "0xA49CF0", VA = "0x180A4AAF0", Slot = "10")]
	[IteratorStateMachine(typeof(_003CyProgress_003Ed__9))]
	protected override IEnumerator yProgress()
	{
		return null;
	}

	[Token(Token = "0x6005E0E")]
	[Address(RVA = "0xA4A880", Offset = "0xA49A80", VA = "0x180A4A880")]
	[IteratorStateMachine(typeof(_003CInstallDataAsync_003Ed__10))]
	private IEnumerator InstallDataAsync(string path, byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6005E0F")]
	[Address(RVA = "0xA4A930", Offset = "0xA49B30", VA = "0x180A4A930")]
	private void InstallData(string path, byte[] data)
	{
	}
}
