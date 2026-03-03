using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema;

public sealed class Position : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_symbol;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0;

	public unsafe int symbol
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_symbol);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_symbol)) = value;
		}
	}

	public unsafe Object particle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static Position()
	{
		Il2CppClassPointerStore<Position>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Position");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Position>.NativeClassPtr);
		NativeFieldInfoPtr_symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Position>.NativeClassPtr, "symbol");
		NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Position>.NativeClassPtr, "particle");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Position>.NativeClassPtr, 100666024);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 506934, RefRangeEnd = 506965, XrefRangeStart = 506934, XrefRangeEnd = 506965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Position(int symbol, Object particle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Position>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&symbol);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)particle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Position(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public Position()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Position>.NativeClassPtr))
	{
	}
}
