using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Threading;

namespace Il2CppInternal.Runtime.Augments;

public sealed class RuntimeThread : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_OptimalMaxSpinWaitsPerSpinIteration;

	private static readonly System.IntPtr NativeFieldInfoPtr_thread;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Thread_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_RuntimeThread_ParameterizedThreadStart_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Yield_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SpinWait_Public_Static_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentProcessorId_Public_Static_Int32_0;

	public unsafe static int OptimalMaxSpinWaitsPerSpinIteration
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OptimalMaxSpinWaitsPerSpinIteration, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OptimalMaxSpinWaitsPerSpinIteration, (void*)(&value));
		}
	}

	public unsafe Thread thread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Thread>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_thread)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool IsBackground
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 701235, RefRangeEnd = 701236, XrefRangeStart = 701233, XrefRangeEnd = 701235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static RuntimeThread()
	{
		Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Internal.Runtime.Augments", "RuntimeThread");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr);
		NativeFieldInfoPtr_OptimalMaxSpinWaitsPerSpinIteration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, "OptimalMaxSpinWaitsPerSpinIteration");
		NativeFieldInfoPtr_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, "thread");
		NativeMethodInfoPtr__ctor_Private_Void_Thread_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663867);
		NativeMethodInfoPtr_Create_Public_Static_RuntimeThread_ParameterizedThreadStart_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663868);
		NativeMethodInfoPtr_set_IsBackground_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663869);
		NativeMethodInfoPtr_Start_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663870);
		NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663871);
		NativeMethodInfoPtr_Yield_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663872);
		NativeMethodInfoPtr_SpinWait_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663873);
		NativeMethodInfoPtr_GetCurrentProcessorId_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr, 100663874);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RuntimeThread(Thread t)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeThread>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Thread_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701232, RefRangeEnd = 701233, XrefRangeStart = 701223, XrefRangeEnd = 701232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxStackSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_RuntimeThread_ParameterizedThreadStart_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RuntimeThread>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701238, RefRangeEnd = 701239, XrefRangeStart = 701236, XrefRangeEnd = 701238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start(Il2CppSystem.Object state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701240, RefRangeEnd = 701241, XrefRangeStart = 701239, XrefRangeEnd = 701240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Sleep(int millisecondsTimeout)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&millisecondsTimeout);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sleep_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701244, RefRangeEnd = 701245, XrefRangeStart = 701241, XrefRangeEnd = 701244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Yield()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Yield_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 701246, RefRangeEnd = 701247, XrefRangeStart = 701245, XrefRangeEnd = 701246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool SpinWait(int iterations)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&iterations);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SpinWait_Public_Static_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 63528, RefRangeEnd = 63535, XrefRangeStart = 63528, XrefRangeEnd = 63535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCurrentProcessorId()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCurrentProcessorId_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public RuntimeThread(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
