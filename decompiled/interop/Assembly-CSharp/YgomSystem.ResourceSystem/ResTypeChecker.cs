using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002C6")]
public class ResTypeChecker : IResTypeChecker
{
	[Token(Token = "0x20002C7")]
	private class CheckFileTypeParam
	{
		[Token(Token = "0x170001B2")]
		public int Result
		{
			[Token(Token = "0x6001107")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6001108")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B3")]
		public string Path
		{
			[Token(Token = "0x6001109")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600110A")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170001B4")]
		public bool isStreaming
		{
			[Token(Token = "0x600110B")]
			[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600110C")]
			[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600110D")]
		[Address(RVA = "0xE6C9C0", Offset = "0xE6BBC0", VA = "0x180E6C9C0")]
		public CheckFileTypeParam()
		{
		}
	}

	[Token(Token = "0x20002C8")]
	private class CheckFileTypeThread : PooledThreadBase
	{
		[Token(Token = "0x600110E")]
		[Address(RVA = "0xE6CEF0", Offset = "0xE6C0F0", VA = "0x180E6CEF0", Slot = "10")]
		protected override bool ExecThread(object parameter)
		{
			return default(bool);
		}

		[Token(Token = "0x600110F")]
		[Address(RVA = "0xE6CC70", Offset = "0xE6BE70", VA = "0x180E6CC70")]
		private bool CheckFromLocalFileSystem(CheckFileTypeParam param)
		{
			return default(bool);
		}

		[Token(Token = "0x6001110")]
		[Address(RVA = "0xE6C9E0", Offset = "0xE6BBE0", VA = "0x180E6C9E0")]
		private bool CheckFromFileStream(CheckFileTypeParam param)
		{
			return default(bool);
		}

		[Token(Token = "0x6001111")]
		[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
		public CheckFileTypeThread()
		{
		}
	}

	[Token(Token = "0x20002C9")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4000F75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ResTypeChecker _003C_003E4__this;

		[Token(Token = "0x4000F76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Resource res;

		[Token(Token = "0x6001112")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6001113")]
		[Address(RVA = "0xE817E0", Offset = "0xE809E0", VA = "0x180E817E0")]
		internal void _003CCheckFileTypeAsync_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20002CA")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_1
	{
		[Token(Token = "0x4000F77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isAssetBundle;

		[Token(Token = "0x6001114")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass11_1()
		{
		}

		[Token(Token = "0x6001115")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		internal void _003CCheckFileTypeAsync_003Eb__1(bool result)
		{
		}
	}

	[Token(Token = "0x20002CB")]
	[CompilerGenerated]
	private sealed class _003CCheckFileTypeAsync_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ResTypeChecker _003C_003E4__this;

		[Token(Token = "0x4000F7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Resource res;

		[Token(Token = "0x4000F7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		[Token(Token = "0x4000F7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ResourceManager.ReqType queueId;

		[Token(Token = "0x4000F7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass11_1 _003C_003E8__2;

		[Token(Token = "0x4000F7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Task _003Ctask_003E5__2;

		[Token(Token = "0x4000F80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _003CisStreaming_003E5__3;

		[Token(Token = "0x170001B5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001119")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600111B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001116")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckFileTypeAsync_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001117")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001118")]
		[Address(RVA = "0xE7AC40", Offset = "0xE79E40", VA = "0x180E7AC40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600111A")]
		[Address(RVA = "0xE7B060", Offset = "0xE7A260", VA = "0x180E7B060", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20002CC")]
	[CompilerGenerated]
	private sealed class _003CcheckFileAssetBundleAsync_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isStreamingAssets;

		[Token(Token = "0x4000F84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string path;

		[Token(Token = "0x4000F85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<bool> callback;

		[Token(Token = "0x4000F86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ResTypeChecker _003C_003E4__this;

		[Token(Token = "0x4000F87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int id;

		[Token(Token = "0x4000F88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CheckFileTypeThread _003CidleThread_003E5__2;

		[Token(Token = "0x4000F89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CheckFileTypeParam _003Cparam_003E5__3;

		[Token(Token = "0x170001B7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600111F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001121")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600111C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckFileAssetBundleAsync_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600111D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600111E")]
		[Address(RVA = "0xE82DA0", Offset = "0xE81FA0", VA = "0x180E82DA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001120")]
		[Address(RVA = "0xE83140", Offset = "0xE82340", VA = "0x180E83140", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000F6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private CheckFileTypeParam[] threadParam;

	[Token(Token = "0x4000F70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CheckFileTypeThread[] threads;

	[Token(Token = "0x4000F71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<IResTypeChecker> m_checkList;

	[Token(Token = "0x60010FE")]
	[Address(RVA = "0xE75E50", Offset = "0xE75050", VA = "0x180E75E50", Slot = "4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60010FF")]
	[Address(RVA = "0xE759A0", Offset = "0xE74BA0", VA = "0x180E759A0", Slot = "5")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6001100")]
	[Address(RVA = "0xE75800", Offset = "0xE74A00", VA = "0x180E75800", Slot = "6")]
	public void ClearCache()
	{
	}

	[Token(Token = "0x6001101")]
	[Address(RVA = "0xE75CF0", Offset = "0xE74EF0", VA = "0x180E75CF0", Slot = "7")]
	public ResTypeData GetResType(string path)
	{
		return null;
	}

	[Token(Token = "0x6001102")]
	[Address(RVA = "0xE75B90", Offset = "0xE74D90", VA = "0x180E75B90", Slot = "8")]
	public ResTypeData GetResTypeSimpleCheck(string path)
	{
		return null;
	}

	[Token(Token = "0x6001103")]
	[Address(RVA = "0xE76290", Offset = "0xE75490", VA = "0x180E76290")]
	private void UpdateResType(Resource res)
	{
	}

	[Token(Token = "0x6001104")]
	[Address(RVA = "0xE75760", Offset = "0xE74960", VA = "0x180E75760")]
	[IteratorStateMachine(typeof(_003CCheckFileTypeAsync_003Ed__11))]
	public IEnumerator CheckFileTypeAsync(Resource res, ResourceManager.ReqType queueId)
	{
		return null;
	}

	[Token(Token = "0x6001105")]
	[Address(RVA = "0xE76370", Offset = "0xE75570", VA = "0x180E76370")]
	[IteratorStateMachine(typeof(_003CcheckFileAssetBundleAsync_003Ed__12))]
	private IEnumerator checkFileAssetBundleAsync(int id, string path, bool isStreamingAssets = false, [Optional] Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6001106")]
	[Address(RVA = "0xE762E0", Offset = "0xE754E0", VA = "0x180E762E0")]
	public ResTypeChecker()
	{
	}
}
