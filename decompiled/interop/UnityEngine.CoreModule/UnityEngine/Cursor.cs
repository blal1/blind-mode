using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

public class Cursor : Il2CppSystem.Object
{
	private delegate bool get_visibleDelegate();

	private delegate void set_lockStateDelegate(CursorLockMode value);

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_IntPtr_byref_Vector2_CursorMode_0;

	private static readonly get_visibleDelegate get_visibleDelegateField;

	private static readonly set_lockStateDelegate set_lockStateDelegateField;

	public unsafe static bool visible
	{
		get
		{
			return get_visibleDelegateField();
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1182314, RefRangeEnd = 1182316, XrefRangeStart = 1182312, XrefRangeEnd = 1182314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static CursorLockMode lockState
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1182318, RefRangeEnd = 1182323, XrefRangeStart = 1182316, XrefRangeEnd = 1182318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CursorLockMode*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			set_lockStateDelegateField(value);
		}
	}

	static Cursor()
	{
		Il2CppClassPointerStore<Cursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Cursor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cursor>.NativeClassPtr);
		NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665542);
		NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665543);
		NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665544);
		NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_IntPtr_byref_Vector2_CursorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100665545);
		get_visibleDelegateField = IL2CPP.ResolveICall<get_visibleDelegate>("UnityEngine.Cursor::get_visible");
		set_lockStateDelegateField = IL2CPP.ResolveICall<set_lockStateDelegate>("UnityEngine.Cursor::set_lockState");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1182310, RefRangeEnd = 1182312, XrefRangeStart = 1182305, XrefRangeEnd = 1182310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)texture);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &hotspot;
		*(CursorMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cursorMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1182323, XrefRangeEnd = 1182325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCursor_Injected(System.IntPtr texture, [In] ref Vector2 hotspot, CursorMode cursorMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&texture);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref hotspot);
		*(CursorMode**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cursorMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_IntPtr_byref_Vector2_CursorMode_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Cursor(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void SetCursor(Texture2D texture, CursorMode cursorMode)
	{
		SetCursor(texture, Vector2.zero, cursorMode);
	}
}
