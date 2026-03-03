using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace Il2Cpp;

public static class Initializer : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__OriginalCultureInfo_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_OriginalCultureInfo_Public_Static_get_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_OriginalCultureInfo_Private_Static_set_Void_CultureInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitializeBeforeSceneLoad_Private_Static_Void_0;

	public unsafe static CultureInfo _OriginalCultureInfo_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OriginalCultureInfo_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OriginalCultureInfo_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CultureInfo OriginalCultureInfo
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37774, XrefRangeEnd = 37778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_OriginalCultureInfo_Public_Static_get_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37778, XrefRangeEnd = 37784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_OriginalCultureInfo_Private_Static_set_Void_CultureInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static Initializer()
	{
		Il2CppClassPointerStore<Initializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Initializer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initializer>.NativeClassPtr);
		NativeFieldInfoPtr__OriginalCultureInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Initializer>.NativeClassPtr, "<OriginalCultureInfo>k__BackingField");
		NativeMethodInfoPtr_get_OriginalCultureInfo_Public_Static_get_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100664001);
		NativeMethodInfoPtr_set_OriginalCultureInfo_Private_Static_set_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100664002);
		NativeMethodInfoPtr_InitializeBeforeSceneLoad_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Initializer>.NativeClassPtr, 100664003);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37784, XrefRangeEnd = 37837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitializeBeforeSceneLoad()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeBeforeSceneLoad_Private_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Initializer(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
