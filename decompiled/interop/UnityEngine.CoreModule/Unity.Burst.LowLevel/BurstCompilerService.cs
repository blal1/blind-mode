using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.Burst.LowLevel;

public static class BurstCompilerService : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "BurstLogType")]
	public enum BurstLogType
	{
		Info,
		Warning,
		Error
	}

	private delegate bool get_IsInitializedDelegate();

	private delegate void SetCurrentExecutionModeDelegate(uint environment);

	private delegate uint GetCurrentExecutionModeDelegate();

	private delegate void GetDisassembly_InjectedDelegate(System.IntPtr m, System.IntPtr compilerOptions, [Out] System.IntPtr ret);

	private delegate void GetMethodSignature_InjectedDelegate(System.IntPtr method, [Out] System.IntPtr ret);

	private delegate bool LoadBurstLibrary_InjectedDelegate(System.IntPtr fullPathToLibBurstGenerated);

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CompileAsyncDelegateMethod_Injected_Private_Static_Int32_Object_byref_ManagedSpanWrapper_0;

	private static readonly get_IsInitializedDelegate get_IsInitializedDelegateField;

	private static readonly SetCurrentExecutionModeDelegate SetCurrentExecutionModeDelegateField;

	private static readonly GetCurrentExecutionModeDelegate GetCurrentExecutionModeDelegateField;

	private static readonly GetDisassembly_InjectedDelegate GetDisassembly_InjectedDelegateField;

	private static readonly GetMethodSignature_InjectedDelegate GetMethodSignature_InjectedDelegateField;

	private static readonly LoadBurstLibrary_InjectedDelegate LoadBurstLibrary_InjectedDelegateField;

	public static bool IsInitialized => get_IsInitializedDelegateField();

	static BurstCompilerService()
	{
		Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Burst.LowLevel", "BurstCompilerService");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr);
		NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663672);
		NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663673);
		NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663674);
		NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663675);
		NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663676);
		NativeMethodInfoPtr_CompileAsyncDelegateMethod_Injected_Private_Static_Int32_Object_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663677);
		get_IsInitializedDelegateField = IL2CPP.ResolveICall<get_IsInitializedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::get_IsInitialized");
		SetCurrentExecutionModeDelegateField = IL2CPP.ResolveICall<SetCurrentExecutionModeDelegate>("Unity.Burst.LowLevel.BurstCompilerService::SetCurrentExecutionMode");
		GetCurrentExecutionModeDelegateField = IL2CPP.ResolveICall<GetCurrentExecutionModeDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetCurrentExecutionMode");
		GetDisassembly_InjectedDelegateField = IL2CPP.ResolveICall<GetDisassembly_InjectedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetDisassembly_Injected");
		GetMethodSignature_InjectedDelegateField = IL2CPP.ResolveICall<GetMethodSignature_InjectedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetMethodSignature_Injected");
		LoadBurstLibrary_InjectedDelegateField = IL2CPP.ResolveICall<LoadBurstLibrary_InjectedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::LoadBurstLibrary_Injected");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1166469, RefRangeEnd = 1166471, XrefRangeStart = 1166455, XrefRangeEnd = 1166469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompileAsyncDelegateMethod(Il2CppSystem.Object delegateMethod, string compilerOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)delegateMethod);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(compilerOptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1166473, RefRangeEnd = 1166475, XrefRangeStart = 1166471, XrefRangeEnd = 1166473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* GetAsyncCompiledAsyncDelegateMethod(int userID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&userID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166477, RefRangeEnd = 1166478, XrefRangeStart = 1166475, XrefRangeEnd = 1166477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref key);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size_of;
		*(uint**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignment;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166480, RefRangeEnd = 1166481, XrefRangeStart = 1166478, XrefRangeEnd = 1166480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Log(void* userData, BurstLogType logType, byte* message, byte* filename, int lineNumber)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)userData;
		*(BurstLogType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &logType;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = message;
		*(byte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = filename;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineNumber;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166483, RefRangeEnd = 1166484, XrefRangeStart = 1166481, XrefRangeEnd = 1166483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RuntimeLog(void* userData, BurstLogType logType, byte* message, byte* filename, int lineNumber)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)userData;
		*(BurstLogType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &logType;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = message;
		*(byte**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = filename;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &lineNumber;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166484, XrefRangeEnd = 1166486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CompileAsyncDelegateMethod_Injected(Il2CppSystem.Object delegateMethod, ref ManagedSpanWrapper compilerOptions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)delegateMethod);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref compilerOptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CompileAsyncDelegateMethod_Injected_Private_Static_Int32_Object_byref_ManagedSpanWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public BurstCompilerService(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static string GetDisassembly(MethodInfo m, string compilerOptions)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(compilerOptions, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(compilerOptions);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					GetDisassembly_Injected(m, ref managedSpanWrapper, out ret);
				}
			}
			else
			{
				GetDisassembly_Injected(m, ref managedSpanWrapper, out ret);
			}
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static string GetMethodSignature(MethodInfo method)
	{
		Unsafe.SkipInit(out ManagedSpanWrapper ret);
		string stringAndDispose;
		try
		{
			GetMethodSignature_Injected(method, out ret);
		}
		finally
		{
			stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
		}
		return stringAndDispose;
	}

	public static void SetCurrentExecutionMode(uint environment)
	{
		SetCurrentExecutionModeDelegateField(environment);
	}

	public static uint GetCurrentExecutionMode()
	{
		return GetCurrentExecutionModeDelegateField();
	}

	public unsafe static bool LoadBurstLibrary(string fullPathToLibBurstGenerated)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//The blocks IL_0029 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(fullPathToLibBurstGenerated, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(fullPathToLibBurstGenerated);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					return LoadBurstLibrary_Injected(ref managedSpanWrapper);
				}
			}
			return LoadBurstLibrary_Injected(ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void GetDisassembly_Injected(MethodInfo m, ref ManagedSpanWrapper compilerOptions, out ManagedSpanWrapper ret)
	{
		GetDisassembly_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)m), (nint)Unsafe.AsPointer(ref compilerOptions), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetMethodSignature_Injected(MethodInfo method, out ManagedSpanWrapper ret)
	{
		GetMethodSignature_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)method), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static bool LoadBurstLibrary_Injected(ref ManagedSpanWrapper fullPathToLibBurstGenerated)
	{
		return LoadBurstLibrary_InjectedDelegateField((nint)Unsafe.AsPointer(ref fullPathToLibBurstGenerated));
	}
}
