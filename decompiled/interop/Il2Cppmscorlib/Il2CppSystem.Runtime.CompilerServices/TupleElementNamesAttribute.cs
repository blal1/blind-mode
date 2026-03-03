using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices;

public sealed class TupleElementNamesAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__transformNames;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;

	public unsafe Il2CppStringArray _transformNames
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transformNames);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__transformNames)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static TupleElementNamesAttribute()
	{
		Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TupleElementNamesAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__transformNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr, "_transformNames");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr, 100671409);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 805648, XrefRangeEnd = 805656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TupleElementNamesAttribute(Il2CppStringArray transformNames)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)transformNames);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TupleElementNamesAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
