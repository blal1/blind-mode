using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine;

public sealed class GUIScrollGroup : GUILayoutGroup
{
	private static readonly IntPtr NativeFieldInfoPtr_calcMinWidth;

	private static readonly IntPtr NativeFieldInfoPtr_calcMaxWidth;

	private static readonly IntPtr NativeFieldInfoPtr_calcMinHeight;

	private static readonly IntPtr NativeFieldInfoPtr_calcMaxHeight;

	private static readonly IntPtr NativeFieldInfoPtr_clientWidth;

	private static readonly IntPtr NativeFieldInfoPtr_clientHeight;

	private static readonly IntPtr NativeFieldInfoPtr_allowHorizontalScroll;

	private static readonly IntPtr NativeFieldInfoPtr_allowVerticalScroll;

	private static readonly IntPtr NativeFieldInfoPtr_needsHorizontalScrollbar;

	private static readonly IntPtr NativeFieldInfoPtr_needsVerticalScrollbar;

	private static readonly IntPtr NativeFieldInfoPtr_horizontalScrollbar;

	private static readonly IntPtr NativeFieldInfoPtr_verticalScrollbar;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0;

	private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0;

	public unsafe float calcMinWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calcMinWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calcMinWidth)) = value;
		}
	}

	public unsafe float calcMaxWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calcMaxWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calcMaxWidth)) = value;
		}
	}

	public unsafe float calcMinHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calcMinHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calcMinHeight)) = value;
		}
	}

	public unsafe float calcMaxHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calcMaxHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_calcMaxHeight)) = value;
		}
	}

	public unsafe float clientWidth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientWidth);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientWidth)) = value;
		}
	}

	public unsafe float clientHeight
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientHeight);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_clientHeight)) = value;
		}
	}

	public unsafe bool allowHorizontalScroll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowHorizontalScroll);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowHorizontalScroll)) = value;
		}
	}

	public unsafe bool allowVerticalScroll
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowVerticalScroll);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_allowVerticalScroll)) = value;
		}
	}

	public unsafe bool needsHorizontalScrollbar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsHorizontalScrollbar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsHorizontalScrollbar)) = value;
		}
	}

	public unsafe bool needsVerticalScrollbar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsVerticalScrollbar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_needsVerticalScrollbar)) = value;
		}
	}

	public unsafe GUIStyle horizontalScrollbar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalScrollbar);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_horizontalScrollbar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GUIStyle verticalScrollbar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalScrollbar);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verticalScrollbar)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static GUIScrollGroup()
	{
		Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIScrollGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr);
		NativeFieldInfoPtr_calcMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMinWidth");
		NativeFieldInfoPtr_calcMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMaxWidth");
		NativeFieldInfoPtr_calcMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMinHeight");
		NativeFieldInfoPtr_calcMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "calcMaxHeight");
		NativeFieldInfoPtr_clientWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "clientWidth");
		NativeFieldInfoPtr_clientHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "clientHeight");
		NativeFieldInfoPtr_allowHorizontalScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "allowHorizontalScroll");
		NativeFieldInfoPtr_allowVerticalScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "allowVerticalScroll");
		NativeFieldInfoPtr_needsHorizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "needsHorizontalScrollbar");
		NativeFieldInfoPtr_needsVerticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "needsVerticalScrollbar");
		NativeFieldInfoPtr_horizontalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "horizontalScrollbar");
		NativeFieldInfoPtr_verticalScrollbar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, "verticalScrollbar");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663800);
		NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663801);
		NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663802);
		NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663803);
		NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr, 100663804);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249129, XrefRangeEnd = 1249133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GUIScrollGroup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIScrollGroup>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249133, XrefRangeEnd = 1249134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void CalcWidth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249134, XrefRangeEnd = 1249141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetHorizontal(float x, float width)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &width;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249141, XrefRangeEnd = 1249145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void CalcHeight()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249145, XrefRangeEnd = 1249149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetVertical(float y, float height)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&y);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &height;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GUIScrollGroup(IntPtr pointer)
		: base(pointer)
	{
	}
}
