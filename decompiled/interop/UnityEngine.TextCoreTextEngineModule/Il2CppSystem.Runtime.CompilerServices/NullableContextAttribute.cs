using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.CompilerServices;

public sealed class NullableContextAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Flag;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_0;

	public unsafe byte Flag
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flag);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Flag)) = value;
		}
	}

	static NullableContextAttribute()
	{
		Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "System.Runtime.CompilerServices", "NullableContextAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_Flag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr, "Flag");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr, 100663300);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NullableContextAttribute(byte A_1)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullableContextAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&A_1);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NullableContextAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
