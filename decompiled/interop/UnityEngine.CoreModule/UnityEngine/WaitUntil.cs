using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public sealed class WaitUntil : CustomYieldInstruction
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Predicate;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeoutCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeoutMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxExecutionTime;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTime_Private_Double_0;

	public unsafe Il2CppSystem.Func<bool> m_Predicate
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Predicate);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Predicate)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action m_TimeoutCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TimeoutCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TimeoutCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe WaitTimeoutMode m_TimeoutMode
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TimeoutMode);
			return *(WaitTimeoutMode*)num;
		}
		set
		{
			*(WaitTimeoutMode*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TimeoutMode)) = value;
		}
	}

	public unsafe double m_MaxExecutionTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxExecutionTime);
			return *(double*)num;
		}
		set
		{
			*(double*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_MaxExecutionTime)) = value;
		}
	}

	public unsafe override bool keepWaiting
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215167, XrefRangeEnd = 1215173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static WaitUntil()
	{
		Il2CppClassPointerStore<WaitUntil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "WaitUntil");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr);
		NativeFieldInfoPtr_m_Predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, "m_Predicate");
		NativeFieldInfoPtr_m_TimeoutCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, "m_TimeoutCallback");
		NativeFieldInfoPtr_m_TimeoutMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, "m_TimeoutMode");
		NativeFieldInfoPtr_m_MaxExecutionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, "m_MaxExecutionTime");
		NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100666588);
		NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100666589);
		NativeMethodInfoPtr_GetTime_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100666590);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 1215175, RefRangeEnd = 1215199, XrefRangeStart = 1215173, XrefRangeEnd = 1215175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WaitUntil(Il2CppSystem.Func<bool> predicate)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215199, XrefRangeEnd = 1215201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe double GetTime()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTime_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(double*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public WaitUntil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
