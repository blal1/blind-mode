using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace UnityEngine.Experimental.Rendering;

public sealed class XRPassCreateInfo : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_renderTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_renderTargetDesc;

	private static readonly System.IntPtr NativeFieldInfoPtr_motionVectorRenderTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_motionVectorRenderTargetDesc;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingParameters;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionMeshMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_occlusionMeshScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_foveatedRenderingInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_multipassId;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingPassId;

	private static readonly System.IntPtr NativeFieldInfoPtr_copyDepth;

	private static readonly System.IntPtr NativeFieldInfoPtr_hasMotionVectorPass;

	private static readonly System.IntPtr NativeFieldInfoPtr_spaceWarpRightHandedNDC;

	private static readonly System.IntPtr NativeFieldInfoPtr_xrSdkRenderPass;

	public unsafe RenderTargetIdentifier renderTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderTarget);
			return *(RenderTargetIdentifier*)num;
		}
		set
		{
			*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderTarget)) = value;
		}
	}

	public unsafe RenderTextureDescriptor renderTargetDesc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderTargetDesc);
			return *(RenderTextureDescriptor*)num;
		}
		set
		{
			*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_renderTargetDesc)) = value;
		}
	}

	public unsafe RenderTargetIdentifier motionVectorRenderTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionVectorRenderTarget);
			return *(RenderTargetIdentifier*)num;
		}
		set
		{
			*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionVectorRenderTarget)) = value;
		}
	}

	public unsafe RenderTextureDescriptor motionVectorRenderTargetDesc
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionVectorRenderTargetDesc);
			return *(RenderTextureDescriptor*)num;
		}
		set
		{
			*(RenderTextureDescriptor*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_motionVectorRenderTargetDesc)) = value;
		}
	}

	public unsafe ScriptableCullingParameters cullingParameters
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingParameters);
			return *(ScriptableCullingParameters*)num;
		}
		set
		{
			*(ScriptableCullingParameters*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingParameters)) = value;
		}
	}

	public unsafe Material occlusionMeshMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionMeshMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionMeshMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float occlusionMeshScale
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionMeshScale);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occlusionMeshScale)) = value;
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

	public unsafe int multipassId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multipassId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_multipassId)) = value;
		}
	}

	public unsafe int cullingPassId
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingPassId);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cullingPassId)) = value;
		}
	}

	public unsafe bool copyDepth
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyDepth);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_copyDepth)) = value;
		}
	}

	public unsafe bool hasMotionVectorPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasMotionVectorPass);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_hasMotionVectorPass)) = value;
		}
	}

	public unsafe bool spaceWarpRightHandedNDC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spaceWarpRightHandedNDC);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_spaceWarpRightHandedNDC)) = value;
		}
	}

	public unsafe XRDisplaySubsystem.XRRenderPass xrSdkRenderPass
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xrSdkRenderPass);
			return *(XRDisplaySubsystem.XRRenderPass*)num;
		}
		set
		{
			*(XRDisplaySubsystem.XRRenderPass*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_xrSdkRenderPass)) = value;
		}
	}

	static XRPassCreateInfo()
	{
		Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRPassCreateInfo");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr);
		NativeFieldInfoPtr_renderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "renderTarget");
		NativeFieldInfoPtr_renderTargetDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "renderTargetDesc");
		NativeFieldInfoPtr_motionVectorRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "motionVectorRenderTarget");
		NativeFieldInfoPtr_motionVectorRenderTargetDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "motionVectorRenderTargetDesc");
		NativeFieldInfoPtr_cullingParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "cullingParameters");
		NativeFieldInfoPtr_occlusionMeshMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "occlusionMeshMaterial");
		NativeFieldInfoPtr_occlusionMeshScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "occlusionMeshScale");
		NativeFieldInfoPtr_foveatedRenderingInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "foveatedRenderingInfo");
		NativeFieldInfoPtr_multipassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "multipassId");
		NativeFieldInfoPtr_cullingPassId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "cullingPassId");
		NativeFieldInfoPtr_copyDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "copyDepth");
		NativeFieldInfoPtr_hasMotionVectorPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "hasMotionVectorPass");
		NativeFieldInfoPtr_spaceWarpRightHandedNDC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "spaceWarpRightHandedNDC");
		NativeFieldInfoPtr_xrSdkRenderPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr, "xrSdkRenderPass");
	}

	public XRPassCreateInfo(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public XRPassCreateInfo()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRPassCreateInfo>.NativeClassPtr))
	{
	}
}
