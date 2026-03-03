using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

public sealed class AddComponentMenu : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_AddComponentMenu;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Ordering;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

	public unsafe string m_AddComponentMenu
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AddComponentMenu);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AddComponentMenu)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int m_Ordering
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ordering);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Ordering)) = value;
		}
	}

	public string componentMenu => m_AddComponentMenu;

	public int componentOrder => m_Ordering;

	static AddComponentMenu()
	{
		Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "AddComponentMenu");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr);
		NativeFieldInfoPtr_m_AddComponentMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, "m_AddComponentMenu");
		NativeFieldInfoPtr_m_Ordering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, "m_Ordering");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100666172);
		NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100666173);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1186018, XrefRangeEnd = 1186020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddComponentMenu(string menuName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AddComponentMenu(string menuName, int order)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(menuName);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &order;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AddComponentMenu(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
