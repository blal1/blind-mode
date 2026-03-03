using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections.Generic;

public class ArraySortHelper<T> : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_defaultArraySortHelper;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BinarySearch_Public_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InternalBinarySearch_Internal_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwapIfGreater_Private_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ArraySortHelper<T> s_defaultArraySortHelper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_defaultArraySortHelper, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArraySortHelper<T>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_defaultArraySortHelper, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ArraySortHelper<T> Default
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832773, XrefRangeEnd = 832777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArraySortHelper<T>>(intPtr2) : null;
		}
	}

	static ArraySortHelper()
	{
		Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ArraySortHelper`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr);
		NativeFieldInfoPtr_s_defaultArraySortHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, "s_defaultArraySortHelper");
		NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674223);
		NativeMethodInfoPtr_BinarySearch_Public_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674224);
		NativeMethodInfoPtr_Sort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674225);
		NativeMethodInfoPtr_InternalBinarySearch_Internal_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674226);
		NativeMethodInfoPtr_SwapIfGreater_Private_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674227);
		NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674228);
		NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674229);
		NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674230);
		NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674231);
		NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674232);
		NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674233);
		NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674234);
		NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674235);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr, 100674236);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832656, RefRangeEnd = 832657, XrefRangeStart = 832645, XrefRangeEnd = 832656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Sort(Il2CppArrayBase<T> keys, int index, int length, IComparer<T> comparer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_T_Int32_Int32_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832661, RefRangeEnd = 832662, XrefRangeStart = 832657, XrefRangeEnd = 832661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int BinarySearch(Il2CppArrayBase<T> array, int index, int length, T value, IComparer<T> comparer)
	{
		//IL_007b->IL007e: Incompatible stack types: I vs Ref
		//IL_006e->IL007e: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
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
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BinarySearch_Public_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832669, RefRangeEnd = 832670, XrefRangeStart = 832662, XrefRangeEnd = 832669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Sort(Il2CppArrayBase<T> keys, int index, int length, Comparison<T> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832673, RefRangeEnd = 832674, XrefRangeStart = 832670, XrefRangeEnd = 832673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int InternalBinarySearch(Il2CppArrayBase<T> array, int index, int length, T value, IComparer<T> comparer)
	{
		//IL_0073->IL0076: Incompatible stack types: I vs Ref
		//IL_0066->IL0076: Incompatible stack types: I vs Ref
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)array);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
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
		*(void**)num = Unsafe.AsPointer(ref reference);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InternalBinarySearch_Internal_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_T_IComparer_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832674, XrefRangeEnd = 832677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SwapIfGreater(Il2CppArrayBase<T> keys, Comparison<T> comparer, int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwapIfGreater_Private_Static_Void_Il2CppArrayBase_1_T_Comparison_1_T_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832677, XrefRangeEnd = 832679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Swap(Il2CppArrayBase<T> a, int i, int j)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)a);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832679, XrefRangeEnd = 832685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IntrospectiveSort(Il2CppArrayBase<T> keys, int left, int length, Comparison<T> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 832719, RefRangeEnd = 832721, XrefRangeStart = 832685, XrefRangeEnd = 832719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IntroSort(Il2CppArrayBase<T> keys, int lo, int hi, int depthLimit, Comparison<T> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthLimit;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832745, RefRangeEnd = 832746, XrefRangeStart = 832721, XrefRangeEnd = 832745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PickPivotAndPartition(Il2CppArrayBase<T> keys, int lo, int hi, Comparison<T> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832759, RefRangeEnd = 832760, XrefRangeStart = 832746, XrefRangeEnd = 832759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Heapsort(Il2CppArrayBase<T> keys, int lo, int hi, Comparison<T> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 832768, RefRangeEnd = 832770, XrefRangeStart = 832760, XrefRangeEnd = 832768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DownHeap(Il2CppArrayBase<T> keys, int i, int n, int lo, Comparison<T> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Int32_Comparison_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832770, XrefRangeEnd = 832773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertionSort(Il2CppArrayBase<T> keys, int lo, int hi, Comparison<T> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_T_Int32_Int32_Comparison_1_T_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ArraySortHelper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySortHelper<T>>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ArraySortHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
public class ArraySortHelper<TKey, TValue> : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_defaultArraySortHelper;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwapIfGreaterWithItems_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_2_TKey_TValue_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static ArraySortHelper<TKey, TValue> s_defaultArraySortHelper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_defaultArraySortHelper, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArraySortHelper<TKey, TValue>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_defaultArraySortHelper, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ArraySortHelper<TKey, TValue> Default
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832888, XrefRangeEnd = 832892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_2_TKey_TValue_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ArraySortHelper<TKey, TValue>>(intPtr2) : null;
		}
	}

	static ArraySortHelper()
	{
		Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ArraySortHelper`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[2]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr);
		NativeFieldInfoPtr_s_defaultArraySortHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, "s_defaultArraySortHelper");
		NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674238);
		NativeMethodInfoPtr_SwapIfGreaterWithItems_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674239);
		NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674240);
		NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674241);
		NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674242);
		NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674243);
		NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674244);
		NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674245);
		NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674246);
		NativeMethodInfoPtr_get_Default_Public_Static_get_ArraySortHelper_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674247);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr, 100674248);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832789, RefRangeEnd = 832790, XrefRangeStart = 832777, XrefRangeEnd = 832789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Sort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int index, int length, IComparer<TKey> comparer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sort_Public_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832790, XrefRangeEnd = 832793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SwapIfGreaterWithItems(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, IComparer<TKey> comparer, int a, int b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &a;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwapIfGreaterWithItems_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_IComparer_1_TKey_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void Swap(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int i, int j)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &j;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Swap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 832793, XrefRangeEnd = 832799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IntrospectiveSort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int left, int length, IComparer<TKey> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &left;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &length;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntrospectiveSort_Internal_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 832833, RefRangeEnd = 832836, XrefRangeStart = 832799, XrefRangeEnd = 832833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void IntroSort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, int depthLimit, IComparer<TKey> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthLimit;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntroSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832861, RefRangeEnd = 832862, XrefRangeStart = 832836, XrefRangeEnd = 832861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PickPivotAndPartition(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, IComparer<TKey> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PickPivotAndPartition_Private_Static_Int32_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832873, RefRangeEnd = 832874, XrefRangeStart = 832862, XrefRangeEnd = 832873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Heapsort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, IComparer<TKey> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Heapsort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 832880, RefRangeEnd = 832882, XrefRangeStart = 832874, XrefRangeEnd = 832880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DownHeap(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int i, int n, int lo, IComparer<TKey> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &n;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DownHeap_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_Int32_IComparer_1_TKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 832887, RefRangeEnd = 832888, XrefRangeStart = 832882, XrefRangeEnd = 832887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InsertionSort(Il2CppArrayBase<TKey> keys, Il2CppArrayBase<TValue> values, int lo, int hi, IComparer<TKey> comparer)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)keys);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)values);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &lo;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &hi;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)comparer);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InsertionSort_Private_Static_Void_Il2CppArrayBase_1_TKey_Il2CppArrayBase_1_TValue_Int32_Int32_IComparer_1_TKey_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ArraySortHelper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArraySortHelper<TKey, TValue>>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ArraySortHelper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
