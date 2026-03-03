using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ShaderDebugPrintInput
{
	private static readonly System.IntPtr NativeFieldInfoPtr__pos_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__leftDown_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__rightDown_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__middleDown_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_pos_Public_get_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_pos_Public_set_Void_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_leftDown_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_leftDown_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_rightDown_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_rightDown_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_middleDown_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_middleDown_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_String_Public_String_0;

	[FieldOffset(0)]
	public Vector2 _pos_k__BackingField;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.U1)]
	public bool _leftDown_k__BackingField;

	[FieldOffset(9)]
	[MarshalAs(UnmanagedType.U1)]
	public bool _rightDown_k__BackingField;

	[FieldOffset(10)]
	[MarshalAs(UnmanagedType.U1)]
	public bool _middleDown_k__BackingField;

	public unsafe Vector2 pos
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_pos_Public_get_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 687877, RefRangeEnd = 687880, XrefRangeStart = 687877, XrefRangeEnd = 687880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_pos_Public_set_Void_Vector2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool leftDown
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_leftDown_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 376360, XrefRangeStart = 376359, XrefRangeEnd = 376360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_leftDown_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool rightDown
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_rightDown_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584896, RefRangeEnd = 584897, XrefRangeStart = 584896, XrefRangeEnd = 584897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_rightDown_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool middleDown
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_middleDown_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584897, RefRangeEnd = 584898, XrefRangeStart = 584897, XrefRangeEnd = 584898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_middleDown_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ShaderDebugPrintInput()
	{
		Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ShaderDebugPrintInput");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr);
		NativeFieldInfoPtr__pos_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, "<pos>k__BackingField");
		NativeFieldInfoPtr__leftDown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, "<leftDown>k__BackingField");
		NativeFieldInfoPtr__rightDown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, "<rightDown>k__BackingField");
		NativeFieldInfoPtr__middleDown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, "<middleDown>k__BackingField");
		NativeMethodInfoPtr_get_pos_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100665131);
		NativeMethodInfoPtr_set_pos_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100665132);
		NativeMethodInfoPtr_get_leftDown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100665133);
		NativeMethodInfoPtr_set_leftDown_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100665134);
		NativeMethodInfoPtr_get_rightDown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100665135);
		NativeMethodInfoPtr_set_rightDown_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100665136);
		NativeMethodInfoPtr_get_middleDown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100665137);
		NativeMethodInfoPtr_set_middleDown_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100665138);
		NativeMethodInfoPtr_String_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, 100665139);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036162, XrefRangeEnd = 1036188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string String()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_String_Public_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderDebugPrintInput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
