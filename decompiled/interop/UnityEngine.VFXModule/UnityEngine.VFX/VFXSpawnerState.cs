using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.VFX;

public sealed class VFXSpawnerState : Il2CppSystem.Object
{
	public static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VFXSpawnerState_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VFXSpawnerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663404);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(VFXSpawnerState vfxSpawnerState)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)vfxSpawnerState);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VFXSpawnerState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate bool get_newLoop_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_deltaTime_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_delayBeforeLoop_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_delayBeforeLoop_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_loopDuration_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_loopDuration_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_delayAfterLoop_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_delayAfterLoop_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_loopIndex_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_loopIndex_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_loopCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_loopCount_InjectedDelegate(System.IntPtr _unity_self, int value);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Owner;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WrapEventAttribute;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateSpawnerStateWrapper_Internal_Static_VFXSpawnerState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareWrapper_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPtr_Internal_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_playing_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_playing_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_loopState_Public_get_VFXSpawnerLoopState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_loopState_Public_set_Void_VFXSpawnerLoopState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spawnCount_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_spawnCount_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalTime_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_totalTime_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetVFXEventAttribute_Internal_VFXEventAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_vfxEventAttribute_Public_get_VFXEventAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_loopState_Injected_Private_Static_VFXSpawnerLoopState_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_loopState_Injected_Private_Static_Void_IntPtr_VFXSpawnerLoopState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_spawnCount_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_spawnCount_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaTime_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_totalTime_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_totalTime_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetVFXEventAttribute_Injected_Private_Static_IntPtr_IntPtr_0;

	private static readonly get_newLoop_InjectedDelegate get_newLoop_InjectedDelegateField;

	private static readonly set_deltaTime_InjectedDelegate set_deltaTime_InjectedDelegateField;

	private static readonly get_delayBeforeLoop_InjectedDelegate get_delayBeforeLoop_InjectedDelegateField;

	private static readonly set_delayBeforeLoop_InjectedDelegate set_delayBeforeLoop_InjectedDelegateField;

	private static readonly get_loopDuration_InjectedDelegate get_loopDuration_InjectedDelegateField;

	private static readonly set_loopDuration_InjectedDelegate set_loopDuration_InjectedDelegateField;

	private static readonly get_delayAfterLoop_InjectedDelegate get_delayAfterLoop_InjectedDelegateField;

	private static readonly set_delayAfterLoop_InjectedDelegate set_delayAfterLoop_InjectedDelegateField;

	private static readonly get_loopIndex_InjectedDelegate get_loopIndex_InjectedDelegateField;

	private static readonly set_loopIndex_InjectedDelegate set_loopIndex_InjectedDelegateField;

	private static readonly get_loopCount_InjectedDelegate get_loopCount_InjectedDelegateField;

	private static readonly set_loopCount_InjectedDelegate set_loopCount_InjectedDelegateField;

	public unsafe System.IntPtr m_Ptr
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr);
			return *(System.IntPtr*)num;
		}
		set
		{
			*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ptr)) = value;
		}
	}

	public unsafe bool m_Owner
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Owner);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Owner)) = value;
		}
	}

	public unsafe VFXEventAttribute m_WrapEventAttribute
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WrapEventAttribute);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WrapEventAttribute)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool playing
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1409188, RefRangeEnd = 1409190, XrefRangeStart = 1409185, XrefRangeEnd = 1409188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_playing_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1409194, RefRangeEnd = 1409196, XrefRangeStart = 1409190, XrefRangeEnd = 1409194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_playing_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe VFXSpawnerLoopState loopState
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409196, XrefRangeEnd = 1409200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_loopState_Public_get_VFXSpawnerLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(VFXSpawnerLoopState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409200, XrefRangeEnd = 1409204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_loopState_Public_set_Void_VFXSpawnerLoopState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float spawnCount
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409208, RefRangeEnd = 1409209, XrefRangeStart = 1409204, XrefRangeEnd = 1409208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spawnCount_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409213, RefRangeEnd = 1409214, XrefRangeStart = 1409209, XrefRangeEnd = 1409213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_spawnCount_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float deltaTime
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1409218, RefRangeEnd = 1409220, XrefRangeStart = 1409214, XrefRangeEnd = 1409218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_deltaTime_Injected(intPtr, value);
		}
	}

	public unsafe float totalTime
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1409224, RefRangeEnd = 1409226, XrefRangeStart = 1409220, XrefRangeEnd = 1409224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1409230, RefRangeEnd = 1409231, XrefRangeStart = 1409226, XrefRangeEnd = 1409230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_totalTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe VFXEventAttribute vfxEventAttribute
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1409238, RefRangeEnd = 1409242, XrefRangeStart = 1409238, XrefRangeEnd = 1409238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_vfxEventAttribute_Public_get_VFXEventAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
		}
	}

	public bool newLoop
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_newLoop_Injected(intPtr);
		}
	}

	public float delayBeforeLoop
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_delayBeforeLoop_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_delayBeforeLoop_Injected(intPtr, value);
		}
	}

	public float loopDuration
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loopDuration_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_loopDuration_Injected(intPtr, value);
		}
	}

	public float delayAfterLoop
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_delayAfterLoop_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_delayAfterLoop_Injected(intPtr, value);
		}
	}

	public int loopIndex
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loopIndex_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_loopIndex_Injected(intPtr, value);
		}
	}

	public int loopCount
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loopCount_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_loopCount_Injected(intPtr, value);
		}
	}

	static VFXSpawnerState()
	{
		Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXSpawnerState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, "m_Owner");
		NativeFieldInfoPtr_m_WrapEventAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, "m_WrapEventAttribute");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663374);
		NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663375);
		NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663376);
		NativeMethodInfoPtr_CreateSpawnerStateWrapper_Internal_Static_VFXSpawnerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663377);
		NativeMethodInfoPtr_PrepareWrapper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663378);
		NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663379);
		NativeMethodInfoPtr_GetPtr_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663380);
		NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663381);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_get_playing_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_set_playing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_get_loopState_Public_get_VFXSpawnerLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_set_loopState_Public_set_Void_VFXSpawnerLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_get_spawnCount_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_set_spawnCount_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_get_totalTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_set_totalTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_Internal_GetVFXEventAttribute_Internal_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_get_vfxEventAttribute_Public_get_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_get_loopState_Injected_Private_Static_VFXSpawnerLoopState_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr_set_loopState_Injected_Private_Static_Void_IntPtr_VFXSpawnerLoopState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663397);
		NativeMethodInfoPtr_get_spawnCount_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663398);
		NativeMethodInfoPtr_set_spawnCount_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663399);
		NativeMethodInfoPtr_get_deltaTime_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663400);
		NativeMethodInfoPtr_get_totalTime_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663401);
		NativeMethodInfoPtr_set_totalTime_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663402);
		NativeMethodInfoPtr_Internal_GetVFXEventAttribute_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663403);
		get_newLoop_InjectedDelegateField = IL2CPP.ResolveICall<get_newLoop_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::get_newLoop_Injected");
		set_deltaTime_InjectedDelegateField = IL2CPP.ResolveICall<set_deltaTime_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::set_deltaTime_Injected");
		get_delayBeforeLoop_InjectedDelegateField = IL2CPP.ResolveICall<get_delayBeforeLoop_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::get_delayBeforeLoop_Injected");
		set_delayBeforeLoop_InjectedDelegateField = IL2CPP.ResolveICall<set_delayBeforeLoop_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::set_delayBeforeLoop_Injected");
		get_loopDuration_InjectedDelegateField = IL2CPP.ResolveICall<get_loopDuration_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopDuration_Injected");
		set_loopDuration_InjectedDelegateField = IL2CPP.ResolveICall<set_loopDuration_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopDuration_Injected");
		get_delayAfterLoop_InjectedDelegateField = IL2CPP.ResolveICall<get_delayAfterLoop_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::get_delayAfterLoop_Injected");
		set_delayAfterLoop_InjectedDelegateField = IL2CPP.ResolveICall<set_delayAfterLoop_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::set_delayAfterLoop_Injected");
		get_loopIndex_InjectedDelegateField = IL2CPP.ResolveICall<get_loopIndex_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopIndex_Injected");
		set_loopIndex_InjectedDelegateField = IL2CPP.ResolveICall<set_loopIndex_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopIndex_Injected");
		get_loopCount_InjectedDelegateField = IL2CPP.ResolveICall<get_loopCount_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopCount_Injected");
		set_loopCount_InjectedDelegateField = IL2CPP.ResolveICall<set_loopCount_InjectedDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopCount_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409134, XrefRangeEnd = 1409137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXSpawnerState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1167575, RefRangeEnd = 1167577, XrefRangeStart = 1167575, XrefRangeEnd = 1167577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXSpawnerState(System.IntPtr ptr, bool owner)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr))
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(bool**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &owner;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409137, XrefRangeEnd = 1409139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_Create()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Create_Internal_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409139, XrefRangeEnd = 1409149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VFXSpawnerState CreateSpawnerStateWrapper()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateSpawnerStateWrapper_Internal_Static_VFXSpawnerState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXSpawnerState>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409149, XrefRangeEnd = 1409167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareWrapper()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareWrapper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void SetWrapValue(System.IntPtr ptrToSpawnerState, System.IntPtr ptrToEventAttribute)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&ptrToSpawnerState);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ptrToEventAttribute;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(200)]
	[CachedScanResults(RefRangeStart = 1156232, RefRangeEnd = 1156432, XrefRangeStart = 1156232, XrefRangeEnd = 1156432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe System.IntPtr GetPtr()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPtr_Internal_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409167, XrefRangeEnd = 1409170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409170, XrefRangeEnd = 1409176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409176, XrefRangeEnd = 1409183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409183, XrefRangeEnd = 1409185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Destroy(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409231, XrefRangeEnd = 1409238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXEventAttribute Internal_GetVFXEventAttribute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetVFXEventAttribute_Internal_VFXEventAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409242, XrefRangeEnd = 1409244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static VFXSpawnerLoopState get_loopState_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_loopState_Injected_Private_Static_VFXSpawnerLoopState_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(VFXSpawnerLoopState*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409244, XrefRangeEnd = 1409246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_loopState_Injected(System.IntPtr _unity_self, VFXSpawnerLoopState value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(VFXSpawnerLoopState**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_loopState_Injected_Private_Static_Void_IntPtr_VFXSpawnerLoopState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409246, XrefRangeEnd = 1409248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_spawnCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_spawnCount_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409248, XrefRangeEnd = 1409250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_spawnCount_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_spawnCount_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409250, XrefRangeEnd = 1409252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_deltaTime_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_deltaTime_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409252, XrefRangeEnd = 1409254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_totalTime_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_totalTime_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409254, XrefRangeEnd = 1409256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_totalTime_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_totalTime_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1409256, XrefRangeEnd = 1409258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr Internal_GetVFXEventAttribute_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetVFXEventAttribute_Injected_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public VFXSpawnerState(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static bool get_newLoop_Injected(System.IntPtr _unity_self)
	{
		return get_newLoop_InjectedDelegateField(_unity_self);
	}

	public static void set_deltaTime_Injected(System.IntPtr _unity_self, float value)
	{
		set_deltaTime_InjectedDelegateField(_unity_self, value);
	}

	public static float get_delayBeforeLoop_Injected(System.IntPtr _unity_self)
	{
		return get_delayBeforeLoop_InjectedDelegateField(_unity_self);
	}

	public static void set_delayBeforeLoop_Injected(System.IntPtr _unity_self, float value)
	{
		set_delayBeforeLoop_InjectedDelegateField(_unity_self, value);
	}

	public static float get_loopDuration_Injected(System.IntPtr _unity_self)
	{
		return get_loopDuration_InjectedDelegateField(_unity_self);
	}

	public static void set_loopDuration_Injected(System.IntPtr _unity_self, float value)
	{
		set_loopDuration_InjectedDelegateField(_unity_self, value);
	}

	public static float get_delayAfterLoop_Injected(System.IntPtr _unity_self)
	{
		return get_delayAfterLoop_InjectedDelegateField(_unity_self);
	}

	public static void set_delayAfterLoop_Injected(System.IntPtr _unity_self, float value)
	{
		set_delayAfterLoop_InjectedDelegateField(_unity_self, value);
	}

	public static int get_loopIndex_Injected(System.IntPtr _unity_self)
	{
		return get_loopIndex_InjectedDelegateField(_unity_self);
	}

	public static void set_loopIndex_Injected(System.IntPtr _unity_self, int value)
	{
		set_loopIndex_InjectedDelegateField(_unity_self, value);
	}

	public static int get_loopCount_Injected(System.IntPtr _unity_self)
	{
		return get_loopCount_InjectedDelegateField(_unity_self);
	}

	public static void set_loopCount_Injected(System.IntPtr _unity_self, int value)
	{
		set_loopCount_InjectedDelegateField(_unity_self, value);
	}
}
