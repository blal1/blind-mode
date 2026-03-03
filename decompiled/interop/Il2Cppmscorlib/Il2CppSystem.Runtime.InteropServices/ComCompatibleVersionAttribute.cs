using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.InteropServices;

public sealed class ComCompatibleVersionAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__major;

	private static readonly System.IntPtr NativeFieldInfoPtr__minor;

	private static readonly System.IntPtr NativeFieldInfoPtr__build;

	private static readonly System.IntPtr NativeFieldInfoPtr__revision;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

	public unsafe int _major
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__major);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__major)) = value;
		}
	}

	public unsafe int _minor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minor);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__minor)) = value;
		}
	}

	public unsafe int _build
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__build);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__build)) = value;
		}
	}

	public unsafe int _revision
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__revision);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__revision)) = value;
		}
	}

	static ComCompatibleVersionAttribute()
	{
		Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ComCompatibleVersionAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_major");
		NativeFieldInfoPtr__minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_minor");
		NativeFieldInfoPtr__build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_build");
		NativeFieldInfoPtr__revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, "_revision");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr, 100671239);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804051, XrefRangeEnd = 804052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ComCompatibleVersionAttribute(int major, int minor, int build, int revision)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComCompatibleVersionAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&major);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &minor;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &build;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &revision;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ComCompatibleVersionAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
