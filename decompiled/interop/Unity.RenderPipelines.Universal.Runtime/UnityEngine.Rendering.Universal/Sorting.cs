using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering.Universal;

[StructLayout(LayoutKind.Explicit)]
public struct Sorting
{
	[ObfuscatedName("UnityEngine.Rendering.Universal.Sorting+<>c__DisplayClass4_0`1")]
	public sealed class __c__DisplayClass4_0<T> : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		public unsafe Il2CppArrayBase<T> data
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_data)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c__DisplayClass4_0()
		{
			Il2CppClassPointerStore<__c__DisplayClass4_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sorting>.NativeClassPtr, "<>c__DisplayClass4_0`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c__DisplayClass4_0<T>>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c__DisplayClass4_0<T>>.NativeClassPtr, "data");
		}

		public __c__DisplayClass4_0(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public __c__DisplayClass4_0()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c__DisplayClass4_0<T>>.NativeClassPtr))
		{
		}
	}

	private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0, Il2CppClassPointerStore<Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0, Il2CppClassPointerStore<Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Median3Pivot_Private_Static_T_Il2CppArrayBase_1_T_Int32_Int32_Int32_Func_3_T_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Median3Pivot_Private_Static_T_Il2CppArrayBase_1_T_Int32_Int32_Int32_Func_3_T_T_Int32_0, Il2CppClassPointerStore<Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0, Il2CppClassPointerStore<Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0, Il2CppClassPointerStore<Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0, Il2CppClassPointerStore<Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass4_0_1_T_PDM_0<T>
	{
		internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)new MethodInfo(IL2CPP.il2cpp_method_get_object(NativeMethodInfoPtr_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass4_0_1_T_PDM_0, Il2CppClassPointerStore<Sorting>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_QuickSortSampler;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_InsertionSortSampler;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Median3Pivot_Private_Static_T_Il2CppArrayBase_1_T_Int32_Int32_Int32_Func_3_T_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass4_0_1_T_PDM_0;

	public unsafe static ProfilingSampler s_QuickSortSampler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_QuickSortSampler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_QuickSortSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ProfilingSampler s_InsertionSortSampler
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_InsertionSortSampler, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_InsertionSortSampler, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Sorting()
	{
		Il2CppClassPointerStore<Sorting>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Sorting");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sorting>.NativeClassPtr);
		NativeFieldInfoPtr_s_QuickSortSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sorting>.NativeClassPtr, "s_QuickSortSampler");
		NativeFieldInfoPtr_s_InsertionSortSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sorting>.NativeClassPtr, "s_InsertionSortSampler");
		NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sorting>.NativeClassPtr, 100664788);
		NativeMethodInfoPtr_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sorting>.NativeClassPtr, 100664789);
		NativeMethodInfoPtr_Median3Pivot_Private_Static_T_Il2CppArrayBase_1_T_Int32_Int32_Int32_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sorting>.NativeClassPtr, 100664790);
		NativeMethodInfoPtr_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sorting>.NativeClassPtr, 100664791);
		NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sorting>.NativeClassPtr, 100664792);
		NativeMethodInfoPtr_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sorting>.NativeClassPtr, 100664793);
		NativeMethodInfoPtr_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass4_0_1_T_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sorting>.NativeClassPtr, 100664795);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088526, XrefRangeEnd = 1088537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QuickSort<T>(Il2CppArrayBase<T> data, Il2CppSystem.Func<T, T, int> compare)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compare);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1088551, RefRangeEnd = 1088553, XrefRangeStart = 1088537, XrefRangeEnd = 1088551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void QuickSort<T>(Il2CppArrayBase<T> data, int start, int end, Il2CppSystem.Func<T, T, int> compare)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compare);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_QuickSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088562, RefRangeEnd = 1088563, XrefRangeStart = 1088553, XrefRangeEnd = 1088562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T Median3Pivot<T>(Il2CppArrayBase<T> data, int start, int pivot, int end, Il2CppSystem.Func<T, T, int> compare)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivot;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compare);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Median3Pivot_Private_Static_T_Il2CppArrayBase_1_T_Int32_Int32_Int32_Func_3_T_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1088570, RefRangeEnd = 1088571, XrefRangeStart = 1088563, XrefRangeEnd = 1088570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Partition<T>(Il2CppArrayBase<T> data, int start, int end, Il2CppSystem.Func<T, T, int> compare)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compare);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Partition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088571, XrefRangeEnd = 1088582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertionSort<T>(Il2CppArrayBase<T> data, Il2CppSystem.Func<T, T, int> compare)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compare);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Func_3_T_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1088582, XrefRangeEnd = 1088583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertionSort<T>(Il2CppArrayBase<T> data, int start, int end, Il2CppSystem.Func<T, T, int> compare)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &end;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)compare);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_InsertionSort_Public_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Func_3_T_T_Int32_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass4_0_1_T_PDM_0<T>(int a, int b, ref __c__DisplayClass4_0<T> A_2)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)A_2);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MethodInfoStoreGeneric_Method_Internal_Static_Void_Int32_Int32_byref___c__DisplayClass4_0_1_T_PDM_0<T>.Pointer, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sorting>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
