using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks;

public sealed class ContinuationTaskFromTask : Task
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_antecedent;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0;

	public unsafe Task m_antecedent
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_antecedent);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Task>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_antecedent)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ContinuationTaskFromTask()
	{
		Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ContinuationTaskFromTask");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr);
		NativeFieldInfoPtr_m_antecedent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, "m_antecedent");
		NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, 100668372);
		NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr, 100668373);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775527, XrefRangeEnd = 775541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ContinuationTaskFromTask(Task antecedent, Delegate action, Object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinuationTaskFromTask>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)antecedent);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(TaskCreationOptions**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &creationOptions;
		*(InternalTaskOptions**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &internalOptions;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Task_Delegate_Object_TaskCreationOptions_InternalTaskOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 775541, XrefRangeEnd = 775550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void InnerInvoke()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ContinuationTaskFromTask(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
