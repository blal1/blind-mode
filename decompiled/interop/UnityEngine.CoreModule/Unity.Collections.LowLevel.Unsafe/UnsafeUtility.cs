using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Bindings;

namespace Unity.Collections.LowLevel.Unsafe;

public static class UnsafeUtility : Il2CppSystem.Object
{
	public sealed class AlignOfHelper<T> : Il2CppSystem.ValueType where T : new()
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_dummy;

		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		public unsafe byte dummy
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dummy);
				return *(byte*)num;
			}
			set
			{
				*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dummy)) = value;
			}
		}

		public unsafe T data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				return IL2CPP.PointerToValueGeneric<T>((System.IntPtr)num, true, false);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				System.Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						object obj = value;
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null));
						if (intPtr != (System.IntPtr)0 && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr)))
						{
							System.IntPtr intPtr2 = intPtr;
							// IL cpblk instruction
							System.Runtime.CompilerServices.Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr2), ref *(uint*)null));
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, intPtr);
						}
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)num2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					System.Runtime.CompilerServices.Unsafe.Write((void*)num2, value);
				}
			}
		}

		static AlignOfHelper()
		{
			Il2CppClassPointerStore<AlignOfHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, "AlignOfHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AlignOfHelper<T>>.NativeClassPtr);
			NativeFieldInfoPtr_dummy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlignOfHelper<T>>.NativeClassPtr, "dummy");
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AlignOfHelper<T>>.NativeClassPtr, "data");
		}

		public AlignOfHelper(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public AlignOfHelper()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AlignOfHelper<T>>.NativeClassPtr))
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_IsBlittable_Public_Static_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_IsGenericListBlittable_Internal_Static_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IsGenericListBlittable_Internal_Static_Boolean_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetReasonForGenericListNonBlittable_Internal_Static_String_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetReasonForGenericListNonBlittable_Internal_Static_String_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_CopyStructureToPtr_Public_Static_Void_byref_T_ptr_Void_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_CopyStructureToPtr_Public_Static_Void_byref_T_ptr_Void_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InternalCopyStructureToPtr_Private_Static_Void_byref_T_ptr_Void_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InternalCopyStructureToPtr_Private_Static_Void_byref_T_ptr_Void_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_As_Public_Static_byref_T_byref_U_0<U, T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<U>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_As_Internal_Static_T_Object_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_As_Internal_Static_T_Object_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EnumToInt_Public_Static_Int32_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EnumEquals_Public_Static_Boolean_T_T_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0, Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private delegate int GetFieldOffsetInStructDelegate(System.IntPtr field);

	private delegate int GetFieldOffsetInClassDelegate(System.IntPtr field);

	private delegate System.IntPtr PinSystemArrayAndGetAddressDelegate(System.IntPtr target, [System.Runtime.InteropServices.Out] System.IntPtr gcHandle);

	private delegate System.IntPtr PinSystemObjectAndGetAddressDelegate(System.IntPtr target, [System.Runtime.InteropServices.Out] System.IntPtr gcHandle);

	private delegate void ReleaseGCObjectDelegate(ulong gcHandle);

	private delegate void CopyObjectAddressToPtrDelegate(System.IntPtr target, System.IntPtr dstPtr);

	private delegate int CheckForLeaksDelegate();

	private delegate int ForgiveLeaksDelegate();

	private delegate NativeLeakDetectionMode GetLeakDetectionModeDelegate();

	private delegate void SetLeakDetectionModeDelegate(NativeLeakDetectionMode value);

	private delegate void MemCpyReplicateDelegate(System.IntPtr destination, System.IntPtr source, int size, int count);

	private delegate void MemSwapDelegate(System.IntPtr ptr1, System.IntPtr ptr2, long size);

	private delegate bool IsUnmanagedDelegate(System.IntPtr type);

	private delegate bool IsValidNativeContainerElementTypeDelegate(System.IntPtr type);

	private delegate int GetScriptingTypeFlagsDelegate(System.IntPtr type);

	private delegate void LogError_InjectedDelegate(System.IntPtr msg, System.IntPtr filename, int linenumber);

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemMove_Public_Static_Void_ptr_Void_ptr_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MemCmp_Public_Static_Int32_ptr_Void_ptr_Void_Int64_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsGenericListBlittable_Internal_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetReasonForGenericListNonBlittable_Internal_Static_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CopyStructureToPtr_Public_Static_Void_byref_T_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalCopyStructureToPtr_Private_Static_Void_byref_T_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_As_Internal_Static_T_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0;

	public const int kIsManaged = 1;

	public const int kIsNativeContainer = 2;

	private static readonly GetFieldOffsetInStructDelegate GetFieldOffsetInStructDelegateField;

	private static readonly GetFieldOffsetInClassDelegate GetFieldOffsetInClassDelegateField;

	private static readonly PinSystemArrayAndGetAddressDelegate PinSystemArrayAndGetAddressDelegateField;

	private static readonly PinSystemObjectAndGetAddressDelegate PinSystemObjectAndGetAddressDelegateField;

	private static readonly ReleaseGCObjectDelegate ReleaseGCObjectDelegateField;

	private static readonly CopyObjectAddressToPtrDelegate CopyObjectAddressToPtrDelegateField;

	private static readonly CheckForLeaksDelegate CheckForLeaksDelegateField;

	private static readonly ForgiveLeaksDelegate ForgiveLeaksDelegateField;

	private static readonly GetLeakDetectionModeDelegate GetLeakDetectionModeDelegateField;

	private static readonly SetLeakDetectionModeDelegate SetLeakDetectionModeDelegateField;

	private static readonly MemCpyReplicateDelegate MemCpyReplicateDelegateField;

	private static readonly MemSwapDelegate MemSwapDelegateField;

	private static readonly IsUnmanagedDelegate IsUnmanagedDelegateField;

	private static readonly IsValidNativeContainerElementTypeDelegate IsValidNativeContainerElementTypeDelegateField;

	private static readonly GetScriptingTypeFlagsDelegate GetScriptingTypeFlagsDelegateField;

	private static readonly LogError_InjectedDelegate LogError_InjectedDelegateField;

	static UnsafeUtility()
	{
		Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", "UnsafeUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr);
		NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663631);
		NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663632);
		NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663633);
		NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663634);
		NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663635);
		NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663636);
		NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663637);
		NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663638);
		NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663639);
		NativeMethodInfoPtr_MemMove_Public_Static_Void_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663640);
		NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663641);
		NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663642);
		NativeMethodInfoPtr_MemCmp_Public_Static_Int32_ptr_Void_ptr_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663643);
		NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663644);
		NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663645);
		NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663646);
		NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663647);
		NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663648);
		NativeMethodInfoPtr_IsGenericListBlittable_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663649);
		NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663650);
		NativeMethodInfoPtr_GetReasonForGenericListNonBlittable_Internal_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_AlignOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_CopyStructureToPtr_Public_Static_Void_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663655);
		NativeMethodInfoPtr_InternalCopyStructureToPtr_Private_Static_Void_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663656);
		NativeMethodInfoPtr_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663659);
		NativeMethodInfoPtr_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_AddressOf_Public_Static_ptr_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr_As_Public_Static_byref_T_byref_U_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr_As_Internal_Static_T_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663664);
		NativeMethodInfoPtr_AsRef_Public_Static_byref_T_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663665);
		NativeMethodInfoPtr_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663666);
		NativeMethodInfoPtr_EnumToInt_Public_Static_Int32_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663668);
		NativeMethodInfoPtr_EnumEquals_Public_Static_Boolean_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeUtility>.NativeClassPtr, 100663669);
		GetFieldOffsetInStructDelegateField = IL2CPP.ResolveICall<GetFieldOffsetInStructDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInStruct");
		GetFieldOffsetInClassDelegateField = IL2CPP.ResolveICall<GetFieldOffsetInClassDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetFieldOffsetInClass");
		PinSystemArrayAndGetAddressDelegateField = IL2CPP.ResolveICall<PinSystemArrayAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemArrayAndGetAddress");
		PinSystemObjectAndGetAddressDelegateField = IL2CPP.ResolveICall<PinSystemObjectAndGetAddressDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::PinSystemObjectAndGetAddress");
		ReleaseGCObjectDelegateField = IL2CPP.ResolveICall<ReleaseGCObjectDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ReleaseGCObject");
		CopyObjectAddressToPtrDelegateField = IL2CPP.ResolveICall<CopyObjectAddressToPtrDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CopyObjectAddressToPtr");
		CheckForLeaksDelegateField = IL2CPP.ResolveICall<CheckForLeaksDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::CheckForLeaks");
		ForgiveLeaksDelegateField = IL2CPP.ResolveICall<ForgiveLeaksDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::ForgiveLeaks");
		GetLeakDetectionModeDelegateField = IL2CPP.ResolveICall<GetLeakDetectionModeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetLeakDetectionMode");
		SetLeakDetectionModeDelegateField = IL2CPP.ResolveICall<SetLeakDetectionModeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::SetLeakDetectionMode");
		MemCpyReplicateDelegateField = IL2CPP.ResolveICall<MemCpyReplicateDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemCpyReplicate");
		MemSwapDelegateField = IL2CPP.ResolveICall<MemSwapDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::MemSwap");
		IsUnmanagedDelegateField = IL2CPP.ResolveICall<IsUnmanagedDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsUnmanaged");
		IsValidNativeContainerElementTypeDelegateField = IL2CPP.ResolveICall<IsValidNativeContainerElementTypeDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::IsValidNativeContainerElementType");
		GetScriptingTypeFlagsDelegateField = IL2CPP.ResolveICall<GetScriptingTypeFlagsDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::GetScriptingTypeFlags");
		LogError_InjectedDelegateField = IL2CPP.ResolveICall<LogError_InjectedDelegate>("Unity.Collections.LowLevel.Unsafe.UnsafeUtility::LogError_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166078, XrefRangeEnd = 1166083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBlittable<T>() where T : new()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IsBlittable_Public_Static_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1166085, RefRangeEnd = 1166087, XrefRangeStart = 1166083, XrefRangeEnd = 1166085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LeakRecord(System.IntPtr handle, LeakCategory category, int callstacksToSkip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handle);
		*(LeakCategory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &callstacksToSkip;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeakRecord_Internal_Static_Int32_IntPtr_LeakCategory_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166089, RefRangeEnd = 1166090, XrefRangeStart = 1166087, XrefRangeEnd = 1166089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LeakErase(System.IntPtr handle, LeakCategory category)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(LeakCategory**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &category;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LeakErase_Internal_Static_Int32_IntPtr_LeakCategory_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1166092, RefRangeEnd = 1166094, XrefRangeStart = 1166090, XrefRangeEnd = 1166092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* MallocTracked(long size, int alignment, Allocator allocator, int callstacksToSkip)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&size);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignment;
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &callstacksToSkip;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MallocTracked_Public_Static_ptr_Void_Int64_Int32_Allocator_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1166096, RefRangeEnd = 1166098, XrefRangeStart = 1166094, XrefRangeEnd = 1166096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FreeTracked(void* memory, Allocator allocator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)memory;
		*(Allocator**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeTracked_Public_Static_Void_ptr_Void_Allocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(20)]
	[CachedScanResults(RefRangeStart = 1166100, RefRangeEnd = 1166120, XrefRangeStart = 1166098, XrefRangeEnd = 1166100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* Malloc(long size, int alignment, Allocator allocator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&size);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &alignment;
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Malloc_Public_Static_ptr_Void_Int64_Int32_Allocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (void*)result;
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 1166122, RefRangeEnd = 1166147, XrefRangeStart = 1166120, XrefRangeEnd = 1166122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Free(void* memory, Allocator allocator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)memory;
		*(Allocator**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Free_Public_Static_Void_ptr_Void_Allocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(111)]
	[CachedScanResults(RefRangeStart = 1166149, RefRangeEnd = 1166260, XrefRangeStart = 1166147, XrefRangeEnd = 1166149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemCpy(void* destination, void* source, long size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)destination;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = source;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemCpy_Public_Static_Void_ptr_Void_ptr_Void_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1166262, RefRangeEnd = 1166264, XrefRangeStart = 1166260, XrefRangeEnd = 1166262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)destination;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationStride;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = source;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceStride;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &elementSize;
		*(int**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemCpyStride_Public_Static_Void_ptr_Void_Int32_ptr_Void_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1166266, RefRangeEnd = 1166269, XrefRangeStart = 1166264, XrefRangeEnd = 1166266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemMove(void* destination, void* source, long size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)destination;
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = source;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemMove_Public_Static_Void_ptr_Void_ptr_Void_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 1166271, RefRangeEnd = 1166286, XrefRangeStart = 1166269, XrefRangeEnd = 1166271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemSet(void* destination, byte value, long size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)destination;
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		*(long**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemSet_Public_Static_Void_ptr_Void_Byte_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 1166288, RefRangeEnd = 1166306, XrefRangeStart = 1166286, XrefRangeEnd = 1166288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MemClear(void* destination, long size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)destination;
		*(long**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemClear_Public_Static_Void_ptr_Void_Int64_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(37)]
	[CachedScanResults(RefRangeStart = 1166308, RefRangeEnd = 1166345, XrefRangeStart = 1166306, XrefRangeEnd = 1166308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MemCmp(void* ptr1, void* ptr2, long size)
	{
		System.IntPtr* ptr3 = stackalloc System.IntPtr[3];
		*ptr3 = (nint)ptr1;
		*(void**)((byte*)ptr3 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = ptr2;
		*(long**)((byte*)ptr3 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MemCmp_Public_Static_Int32_ptr_Void_ptr_Void_Int64_0, (System.IntPtr)0, (void**)ptr3, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1166379, RefRangeEnd = 1166382, XrefRangeStart = 1166345, XrefRangeEnd = 1166379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SizeOf(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1166384, RefRangeEnd = 1166385, XrefRangeStart = 1166382, XrefRangeEnd = 1166384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBlittable(Il2CppSystem.Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBlittable_Public_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166385, XrefRangeEnd = 1166386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsBlittableValueType(Il2CppSystem.Type t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsBlittableValueType_Private_Static_Boolean_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1166405, RefRangeEnd = 1166408, XrefRangeStart = 1166386, XrefRangeEnd = 1166405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetReasonForTypeNonBlittableImpl(Il2CppSystem.Type t, string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReasonForTypeNonBlittableImpl_Private_Static_String_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 1166410, RefRangeEnd = 1166416, XrefRangeStart = 1166408, XrefRangeEnd = 1166410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsArrayBlittable(Il2CppSystem.Array arr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsArrayBlittable_Internal_Static_Boolean_Array_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166416, XrefRangeEnd = 1166417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsGenericListBlittable<T>() where T : new()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IsGenericListBlittable_Internal_Static_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1166420, RefRangeEnd = 1166423, XrefRangeStart = 1166417, XrefRangeEnd = 1166420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetReasonForArrayNonBlittable(Il2CppSystem.Array arr)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetReasonForArrayNonBlittable_Internal_Static_String_Array_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166423, XrefRangeEnd = 1166429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetReasonForGenericListNonBlittable<T>() where T : new()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetReasonForGenericListNonBlittable_Internal_Static_String_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 1166430, RefRangeEnd = 1166443, XrefRangeStart = 1166429, XrefRangeEnd = 1166430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AlignOf<T>() where T : new()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AlignOf_Public_Static_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166443, XrefRangeEnd = 1166444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyPtrToStructure<T>(void* ptr, out T output) where T : new()
	{
		//IL_0032->IL0034: Incompatible stack types: I vs Ref
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)ptr;
		byte* num = (byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num2);
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref output;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CopyPtrToStructure_Public_Static_Void_ptr_Void_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(T).IsValueType)
		{
			nint num3 = num2;
			System.Runtime.CompilerServices.Unsafe.As<T, object>(ref output) = ((num3 == 0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>((System.IntPtr)num3, false, false));
		}
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1166444, RefRangeEnd = 1166447, XrefRangeStart = 1166444, XrefRangeEnd = 1166444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalCopyPtrToStructure<T>(void* ptr, out T output) where T : new()
	{
		//IL_0032->IL0034: Incompatible stack types: I vs Ref
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)ptr;
		byte* num = (byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nint num2);
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			num2 = 0;
			reference = ref *(_003F*)(&num2);
		}
		else
		{
			reference = ref output;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InternalCopyPtrToStructure_Private_Static_Void_ptr_Void_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		if (!typeof(T).IsValueType)
		{
			nint num3 = num2;
			System.Runtime.CompilerServices.Unsafe.As<T, object>(ref output) = ((num3 == 0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>((System.IntPtr)num3, false, false));
		}
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166447, XrefRangeEnd = 1166448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CopyStructureToPtr<T>(ref T input, void* ptr) where T : new()
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<T, object>(ref input));
		*ptr2 = (nint)(&intPtr);
		*(void**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = ptr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_CopyStructureToPtr_Public_Static_Void_byref_T_ptr_Void_0<T>.Pointer, (System.IntPtr)0, (void**)ptr2, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<T, object>(ref input) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166448, XrefRangeEnd = 1166454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InternalCopyStructureToPtr<T>(ref T input, void* ptr) where T : new()
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<T, object>(ref input));
		*ptr2 = (nint)(&intPtr);
		*(void**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = ptr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InternalCopyStructureToPtr_Private_Static_Void_byref_T_ptr_Void_0<T>.Pointer, (System.IntPtr)0, (void**)ptr2, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<T, object>(ref input) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1023994, RefRangeEnd = 1023996, XrefRangeStart = 1023994, XrefRangeEnd = 1023996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T ReadArrayElement<T>(void* source, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)source;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadArrayElement_Public_Static_T_ptr_Void_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(0)]
	public unsafe static T ReadArrayElementWithStride<T>(void* source, int index, int stride)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)source;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ReadArrayElementWithStride_Public_Static_T_ptr_Void_Int32_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1024141, RefRangeEnd = 1024142, XrefRangeStart = 1024141, XrefRangeEnd = 1024142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteArrayElement<T>(void* destination, int index, T value)
	{
		//IL_0060->IL0063: Incompatible stack types: I vs Ref
		//IL_0053->IL0063: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)destination;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WriteArrayElement_Public_Static_Void_ptr_Void_Int32_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value)
	{
		//IL_006e->IL0071: Incompatible stack types: I vs Ref
		//IL_0061->IL0071: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)destination;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &stride;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_WriteArrayElementWithStride_Public_Static_Void_ptr_Void_Int32_Int32_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void* AddressOf<T>(ref T output) where T : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<T, object>(ref output));
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr result = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AddressOf_Public_Static_ptr_Void_byref_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr3 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<T, object>(ref output) = ((intPtr3 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr3, false, false));
		return (void*)result;
	}

	[CallerCount(0)]
	public unsafe static int SizeOf<T>() where T : new()
	{
		System.IntPtr* ptr = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ref T As<U, T>(ref U from)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<U, object>(ref from));
		*ptr = (nint)(&intPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_As_Public_Static_byref_T_byref_U_0<U, T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<U, object>(ref from) = ((intPtr4 == (System.IntPtr)0) ? ((U)null) : IL2CPP.PointerToValueGeneric<U>(intPtr4, false, false));
		return ref *(T*)intPtr3;
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T As<T>(Il2CppSystem.Object from) where T : class
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)from);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_As_Internal_Static_T_Object_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(1403)]
	[CachedScanResults(RefRangeStart = 106100, RefRangeEnd = 107503, XrefRangeStart = 106100, XrefRangeEnd = 107503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ref T AsRef<T>(void* ptr) where T : new()
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)ptr;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AsRef_Public_Static_byref_T_ptr_Void_0<T>.Pointer, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(T*)intPtr2;
	}

	[CallerCount(0)]
	public unsafe static ref T ArrayElementAsRef<T>(void* ptr, int index) where T : new()
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)ptr;
		*(int**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ArrayElementAsRef_Public_Static_byref_T_ptr_Void_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return ref *(T*)intPtr2;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1166454, XrefRangeEnd = 1166455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int EnumToInt<T>(T enumValue) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = enumValue;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref enumValue;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EnumToInt_Public_Static_Int32_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static void InternalEnumToInt<T>(ref T enumValue, ref int intValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)System.Runtime.CompilerServices.Unsafe.As<T, object>(ref enumValue));
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = System.Runtime.CompilerServices.Unsafe.AsPointer(ref intValue);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InternalEnumToInt_Private_Static_Void_byref_T_byref_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		System.Runtime.CompilerServices.Unsafe.As<T, object>(ref enumValue) = ((intPtr4 == (System.IntPtr)0) ? ((T)null) : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 449651, RefRangeEnd = 449658, XrefRangeStart = 449651, XrefRangeEnd = 449658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool EnumEquals<T>(T lhs, T rhs) where T : new()
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		//IL_008d->IL0090: Incompatible stack types: I vs Ref
		//IL_0080->IL0090: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = lhs;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref lhs;
		}
		*ptr = (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref T reference2;
		if (!typeof(T).IsValueType)
		{
			object obj2 = rhs;
			reference2 = ref *(_003F*)((!(obj2 is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj2 is Il2CppObjectBase) ? obj2 : null)) : IL2CPP.ManagedStringToIl2Cpp(obj2 as string));
		}
		else
		{
			reference2 = ref rhs;
		}
		*(void**)num = System.Runtime.CompilerServices.Unsafe.AsPointer(ref reference2);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EnumEquals_Public_Static_Boolean_T_T_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public UnsafeUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static int GetFieldOffsetInStruct(FieldInfo field)
	{
		return GetFieldOffsetInStructDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field));
	}

	public static int GetFieldOffsetInClass(FieldInfo field)
	{
		return GetFieldOffsetInClassDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)field));
	}

	public static int GetFieldOffset(FieldInfo field)
	{
		if (field.DeclaringType.IsValueType)
		{
			return GetFieldOffsetInStruct(field);
		}
		if (field.DeclaringType.IsClass)
		{
			return GetFieldOffsetInClass(field);
		}
		return -1;
	}

	public unsafe static void* PinGCObjectAndGetAddress(Il2CppSystem.Object target, out ulong gcHandle)
	{
		return PinSystemObjectAndGetAddress(target, out gcHandle);
	}

	public unsafe static void* PinGCArrayAndGetDataAddress(Il2CppSystem.Array target, out ulong gcHandle)
	{
		return PinSystemArrayAndGetAddress(target, out gcHandle);
	}

	public unsafe static void* PinSystemArrayAndGetAddress(Il2CppSystem.Object target, out ulong gcHandle)
	{
		return (void*)PinSystemArrayAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref gcHandle));
	}

	public unsafe static void* PinSystemObjectAndGetAddress(Il2CppSystem.Object target, out ulong gcHandle)
	{
		return (void*)PinSystemObjectAndGetAddressDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref gcHandle));
	}

	public static void ReleaseGCObject(ulong gcHandle)
	{
		ReleaseGCObjectDelegateField(gcHandle);
	}

	public unsafe static void CopyObjectAddressToPtr(Il2CppSystem.Object target, void* dstPtr)
	{
		CopyObjectAddressToPtrDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)target), (nint)dstPtr);
	}

	public static int CheckForLeaks()
	{
		return CheckForLeaksDelegateField();
	}

	public static int ForgiveLeaks()
	{
		return ForgiveLeaksDelegateField();
	}

	public static NativeLeakDetectionMode GetLeakDetectionMode()
	{
		return GetLeakDetectionModeDelegateField();
	}

	public static void SetLeakDetectionMode(NativeLeakDetectionMode value)
	{
		SetLeakDetectionModeDelegateField(value);
	}

	public static bool IsValidAllocator(Allocator allocator)
	{
		return allocator > Allocator.None;
	}

	public unsafe static void MemCpyReplicate(void* destination, void* source, int size, int count)
	{
		MemCpyReplicateDelegateField((nint)destination, (nint)source, size, count);
	}

	public unsafe static void MemSwap(void* ptr1, void* ptr2, long size)
	{
		MemSwapDelegateField((nint)ptr1, (nint)ptr2, size);
	}

	public static bool IsUnmanaged(Il2CppSystem.Type type)
	{
		return IsUnmanagedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
	}

	public static bool IsValidNativeContainerElementType(Il2CppSystem.Type type)
	{
		return IsValidNativeContainerElementTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
	}

	public static int GetScriptingTypeFlags(Il2CppSystem.Type type)
	{
		return GetScriptingTypeFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type));
	}

	public unsafe static void LogError(string msg, string filename, int linenumber)
	{
		//IL_0018: Expected O, but got Ref
		//IL_0024: Expected O, but got Ref
		//IL_0044: Expected O, but got Ref
		//IL_0052: Expected O, but got Ref
		//The blocks IL_0029, IL_0036, IL_0044, IL_0052, IL_0057 are reachable both inside and outside the pinned region starting at IL_0018. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0057 are reachable both inside and outside the pinned region starting at IL_0044. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			ref ManagedSpanWrapper msg2;
			Il2CppSystem.ReadOnlySpan<char> readOnlySpan2;
			System.Runtime.CompilerServices.Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper2);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(msg, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(msg);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					msg2 = ref managedSpanWrapper;
					if (!StringMarshaller.TryMarshalEmptyOrNullString(filename, ref managedSpanWrapper2))
					{
						readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(filename);
						fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
						{
							managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
							LogError_Injected(ref msg2, ref managedSpanWrapper2, linenumber);
							return;
						}
					}
					LogError_Injected(ref msg2, ref managedSpanWrapper2, linenumber);
					return;
				}
			}
			msg2 = ref managedSpanWrapper;
			if (!StringMarshaller.TryMarshalEmptyOrNullString(filename, ref managedSpanWrapper2))
			{
				readOnlySpan2 = Il2CppSystem.MemoryExtensions.AsSpan(filename);
				fixed (char* begin2 = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).GetPinnableReference())
				{
					managedSpanWrapper2 = new ManagedSpanWrapper(begin2, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan2)).Length);
					LogError_Injected(ref msg2, ref managedSpanWrapper2, linenumber);
					return;
				}
			}
			LogError_Injected(ref msg2, ref managedSpanWrapper2, linenumber);
		}
		finally
		{
		}
	}

	public static string GetReasonForTypeNonBlittable(Il2CppSystem.Type t)
	{
		return GetReasonForTypeNonBlittableImpl(t, t.Name);
	}

	public static string GetReasonForValueTypeNonBlittable<T>() where T : struct
	{
		Il2CppSystem.Type typeFromHandle = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
		return GetReasonForTypeNonBlittableImpl(typeFromHandle, typeFromHandle.Name);
	}

	public static bool IsUnmanaged<T>()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool IsNativeContainerType<T>()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static bool IsValidNativeContainerElementType<T>()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppSystem.Span<byte> GetByteSpanFromArray(Il2CppSystem.Array array, int elementSize)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static Il2CppSystem.Span<byte> GetByteSpanFromList<T>(List<T> list) where T : struct
	{
		return Il2CppSystem.Runtime.InteropServices.MemoryMarshal.AsBytes(NoAllocHelpers.ExtractArrayFromList(list).AsSpan<T>());
	}

	public unsafe static ref T ClassAsRef<T>(void* ptr) where T : class
	{
		return ref *(T*)ptr;
	}

	public static ref T Add<T>(ref T source, int elementOffset) where T : struct, Il2CppSystem.ValueType
	{
		return ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref source, System.Runtime.CompilerServices.Unsafe.SizeOf<T>() * elementOffset);
	}

	public unsafe static void LogError_Injected(ref ManagedSpanWrapper msg, ref ManagedSpanWrapper filename, int linenumber)
	{
		LogError_InjectedDelegateField((nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref msg), (nint)System.Runtime.CompilerServices.Unsafe.AsPointer(ref filename), linenumber);
	}
}
