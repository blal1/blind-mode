using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace Unity.IO.LowLevel.Unsafe;

public static class VirtualFileSystem
{
	private delegate bool GetLocalFileSystemName_InjectedDelegate(System.IntPtr vfsFileName, [Out] System.IntPtr localFileName, [Out] System.IntPtr localFileOffset, [Out] System.IntPtr localFileSize);

	private delegate void ToLogicalPath_InjectedDelegate(System.IntPtr physicalPath, [Out] System.IntPtr ret);

	private static readonly GetLocalFileSystemName_InjectedDelegate GetLocalFileSystemName_InjectedDelegateField = IL2CPP.ResolveICall<GetLocalFileSystemName_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.VirtualFileSystem::GetLocalFileSystemName_Injected");

	private static readonly ToLogicalPath_InjectedDelegate ToLogicalPath_InjectedDelegateField = IL2CPP.ResolveICall<ToLogicalPath_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.VirtualFileSystem::ToLogicalPath_Injected");

	public unsafe static bool GetLocalFileSystemName(string vfsFileName, out string localFileName, out ulong localFileOffset, out ulong localFileSize)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper localFileName2);
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(vfsFileName, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(vfsFileName);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return GetLocalFileSystemName_Injected(ref managedSpanWrapper, out localFileName2, out localFileOffset, out localFileSize);
				}
			}
			return GetLocalFileSystemName_Injected(ref managedSpanWrapper, out localFileName2, out localFileOffset, out localFileSize);
		}
		finally
		{
			localFileName = OutStringMarshaller.GetStringAndDispose(localFileName2);
		}
	}

	public unsafe static string ToLogicalPath(string physicalPath)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(physicalPath, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(physicalPath);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					ToLogicalPath_Injected(ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				ToLogicalPath_Injected(ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public unsafe static bool GetLocalFileSystemName_Injected(ref ManagedSpanWrapper vfsFileName, out ManagedSpanWrapper localFileName, out ulong localFileOffset, out ulong localFileSize)
	{
		return GetLocalFileSystemName_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref vfsFileName), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref localFileName), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref localFileOffset), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref localFileSize));
	}

	public unsafe static void ToLogicalPath_Injected(ref ManagedSpanWrapper physicalPath, out ManagedSpanWrapper ret)
	{
		ToLogicalPath_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref physicalPath), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref ret));
	}
}
