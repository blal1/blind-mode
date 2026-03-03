using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.InputSystem.Utilities;

public sealed class CallbackArray<TDelegate> : Il2CppSystem.ValueType where TDelegate : Il2CppSystem.Delegate
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_CannotMutateCallbacksArray;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Callbacks;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CallbacksToAdd;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CallbacksToRemove;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_TDelegate_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddCallback_Public_Void_TDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoveCallback_Public_Void_TDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LockForChanges_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnlockForChanges_Public_Void_0;

	public unsafe bool m_CannotMutateCallbacksArray
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CannotMutateCallbacksArray);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CannotMutateCallbacksArray)) = value;
		}
	}

	public unsafe InlinedArray<TDelegate> m_Callbacks
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Callbacks);
			return new InlinedArray<TDelegate>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<TDelegate>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Callbacks), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<TDelegate>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InlinedArray<TDelegate> m_CallbacksToAdd
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CallbacksToAdd);
			return new InlinedArray<TDelegate>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<TDelegate>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CallbacksToAdd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<TDelegate>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe InlinedArray<TDelegate> m_CallbacksToRemove
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CallbacksToRemove);
			return new InlinedArray<TDelegate>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InlinedArray<TDelegate>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CallbacksToRemove), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InlinedArray<TDelegate>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe int length
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_length_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe TDelegate this[int index]
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1016206, RefRangeEnd = 1016214, XrefRangeStart = 1016199, XrefRangeEnd = 1016206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&index);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_TDelegate_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.PointerToValueGeneric<TDelegate>(intPtr2, false, true);
		}
	}

	static CallbackArray()
	{
		Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "CallbackArray`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr);
		NativeFieldInfoPtr_m_CannotMutateCallbacksArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_CannotMutateCallbacksArray");
		NativeFieldInfoPtr_m_Callbacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_Callbacks");
		NativeFieldInfoPtr_m_CallbacksToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_CallbacksToAdd");
		NativeFieldInfoPtr_m_CallbacksToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, "m_CallbacksToRemove");
		NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100668663);
		NativeMethodInfoPtr_get_Item_Public_get_TDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100668664);
		NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100668665);
		NativeMethodInfoPtr_AddCallback_Public_Void_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100668666);
		NativeMethodInfoPtr_RemoveCallback_Public_Void_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100668667);
		NativeMethodInfoPtr_LockForChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100668668);
		NativeMethodInfoPtr_UnlockForChanges_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr, 100668669);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1016220, RefRangeEnd = 1016222, XrefRangeStart = 1016214, XrefRangeEnd = 1016220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(36)]
	[CachedScanResults(RefRangeStart = 1016234, RefRangeEnd = 1016270, XrefRangeStart = 1016222, XrefRangeEnd = 1016234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCallback(TDelegate dlg)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TDelegate reference;
		if (!typeof(TDelegate).IsValueType)
		{
			TDelegate val = dlg;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref dlg;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCallback_Public_Void_TDelegate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 1016282, RefRangeEnd = 1016317, XrefRangeStart = 1016270, XrefRangeEnd = 1016282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCallback(TDelegate dlg)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TDelegate reference;
		if (!typeof(TDelegate).IsValueType)
		{
			TDelegate val = dlg;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref dlg;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCallback_Public_Void_TDelegate_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 960106, RefRangeEnd = 960114, XrefRangeStart = 960106, XrefRangeEnd = 960114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LockForChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LockForChanges_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1016341, RefRangeEnd = 1016349, XrefRangeStart = 1016317, XrefRangeEnd = 1016341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnlockForChanges()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnlockForChanges_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CallbackArray(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public CallbackArray()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallbackArray<TDelegate>>.NativeClassPtr))
	{
	}
}
