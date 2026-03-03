using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.ExceptionServices;

public sealed class ExceptionDispatchInfo : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Exception;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_stackTrace;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Throw_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Throw_Public_Static_Void_Exception_0;

	public unsafe Exception m_Exception
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Exception);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Exception)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object m_stackTrace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_stackTrace);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_stackTrace)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object BinaryStackTraceArray
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
	}

	public unsafe Exception SourceException
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
		}
	}

	static ExceptionDispatchInfo()
	{
		Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.ExceptionServices", "ExceptionDispatchInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr);
		NativeFieldInfoPtr_m_Exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, "m_Exception");
		NativeFieldInfoPtr_m_stackTrace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, "m_stackTrace");
		NativeMethodInfoPtr__ctor_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671352);
		NativeMethodInfoPtr_get_BinaryStackTraceArray_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671353);
		NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671354);
		NativeMethodInfoPtr_get_SourceException_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671355);
		NativeMethodInfoPtr_Throw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671356);
		NativeMethodInfoPtr_Throw_Public_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr, 100671357);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805384, XrefRangeEnd = 805403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ExceptionDispatchInfo(Exception exception)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExceptionDispatchInfo>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)exception);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 805421, RefRangeEnd = 805441, XrefRangeStart = 805403, XrefRangeEnd = 805421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ExceptionDispatchInfo Capture(Exception source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Capture_Public_Static_ExceptionDispatchInfo_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
	}

	[CallerCount(28)]
	[CachedScanResults(RefRangeStart = 805445, RefRangeEnd = 805473, XrefRangeStart = 805441, XrefRangeEnd = 805445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Throw()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Throw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 805476, RefRangeEnd = 805484, XrefRangeStart = 805473, XrefRangeEnd = 805476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Throw(Exception source)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Throw_Public_Static_Void_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ExceptionDispatchInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
