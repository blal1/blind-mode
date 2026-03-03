using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Serialization;

public sealed class OptionalFieldAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_versionAdded;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0;

	public unsafe int versionAdded
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_versionAdded);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_versionAdded)) = value;
		}
	}

	public unsafe int VersionAdded
	{
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static OptionalFieldAttribute()
	{
		Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "OptionalFieldAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_versionAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, "versionAdded");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, 100670752);
		NativeMethodInfoPtr_set_VersionAdded_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr, 100670753);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 799053, XrefRangeEnd = 799054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OptionalFieldAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionalFieldAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public OptionalFieldAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
