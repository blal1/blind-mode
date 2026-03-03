using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class CrashReport
{
	private delegate System.IntPtr GetReportsDelegate();

	private delegate void GetReportData_InjectedDelegate(System.IntPtr id, [Out] System.IntPtr secondsSinceUnixEpoch, [Out] System.IntPtr ret);

	private delegate bool RemoveReport_InjectedDelegate(System.IntPtr id);

	private static readonly GetReportsDelegate GetReportsDelegateField = IL2CPP.ResolveICall<GetReportsDelegate>("UnityEngine.CrashReport::GetReports");

	private static readonly GetReportData_InjectedDelegate GetReportData_InjectedDelegateField = IL2CPP.ResolveICall<GetReportData_InjectedDelegate>("UnityEngine.CrashReport::GetReportData_Injected");

	private static readonly RemoveReport_InjectedDelegate RemoveReport_InjectedDelegateField = IL2CPP.ResolveICall<RemoveReport_InjectedDelegate>("UnityEngine.CrashReport::RemoveReport_Injected");

	public static Il2CppReferenceArray<CrashReport> reports
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static CrashReport lastReport
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public static int Compare(CrashReport c1, CrashReport c2)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void PopulateReports()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void RemoveAll()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Remove()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppStringArray GetReports()
	{
		System.IntPtr intPtr = GetReportsDelegateField();
		return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
	}

	public unsafe static string GetReportData(string id, out double secondsSinceUnixEpoch)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(id, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(id);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetReportData_Injected(ref managedSpanWrapper, out secondsSinceUnixEpoch, out ret);
				}
			}
			else
			{
				GetReportData_Injected(ref managedSpanWrapper, out secondsSinceUnixEpoch, out ret);
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static bool RemoveReport(string id)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(id, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(id);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return RemoveReport_Injected(ref managedSpanWrapper);
				}
			}
			return RemoveReport_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void GetReportData_Injected(ref ManagedSpanWrapper id, out double secondsSinceUnixEpoch, out ManagedSpanWrapper ret)
	{
		GetReportData_InjectedDelegateField((nint)Unsafe.AsPointer(ref id), (nint)Unsafe.AsPointer(ref secondsSinceUnixEpoch), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool RemoveReport_Injected(ref ManagedSpanWrapper id)
	{
		return RemoveReport_InjectedDelegateField((nint)Unsafe.AsPointer(ref id));
	}
}
