using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Reflection;

public sealed class AssemblyDelaySignAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__DelaySign_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	public unsafe bool _DelaySign_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DelaySign_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__DelaySign_k__BackingField)) = value;
		}
	}

	static AssemblyDelaySignAttribute()
	{
		Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyDelaySignAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__DelaySign_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr, "<DelaySign>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr, 100671663);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssemblyDelaySignAttribute(bool delaySign)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyDelaySignAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&delaySign);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AssemblyDelaySignAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
