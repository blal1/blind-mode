using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Diagnostics;

public static class Utils
{
	private delegate void ForceCrashDelegate(ForcedCrashCategory crashCategory);

	private delegate void ValidateHeapDelegate();

	private delegate void NativeAssert_InjectedDelegate(System.IntPtr message);

	private delegate void NativeError_InjectedDelegate(System.IntPtr message);

	private delegate void NativeWarning_InjectedDelegate(System.IntPtr message);

	private static readonly ForceCrashDelegate ForceCrashDelegateField = IL2CPP.ResolveICall<ForceCrashDelegate>("UnityEngine.Diagnostics.Utils::ForceCrash");

	private static readonly ValidateHeapDelegate ValidateHeapDelegateField = IL2CPP.ResolveICall<ValidateHeapDelegate>("UnityEngine.Diagnostics.Utils::ValidateHeap");

	private static readonly NativeAssert_InjectedDelegate NativeAssert_InjectedDelegateField = IL2CPP.ResolveICall<NativeAssert_InjectedDelegate>("UnityEngine.Diagnostics.Utils::NativeAssert_Injected");

	private static readonly NativeError_InjectedDelegate NativeError_InjectedDelegateField = IL2CPP.ResolveICall<NativeError_InjectedDelegate>("UnityEngine.Diagnostics.Utils::NativeError_Injected");

	private static readonly NativeWarning_InjectedDelegate NativeWarning_InjectedDelegateField = IL2CPP.ResolveICall<NativeWarning_InjectedDelegate>("UnityEngine.Diagnostics.Utils::NativeWarning_Injected");

	public static void ForceCrash(ForcedCrashCategory crashCategory)
	{
		ForceCrashDelegateField(crashCategory);
	}

	public unsafe static void NativeAssert(string message)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(message, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(message);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					NativeAssert_Injected(ref managedSpanWrapper);
					return;
				}
			}
			NativeAssert_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void NativeError(string message)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(message, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(message);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					NativeError_Injected(ref managedSpanWrapper);
					return;
				}
			}
			NativeError_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void NativeWarning(string message)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(message, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(message);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					NativeWarning_Injected(ref managedSpanWrapper);
					return;
				}
			}
			NativeWarning_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public static void ValidateHeap()
	{
		ValidateHeapDelegateField();
	}

	public unsafe static void NativeAssert_Injected(ref ManagedSpanWrapper message)
	{
		NativeAssert_InjectedDelegateField((nint)Unsafe.AsPointer(ref message));
	}

	public unsafe static void NativeError_Injected(ref ManagedSpanWrapper message)
	{
		NativeError_InjectedDelegateField((nint)Unsafe.AsPointer(ref message));
	}

	public unsafe static void NativeWarning_Injected(ref ManagedSpanWrapper message)
	{
		NativeWarning_InjectedDelegateField((nint)Unsafe.AsPointer(ref message));
	}
}
