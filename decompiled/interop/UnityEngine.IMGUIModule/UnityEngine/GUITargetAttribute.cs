using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

public class GUITargetAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr_displayMask;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0;

	public unsafe int displayMask
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayMask);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayMask)) = value;
		}
	}

	static GUITargetAttribute()
	{
		Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUITargetAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr);
		NativeFieldInfoPtr_displayMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr, "displayMask");
		NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUITargetAttribute>.NativeClassPtr, 100663682);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247795, XrefRangeEnd = 1247807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetGUITargetAttrValue(Il2CppSystem.Type klass, string methodName)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)klass);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(methodName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetGUITargetAttrValue_Private_Static_Int32_Type_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public GUITargetAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
