using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Reflection;

public sealed class AssemblyProductAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Product_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe string _Product_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Product_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Product_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static AssemblyProductAttribute()
	{
		Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyProductAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__Product_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr, "<Product>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr, 100671669);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 684810, RefRangeEnd = 684814, XrefRangeStart = 684810, XrefRangeEnd = 684814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssemblyProductAttribute(string product)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyProductAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(product);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AssemblyProductAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
