using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks;

public static class AsyncCausalityTracer : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0;

	public unsafe static bool LoggingOn
	{
		[CallerCount(143)]
		[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static AsyncCausalityTracer()
	{
		Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "AsyncCausalityTracer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr);
		NativeMethodInfoPtr_get_LoggingOn_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100668461);
		NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100668462);
		NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100668463);
		NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100668464);
		NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncCausalityTracer>.NativeClassPtr, 100668465);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&traceLevel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &taskId;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(operationName);
		*(ulong**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &relatedContext;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraceOperationCreation_Internal_Static_Void_CausalityTraceLevel_Int32_String_UInt64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&traceLevel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &taskId;
		*(AsyncCausalityStatus**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &status;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraceOperationCompletion_Internal_Static_Void_CausalityTraceLevel_Int32_AsyncCausalityStatus_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&traceLevel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &taskId;
		*(CausalitySynchronousWork**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &work;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraceSynchronousWorkStart_Internal_Static_Void_CausalityTraceLevel_Int32_CausalitySynchronousWork_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&traceLevel);
		*(CausalitySynchronousWork**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &work;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TraceSynchronousWorkCompletion_Internal_Static_Void_CausalityTraceLevel_CausalitySynchronousWork_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AsyncCausalityTracer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
