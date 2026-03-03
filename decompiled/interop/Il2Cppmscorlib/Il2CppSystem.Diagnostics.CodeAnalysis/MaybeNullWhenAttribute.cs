using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Diagnostics.CodeAnalysis;

public sealed class MaybeNullWhenAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__ReturnValue_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

	public unsafe bool _ReturnValue_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ReturnValue_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ReturnValue_k__BackingField)) = value;
		}
	}

	static MaybeNullWhenAttribute()
	{
		Il2CppClassPointerStore<MaybeNullWhenAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.CodeAnalysis", "MaybeNullWhenAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaybeNullWhenAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__ReturnValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaybeNullWhenAttribute>.NativeClassPtr, "<ReturnValue>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaybeNullWhenAttribute>.NativeClassPtr, 100673384);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MaybeNullWhenAttribute(bool returnValue)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaybeNullWhenAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&returnValue);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public MaybeNullWhenAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
