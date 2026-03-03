using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine;

public sealed class GUIWordWrapSizer : GUILayoutEntry
{
	private static readonly IntPtr NativeFieldInfoPtr_m_Content;

	private static readonly IntPtr NativeFieldInfoPtr_m_ForcedMinHeight;

	private static readonly IntPtr NativeFieldInfoPtr_m_ForcedMaxHeight;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0;

	public unsafe GUIContent m_Content
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Content);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GUIContent>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Content)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float m_ForcedMinHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForcedMinHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForcedMinHeight)) = value;
		}
	}

	public unsafe float m_ForcedMaxHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForcedMaxHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ForcedMaxHeight)) = value;
		}
	}

	static GUIWordWrapSizer()
	{
		Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIWordWrapSizer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr);
		NativeFieldInfoPtr_m_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, "m_Content");
		NativeFieldInfoPtr_m_ForcedMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, "m_ForcedMinHeight");
		NativeFieldInfoPtr_m_ForcedMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, "m_ForcedMaxHeight");
		NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, 100663781);
		NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, 100663782);
		NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr, 100663783);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1248773, RefRangeEnd = 1248774, XrefRangeStart = 1248753, XrefRangeEnd = 1248773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUIWordWrapSizer(GUIStyle style, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIWordWrapSizer>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_GUIStyle_GUIContent_Il2CppReferenceArray_1_GUILayoutOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248774, XrefRangeEnd = 1248782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void CalcWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248782, XrefRangeEnd = 1248788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void CalcHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GUIWordWrapSizer(IntPtr pointer)
		: base(pointer)
	{
	}
}
