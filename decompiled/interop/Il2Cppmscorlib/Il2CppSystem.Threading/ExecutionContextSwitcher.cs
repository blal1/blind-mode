using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public sealed class ExecutionContextSwitcher : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_outerEC;

	private static readonly System.IntPtr NativeFieldInfoPtr_outerECBelongsToScope;

	private static readonly System.IntPtr NativeFieldInfoPtr_hecsw;

	private static readonly System.IntPtr NativeFieldInfoPtr_thread;

	private static readonly System.IntPtr NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Undo_Internal_Void_0;

	public unsafe ExecutionContext.Reader outerEC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outerEC);
			return new ExecutionContext.Reader(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outerEC), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ExecutionContext.Reader>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool outerECBelongsToScope
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outerECBelongsToScope);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_outerECBelongsToScope)) = value;
		}
	}

	public unsafe Object hecsw
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hecsw);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hecsw)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	static ExecutionContextSwitcher()
	{
		Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ExecutionContextSwitcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr);
		NativeFieldInfoPtr_outerEC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "outerEC");
		NativeFieldInfoPtr_outerECBelongsToScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "outerECBelongsToScope");
		NativeFieldInfoPtr_hecsw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "hecsw");
		NativeFieldInfoPtr_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, "thread");
		NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, 100667761);
		NativeMethodInfoPtr_Undo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr, 100667762);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768711, XrefRangeEnd = 768712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UndoNoThrow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UndoNoThrow_Internal_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 768719, RefRangeEnd = 768730, XrefRangeStart = 768712, XrefRangeEnd = 768719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Undo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Undo_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ExecutionContextSwitcher(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ExecutionContextSwitcher()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionContextSwitcher>.NativeClassPtr))
	{
	}
}
