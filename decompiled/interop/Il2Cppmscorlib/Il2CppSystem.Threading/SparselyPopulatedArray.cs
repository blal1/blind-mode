using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading;

public class SparselyPopulatedArray<T> : Object where T : class
{
	private static readonly System.IntPtr NativeFieldInfoPtr__head;

	private static readonly System.IntPtr NativeFieldInfoPtr__tail;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0;

	public unsafe SparselyPopulatedArrayFragment<T> _head
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__head);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__head)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SparselyPopulatedArrayFragment<T> _tail
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tail);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__tail)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SparselyPopulatedArrayFragment<T> Tail
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 767888, RefRangeEnd = 767889, XrefRangeStart = 767887, XrefRangeEnd = 767888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SparselyPopulatedArrayFragment<T>>(intPtr2) : null;
		}
	}

	static SparselyPopulatedArray()
	{
		Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SparselyPopulatedArray`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[1] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr);
		NativeFieldInfoPtr__head = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, "_head");
		NativeFieldInfoPtr__tail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, "_tail");
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100667682);
		NativeMethodInfoPtr_get_Tail_Internal_get_SparselyPopulatedArrayFragment_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100667683);
		NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr, 100667684);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 767886, RefRangeEnd = 767887, XrefRangeStart = 767879, XrefRangeEnd = 767886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SparselyPopulatedArray(int initialSize)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SparselyPopulatedArray<T>>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&initialSize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 767923, RefRangeEnd = 767924, XrefRangeStart = 767889, XrefRangeEnd = 767923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SparselyPopulatedArrayAddInfo<T> Add(T element)
	{
		//IL_004c->IL004f: Incompatible stack types: I vs Ref
		//IL_003f->IL004f: Incompatible stack types: I vs Ref
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		ref T reference;
		if (!typeof(T).IsValueType)
		{
			T val = element;
			reference = ref *(_003F*)((!(val is string)) ? IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)((val is Il2CppObjectBase) ? val : null)) : IL2CPP.ManagedStringToIl2Cpp(val as string));
		}
		else
		{
			reference = ref element;
		}
		*ptr = (nint)Unsafe.AsPointer(ref reference);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Add_Internal_SparselyPopulatedArrayAddInfo_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new SparselyPopulatedArrayAddInfo<T>(pointer);
	}

	public SparselyPopulatedArray(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
