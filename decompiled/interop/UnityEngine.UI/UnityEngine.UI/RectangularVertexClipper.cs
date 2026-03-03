using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI;

public class RectangularVertexClipper : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_WorldCorners;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CanvasCorners;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe Il2CppStructArray<Vector3> m_WorldCorners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorldCorners);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WorldCorners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<Vector3> m_CanvasCorners
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CanvasCorners);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CanvasCorners)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static RectangularVertexClipper()
	{
		Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "RectangularVertexClipper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr);
		NativeFieldInfoPtr_m_WorldCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, "m_WorldCorners");
		NativeFieldInfoPtr_m_CanvasCorners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, "m_CanvasCorners");
		NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr, 100663386);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1286156, RefRangeEnd = 1286157, XrefRangeStart = 1286147, XrefRangeEnd = 1286156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Rect GetCanvasRect(RectTransform t, Canvas c)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCanvasRect_Public_Rect_RectTransform_Canvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1286165, RefRangeEnd = 1286166, XrefRangeStart = 1286157, XrefRangeEnd = 1286165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RectangularVertexClipper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectangularVertexClipper>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RectangularVertexClipper(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
