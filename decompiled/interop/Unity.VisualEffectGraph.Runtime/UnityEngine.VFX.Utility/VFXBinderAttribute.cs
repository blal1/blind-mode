using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.VFX.Utility;

public class VFXBinderAttribute : PropertyAttribute
{
	private static readonly IntPtr NativeFieldInfoPtr_MenuPath;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	public unsafe string MenuPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MenuPath);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_MenuPath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static VFXBinderAttribute()
	{
		Il2CppClassPointerStore<VFXBinderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.VisualEffectGraph.Runtime.dll", "UnityEngine.VFX.Utility", "VFXBinderAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXBinderAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_MenuPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXBinderAttribute>.NativeClassPtr, "MenuPath");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXBinderAttribute>.NativeClassPtr, 100663773);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 110022, RefRangeEnd = 110023, XrefRangeStart = 110022, XrefRangeEnd = 110023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXBinderAttribute(string menuPath)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXBinderAttribute>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(menuPath);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VFXBinderAttribute(IntPtr pointer)
		: base(pointer)
	{
	}
}
