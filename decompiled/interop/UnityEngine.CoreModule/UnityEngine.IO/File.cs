using Il2CppInterop.Runtime;

namespace UnityEngine.IO;

public static class File
{
	private delegate void SetRecordZeroSeeksDelegate(bool enable);

	private delegate bool GetRecordZeroSeeksDelegate();

	private delegate ulong GetTotalOpenCallsDelegate();

	private delegate ulong GetTotalCloseCallsDelegate();

	private delegate ulong GetTotalReadCallsDelegate();

	private delegate ulong GetTotalWriteCallsDelegate();

	private delegate ulong GetTotalSeekCallsDelegate();

	private delegate ulong GetTotalZeroSeekCallsDelegate();

	private delegate ulong GetTotalFilesOpenedDelegate();

	private delegate ulong GetTotalFilesClosedDelegate();

	private delegate ulong GetTotalBytesReadDelegate();

	private delegate ulong GetTotalBytesWrittenDelegate();

	private delegate void SetMainThreadFileIORestrictionDelegate(ThreadIORestrictionMode mode);

	private delegate ThreadIORestrictionMode GetMainThreadFileIORestrictionDelegate();

	private static readonly SetRecordZeroSeeksDelegate SetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<SetRecordZeroSeeksDelegate>("UnityEngine.IO.File::SetRecordZeroSeeks");

	private static readonly GetRecordZeroSeeksDelegate GetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<GetRecordZeroSeeksDelegate>("UnityEngine.IO.File::GetRecordZeroSeeks");

	private static readonly GetTotalOpenCallsDelegate GetTotalOpenCallsDelegateField = IL2CPP.ResolveICall<GetTotalOpenCallsDelegate>("UnityEngine.IO.File::GetTotalOpenCalls");

	private static readonly GetTotalCloseCallsDelegate GetTotalCloseCallsDelegateField = IL2CPP.ResolveICall<GetTotalCloseCallsDelegate>("UnityEngine.IO.File::GetTotalCloseCalls");

	private static readonly GetTotalReadCallsDelegate GetTotalReadCallsDelegateField = IL2CPP.ResolveICall<GetTotalReadCallsDelegate>("UnityEngine.IO.File::GetTotalReadCalls");

	private static readonly GetTotalWriteCallsDelegate GetTotalWriteCallsDelegateField = IL2CPP.ResolveICall<GetTotalWriteCallsDelegate>("UnityEngine.IO.File::GetTotalWriteCalls");

	private static readonly GetTotalSeekCallsDelegate GetTotalSeekCallsDelegateField = IL2CPP.ResolveICall<GetTotalSeekCallsDelegate>("UnityEngine.IO.File::GetTotalSeekCalls");

	private static readonly GetTotalZeroSeekCallsDelegate GetTotalZeroSeekCallsDelegateField = IL2CPP.ResolveICall<GetTotalZeroSeekCallsDelegate>("UnityEngine.IO.File::GetTotalZeroSeekCalls");

	private static readonly GetTotalFilesOpenedDelegate GetTotalFilesOpenedDelegateField = IL2CPP.ResolveICall<GetTotalFilesOpenedDelegate>("UnityEngine.IO.File::GetTotalFilesOpened");

	private static readonly GetTotalFilesClosedDelegate GetTotalFilesClosedDelegateField = IL2CPP.ResolveICall<GetTotalFilesClosedDelegate>("UnityEngine.IO.File::GetTotalFilesClosed");

	private static readonly GetTotalBytesReadDelegate GetTotalBytesReadDelegateField = IL2CPP.ResolveICall<GetTotalBytesReadDelegate>("UnityEngine.IO.File::GetTotalBytesRead");

	private static readonly GetTotalBytesWrittenDelegate GetTotalBytesWrittenDelegateField = IL2CPP.ResolveICall<GetTotalBytesWrittenDelegate>("UnityEngine.IO.File::GetTotalBytesWritten");

	private static readonly SetMainThreadFileIORestrictionDelegate SetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<SetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::SetMainThreadFileIORestriction");

	private static readonly GetMainThreadFileIORestrictionDelegate GetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<GetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::GetMainThreadFileIORestriction");

	public static ulong totalOpenCalls => GetTotalOpenCalls();

	public static ulong totalCloseCalls => GetTotalCloseCalls();

	public static ulong totalReadCalls => GetTotalReadCalls();

	public static ulong totalWriteCalls => GetTotalWriteCalls();

	public static ulong totalSeekCalls => GetTotalSeekCalls();

	public static ulong totalZeroSeekCalls => GetTotalZeroSeekCalls();

	public static ulong totalFilesOpened => GetTotalFilesOpened();

	public static ulong totalFilesClosed => GetTotalFilesClosed();

	public static ulong totalBytesRead => GetTotalBytesRead();

	public static ulong totalBytesWritten => GetTotalBytesWritten();

	public static bool recordZeroSeeks
	{
		get
		{
			return GetRecordZeroSeeks();
		}
		set
		{
			SetRecordZeroSeeks(value);
		}
	}

	public static ThreadIORestrictionMode MainThreadIORestrictionMode
	{
		get
		{
			return GetMainThreadFileIORestriction();
		}
		set
		{
			SetMainThreadFileIORestriction(value);
		}
	}

	public static void SetRecordZeroSeeks(bool enable)
	{
		SetRecordZeroSeeksDelegateField(enable);
	}

	public static bool GetRecordZeroSeeks()
	{
		return GetRecordZeroSeeksDelegateField();
	}

	public static ulong GetTotalOpenCalls()
	{
		return GetTotalOpenCallsDelegateField();
	}

	public static ulong GetTotalCloseCalls()
	{
		return GetTotalCloseCallsDelegateField();
	}

	public static ulong GetTotalReadCalls()
	{
		return GetTotalReadCallsDelegateField();
	}

	public static ulong GetTotalWriteCalls()
	{
		return GetTotalWriteCallsDelegateField();
	}

	public static ulong GetTotalSeekCalls()
	{
		return GetTotalSeekCallsDelegateField();
	}

	public static ulong GetTotalZeroSeekCalls()
	{
		return GetTotalZeroSeekCallsDelegateField();
	}

	public static ulong GetTotalFilesOpened()
	{
		return GetTotalFilesOpenedDelegateField();
	}

	public static ulong GetTotalFilesClosed()
	{
		return GetTotalFilesClosedDelegateField();
	}

	public static ulong GetTotalBytesRead()
	{
		return GetTotalBytesReadDelegateField();
	}

	public static ulong GetTotalBytesWritten()
	{
		return GetTotalBytesWrittenDelegateField();
	}

	public static void SetMainThreadFileIORestriction(ThreadIORestrictionMode mode)
	{
		SetMainThreadFileIORestrictionDelegateField(mode);
	}

	public static ThreadIORestrictionMode GetMainThreadFileIORestriction()
	{
		return GetMainThreadFileIORestrictionDelegateField();
	}
}
