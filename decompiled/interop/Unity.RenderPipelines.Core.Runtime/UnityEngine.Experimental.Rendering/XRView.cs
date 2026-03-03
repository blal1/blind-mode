using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.Rendering;

public sealed class XRView : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_projMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_prevViewMatrix;

	private static readonly System.IntPtr NativeFieldInfoPtr_viewport;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionMesh;

	private static readonly System.IntPtr NativeFieldInfoPtr_textureArraySlice;

	private static readonly System.IntPtr NativeFieldInfoPtr_eyeCenterUV;

	private static readonly System.IntPtr NativeFieldInfoPtr_isPrevViewMatrixValid;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_Rect_Mesh_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ComputeEyeCenterUV_Private_Static_Vector2_Matrix4x4_0;

	public unsafe Matrix4x4 projMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projMatrix);
			return *(Matrix4x4*)num;
		}
		set
		{
			*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projMatrix)) = value;
		}
	}

	public unsafe Matrix4x4 viewMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewMatrix);
			return *(Matrix4x4*)num;
		}
		set
		{
			*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewMatrix)) = value;
		}
	}

	public unsafe Matrix4x4 prevViewMatrix
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevViewMatrix);
			return *(Matrix4x4*)num;
		}
		set
		{
			*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_prevViewMatrix)) = value;
		}
	}

	public unsafe Rect viewport
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewport);
			return *(Rect*)num;
		}
		set
		{
			*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_viewport)) = value;
		}
	}

	public unsafe Mesh occlusionMesh
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionMesh);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Mesh>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionMesh)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int textureArraySlice
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureArraySlice);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_textureArraySlice)) = value;
		}
	}

	public unsafe Vector2 eyeCenterUV
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyeCenterUV);
			return *(Vector2*)num;
		}
		set
		{
			*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_eyeCenterUV)) = value;
		}
	}

	public unsafe bool isPrevViewMatrixValid
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPrevViewMatrixValid);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPrevViewMatrixValid)) = value;
		}
	}

	static XRView()
	{
		Il2CppClassPointerStore<XRView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRView>.NativeClassPtr);
		NativeFieldInfoPtr_projMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "projMatrix");
		NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "viewMatrix");
		NativeFieldInfoPtr_prevViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "prevViewMatrix");
		NativeFieldInfoPtr_viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "viewport");
		NativeFieldInfoPtr_occlusionMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "occlusionMesh");
		NativeFieldInfoPtr_textureArraySlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "textureArraySlice");
		NativeFieldInfoPtr_eyeCenterUV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "eyeCenterUV");
		NativeFieldInfoPtr_isPrevViewMatrixValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRView>.NativeClassPtr, "isPrevViewMatrixValid");
		NativeMethodInfoPtr__ctor_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_Rect_Mesh_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRView>.NativeClassPtr, 100663453);
		NativeMethodInfoPtr_ComputeEyeCenterUV_Private_Static_Vector2_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRView>.NativeClassPtr, 100663454);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1026281, RefRangeEnd = 1026283, XrefRangeStart = 1026276, XrefRangeEnd = 1026281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRView(Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Matrix4x4 prevViewMatrix, bool isPrevViewMatrixValid, Rect viewport, Mesh occlusionMesh, int textureArraySlice)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRView>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&projMatrix);
		*(Matrix4x4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewMatrix;
		*(Matrix4x4**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &prevViewMatrix;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &isPrevViewMatrixValid;
		*(Rect**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewport;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)occlusionMesh);
		*(int**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureArraySlice;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Matrix4x4_Matrix4x4_Matrix4x4_Boolean_Rect_Mesh_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026283, XrefRangeEnd = 1026287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 ComputeEyeCenterUV(Matrix4x4 proj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&proj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ComputeEyeCenterUV_Private_Static_Vector2_Matrix4x4_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public XRView(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public XRView()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRView>.NativeClassPtr))
	{
	}
}
