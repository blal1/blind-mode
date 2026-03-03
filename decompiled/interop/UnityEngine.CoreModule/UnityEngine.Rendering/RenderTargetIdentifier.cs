using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RenderTargetIdentifier
{
	private static readonly System.IntPtr NativeFieldInfoPtr_AllDepthSlices;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_NameID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferPointer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_MipLevel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CubeFace;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthSlice;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CubemapFace_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0;

	[FieldOffset(0)]
	public BuiltinRenderTextureType m_Type;

	[FieldOffset(4)]
	public int m_NameID;

	[FieldOffset(8)]
	public int m_InstanceID;

	[FieldOffset(16)]
	public System.IntPtr m_BufferPointer;

	[FieldOffset(24)]
	public int m_MipLevel;

	[FieldOffset(28)]
	public CubemapFace m_CubeFace;

	[FieldOffset(32)]
	public int m_DepthSlice;

	public unsafe static int AllDepthSlices
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_AllDepthSlices, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_AllDepthSlices, (void*)(&value));
		}
	}

	static RenderTargetIdentifier()
	{
		Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderTargetIdentifier");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr);
		NativeFieldInfoPtr_AllDepthSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "AllDepthSlices");
		NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_Type");
		NativeFieldInfoPtr_m_NameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_NameID");
		NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_InstanceID");
		NativeFieldInfoPtr_m_BufferPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_BufferPointer");
		NativeFieldInfoPtr_m_MipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_MipLevel");
		NativeFieldInfoPtr_m_CubeFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_CubeFace");
		NativeFieldInfoPtr_m_DepthSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, "m_DepthSlice");
		NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667683);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667684);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667685);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667686);
		NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667687);
		NativeMethodInfoPtr__ctor_Public_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667688);
		NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667689);
		NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667690);
		NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667691);
		NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667692);
		NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667693);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667694);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667695);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667696);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667697);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667698);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100667699);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1231880, RefRangeEnd = 1231883, XrefRangeStart = 1231880, XrefRangeEnd = 1231880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetIdentifier(BuiltinRenderTextureType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1231883, XrefRangeEnd = 1231884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetIdentifier(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe RenderTargetIdentifier(int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1231884, RefRangeEnd = 1231885, XrefRangeStart = 1231884, XrefRangeEnd = 1231884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetIdentifier(int nameID, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&nameID);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(CubemapFace**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubeFace;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_CubemapFace_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 1231885, RefRangeEnd = 1231907, XrefRangeStart = 1231885, XrefRangeEnd = 1231885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetIdentifier(RenderTargetIdentifier renderTargetIdentifier, int mipLevel, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&renderTargetIdentifier);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(CubemapFace**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubeFace;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 1231920, RefRangeEnd = 1231930, XrefRangeStart = 1231907, XrefRangeEnd = 1231920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetIdentifier(Texture tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Texture_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1231930, RefRangeEnd = 1231931, XrefRangeStart = 1231930, XrefRangeEnd = 1231930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RenderTargetIdentifier(RenderBuffer buf, int mipLevel = 0, CubemapFace cubeFace = CubemapFace.Unknown, int depthSlice = 0)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&buf);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipLevel;
		*(CubemapFace**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cubeFace;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &depthSlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RenderBuffer_Int32_CubemapFace_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(29)]
	[CachedScanResults(RefRangeStart = 1231931, RefRangeEnd = 1231960, XrefRangeStart = 1231931, XrefRangeEnd = 1231931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1231961, RefRangeEnd = 1231962, XrefRangeStart = 1231960, XrefRangeEnd = 1231961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator RenderTargetIdentifier(string name)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1231962, RefRangeEnd = 1231973, XrefRangeStart = 1231962, XrefRangeEnd = 1231962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator RenderTargetIdentifier(int nameID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&nameID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(114)]
	[CachedScanResults(RefRangeStart = 1231986, RefRangeEnd = 1232100, XrefRangeStart = 1231973, XrefRangeEnd = 1231986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator RenderTargetIdentifier(Texture tex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tex);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232100, XrefRangeEnd = 1232136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1232139, RefRangeEnd = 1232142, XrefRangeStart = 1232136, XrefRangeEnd = 1232139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 1232142, RefRangeEnd = 1232167, XrefRangeStart = 1232142, XrefRangeEnd = 1232142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(RenderTargetIdentifier rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rhs);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1232167, XrefRangeEnd = 1232170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 1232142, RefRangeEnd = 1232167, XrefRangeStart = 1232142, XrefRangeEnd = 1232167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(24)]
	[CachedScanResults(RefRangeStart = 1232170, RefRangeEnd = 1232194, XrefRangeStart = 1232170, XrefRangeEnd = 1232170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(RenderTargetIdentifier**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static implicit operator RenderTargetIdentifier(RenderBuffer buf)
	{
		return new RenderTargetIdentifier(buf);
	}
}
