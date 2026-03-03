using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RenderGraphModule;

[StructLayout(LayoutKind.Explicit)]
public struct TextureAccess
{
	private static readonly System.IntPtr NativeFieldInfoPtr_textureHandle;

	private static readonly System.IntPtr NativeFieldInfoPtr_mipLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_depthSlice;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_AccessFlags_Int32_Int32_0;

	[FieldOffset(0)]
	public TextureHandle textureHandle;

	[FieldOffset(16)]
	public int mipLevel;

	[FieldOffset(20)]
	public int depthSlice;

	[FieldOffset(24)]
	public AccessFlags flags;

	static TextureAccess()
	{
		Il2CppClassPointerStore<TextureAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.RenderGraphModule", "TextureAccess");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureAccess>.NativeClassPtr);
		NativeFieldInfoPtr_textureHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureAccess>.NativeClassPtr, "textureHandle");
		NativeFieldInfoPtr_mipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureAccess>.NativeClassPtr, "mipLevel");
		NativeFieldInfoPtr_depthSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureAccess>.NativeClassPtr, "depthSlice");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureAccess>.NativeClassPtr, "flags");
		NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_AccessFlags_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureAccess>.NativeClassPtr, 100667717);
	}

	[CallerCount(0)]
	public unsafe TextureAccess(TextureHandle handle, AccessFlags flags, int mipLevel, int depthSlice)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&handle);
		*(AccessFlags**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &flags;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_TextureHandle_AccessFlags_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureAccess>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
