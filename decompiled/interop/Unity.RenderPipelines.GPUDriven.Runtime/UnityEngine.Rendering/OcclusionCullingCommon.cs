using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Collections;
using UnityEngine.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering;

public class OcclusionCullingCommon : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct OccluderContextSlot
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_valid;

		private static readonly System.IntPtr NativeFieldInfoPtr_lastUsedFrameIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_viewInstanceID;

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.U1)]
		public bool valid;

		[FieldOffset(4)]
		public int lastUsedFrameIndex;

		[FieldOffset(8)]
		public int viewInstanceID;

		static OccluderContextSlot()
		{
			Il2CppClassPointerStore<OccluderContextSlot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "OccluderContextSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccluderContextSlot>.NativeClassPtr);
			NativeFieldInfoPtr_valid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContextSlot>.NativeClassPtr, "valid");
			NativeFieldInfoPtr_lastUsedFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContextSlot>.NativeClassPtr, "lastUsedFrameIndex");
			NativeFieldInfoPtr_viewInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderContextSlot>.NativeClassPtr, "viewInstanceID");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OccluderContextSlot>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public static class ShaderIDs : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_OcclusionCullingCommonShaderVariables;

		private static readonly System.IntPtr NativeFieldInfoPtr__OccluderDepthPyramid;

		private static readonly System.IntPtr NativeFieldInfoPtr__OcclusionDebugOverlay;

		private static readonly System.IntPtr NativeFieldInfoPtr_OcclusionCullingDebugShaderVariables;

		public unsafe static int OcclusionCullingCommonShaderVariables
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OcclusionCullingCommonShaderVariables, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OcclusionCullingCommonShaderVariables, (void*)(&value));
			}
		}

		public unsafe static int _OccluderDepthPyramid
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OccluderDepthPyramid, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OccluderDepthPyramid, (void*)(&value));
			}
		}

		public unsafe static int _OcclusionDebugOverlay
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__OcclusionDebugOverlay, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__OcclusionDebugOverlay, (void*)(&value));
			}
		}

		public unsafe static int OcclusionCullingDebugShaderVariables
		{
			get
			{
				Unsafe.SkipInit(out int result);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_OcclusionCullingDebugShaderVariables, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_OcclusionCullingDebugShaderVariables, (void*)(&value));
			}
		}

		static ShaderIDs()
		{
			Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "ShaderIDs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr);
			NativeFieldInfoPtr_OcclusionCullingCommonShaderVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "OcclusionCullingCommonShaderVariables");
			NativeFieldInfoPtr__OccluderDepthPyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_OccluderDepthPyramid");
			NativeFieldInfoPtr__OcclusionDebugOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "_OcclusionDebugOverlay");
			NativeFieldInfoPtr_OcclusionCullingDebugShaderVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderIDs>.NativeClassPtr, "OcclusionCullingDebugShaderVariables");
		}

		public ShaderIDs(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class OcclusionTestOverlaySetupPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_cb;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe OcclusionCullingDebugShaderVariables cb
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cb);
				return *(OcclusionCullingDebugShaderVariables*)num;
			}
			set
			{
				*(OcclusionCullingDebugShaderVariables*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cb)) = value;
			}
		}

		static OcclusionTestOverlaySetupPassData()
		{
			Il2CppClassPointerStore<OcclusionTestOverlaySetupPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "OcclusionTestOverlaySetupPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionTestOverlaySetupPassData>.NativeClassPtr);
			NativeFieldInfoPtr_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionTestOverlaySetupPassData>.NativeClassPtr, "cb");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionTestOverlaySetupPassData>.NativeClassPtr, 100664000);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OcclusionTestOverlaySetupPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OcclusionTestOverlaySetupPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OcclusionTestOverlaySetupPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class OcclusionTestOverlayPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_debugPyramid;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe BufferHandle debugPyramid
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugPyramid);
				return *(BufferHandle*)num;
			}
			set
			{
				*(BufferHandle*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugPyramid)) = value;
			}
		}

		static OcclusionTestOverlayPassData()
		{
			Il2CppClassPointerStore<OcclusionTestOverlayPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "OcclusionTestOverlayPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionTestOverlayPassData>.NativeClassPtr);
			NativeFieldInfoPtr_debugPyramid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionTestOverlayPassData>.NativeClassPtr, "debugPyramid");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionTestOverlayPassData>.NativeClassPtr, 100664001);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OcclusionTestOverlayPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OcclusionTestOverlayPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OcclusionTestOverlayPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class OccluderOverlayPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_debugMaterial;

		private static readonly System.IntPtr NativeFieldInfoPtr_occluderTexture;

		private static readonly System.IntPtr NativeFieldInfoPtr_viewport;

		private static readonly System.IntPtr NativeFieldInfoPtr_passIndex;

		private static readonly System.IntPtr NativeFieldInfoPtr_validRange;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe Material debugMaterial
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMaterial);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_debugMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe RTHandle occluderTexture
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderTexture);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<RTHandle>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderTexture)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

		public unsafe int passIndex
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passIndex);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_passIndex)) = value;
			}
		}

		public unsafe Vector2 validRange
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validRange);
				return *(Vector2*)num;
			}
			set
			{
				*(Vector2*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_validRange)) = value;
			}
		}

		static OccluderOverlayPassData()
		{
			Il2CppClassPointerStore<OccluderOverlayPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "OccluderOverlayPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OccluderOverlayPassData>.NativeClassPtr);
			NativeFieldInfoPtr_debugMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderOverlayPassData>.NativeClassPtr, "debugMaterial");
			NativeFieldInfoPtr_occluderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderOverlayPassData>.NativeClassPtr, "occluderTexture");
			NativeFieldInfoPtr_viewport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderOverlayPassData>.NativeClassPtr, "viewport");
			NativeFieldInfoPtr_passIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderOverlayPassData>.NativeClassPtr, "passIndex");
			NativeFieldInfoPtr_validRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OccluderOverlayPassData>.NativeClassPtr, "validRange");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OccluderOverlayPassData>.NativeClassPtr, 100664002);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OccluderOverlayPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OccluderOverlayPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public OccluderOverlayPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	public class UpdateOccludersPassData : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_occluderParams;

		private static readonly System.IntPtr NativeFieldInfoPtr_occluderSubviewUpdates;

		private static readonly System.IntPtr NativeFieldInfoPtr_occluderHandles;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe OccluderParameters occluderParams
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderParams);
				return *(OccluderParameters*)num;
			}
			set
			{
				*(OccluderParameters*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderParams)) = value;
			}
		}

		public unsafe List<OccluderSubviewUpdate> occluderSubviewUpdates
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderSubviewUpdates);
				System.IntPtr intPtr = *(System.IntPtr*)num;
				return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccluderSubviewUpdate>>(intPtr) : null;
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderSubviewUpdates)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe OccluderHandles occluderHandles
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderHandles);
				return *(OccluderHandles*)num;
			}
			set
			{
				*(OccluderHandles*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_occluderHandles)) = value;
			}
		}

		static UpdateOccludersPassData()
		{
			Il2CppClassPointerStore<UpdateOccludersPassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "UpdateOccludersPassData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateOccludersPassData>.NativeClassPtr);
			NativeFieldInfoPtr_occluderParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateOccludersPassData>.NativeClassPtr, "occluderParams");
			NativeFieldInfoPtr_occluderSubviewUpdates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateOccludersPassData>.NativeClassPtr, "occluderSubviewUpdates");
			NativeFieldInfoPtr_occluderHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateOccludersPassData>.NativeClassPtr, "occluderHandles");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateOccludersPassData>.NativeClassPtr, 100664003);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateOccludersPassData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateOccludersPassData>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public UpdateOccludersPassData(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	[System.Serializable]
	[ObfuscatedName("UnityEngine.Rendering.OcclusionCullingCommon+<>c")]
	public sealed class __c : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr___9;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__29_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__32_0;

		private static readonly System.IntPtr NativeFieldInfoPtr___9__37_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderDebugOcclusionTestOverlay_b__29_0_Internal_Void_OcclusionTestOverlaySetupPassData_ComputeGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__RenderDebugOccluderOverlay_b__32_0_Internal_Void_OccluderOverlayPassData_RasterGraphContext_0;

		private static readonly System.IntPtr NativeMethodInfoPtr__UpdateInstanceOccluders_b__37_0_Internal_Void_UpdateOccludersPassData_ComputeGraphContext_0;

		public unsafe static __c __9
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<OcclusionTestOverlaySetupPassData, ComputeGraphContext> __9__29_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<OcclusionTestOverlaySetupPassData, ComputeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__29_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<OccluderOverlayPassData, RasterGraphContext> __9__32_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<OccluderOverlayPassData, RasterGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__32_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		public unsafe static BaseRenderFunc<UpdateOccludersPassData, ComputeGraphContext> __9__37_0
		{
			get
			{
				Unsafe.SkipInit(out System.IntPtr intPtr);
				IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr___9__37_0, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BaseRenderFunc<UpdateOccludersPassData, ComputeGraphContext>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr___9__37_0, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
			}
		}

		static __c()
		{
			Il2CppClassPointerStore<__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__c>.NativeClassPtr);
			NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9");
			NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__29_0");
			NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__32_0");
			NativeFieldInfoPtr___9__37_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__c>.NativeClassPtr, "<>9__37_0");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664005);
			NativeMethodInfoPtr__RenderDebugOcclusionTestOverlay_b__29_0_Internal_Void_OcclusionTestOverlaySetupPassData_ComputeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664006);
			NativeMethodInfoPtr__RenderDebugOccluderOverlay_b__32_0_Internal_Void_OccluderOverlayPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664007);
			NativeMethodInfoPtr__UpdateInstanceOccluders_b__37_0_Internal_Void_UpdateOccludersPassData_ComputeGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__c>.NativeClassPtr, 100664008);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__c>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074462, XrefRangeEnd = 1074474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderDebugOcclusionTestOverlay_b__29_0(OcclusionTestOverlaySetupPassData data, ComputeGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctx);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderDebugOcclusionTestOverlay_b__29_0_Internal_Void_OcclusionTestOverlaySetupPassData_ComputeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074474, XrefRangeEnd = 1074490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _RenderDebugOccluderOverlay_b__32_0(OccluderOverlayPassData data, RasterGraphContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ctx));
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderDebugOccluderOverlay_b__32_0_Internal_Void_OccluderOverlayPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074490, XrefRangeEnd = 1074511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _UpdateInstanceOccluders_b__37_0(UpdateOccludersPassData data, ComputeGraphContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
			*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)context);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__UpdateInstanceOccluders_b__37_0_Internal_Void_UpdateOccludersPassData_ComputeGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public __c(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_s_MaxContextGCFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugOcclusionTestMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OccluderDebugViewMaterial;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OcclusionDebugCS;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearOcclusionDebugKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OccluderDepthPyramidCS;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OccluderDepthDownscaleKernel;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_SilhouettePlaneCache;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ViewIDToIndexMap;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OccluderContextData;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_OccluderContextSlots;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FreeOccluderContexts;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CommonShaderVariables;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CommonConstantBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugShaderVariables;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DebugConstantBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingSamplerUpdateOccluders;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingSamplerOcclusionTestOverlay;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfilingSamplerOccluderOverlay;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Internal_Void_GPUResidentDrawerResources_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UseOcclusionDebug_Internal_Static_Boolean_byref_OccluderContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareCulling_Internal_Void_ComputeCommandBuffer_byref_OccluderContext_byref_OcclusionCullingSettings_byref_InstanceOcclusionTestSubviewSettings_byref_OcclusionTestComputeShader_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDepthPyramid_Internal_Static_Void_ComputeCommandBuffer_byref_OcclusionTestComputeShader_Int32_byref_OccluderHandles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetDebugPyramid_Internal_Static_Void_ComputeCommandBuffer_byref_OcclusionTestComputeShader_Int32_byref_OccluderHandles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderDebugOcclusionTestOverlay_Public_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Int32_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RenderDebugOccluderOverlay_Public_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Vector2_Single_TextureHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DispatchDebugClear_Private_Void_ComputeCommandBuffer_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PrepareOccluders_Private_OccluderHandles_RenderGraph_byref_OccluderParameters_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateFarDepthPyramid_Private_Void_ComputeCommandBuffer_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_byref_OccluderHandles_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateInstanceOccluders_Public_Boolean_RenderGraph_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateSilhouettePlanes_Internal_Void_Int32_NativeArray_1_Plane_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOcclusionTestDebugOutput_Internal_OcclusionCullingDebugOutput_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateOccluderStats_Public_Void_DebugRendererBatcherStats_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_HasOccluderContext_Internal_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOccluderContext_Internal_Boolean_Int32_byref_OccluderContext_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFrame_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewContext_Private_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DeleteContext_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__RenderDebugOcclusionTestOverlay_b__29_1_Private_Void_OcclusionTestOverlayPassData_RasterGraphContext_0;

	public unsafe static int s_MaxContextGCFrame
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_MaxContextGCFrame, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_MaxContextGCFrame, (void*)(&value));
		}
	}

	public unsafe Material m_DebugOcclusionTestMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugOcclusionTestMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugOcclusionTestMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_OccluderDebugViewMaterial
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OccluderDebugViewMaterial);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OccluderDebugViewMaterial)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ComputeShader m_OcclusionDebugCS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OcclusionDebugCS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OcclusionDebugCS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_ClearOcclusionDebugKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClearOcclusionDebugKernel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ClearOcclusionDebugKernel)) = value;
		}
	}

	public unsafe ComputeShader m_OccluderDepthPyramidCS
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OccluderDepthPyramidCS);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeShader>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OccluderDepthPyramidCS)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_OccluderDepthDownscaleKernel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OccluderDepthDownscaleKernel);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OccluderDepthDownscaleKernel)) = value;
		}
	}

	public unsafe int m_FrameIndex
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameIndex);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameIndex)) = value;
		}
	}

	public unsafe SilhouettePlaneCache m_SilhouettePlaneCache
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SilhouettePlaneCache);
			return new SilhouettePlaneCache(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_SilhouettePlaneCache), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SilhouettePlaneCache>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeParallelHashMap<int, int> m_ViewIDToIndexMap
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ViewIDToIndexMap);
			return new NativeParallelHashMap<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParallelHashMap<int, int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ViewIDToIndexMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeParallelHashMap<int, int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe List<OccluderContext> m_OccluderContextData
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OccluderContextData);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<OccluderContext>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OccluderContextData)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeList<OccluderContextSlot> m_OccluderContextSlots
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OccluderContextSlots);
			return new NativeList<OccluderContextSlot>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<OccluderContextSlot>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_OccluderContextSlots), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<OccluderContextSlot>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeList<int> m_FreeOccluderContexts
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeOccluderContexts);
			return new NativeList<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FreeOccluderContexts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe NativeArray<OcclusionCullingCommonShaderVariables> m_CommonShaderVariables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommonShaderVariables);
			return new NativeArray<OcclusionCullingCommonShaderVariables>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<OcclusionCullingCommonShaderVariables>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommonShaderVariables), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<OcclusionCullingCommonShaderVariables>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ComputeBuffer m_CommonConstantBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommonConstantBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CommonConstantBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe NativeArray<OcclusionCullingDebugShaderVariables> m_DebugShaderVariables
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugShaderVariables);
			return new NativeArray<OcclusionCullingDebugShaderVariables>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<OcclusionCullingDebugShaderVariables>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugShaderVariables), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<OcclusionCullingDebugShaderVariables>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe ComputeBuffer m_DebugConstantBuffer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugConstantBuffer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ComputeBuffer>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DebugConstantBuffer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProfilingSampler m_ProfilingSamplerUpdateOccluders
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSamplerUpdateOccluders);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSamplerUpdateOccluders)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProfilingSampler m_ProfilingSamplerOcclusionTestOverlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSamplerOcclusionTestOverlay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSamplerOcclusionTestOverlay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ProfilingSampler m_ProfilingSamplerOccluderOverlay
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSamplerOccluderOverlay);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfilingSamplerOccluderOverlay)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static OcclusionCullingCommon()
	{
		Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.GPUDriven.Runtime.dll", "UnityEngine.Rendering", "OcclusionCullingCommon");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr);
		NativeFieldInfoPtr_s_MaxContextGCFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "s_MaxContextGCFrame");
		NativeFieldInfoPtr_m_DebugOcclusionTestMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_DebugOcclusionTestMaterial");
		NativeFieldInfoPtr_m_OccluderDebugViewMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_OccluderDebugViewMaterial");
		NativeFieldInfoPtr_m_OcclusionDebugCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_OcclusionDebugCS");
		NativeFieldInfoPtr_m_ClearOcclusionDebugKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_ClearOcclusionDebugKernel");
		NativeFieldInfoPtr_m_OccluderDepthPyramidCS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_OccluderDepthPyramidCS");
		NativeFieldInfoPtr_m_OccluderDepthDownscaleKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_OccluderDepthDownscaleKernel");
		NativeFieldInfoPtr_m_FrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_FrameIndex");
		NativeFieldInfoPtr_m_SilhouettePlaneCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_SilhouettePlaneCache");
		NativeFieldInfoPtr_m_ViewIDToIndexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_ViewIDToIndexMap");
		NativeFieldInfoPtr_m_OccluderContextData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_OccluderContextData");
		NativeFieldInfoPtr_m_OccluderContextSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_OccluderContextSlots");
		NativeFieldInfoPtr_m_FreeOccluderContexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_FreeOccluderContexts");
		NativeFieldInfoPtr_m_CommonShaderVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_CommonShaderVariables");
		NativeFieldInfoPtr_m_CommonConstantBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_CommonConstantBuffer");
		NativeFieldInfoPtr_m_DebugShaderVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_DebugShaderVariables");
		NativeFieldInfoPtr_m_DebugConstantBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_DebugConstantBuffer");
		NativeFieldInfoPtr_m_ProfilingSamplerUpdateOccluders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_ProfilingSamplerUpdateOccluders");
		NativeFieldInfoPtr_m_ProfilingSamplerOcclusionTestOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_ProfilingSamplerOcclusionTestOverlay");
		NativeFieldInfoPtr_m_ProfilingSamplerOccluderOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, "m_ProfilingSamplerOccluderOverlay");
		NativeMethodInfoPtr_Init_Internal_Void_GPUResidentDrawerResources_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663976);
		NativeMethodInfoPtr_UseOcclusionDebug_Internal_Static_Boolean_byref_OccluderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663977);
		NativeMethodInfoPtr_PrepareCulling_Internal_Void_ComputeCommandBuffer_byref_OccluderContext_byref_OcclusionCullingSettings_byref_InstanceOcclusionTestSubviewSettings_byref_OcclusionTestComputeShader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663978);
		NativeMethodInfoPtr_SetDepthPyramid_Internal_Static_Void_ComputeCommandBuffer_byref_OcclusionTestComputeShader_Int32_byref_OccluderHandles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663979);
		NativeMethodInfoPtr_SetDebugPyramid_Internal_Static_Void_ComputeCommandBuffer_byref_OcclusionTestComputeShader_Int32_byref_OccluderHandles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663980);
		NativeMethodInfoPtr_RenderDebugOcclusionTestOverlay_Public_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Int32_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663981);
		NativeMethodInfoPtr_RenderDebugOccluderOverlay_Public_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Vector2_Single_TextureHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663982);
		NativeMethodInfoPtr_DispatchDebugClear_Private_Void_ComputeCommandBuffer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663983);
		NativeMethodInfoPtr_PrepareOccluders_Private_OccluderHandles_RenderGraph_byref_OccluderParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663984);
		NativeMethodInfoPtr_CreateFarDepthPyramid_Private_Void_ComputeCommandBuffer_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_byref_OccluderHandles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663985);
		NativeMethodInfoPtr_UpdateInstanceOccluders_Public_Boolean_RenderGraph_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663986);
		NativeMethodInfoPtr_UpdateSilhouettePlanes_Internal_Void_Int32_NativeArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663987);
		NativeMethodInfoPtr_GetOcclusionTestDebugOutput_Internal_OcclusionCullingDebugOutput_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663988);
		NativeMethodInfoPtr_UpdateOccluderStats_Public_Void_DebugRendererBatcherStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663989);
		NativeMethodInfoPtr_HasOccluderContext_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663990);
		NativeMethodInfoPtr_GetOccluderContext_Internal_Boolean_Int32_byref_OccluderContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663991);
		NativeMethodInfoPtr_UpdateFrame_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663992);
		NativeMethodInfoPtr_NewContext_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663993);
		NativeMethodInfoPtr_DeleteContext_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663994);
		NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663995);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663996);
		NativeMethodInfoPtr__RenderDebugOcclusionTestOverlay_b__29_1_Private_Void_OcclusionTestOverlayPassData_RasterGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr, 100663998);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074582, RefRangeEnd = 1074583, XrefRangeStart = 1074511, XrefRangeEnd = 1074582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(GPUResidentDrawerResources resources)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resources);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Internal_Void_GPUResidentDrawerResources_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 377031, RefRangeEnd = 377032, XrefRangeStart = 377031, XrefRangeEnd = 377032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UseOcclusionDebug([In] ref OccluderContext occluderCtx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)occluderCtx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UseOcclusionDebug_Internal_Static_Boolean_byref_OccluderContext_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074601, RefRangeEnd = 1074602, XrefRangeStart = 1074583, XrefRangeEnd = 1074601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PrepareCulling(ComputeCommandBuffer cmd, [In] ref OccluderContext occluderCtx, [In] ref OcclusionCullingSettings settings, [In] ref InstanceOcclusionTestSubviewSettings subviewSettings, [In] ref OcclusionTestComputeShader shader, bool useOcclusionDebug)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)occluderCtx);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref settings);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref subviewSettings);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shader);
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &useOcclusionDebug;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareCulling_Internal_Void_ComputeCommandBuffer_byref_OccluderContext_byref_OcclusionCullingSettings_byref_InstanceOcclusionTestSubviewSettings_byref_OcclusionTestComputeShader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074607, RefRangeEnd = 1074608, XrefRangeStart = 1074602, XrefRangeEnd = 1074607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDepthPyramid(ComputeCommandBuffer cmd, [In] ref OcclusionTestComputeShader shader, int kernel, [In] ref OccluderHandles occluderHandles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shader);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &kernel;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderHandles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDepthPyramid_Internal_Static_Void_ComputeCommandBuffer_byref_OcclusionTestComputeShader_Int32_byref_OccluderHandles_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074617, RefRangeEnd = 1074618, XrefRangeStart = 1074608, XrefRangeEnd = 1074617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDebugPyramid(ComputeCommandBuffer cmd, [In] ref OcclusionTestComputeShader shader, int kernel, [In] ref OccluderHandles occluderHandles)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)shader);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &kernel;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderHandles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDebugPyramid_Internal_Static_Void_ComputeCommandBuffer_byref_OcclusionTestComputeShader_Int32_byref_OccluderHandles_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074686, RefRangeEnd = 1074687, XrefRangeStart = 1074618, XrefRangeEnd = 1074686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderDebugOcclusionTestOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, int viewInstanceID, TextureHandle colorBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugSettings);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewInstanceID;
		*(TextureHandle**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderDebugOcclusionTestOverlay_Public_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Int32_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074733, RefRangeEnd = 1074734, XrefRangeStart = 1074687, XrefRangeEnd = 1074733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RenderDebugOccluderOverlay(RenderGraph renderGraph, DebugDisplayGPUResidentDrawer debugSettings, Vector2 screenPos, float maxHeight, TextureHandle colorBuffer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugSettings);
		*(Vector2**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &screenPos;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxHeight;
		*(TextureHandle**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &colorBuffer;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RenderDebugOccluderOverlay_Public_Void_RenderGraph_DebugDisplayGPUResidentDrawer_Vector2_Single_TextureHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074755, RefRangeEnd = 1074756, XrefRangeStart = 1074734, XrefRangeEnd = 1074755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DispatchDebugClear(ComputeCommandBuffer cmd, int viewInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &viewInstanceID;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DispatchDebugClear_Private_Void_ComputeCommandBuffer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074756, XrefRangeEnd = 1074775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OccluderHandles PrepareOccluders(RenderGraph renderGraph, [In] ref OccluderParameters occluderParams)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderParams);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PrepareOccluders_Private_OccluderHandles_RenderGraph_byref_OccluderParameters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(OccluderHandles*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074792, RefRangeEnd = 1074793, XrefRangeStart = 1074775, XrefRangeEnd = 1074792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateFarDepthPyramid(ComputeCommandBuffer cmd, [In] ref OccluderParameters occluderParams, Il2CppSystem.ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates, [In] ref OccluderHandles occluderHandles)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cmd);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderParams);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)occluderSubviewUpdates));
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderHandles);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateFarDepthPyramid_Private_Void_ComputeCommandBuffer_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_byref_OccluderHandles_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1074878, RefRangeEnd = 1074880, XrefRangeStart = 1074793, XrefRangeEnd = 1074878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool UpdateInstanceOccluders(RenderGraph renderGraph, [In] ref OccluderParameters occluderParams, Il2CppSystem.ReadOnlySpan<OccluderSubviewUpdate> occluderSubviewUpdates)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)renderGraph);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref occluderParams);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)occluderSubviewUpdates));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateInstanceOccluders_Public_Boolean_RenderGraph_byref_OccluderParameters_ReadOnlySpan_1_OccluderSubviewUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074881, RefRangeEnd = 1074882, XrefRangeStart = 1074880, XrefRangeEnd = 1074881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSilhouettePlanes(int viewInstanceID, NativeArray<Plane> planes)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&viewInstanceID);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)planes));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateSilhouettePlanes_Internal_Void_Int32_NativeArray_1_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1074894, RefRangeEnd = 1074896, XrefRangeStart = 1074882, XrefRangeEnd = 1074894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OcclusionCullingDebugOutput GetOcclusionTestDebugOutput(int viewInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewInstanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOcclusionTestDebugOutput_Internal_OcclusionCullingDebugOutput_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new OcclusionCullingDebugOutput(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074941, RefRangeEnd = 1074942, XrefRangeStart = 1074896, XrefRangeEnd = 1074941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateOccluderStats(DebugRendererBatcherStats debugStats)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)debugStats);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateOccluderStats_Public_Void_DebugRendererBatcherStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074945, RefRangeEnd = 1074946, XrefRangeStart = 1074942, XrefRangeEnd = 1074945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasOccluderContext(int viewInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewInstanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_HasOccluderContext_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1074957, RefRangeEnd = 1074960, XrefRangeStart = 1074946, XrefRangeEnd = 1074957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetOccluderContext(int viewInstanceID, out OccluderContext occluderContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&viewInstanceID);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		nint num2 = 0;
		*(nint**)num = &num2;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOccluderContext_Internal_Boolean_Int32_byref_OccluderContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num3 = num2;
		occluderContext = ((num3 == 0) ? null : new OccluderContext(num3));
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1074983, RefRangeEnd = 1074984, XrefRangeStart = 1074960, XrefRangeEnd = 1074983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateFrame()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateFrame_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1075016, RefRangeEnd = 1075018, XrefRangeStart = 1074984, XrefRangeEnd = 1075016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int NewContext(int viewInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewInstanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewContext_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1075037, RefRangeEnd = 1075040, XrefRangeStart = 1075018, XrefRangeEnd = 1075037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeleteContext(int viewInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&viewInstanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DeleteContext_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1075085, RefRangeEnd = 1075086, XrefRangeStart = 1075040, XrefRangeEnd = 1075085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe OcclusionCullingCommon()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OcclusionCullingCommon>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075086, XrefRangeEnd = 1075099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RenderDebugOcclusionTestOverlay_b__29_1(OcclusionTestOverlayPassData data, RasterGraphContext ctx)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)data);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)ctx));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__RenderDebugOcclusionTestOverlay_b__29_1_Private_Void_OcclusionTestOverlayPassData_RasterGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public OcclusionCullingCommon(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
