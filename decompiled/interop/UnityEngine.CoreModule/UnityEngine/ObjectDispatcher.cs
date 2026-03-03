using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;

namespace UnityEngine;

public sealed class ObjectDispatcher : Il2CppSystem.Object
{
	[OriginalName("UnityEngine.CoreModule.dll", "", "TransformTrackingType")]
	public enum TransformTrackingType
	{
		GlobalTRS,
		LocalTRS,
		Hierarchy
	}

	[OriginalName("UnityEngine.CoreModule.dll", "", "TypeTrackingFlags")]
	[System.Flags]
	public enum TypeTrackingFlags
	{
		SceneObjects = 1,
		Assets = 2,
		EditorOnlyObjects = 4,
		Default = 3,
		All = 7
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.ObjectDispatcher+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__64_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0;

		private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__64_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665995);
			NativeMethodInfoPtr___cctor_b__64_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665996);
			NativeMethodInfoPtr___cctor_b__64_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100665997);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184657, XrefRangeEnd = 1184663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__64_0(Il2CppReferenceArray<Object> changed, System.IntPtr changedID, System.IntPtr destroyedID, int changedCount, int destroyedCount, Il2CppSystem.Action<TypeDispatchData> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[6];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)changed);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &changedID;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destroyedID;
			*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &changedCount;
			*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &destroyedCount;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__64_0_Internal_Void_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184663, XrefRangeEnd = 1184679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__64_1(System.IntPtr transformed, System.IntPtr parents, System.IntPtr localToWorldMatrices, System.IntPtr positions, System.IntPtr rotations, System.IntPtr scales, int count, Il2CppSystem.Action<TransformDispatchData> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[8];
			*ptr = (nint)(&transformed);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &parents;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &localToWorldMatrices;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &positions;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotations;
			*(System.IntPtr**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &scales;
			*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
			*(System.IntPtr*)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr___cctor_b__64_1_Internal_Void_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_GetTypeChangesAndClear_Public_TypeDispatchData_Allocator_Boolean_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetTypeChangesAndClear_Public_TypeDispatchData_Allocator_Boolean_Boolean_0, Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetTransformChangesAndClear_Public_TransformDispatchData_TransformTrackingType_Allocator_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetTransformChangesAndClear_Public_TransformDispatchData_TransformTrackingType_Allocator_0, Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EnableTypeTracking_Public_Void_TypeTrackingFlags_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EnableTypeTracking_Public_Void_TypeTrackingFlags_0, Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EnableTransformTracking_Public_Void_TransformTrackingType_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EnableTransformTracking_Public_Void_TransformTrackingType_0, Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	[System.Serializable]
	public sealed class _003C_003Ec
	{
	}

	private delegate int GetMaxDispatchHistoryFramesCountDelegate(System.IntPtr ptr);

	private delegate void SetMaxDispatchHistoryFramesCountDelegate(System.IntPtr ptr, int count);

	private delegate void DisableTypeTrackingDelegate(System.IntPtr ptr, System.IntPtr type);

	private delegate void DisableTransformTrackingDelegate(System.IntPtr ptr, System.IntPtr type, TransformTrackingType trackingType);

	private delegate void DispatchTransformChangesAndClearDelegate(System.IntPtr ptr, System.IntPtr type, TransformTrackingType trackingType, System.IntPtr callback, bool sortByInstanceID);

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DispatchAllocator;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TypeDispatchData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformDispatchData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformedComponents;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TypeDataCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformDataCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformComponentCallback;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_TypeDispatch;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_TransformDispatch;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_valid_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateSystemHandleAndThrow_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateTypeAndThrow_Private_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ValidateComponentTypeAndThrow_Private_Void_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchCallback_Private_Void_TypeDispatchData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchCallback_Private_Void_TransformDispatchData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchCallback_Private_Void_Il2CppReferenceArray_1_Component_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchTypeChangesAndClear_Public_Void_Type_Action_1_TypeDispatchData_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchTransformChangesAndClear_Public_Void_Type_TransformTrackingType_Action_1_TransformDispatchData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeChangesAndClear_Public_TypeDispatchData_Type_Allocator_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTransformChangesAndClear_Public_TransformDispatchData_Type_TransformTrackingType_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableTypeTracking_Public_Void_TypeTrackingFlags_Il2CppReferenceArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableTransformTracking_Public_Void_TransformTrackingType_Il2CppReferenceArray_1_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeChangesAndClear_Public_TypeDispatchData_Allocator_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetTransformChangesAndClear_Public_TransformDispatchData_TransformTrackingType_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableTypeTracking_Public_Void_TypeTrackingFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableTransformTracking_Public_Void_TransformTrackingType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateDispatchSystemHandle_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DestroyDispatchSystemHandle_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableTypeTracking_Private_Static_Void_IntPtr_Type_TypeTrackingFlags_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableTransformTracking_Private_Static_Void_IntPtr_Type_TransformTrackingType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchTypeChangesAndClear_Private_Static_Void_IntPtr_Type_Action_6_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_Boolean_Boolean_Action_1_TypeDispatchData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchTransformDataChangesAndClear_Private_Static_Void_IntPtr_Type_TransformTrackingType_Action_8_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_Action_1_TransformDispatchData_0;

	private static readonly GetMaxDispatchHistoryFramesCountDelegate GetMaxDispatchHistoryFramesCountDelegateField;

	private static readonly SetMaxDispatchHistoryFramesCountDelegate SetMaxDispatchHistoryFramesCountDelegateField;

	private static readonly DisableTypeTrackingDelegate DisableTypeTrackingDelegateField;

	private static readonly DisableTransformTrackingDelegate DisableTransformTrackingDelegateField;

	private static readonly DispatchTransformChangesAndClearDelegate DispatchTransformChangesAndClearDelegateField;

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

	public unsafe Allocator m_DispatchAllocator
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DispatchAllocator);
			return *(Allocator*)num;
		}
		set
		{
			*(Allocator*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DispatchAllocator)) = value;
		}
	}

	public unsafe TypeDispatchData m_TypeDispatchData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TypeDispatchData);
			return new TypeDispatchData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TypeDispatchData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe TransformDispatchData m_TransformDispatchData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformDispatchData);
			return new TransformDispatchData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformDispatchData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe Il2CppReferenceArray<Component> m_TransformedComponents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformedComponents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Component>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformedComponents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<TypeDispatchData> m_TypeDataCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TypeDataCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<TypeDispatchData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TypeDataCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<TransformDispatchData> m_TransformDataCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformDataCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<TransformDispatchData>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformDataCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppSystem.Action<Il2CppReferenceArray<Component>> m_TransformComponentCallback
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformComponentCallback);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Il2CppReferenceArray<Component>>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_TransformComponentCallback)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<Il2CppReferenceArray<Object>, System.IntPtr, System.IntPtr, int, int, Il2CppSystem.Action<TypeDispatchData>> s_TypeDispatch
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_TypeDispatch, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<Il2CppReferenceArray<Object>, System.IntPtr, System.IntPtr, int, int, Il2CppSystem.Action<TypeDispatchData>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_TypeDispatch, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppSystem.Action<System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int, Il2CppSystem.Action<TransformDispatchData>> s_TransformDispatch
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_TransformDispatch, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int, Il2CppSystem.Action<TransformDispatchData>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_TransformDispatch, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool valid
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1184679, RefRangeEnd = 1184681, XrefRangeStart = 1184679, XrefRangeEnd = 1184679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_valid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public int maxDispatchHistoryFramesCount
	{
		get
		{
			ValidateSystemHandleAndThrow();
			return GetMaxDispatchHistoryFramesCount(m_Ptr);
		}
		set
		{
			ValidateSystemHandleAndThrow();
			SetMaxDispatchHistoryFramesCount(m_Ptr, value);
		}
	}

	static ObjectDispatcher()
	{
		Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ObjectDispatcher");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr);
		NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "m_Ptr");
		NativeFieldInfoPtr_m_DispatchAllocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "m_DispatchAllocator");
		NativeFieldInfoPtr_m_TypeDispatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "m_TypeDispatchData");
		NativeFieldInfoPtr_m_TransformDispatchData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "m_TransformDispatchData");
		NativeFieldInfoPtr_m_TransformedComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "m_TransformedComponents");
		NativeFieldInfoPtr_m_TypeDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "m_TypeDataCallback");
		NativeFieldInfoPtr_m_TransformDataCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "m_TransformDataCallback");
		NativeFieldInfoPtr_m_TransformComponentCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "m_TransformComponentCallback");
		NativeFieldInfoPtr_s_TypeDispatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "s_TypeDispatch");
		NativeFieldInfoPtr_s_TransformDispatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, "s_TransformDispatch");
		NativeMethodInfoPtr_get_valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665966);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665967);
		NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665968);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665969);
		NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665970);
		NativeMethodInfoPtr_ValidateSystemHandleAndThrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665971);
		NativeMethodInfoPtr_ValidateTypeAndThrow_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665972);
		NativeMethodInfoPtr_ValidateComponentTypeAndThrow_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665973);
		NativeMethodInfoPtr_DispatchCallback_Private_Void_TypeDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665974);
		NativeMethodInfoPtr_DispatchCallback_Private_Void_TransformDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665975);
		NativeMethodInfoPtr_DispatchCallback_Private_Void_Il2CppReferenceArray_1_Component_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665976);
		NativeMethodInfoPtr_DispatchTypeChangesAndClear_Public_Void_Type_Action_1_TypeDispatchData_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665977);
		NativeMethodInfoPtr_DispatchTransformChangesAndClear_Public_Void_Type_TransformTrackingType_Action_1_TransformDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665978);
		NativeMethodInfoPtr_GetTypeChangesAndClear_Public_TypeDispatchData_Type_Allocator_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665979);
		NativeMethodInfoPtr_GetTransformChangesAndClear_Public_TransformDispatchData_Type_TransformTrackingType_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665980);
		NativeMethodInfoPtr_EnableTypeTracking_Public_Void_TypeTrackingFlags_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665981);
		NativeMethodInfoPtr_EnableTransformTracking_Public_Void_TransformTrackingType_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665982);
		NativeMethodInfoPtr_GetTypeChangesAndClear_Public_TypeDispatchData_Allocator_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665983);
		NativeMethodInfoPtr_GetTransformChangesAndClear_Public_TransformDispatchData_TransformTrackingType_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665984);
		NativeMethodInfoPtr_EnableTypeTracking_Public_Void_TypeTrackingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665985);
		NativeMethodInfoPtr_EnableTransformTracking_Public_Void_TransformTrackingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665986);
		NativeMethodInfoPtr_CreateDispatchSystemHandle_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665987);
		NativeMethodInfoPtr_DestroyDispatchSystemHandle_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665988);
		NativeMethodInfoPtr_EnableTypeTracking_Private_Static_Void_IntPtr_Type_TypeTrackingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665989);
		NativeMethodInfoPtr_EnableTransformTracking_Private_Static_Void_IntPtr_Type_TransformTrackingType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665990);
		NativeMethodInfoPtr_DispatchTypeChangesAndClear_Private_Static_Void_IntPtr_Type_Action_6_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_Boolean_Boolean_Action_1_TypeDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665991);
		NativeMethodInfoPtr_DispatchTransformDataChangesAndClear_Private_Static_Void_IntPtr_Type_TransformTrackingType_Action_8_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_Action_1_TransformDispatchData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr, 100665992);
		GetMaxDispatchHistoryFramesCountDelegateField = IL2CPP.ResolveICall<GetMaxDispatchHistoryFramesCountDelegate>("UnityEngine.ObjectDispatcher::GetMaxDispatchHistoryFramesCount");
		SetMaxDispatchHistoryFramesCountDelegateField = IL2CPP.ResolveICall<SetMaxDispatchHistoryFramesCountDelegate>("UnityEngine.ObjectDispatcher::SetMaxDispatchHistoryFramesCount");
		DisableTypeTrackingDelegateField = IL2CPP.ResolveICall<DisableTypeTrackingDelegate>("UnityEngine.ObjectDispatcher::DisableTypeTracking");
		DisableTransformTrackingDelegateField = IL2CPP.ResolveICall<DisableTransformTrackingDelegate>("UnityEngine.ObjectDispatcher::DisableTransformTracking");
		DispatchTransformChangesAndClearDelegateField = IL2CPP.ResolveICall<DispatchTransformChangesAndClearDelegate>("UnityEngine.ObjectDispatcher::DispatchTransformChangesAndClear");
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1184708, RefRangeEnd = 1184709, XrefRangeStart = 1184681, XrefRangeEnd = 1184708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ObjectDispatcher()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectDispatcher>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184709, XrefRangeEnd = 1184713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void Finalize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1184718, RefRangeEnd = 1184719, XrefRangeStart = 1184713, XrefRangeEnd = 1184718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184724, RefRangeEnd = 1184726, XrefRangeStart = 1184719, XrefRangeEnd = 1184724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&disposing);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void ValidateSystemHandleAndThrow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateSystemHandleAndThrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184731, RefRangeEnd = 1184733, XrefRangeStart = 1184726, XrefRangeEnd = 1184731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateTypeAndThrow(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateTypeAndThrow_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184738, RefRangeEnd = 1184740, XrefRangeStart = 1184733, XrefRangeEnd = 1184738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ValidateComponentTypeAndThrow(Il2CppSystem.Type type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ValidateComponentTypeAndThrow_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184740, XrefRangeEnd = 1184746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchCallback(TypeDispatchData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchCallback_Private_Void_TypeDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184746, XrefRangeEnd = 1184762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchCallback(TransformDispatchData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)data));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchCallback_Private_Void_TransformDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchCallback(Il2CppReferenceArray<Component> components)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)components);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchCallback_Private_Void_Il2CppReferenceArray_1_Component_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184762, XrefRangeEnd = 1184775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchTypeChangesAndClear(Il2CppSystem.Type type, Il2CppSystem.Action<TypeDispatchData> callback, bool sortByInstanceID = false, bool noScriptingArray = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortByInstanceID;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &noScriptingArray;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchTypeChangesAndClear_Public_Void_Type_Action_1_TypeDispatchData_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184775, XrefRangeEnd = 1184788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchTransformChangesAndClear(Il2CppSystem.Type type, TransformTrackingType trackingType, Il2CppSystem.Action<TransformDispatchData> callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(TransformTrackingType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trackingType;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchTransformChangesAndClear_Public_Void_Type_TransformTrackingType_Action_1_TransformDispatchData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1184795, RefRangeEnd = 1184796, XrefRangeStart = 1184788, XrefRangeEnd = 1184795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TypeDispatchData GetTypeChangesAndClear(Il2CppSystem.Type type, Allocator allocator, bool sortByInstanceID = false, bool noScriptingArray = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(Allocator**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortByInstanceID;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &noScriptingArray;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTypeChangesAndClear_Public_TypeDispatchData_Type_Allocator_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new TypeDispatchData(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1184803, RefRangeEnd = 1184804, XrefRangeStart = 1184796, XrefRangeEnd = 1184803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TransformDispatchData GetTransformChangesAndClear(Il2CppSystem.Type type, TransformTrackingType trackingType, Allocator allocator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(TransformTrackingType**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &trackingType;
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetTransformChangesAndClear_Public_TransformDispatchData_Type_TransformTrackingType_Allocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new TransformDispatchData(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1184815, RefRangeEnd = 1184816, XrefRangeStart = 1184804, XrefRangeEnd = 1184815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableTypeTracking(TypeTrackingFlags typeTrackingMask, [Optional] Il2CppReferenceArray<Il2CppSystem.Type> types)
	{
		if (types == null)
		{
			types = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&typeTrackingMask);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableTypeTracking_Public_Void_TypeTrackingFlags_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1184827, RefRangeEnd = 1184828, XrefRangeStart = 1184816, XrefRangeEnd = 1184827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableTransformTracking(TransformTrackingType trackingType, [Optional] Il2CppReferenceArray<Il2CppSystem.Type> types)
	{
		if (types == null)
		{
			types = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&trackingType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)types);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableTransformTracking_Public_Void_TransformTrackingType_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1184833, RefRangeEnd = 1184837, XrefRangeStart = 1184828, XrefRangeEnd = 1184833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TypeDispatchData GetTypeChangesAndClear<T>(Allocator allocator, bool sortByInstanceID = false, bool noScriptingArray = false) where T : Object
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&allocator);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortByInstanceID;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &noScriptingArray;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetTypeChangesAndClear_Public_TypeDispatchData_Allocator_Boolean_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new TypeDispatchData(pointer);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184842, RefRangeEnd = 1184844, XrefRangeStart = 1184837, XrefRangeEnd = 1184842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TransformDispatchData GetTransformChangesAndClear<T>(TransformTrackingType trackingType, Allocator allocator) where T : Object
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&trackingType);
		*(Allocator**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetTransformChangesAndClear_Public_TransformDispatchData_TransformTrackingType_Allocator_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new TransformDispatchData(pointer);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1184858, RefRangeEnd = 1184862, XrefRangeStart = 1184844, XrefRangeEnd = 1184858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableTypeTracking<T>(TypeTrackingFlags typeTrackingMask = TypeTrackingFlags.Default) where T : Object
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&typeTrackingMask);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EnableTypeTracking_Public_Void_TypeTrackingFlags_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1184876, RefRangeEnd = 1184878, XrefRangeStart = 1184862, XrefRangeEnd = 1184876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableTransformTracking<T>(TransformTrackingType trackingType) where T : Object
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&trackingType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EnableTransformTracking_Public_Void_TransformTrackingType_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184878, XrefRangeEnd = 1184880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr CreateDispatchSystemHandle()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateDispatchSystemHandle_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184880, XrefRangeEnd = 1184882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DestroyDispatchSystemHandle(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DestroyDispatchSystemHandle_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184882, XrefRangeEnd = 1184884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableTypeTracking(System.IntPtr ptr, Il2CppSystem.Type type, TypeTrackingFlags typeTrackingMask)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(TypeTrackingFlags**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &typeTrackingMask;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableTypeTracking_Private_Static_Void_IntPtr_Type_TypeTrackingFlags_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184884, XrefRangeEnd = 1184886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableTransformTracking(System.IntPtr ptr, Il2CppSystem.Type type, TransformTrackingType trackingType)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(TransformTrackingType**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &trackingType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableTransformTracking_Private_Static_Void_IntPtr_Type_TransformTrackingType_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184886, XrefRangeEnd = 1184888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DispatchTypeChangesAndClear(System.IntPtr ptr, Il2CppSystem.Type type, Il2CppSystem.Action<Il2CppReferenceArray<Object>, System.IntPtr, System.IntPtr, int, int, Il2CppSystem.Action<TypeDispatchData>> callback, bool sortByInstanceID, bool noScriptingArray, Il2CppSystem.Action<TypeDispatchData> param)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[6];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(bool**)((byte*)ptr2 + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sortByInstanceID;
		*(bool**)((byte*)ptr2 + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &noScriptingArray;
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchTypeChangesAndClear_Private_Static_Void_IntPtr_Type_Action_6_Il2CppReferenceArray_1_Object_IntPtr_IntPtr_Int32_Int32_Action_1_TypeDispatchData_Boolean_Boolean_Action_1_TypeDispatchData_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184888, XrefRangeEnd = 1184890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DispatchTransformDataChangesAndClear(System.IntPtr ptr, Il2CppSystem.Type type, TransformTrackingType trackingType, Il2CppSystem.Action<System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, System.IntPtr, int, Il2CppSystem.Action<TransformDispatchData>> callback, Il2CppSystem.Action<TransformDispatchData> param)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[5];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(TransformTrackingType**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &trackingType;
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchTransformDataChangesAndClear_Private_Static_Void_IntPtr_Type_TransformTrackingType_Action_8_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int32_Action_1_TransformDispatchData_Action_1_TransformDispatchData_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public void EnableTypeTracking(TypeTrackingFlags typeTrackingMask, params Il2CppSystem.Type[] types)
	{
		EnableTypeTracking(typeTrackingMask, new Il2CppReferenceArray<Il2CppSystem.Type>(types));
	}

	public void EnableTransformTracking(TransformTrackingType trackingType, params Il2CppSystem.Type[] types)
	{
		EnableTransformTracking(trackingType, new Il2CppReferenceArray<Il2CppSystem.Type>(types));
	}

	public ObjectDispatcher(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void DispatchTransformChangesAndClear(Il2CppSystem.Type type, TransformTrackingType trackingType, Il2CppSystem.Action<Il2CppReferenceArray<Component>> callback, [Optional] bool sortByInstanceID)
	{
		ValidateSystemHandleAndThrow();
		ValidateComponentTypeAndThrow(type);
		DispatchTransformChangesAndClear(m_Ptr, type, trackingType, callback, sortByInstanceID);
	}

	public void ClearTypeChanges(Il2CppSystem.Type type)
	{
		ValidateSystemHandleAndThrow();
		ValidateTypeAndThrow(type);
		DispatchTypeChangesAndClear(m_Ptr, type, null, sortByInstanceID: false, noScriptingArray: false, null);
	}

	public void GetTypeChangesAndClear(Il2CppSystem.Type type, List<Object> changed, out NativeArray<int> changedID, out NativeArray<int> destroyedID, Allocator allocator, [Optional] bool sortByInstanceID)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Il2CppReferenceArray<Component> GetTransformChangesAndClear(Il2CppSystem.Type type, TransformTrackingType trackingType, [Optional] bool sortByInstanceID)
	{
		DispatchTransformChangesAndClear(type, trackingType, m_TransformComponentCallback, sortByInstanceID);
		return m_TransformedComponents;
	}

	public void EnableTypeTracking(Il2CppReferenceArray<Il2CppSystem.Type> types)
	{
		EnableTypeTracking(TypeTrackingFlags.Default, types);
	}

	public void EnableTypeTracking(params Il2CppSystem.Type[] types)
	{
		EnableTypeTracking(new Il2CppReferenceArray<Il2CppSystem.Type>(types));
	}

	public void EnableTypeTrackingIncludingAssets(Il2CppReferenceArray<Il2CppSystem.Type> types)
	{
		EnableTypeTracking(TypeTrackingFlags.Default, types);
	}

	public void EnableTypeTrackingIncludingAssets(params Il2CppSystem.Type[] types)
	{
		EnableTypeTrackingIncludingAssets(new Il2CppReferenceArray<Il2CppSystem.Type>(types));
	}

	public void DisableTypeTracking(Il2CppReferenceArray<Il2CppSystem.Type> types)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void DisableTypeTracking(params Il2CppSystem.Type[] types)
	{
		DisableTypeTracking(new Il2CppReferenceArray<Il2CppSystem.Type>(types));
	}

	public void DisableTransformTracking(TransformTrackingType trackingType, Il2CppReferenceArray<Il2CppSystem.Type> types)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void DisableTransformTracking(TransformTrackingType trackingType, params Il2CppSystem.Type[] types)
	{
		DisableTransformTracking(trackingType, new Il2CppReferenceArray<Il2CppSystem.Type>(types));
	}

	public void DispatchTypeChangesAndClear<T>(Il2CppSystem.Action<TypeDispatchData> callback, [Optional] bool sortByInstanceID, [Optional] bool noScriptingArray) where T : Object
	{
		DispatchTypeChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), callback, sortByInstanceID, noScriptingArray);
	}

	public void DispatchTransformChangesAndClear<T>(TransformTrackingType trackingType, Il2CppSystem.Action<Il2CppReferenceArray<Component>> callback, [Optional] bool sortByInstanceID) where T : Object
	{
		DispatchTransformChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, callback, sortByInstanceID);
	}

	public void DispatchTransformChangesAndClear<T>(TransformTrackingType trackingType, Il2CppSystem.Action<TransformDispatchData> callback) where T : Object
	{
		DispatchTransformChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, callback);
	}

	public void ClearTypeChanges<T>() where T : Object
	{
		ClearTypeChanges(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
	}

	public void GetTypeChangesAndClear<T>(List<Object> changed, out NativeArray<int> changedID, out NativeArray<int> destroyedID, Allocator allocator, [Optional] bool sortByInstanceID) where T : Object
	{
		GetTypeChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), changed, out changedID, out destroyedID, allocator, sortByInstanceID);
	}

	public Il2CppReferenceArray<Component> GetTransformChangesAndClear<T>(TransformTrackingType trackingType, [Optional] bool sortByInstanceID) where T : Object
	{
		return GetTransformChangesAndClear(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), trackingType, sortByInstanceID);
	}

	public void DisableTypeTracking<T>() where T : Object
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void DisableTransformTracking<T>(TransformTrackingType trackingType) where T : Object
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int GetMaxDispatchHistoryFramesCount(System.IntPtr ptr)
	{
		return GetMaxDispatchHistoryFramesCountDelegateField(ptr);
	}

	public static void SetMaxDispatchHistoryFramesCount(System.IntPtr ptr, int count)
	{
		SetMaxDispatchHistoryFramesCountDelegateField(ptr, count);
	}

	public static void DisableTypeTracking(System.IntPtr ptr, Il2CppSystem.Type type)
	{
		DisableTypeTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
	}

	public static void DisableTransformTracking(System.IntPtr ptr, Il2CppSystem.Type type, TransformTrackingType trackingType)
	{
		DisableTransformTrackingDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type), trackingType);
	}

	public static void DispatchTransformChangesAndClear(System.IntPtr ptr, Il2CppSystem.Type type, TransformTrackingType trackingType, Il2CppSystem.Action<Il2CppReferenceArray<Component>> callback, bool sortByInstanceID)
	{
		DispatchTransformChangesAndClearDelegateField(ptr, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type), trackingType, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)callback), sortByInstanceID);
	}
}
