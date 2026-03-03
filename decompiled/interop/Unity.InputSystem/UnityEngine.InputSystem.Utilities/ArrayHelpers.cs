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

namespace UnityEngine.InputSystem.Utilities;

public static class ArrayHelpers : Il2CppSystem.Object
{
	[ObfuscatedName("UnityEngine.InputSystem.Utilities.ArrayHelpers+<>c__DisplayClass33_0`1")]
	public sealed class __c__DisplayClass33_0<TValue> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_secondValue;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Merge_b__0_Internal_Boolean_TValue_0;

		public unsafe TValue secondValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondValue);
				return IL2CPP.PointerToValueGeneric<TValue>((System.IntPtr)num, true, false);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondValue);
				System.Type typeFromHandle = typeof(TValue);
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
							Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr2), ref *(uint*)null));
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
					Unsafe.Write((void*)num2, value);
				}
			}
		}

		static __c__DisplayClass33_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass33_0<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, "<>c__DisplayClass33_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass33_0<TValue>>.NativeClassPtr);
			NativeFieldInfoPtr_secondValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass33_0<TValue>>.NativeClassPtr, "secondValue");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass33_0<TValue>>.NativeClassPtr, 100668658);
			NativeMethodInfoPtr__Merge_b__0_Internal_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass33_0<TValue>>.NativeClassPtr, 100668659);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass33_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass33_0<TValue>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015739, XrefRangeEnd = 1015740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Merge_b__0(TValue x)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref TValue reference;
			if (!typeof(TValue).IsValueType)
			{
				object obj = x;
				reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
			}
			else
			{
				reference = ref x;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Merge_b__0_Internal_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c__DisplayClass33_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.InputSystem.Utilities.ArrayHelpers+<>c__DisplayClass34_0`1")]
	public sealed class __c__DisplayClass34_0<TValue> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_comparer;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe IEqualityComparer<TValue> comparer
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_comparer);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEqualityComparer<TValue>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_comparer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass34_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass34_0<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, "<>c__DisplayClass34_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass34_0<TValue>>.NativeClassPtr);
			NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass34_0<TValue>>.NativeClassPtr, "comparer");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass34_0<TValue>>.NativeClassPtr, 100668660);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass34_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass34_0<TValue>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c__DisplayClass34_0(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[ObfuscatedName("UnityEngine.InputSystem.Utilities.ArrayHelpers+<>c__DisplayClass34_1`1")]
	public sealed class __c__DisplayClass34_1<TValue> : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_secondValue;

		private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass34_0_1_TValue_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__Merge_b__0_Internal_Boolean_TValue_0;

		public unsafe TValue secondValue
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondValue);
				return IL2CPP.PointerToValueGeneric<TValue>((System.IntPtr)num, true, false);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				nint num2 = (nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_secondValue);
				System.Type typeFromHandle = typeof(TValue);
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
							Unsafe.CopyBlock(num2, IL2CPP.il2cpp_object_unbox(intPtr), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr2), ref *(uint*)null));
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
					Unsafe.Write((void*)num2, value);
				}
			}
		}

		public unsafe __c__DisplayClass34_0<TValue> field_Public___c__DisplayClass34_0_1_TValue_0
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass34_0_1_TValue_0);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c__DisplayClass34_0<TValue>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_field_Public___c__DisplayClass34_0_1_TValue_0)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass34_1()
		{
			Il2CppClassPointerStore<__c__DisplayClass34_1<TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, "<>c__DisplayClass34_1`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass34_1<TValue>>.NativeClassPtr);
			NativeFieldInfoPtr_secondValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass34_1<TValue>>.NativeClassPtr, "secondValue");
			NativeFieldInfoPtr_field_Public___c__DisplayClass34_0_1_TValue_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass34_1<TValue>>.NativeClassPtr, "CS$<>8__locals1");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass34_1<TValue>>.NativeClassPtr, 100668661);
			NativeMethodInfoPtr__Merge_b__0_Internal_Boolean_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c__DisplayClass34_1<TValue>>.NativeClassPtr, 100668662);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass34_1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass34_1<TValue>>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015740, XrefRangeEnd = 1015745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Merge_b__0(TValue x)
		{
			//IL_004c->IL004f: Incompatible stack types: I vs Ref
			//IL_003f->IL004f: Incompatible stack types: I vs Ref
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			ref TValue reference;
			if (!typeof(TValue).IsValueType)
			{
				object obj = x;
				reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
			}
			else
			{
				reference = ref x;
			}
			*ptr = (nint)Unsafe.AsPointer(ref reference);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__Merge_b__0_Internal_Boolean_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public __c__DisplayClass34_1(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_LengthSafe_Public_Static_Int32_Il2CppArrayBase_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_LengthSafe_Public_Static_Int32_Il2CppArrayBase_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EnsureCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EnsureCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_DuplicateWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_DuplicateWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Contains_Public_Static_Boolean_Il2CppArrayBase_1_TValue_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppArrayBase_1_TValue_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TValue_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TValue_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_TSecond_0<TFirst, TSecond>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_TSecond_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFirst>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSecond>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_Int32_TSecond_0<TFirst, TSecond>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_Int32_TSecond_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFirst>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSecond>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_HaveDuplicateReferences_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_Int32_0<TFirst>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_HaveDuplicateReferences_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFirst>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_HaveEqualElements_Public_Static_Boolean_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_HaveEqualElements_Public_Static_Boolean_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_TValue_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_TValue_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_Predicate_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_Predicate_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_Predicate_1_TValue_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_Predicate_1_TValue_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_IndexOfReference_Public_Static_Int32_Il2CppArrayBase_1_TFirst_TSecond_Int32_0<TFirst, TSecond>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_Il2CppArrayBase_1_TFirst_TSecond_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFirst>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSecond>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_IndexOfReference_Public_Static_Int32_Il2CppArrayBase_1_TFirst_TSecond_Int32_Int32_0<TFirst, TSecond>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_Il2CppArrayBase_1_TFirst_TSecond_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TFirst>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSecond>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_IndexOfValue_Public_Static_Int32_Il2CppArrayBase_1_TValue_TValue_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_IndexOfValue_Public_Static_Int32_Il2CppArrayBase_1_TValue_TValue_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_NativeArray_1_TValue_Int32_Allocator_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Resize_Public_Static_Void_byref_NativeArray_1_TValue_Int32_Allocator_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Append_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Append_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Append_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_IEnumerable_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Append_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_IEnumerable_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AppendToImmutable_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AppendToImmutable_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AppendWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_TValue_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AppendWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_TValue_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_AppendListWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_TValues_Int32_0<TValue, TValues>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AppendListWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_TValues_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValues>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_AppendWithCapacity_Public_Static_Int32_byref_NativeArray_1_TValue_byref_Int32_TValue_Int32_Allocator_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_AppendWithCapacity_Public_Static_Int32_byref_NativeArray_1_TValue_byref_Int32_TValue_Int32_Allocator_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InsertAt_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InsertAt_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InsertAtWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_TValue_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InsertAtWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_TValue_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_PutAtIfNotSet_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Func_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_PutAtIfNotSet_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Func_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GrowBy_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GrowBy_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GrowBy_Public_Static_Int32_byref_NativeArray_1_TValue_Int32_Allocator_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GrowBy_Public_Static_Int32_byref_NativeArray_1_TValue_Int32_Allocator_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GrowWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GrowWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_GrowWithCapacity_Public_Static_Int32_byref_NativeArray_1_TValue_byref_Int32_Int32_Int32_Allocator_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_GrowWithCapacity_Public_Static_Int32_byref_NativeArray_1_TValue_byref_Int32_Int32_Int32_Allocator_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Join_Public_Static_Il2CppArrayBase_1_TValue_TValue_Il2CppArrayBase_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Join_Public_Static_Il2CppArrayBase_1_TValue_TValue_Il2CppArrayBase_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Merge_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Merge_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Merge_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_IEqualityComparer_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Merge_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_IEqualityComparer_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EraseAt_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EraseAt_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EraseAtWithCapacity_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EraseAtWithCapacity_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EraseAtWithCapacity_Public_Static_Void_NativeArray_1_TValue_byref_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EraseAtWithCapacity_Public_Static_Void_NativeArray_1_TValue_byref_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Erase_Public_Static_Boolean_byref_Il2CppArrayBase_1_TValue_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Erase_Public_Static_Boolean_byref_Il2CppArrayBase_1_TValue_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EraseAtByMovingTail_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EraseAtByMovingTail_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Copy_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Copy_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Clone_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Clone_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Select_Public_Static_Il2CppArrayBase_1_TNew_Il2CppArrayBase_1_TOld_Func_2_TOld_TNew_0<TOld, TNew>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Select_Public_Static_Il2CppArrayBase_1_TNew_Il2CppArrayBase_1_TOld_Func_2_TOld_TNew_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
		{
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOld>.NativeClassPtr)),
			Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNew>.NativeClassPtr))
		}))));
	}

	private sealed class MethodInfoStoreGeneric_Swap_Private_Static_Void_byref_TValue_byref_TValue_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Swap_Private_Static_Void_byref_TValue_byref_TValue_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_MoveSlice_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_MoveSlice_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_EraseSliceWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_EraseSliceWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SwapElements_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SwapElements_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_SwapElements_Public_Static_Void_NativeArray_1_TValue_Int32_Int32_0<TValue>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_SwapElements_Public_Static_Void_NativeArray_1_TValue_Int32_Int32_0, Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_LengthSafe_Public_Static_Int32_Il2CppArrayBase_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnsureCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DuplicateWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppArrayBase_1_TValue_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TValue_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_TSecond_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_Int32_TSecond_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveDuplicateReferences_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HaveEqualElements_Public_Static_Boolean_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_TValue_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_Predicate_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_Predicate_1_TValue_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_Il2CppArrayBase_1_TFirst_TSecond_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_Il2CppArrayBase_1_TFirst_TSecond_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IndexOfValue_Public_Static_Int32_Il2CppArrayBase_1_TValue_TValue_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resize_Public_Static_Void_byref_NativeArray_1_TValue_Int32_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Append_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_IEnumerable_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendToImmutable_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_TValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendListWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_TValues_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AppendWithCapacity_Public_Static_Int32_byref_NativeArray_1_TValue_byref_Int32_TValue_Int32_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertAt_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertAtWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_TValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PutAtIfNotSet_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Func_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GrowBy_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GrowBy_Public_Static_Int32_byref_NativeArray_1_TValue_Int32_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GrowWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GrowWithCapacity_Public_Static_Int32_byref_NativeArray_1_TValue_byref_Int32_Int32_Int32_Allocator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Join_Public_Static_Il2CppArrayBase_1_TValue_TValue_Il2CppArrayBase_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Merge_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Merge_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_IEqualityComparer_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EraseAt_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EraseAtWithCapacity_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EraseAtWithCapacity_Public_Static_Void_NativeArray_1_TValue_byref_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Erase_Public_Static_Boolean_byref_Il2CppArrayBase_1_TValue_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EraseAtByMovingTail_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Select_Public_Static_Il2CppArrayBase_1_TNew_Il2CppArrayBase_1_TOld_Func_2_TOld_TNew_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Swap_Private_Static_Void_byref_TValue_byref_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MoveSlice_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EraseSliceWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwapElements_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwapElements_Public_Static_Void_NativeArray_1_TValue_Int32_Int32_0;

	static ArrayHelpers()
	{
		Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem.Utilities", "ArrayHelpers");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr);
		NativeMethodInfoPtr_LengthSafe_Public_Static_Int32_Il2CppArrayBase_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668610);
		NativeMethodInfoPtr_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668611);
		NativeMethodInfoPtr_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668612);
		NativeMethodInfoPtr_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668613);
		NativeMethodInfoPtr_EnsureCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668614);
		NativeMethodInfoPtr_DuplicateWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668615);
		NativeMethodInfoPtr_Contains_Public_Static_Boolean_Il2CppArrayBase_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668616);
		NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668617);
		NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_TSecond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668618);
		NativeMethodInfoPtr_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_Int32_TSecond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668619);
		NativeMethodInfoPtr_HaveDuplicateReferences_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668620);
		NativeMethodInfoPtr_HaveEqualElements_Public_Static_Boolean_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668621);
		NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_TValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668622);
		NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_Predicate_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668623);
		NativeMethodInfoPtr_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_Predicate_1_TValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668624);
		NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_Il2CppArrayBase_1_TFirst_TSecond_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668625);
		NativeMethodInfoPtr_IndexOfReference_Public_Static_Int32_Il2CppArrayBase_1_TFirst_TSecond_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668626);
		NativeMethodInfoPtr_IndexOfValue_Public_Static_Int32_Il2CppArrayBase_1_TValue_TValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668627);
		NativeMethodInfoPtr_Resize_Public_Static_Void_byref_NativeArray_1_TValue_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668628);
		NativeMethodInfoPtr_Append_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668629);
		NativeMethodInfoPtr_Append_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_IEnumerable_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668630);
		NativeMethodInfoPtr_AppendToImmutable_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668631);
		NativeMethodInfoPtr_AppendWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668632);
		NativeMethodInfoPtr_AppendListWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_TValues_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668633);
		NativeMethodInfoPtr_AppendWithCapacity_Public_Static_Int32_byref_NativeArray_1_TValue_byref_Int32_TValue_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668634);
		NativeMethodInfoPtr_InsertAt_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668635);
		NativeMethodInfoPtr_InsertAtWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668636);
		NativeMethodInfoPtr_PutAtIfNotSet_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Func_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668637);
		NativeMethodInfoPtr_GrowBy_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668638);
		NativeMethodInfoPtr_GrowBy_Public_Static_Int32_byref_NativeArray_1_TValue_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668639);
		NativeMethodInfoPtr_GrowWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668640);
		NativeMethodInfoPtr_GrowWithCapacity_Public_Static_Int32_byref_NativeArray_1_TValue_byref_Int32_Int32_Int32_Allocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668641);
		NativeMethodInfoPtr_Join_Public_Static_Il2CppArrayBase_1_TValue_TValue_Il2CppArrayBase_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668642);
		NativeMethodInfoPtr_Merge_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668643);
		NativeMethodInfoPtr_Merge_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_IEqualityComparer_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668644);
		NativeMethodInfoPtr_EraseAt_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668645);
		NativeMethodInfoPtr_EraseAtWithCapacity_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668646);
		NativeMethodInfoPtr_EraseAtWithCapacity_Public_Static_Void_NativeArray_1_TValue_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668647);
		NativeMethodInfoPtr_Erase_Public_Static_Boolean_byref_Il2CppArrayBase_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668648);
		NativeMethodInfoPtr_EraseAtByMovingTail_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668649);
		NativeMethodInfoPtr_Copy_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668650);
		NativeMethodInfoPtr_Clone_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668651);
		NativeMethodInfoPtr_Select_Public_Static_Il2CppArrayBase_1_TNew_Il2CppArrayBase_1_TOld_Func_2_TOld_TNew_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668652);
		NativeMethodInfoPtr_Swap_Private_Static_Void_byref_TValue_byref_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668653);
		NativeMethodInfoPtr_MoveSlice_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668654);
		NativeMethodInfoPtr_EraseSliceWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668655);
		NativeMethodInfoPtr_SwapElements_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668656);
		NativeMethodInfoPtr_SwapElements_Public_Static_Void_NativeArray_1_TValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayHelpers>.NativeClassPtr, 100668657);
	}

	[CallerCount(47)]
	[CachedScanResults(RefRangeStart = 1015745, RefRangeEnd = 1015792, XrefRangeStart = 1015745, XrefRangeEnd = 1015745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int LengthSafe<TValue>(this Il2CppArrayBase<TValue> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_LengthSafe_Public_Static_Int32_Il2CppArrayBase_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1015793, RefRangeEnd = 1015795, XrefRangeStart = 1015792, XrefRangeEnd = 1015793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear<TValue>(this Il2CppArrayBase<TValue> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1015796, RefRangeEnd = 1015799, XrefRangeStart = 1015795, XrefRangeEnd = 1015796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear<TValue>(this Il2CppArrayBase<TValue> array, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1015800, RefRangeEnd = 1015801, XrefRangeStart = 1015799, XrefRangeEnd = 1015800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Clear<TValue>(this Il2CppArrayBase<TValue> array, ref int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref count);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Clear_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1015818, RefRangeEnd = 1015820, XrefRangeStart = 1015801, XrefRangeEnd = 1015818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnsureCapacity<TValue>(ref Il2CppArrayBase<TValue> array, int count, int capacity, int capacityIncrement = 10)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacity;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacityIncrement;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EnsureCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015820, XrefRangeEnd = 1015843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DuplicateWithCapacity<TValue>(ref Il2CppArrayBase<TValue> array, int count, int capacity, int capacityIncrement = 10)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacity;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacityIncrement;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_DuplicateWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1015847, RefRangeEnd = 1015850, XrefRangeStart = 1015843, XrefRangeEnd = 1015847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Contains<TValue>(Il2CppArrayBase<TValue> array, TValue value)
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Contains_Public_Static_Boolean_Il2CppArrayBase_1_TValue_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1015853, RefRangeEnd = 1015855, XrefRangeStart = 1015850, XrefRangeEnd = 1015853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ContainsReference<TValue>(this Il2CppArrayBase<TValue> array, TValue value) where TValue : class
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			TValue val = value;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TValue_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1015857, RefRangeEnd = 1015861, XrefRangeStart = 1015855, XrefRangeEnd = 1015857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ContainsReference<TFirst, TSecond>(this Il2CppArrayBase<TFirst> array, int count, TSecond value) where TFirst : TSecond where TSecond : class
	{
		//IL_0065->IL0068: Incompatible stack types: I vs Ref
		//IL_0058->IL0068: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TSecond reference;
		if (!typeof(TSecond).IsValueType)
		{
			TSecond val = value;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_TSecond_0<TFirst, TSecond>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1015862, RefRangeEnd = 1015863, XrefRangeStart = 1015861, XrefRangeEnd = 1015862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ContainsReference<TFirst, TSecond>(this Il2CppArrayBase<TFirst> array, int startIndex, int count, TSecond value) where TFirst : TSecond where TSecond : class
	{
		//IL_0073->IL0076: Incompatible stack types: I vs Ref
		//IL_0066->IL0076: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TSecond reference;
		if (!typeof(TSecond).IsValueType)
		{
			TSecond val = value;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_ContainsReference_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_Int32_TSecond_0<TFirst, TSecond>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1015863, RefRangeEnd = 1015864, XrefRangeStart = 1015863, XrefRangeEnd = 1015863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HaveDuplicateReferences<TFirst>(this Il2CppArrayBase<TFirst> first, int index, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)first);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_HaveDuplicateReferences_Public_Static_Boolean_Il2CppArrayBase_1_TFirst_Int32_Int32_0<TFirst>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015864, XrefRangeEnd = 1015878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HaveEqualElements<TValue>(Il2CppArrayBase<TValue> first, Il2CppArrayBase<TValue> second, int count = int.MaxValue)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)first);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)second);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_HaveEqualElements_Public_Static_Boolean_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015878, XrefRangeEnd = 1015880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOf<TValue>(Il2CppArrayBase<TValue> array, TValue value, int startIndex = 0, int count = -1)
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_TValue_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1015881, RefRangeEnd = 1015882, XrefRangeStart = 1015880, XrefRangeEnd = 1015881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOf<TValue>(this Il2CppArrayBase<TValue> array, Il2CppSystem.Predicate<TValue> predicate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_Predicate_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015882, XrefRangeEnd = 1015885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOf<TValue>(this Il2CppArrayBase<TValue> array, Il2CppSystem.Predicate<TValue> predicate, int startIndex = 0, int count = -1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)predicate);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IndexOf_Public_Static_Int32_Il2CppArrayBase_1_TValue_Predicate_1_TValue_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(19)]
	[CachedScanResults(RefRangeStart = 1015886, RefRangeEnd = 1015905, XrefRangeStart = 1015885, XrefRangeEnd = 1015886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOfReference<TFirst, TSecond>(this Il2CppArrayBase<TFirst> array, TSecond value, int count = -1) where TFirst : TSecond where TSecond : class
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TSecond reference;
		if (!typeof(TSecond).IsValueType)
		{
			TSecond val = value;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IndexOfReference_Public_Static_Int32_Il2CppArrayBase_1_TFirst_TSecond_Int32_0<TFirst, TSecond>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1015905, RefRangeEnd = 1015906, XrefRangeStart = 1015905, XrefRangeEnd = 1015905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOfReference<TFirst, TSecond>(this Il2CppArrayBase<TFirst> array, TSecond value, int startIndex, int count) where TFirst : TSecond where TSecond : class
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TSecond reference;
		if (!typeof(TSecond).IsValueType)
		{
			TSecond val = value;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IndexOfReference_Public_Static_Int32_Il2CppArrayBase_1_TFirst_TSecond_Int32_Int32_0<TFirst, TSecond>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1015908, RefRangeEnd = 1015909, XrefRangeStart = 1015906, XrefRangeEnd = 1015908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOfValue<TValue>(this Il2CppArrayBase<TValue> array, TValue value, int startIndex = 0, int count = -1) where TValue : new()
	{
		//IL_0057->IL005a: Incompatible stack types: I vs Ref
		//IL_004a->IL005a: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &startIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_IndexOfValue_Public_Static_Int32_Il2CppArrayBase_1_TValue_TValue_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1015917, RefRangeEnd = 1015918, XrefRangeStart = 1015909, XrefRangeEnd = 1015917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Resize<TValue>(ref NativeArray<TValue> array, int newSize, Allocator allocator) where TValue : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &newSize;
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Resize_Public_Static_Void_byref_NativeArray_1_TValue_Int32_Allocator_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1015921, RefRangeEnd = 1015929, XrefRangeStart = 1015918, XrefRangeEnd = 1015921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Append<TValue>(ref Il2CppArrayBase<TValue> array, TValue value)
	{
		//IL_005d->IL0060: Incompatible stack types: I vs Ref
		//IL_0050->IL0060: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Append_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015929, XrefRangeEnd = 1015957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Append<TValue>(ref Il2CppArrayBase<TValue> array, IEnumerable<TValue> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Append_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_IEnumerable_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1015960, RefRangeEnd = 1015962, XrefRangeStart = 1015957, XrefRangeEnd = 1015960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AppendToImmutable<TValue>(ref Il2CppArrayBase<TValue> array, Il2CppArrayBase<TValue> values)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AppendToImmutable_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1015964, RefRangeEnd = 1015967, XrefRangeStart = 1015962, XrefRangeEnd = 1015964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AppendWithCapacity<TValue>(ref Il2CppArrayBase<TValue> array, ref int count, TValue value, int capacityIncrement = 10)
	{
		//IL_006b->IL006e: Incompatible stack types: I vs Ref
		//IL_005e->IL006e: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref count);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacityIncrement;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AppendWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_TValue_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1015984, RefRangeEnd = 1015985, XrefRangeStart = 1015967, XrefRangeEnd = 1015984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AppendListWithCapacity<TValue, TValues>(ref Il2CppArrayBase<TValue> array, ref int length, TValues values, int capacityIncrement = 10)
	{
		//IL_006b->IL006e: Incompatible stack types: I vs Ref
		//IL_005e->IL006e: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref length);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValues reference;
		if (!typeof(TValues).IsValueType)
		{
			object obj = values;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref values;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacityIncrement;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AppendListWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_TValues_Int32_0<TValue, TValues>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1015994, RefRangeEnd = 1015997, XrefRangeStart = 1015985, XrefRangeEnd = 1015994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AppendWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, TValue value, int capacityIncrement = 10, Allocator allocator = Allocator.Persistent) where TValue : new()
	{
		//IL_0066->IL0069: Incompatible stack types: I vs Ref
		//IL_0059->IL0069: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref count);
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacityIncrement;
		*(Allocator**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_AppendWithCapacity_Public_Static_Int32_byref_NativeArray_1_TValue_byref_Int32_TValue_Int32_Allocator_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016030, RefRangeEnd = 1016031, XrefRangeStart = 1015997, XrefRangeEnd = 1016030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertAt<TValue>(ref Il2CppArrayBase<TValue> array, int index, TValue value)
	{
		//IL_006a->IL006d: Incompatible stack types: I vs Ref
		//IL_005d->IL006d: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InsertAt_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016035, RefRangeEnd = 1016036, XrefRangeStart = 1016031, XrefRangeEnd = 1016035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertAtWithCapacity<TValue>(ref Il2CppArrayBase<TValue> array, ref int count, int index, TValue value, int capacityIncrement = 10)
	{
		//IL_0078->IL007b: Incompatible stack types: I vs Ref
		//IL_006b->IL007b: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref count);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacityIncrement;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InsertAtWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_TValue_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016036, XrefRangeEnd = 1016048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PutAtIfNotSet<TValue>(ref Il2CppArrayBase<TValue> array, int index, Il2CppSystem.Func<TValue> valueFn)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)valueFn);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_PutAtIfNotSet_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_Func_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1016050, RefRangeEnd = 1016052, XrefRangeStart = 1016048, XrefRangeEnd = 1016050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GrowBy<TValue>(ref Il2CppArrayBase<TValue> array, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GrowBy_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016052, XrefRangeEnd = 1016060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GrowBy<TValue>(ref NativeArray<TValue> array, int count, Allocator allocator = Allocator.Persistent) where TValue : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		*(Allocator**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GrowBy_Public_Static_Int32_byref_NativeArray_1_TValue_Int32_Allocator_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016060, XrefRangeEnd = 1016062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GrowWithCapacity<TValue>(ref Il2CppArrayBase<TValue> array, ref int count, int growBy, int capacityIncrement = 10)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref count);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &growBy;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacityIncrement;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GrowWithCapacity_Public_Static_Int32_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016062, XrefRangeEnd = 1016063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GrowWithCapacity<TValue>(ref NativeArray<TValue> array, ref int count, int growBy, int capacityIncrement = 10, Allocator allocator = Allocator.Persistent) where TValue : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref count);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &growBy;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &capacityIncrement;
		*(Allocator**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &allocator;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_GrowWithCapacity_Public_Static_Int32_byref_NativeArray_1_TValue_byref_Int32_Int32_Int32_Allocator_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1016064, RefRangeEnd = 1016066, XrefRangeStart = 1016063, XrefRangeEnd = 1016064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<TValue> Join<TValue>(TValue value, [Optional] Il2CppArrayBase<TValue> values)
	{
		//IL_0052->IL0055: Incompatible stack types: I vs Ref
		//IL_0045->IL0055: Incompatible stack types: I vs Ref
		if (values == null)
		{
			values = (Il2CppArrayBase<TValue>)(object)new Il2CppReferenceArray<TValue>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Join_Public_Static_Il2CppArrayBase_1_TValue_TValue_Il2CppArrayBase_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<TValue>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016082, RefRangeEnd = 1016083, XrefRangeStart = 1016066, XrefRangeEnd = 1016082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<TValue> Merge<TValue>(Il2CppArrayBase<TValue> first, Il2CppArrayBase<TValue> second)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)first);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)second);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Merge_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<TValue>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016083, XrefRangeEnd = 1016102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<TValue> Merge<TValue>(Il2CppArrayBase<TValue> first, Il2CppArrayBase<TValue> second, IEqualityComparer<TValue> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)first);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)second);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Merge_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_IEqualityComparer_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<TValue>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1016104, RefRangeEnd = 1016112, XrefRangeStart = 1016102, XrefRangeEnd = 1016104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EraseAt<TValue>(ref Il2CppArrayBase<TValue> array, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EraseAt_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1016113, RefRangeEnd = 1016116, XrefRangeStart = 1016112, XrefRangeEnd = 1016113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EraseAtWithCapacity<TValue>(this Il2CppArrayBase<TValue> array, ref int count, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref count);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EraseAtWithCapacity_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016119, RefRangeEnd = 1016120, XrefRangeStart = 1016116, XrefRangeEnd = 1016119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EraseAtWithCapacity<TValue>(NativeArray<TValue> array, ref int count, int index) where TValue : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref count);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EraseAtWithCapacity_Public_Static_Void_NativeArray_1_TValue_byref_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016123, RefRangeEnd = 1016124, XrefRangeStart = 1016120, XrefRangeEnd = 1016123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Erase<TValue>(ref Il2CppArrayBase<TValue> array, TValue value)
	{
		//IL_005d->IL0060: Incompatible stack types: I vs Ref
		//IL_0050->IL0060: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		ref TValue reference;
		if (!typeof(TValue).IsValueType)
		{
			object obj = value;
			reference = ref *(_003F*)((!(obj is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)((obj is Il2CppObjectBase) ? obj : null)) : IL2CPP.ManagedStringToIl2Cpp(obj as string));
		}
		else
		{
			reference = ref value;
		}
		*(void**)num = Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Erase_Public_Static_Boolean_byref_Il2CppArrayBase_1_TValue_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016124, RefRangeEnd = 1016125, XrefRangeStart = 1016124, XrefRangeEnd = 1016124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EraseAtByMovingTail<TValue>(Il2CppArrayBase<TValue> array, ref int count, int index)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref count);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EraseAtByMovingTail_Public_Static_Void_Il2CppArrayBase_1_TValue_byref_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 1016129, RefRangeEnd = 1016141, XrefRangeStart = 1016125, XrefRangeEnd = 1016129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<TValue> Copy<TValue>(Il2CppArrayBase<TValue> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Copy_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<TValue>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016141, XrefRangeEnd = 1016155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<TValue> Clone<TValue>(Il2CppArrayBase<TValue> array)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Clone_Public_Static_Il2CppArrayBase_1_TValue_Il2CppArrayBase_1_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<TValue>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016159, RefRangeEnd = 1016160, XrefRangeStart = 1016155, XrefRangeEnd = 1016159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppArrayBase<TNew> Select<TOld, TNew>(Il2CppArrayBase<TOld> array, Il2CppSystem.Func<TOld, TNew> converter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)converter);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Select_Public_Static_Il2CppArrayBase_1_TNew_Il2CppArrayBase_1_TOld_Func_2_TOld_TNew_0<TOld, TNew>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return Il2CppArrayBase<TNew>.WrapNativeGenericArrayPointer(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1016171, RefRangeEnd = 1016173, XrefRangeStart = 1016160, XrefRangeEnd = 1016171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Swap<TValue>(ref TValue first, ref TValue second)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TValue, object>(ref first));
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)Unsafe.As<TValue, object>(ref second));
		*(System.IntPtr**)num = &intPtr2;
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Swap_Private_Static_Void_byref_TValue_byref_TValue_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		Unsafe.As<TValue, object>(ref first) = ((intPtr5 == (System.IntPtr)0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>(intPtr5, false, false));
		System.IntPtr intPtr6 = intPtr2;
		Unsafe.As<TValue, object>(ref second) = ((intPtr6 == (System.IntPtr)0) ? ((TValue)null) : IL2CPP.PointerToValueGeneric<TValue>(intPtr6, false, false));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016180, RefRangeEnd = 1016181, XrefRangeStart = 1016173, XrefRangeEnd = 1016180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveSlice<TValue>(Il2CppArrayBase<TValue> array, int sourceIndex, int destinationIndex, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &sourceIndex;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &destinationIndex;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_MoveSlice_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1016183, RefRangeEnd = 1016185, XrefRangeStart = 1016181, XrefRangeEnd = 1016183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EraseSliceWithCapacity<TValue>(ref Il2CppArrayBase<TValue> array, ref int length, int index, int count)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*ptr = (nint)(&intPtr);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref length);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_EraseSliceWithCapacity_Public_Static_Void_byref_Il2CppArrayBase_1_TValue_byref_Int32_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		array = ((intPtr4 == (System.IntPtr)0) ? null : new Il2CppArrayBase<TValue>(intPtr4));
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016197, RefRangeEnd = 1016198, XrefRangeStart = 1016185, XrefRangeEnd = 1016197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SwapElements<TValue>(this Il2CppArrayBase<TValue> array, int index1, int index2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SwapElements_Public_Static_Void_Il2CppArrayBase_1_TValue_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1016198, RefRangeEnd = 1016199, XrefRangeStart = 1016198, XrefRangeEnd = 1016198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SwapElements<TValue>(this NativeArray<TValue> array, int index1, int index2) where TValue : new()
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)array));
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index1;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_SwapElements_Public_Static_Void_NativeArray_1_TValue_Int32_Int32_0<TValue>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ArrayHelpers(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
