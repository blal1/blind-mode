using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Security;

namespace Il2CppSystem.Runtime.InteropServices;

public static class Marshal : Object
{
	public sealed class SecureStringAllocator : MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_Int32_0;

		static SecureStringAllocator()
		{
			Il2CppClassPointerStore<SecureStringAllocator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "SecureStringAllocator");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringAllocator>.NativeClassPtr, 100671340);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureStringAllocator>.NativeClassPtr, 100671341);
		}

		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 804608, RefRangeEnd = 804619, XrefRangeStart = 804605, XrefRangeEnd = 804608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecureStringAllocator(Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureStringAllocator>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual System.IntPtr Invoke(int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&len);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public SecureStringAllocator(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator SecureStringAllocator(System.Func<int, System.IntPtr> P_0)
		{
			return DelegateSupport.ConvertDelegate<SecureStringAllocator>((System.Delegate)P_0);
		}

		public static SecureStringAllocator operator +(SecureStringAllocator P_0, SecureStringAllocator P_1)
		{
			return ((Il2CppObjectBase)Delegate.Combine(P_0, P_1)).Cast<SecureStringAllocator>();
		}

		public static SecureStringAllocator operator -(SecureStringAllocator P_0, SecureStringAllocator P_1)
		{
			object obj = Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<SecureStringAllocator>();
			}
			return (SecureStringAllocator)obj;
		}
	}

	public class MarshalerInstanceKeyComparer : Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_2_Type_String_ValueTuple_2_Type_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ValueTuple_2_Type_String_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		static MarshalerInstanceKeyComparer()
		{
			Il2CppClassPointerStore<MarshalerInstanceKeyComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "MarshalerInstanceKeyComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarshalerInstanceKeyComparer>.NativeClassPtr);
			NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_2_Type_String_ValueTuple_2_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalerInstanceKeyComparer>.NativeClassPtr, 100671342);
			NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ValueTuple_2_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalerInstanceKeyComparer>.NativeClassPtr, 100671343);
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarshalerInstanceKeyComparer>.NativeClassPtr, 100671344);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804619, XrefRangeEnd = 804622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(ValueTuple<Type, string> lhs, ValueTuple<Type, string> rhs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)lhs));
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)rhs));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ValueTuple_2_Type_String_ValueTuple_2_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804622, XrefRangeEnd = 804625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(ValueTuple<Type, string> key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)key));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_ValueTuple_2_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarshalerInstanceKeyComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarshalerInstanceKeyComparer>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public MarshalerInstanceKeyComparer(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("System.Runtime.InteropServices.Marshal+<>c")]
	public sealed class __c : Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__201_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__GetCustomMarshalerInstance_b__201_0_Internal_Dictionary_2_ValueTuple_2_Type_String_ICustomMarshaler_0;

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

		public unsafe static Func<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>> __9__201_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__201_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Func<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__201_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__201_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__201_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100671346);
			NativeMethodInfoPtr__GetCustomMarshalerInstance_b__201_0_Internal_Dictionary_2_ValueTuple_2_Type_String_ICustomMarshaler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100671347);
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
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804625, XrefRangeEnd = 804635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<ValueTuple<Type, string>, ICustomMarshaler> _GetCustomMarshalerInstance_b__201_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__GetCustomMarshalerInstance_b__201_0_Internal_Dictionary_2_ValueTuple_2_Type_String_ICustomMarshaler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>>(intPtr2) : null;
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_PtrToStructure_Public_Static_T_IntPtr_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0<TDelegate>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0<TDelegate>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0, Il2CppClassPointerStore<Marshal>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_SystemMaxDBCSCharSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_SystemDefaultCharSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_MarshalerInstanceCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_MarshalerInstanceCacheLock;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocCoTaskMem_Public_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_copy_to_unmanaged_fixed_Private_Static_Void_Array_Int32_IntPtr_Int32_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_skip_fixed_Private_Static_Boolean_Array_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int16_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int32_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_copy_from_unmanaged_fixed_Private_Static_Void_IntPtr_Int32_Array_Int32_ptr_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int16_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int64_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeCoTaskMem_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OffsetOf_Public_Static_IntPtr_Type_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToHGlobalAnsi_Private_Static_IntPtr_ptr_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToHGlobalAnsi_Public_Static_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToHGlobalUni_Private_Static_IntPtr_ptr_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StringToHGlobalUni_Public_Static_IntPtr_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SecureStringGlobalAllocator_Internal_Static_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SecureStringToUnicode_Internal_Static_IntPtr_SecureString_SecureStringAllocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegateForFunctionPointerInternal_Private_Static_Delegate_IntPtr_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_Delegate_IntPtr_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_Delegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomMarshalerInstance_Internal_Static_ICustomMarshaler_Type_String_0;

	public unsafe static int SystemMaxDBCSCharSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SystemMaxDBCSCharSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SystemMaxDBCSCharSize, (void*)(&value));
		}
	}

	public unsafe static int SystemDefaultCharSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SystemDefaultCharSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SystemDefaultCharSize, (void*)(&value));
		}
	}

	public unsafe static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MarshalerInstanceCache, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MarshalerInstanceCache, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Object MarshalerInstanceCacheLock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MarshalerInstanceCacheLock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MarshalerInstanceCacheLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Marshal()
	{
		Il2CppClassPointerStore<Marshal>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "Marshal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Marshal>.NativeClassPtr);
		NativeFieldInfoPtr_SystemMaxDBCSCharSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "SystemMaxDBCSCharSize");
		NativeFieldInfoPtr_SystemDefaultCharSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "SystemDefaultCharSize");
		NativeFieldInfoPtr_MarshalerInstanceCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "MarshalerInstanceCache");
		NativeFieldInfoPtr_MarshalerInstanceCacheLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Marshal>.NativeClassPtr, "MarshalerInstanceCacheLock");
		NativeMethodInfoPtr_AllocCoTaskMem_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671281);
		NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671282);
		NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671283);
		NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671284);
		NativeMethodInfoPtr_copy_to_unmanaged_fixed_Private_Static_Void_Array_Int32_IntPtr_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671285);
		NativeMethodInfoPtr_skip_fixed_Private_Static_Boolean_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671286);
		NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671287);
		NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671288);
		NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int16_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671289);
		NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int32_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671290);
		NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671291);
		NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671292);
		NativeMethodInfoPtr_copy_from_unmanaged_fixed_Private_Static_Void_IntPtr_Int32_Array_Int32_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671293);
		NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671294);
		NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671295);
		NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int16_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671296);
		NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671297);
		NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int64_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671298);
		NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671299);
		NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671300);
		NativeMethodInfoPtr_FreeCoTaskMem_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671301);
		NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671302);
		NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671303);
		NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671304);
		NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671305);
		NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671306);
		NativeMethodInfoPtr_OffsetOf_Public_Static_IntPtr_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671307);
		NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671308);
		NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671309);
		NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671310);
		NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671311);
		NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671312);
		NativeMethodInfoPtr_PtrToStructure_Public_Static_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671313);
		NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671314);
		NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671315);
		NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671316);
		NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671317);
		NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671318);
		NativeMethodInfoPtr_SizeOf_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671319);
		NativeMethodInfoPtr_StringToHGlobalAnsi_Private_Static_IntPtr_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671320);
		NativeMethodInfoPtr_StringToHGlobalAnsi_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671321);
		NativeMethodInfoPtr_StringToHGlobalUni_Private_Static_IntPtr_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671322);
		NativeMethodInfoPtr_StringToHGlobalUni_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671323);
		NativeMethodInfoPtr_SecureStringGlobalAllocator_Internal_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671324);
		NativeMethodInfoPtr_SecureStringToUnicode_Internal_Static_IntPtr_SecureString_SecureStringAllocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671325);
		NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671326);
		NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671327);
		NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671328);
		NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671329);
		NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671330);
		NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671331);
		NativeMethodInfoPtr_GetDelegateForFunctionPointerInternal_Private_Static_Delegate_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671332);
		NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_Delegate_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671333);
		NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671334);
		NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671335);
		NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671336);
		NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671337);
		NativeMethodInfoPtr_GetCustomMarshalerInstance_Internal_Static_ICustomMarshaler_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Marshal>.NativeClassPtr, 100671338);
	}

	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 804636, RefRangeEnd = 804651, XrefRangeStart = 804635, XrefRangeEnd = 804636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr AllocCoTaskMem(int cb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocCoTaskMem_Public_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804651, XrefRangeEnd = 804652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr AllocHGlobal(System.IntPtr cb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 804657, RefRangeEnd = 804673, XrefRangeStart = 804652, XrefRangeEnd = 804657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr AllocHGlobal(int cb)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cb);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocHGlobal_Public_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 804677, RefRangeEnd = 804680, XrefRangeStart = 804673, XrefRangeEnd = 804677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void copy_to_unmanaged(Array source, int startIndex, System.IntPtr destination, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Array_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804680, XrefRangeEnd = 804681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void copy_to_unmanaged_fixed(Array source, int startIndex, System.IntPtr destination, int length, void* fixed_source_element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = fixed_source_element;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_copy_to_unmanaged_fixed_Private_Static_Void_Array_Int32_IntPtr_Int32_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static bool skip_fixed(Array array, int startIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_skip_fixed_Private_Static_Boolean_Array_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804681, XrefRangeEnd = 804691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void copy_to_unmanaged(Il2CppStructArray<byte> source, int startIndex, System.IntPtr destination, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_copy_to_unmanaged_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 804710, RefRangeEnd = 804722, XrefRangeStart = 804691, XrefRangeEnd = 804710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(Il2CppStructArray<byte> source, int startIndex, System.IntPtr destination, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Byte_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804733, RefRangeEnd = 804734, XrefRangeStart = 804722, XrefRangeEnd = 804733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(Il2CppStructArray<short> source, int startIndex, System.IntPtr destination, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int16_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 804745, RefRangeEnd = 804750, XrefRangeStart = 804734, XrefRangeEnd = 804745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(Il2CppStructArray<int> source, int startIndex, System.IntPtr destination, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_Int32_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804761, RefRangeEnd = 804762, XrefRangeStart = 804750, XrefRangeEnd = 804761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(Il2CppStructArray<System.IntPtr> source, int startIndex, System.IntPtr destination, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destination;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_Il2CppStructArray_1_IntPtr_Int32_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 804766, RefRangeEnd = 804772, XrefRangeStart = 804762, XrefRangeEnd = 804766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void copy_from_unmanaged(System.IntPtr source, int startIndex, Array destination, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_copy_from_unmanaged_Internal_Static_Void_IntPtr_Int32_Array_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804772, XrefRangeEnd = 804773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void copy_from_unmanaged_fixed(System.IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = fixed_destination_element;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_copy_from_unmanaged_fixed_Private_Static_Void_IntPtr_Int32_Array_Int32_ptr_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 804784, RefRangeEnd = 804801, XrefRangeStart = 804773, XrefRangeEnd = 804784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(System.IntPtr source, Il2CppStructArray<byte> destination, int startIndex, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Byte_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804812, RefRangeEnd = 804814, XrefRangeStart = 804801, XrefRangeEnd = 804812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(System.IntPtr source, Il2CppStructArray<char> destination, int startIndex, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Char_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804825, RefRangeEnd = 804827, XrefRangeStart = 804814, XrefRangeEnd = 804825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(System.IntPtr source, Il2CppStructArray<short> destination, int startIndex, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int16_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804838, RefRangeEnd = 804839, XrefRangeStart = 804827, XrefRangeEnd = 804838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(System.IntPtr source, Il2CppStructArray<int> destination, int startIndex, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804839, XrefRangeEnd = 804850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(System.IntPtr source, Il2CppStructArray<long> destination, int startIndex, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_Int64_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804861, RefRangeEnd = 804862, XrefRangeStart = 804850, XrefRangeEnd = 804861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Copy(System.IntPtr source, Il2CppStructArray<System.IntPtr> destination, int startIndex, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&source);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)destination);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_Static_Void_IntPtr_Il2CppStructArray_1_IntPtr_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804863, RefRangeEnd = 804864, XrefRangeStart = 804862, XrefRangeEnd = 804863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FreeBSTR(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeBSTR_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 804865, RefRangeEnd = 804881, XrefRangeStart = 804864, XrefRangeEnd = 804865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FreeCoTaskMem(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeCoTaskMem_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 804882, RefRangeEnd = 804907, XrefRangeStart = 804881, XrefRangeEnd = 804882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FreeHGlobal(System.IntPtr hglobal)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&hglobal);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FreeHGlobal_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804907, XrefRangeEnd = 804919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearUnicode(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearUnicode_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 804946, RefRangeEnd = 804949, XrefRangeStart = 804919, XrefRangeEnd = 804946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ZeroFreeGlobalAllocUnicode(System.IntPtr s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ZeroFreeGlobalAllocUnicode_Public_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static int GetHRForException(Exception e)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)e);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHRForException_Public_Static_Int32_Exception_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 804950, RefRangeEnd = 804977, XrefRangeStart = 804949, XrefRangeEnd = 804950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetLastWin32Error()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLastWin32Error_Public_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804978, RefRangeEnd = 804980, XrefRangeStart = 804977, XrefRangeEnd = 804978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr OffsetOf(Type t, string fieldName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(fieldName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OffsetOf_Public_Static_IntPtr_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 804981, RefRangeEnd = 804986, XrefRangeStart = 804980, XrefRangeEnd = 804981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string PtrToStringAnsi(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804987, RefRangeEnd = 804988, XrefRangeStart = 804986, XrefRangeEnd = 804987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string PtrToStringAnsi(System.IntPtr ptr, int len)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(int**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PtrToStringAnsi_Public_Static_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804989, RefRangeEnd = 804991, XrefRangeStart = 804988, XrefRangeEnd = 804989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string PtrToStringUni(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 804992, RefRangeEnd = 804994, XrefRangeStart = 804991, XrefRangeEnd = 804992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string PtrToStringUni(System.IntPtr ptr, int len)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(int**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &len;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PtrToStringUni_Public_Static_String_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 804995, RefRangeEnd = 805002, XrefRangeStart = 804994, XrefRangeEnd = 804995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object PtrToStructure(System.IntPtr ptr, Type structureType)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)structureType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PtrToStructure_Public_Static_Object_IntPtr_Type_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805011, RefRangeEnd = 805012, XrefRangeStart = 805002, XrefRangeEnd = 805011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T PtrToStructure<T>(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_PtrToStructure_Public_Static_T_IntPtr_0<T>.Pointer, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805013, RefRangeEnd = 805014, XrefRangeStart = 805012, XrefRangeEnd = 805013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte ReadByte(System.IntPtr ptr, int ofs)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(int**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ofs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadByte_Public_Static_Byte_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805014, XrefRangeEnd = 805016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static short ReadInt16(System.IntPtr ptr, int ofs)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(int**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ofs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReadInt16_Public_Static_Int16_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(short*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805016, XrefRangeEnd = 805017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ReleaseInternal(System.IntPtr pUnk)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pUnk);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReleaseInternal_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805027, RefRangeEnd = 805028, XrefRangeStart = 805017, XrefRangeEnd = 805027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Release(System.IntPtr pUnk)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&pUnk);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Release_Public_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 805029, RefRangeEnd = 805058, XrefRangeStart = 805028, XrefRangeEnd = 805029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SizeOf(Type t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SizeOf_Public_Static_Int32_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 805066, RefRangeEnd = 805082, XrefRangeStart = 805058, XrefRangeEnd = 805066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int SizeOf<T>()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SizeOf_Public_Static_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805082, XrefRangeEnd = 805083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr StringToHGlobalAnsi(char* s, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)s;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToHGlobalAnsi_Private_Static_IntPtr_ptr_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 805089, RefRangeEnd = 805093, XrefRangeStart = 805083, XrefRangeEnd = 805089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr StringToHGlobalAnsi(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToHGlobalAnsi_Public_Static_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805093, XrefRangeEnd = 805094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr StringToHGlobalUni(char* s, int length)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)s;
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToHGlobalUni_Private_Static_IntPtr_ptr_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 805100, RefRangeEnd = 805102, XrefRangeStart = 805094, XrefRangeEnd = 805100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr StringToHGlobalUni(string s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StringToHGlobalUni_Public_Static_IntPtr_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805102, XrefRangeEnd = 805110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr SecureStringGlobalAllocator(int len)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&len);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SecureStringGlobalAllocator_Internal_Static_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805127, RefRangeEnd = 805128, XrefRangeStart = 805110, XrefRangeEnd = 805127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr SecureStringToUnicode(SecureString s, SecureStringAllocator allocator)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)allocator);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SecureStringToUnicode_Internal_Static_IntPtr_SecureString_SecureStringAllocator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805144, RefRangeEnd = 805145, XrefRangeStart = 805128, XrefRangeEnd = 805144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr SecureStringToGlobalAllocUnicode(SecureString s)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)s);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SecureStringToGlobalAllocUnicode_Public_Static_IntPtr_SecureString_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805146, RefRangeEnd = 805147, XrefRangeStart = 805145, XrefRangeEnd = 805146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StructureToPtr(Object structure, System.IntPtr ptr, bool fDeleteOld)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)structure);
		*(System.IntPtr**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ptr;
		*(bool**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fDeleteOld;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_StructureToPtr_Public_Static_Void_Object_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805147, XrefRangeEnd = 805155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StructureToPtr<T>(T structure, System.IntPtr ptr, bool fDeleteOld)
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			object obj = structure;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref structure;
		}
		*ptr2 = (nint)Unsafe.AsPointer(ref reference);
		*(System.IntPtr**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ptr;
		*(bool**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fDeleteOld;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_StructureToPtr_Public_Static_Void_T_IntPtr_Boolean_0<T>.Pointer, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 805156, RefRangeEnd = 805158, XrefRangeStart = 805155, XrefRangeEnd = 805156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Array_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 805187, RefRangeEnd = 805189, XrefRangeStart = 805158, XrefRangeEnd = 805187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr UnsafeAddrOfPinnedArrayElement<T>(Il2CppArrayBase<T> arr, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)arr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_UnsafeAddrOfPinnedArrayElement_Public_Static_IntPtr_Il2CppArrayBase_1_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805189, XrefRangeEnd = 805191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void WriteInt16(System.IntPtr ptr, int ofs, short val)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[3];
		*ptr2 = (nint)(&ptr);
		*(int**)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ofs;
		*(short**)((byte*)ptr2 + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &val;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_WriteInt16_Public_Static_Void_IntPtr_Int32_Int16_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805191, XrefRangeEnd = 805192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Delegate GetDelegateForFunctionPointerInternal(System.IntPtr ptr, Type t)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDelegateForFunctionPointerInternal_Private_Static_Delegate_IntPtr_Type_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805235, RefRangeEnd = 805236, XrefRangeStart = 805192, XrefRangeEnd = 805235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Delegate GetDelegateForFunctionPointer(System.IntPtr ptr, Type t)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = (nint)(&ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDelegateForFunctionPointer_Public_Static_Delegate_IntPtr_Type_0, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Delegate>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805245, RefRangeEnd = 805246, XrefRangeStart = 805236, XrefRangeEnd = 805245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static TDelegate GetDelegateForFunctionPointer<TDelegate>(System.IntPtr ptr)
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[1];
		*ptr2 = (nint)(&ptr);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetDelegateForFunctionPointer_Public_Static_TDelegate_IntPtr_0<TDelegate>.Pointer, (System.IntPtr)0, (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<TDelegate>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805247, RefRangeEnd = 805248, XrefRangeStart = 805246, XrefRangeEnd = 805247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetFunctionPointerForDelegateInternal(Delegate d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerForDelegateInternal_Private_Static_IntPtr_Delegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 805258, RefRangeEnd = 805259, XrefRangeStart = 805248, XrefRangeEnd = 805258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetFunctionPointerForDelegate(Delegate d)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)d);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetFunctionPointerForDelegate_Public_Static_IntPtr_Delegate_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 805283, RefRangeEnd = 805292, XrefRangeStart = 805259, XrefRangeEnd = 805283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d)
	{
		//IL_0045->IL0048: Incompatible stack types: I vs Ref
		//IL_0038->IL0048: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref TDelegate reference;
		if (!typeof(TDelegate).IsValueType)
		{
			object obj = d;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref d;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GetFunctionPointerForDelegate_Public_Static_IntPtr_TDelegate_0<TDelegate>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805292, XrefRangeEnd = 805379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(cookie);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomMarshalerInstance_Internal_Static_ICustomMarshaler_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICustomMarshaler>(intPtr2) : null;
	}

	public Marshal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
