using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode;

public class NormalizationTableUtil : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_Prop;

	private static readonly System.IntPtr NativeFieldInfoPtr_Map;

	private static readonly System.IntPtr NativeFieldInfoPtr_Combining;

	private static readonly System.IntPtr NativeFieldInfoPtr_Composite;

	private static readonly System.IntPtr NativeFieldInfoPtr_Helper;

	private static readonly System.IntPtr NativeMethodInfoPtr_PropIdx_Public_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MapIdx_Public_Static_Int32_Int32_0;

	public unsafe static CodePointIndexer Prop
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Prop, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Prop, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CodePointIndexer Map
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Map, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Map, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CodePointIndexer Combining
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Combining, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Combining, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CodePointIndexer Composite
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Composite, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Composite, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static CodePointIndexer Helper
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_Helper, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_Helper, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static NormalizationTableUtil()
	{
		Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "NormalizationTableUtil");
		NativeFieldInfoPtr_Prop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Prop");
		NativeFieldInfoPtr_Map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Map");
		NativeFieldInfoPtr_Combining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Combining");
		NativeFieldInfoPtr_Composite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Composite");
		NativeFieldInfoPtr_Helper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Helper");
		NativeMethodInfoPtr_PropIdx_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, 100663506);
		NativeMethodInfoPtr_MapIdx_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, 100663507);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697514, RefRangeEnd = 697515, XrefRangeStart = 697425, XrefRangeEnd = 697514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int PropIdx(int cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PropIdx_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 697521, RefRangeEnd = 697522, XrefRangeStart = 697515, XrefRangeEnd = 697521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int MapIdx(int cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MapIdx_Public_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public NormalizationTableUtil(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
