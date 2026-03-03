using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public sealed class RegisteredWaitHandle : MarshalByRefObject
{
	private static readonly System.IntPtr NativeFieldInfoPtr__waitObject;

	private static readonly System.IntPtr NativeFieldInfoPtr__callback;

	private static readonly System.IntPtr NativeFieldInfoPtr__state;

	private static readonly System.IntPtr NativeFieldInfoPtr__finalEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__cancelEvent;

	private static readonly System.IntPtr NativeFieldInfoPtr__timeout;

	private static readonly System.IntPtr NativeFieldInfoPtr__callsInProcess;

	private static readonly System.IntPtr NativeFieldInfoPtr__executeOnlyOnce;

	private static readonly System.IntPtr NativeFieldInfoPtr__unregistered;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Wait_Internal_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0;

	public unsafe WaitHandle _waitObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__waitObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__waitObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe WaitOrTimerCallback _callback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__callback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WaitOrTimerCallback>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__callback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object _state
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__state)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe WaitHandle _finalEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__finalEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__finalEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ManualResetEvent _cancelEvent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cancelEvent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__cancelEvent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe TimeSpan _timeout
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__timeout);
			return *(TimeSpan*)num;
		}
		set
		{
			*(TimeSpan*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__timeout)) = value;
		}
	}

	public unsafe int _callsInProcess
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__callsInProcess);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__callsInProcess)) = value;
		}
	}

	public unsafe bool _executeOnlyOnce
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__executeOnlyOnce);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__executeOnlyOnce)) = value;
		}
	}

	public unsafe bool _unregistered
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__unregistered);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__unregistered)) = value;
		}
	}

	static RegisteredWaitHandle()
	{
		Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "RegisteredWaitHandle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr);
		NativeFieldInfoPtr__waitObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_waitObject");
		NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_callback");
		NativeFieldInfoPtr__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_state");
		NativeFieldInfoPtr__finalEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_finalEvent");
		NativeFieldInfoPtr__cancelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_cancelEvent");
		NativeFieldInfoPtr__timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_timeout");
		NativeFieldInfoPtr__callsInProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_callsInProcess");
		NativeFieldInfoPtr__executeOnlyOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_executeOnlyOnce");
		NativeFieldInfoPtr__unregistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, "_unregistered");
		NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100668056);
		NativeMethodInfoPtr_Wait_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100668057);
		NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr, 100668058);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 772286, RefRangeEnd = 772288, XrefRangeStart = 772276, XrefRangeEnd = 772286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, Object state, TimeSpan timeout, bool executeOnlyOnce)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisteredWaitHandle>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)waitObject);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(TimeSpan**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &timeout;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &executeOnlyOnce;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772288, XrefRangeEnd = 772328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Wait(Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Wait_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 772328, XrefRangeEnd = 772333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DoCallBack(Object timedOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)timedOut);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoCallBack_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RegisteredWaitHandle(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
