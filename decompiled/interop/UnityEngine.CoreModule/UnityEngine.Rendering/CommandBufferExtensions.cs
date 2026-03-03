using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class CommandBufferExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_Boolean_0;

	static CommandBufferExtensions()
	{
		Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CommandBufferExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100668269);
		NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100668270);
		NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100668271);
		NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100668272);
		NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100668273);
		NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandBufferExtensions>.NativeClassPtr, 100668274);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237029, XrefRangeEnd = 1237037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SwitchIntoFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rt);
		*(FastMemoryFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fastMemoryFlags;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &residency;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &copyContents;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237037, XrefRangeEnd = 1237045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SwitchOutOfFastMemory(CommandBuffer cmd, ref RenderTargetIdentifier rt, bool copyContents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rt);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &copyContents;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Private_Static_Void_CommandBuffer_byref_RenderTargetIdentifier_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1237050, RefRangeEnd = 1237052, XrefRangeStart = 1237045, XrefRangeEnd = 1237050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SwitchIntoFastMemory(this CommandBuffer cmd, RenderTargetIdentifier rid, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rid;
		*(FastMemoryFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fastMemoryFlags;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &residency;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &copyContents;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchIntoFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237057, RefRangeEnd = 1237058, XrefRangeStart = 1237052, XrefRangeEnd = 1237057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SwitchOutOfFastMemory(this CommandBuffer cmd, RenderTargetIdentifier rid, bool copyContents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rid;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &copyContents;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SwitchOutOfFastMemory_Public_Static_Void_CommandBuffer_RenderTargetIdentifier_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237058, XrefRangeEnd = 1237060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SwitchIntoFastMemory_Injected(System.IntPtr cmd, ref RenderTargetIdentifier rt, FastMemoryFlags fastMemoryFlags, float residency, bool copyContents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rt);
		*(FastMemoryFlags**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fastMemoryFlags;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &residency;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &copyContents;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SwitchIntoFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_FastMemoryFlags_Single_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237060, XrefRangeEnd = 1237062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_SwitchOutOfFastMemory_Injected(System.IntPtr cmd, ref RenderTargetIdentifier rt, bool copyContents)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rt);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &copyContents;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_SwitchOutOfFastMemory_Injected_Private_Static_Void_IntPtr_byref_RenderTargetIdentifier_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public CommandBufferExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
