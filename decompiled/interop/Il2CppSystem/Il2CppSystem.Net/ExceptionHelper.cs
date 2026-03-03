using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public static class ExceptionHelper : Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeoutException_Internal_Static_get_WebException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0;

	public unsafe static NotImplementedException MethodNotImplementedException
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 887736, RefRangeEnd = 887743, XrefRangeStart = 887729, XrefRangeEnd = 887736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NotImplementedException>(intPtr2) : null;
		}
	}

	public unsafe static NotImplementedException PropertyNotImplementedException
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 887750, RefRangeEnd = 887764, XrefRangeStart = 887743, XrefRangeEnd = 887750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NotImplementedException>(intPtr2) : null;
		}
	}

	public unsafe static WebException TimeoutException
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887764, XrefRangeEnd = 887770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_TimeoutException_Internal_Static_get_WebException_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<WebException>(intPtr2) : null;
		}
	}

	public unsafe static NotSupportedException PropertyNotSupportedException
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 887777, RefRangeEnd = 887779, XrefRangeStart = 887770, XrefRangeEnd = 887777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<NotSupportedException>(intPtr2) : null;
		}
	}

	public unsafe static WebException RequestAbortedException
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 887786, RefRangeEnd = 887790, XrefRangeStart = 887779, XrefRangeEnd = 887786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<WebException>(intPtr2) : null;
		}
	}

	static ExceptionHelper()
	{
		Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ExceptionHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr);
		NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100666147);
		NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100666148);
		NativeMethodInfoPtr_get_TimeoutException_Internal_Static_get_WebException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100666149);
		NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100666150);
		NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100666151);
	}

	public ExceptionHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
