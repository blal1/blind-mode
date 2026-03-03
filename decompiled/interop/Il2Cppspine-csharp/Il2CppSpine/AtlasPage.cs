using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSpine;

public class AtlasPage : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_format;

	private static readonly System.IntPtr NativeFieldInfoPtr_minFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_magFilter;

	private static readonly System.IntPtr NativeFieldInfoPtr_uWrap;

	private static readonly System.IntPtr NativeFieldInfoPtr_vWrap;

	private static readonly System.IntPtr NativeFieldInfoPtr_pma;

	private static readonly System.IntPtr NativeFieldInfoPtr_rendererObject;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_AtlasPage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int width
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_width)) = value;
		}
	}

	public unsafe int height
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_height)) = value;
		}
	}

	public unsafe Format format
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_format);
			return *(Format*)num;
		}
		set
		{
			*(Format*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_format)) = value;
		}
	}

	public unsafe TextureFilter minFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minFilter);
			return *(TextureFilter*)num;
		}
		set
		{
			*(TextureFilter*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_minFilter)) = value;
		}
	}

	public unsafe TextureFilter magFilter
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_magFilter);
			return *(TextureFilter*)num;
		}
		set
		{
			*(TextureFilter*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_magFilter)) = value;
		}
	}

	public unsafe TextureWrap uWrap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uWrap);
			return *(TextureWrap*)num;
		}
		set
		{
			*(TextureWrap*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_uWrap)) = value;
		}
	}

	public unsafe TextureWrap vWrap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vWrap);
			return *(TextureWrap*)num;
		}
		set
		{
			*(TextureWrap*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_vWrap)) = value;
		}
	}

	public unsafe bool pma
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pma);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pma)) = value;
		}
	}

	public unsafe Il2CppSystem.Object rendererObject
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererObject);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_rendererObject)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AtlasPage()
	{
		Il2CppClassPointerStore<AtlasPage>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "AtlasPage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, "name");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, "width");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, "height");
		NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, "format");
		NativeFieldInfoPtr_minFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, "minFilter");
		NativeFieldInfoPtr_magFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, "magFilter");
		NativeFieldInfoPtr_uWrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, "uWrap");
		NativeFieldInfoPtr_vWrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, "vWrap");
		NativeFieldInfoPtr_pma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, "pma");
		NativeFieldInfoPtr_rendererObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, "rendererObject");
		NativeMethodInfoPtr_Clone_Public_AtlasPage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, 100663627);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr, 100663628);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 842555, RefRangeEnd = 842557, XrefRangeStart = 842552, XrefRangeEnd = 842555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AtlasPage Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clone_Public_AtlasPage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasPage>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 842558, RefRangeEnd = 842561, XrefRangeStart = 842557, XrefRangeEnd = 842558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AtlasPage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AtlasPage>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AtlasPage(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
