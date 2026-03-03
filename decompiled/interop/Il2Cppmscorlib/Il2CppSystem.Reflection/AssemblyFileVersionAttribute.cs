using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Reflection;

public sealed class AssemblyFileVersionAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Version_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe string _Version_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Version_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Version_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static AssemblyFileVersionAttribute()
	{
		Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyFileVersionAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__Version_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr, "<Version>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr, 100671665);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 808301, XrefRangeEnd = 808309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssemblyFileVersionAttribute(string version)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyFileVersionAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AssemblyFileVersionAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
