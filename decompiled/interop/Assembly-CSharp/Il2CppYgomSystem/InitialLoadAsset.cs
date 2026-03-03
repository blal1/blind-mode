using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppYgomSystem;

public class InitialLoadAsset : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_s_isLoaded;

	private static readonly System.IntPtr NativeFieldInfoPtr_kLoadList;

	private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLoaded_Public_Static_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Unload_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static bool s_isLoaded
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_isLoaded, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_isLoaded, (void*)(&value));
		}
	}

	public unsafe static Il2CppStringArray kLoadList
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kLoadList, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kLoadList, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static InitialLoadAsset()
	{
		Il2CppClassPointerStore<InitialLoadAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomSystem", "InitialLoadAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialLoadAsset>.NativeClassPtr);
		NativeFieldInfoPtr_s_isLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialLoadAsset>.NativeClassPtr, "s_isLoaded");
		NativeFieldInfoPtr_kLoadList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialLoadAsset>.NativeClassPtr, "kLoadList");
		NativeMethodInfoPtr_Load_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialLoadAsset>.NativeClassPtr, 100665515);
		NativeMethodInfoPtr_IsLoaded_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialLoadAsset>.NativeClassPtr, 100665516);
		NativeMethodInfoPtr_Unload_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialLoadAsset>.NativeClassPtr, 100665517);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialLoadAsset>.NativeClassPtr, 100665518);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 56994, RefRangeEnd = 56995, XrefRangeStart = 56982, XrefRangeEnd = 56994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Load()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Load_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 57001, RefRangeEnd = 57002, XrefRangeStart = 56995, XrefRangeEnd = 57001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLoaded()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLoaded_Public_Static_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57002, XrefRangeEnd = 57015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Unload()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Unload_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InitialLoadAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitialLoadAsset>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public InitialLoadAsset(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
