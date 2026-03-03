using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public class GUILayout : Il2CppSystem.Object
{
	public sealed class LayoutedWindow
	{
	}

	public class HorizontalScope : GUI.Scope
	{
	}

	public class VerticalScope : GUI.Scope
	{
	}

	public class AreaScope : GUI.Scope
	{
	}

	public class ScrollViewScope : GUI.Scope
	{
	}

	private static readonly System.IntPtr NativeMethodInfoPtr_Label_Public_Static_Void_String_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoLabel_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Button_Public_Static_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DoButton_Private_Static_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FlexibleSpace_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndHorizontal_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_GUIContent_GUIStyle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndArea_Public_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandWidth_Public_Static_GUILayoutOption_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ExpandHeight_Public_Static_GUILayoutOption_Boolean_0;

	static GUILayout()
	{
		Il2CppClassPointerStore<GUILayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayout");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayout>.NativeClassPtr);
		NativeMethodInfoPtr_Label_Public_Static_Void_String_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663471);
		NativeMethodInfoPtr_DoLabel_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663472);
		NativeMethodInfoPtr_Button_Public_Static_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663473);
		NativeMethodInfoPtr_DoButton_Private_Static_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663474);
		NativeMethodInfoPtr_FlexibleSpace_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663475);
		NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663476);
		NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663477);
		NativeMethodInfoPtr_EndHorizontal_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663478);
		NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663479);
		NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_GUIContent_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663480);
		NativeMethodInfoPtr_EndArea_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663481);
		NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663482);
		NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663483);
		NativeMethodInfoPtr_ExpandWidth_Public_Static_GUILayoutOption_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663484);
		NativeMethodInfoPtr_ExpandHeight_Public_Static_GUILayoutOption_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayout>.NativeClassPtr, 100663485);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1245624, RefRangeEnd = 1245625, XrefRangeStart = 1245598, XrefRangeEnd = 1245624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Label(string text, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
	{
		if (options == null)
		{
			options = new Il2CppReferenceArray<GUILayoutOption>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Label_Public_Static_Void_String_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245625, XrefRangeEnd = 1245643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DoLabel(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoLabel_Private_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1245662, RefRangeEnd = 1245664, XrefRangeStart = 1245643, XrefRangeEnd = 1245662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Button(string text, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
	{
		if (options == null)
		{
			options = new Il2CppReferenceArray<GUILayoutOption>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Button_Public_Static_Boolean_String_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245664, XrefRangeEnd = 1245675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool DoButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DoButton_Private_Static_Boolean_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1245749, RefRangeEnd = 1245751, XrefRangeStart = 1245675, XrefRangeEnd = 1245749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FlexibleSpace()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FlexibleSpace_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1245776, RefRangeEnd = 1245777, XrefRangeStart = 1245751, XrefRangeEnd = 1245776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginHorizontal(GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
	{
		if (options == null)
		{
			options = new Il2CppReferenceArray<GUILayoutOption>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245777, XrefRangeEnd = 1245798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginHorizontal(GUIContent content, GUIStyle style, [Optional] Il2CppReferenceArray<GUILayoutOption> options)
	{
		if (options == null)
		{
			options = new Il2CppReferenceArray<GUILayoutOption>(0L);
		}
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)options);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginHorizontal_Public_Static_Void_GUIContent_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1245802, RefRangeEnd = 1245803, XrefRangeStart = 1245798, XrefRangeEnd = 1245802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndHorizontal()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndHorizontal_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1245812, RefRangeEnd = 1245813, XrefRangeStart = 1245803, XrefRangeEnd = 1245812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginArea(Rect screenRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&screenRect);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1245840, RefRangeEnd = 1245841, XrefRangeStart = 1245813, XrefRangeEnd = 1245840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&screenRect);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)content);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)style);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginArea_Public_Static_Void_Rect_GUIContent_GUIStyle_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1245863, RefRangeEnd = 1245864, XrefRangeStart = 1245841, XrefRangeEnd = 1245863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EndArea()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndArea_Public_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245864, XrefRangeEnd = 1245871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GUILayoutOption Width(float width)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&width);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Width_Public_Static_GUILayoutOption_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245871, XrefRangeEnd = 1245878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GUILayoutOption Height(float height)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&height);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Height_Public_Static_GUILayoutOption_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245878, XrefRangeEnd = 1245885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GUILayoutOption ExpandWidth(bool expand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&expand);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandWidth_Public_Static_GUILayoutOption_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245885, XrefRangeEnd = 1245892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GUILayoutOption ExpandHeight(bool expand)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&expand);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ExpandHeight_Public_Static_GUILayoutOption_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<GUILayoutOption>(intPtr2) : null;
	}

	public static void Label(string text, params GUILayoutOption[] options)
	{
		Label(text, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool Button(string text, params GUILayoutOption[] options)
	{
		return Button(text, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void BeginHorizontal(GUIStyle style, params GUILayoutOption[] options)
	{
		BeginHorizontal(style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		BeginHorizontal(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public GUILayout(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void Label(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoLabel(GUIContent.Temp(image), GUI.skin.label, options);
	}

	public static void Label(Texture image, params GUILayoutOption[] options)
	{
		Label(image, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Label(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoLabel(content, GUI.skin.label, options);
	}

	public static void Label(GUIContent content, params GUILayoutOption[] options)
	{
		Label(content, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Label(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoLabel(GUIContent.Temp(image), style, options);
	}

	public static void Label(Texture image, GUIStyle style, params GUILayoutOption[] options)
	{
		Label(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Label(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoLabel(GUIContent.Temp(text), style, options);
	}

	public static void Label(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		Label(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Label(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoLabel(content, style, options);
	}

	public static void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		Label(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Box(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoBox(GUIContent.Temp(image), GUI.skin.box, options);
	}

	public static void Box(Texture image, params GUILayoutOption[] options)
	{
		Box(image, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Box(string text, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoBox(GUIContent.Temp(text), GUI.skin.box, options);
	}

	public static void Box(string text, params GUILayoutOption[] options)
	{
		Box(text, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Box(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoBox(content, GUI.skin.box, options);
	}

	public static void Box(GUIContent content, params GUILayoutOption[] options)
	{
		Box(content, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Box(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoBox(GUIContent.Temp(image), style, options);
	}

	public static void Box(Texture image, GUIStyle style, params GUILayoutOption[] options)
	{
		Box(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Box(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoBox(GUIContent.Temp(text), style, options);
	}

	public static void Box(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		Box(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Box(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		DoBox(content, style, options);
	}

	public static void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		Box(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void DoBox(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		GUI.Box(GUILayoutUtility.GetRect(content, style, options), content, style);
	}

	public static bool Button(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoButton(GUIContent.Temp(image), GUI.skin.button, options);
	}

	public static bool Button(Texture image, params GUILayoutOption[] options)
	{
		return Button(image, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool Button(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoButton(content, GUI.skin.button, options);
	}

	public static bool Button(GUIContent content, params GUILayoutOption[] options)
	{
		return Button(content, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool Button(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoButton(GUIContent.Temp(image), style, options);
	}

	public static bool Button(Texture image, GUIStyle style, params GUILayoutOption[] options)
	{
		return Button(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool Button(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoButton(GUIContent.Temp(text), style, options);
	}

	public static bool Button(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		return Button(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool Button(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoButton(content, style, options);
	}

	public static bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		return Button(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool RepeatButton(Texture image, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoRepeatButton(GUIContent.Temp(image), GUI.skin.button, options);
	}

	public static bool RepeatButton(Texture image, params GUILayoutOption[] options)
	{
		return RepeatButton(image, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool RepeatButton(string text, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoRepeatButton(GUIContent.Temp(text), GUI.skin.button, options);
	}

	public static bool RepeatButton(string text, params GUILayoutOption[] options)
	{
		return RepeatButton(text, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool RepeatButton(GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoRepeatButton(content, GUI.skin.button, options);
	}

	public static bool RepeatButton(GUIContent content, params GUILayoutOption[] options)
	{
		return RepeatButton(content, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool RepeatButton(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoRepeatButton(GUIContent.Temp(image), style, options);
	}

	public static bool RepeatButton(Texture image, GUIStyle style, params GUILayoutOption[] options)
	{
		return RepeatButton(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool RepeatButton(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoRepeatButton(GUIContent.Temp(text), style, options);
	}

	public static bool RepeatButton(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		return RepeatButton(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool RepeatButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoRepeatButton(content, style, options);
	}

	public static bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		return RepeatButton(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool DoRepeatButton(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return GUI.RepeatButton(GUILayoutUtility.GetRect(content, style, options), content, style);
	}

	public static string TextField(string text, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoTextField(text, -1, multiline: false, GUI.skin.textField, options);
	}

	public static string TextField(string text, params GUILayoutOption[] options)
	{
		return TextField(text, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string TextField(string text, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoTextField(text, maxLength, multiline: false, GUI.skin.textField, options);
	}

	public static string TextField(string text, int maxLength, params GUILayoutOption[] options)
	{
		return TextField(text, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string TextField(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoTextField(text, -1, multiline: false, style, options);
	}

	public static string TextField(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		return TextField(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string TextField(string text, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoTextField(text, maxLength, multiline: false, style, options);
	}

	public static string TextField(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
	{
		return TextField(text, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string PasswordField(string password, char maskChar, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return PasswordField(password, maskChar, -1, GUI.skin.textField, options);
	}

	public static string PasswordField(string password, char maskChar, params GUILayoutOption[] options)
	{
		return PasswordField(password, maskChar, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string PasswordField(string password, char maskChar, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return PasswordField(password, maskChar, maxLength, GUI.skin.textField, options);
	}

	public static string PasswordField(string password, char maskChar, int maxLength, params GUILayoutOption[] options)
	{
		return PasswordField(password, maskChar, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string PasswordField(string password, char maskChar, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return PasswordField(password, maskChar, -1, style, options);
	}

	public static string PasswordField(string password, char maskChar, GUIStyle style, params GUILayoutOption[] options)
	{
		return PasswordField(password, maskChar, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		GUIContent content = GUIContent.Temp(GUI.PasswordFieldGetStrToShow(password, maskChar));
		return GUI.PasswordField(GUILayoutUtility.GetRect(content, GUI.skin.textField, options), password, maskChar, maxLength, style);
	}

	public static string PasswordField(string password, char maskChar, int maxLength, GUIStyle style, params GUILayoutOption[] options)
	{
		return PasswordField(password, maskChar, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string TextArea(string text, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoTextField(text, -1, multiline: true, GUI.skin.textArea, options);
	}

	public static string TextArea(string text, params GUILayoutOption[] options)
	{
		return TextArea(text, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string TextArea(string text, int maxLength, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoTextField(text, maxLength, multiline: true, GUI.skin.textArea, options);
	}

	public static string TextArea(string text, int maxLength, params GUILayoutOption[] options)
	{
		return TextArea(text, maxLength, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string TextArea(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoTextField(text, -1, multiline: true, style, options);
	}

	public static string TextArea(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		return TextArea(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string TextArea(string text, int maxLength, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoTextField(text, maxLength, multiline: true, style, options);
	}

	public static string TextArea(string text, int maxLength, GUIStyle style, params GUILayoutOption[] options)
	{
		return TextArea(text, maxLength, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static string DoTextField(string text, int maxLength, bool multiline, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
		GUIContent gUIContent = GUIContent.Temp(text);
		gUIContent = ((GUIUtility.keyboardControl == controlID) ? GUIContent.Temp(Il2CppSystem.String.Concat(text, GUIUtility.compositionString)) : GUIContent.Temp(text));
		Rect rect = GUILayoutUtility.GetRect(gUIContent, style, options);
		if (GUIUtility.keyboardControl == controlID)
		{
			gUIContent = GUIContent.Temp(text);
		}
		GUI.DoTextField(rect, controlID, gUIContent, multiline, maxLength, style);
		return gUIContent.text;
	}

	public static bool Toggle(bool value, Texture image, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoToggle(value, GUIContent.Temp(image), GUI.skin.toggle, options);
	}

	public static bool Toggle(bool value, Texture image, params GUILayoutOption[] options)
	{
		return Toggle(value, image, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool Toggle(bool value, string text, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoToggle(value, GUIContent.Temp(text), GUI.skin.toggle, options);
	}

	public static bool Toggle(bool value, string text, params GUILayoutOption[] options)
	{
		return Toggle(value, text, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool Toggle(bool value, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoToggle(value, content, GUI.skin.toggle, options);
	}

	public static bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options)
	{
		return Toggle(value, content, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool Toggle(bool value, Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoToggle(value, GUIContent.Temp(image), style, options);
	}

	public static bool Toggle(bool value, Texture image, GUIStyle style, params GUILayoutOption[] options)
	{
		return Toggle(value, image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool Toggle(bool value, string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoToggle(value, GUIContent.Temp(text), style, options);
	}

	public static bool Toggle(bool value, string text, GUIStyle style, params GUILayoutOption[] options)
	{
		return Toggle(value, text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool Toggle(bool value, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoToggle(value, content, style, options);
	}

	public static bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		return Toggle(value, content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static bool DoToggle(bool value, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return GUI.Toggle(GUILayoutUtility.GetRect(content, style, options), value, content, style);
	}

	public static int Toolbar(int selected, Il2CppStringArray texts, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, GUIContent.Temp(texts), GUI.skin.button, options);
	}

	public static int Toolbar(int selected, Il2CppStringArray texts, params GUILayoutOption[] options)
	{
		return Toolbar(selected, texts, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, GUIContent.Temp(images), GUI.skin.button, options);
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, params GUILayoutOption[] options)
	{
		return Toolbar(selected, images, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, contents, GUI.skin.button, options);
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, params GUILayoutOption[] options)
	{
		return Toolbar(selected, contents, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, GUIContent.Temp(texts), style, options);
	}

	public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, params GUILayoutOption[] options)
	{
		return Toolbar(selected, texts, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, GUIContent.Temp(images), style, options);
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, params GUILayoutOption[] options)
	{
		return Toolbar(selected, images, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, GUIContent.Temp(texts), style, buttonSize, options);
	}

	public static int Toolbar(int selected, Il2CppStringArray texts, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
	{
		return Toolbar(selected, texts, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, GUIContent.Temp(images), style, buttonSize, options);
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<Texture> images, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
	{
		return Toolbar(selected, images, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, contents, style, GUI.ToolbarButtonSize.Fixed, options);
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, params GUILayoutOption[] options)
	{
		return Toolbar(selected, contents, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, contents, null, style, buttonSize, options);
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
	{
		return Toolbar(selected, contents, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, contents, enabled, style, GUI.ToolbarButtonSize.Fixed, options);
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, params GUILayoutOption[] options)
	{
		return Toolbar(selected, contents, enabled, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return Toolbar(selected, contents, enabled, style, firstStyle, midStyle, lastStyle, GUI.ToolbarButtonSize.Fixed, options);
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, params GUILayoutOption[] options)
	{
		return Toolbar(selected, contents, enabled, style, firstStyle, midStyle, lastStyle, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
	{
		GUI.FindStyles(ref style, out var firstStyle, out var midStyle, out var lastStyle, "left", "mid", "right");
		return Toolbar(selected, contents, enabled, style, firstStyle, midStyle, lastStyle, buttonSize, options);
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
	{
		return Toolbar(selected, contents, enabled, style, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, Il2CppReferenceArray<GUILayoutOption> options)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int Toolbar(int selected, Il2CppReferenceArray<GUIContent> contents, Il2CppStructArray<bool> enabled, GUIStyle style, GUIStyle firstStyle, GUIStyle midStyle, GUIStyle lastStyle, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
	{
		return Toolbar(selected, contents, enabled, style, firstStyle, midStyle, lastStyle, buttonSize, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return SelectionGrid(selected, GUIContent.Temp(texts), xCount, GUI.skin.button, options);
	}

	public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, params GUILayoutOption[] options)
	{
		return SelectionGrid(selected, texts, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return SelectionGrid(selected, GUIContent.Temp(images), xCount, GUI.skin.button, options);
	}

	public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, params GUILayoutOption[] options)
	{
		return SelectionGrid(selected, images, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> content, int xCount, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return SelectionGrid(selected, content, xCount, GUI.skin.button, options);
	}

	public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> content, int xCount, params GUILayoutOption[] options)
	{
		return SelectionGrid(selected, content, xCount, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return SelectionGrid(selected, GUIContent.Temp(texts), xCount, style, options);
	}

	public static int SelectionGrid(int selected, Il2CppStringArray texts, int xCount, GUIStyle style, params GUILayoutOption[] options)
	{
		return SelectionGrid(selected, texts, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return SelectionGrid(selected, GUIContent.Temp(images), xCount, style, options);
	}

	public static int SelectionGrid(int selected, Il2CppReferenceArray<Texture> images, int xCount, GUIStyle style, params GUILayoutOption[] options)
	{
		return SelectionGrid(selected, images, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return GUI.SelectionGrid(GUIGridSizer.GetRect(contents, xCount, style, options), selected, contents, xCount, style);
	}

	public static int SelectionGrid(int selected, Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
	{
		return SelectionGrid(selected, contents, xCount, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static float HorizontalSlider(float value, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoHorizontalSlider(value, leftValue, rightValue, GUI.skin.horizontalSlider, GUI.skin.horizontalSliderThumb, options);
	}

	public static float HorizontalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
	{
		return HorizontalSlider(value, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoHorizontalSlider(value, leftValue, rightValue, slider, thumb, options);
	}

	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
	{
		return HorizontalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return GUI.HorizontalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), slider, options), value, leftValue, rightValue, slider, thumb);
	}

	public static float VerticalSlider(float value, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoVerticalSlider(value, leftValue, rightValue, GUI.skin.verticalSlider, GUI.skin.verticalSliderThumb, options);
	}

	public static float VerticalSlider(float value, float leftValue, float rightValue, params GUILayoutOption[] options)
	{
		return VerticalSlider(value, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoVerticalSlider(value, leftValue, rightValue, slider, thumb, options);
	}

	public static float VerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
	{
		return VerticalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static float DoVerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return GUI.VerticalSlider(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n\n"), slider, options), value, leftValue, rightValue, slider, thumb);
	}

	public static float DoVerticalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, params GUILayoutOption[] options)
	{
		return DoVerticalSlider(value, leftValue, rightValue, slider, thumb, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return HorizontalScrollbar(value, size, leftValue, rightValue, GUI.skin.horizontalScrollbar, options);
	}

	public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, params GUILayoutOption[] options)
	{
		return HorizontalScrollbar(value, size, leftValue, rightValue, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return GUI.HorizontalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("mmmm"), style, options), value, size, leftValue, rightValue, style);
	}

	public static float HorizontalScrollbar(float value, float size, float leftValue, float rightValue, GUIStyle style, params GUILayoutOption[] options)
	{
		return HorizontalScrollbar(value, size, leftValue, rightValue, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return VerticalScrollbar(value, size, topValue, bottomValue, GUI.skin.verticalScrollbar, options);
	}

	public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, params GUILayoutOption[] options)
	{
		return VerticalScrollbar(value, size, topValue, bottomValue, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return GUI.VerticalScrollbar(GUILayoutUtility.GetRect(GUIContent.Temp("\n\n\n\n"), style, options), value, size, topValue, bottomValue, style);
	}

	public static float VerticalScrollbar(float value, float size, float topValue, float bottomValue, GUIStyle style, params GUILayoutOption[] options)
	{
		return VerticalScrollbar(value, size, topValue, bottomValue, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void Space(float pixels)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static void BeginHorizontal(Il2CppReferenceArray<GUILayoutOption> options)
	{
		BeginHorizontal(GUIContent.none, GUIStyle.none, options);
	}

	public static void BeginHorizontal(params GUILayoutOption[] options)
	{
		BeginHorizontal(new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void BeginHorizontal(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		BeginHorizontal(GUIContent.Temp(text), style, options);
	}

	public static void BeginHorizontal(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		BeginHorizontal(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void BeginHorizontal(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		BeginHorizontal(GUIContent.Temp(image), style, options);
	}

	public static void BeginHorizontal(Texture image, GUIStyle style, params GUILayoutOption[] options)
	{
		BeginHorizontal(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void BeginVertical(Il2CppReferenceArray<GUILayoutOption> options)
	{
		BeginVertical(GUIContent.none, GUIStyle.none, options);
	}

	public static void BeginVertical(params GUILayoutOption[] options)
	{
		BeginVertical(new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void BeginVertical(GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		BeginVertical(GUIContent.none, style, options);
	}

	public static void BeginVertical(GUIStyle style, params GUILayoutOption[] options)
	{
		BeginVertical(style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void BeginVertical(string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		BeginVertical(GUIContent.Temp(text), style, options);
	}

	public static void BeginVertical(string text, GUIStyle style, params GUILayoutOption[] options)
	{
		BeginVertical(text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void BeginVertical(Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		BeginVertical(GUIContent.Temp(image), style, options);
	}

	public static void BeginVertical(Texture image, GUIStyle style, params GUILayoutOption[] options)
	{
		BeginVertical(image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void BeginVertical(GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		GUILayoutGroup gUILayoutGroup = GUILayoutUtility.BeginLayoutGroup(style, options, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<GUILayoutGroup>()));
		gUILayoutGroup.isVertical = true;
		if (style != GUIStyle.none || content != GUIContent.none)
		{
			GUI.Box(gUILayoutGroup.rect, content, style);
		}
	}

	public static void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		BeginVertical(content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void EndVertical()
	{
		GUILayoutUtility.EndLayoutGroup();
	}

	public static void BeginArea(Rect screenRect, string text)
	{
		BeginArea(screenRect, GUIContent.Temp(text), GUIStyle.none);
	}

	public static void BeginArea(Rect screenRect, Texture image)
	{
		BeginArea(screenRect, GUIContent.Temp(image), GUIStyle.none);
	}

	public static void BeginArea(Rect screenRect, GUIContent content)
	{
		BeginArea(screenRect, content, GUIStyle.none);
	}

	public static void BeginArea(Rect screenRect, GUIStyle style)
	{
		BeginArea(screenRect, GUIContent.none, style);
	}

	public static void BeginArea(Rect screenRect, string text, GUIStyle style)
	{
		BeginArea(screenRect, GUIContent.Temp(text), style);
	}

	public static void BeginArea(Rect screenRect, Texture image, GUIStyle style)
	{
		BeginArea(screenRect, GUIContent.Temp(image), style);
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return BeginScrollView(scrollPosition, alwaysShowHorizontal: false, alwaysShowVertical: false, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, params GUILayoutOption[] options)
	{
		return BeginScrollView(scrollPosition, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, GUI.skin.horizontalScrollbar, GUI.skin.verticalScrollbar, GUI.skin.scrollView, options);
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, params GUILayoutOption[] options)
	{
		return BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return BeginScrollView(scrollPosition, alwaysShowHorizontal: false, alwaysShowVertical: false, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
	{
		return BeginScrollView(scrollPosition, horizontalScrollbar, verticalScrollbar, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style)
	{
		Il2CppReferenceArray<GUILayoutOption> options = null;
		return BeginScrollView(scrollPosition, style, options);
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		string name = style.name;
		GUIStyle gUIStyle = GUI.skin.FindStyle(Il2CppSystem.String.Concat(name, "VerticalScrollbar"));
		if (gUIStyle == null)
		{
			gUIStyle = GUI.skin.verticalScrollbar;
		}
		GUIStyle gUIStyle2 = GUI.skin.FindStyle(Il2CppSystem.String.Concat(name, "HorizontalScrollbar"));
		if (gUIStyle2 == null)
		{
			gUIStyle2 = GUI.skin.horizontalScrollbar;
		}
		return BeginScrollView(scrollPosition, alwaysShowHorizontal: false, alwaysShowVertical: false, gUIStyle2, gUIStyle, style, options);
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, GUIStyle style, params GUILayoutOption[] options)
	{
		return BeginScrollView(scrollPosition, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, GUI.skin.scrollView, options);
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, params GUILayoutOption[] options)
	{
		return BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, Il2CppReferenceArray<GUILayoutOption> options)
	{
		GUIUtility.CheckOnGUI();
		GUIScrollGroup gUIScrollGroup = ((Il2CppObjectBase)GUILayoutUtility.BeginLayoutGroup(background, null, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<GUIScrollGroup>()))).Cast<GUIScrollGroup>();
		EventType type = Event.current.type;
		EventType eventType = type;
		if (eventType == EventType.Layout)
		{
			gUIScrollGroup.resetCoords = true;
			gUIScrollGroup.isVertical = true;
			gUIScrollGroup.stretchWidth = 1;
			gUIScrollGroup.stretchHeight = 1;
			gUIScrollGroup.verticalScrollbar = verticalScrollbar;
			gUIScrollGroup.horizontalScrollbar = horizontalScrollbar;
			gUIScrollGroup.needsVerticalScrollbar = alwaysShowVertical;
			gUIScrollGroup.needsHorizontalScrollbar = alwaysShowHorizontal;
			gUIScrollGroup.ApplyOptions(options);
		}
		return GUI.BeginScrollView(gUIScrollGroup.rect, scrollPosition, new Rect(0f, 0f, gUIScrollGroup.clientWidth, gUIScrollGroup.clientHeight), alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background);
	}

	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, params GUILayoutOption[] options)
	{
		return BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, background, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static void EndScrollView()
	{
		EndScrollView(handleScrollWheel: true);
	}

	public static void EndScrollView(bool handleScrollWheel)
	{
		GUILayoutUtility.EndLayoutGroup();
		GUI.EndScrollView(handleScrollWheel);
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoWindow(id, screenRect, func, GUIContent.Temp(text), GUI.skin.window, options);
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, params GUILayoutOption[] options)
	{
		return Window(id, screenRect, func, text, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoWindow(id, screenRect, func, GUIContent.Temp(image), GUI.skin.window, options);
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, params GUILayoutOption[] options)
	{
		return Window(id, screenRect, func, image, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoWindow(id, screenRect, func, content, GUI.skin.window, options);
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options)
	{
		return Window(id, screenRect, func, content, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoWindow(id, screenRect, func, GUIContent.Temp(text), style, options);
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUIStyle style, params GUILayoutOption[] options)
	{
		return Window(id, screenRect, func, text, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoWindow(id, screenRect, func, GUIContent.Temp(image), style, options);
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, Texture image, GUIStyle style, params GUILayoutOption[] options)
	{
		return Window(id, screenRect, func, image, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		return DoWindow(id, screenRect, func, content, style, options);
	}

	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
	{
		return Window(id, screenRect, func, content, style, new Il2CppReferenceArray<GUILayoutOption>(options));
	}

	public unsafe static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
	{
		GUIUtility.CheckOnGUI();
		LayoutedWindow @object = new LayoutedWindow(func, screenRect, content, options, style);
		return GUI.Window(id, screenRect, new GUI.WindowFunction((Il2CppSystem.Object)(object)@object, (nint)__ldftn(LayoutedWindow.DoWindow)), content, style);
	}

	public static GUILayoutOption MinWidth(float minWidth)
	{
		return new GUILayoutOption(GUILayoutOption.Type.minWidth, (Il2CppSystem.Object)(object)minWidth);
	}

	public static GUILayoutOption MaxWidth(float maxWidth)
	{
		return new GUILayoutOption(GUILayoutOption.Type.maxWidth, (Il2CppSystem.Object)(object)maxWidth);
	}

	public static GUILayoutOption MinHeight(float minHeight)
	{
		return new GUILayoutOption(GUILayoutOption.Type.minHeight, (Il2CppSystem.Object)(object)minHeight);
	}

	public static GUILayoutOption MaxHeight(float maxHeight)
	{
		return new GUILayoutOption(GUILayoutOption.Type.maxHeight, (Il2CppSystem.Object)(object)maxHeight);
	}
}
