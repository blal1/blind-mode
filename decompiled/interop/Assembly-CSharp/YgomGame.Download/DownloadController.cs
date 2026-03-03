using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace YgomGame.Download;

[Token(Token = "0x2000F70")]
public sealed class DownloadController
{
	[Token(Token = "0x2000F71")]
	private struct DownloadData
	{
		[Token(Token = "0x400A83C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string path;

		[Token(Token = "0x400A83D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string index;
	}

	[Token(Token = "0x2000F72")]
	public delegate void EventHandler();

	[Token(Token = "0x2000F73")]
	public delegate void StepHandler(DownloadStep step);

	[Token(Token = "0x2000F75")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_0
	{
		[Token(Token = "0x400A841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DLCList m_streamList;

		[Token(Token = "0x400A842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DownloadController _003C_003E4__this;

		[Token(Token = "0x400A843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool wait;

		[Token(Token = "0x6005DD5")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass44_0()
		{
		}

		[Token(Token = "0x6005DD6")]
		[Address(RVA = "0xA4B8A0", Offset = "0xA4AAA0", VA = "0x180A4B8A0")]
		internal void _003CyDownload_003Eb__5()
		{
		}
	}

	[Token(Token = "0x2000F76")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_1
	{
		[Token(Token = "0x400A844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DLCList download;

		[Token(Token = "0x400A845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass44_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass44_1()
		{
		}

		[Token(Token = "0x6005DD8")]
		[Address(RVA = "0xA4B8E0", Offset = "0xA4AAE0", VA = "0x180A4B8E0")]
		internal void _003CyDownload_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000F77")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_2
	{
		[Token(Token = "0x400A846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool dialogCheck;

		[Token(Token = "0x400A847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool gotoTitle;

		[Token(Token = "0x6005DD9")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass44_2()
		{
		}

		[Token(Token = "0x6005DDA")]
		[Address(RVA = "0xA4BA30", Offset = "0xA4AC30", VA = "0x180A4BA30")]
		internal void _003CyDownload_003Eb__3()
		{
		}

		[Token(Token = "0x6005DDB")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CyDownload_003Eb__4()
		{
		}
	}

	[Token(Token = "0x2000F78")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_3
	{
		[Token(Token = "0x400A848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool result;

		[Token(Token = "0x6005DDC")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass44_3()
		{
		}

		[Token(Token = "0x6005DDD")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		internal void _003CyDownload_003Eb__6(bool r)
		{
		}
	}

	[Token(Token = "0x2000F7A")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		[Token(Token = "0x400A84B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DownloadController _003C_003E4__this;

		[Token(Token = "0x400A84C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TaskDownloadAssetManager m_manager;

		[Token(Token = "0x400A84D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int count;

		[Token(Token = "0x400A84E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x6005DE0")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6005DE1")]
		[Address(RVA = "0xA4BCC0", Offset = "0xA4AEC0", VA = "0x180A4BCC0")]
		internal void _003CDownloadItem_003Eb__0(DLCList.DLCInfo _info)
		{
		}

		[Token(Token = "0x6005DE2")]
		[Address(RVA = "0xA4BDC0", Offset = "0xA4AFC0", VA = "0x180A4BDC0")]
		internal void _003CDownloadItem_003Eb__1()
		{
		}

		[Token(Token = "0x6005DE3")]
		[Address(RVA = "0xA4BE60", Offset = "0xA4B060", VA = "0x180A4BE60")]
		internal void _003CDownloadItem_003Eb__2()
		{
		}

		[Token(Token = "0x6005DE4")]
		[Address(RVA = "0xA4BFB0", Offset = "0xA4B1B0", VA = "0x180A4BFB0")]
		internal void _003CDownloadItem_003Eb__3()
		{
		}
	}

	[Token(Token = "0x2000F7C")]
	[CompilerGenerated]
	private sealed class _003CDownloadItem_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DownloadController _003C_003E4__this;

		[Token(Token = "0x400A854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x400A855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string baseUrl;

		[Token(Token = "0x400A856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DLCList target;

		[Token(Token = "0x400A857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass46_0 _003C_003E8__1;

		[Token(Token = "0x17000EC5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005DEB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EC6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005DED")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005DE8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CDownloadItem_003Ed__46(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005DE9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005DEA")]
		[Address(RVA = "0xA4AF50", Offset = "0xA4A150", VA = "0x180A4AF50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005DEC")]
		[Address(RVA = "0xA4B350", Offset = "0xA4A550", VA = "0x180A4B350", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000F7D")]
	[CompilerGenerated]
	private sealed class _003CyDeleteUnusedData_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A85A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DownloadController _003C_003E4__this;

		[Token(Token = "0x400A85B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Task _003Ctask_003E5__2;

		[Token(Token = "0x17000EC7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005DF1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EC8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005DF3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005DEE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyDeleteUnusedData_003Ed__45(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005DEF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005DF0")]
		[Address(RVA = "0xA4C580", Offset = "0xA4B780", VA = "0x180A4C580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005DF2")]
		[Address(RVA = "0xA4C730", Offset = "0xA4B930", VA = "0x180A4C730", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000F7E")]
	[CompilerGenerated]
	private sealed class _003CyDownload_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A85C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A85D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A85E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DownloadController _003C_003E4__this;

		[Token(Token = "0x400A85F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass44_0 _003C_003E8__1;

		[Token(Token = "0x400A860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass44_2 _003C_003E8__2;

		[Token(Token = "0x400A861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass44_1 _003C_003E8__3;

		[Token(Token = "0x400A862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass44_3 _003C_003E8__4;

		[Token(Token = "0x400A863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<DownloadData>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x400A864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TaskWebRequest _003Crequest_003E5__3;

		[Token(Token = "0x400A865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Task _003Ctask_003E5__4;

		[Token(Token = "0x400A866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _003Ci_003E5__5;

		[Token(Token = "0x17000EC9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005DF8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000ECA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005DFA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005DF4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyDownload_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005DF5")]
		[Address(RVA = "0xA4DE20", Offset = "0xA4D020", VA = "0x180A4DE20", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005DF6")]
		[Address(RVA = "0xA4C770", Offset = "0xA4B970", VA = "0x180A4C770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005DF7")]
		[Address(RVA = "0xA4DEB0", Offset = "0xA4D0B0", VA = "0x180A4DEB0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6005DF9")]
		[Address(RVA = "0xA4DDE0", Offset = "0xA4CFE0", VA = "0x180A4DDE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public DownloadStep m_step;

	[Token(Token = "0x400A82A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private EventHandler downloadCompleteHandler;

	[Token(Token = "0x400A82B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private EventHandler downloadErrorHandler;

	[Token(Token = "0x400A82C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private EventHandler downloadProgressStartHandler;

	[Token(Token = "0x400A82D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private StepHandler stepHandler;

	[Token(Token = "0x400A82E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int completeNum;

	[Token(Token = "0x400A82F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int requestEndNum;

	[Token(Token = "0x400A830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private long m_totalSize;

	[Token(Token = "0x400A831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private long m_requestEndSize;

	[Token(Token = "0x400A832")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private long m_compSize;

	[Token(Token = "0x400A833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<DownloadData> m_dataList;

	[Token(Token = "0x400A834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<DLCList> m_targetList;

	[Token(Token = "0x400A835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private DLCList m_downloadList;

	[Token(Token = "0x400A836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private DLCList m_compList;

	[Token(Token = "0x400A837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private DLCList m_local;

	[Token(Token = "0x400A838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private IEnumerator downloadCoroutine;

	[Token(Token = "0x400A839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool bAppQuitAbort;

	[Token(Token = "0x400A83A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Action abortCallback;

	[Token(Token = "0x17000EC0")]
	public DownloadStep step
	{
		[Token(Token = "0x6005DB0")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		get
		{
			return default(DownloadStep);
		}
		[Token(Token = "0x6005DB1")]
		[Address(RVA = "0xA45A70", Offset = "0xA44C70", VA = "0x180A45A70")]
		private set
		{
		}
	}

	[Token(Token = "0x17000EC1")]
	public float TotalProgress
	{
		[Token(Token = "0x6005DB7")]
		[Address(RVA = "0xA45A30", Offset = "0xA44C30", VA = "0x180A45A30")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000EC2")]
	public int TotalNum
	{
		[Token(Token = "0x6005DB8")]
		[Address(RVA = "0x3DDD20", Offset = "0x3DCF20", VA = "0x1803DDD20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005DB9")]
		[Address(RVA = "0x62DFF0", Offset = "0x62D1F0", VA = "0x18062DFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000EC3")]
	public int CompleteNum
	{
		[Token(Token = "0x6005DBA")]
		[Address(RVA = "0xA45A20", Offset = "0xA44C20", VA = "0x180A45A20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000EC4")]
	public long TotalSize
	{
		[Token(Token = "0x6005DBB")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x6005DB2")]
	[Address(RVA = "0xA455C0", Offset = "0xA447C0", VA = "0x180A455C0")]
	public void SetStepHandler(StepHandler handler)
	{
	}

	[Token(Token = "0x6005DB3")]
	[Address(RVA = "0xA45430", Offset = "0xA44630", VA = "0x180A45430")]
	public void ReleaseStepHandler(StepHandler handler)
	{
	}

	[Token(Token = "0x6005DB4")]
	[Address(RVA = "0xA454D0", Offset = "0xA446D0", VA = "0x180A454D0")]
	public void RequestAppQuitAbort(Action callback)
	{
	}

	[Token(Token = "0x6005DB5")]
	[Address(RVA = "0xA44D80", Offset = "0xA43F80", VA = "0x180A44D80")]
	private void DownloadCompleteEvent()
	{
	}

	[Token(Token = "0x6005DB6")]
	[Address(RVA = "0xA44E30", Offset = "0xA44030", VA = "0x180A44E30")]
	private void DownloadErrorEvent()
	{
	}

	[Token(Token = "0x6005DBC")]
	[Address(RVA = "0x51D0F0", Offset = "0x51C2F0", VA = "0x18051D0F0")]
	public void ShowLoading()
	{
	}

	[Token(Token = "0x6005DBD")]
	[Address(RVA = "0x51E010", Offset = "0x51D210", VA = "0x18051E010")]
	public void HideLoading()
	{
	}

	[Token(Token = "0x6005DBE")]
	[Address(RVA = "0xA45660", Offset = "0xA44860", VA = "0x180A45660")]
	public void StartDownload(EventHandler complete, EventHandler error, [Optional] EventHandler startHandler)
	{
	}

	[Token(Token = "0x6005DBF")]
	[Address(RVA = "0xA45360", Offset = "0xA44560", VA = "0x180A45360")]
	public void RefreshCache()
	{
	}

	[Token(Token = "0x6005DC0")]
	[Address(RVA = "0xA44CB0", Offset = "0xA43EB0", VA = "0x180A44CB0")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6005DC1")]
	[Address(RVA = "0xA45B00", Offset = "0xA44D00", VA = "0x180A45B00")]
	[IteratorStateMachine(typeof(_003CyDownload_003Ed__44))]
	private IEnumerator yDownload()
	{
		return null;
	}

	[Token(Token = "0x6005DC2")]
	[Address(RVA = "0xA45A90", Offset = "0xA44C90", VA = "0x180A45A90")]
	[IteratorStateMachine(typeof(_003CyDeleteUnusedData_003Ed__45))]
	private IEnumerator yDeleteUnusedData()
	{
		return null;
	}

	[Token(Token = "0x6005DC3")]
	[Address(RVA = "0xA44E90", Offset = "0xA44090", VA = "0x180A44E90")]
	[IteratorStateMachine(typeof(_003CDownloadItem_003Ed__46))]
	private IEnumerator DownloadItem(string baseUrl, DLCList target, Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6005DC4")]
	[Address(RVA = "0xA45500", Offset = "0xA44700", VA = "0x180A45500")]
	private void SendComplete()
	{
	}

	[Token(Token = "0x6005DC5")]
	[Address(RVA = "0xA44F50", Offset = "0xA44150", VA = "0x180A44F50")]
	private void OpenAlertDialog(string message, Action callbackTitle, Action callbackRetry)
	{
	}

	[Token(Token = "0x6005DC6")]
	[Address(RVA = "0xA459A0", Offset = "0xA44BA0", VA = "0x180A459A0")]
	public DownloadController()
	{
	}
}
