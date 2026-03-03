using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine.XR;

public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[OriginalName("UnityEngine.XRModule.dll", "", "TextureLayout")]
	[System.Flags]
	public enum TextureLayout
	{
		Texture2DArray = 1,
		SingleTexture2D = 2,
		SeparateTexture2Ds = 4
	}

	public sealed class XRRenderParameter : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_view;

		private static readonly System.IntPtr NativeFieldInfoPtr_projection;

		private static readonly System.IntPtr NativeFieldInfoPtr_viewport;

		private static readonly System.IntPtr NativeFieldInfoPtr_occlusionMesh;

		private static readonly System.IntPtr NativeFieldInfoPtr_textureArraySlice;

		private static readonly System.IntPtr NativeFieldInfoPtr_previousView;

		private static readonly System.IntPtr NativeFieldInfoPtr_isPreviousViewValid;

		public unsafe Matrix4x4 view
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_view);
				return *(Matrix4x4*)num;
			}
			set
			{
				*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_view)) = value;
			}
		}

		public unsafe Matrix4x4 projection
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projection);
				return *(Matrix4x4*)num;
			}
			set
			{
				*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_projection)) = value;
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

		public unsafe Matrix4x4 previousView
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousView);
				return *(Matrix4x4*)num;
			}
			set
			{
				*(Matrix4x4*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_previousView)) = value;
			}
		}

		public unsafe bool isPreviousViewValid
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPreviousViewValid);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_isPreviousViewValid)) = value;
			}
		}

		static XRRenderParameter()
		{
			Il2CppClassPointerStore<XRRenderParameter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "XRRenderParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRRenderParameter>.NativeClassPtr);
			NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderParameter>.NativeClassPtr, "view");
			NativeFieldInfoPtr_projection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderParameter>.NativeClassPtr, "projection");
			NativeFieldInfoPtr_viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderParameter>.NativeClassPtr, "viewport");
			NativeFieldInfoPtr_occlusionMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderParameter>.NativeClassPtr, "occlusionMesh");
			NativeFieldInfoPtr_textureArraySlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderParameter>.NativeClassPtr, "textureArraySlice");
			NativeFieldInfoPtr_previousView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderParameter>.NativeClassPtr, "previousView");
			NativeFieldInfoPtr_isPreviousViewValid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderParameter>.NativeClassPtr, "isPreviousViewValid");
		}

		public XRRenderParameter(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public XRRenderParameter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRRenderParameter>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct XRRenderPass
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_displaySubsystemInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_renderPassIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_renderTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr_renderTargetDesc;

		private static readonly System.IntPtr NativeFieldInfoPtr_hasMotionVectorPass;

		private static readonly System.IntPtr NativeFieldInfoPtr_motionVectorRenderTarget;

		private static readonly System.IntPtr NativeFieldInfoPtr_motionVectorRenderTargetDesc;

		private static readonly System.IntPtr NativeFieldInfoPtr_shouldFillOutDepth;

		private static readonly System.IntPtr NativeFieldInfoPtr_spaceWarpRightHandedNDC;

		private static readonly System.IntPtr NativeFieldInfoPtr_cullingPassIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_foveatedRenderingInfo;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderParameter_Public_Void_Camera_Int32_byref_XRRenderParameter_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderParameterCount_Public_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderParameter_Injected_Private_Static_Void_byref_XRRenderPass_IntPtr_Int32_byref_XRRenderParameter_0;

		[FieldOffset(0)]
		public System.IntPtr displaySubsystemInstance;

		[FieldOffset(8)]
		public int renderPassIndex;

		[FieldOffset(16)]
		public RenderTargetIdentifier renderTarget;

		[FieldOffset(56)]
		public RenderTextureDescriptor renderTargetDesc;

		[FieldOffset(108)]
		[MarshalAs(UnmanagedType.U1)]
		public bool hasMotionVectorPass;

		[FieldOffset(112)]
		public RenderTargetIdentifier motionVectorRenderTarget;

		[FieldOffset(152)]
		public RenderTextureDescriptor motionVectorRenderTargetDesc;

		[FieldOffset(204)]
		[MarshalAs(UnmanagedType.U1)]
		public bool shouldFillOutDepth;

		[FieldOffset(205)]
		[MarshalAs(UnmanagedType.U1)]
		public bool spaceWarpRightHandedNDC;

		[FieldOffset(208)]
		public int cullingPassIndex;

		[FieldOffset(216)]
		public System.IntPtr foveatedRenderingInfo;

		static XRRenderPass()
		{
			Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "XRRenderPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr);
			NativeFieldInfoPtr_displaySubsystemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "displaySubsystemInstance");
			NativeFieldInfoPtr_renderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "renderPassIndex");
			NativeFieldInfoPtr_renderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "renderTarget");
			NativeFieldInfoPtr_renderTargetDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "renderTargetDesc");
			NativeFieldInfoPtr_hasMotionVectorPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "hasMotionVectorPass");
			NativeFieldInfoPtr_motionVectorRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "motionVectorRenderTarget");
			NativeFieldInfoPtr_motionVectorRenderTargetDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "motionVectorRenderTargetDesc");
			NativeFieldInfoPtr_shouldFillOutDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "shouldFillOutDepth");
			NativeFieldInfoPtr_spaceWarpRightHandedNDC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "spaceWarpRightHandedNDC");
			NativeFieldInfoPtr_cullingPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "cullingPassIndex");
			NativeFieldInfoPtr_foveatedRenderingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, "foveatedRenderingInfo");
			NativeMethodInfoPtr_GetRenderParameter_Public_Void_Camera_Int32_byref_XRRenderParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, 100663368);
			NativeMethodInfoPtr_GetRenderParameterCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, 100663369);
			NativeMethodInfoPtr_GetRenderParameter_Injected_Private_Static_Void_byref_XRRenderPass_IntPtr_Int32_byref_XRRenderParameter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, 100663370);
		}

		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1411052, RefRangeEnd = 1411058, XrefRangeStart = 1411047, XrefRangeEnd = 1411052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRenderParameter(Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderParameterIndex;
			byte* num = (byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderParameter_Public_Void_Camera_Int32_byref_XRRenderParameter_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num3 = num2;
			renderParameter = ((num3 == 0) ? null : new XRRenderParameter(num3));
		}

		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1411060, RefRangeEnd = 1411065, XrefRangeStart = 1411058, XrefRangeEnd = 1411060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetRenderParameterCount()
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderParameterCount_Public_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411065, XrefRangeEnd = 1411067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderParameter_Injected(ref XRRenderPass _unity_self, System.IntPtr camera, int renderParameterIndex, out XRRenderParameter renderParameter)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[4];
			*ptr = (nint)Unsafe.AsPointer(ref _unity_self);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
			*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderParameterIndex;
			byte* num = (byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderParameter_Injected_Private_Static_Void_byref_XRRenderPass_IntPtr_Int32_byref_XRRenderParameter_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num3 = num2;
			renderParameter = ((num3 == 0) ? null : new XRRenderParameter(num3));
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XRRenderPass>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public sealed class XRBlitParams : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_srcTex;

		private static readonly System.IntPtr NativeFieldInfoPtr_srcTexArraySlice;

		private static readonly System.IntPtr NativeFieldInfoPtr_srcRect;

		private static readonly System.IntPtr NativeFieldInfoPtr_destRect;

		private static readonly System.IntPtr NativeFieldInfoPtr_foveatedRenderingInfo;

		private static readonly System.IntPtr NativeFieldInfoPtr_srcHdrEncoded;

		private static readonly System.IntPtr NativeFieldInfoPtr_srcHdrColorGamut;

		private static readonly System.IntPtr NativeFieldInfoPtr_srcHdrMaxLuminance;

		public unsafe RenderTexture srcTex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcTex);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcTex)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe int srcTexArraySlice
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcTexArraySlice);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcTexArraySlice)) = value;
			}
		}

		public unsafe Rect srcRect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcRect);
				return *(Rect*)num;
			}
			set
			{
				*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcRect)) = value;
			}
		}

		public unsafe Rect destRect
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destRect);
				return *(Rect*)num;
			}
			set
			{
				*(Rect*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_destRect)) = value;
			}
		}

		public unsafe System.IntPtr foveatedRenderingInfo
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foveatedRenderingInfo);
				return *(System.IntPtr*)num;
			}
			set
			{
				*(System.IntPtr*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_foveatedRenderingInfo)) = value;
			}
		}

		public unsafe bool srcHdrEncoded
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcHdrEncoded);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcHdrEncoded)) = value;
			}
		}

		public unsafe ColorGamut srcHdrColorGamut
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcHdrColorGamut);
				return *(ColorGamut*)num;
			}
			set
			{
				*(ColorGamut*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcHdrColorGamut)) = value;
			}
		}

		public unsafe int srcHdrMaxLuminance
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcHdrMaxLuminance);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_srcHdrMaxLuminance)) = value;
			}
		}

		static XRBlitParams()
		{
			Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "XRBlitParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr);
			NativeFieldInfoPtr_srcTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr, "srcTex");
			NativeFieldInfoPtr_srcTexArraySlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr, "srcTexArraySlice");
			NativeFieldInfoPtr_srcRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr, "srcRect");
			NativeFieldInfoPtr_destRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr, "destRect");
			NativeFieldInfoPtr_foveatedRenderingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr, "foveatedRenderingInfo");
			NativeFieldInfoPtr_srcHdrEncoded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr, "srcHdrEncoded");
			NativeFieldInfoPtr_srcHdrColorGamut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr, "srcHdrColorGamut");
			NativeFieldInfoPtr_srcHdrMaxLuminance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr, "srcHdrMaxLuminance");
		}

		public XRBlitParams(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public XRBlitParams()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRBlitParams>.NativeClassPtr))
		{
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct XRMirrorViewBlitDesc
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_displaySubsystemInstance;

		private static readonly System.IntPtr NativeFieldInfoPtr_nativeBlitAvailable;

		private static readonly System.IntPtr NativeFieldInfoPtr_nativeBlitInvalidStates;

		private static readonly System.IntPtr NativeFieldInfoPtr_blitParamsCount;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetBlitParameter_Public_Void_Int32_byref_XRBlitParams_0;

		[FieldOffset(0)]
		public System.IntPtr displaySubsystemInstance;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.U1)]
		public bool nativeBlitAvailable;

		[FieldOffset(9)]
		[MarshalAs(UnmanagedType.U1)]
		public bool nativeBlitInvalidStates;

		[FieldOffset(12)]
		public int blitParamsCount;

		static XRMirrorViewBlitDesc()
		{
			Il2CppClassPointerStore<XRMirrorViewBlitDesc>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "XRMirrorViewBlitDesc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRMirrorViewBlitDesc>.NativeClassPtr);
			NativeFieldInfoPtr_displaySubsystemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorViewBlitDesc>.NativeClassPtr, "displaySubsystemInstance");
			NativeFieldInfoPtr_nativeBlitAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorViewBlitDesc>.NativeClassPtr, "nativeBlitAvailable");
			NativeFieldInfoPtr_nativeBlitInvalidStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorViewBlitDesc>.NativeClassPtr, "nativeBlitInvalidStates");
			NativeFieldInfoPtr_blitParamsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRMirrorViewBlitDesc>.NativeClassPtr, "blitParamsCount");
			NativeMethodInfoPtr_GetBlitParameter_Public_Void_Int32_byref_XRBlitParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRMirrorViewBlitDesc>.NativeClassPtr, 100663371);
		}

		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411069, RefRangeEnd = 1411070, XrefRangeStart = 1411067, XrefRangeEnd = 1411069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBlitParameter(int blitParameterIndex, out XRBlitParams blitParameter)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&blitParameterIndex);
			byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
			nint num2 = 0;
			*(nint**)num = &num2;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetBlitParameter_Public_Void_Int32_byref_XRBlitParams_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			nint num3 = num2;
			blitParameter = ((num3 == 0) ? null : new XRBlitParams(num3));
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XRMirrorViewBlitDesc>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public new static class BindingsMarshaller : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_XRDisplaySubsystem_0;

		static BindingsMarshaller()
		{
			Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "BindingsMarshaller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr);
			NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_XRDisplaySubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindingsMarshaller>.NativeClassPtr, 100663372);
		}

		[CallerCount(0)]
		public unsafe static System.IntPtr ConvertToNative(XRDisplaySubsystem xrDisplaySubsystem)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)xrDisplaySubsystem);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_XRDisplaySubsystem_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BindingsMarshaller(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public enum FoveatedRenderingFlags
	{
		None,
		GazeAllowed
	}

	public enum LateLatchNode
	{
		Head,
		LeftHand,
		RightHand
	}

	public enum ReprojectionMode
	{
		Unspecified,
		PositionAndOrientation,
		OrientationOnly,
		None
	}

	private delegate bool get_displayOpaque_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_contentProtectionEnabled_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_contentProtectionEnabled_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void set_scaleOfAllViewports_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_scaleOfAllRenderTargets_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_zNear_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_zFar_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool get_sRGB_InjectedDelegate(System.IntPtr _unity_self);

	private delegate float get_occlusionMaskScale_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_occlusionMaskScale_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_foveatedRenderingLevel_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_foveatedRenderingLevel_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate FoveatedRenderingFlags get_foveatedRenderingFlags_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_foveatedRenderingFlags_InjectedDelegate(System.IntPtr _unity_self, FoveatedRenderingFlags value);

	private delegate void MarkTransformLateLatched_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr transform, LateLatchNode nodeType);

	private delegate TextureLayout get_textureLayout_InjectedDelegate(System.IntPtr _unity_self);

	private delegate TextureLayout get_supportedTextureLayouts_InjectedDelegate(System.IntPtr _unity_self);

	private delegate ReprojectionMode get_reprojectionMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_reprojectionMode_InjectedDelegate(System.IntPtr _unity_self, ReprojectionMode value);

	private delegate void SetFocusPlane_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr point, [In] System.IntPtr normal, [In] System.IntPtr velocity);

	private delegate bool get_disableLegacyRenderer_InjectedDelegate(System.IntPtr _unity_self);

	private delegate bool TryGetAppGPUTimeLastFrame_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr gpuTimeLastFrame);

	private delegate bool TryGetCompositorGPUTimeLastFrame_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr gpuTimeLastFrameCompositor);

	private delegate bool TryGetDroppedFrameCount_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr droppedFrameCount);

	private delegate bool TryGetFramePresentCount_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr framePresentCount);

	private delegate bool TryGetDisplayRefreshRate_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr displayRefreshRate);

	private delegate bool TryGetMotionToPhoton_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr motionToPhoton);

	private delegate System.IntPtr GetRenderTexture_InjectedDelegate(System.IntPtr _unity_self, uint unityXrRenderTextureId);

	private delegate System.IntPtr GetRenderTextureForRenderPass_InjectedDelegate(System.IntPtr _unity_self, int renderPass);

	private delegate System.IntPtr GetSharedDepthTextureForRenderPass_InjectedDelegate(System.IntPtr _unity_self, int renderPass);

	private static readonly System.IntPtr NativeFieldInfoPtr_displayFocusChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HDROutputSettings;

	private static readonly System.IntPtr NativeMethodInfoPtr_InvokeDisplayFocusChanged_Private_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scaleOfAllViewports_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scaleOfAllRenderTargets_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_zNear_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_zFar_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_textureLayout_Public_set_Void_TextureLayout_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMSAALevel_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_disableLegacyRenderer_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderPassCount_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderPass_Public_Void_Int32_byref_XRRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryGetRenderPass_Private_Boolean_Int32_byref_XRRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EndRecordingIfLateLatched_Public_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryEndRecordingIfLateLatched_Private_Boolean_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_BeginRecordingIfLateLatched_Public_Void_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryBeginRecordingIfLateLatched_Private_Boolean_Camera_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCullingParameters_Public_Void_Camera_Int32_byref_ScriptableCullingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryGetCullingParams_Private_Boolean_Camera_Int32_byref_ScriptableCullingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreferredMirrorBlitMode_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPreferredMirrorBlitMode_Public_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMirrorViewBlitDesc_Public_Boolean_RenderTexture_byref_XRMirrorViewBlitDesc_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGraphicsThreadMirrorViewBlit_Public_Boolean_CommandBuffer_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hdrOutputSettings_Public_get_HDROutputSettings_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_scaleOfAllViewports_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_scaleOfAllRenderTargets_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_zNear_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_zFar_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_sRGB_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_textureLayout_Injected_Private_Static_Void_IntPtr_TextureLayout_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetMSAALevel_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_disableLegacyRenderer_Injected_Private_Static_Void_IntPtr_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderPassCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryGetRenderPass_Injected_Private_Static_Boolean_IntPtr_Int32_byref_XRRenderPass_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryEndRecordingIfLateLatched_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryBeginRecordingIfLateLatched_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_TryGetCullingParams_Injected_Private_Static_Boolean_IntPtr_IntPtr_Int32_byref_ScriptableCullingParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPreferredMirrorBlitMode_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPreferredMirrorBlitMode_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMirrorViewBlitDesc_Injected_Private_Static_Boolean_IntPtr_IntPtr_byref_XRMirrorViewBlitDesc_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddGraphicsThreadMirrorViewBlit_Injected_Private_Static_Boolean_IntPtr_IntPtr_Boolean_Int32_0;

	private static readonly get_displayOpaque_InjectedDelegate get_displayOpaque_InjectedDelegateField;

	private static readonly get_contentProtectionEnabled_InjectedDelegate get_contentProtectionEnabled_InjectedDelegateField;

	private static readonly set_contentProtectionEnabled_InjectedDelegate set_contentProtectionEnabled_InjectedDelegateField;

	private static readonly set_scaleOfAllViewports_InjectedDelegate set_scaleOfAllViewports_InjectedDelegateField;

	private static readonly get_scaleOfAllRenderTargets_InjectedDelegate get_scaleOfAllRenderTargets_InjectedDelegateField;

	private static readonly get_zNear_InjectedDelegate get_zNear_InjectedDelegateField;

	private static readonly get_zFar_InjectedDelegate get_zFar_InjectedDelegateField;

	private static readonly get_sRGB_InjectedDelegate get_sRGB_InjectedDelegateField;

	private static readonly get_occlusionMaskScale_InjectedDelegate get_occlusionMaskScale_InjectedDelegateField;

	private static readonly set_occlusionMaskScale_InjectedDelegate set_occlusionMaskScale_InjectedDelegateField;

	private static readonly get_foveatedRenderingLevel_InjectedDelegate get_foveatedRenderingLevel_InjectedDelegateField;

	private static readonly set_foveatedRenderingLevel_InjectedDelegate set_foveatedRenderingLevel_InjectedDelegateField;

	private static readonly get_foveatedRenderingFlags_InjectedDelegate get_foveatedRenderingFlags_InjectedDelegateField;

	private static readonly set_foveatedRenderingFlags_InjectedDelegate set_foveatedRenderingFlags_InjectedDelegateField;

	private static readonly MarkTransformLateLatched_InjectedDelegate MarkTransformLateLatched_InjectedDelegateField;

	private static readonly get_textureLayout_InjectedDelegate get_textureLayout_InjectedDelegateField;

	private static readonly get_supportedTextureLayouts_InjectedDelegate get_supportedTextureLayouts_InjectedDelegateField;

	private static readonly get_reprojectionMode_InjectedDelegate get_reprojectionMode_InjectedDelegateField;

	private static readonly set_reprojectionMode_InjectedDelegate set_reprojectionMode_InjectedDelegateField;

	private static readonly SetFocusPlane_InjectedDelegate SetFocusPlane_InjectedDelegateField;

	private static readonly get_disableLegacyRenderer_InjectedDelegate get_disableLegacyRenderer_InjectedDelegateField;

	private static readonly TryGetAppGPUTimeLastFrame_InjectedDelegate TryGetAppGPUTimeLastFrame_InjectedDelegateField;

	private static readonly TryGetCompositorGPUTimeLastFrame_InjectedDelegate TryGetCompositorGPUTimeLastFrame_InjectedDelegateField;

	private static readonly TryGetDroppedFrameCount_InjectedDelegate TryGetDroppedFrameCount_InjectedDelegateField;

	private static readonly TryGetFramePresentCount_InjectedDelegate TryGetFramePresentCount_InjectedDelegateField;

	private static readonly TryGetDisplayRefreshRate_InjectedDelegate TryGetDisplayRefreshRate_InjectedDelegateField;

	private static readonly TryGetMotionToPhoton_InjectedDelegate TryGetMotionToPhoton_InjectedDelegateField;

	private static readonly GetRenderTexture_InjectedDelegate GetRenderTexture_InjectedDelegateField;

	private static readonly GetRenderTextureForRenderPass_InjectedDelegate GetRenderTextureForRenderPass_InjectedDelegateField;

	private static readonly GetSharedDepthTextureForRenderPass_InjectedDelegate GetSharedDepthTextureForRenderPass_InjectedDelegateField;

	public unsafe Il2CppSystem.Action<bool> displayFocusChanged
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayFocusChanged);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<bool>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_displayFocusChanged)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe HDROutputSettings m_HDROutputSettings
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HDROutputSettings);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<HDROutputSettings>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HDROutputSettings)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float scaleOfAllViewports
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411074, RefRangeEnd = 1411075, XrefRangeStart = 1411070, XrefRangeEnd = 1411074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaleOfAllViewports_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_scaleOfAllViewports_Injected(intPtr, value);
		}
	}

	public unsafe float scaleOfAllRenderTargets
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_scaleOfAllRenderTargets_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411079, RefRangeEnd = 1411080, XrefRangeStart = 1411075, XrefRangeEnd = 1411079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scaleOfAllRenderTargets_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float zNear
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_zNear_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411084, RefRangeEnd = 1411085, XrefRangeStart = 1411080, XrefRangeEnd = 1411084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_zNear_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float zFar
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_zFar_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411089, RefRangeEnd = 1411090, XrefRangeStart = 1411085, XrefRangeEnd = 1411089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_zFar_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool sRGB
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_sRGB_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411094, RefRangeEnd = 1411095, XrefRangeStart = 1411090, XrefRangeEnd = 1411094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe TextureLayout textureLayout
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_textureLayout_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411099, RefRangeEnd = 1411100, XrefRangeStart = 1411095, XrefRangeEnd = 1411099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_textureLayout_Public_set_Void_TextureLayout_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool disableLegacyRenderer
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_disableLegacyRenderer_Injected(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1411109, RefRangeEnd = 1411110, XrefRangeStart = 1411105, XrefRangeEnd = 1411109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disableLegacyRenderer_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe HDROutputSettings hdrOutputSettings
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1411208, RefRangeEnd = 1411215, XrefRangeStart = 1411203, XrefRangeEnd = 1411208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hdrOutputSettings_Public_get_HDROutputSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<HDROutputSettings>(intPtr2) : null;
		}
	}

	public bool singlePassRenderingDisabled
	{
		get
		{
			return (textureLayout & TextureLayout.Texture2DArray) == 0;
		}
		set
		{
			if (value)
			{
				textureLayout = TextureLayout.SeparateTexture2Ds;
			}
			else if ((supportedTextureLayouts & TextureLayout.Texture2DArray) > (TextureLayout)0)
			{
				textureLayout = TextureLayout.Texture2DArray;
			}
		}
	}

	public bool displayOpaque
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_displayOpaque_Injected(intPtr);
		}
	}

	public bool contentProtectionEnabled
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_contentProtectionEnabled_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_contentProtectionEnabled_Injected(intPtr, value);
		}
	}

	public float occlusionMaskScale
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_occlusionMaskScale_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_occlusionMaskScale_Injected(intPtr, value);
		}
	}

	public float foveatedRenderingLevel
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_foveatedRenderingLevel_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_foveatedRenderingLevel_Injected(intPtr, value);
		}
	}

	public FoveatedRenderingFlags foveatedRenderingFlags
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_foveatedRenderingFlags_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_foveatedRenderingFlags_Injected(intPtr, value);
		}
	}

	public TextureLayout supportedTextureLayouts
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_supportedTextureLayouts_Injected(intPtr);
		}
	}

	public ReprojectionMode reprojectionMode
	{
		get
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_reprojectionMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_reprojectionMode_Injected(intPtr, value);
		}
	}

	static XRDisplaySubsystem()
	{
		Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRDisplaySubsystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr);
		NativeFieldInfoPtr_displayFocusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "displayFocusChanged");
		NativeFieldInfoPtr_m_HDROutputSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, "m_HDROutputSettings");
		NativeMethodInfoPtr_InvokeDisplayFocusChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663327);
		NativeMethodInfoPtr_get_scaleOfAllViewports_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663328);
		NativeMethodInfoPtr_set_scaleOfAllRenderTargets_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663329);
		NativeMethodInfoPtr_set_zNear_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663330);
		NativeMethodInfoPtr_set_zFar_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663331);
		NativeMethodInfoPtr_set_sRGB_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_set_textureLayout_Public_set_Void_TextureLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_SetMSAALevel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr_set_disableLegacyRenderer_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr_GetRenderPassCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr_GetRenderPass_Public_Void_Int32_byref_XRRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr_Internal_TryGetRenderPass_Private_Boolean_Int32_byref_XRRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663338);
		NativeMethodInfoPtr_EndRecordingIfLateLatched_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663339);
		NativeMethodInfoPtr_Internal_TryEndRecordingIfLateLatched_Private_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663340);
		NativeMethodInfoPtr_BeginRecordingIfLateLatched_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663341);
		NativeMethodInfoPtr_Internal_TryBeginRecordingIfLateLatched_Private_Boolean_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663342);
		NativeMethodInfoPtr_GetCullingParameters_Public_Void_Camera_Int32_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663343);
		NativeMethodInfoPtr_Internal_TryGetCullingParams_Private_Boolean_Camera_Int32_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663344);
		NativeMethodInfoPtr_GetPreferredMirrorBlitMode_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663345);
		NativeMethodInfoPtr_SetPreferredMirrorBlitMode_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663346);
		NativeMethodInfoPtr_GetMirrorViewBlitDesc_Public_Boolean_RenderTexture_byref_XRMirrorViewBlitDesc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663347);
		NativeMethodInfoPtr_AddGraphicsThreadMirrorViewBlit_Public_Boolean_CommandBuffer_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663348);
		NativeMethodInfoPtr_get_hdrOutputSettings_Public_get_HDROutputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663349);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663350);
		NativeMethodInfoPtr_get_scaleOfAllViewports_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663351);
		NativeMethodInfoPtr_set_scaleOfAllRenderTargets_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663352);
		NativeMethodInfoPtr_set_zNear_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663353);
		NativeMethodInfoPtr_set_zFar_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663354);
		NativeMethodInfoPtr_set_sRGB_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663355);
		NativeMethodInfoPtr_set_textureLayout_Injected_Private_Static_Void_IntPtr_TextureLayout_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663356);
		NativeMethodInfoPtr_SetMSAALevel_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663357);
		NativeMethodInfoPtr_set_disableLegacyRenderer_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663358);
		NativeMethodInfoPtr_GetRenderPassCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663359);
		NativeMethodInfoPtr_Internal_TryGetRenderPass_Injected_Private_Static_Boolean_IntPtr_Int32_byref_XRRenderPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663360);
		NativeMethodInfoPtr_Internal_TryEndRecordingIfLateLatched_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663361);
		NativeMethodInfoPtr_Internal_TryBeginRecordingIfLateLatched_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663362);
		NativeMethodInfoPtr_Internal_TryGetCullingParams_Injected_Private_Static_Boolean_IntPtr_IntPtr_Int32_byref_ScriptableCullingParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663363);
		NativeMethodInfoPtr_GetPreferredMirrorBlitMode_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663364);
		NativeMethodInfoPtr_SetPreferredMirrorBlitMode_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_GetMirrorViewBlitDesc_Injected_Private_Static_Boolean_IntPtr_IntPtr_byref_XRMirrorViewBlitDesc_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_AddGraphicsThreadMirrorViewBlit_Injected_Private_Static_Boolean_IntPtr_IntPtr_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr, 100663367);
		get_displayOpaque_InjectedDelegateField = IL2CPP.ResolveICall<get_displayOpaque_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_displayOpaque_Injected");
		get_contentProtectionEnabled_InjectedDelegateField = IL2CPP.ResolveICall<get_contentProtectionEnabled_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_contentProtectionEnabled_Injected");
		set_contentProtectionEnabled_InjectedDelegateField = IL2CPP.ResolveICall<set_contentProtectionEnabled_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_contentProtectionEnabled_Injected");
		set_scaleOfAllViewports_InjectedDelegateField = IL2CPP.ResolveICall<set_scaleOfAllViewports_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_scaleOfAllViewports_Injected");
		get_scaleOfAllRenderTargets_InjectedDelegateField = IL2CPP.ResolveICall<get_scaleOfAllRenderTargets_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_scaleOfAllRenderTargets_Injected");
		get_zNear_InjectedDelegateField = IL2CPP.ResolveICall<get_zNear_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_zNear_Injected");
		get_zFar_InjectedDelegateField = IL2CPP.ResolveICall<get_zFar_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_zFar_Injected");
		get_sRGB_InjectedDelegateField = IL2CPP.ResolveICall<get_sRGB_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_sRGB_Injected");
		get_occlusionMaskScale_InjectedDelegateField = IL2CPP.ResolveICall<get_occlusionMaskScale_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_occlusionMaskScale_Injected");
		set_occlusionMaskScale_InjectedDelegateField = IL2CPP.ResolveICall<set_occlusionMaskScale_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_occlusionMaskScale_Injected");
		get_foveatedRenderingLevel_InjectedDelegateField = IL2CPP.ResolveICall<get_foveatedRenderingLevel_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_foveatedRenderingLevel_Injected");
		set_foveatedRenderingLevel_InjectedDelegateField = IL2CPP.ResolveICall<set_foveatedRenderingLevel_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_foveatedRenderingLevel_Injected");
		get_foveatedRenderingFlags_InjectedDelegateField = IL2CPP.ResolveICall<get_foveatedRenderingFlags_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_foveatedRenderingFlags_Injected");
		set_foveatedRenderingFlags_InjectedDelegateField = IL2CPP.ResolveICall<set_foveatedRenderingFlags_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_foveatedRenderingFlags_Injected");
		MarkTransformLateLatched_InjectedDelegateField = IL2CPP.ResolveICall<MarkTransformLateLatched_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::MarkTransformLateLatched_Injected");
		get_textureLayout_InjectedDelegateField = IL2CPP.ResolveICall<get_textureLayout_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_textureLayout_Injected");
		get_supportedTextureLayouts_InjectedDelegateField = IL2CPP.ResolveICall<get_supportedTextureLayouts_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_supportedTextureLayouts_Injected");
		get_reprojectionMode_InjectedDelegateField = IL2CPP.ResolveICall<get_reprojectionMode_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_reprojectionMode_Injected");
		set_reprojectionMode_InjectedDelegateField = IL2CPP.ResolveICall<set_reprojectionMode_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::set_reprojectionMode_Injected");
		SetFocusPlane_InjectedDelegateField = IL2CPP.ResolveICall<SetFocusPlane_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::SetFocusPlane_Injected");
		get_disableLegacyRenderer_InjectedDelegateField = IL2CPP.ResolveICall<get_disableLegacyRenderer_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::get_disableLegacyRenderer_Injected");
		TryGetAppGPUTimeLastFrame_InjectedDelegateField = IL2CPP.ResolveICall<TryGetAppGPUTimeLastFrame_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetAppGPUTimeLastFrame_Injected");
		TryGetCompositorGPUTimeLastFrame_InjectedDelegateField = IL2CPP.ResolveICall<TryGetCompositorGPUTimeLastFrame_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetCompositorGPUTimeLastFrame_Injected");
		TryGetDroppedFrameCount_InjectedDelegateField = IL2CPP.ResolveICall<TryGetDroppedFrameCount_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetDroppedFrameCount_Injected");
		TryGetFramePresentCount_InjectedDelegateField = IL2CPP.ResolveICall<TryGetFramePresentCount_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetFramePresentCount_Injected");
		TryGetDisplayRefreshRate_InjectedDelegateField = IL2CPP.ResolveICall<TryGetDisplayRefreshRate_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetDisplayRefreshRate_Injected");
		TryGetMotionToPhoton_InjectedDelegateField = IL2CPP.ResolveICall<TryGetMotionToPhoton_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::TryGetMotionToPhoton_Injected");
		GetRenderTexture_InjectedDelegateField = IL2CPP.ResolveICall<GetRenderTexture_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::GetRenderTexture_Injected");
		GetRenderTextureForRenderPass_InjectedDelegateField = IL2CPP.ResolveICall<GetRenderTextureForRenderPass_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::GetRenderTextureForRenderPass_Injected");
		GetSharedDepthTextureForRenderPass_InjectedDelegateField = IL2CPP.ResolveICall<GetSharedDepthTextureForRenderPass_InjectedDelegate>("UnityEngine.XR.XRDisplaySubsystem::GetSharedDepthTextureForRenderPass_Injected");
	}

	[CallerCount(0)]
	public unsafe void InvokeDisplayFocusChanged(bool focus)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&focus);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InvokeDisplayFocusChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1411104, RefRangeEnd = 1411105, XrefRangeStart = 1411100, XrefRangeEnd = 1411104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMSAALevel(int level)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMSAALevel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1411114, RefRangeEnd = 1411115, XrefRangeStart = 1411110, XrefRangeEnd = 1411114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRenderPassCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderPassCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1411118, RefRangeEnd = 1411120, XrefRangeStart = 1411115, XrefRangeEnd = 1411118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetRenderPass(int renderPassIndex, out XRRenderPass renderPass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&renderPassIndex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderPass_Public_Void_Int32_byref_XRRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411120, XrefRangeEnd = 1411124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Internal_TryGetRenderPass(int renderPassIndex, out XRRenderPass renderPass)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&renderPassIndex);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_TryGetRenderPass_Private_Boolean_Int32_byref_XRRenderPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1411134, RefRangeEnd = 1411135, XrefRangeStart = 1411124, XrefRangeEnd = 1411134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndRecordingIfLateLatched(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EndRecordingIfLateLatched_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411135, XrefRangeEnd = 1411142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Internal_TryEndRecordingIfLateLatched(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_TryEndRecordingIfLateLatched_Private_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1411152, RefRangeEnd = 1411153, XrefRangeStart = 1411142, XrefRangeEnd = 1411152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginRecordingIfLateLatched(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_BeginRecordingIfLateLatched_Public_Void_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411153, XrefRangeEnd = 1411160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Internal_TryBeginRecordingIfLateLatched(Camera camera)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_TryBeginRecordingIfLateLatched_Private_Boolean_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1411170, RefRangeEnd = 1411172, XrefRangeStart = 1411160, XrefRangeEnd = 1411170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cullingPassIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scriptableCullingParameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCullingParameters_Public_Void_Camera_Int32_byref_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411172, XrefRangeEnd = 1411179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Internal_TryGetCullingParams(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)camera);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cullingPassIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scriptableCullingParameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_TryGetCullingParams_Private_Boolean_Camera_Int32_byref_ScriptableCullingParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1411183, RefRangeEnd = 1411185, XrefRangeStart = 1411179, XrefRangeEnd = 1411183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPreferredMirrorBlitMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreferredMirrorBlitMode_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1411189, RefRangeEnd = 1411190, XrefRangeStart = 1411185, XrefRangeEnd = 1411189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPreferredMirrorBlitMode(int blitMode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&blitMode);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPreferredMirrorBlitMode_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1411197, RefRangeEnd = 1411198, XrefRangeStart = 1411190, XrefRangeEnd = 1411197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mirrorRt);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outDesc);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMirrorViewBlitDesc_Public_Boolean_RenderTexture_byref_XRMirrorViewBlitDesc_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1411202, RefRangeEnd = 1411203, XrefRangeStart = 1411198, XrefRangeEnd = 1411202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowGraphicsStateInvalidate;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGraphicsThreadMirrorViewBlit_Public_Boolean_CommandBuffer_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411215, XrefRangeEnd = 1411218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRDisplaySubsystem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRDisplaySubsystem>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411218, XrefRangeEnd = 1411220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_scaleOfAllViewports_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_scaleOfAllViewports_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411220, XrefRangeEnd = 1411222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_scaleOfAllRenderTargets_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_scaleOfAllRenderTargets_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411222, XrefRangeEnd = 1411224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_zNear_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_zNear_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411224, XrefRangeEnd = 1411226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_zFar_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_zFar_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411226, XrefRangeEnd = 1411228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_sRGB_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_sRGB_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411228, XrefRangeEnd = 1411230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_textureLayout_Injected(System.IntPtr _unity_self, TextureLayout value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(TextureLayout**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_textureLayout_Injected_Private_Static_Void_IntPtr_TextureLayout_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411230, XrefRangeEnd = 1411232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMSAALevel_Injected(System.IntPtr _unity_self, int level)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &level;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetMSAALevel_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411232, XrefRangeEnd = 1411234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_disableLegacyRenderer_Injected(System.IntPtr _unity_self, bool value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_disableLegacyRenderer_Injected_Private_Static_Void_IntPtr_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411234, XrefRangeEnd = 1411236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetRenderPassCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRenderPassCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411236, XrefRangeEnd = 1411238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_TryGetRenderPass_Injected(System.IntPtr _unity_self, int renderPassIndex, out XRRenderPass renderPass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &renderPassIndex;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref renderPass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_TryGetRenderPass_Injected_Private_Static_Boolean_IntPtr_Int32_byref_XRRenderPass_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411238, XrefRangeEnd = 1411240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_TryEndRecordingIfLateLatched_Injected(System.IntPtr _unity_self, System.IntPtr camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_TryEndRecordingIfLateLatched_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411240, XrefRangeEnd = 1411242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_TryBeginRecordingIfLateLatched_Injected(System.IntPtr _unity_self, System.IntPtr camera)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_TryBeginRecordingIfLateLatched_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411242, XrefRangeEnd = 1411244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_TryGetCullingParams_Injected(System.IntPtr _unity_self, System.IntPtr camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &camera;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cullingPassIndex;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref scriptableCullingParameters);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_TryGetCullingParams_Injected_Private_Static_Boolean_IntPtr_IntPtr_Int32_byref_ScriptableCullingParameters_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411244, XrefRangeEnd = 1411246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPreferredMirrorBlitMode_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPreferredMirrorBlitMode_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411246, XrefRangeEnd = 1411248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPreferredMirrorBlitMode_Injected(System.IntPtr _unity_self, int blitMode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &blitMode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPreferredMirrorBlitMode_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411248, XrefRangeEnd = 1411250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool GetMirrorViewBlitDesc_Injected(System.IntPtr _unity_self, System.IntPtr mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &mirrorRt;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref outDesc);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMirrorViewBlitDesc_Injected_Private_Static_Boolean_IntPtr_IntPtr_byref_XRMirrorViewBlitDesc_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411250, XrefRangeEnd = 1411252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool AddGraphicsThreadMirrorViewBlit_Injected(System.IntPtr _unity_self, System.IntPtr cmd, bool allowGraphicsStateInvalidate, int mode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&_unity_self);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &cmd;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &allowGraphicsStateInvalidate;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddGraphicsThreadMirrorViewBlit_Injected_Private_Static_Boolean_IntPtr_IntPtr_Boolean_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public XRDisplaySubsystem(System.IntPtr pointer)
		: base(pointer)
	{
	}

	[SpecialName]
	public void add_displayFocusChanged(Il2CppSystem.Action<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	[SpecialName]
	public void remove_displayFocusChanged(Il2CppSystem.Action<bool> value)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void MarkTransformLateLatched(Transform transform, LateLatchNode nodeType)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		MarkTransformLateLatched_Injected(intPtr, Object.MarshalledUnityObject.Marshal(transform), nodeType);
	}

	public void SetFocusPlane(Vector3 point, Vector3 normal, Vector3 velocity)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetFocusPlane_Injected(intPtr, ref point, ref normal, ref velocity);
	}

	public bool TryGetAppGPUTimeLastFrame(out float gpuTimeLastFrame)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return TryGetAppGPUTimeLastFrame_Injected(intPtr, out gpuTimeLastFrame);
	}

	public bool TryGetCompositorGPUTimeLastFrame(out float gpuTimeLastFrameCompositor)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return TryGetCompositorGPUTimeLastFrame_Injected(intPtr, out gpuTimeLastFrameCompositor);
	}

	public bool TryGetDroppedFrameCount(out int droppedFrameCount)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return TryGetDroppedFrameCount_Injected(intPtr, out droppedFrameCount);
	}

	public bool TryGetFramePresentCount(out int framePresentCount)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return TryGetFramePresentCount_Injected(intPtr, out framePresentCount);
	}

	public bool TryGetDisplayRefreshRate(out float displayRefreshRate)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return TryGetDisplayRefreshRate_Injected(intPtr, out displayRefreshRate);
	}

	public bool TryGetMotionToPhoton(out float motionToPhoton)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return TryGetMotionToPhoton_Injected(intPtr, out motionToPhoton);
	}

	public RenderTexture GetRenderTexture(uint unityXrRenderTextureId)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<RenderTexture>(GetRenderTexture_Injected(intPtr, unityXrRenderTextureId));
	}

	public RenderTexture GetRenderTextureForRenderPass(int renderPass)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<RenderTexture>(GetRenderTextureForRenderPass_Injected(intPtr, renderPass));
	}

	public RenderTexture GetSharedDepthTextureForRenderPass(int renderPass)
	{
		System.IntPtr intPtr = BindingsMarshaller.ConvertToNative(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<RenderTexture>(GetSharedDepthTextureForRenderPass_Injected(intPtr, renderPass));
	}

	public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc)
	{
		return GetMirrorViewBlitDesc(mirrorRt, out outDesc, -1);
	}

	public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate)
	{
		return AddGraphicsThreadMirrorViewBlit(cmd, allowGraphicsStateInvalidate, -1);
	}

	public static bool get_displayOpaque_Injected(System.IntPtr _unity_self)
	{
		return get_displayOpaque_InjectedDelegateField(_unity_self);
	}

	public static bool get_contentProtectionEnabled_Injected(System.IntPtr _unity_self)
	{
		return get_contentProtectionEnabled_InjectedDelegateField(_unity_self);
	}

	public static void set_contentProtectionEnabled_Injected(System.IntPtr _unity_self, bool value)
	{
		set_contentProtectionEnabled_InjectedDelegateField(_unity_self, value);
	}

	public static void set_scaleOfAllViewports_Injected(System.IntPtr _unity_self, float value)
	{
		set_scaleOfAllViewports_InjectedDelegateField(_unity_self, value);
	}

	public static float get_scaleOfAllRenderTargets_Injected(System.IntPtr _unity_self)
	{
		return get_scaleOfAllRenderTargets_InjectedDelegateField(_unity_self);
	}

	public static float get_zNear_Injected(System.IntPtr _unity_self)
	{
		return get_zNear_InjectedDelegateField(_unity_self);
	}

	public static float get_zFar_Injected(System.IntPtr _unity_self)
	{
		return get_zFar_InjectedDelegateField(_unity_self);
	}

	public static bool get_sRGB_Injected(System.IntPtr _unity_self)
	{
		return get_sRGB_InjectedDelegateField(_unity_self);
	}

	public static float get_occlusionMaskScale_Injected(System.IntPtr _unity_self)
	{
		return get_occlusionMaskScale_InjectedDelegateField(_unity_self);
	}

	public static void set_occlusionMaskScale_Injected(System.IntPtr _unity_self, float value)
	{
		set_occlusionMaskScale_InjectedDelegateField(_unity_self, value);
	}

	public static float get_foveatedRenderingLevel_Injected(System.IntPtr _unity_self)
	{
		return get_foveatedRenderingLevel_InjectedDelegateField(_unity_self);
	}

	public static void set_foveatedRenderingLevel_Injected(System.IntPtr _unity_self, float value)
	{
		set_foveatedRenderingLevel_InjectedDelegateField(_unity_self, value);
	}

	public static FoveatedRenderingFlags get_foveatedRenderingFlags_Injected(System.IntPtr _unity_self)
	{
		return get_foveatedRenderingFlags_InjectedDelegateField(_unity_self);
	}

	public static void set_foveatedRenderingFlags_Injected(System.IntPtr _unity_self, FoveatedRenderingFlags value)
	{
		set_foveatedRenderingFlags_InjectedDelegateField(_unity_self, value);
	}

	public static void MarkTransformLateLatched_Injected(System.IntPtr _unity_self, System.IntPtr transform, LateLatchNode nodeType)
	{
		MarkTransformLateLatched_InjectedDelegateField(_unity_self, transform, nodeType);
	}

	public static TextureLayout get_textureLayout_Injected(System.IntPtr _unity_self)
	{
		return get_textureLayout_InjectedDelegateField(_unity_self);
	}

	public static TextureLayout get_supportedTextureLayouts_Injected(System.IntPtr _unity_self)
	{
		return get_supportedTextureLayouts_InjectedDelegateField(_unity_self);
	}

	public static ReprojectionMode get_reprojectionMode_Injected(System.IntPtr _unity_self)
	{
		return get_reprojectionMode_InjectedDelegateField(_unity_self);
	}

	public static void set_reprojectionMode_Injected(System.IntPtr _unity_self, ReprojectionMode value)
	{
		set_reprojectionMode_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void SetFocusPlane_Injected(System.IntPtr _unity_self, [In] ref Vector3 point, [In] ref Vector3 normal, [In] ref Vector3 velocity)
	{
		SetFocusPlane_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref point), (nint)Unsafe.AsPointer(ref normal), (nint)Unsafe.AsPointer(ref velocity));
	}

	public static bool get_disableLegacyRenderer_Injected(System.IntPtr _unity_self)
	{
		return get_disableLegacyRenderer_InjectedDelegateField(_unity_self);
	}

	public unsafe static bool TryGetAppGPUTimeLastFrame_Injected(System.IntPtr _unity_self, out float gpuTimeLastFrame)
	{
		return TryGetAppGPUTimeLastFrame_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref gpuTimeLastFrame));
	}

	public unsafe static bool TryGetCompositorGPUTimeLastFrame_Injected(System.IntPtr _unity_self, out float gpuTimeLastFrameCompositor)
	{
		return TryGetCompositorGPUTimeLastFrame_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref gpuTimeLastFrameCompositor));
	}

	public unsafe static bool TryGetDroppedFrameCount_Injected(System.IntPtr _unity_self, out int droppedFrameCount)
	{
		return TryGetDroppedFrameCount_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref droppedFrameCount));
	}

	public unsafe static bool TryGetFramePresentCount_Injected(System.IntPtr _unity_self, out int framePresentCount)
	{
		return TryGetFramePresentCount_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref framePresentCount));
	}

	public unsafe static bool TryGetDisplayRefreshRate_Injected(System.IntPtr _unity_self, out float displayRefreshRate)
	{
		return TryGetDisplayRefreshRate_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref displayRefreshRate));
	}

	public unsafe static bool TryGetMotionToPhoton_Injected(System.IntPtr _unity_self, out float motionToPhoton)
	{
		return TryGetMotionToPhoton_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref motionToPhoton));
	}

	public static System.IntPtr GetRenderTexture_Injected(System.IntPtr _unity_self, uint unityXrRenderTextureId)
	{
		return GetRenderTexture_InjectedDelegateField(_unity_self, unityXrRenderTextureId);
	}

	public static System.IntPtr GetRenderTextureForRenderPass_Injected(System.IntPtr _unity_self, int renderPass)
	{
		return GetRenderTextureForRenderPass_InjectedDelegateField(_unity_self, renderPass);
	}

	public static System.IntPtr GetSharedDepthTextureForRenderPass_Injected(System.IntPtr _unity_self, int renderPass)
	{
		return GetSharedDepthTextureForRenderPass_InjectedDelegateField(_unity_self, renderPass);
	}
}
