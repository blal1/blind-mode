using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public class ThreadHelper : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__start;

	private static readonly System.IntPtr NativeFieldInfoPtr__startArg;

	private static readonly System.IntPtr NativeFieldInfoPtr__executionContext;

	private static readonly System.IntPtr NativeFieldInfoPtr__ccb;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ThreadStart_Internal_Void_0;

	public unsafe Delegate _start
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__start);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Delegate>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__start)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object _startArg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startArg);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__startArg)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ExecutionContext _executionContext
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__executionContext);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__executionContext)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ContextCallback _ccb
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__ccb, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__ccb, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ThreadHelper()
	{
		Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr);
		NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_start");
		NativeFieldInfoPtr__startArg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_startArg");
		NativeFieldInfoPtr__executionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_executionContext");
		NativeFieldInfoPtr__ccb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, "_ccb");
		NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100667856);
		NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100667857);
		NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100667858);
		NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100667859);
		NativeMethodInfoPtr_ThreadStart_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr, 100667860);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ThreadHelper(Delegate start)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadHelper>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)start);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 32149, RefRangeEnd = 32159, XrefRangeStart = 32149, XrefRangeEnd = 32159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExecutionContextHelper(ExecutionContext ec)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ec);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetExecutionContextHelper_Internal_Void_ExecutionContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770580, XrefRangeEnd = 770590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ThreadStart_Context(Object state)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThreadStart_Context_Private_Static_Void_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770590, XrefRangeEnd = 770603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ThreadStart(Object obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThreadStart_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770603, XrefRangeEnd = 770625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ThreadStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ThreadStart_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ThreadHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
