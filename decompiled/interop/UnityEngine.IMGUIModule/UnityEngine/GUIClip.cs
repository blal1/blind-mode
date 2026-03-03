using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public sealed class GUIClip : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ParentClipScope
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_m_Disposed;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Rect_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool m_Disposed;

		static ParentClipScope()
		{
			Il2CppClassPointerStore<ParentClipScope>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, "ParentClipScope");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParentClipScope>.NativeClassPtr);
			NativeFieldInfoPtr_m_Disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParentClipScope>.NativeClassPtr, "m_Disposed");
			NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParentClipScope>.NativeClassPtr, 100663450);
			NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParentClipScope>.NativeClassPtr, 100663451);
		}

		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1245433, RefRangeEnd = 1245435, XrefRangeStart = 1245431, XrefRangeEnd = 1245433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParentClipScope(Matrix4x4 objectTransform, Rect clipRect)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&objectTransform);
			*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clipRect;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Matrix4x4_Rect_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1245437, RefRangeEnd = 1245441, XrefRangeStart = 1245435, XrefRangeEnd = 1245437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParentClipScope>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private delegate bool get_enabledDelegate();

	private delegate void ReapplyDelegate();

	private delegate void get_topmostRect_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetTopRect_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void Unclip_Vector2_InjectedDelegate([In] System.IntPtr pos, [Out] System.IntPtr ret);

	private delegate void Unclip_Rect_InjectedDelegate([In] System.IntPtr rect, [Out] System.IntPtr ret);

	private delegate void Clip_Vector2_InjectedDelegate([In] System.IntPtr absolutePos, [Out] System.IntPtr ret);

	private delegate void Internal_Clip_Rect_InjectedDelegate([In] System.IntPtr absoluteRect, [Out] System.IntPtr ret);

	private delegate void UnclipToWindow_Vector2_InjectedDelegate([In] System.IntPtr pos, [Out] System.IntPtr ret);

	private delegate void UnclipToWindow_Rect_InjectedDelegate([In] System.IntPtr rect, [Out] System.IntPtr ret);

	private delegate void ClipToWindow_Vector2_InjectedDelegate([In] System.IntPtr absolutePos, [Out] System.IntPtr ret);

	private delegate void ClipToWindow_Rect_InjectedDelegate([In] System.IntPtr absoluteRect, [Out] System.IntPtr ret);

	private delegate void Internal_GetAbsoluteMousePosition_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void GetParentMatrix_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_visibleRect_Internal_Static_get_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Pop_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetCount_Internal_Static_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMatrix_Internal_Static_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrix_Internal_Static_Void_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Matrix4x4_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_PopParentClip_Internal_Static_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_visibleRect_Injected_Private_Static_Void_byref_Rect_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Push_Injected_Private_Static_Void_byref_Rect_byref_Vector2_byref_Vector2_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_PushParentClip_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_byref_Rect_0;

	private static readonly get_enabledDelegate get_enabledDelegateField;

	private static readonly ReapplyDelegate ReapplyDelegateField;

	private static readonly get_topmostRect_InjectedDelegate get_topmostRect_InjectedDelegateField;

	private static readonly GetTopRect_InjectedDelegate GetTopRect_InjectedDelegateField;

	private static readonly Unclip_Vector2_InjectedDelegate Unclip_Vector2_InjectedDelegateField;

	private static readonly Unclip_Rect_InjectedDelegate Unclip_Rect_InjectedDelegateField;

	private static readonly Clip_Vector2_InjectedDelegate Clip_Vector2_InjectedDelegateField;

	private static readonly Internal_Clip_Rect_InjectedDelegate Internal_Clip_Rect_InjectedDelegateField;

	private static readonly UnclipToWindow_Vector2_InjectedDelegate UnclipToWindow_Vector2_InjectedDelegateField;

	private static readonly UnclipToWindow_Rect_InjectedDelegate UnclipToWindow_Rect_InjectedDelegateField;

	private static readonly ClipToWindow_Vector2_InjectedDelegate ClipToWindow_Vector2_InjectedDelegateField;

	private static readonly ClipToWindow_Rect_InjectedDelegate ClipToWindow_Rect_InjectedDelegateField;

	private static readonly Internal_GetAbsoluteMousePosition_InjectedDelegate Internal_GetAbsoluteMousePosition_InjectedDelegateField;

	private static readonly GetParentMatrix_InjectedDelegate GetParentMatrix_InjectedDelegateField;

	public unsafe static Rect visibleRect
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245441, XrefRangeEnd = 1245443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_visibleRect_Internal_Static_get_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Rect*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static bool enabled => get_enabledDelegateField();

	public static Rect topmostRect
	{
		get
		{
			get_topmostRect_Injected(out var ret);
			return ret;
		}
	}

	static GUIClip()
	{
		Il2CppClassPointerStore<GUIClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIClip");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIClip>.NativeClassPtr);
		NativeMethodInfoPtr_get_visibleRect_Internal_Static_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663435);
		NativeMethodInfoPtr_Internal_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663436);
		NativeMethodInfoPtr_Internal_Pop_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663437);
		NativeMethodInfoPtr_Internal_GetCount_Internal_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663438);
		NativeMethodInfoPtr_GetMatrix_Internal_Static_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663439);
		NativeMethodInfoPtr_SetMatrix_Internal_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663440);
		NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663441);
		NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Matrix4x4_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663442);
		NativeMethodInfoPtr_Internal_PopParentClip_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663443);
		NativeMethodInfoPtr_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663444);
		NativeMethodInfoPtr_get_visibleRect_Injected_Private_Static_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663445);
		NativeMethodInfoPtr_Internal_Push_Injected_Private_Static_Void_byref_Rect_byref_Vector2_byref_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663446);
		NativeMethodInfoPtr_GetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663447);
		NativeMethodInfoPtr_SetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663448);
		NativeMethodInfoPtr_Internal_PushParentClip_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIClip>.NativeClassPtr, 100663449);
		get_enabledDelegateField = IL2CPP.ResolveICall<get_enabledDelegate>("UnityEngine.GUIClip::get_enabled");
		ReapplyDelegateField = IL2CPP.ResolveICall<ReapplyDelegate>("UnityEngine.GUIClip::Reapply");
		get_topmostRect_InjectedDelegateField = IL2CPP.ResolveICall<get_topmostRect_InjectedDelegate>("UnityEngine.GUIClip::get_topmostRect_Injected");
		GetTopRect_InjectedDelegateField = IL2CPP.ResolveICall<GetTopRect_InjectedDelegate>("UnityEngine.GUIClip::GetTopRect_Injected");
		Unclip_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<Unclip_Vector2_InjectedDelegate>("UnityEngine.GUIClip::Unclip_Vector2_Injected");
		Unclip_Rect_InjectedDelegateField = IL2CPP.ResolveICall<Unclip_Rect_InjectedDelegate>("UnityEngine.GUIClip::Unclip_Rect_Injected");
		Clip_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<Clip_Vector2_InjectedDelegate>("UnityEngine.GUIClip::Clip_Vector2_Injected");
		Internal_Clip_Rect_InjectedDelegateField = IL2CPP.ResolveICall<Internal_Clip_Rect_InjectedDelegate>("UnityEngine.GUIClip::Internal_Clip_Rect_Injected");
		UnclipToWindow_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<UnclipToWindow_Vector2_InjectedDelegate>("UnityEngine.GUIClip::UnclipToWindow_Vector2_Injected");
		UnclipToWindow_Rect_InjectedDelegateField = IL2CPP.ResolveICall<UnclipToWindow_Rect_InjectedDelegate>("UnityEngine.GUIClip::UnclipToWindow_Rect_Injected");
		ClipToWindow_Vector2_InjectedDelegateField = IL2CPP.ResolveICall<ClipToWindow_Vector2_InjectedDelegate>("UnityEngine.GUIClip::ClipToWindow_Vector2_Injected");
		ClipToWindow_Rect_InjectedDelegateField = IL2CPP.ResolveICall<ClipToWindow_Rect_InjectedDelegate>("UnityEngine.GUIClip::ClipToWindow_Rect_Injected");
		Internal_GetAbsoluteMousePosition_InjectedDelegateField = IL2CPP.ResolveICall<Internal_GetAbsoluteMousePosition_InjectedDelegate>("UnityEngine.GUIClip::Internal_GetAbsoluteMousePosition_Injected");
		GetParentMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GetParentMatrix_InjectedDelegate>("UnityEngine.GUIClip::GetParentMatrix_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245443, XrefRangeEnd = 1245445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&screenRect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scrollOffset;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderOffset;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &resetOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245445, XrefRangeEnd = 1245447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Pop()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Pop_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1245449, RefRangeEnd = 1245450, XrefRangeStart = 1245447, XrefRangeEnd = 1245449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Internal_GetCount()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_GetCount_Internal_Static_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245450, XrefRangeEnd = 1245452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Matrix4x4 GetMatrix()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMatrix_Internal_Static_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Matrix4x4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245452, XrefRangeEnd = 1245454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMatrix(Matrix4x4 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrix_Internal_Static_Void_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245454, XrefRangeEnd = 1245456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&objectTransform);
		*(Rect**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &clipRect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245456, XrefRangeEnd = 1245458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_PushParentClip(Matrix4x4 renderTransform, Matrix4x4 inputTransform, Rect clipRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&renderTransform);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &inputTransform;
		*(Rect**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &clipRect;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_PushParentClip_Internal_Static_Void_Matrix4x4_Matrix4x4_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245458, XrefRangeEnd = 1245460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_PopParentClip()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_PopParentClip_Internal_Static_Void_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245460, XrefRangeEnd = 1245462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&screenRect);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scrollOffset;
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderOffset;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &resetOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Push_Internal_Static_Void_Rect_Vector2_Vector2_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245462, XrefRangeEnd = 1245464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_visibleRect_Injected(out Rect ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_visibleRect_Injected_Private_Static_Void_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245464, XrefRangeEnd = 1245466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_Push_Injected([In] ref Rect screenRect, [In] ref Vector2 scrollOffset, [In] ref Vector2 renderOffset, bool resetOffset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref screenRect);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scrollOffset);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderOffset);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &resetOffset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_Push_Injected_Private_Static_Void_byref_Rect_byref_Vector2_byref_Vector2_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245466, XrefRangeEnd = 1245468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetMatrix_Injected(out Matrix4x4 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245468, XrefRangeEnd = 1245470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMatrix_Injected([In] ref Matrix4x4 m)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref m);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1245470, XrefRangeEnd = 1245472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_PushParentClip_Injected([In] ref Matrix4x4 renderTransform, [In] ref Matrix4x4 inputTransform, [In] ref Rect clipRect)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref renderTransform);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref inputTransform);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref clipRect);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_PushParentClip_Injected_Private_Static_Void_byref_Matrix4x4_byref_Matrix4x4_byref_Rect_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public GUIClip(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static Rect GetTopRect()
	{
		GetTopRect_Injected(out var ret);
		return ret;
	}

	public static Vector2 Unclip_Vector2(Vector2 pos)
	{
		Unclip_Vector2_Injected(ref pos, out var ret);
		return ret;
	}

	public static Rect Unclip_Rect(Rect rect)
	{
		Unclip_Rect_Injected(ref rect, out var ret);
		return ret;
	}

	public static Vector2 Clip_Vector2(Vector2 absolutePos)
	{
		Clip_Vector2_Injected(ref absolutePos, out var ret);
		return ret;
	}

	public static Rect Internal_Clip_Rect(Rect absoluteRect)
	{
		Internal_Clip_Rect_Injected(ref absoluteRect, out var ret);
		return ret;
	}

	public static Vector2 UnclipToWindow_Vector2(Vector2 pos)
	{
		UnclipToWindow_Vector2_Injected(ref pos, out var ret);
		return ret;
	}

	public static Rect UnclipToWindow_Rect(Rect rect)
	{
		UnclipToWindow_Rect_Injected(ref rect, out var ret);
		return ret;
	}

	public static Vector2 ClipToWindow_Vector2(Vector2 absolutePos)
	{
		ClipToWindow_Vector2_Injected(ref absolutePos, out var ret);
		return ret;
	}

	public static Rect ClipToWindow_Rect(Rect absoluteRect)
	{
		ClipToWindow_Rect_Injected(ref absoluteRect, out var ret);
		return ret;
	}

	public static Vector2 Internal_GetAbsoluteMousePosition()
	{
		Internal_GetAbsoluteMousePosition_Injected(out var ret);
		return ret;
	}

	public static void Reapply()
	{
		ReapplyDelegateField();
	}

	public static Matrix4x4 GetParentMatrix()
	{
		GetParentMatrix_Injected(out var ret);
		return ret;
	}

	public static void Pop()
	{
		Internal_Pop();
	}

	public static Vector2 Unclip(Vector2 pos)
	{
		return Unclip_Vector2(pos);
	}

	public static Rect Unclip(Rect rect)
	{
		return Unclip_Rect(rect);
	}

	public static Vector2 Clip(Vector2 absolutePos)
	{
		return Clip_Vector2(absolutePos);
	}

	public static Rect Clip(Rect absoluteRect)
	{
		return Internal_Clip_Rect(absoluteRect);
	}

	public static Vector2 UnclipToWindow(Vector2 pos)
	{
		return UnclipToWindow_Vector2(pos);
	}

	public static Rect UnclipToWindow(Rect rect)
	{
		return UnclipToWindow_Rect(rect);
	}

	public static Vector2 ClipToWindow(Vector2 absolutePos)
	{
		return ClipToWindow_Vector2(absolutePos);
	}

	public static Rect ClipToWindow(Rect absoluteRect)
	{
		return ClipToWindow_Rect(absoluteRect);
	}

	public static Vector2 GetAbsoluteMousePosition()
	{
		return Internal_GetAbsoluteMousePosition();
	}

	public unsafe static void get_topmostRect_Injected(out Rect ret)
	{
		get_topmostRect_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetTopRect_Injected(out Rect ret)
	{
		GetTopRect_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Unclip_Vector2_Injected([In] ref Vector2 pos, out Vector2 ret)
	{
		Unclip_Vector2_InjectedDelegateField((nint)Unsafe.AsPointer(ref pos), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Unclip_Rect_Injected([In] ref Rect rect, out Rect ret)
	{
		Unclip_Rect_InjectedDelegateField((nint)Unsafe.AsPointer(ref rect), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Clip_Vector2_Injected([In] ref Vector2 absolutePos, out Vector2 ret)
	{
		Clip_Vector2_InjectedDelegateField((nint)Unsafe.AsPointer(ref absolutePos), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Internal_Clip_Rect_Injected([In] ref Rect absoluteRect, out Rect ret)
	{
		Internal_Clip_Rect_InjectedDelegateField((nint)Unsafe.AsPointer(ref absoluteRect), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void UnclipToWindow_Vector2_Injected([In] ref Vector2 pos, out Vector2 ret)
	{
		UnclipToWindow_Vector2_InjectedDelegateField((nint)Unsafe.AsPointer(ref pos), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void UnclipToWindow_Rect_Injected([In] ref Rect rect, out Rect ret)
	{
		UnclipToWindow_Rect_InjectedDelegateField((nint)Unsafe.AsPointer(ref rect), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ClipToWindow_Vector2_Injected([In] ref Vector2 absolutePos, out Vector2 ret)
	{
		ClipToWindow_Vector2_InjectedDelegateField((nint)Unsafe.AsPointer(ref absolutePos), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void ClipToWindow_Rect_Injected([In] ref Rect absoluteRect, out Rect ret)
	{
		ClipToWindow_Rect_InjectedDelegateField((nint)Unsafe.AsPointer(ref absoluteRect), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void Internal_GetAbsoluteMousePosition_Injected(out Vector2 ret)
	{
		Internal_GetAbsoluteMousePosition_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void GetParentMatrix_Injected(out Matrix4x4 ret)
	{
		GetParentMatrix_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}
}
