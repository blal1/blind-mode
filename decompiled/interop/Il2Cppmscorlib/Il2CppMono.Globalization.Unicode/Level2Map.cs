using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode;

public class Level2Map : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Source;

	private static readonly System.IntPtr NativeFieldInfoPtr_Replace;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0;

	public unsafe byte Source
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Source);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Source)) = value;
		}
	}

	public unsafe byte Replace
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Replace);
			return *(byte*)num;
		}
		set
		{
			*(byte*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_Replace)) = value;
		}
	}

	static Level2Map()
	{
		Il2CppClassPointerStore<Level2Map>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "Level2Map");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Level2Map>.NativeClassPtr);
		NativeFieldInfoPtr_Source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level2Map>.NativeClassPtr, "Source");
		NativeFieldInfoPtr_Replace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Level2Map>.NativeClassPtr, "Replace");
		NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Level2Map>.NativeClassPtr, 100663479);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 697061, XrefRangeEnd = 697062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Level2Map(byte source, byte replace)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Level2Map>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&source);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &replace;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Level2Map(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
