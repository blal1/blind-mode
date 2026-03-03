using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public sealed class RenderTargetBinding : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorRenderTargets;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthRenderTarget;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorLoadActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorStoreActions;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthLoadAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthStoreAction;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorRenderTargets_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthRenderTarget_Public_get_RenderTargetIdentifier_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorLoadActions_Public_get_Il2CppStructArray_1_RenderBufferLoadAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthLoadAction_Public_get_RenderBufferLoadAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_flags_Public_get_RenderTargetFlags_0;

	public unsafe Il2CppStructArray<RenderTargetIdentifier> m_ColorRenderTargets
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorRenderTargets);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorRenderTargets)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderTargetIdentifier m_DepthRenderTarget
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthRenderTarget);
			return *(RenderTargetIdentifier*)num;
		}
		set
		{
			*(RenderTargetIdentifier*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthRenderTarget)) = value;
		}
	}

	public unsafe Il2CppStructArray<RenderBufferLoadAction> m_ColorLoadActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorLoadActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferLoadAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorLoadActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<RenderBufferStoreAction> m_ColorStoreActions
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorStoreActions);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ColorStoreActions)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe RenderBufferLoadAction m_DepthLoadAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthLoadAction);
			return *(RenderBufferLoadAction*)num;
		}
		set
		{
			*(RenderBufferLoadAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthLoadAction)) = value;
		}
	}

	public unsafe RenderBufferStoreAction m_DepthStoreAction
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthStoreAction);
			return *(RenderBufferStoreAction*)num;
		}
		set
		{
			*(RenderBufferStoreAction*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DepthStoreAction)) = value;
		}
	}

	public unsafe RenderTargetFlags m_Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
			return *(RenderTargetFlags*)num;
		}
		set
		{
			*(RenderTargetFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
		}
	}

	public unsafe Il2CppStructArray<RenderTargetIdentifier> colorRenderTargets
	{
		[CallerCount(255)]
		[CachedScanResults(RefRangeStart = 761723, RefRangeEnd = 761978, XrefRangeStart = 761723, XrefRangeEnd = 761978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorRenderTargets_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
		}
		set
		{
			m_ColorRenderTargets = value;
		}
	}

	public unsafe RenderTargetIdentifier depthRenderTarget
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthRenderTarget_Public_get_RenderTargetIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetIdentifier*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_DepthRenderTarget = value;
		}
	}

	public unsafe Il2CppStructArray<RenderBufferLoadAction> colorLoadActions
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorLoadActions_Public_get_Il2CppStructArray_1_RenderBufferLoadAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferLoadAction>>(intPtr2) : null;
		}
		set
		{
			m_ColorLoadActions = value;
		}
	}

	public unsafe Il2CppStructArray<RenderBufferStoreAction> colorStoreActions
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1232194, RefRangeEnd = 1232230, XrefRangeStart = 1232194, XrefRangeEnd = 1232194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(intPtr2) : null;
		}
		set
		{
			m_ColorStoreActions = value;
		}
	}

	public unsafe RenderBufferLoadAction depthLoadAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthLoadAction_Public_get_RenderBufferLoadAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderBufferLoadAction*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_DepthLoadAction = value;
		}
	}

	public unsafe RenderBufferStoreAction depthStoreAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderBufferStoreAction*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_DepthStoreAction = value;
		}
	}

	public unsafe RenderTargetFlags flags
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_flags_Public_get_RenderTargetFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RenderTargetFlags*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			m_Flags = value;
		}
	}

	static RenderTargetBinding()
	{
		Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderTargetBinding");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr);
		NativeFieldInfoPtr_m_ColorRenderTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, "m_ColorRenderTargets");
		NativeFieldInfoPtr_m_DepthRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, "m_DepthRenderTarget");
		NativeFieldInfoPtr_m_ColorLoadActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, "m_ColorLoadActions");
		NativeFieldInfoPtr_m_ColorStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, "m_ColorStoreActions");
		NativeFieldInfoPtr_m_DepthLoadAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, "m_DepthLoadAction");
		NativeFieldInfoPtr_m_DepthStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, "m_DepthStoreAction");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, "m_Flags");
		NativeMethodInfoPtr_get_colorRenderTargets_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100667700);
		NativeMethodInfoPtr_get_depthRenderTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100667701);
		NativeMethodInfoPtr_get_colorLoadActions_Public_get_Il2CppStructArray_1_RenderBufferLoadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100667702);
		NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100667703);
		NativeMethodInfoPtr_get_depthLoadAction_Public_get_RenderBufferLoadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100667704);
		NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100667705);
		NativeMethodInfoPtr_get_flags_Public_get_RenderTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100667706);
	}

	public RenderTargetBinding(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RenderTargetBinding()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr))
	{
	}
}
