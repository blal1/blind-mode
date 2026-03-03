using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public sealed class SparselyPopulatedArrayAddInfo<T> : ValueType where T : class
{
	private static readonly System.IntPtr NativeFieldInfoPtr__source;

	private static readonly System.IntPtr NativeFieldInfoPtr__index;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Index_Internal_get_Int32_0;

	public unsafe SparselyPopulatedArrayFragment<T> _source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__source);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__source)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int _index
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__index);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__index)) = value;
		}
	}

	public unsafe SparselyPopulatedArrayFragment<T> Source
	{
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 110111, RefRangeEnd = 110209, XrefRangeStart = 110111, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
		}
	}

	public unsafe int Index
	{
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 719678, RefRangeEnd = 719702, XrefRangeStart = 719678, XrefRangeEnd = 719702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Index_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SparselyPopulatedArrayAddInfo()
	{
		Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArrayAddInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr);
		NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, "_source");
		NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, "_index");
		NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100667685);
		NativeMethodInfoPtr_get_Source_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100667686);
		NativeMethodInfoPtr_get_Index_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr, 100667687);
	}

	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 767829, RefRangeEnd = 767852, XrefRangeStart = 767829, XrefRangeEnd = 767852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SparselyPopulatedArrayAddInfo(SparselyPopulatedArrayFragment<T> source, int index)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_SparselyPopulatedArrayFragment_1_T_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SparselyPopulatedArrayAddInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public SparselyPopulatedArrayAddInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArrayAddInfo<T>>.NativeClassPtr))
	{
	}
}
