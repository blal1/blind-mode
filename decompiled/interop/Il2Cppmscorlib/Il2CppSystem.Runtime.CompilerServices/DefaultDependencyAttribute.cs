using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices;

[System.Serializable]
public sealed class DefaultDependencyAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_loadHint;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0;

	public unsafe LoadHint loadHint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadHint);
			return *(LoadHint*)num;
		}
		set
		{
			*(LoadHint*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loadHint)) = value;
		}
	}

	static DefaultDependencyAttribute()
	{
		Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "DefaultDependencyAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_loadHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr, "loadHint");
		NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr, 100671501);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 166660, RefRangeEnd = 166661, XrefRangeStart = 166660, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DefaultDependencyAttribute(LoadHint loadHintArgument)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultDependencyAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&loadHintArgument);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LoadHint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DefaultDependencyAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
