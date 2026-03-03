using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem;

[System.Serializable]
public sealed class CLSCompliantAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__compliant;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	public unsafe bool _compliant
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compliant);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__compliant)) = value;
		}
	}

	static CLSCompliantAttribute()
	{
		Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CLSCompliantAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__compliant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr, "_compliant");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr, 100664437);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720684, XrefRangeEnd = 720685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CLSCompliantAttribute(bool isCompliant)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CLSCompliantAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&isCompliant);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CLSCompliantAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
