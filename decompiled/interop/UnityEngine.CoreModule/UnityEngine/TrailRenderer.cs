using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class TrailRenderer : Renderer
{
	private delegate void set_time_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_widthMultiplier_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_widthMultiplier_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_autodestruct_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_autodestruct_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_emitting_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_emitting_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate int get_numCornerVertices_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_numCornerVertices_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_numCapVertices_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_numCapVertices_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate float get_minVertexDistance_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_minVertexDistance_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate void get_startColor_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_startColor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_endColor_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_endColor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate int get_positionCount_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetPosition_InjectedDelegate(System.IntPtr _unity_self, int index, [In] System.IntPtr position);

	private delegate void GetPosition_InjectedDelegate(System.IntPtr _unity_self, int index, [Out] System.IntPtr ret);

	private delegate void get_textureScale_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_textureScale_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate float get_shadowBias_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_shadowBias_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate bool get_generateLightingData_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_generateLightingData_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate LineTextureMode get_textureMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_textureMode_InjectedDelegate(System.IntPtr _unity_self, LineTextureMode value);

	private delegate LineAlignment get_alignment_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_alignment_InjectedDelegate(System.IntPtr _unity_self, LineAlignment value);

	private delegate SpriteMaskInteraction get_maskInteraction_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_maskInteraction_InjectedDelegate(System.IntPtr _unity_self, SpriteMaskInteraction value);

	private delegate void Clear_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void BakeMesh_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr mesh, System.IntPtr camera, bool useTransform);

	private delegate System.IntPtr GetWidthCurveCopy_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetWidthCurve_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr curve);

	private delegate System.IntPtr GetColorGradientCopy_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetColorGradient_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr curve);

	private delegate int GetPositions_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr positions);

	private delegate int GetVisiblePositions_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr positions);

	private delegate void SetPositions_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions);

	private delegate void AddPosition_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr position);

	private delegate void AddPositions_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions);

	private delegate void SetPositionsWithNativeContainer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions, int count);

	private delegate int GetPositionsWithNativeContainer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions, int length);

	private delegate int GetVisiblePositionsWithNativeContainer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions, int length);

	private delegate void AddPositionsWithNativeContainer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions, int length);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_startWidth_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_endWidth_Public_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_startWidth_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_startWidth_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_endWidth_Injected_Private_Static_Single_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_endWidth_Injected_Private_Static_Void_IntPtr_Single_0;

	private static readonly set_time_InjectedDelegate set_time_InjectedDelegateField;

	private static readonly get_widthMultiplier_InjectedDelegate get_widthMultiplier_InjectedDelegateField;

	private static readonly set_widthMultiplier_InjectedDelegate set_widthMultiplier_InjectedDelegateField;

	private static readonly get_autodestruct_InjectedDelegate get_autodestruct_InjectedDelegateField;

	private static readonly set_autodestruct_InjectedDelegate set_autodestruct_InjectedDelegateField;

	private static readonly get_emitting_InjectedDelegate get_emitting_InjectedDelegateField;

	private static readonly set_emitting_InjectedDelegate set_emitting_InjectedDelegateField;

	private static readonly get_numCornerVertices_InjectedDelegate get_numCornerVertices_InjectedDelegateField;

	private static readonly set_numCornerVertices_InjectedDelegate set_numCornerVertices_InjectedDelegateField;

	private static readonly get_numCapVertices_InjectedDelegate get_numCapVertices_InjectedDelegateField;

	private static readonly set_numCapVertices_InjectedDelegate set_numCapVertices_InjectedDelegateField;

	private static readonly get_minVertexDistance_InjectedDelegate get_minVertexDistance_InjectedDelegateField;

	private static readonly set_minVertexDistance_InjectedDelegate set_minVertexDistance_InjectedDelegateField;

	private static readonly get_startColor_InjectedDelegate get_startColor_InjectedDelegateField;

	private static readonly set_startColor_InjectedDelegate set_startColor_InjectedDelegateField;

	private static readonly get_endColor_InjectedDelegate get_endColor_InjectedDelegateField;

	private static readonly set_endColor_InjectedDelegate set_endColor_InjectedDelegateField;

	private static readonly get_positionCount_InjectedDelegate get_positionCount_InjectedDelegateField;

	private static readonly SetPosition_InjectedDelegate SetPosition_InjectedDelegateField;

	private static readonly GetPosition_InjectedDelegate GetPosition_InjectedDelegateField;

	private static readonly get_textureScale_InjectedDelegate get_textureScale_InjectedDelegateField;

	private static readonly set_textureScale_InjectedDelegate set_textureScale_InjectedDelegateField;

	private static readonly get_shadowBias_InjectedDelegate get_shadowBias_InjectedDelegateField;

	private static readonly set_shadowBias_InjectedDelegate set_shadowBias_InjectedDelegateField;

	private static readonly get_generateLightingData_InjectedDelegate get_generateLightingData_InjectedDelegateField;

	private static readonly set_generateLightingData_InjectedDelegate set_generateLightingData_InjectedDelegateField;

	private static readonly get_textureMode_InjectedDelegate get_textureMode_InjectedDelegateField;

	private static readonly set_textureMode_InjectedDelegate set_textureMode_InjectedDelegateField;

	private static readonly get_alignment_InjectedDelegate get_alignment_InjectedDelegateField;

	private static readonly set_alignment_InjectedDelegate set_alignment_InjectedDelegateField;

	private static readonly get_maskInteraction_InjectedDelegate get_maskInteraction_InjectedDelegateField;

	private static readonly set_maskInteraction_InjectedDelegate set_maskInteraction_InjectedDelegateField;

	private static readonly Clear_InjectedDelegate Clear_InjectedDelegateField;

	private static readonly BakeMesh_InjectedDelegate BakeMesh_InjectedDelegateField;

	private static readonly GetWidthCurveCopy_InjectedDelegate GetWidthCurveCopy_InjectedDelegateField;

	private static readonly SetWidthCurve_InjectedDelegate SetWidthCurve_InjectedDelegateField;

	private static readonly GetColorGradientCopy_InjectedDelegate GetColorGradientCopy_InjectedDelegateField;

	private static readonly SetColorGradient_InjectedDelegate SetColorGradient_InjectedDelegateField;

	private static readonly GetPositions_InjectedDelegate GetPositions_InjectedDelegateField;

	private static readonly GetVisiblePositions_InjectedDelegate GetVisiblePositions_InjectedDelegateField;

	private static readonly SetPositions_InjectedDelegate SetPositions_InjectedDelegateField;

	private static readonly AddPosition_InjectedDelegate AddPosition_InjectedDelegateField;

	private static readonly AddPositions_InjectedDelegate AddPositions_InjectedDelegateField;

	private static readonly SetPositionsWithNativeContainer_InjectedDelegate SetPositionsWithNativeContainer_InjectedDelegateField;

	private static readonly GetPositionsWithNativeContainer_InjectedDelegate GetPositionsWithNativeContainer_InjectedDelegateField;

	private static readonly GetVisiblePositionsWithNativeContainer_InjectedDelegate GetVisiblePositionsWithNativeContainer_InjectedDelegateField;

	private static readonly AddPositionsWithNativeContainer_InjectedDelegate AddPositionsWithNativeContainer_InjectedDelegateField;

	public unsafe float time
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173583, RefRangeEnd = 1173584, XrefRangeStart = 1173578, XrefRangeEnd = 1173583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_time_Injected(intPtr, value);
		}
	}

	public unsafe float startWidth
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1173589, RefRangeEnd = 1173591, XrefRangeStart = 1173584, XrefRangeEnd = 1173589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_startWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1173596, RefRangeEnd = 1173600, XrefRangeStart = 1173591, XrefRangeEnd = 1173596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe float endWidth
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1173605, RefRangeEnd = 1173607, XrefRangeStart = 1173600, XrefRangeEnd = 1173605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_endWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1173612, RefRangeEnd = 1173616, XrefRangeStart = 1173607, XrefRangeEnd = 1173612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public int numPositions => positionCount;

	public float widthMultiplier
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_widthMultiplier_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_widthMultiplier_Injected(intPtr, value);
		}
	}

	public bool autodestruct
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_autodestruct_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_autodestruct_Injected(intPtr, value);
		}
	}

	public bool emitting
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_emitting_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_emitting_Injected(intPtr, value);
		}
	}

	public int numCornerVertices
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_numCornerVertices_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_numCornerVertices_Injected(intPtr, value);
		}
	}

	public int numCapVertices
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_numCapVertices_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_numCapVertices_Injected(intPtr, value);
		}
	}

	public float minVertexDistance
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_minVertexDistance_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_minVertexDistance_Injected(intPtr, value);
		}
	}

	public Color startColor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_startColor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_startColor_Injected(intPtr, ref value);
		}
	}

	public Color endColor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_endColor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_endColor_Injected(intPtr, ref value);
		}
	}

	public int positionCount
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_positionCount_Injected(intPtr);
		}
	}

	public Vector2 textureScale
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_textureScale_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_textureScale_Injected(intPtr, ref value);
		}
	}

	public float shadowBias
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_shadowBias_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shadowBias_Injected(intPtr, value);
		}
	}

	public bool generateLightingData
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_generateLightingData_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_generateLightingData_Injected(intPtr, value);
		}
	}

	public LineTextureMode textureMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_textureMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_textureMode_Injected(intPtr, value);
		}
	}

	public LineAlignment alignment
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_alignment_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_alignment_Injected(intPtr, value);
		}
	}

	public SpriteMaskInteraction maskInteraction
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_maskInteraction_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maskInteraction_Injected(intPtr, value);
		}
	}

	public AnimationCurve widthCurve
	{
		get
		{
			return GetWidthCurveCopy();
		}
		set
		{
			SetWidthCurve(value);
		}
	}

	public Gradient colorGradient
	{
		get
		{
			return GetColorGradientCopy();
		}
		set
		{
			SetColorGradient(value);
		}
	}

	static TrailRenderer()
	{
		Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TrailRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr);
		NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664481);
		NativeMethodInfoPtr_get_startWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664482);
		NativeMethodInfoPtr_set_startWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664483);
		NativeMethodInfoPtr_get_endWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664484);
		NativeMethodInfoPtr_set_endWidth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664485);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664486);
		NativeMethodInfoPtr_get_time_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664487);
		NativeMethodInfoPtr_get_startWidth_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664488);
		NativeMethodInfoPtr_set_startWidth_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664489);
		NativeMethodInfoPtr_get_endWidth_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664490);
		NativeMethodInfoPtr_set_endWidth_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr, 100664491);
		set_time_InjectedDelegateField = IL2CPP.ResolveICall<set_time_InjectedDelegate>("UnityEngine.TrailRenderer::set_time_Injected");
		get_widthMultiplier_InjectedDelegateField = IL2CPP.ResolveICall<get_widthMultiplier_InjectedDelegate>("UnityEngine.TrailRenderer::get_widthMultiplier_Injected");
		set_widthMultiplier_InjectedDelegateField = IL2CPP.ResolveICall<set_widthMultiplier_InjectedDelegate>("UnityEngine.TrailRenderer::set_widthMultiplier_Injected");
		get_autodestruct_InjectedDelegateField = IL2CPP.ResolveICall<get_autodestruct_InjectedDelegate>("UnityEngine.TrailRenderer::get_autodestruct_Injected");
		set_autodestruct_InjectedDelegateField = IL2CPP.ResolveICall<set_autodestruct_InjectedDelegate>("UnityEngine.TrailRenderer::set_autodestruct_Injected");
		get_emitting_InjectedDelegateField = IL2CPP.ResolveICall<get_emitting_InjectedDelegate>("UnityEngine.TrailRenderer::get_emitting_Injected");
		set_emitting_InjectedDelegateField = IL2CPP.ResolveICall<set_emitting_InjectedDelegate>("UnityEngine.TrailRenderer::set_emitting_Injected");
		get_numCornerVertices_InjectedDelegateField = IL2CPP.ResolveICall<get_numCornerVertices_InjectedDelegate>("UnityEngine.TrailRenderer::get_numCornerVertices_Injected");
		set_numCornerVertices_InjectedDelegateField = IL2CPP.ResolveICall<set_numCornerVertices_InjectedDelegate>("UnityEngine.TrailRenderer::set_numCornerVertices_Injected");
		get_numCapVertices_InjectedDelegateField = IL2CPP.ResolveICall<get_numCapVertices_InjectedDelegate>("UnityEngine.TrailRenderer::get_numCapVertices_Injected");
		set_numCapVertices_InjectedDelegateField = IL2CPP.ResolveICall<set_numCapVertices_InjectedDelegate>("UnityEngine.TrailRenderer::set_numCapVertices_Injected");
		get_minVertexDistance_InjectedDelegateField = IL2CPP.ResolveICall<get_minVertexDistance_InjectedDelegate>("UnityEngine.TrailRenderer::get_minVertexDistance_Injected");
		set_minVertexDistance_InjectedDelegateField = IL2CPP.ResolveICall<set_minVertexDistance_InjectedDelegate>("UnityEngine.TrailRenderer::set_minVertexDistance_Injected");
		get_startColor_InjectedDelegateField = IL2CPP.ResolveICall<get_startColor_InjectedDelegate>("UnityEngine.TrailRenderer::get_startColor_Injected");
		set_startColor_InjectedDelegateField = IL2CPP.ResolveICall<set_startColor_InjectedDelegate>("UnityEngine.TrailRenderer::set_startColor_Injected");
		get_endColor_InjectedDelegateField = IL2CPP.ResolveICall<get_endColor_InjectedDelegate>("UnityEngine.TrailRenderer::get_endColor_Injected");
		set_endColor_InjectedDelegateField = IL2CPP.ResolveICall<set_endColor_InjectedDelegate>("UnityEngine.TrailRenderer::set_endColor_Injected");
		get_positionCount_InjectedDelegateField = IL2CPP.ResolveICall<get_positionCount_InjectedDelegate>("UnityEngine.TrailRenderer::get_positionCount_Injected");
		SetPosition_InjectedDelegateField = IL2CPP.ResolveICall<SetPosition_InjectedDelegate>("UnityEngine.TrailRenderer::SetPosition_Injected");
		GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<GetPosition_InjectedDelegate>("UnityEngine.TrailRenderer::GetPosition_Injected");
		get_textureScale_InjectedDelegateField = IL2CPP.ResolveICall<get_textureScale_InjectedDelegate>("UnityEngine.TrailRenderer::get_textureScale_Injected");
		set_textureScale_InjectedDelegateField = IL2CPP.ResolveICall<set_textureScale_InjectedDelegate>("UnityEngine.TrailRenderer::set_textureScale_Injected");
		get_shadowBias_InjectedDelegateField = IL2CPP.ResolveICall<get_shadowBias_InjectedDelegate>("UnityEngine.TrailRenderer::get_shadowBias_Injected");
		set_shadowBias_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowBias_InjectedDelegate>("UnityEngine.TrailRenderer::set_shadowBias_Injected");
		get_generateLightingData_InjectedDelegateField = IL2CPP.ResolveICall<get_generateLightingData_InjectedDelegate>("UnityEngine.TrailRenderer::get_generateLightingData_Injected");
		set_generateLightingData_InjectedDelegateField = IL2CPP.ResolveICall<set_generateLightingData_InjectedDelegate>("UnityEngine.TrailRenderer::set_generateLightingData_Injected");
		get_textureMode_InjectedDelegateField = IL2CPP.ResolveICall<get_textureMode_InjectedDelegate>("UnityEngine.TrailRenderer::get_textureMode_Injected");
		set_textureMode_InjectedDelegateField = IL2CPP.ResolveICall<set_textureMode_InjectedDelegate>("UnityEngine.TrailRenderer::set_textureMode_Injected");
		get_alignment_InjectedDelegateField = IL2CPP.ResolveICall<get_alignment_InjectedDelegate>("UnityEngine.TrailRenderer::get_alignment_Injected");
		set_alignment_InjectedDelegateField = IL2CPP.ResolveICall<set_alignment_InjectedDelegate>("UnityEngine.TrailRenderer::set_alignment_Injected");
		get_maskInteraction_InjectedDelegateField = IL2CPP.ResolveICall<get_maskInteraction_InjectedDelegate>("UnityEngine.TrailRenderer::get_maskInteraction_Injected");
		set_maskInteraction_InjectedDelegateField = IL2CPP.ResolveICall<set_maskInteraction_InjectedDelegate>("UnityEngine.TrailRenderer::set_maskInteraction_Injected");
		Clear_InjectedDelegateField = IL2CPP.ResolveICall<Clear_InjectedDelegate>("UnityEngine.TrailRenderer::Clear_Injected");
		BakeMesh_InjectedDelegateField = IL2CPP.ResolveICall<BakeMesh_InjectedDelegate>("UnityEngine.TrailRenderer::BakeMesh_Injected");
		GetWidthCurveCopy_InjectedDelegateField = IL2CPP.ResolveICall<GetWidthCurveCopy_InjectedDelegate>("UnityEngine.TrailRenderer::GetWidthCurveCopy_Injected");
		SetWidthCurve_InjectedDelegateField = IL2CPP.ResolveICall<SetWidthCurve_InjectedDelegate>("UnityEngine.TrailRenderer::SetWidthCurve_Injected");
		GetColorGradientCopy_InjectedDelegateField = IL2CPP.ResolveICall<GetColorGradientCopy_InjectedDelegate>("UnityEngine.TrailRenderer::GetColorGradientCopy_Injected");
		SetColorGradient_InjectedDelegateField = IL2CPP.ResolveICall<SetColorGradient_InjectedDelegate>("UnityEngine.TrailRenderer::SetColorGradient_Injected");
		GetPositions_InjectedDelegateField = IL2CPP.ResolveICall<GetPositions_InjectedDelegate>("UnityEngine.TrailRenderer::GetPositions_Injected");
		GetVisiblePositions_InjectedDelegateField = IL2CPP.ResolveICall<GetVisiblePositions_InjectedDelegate>("UnityEngine.TrailRenderer::GetVisiblePositions_Injected");
		SetPositions_InjectedDelegateField = IL2CPP.ResolveICall<SetPositions_InjectedDelegate>("UnityEngine.TrailRenderer::SetPositions_Injected");
		AddPosition_InjectedDelegateField = IL2CPP.ResolveICall<AddPosition_InjectedDelegate>("UnityEngine.TrailRenderer::AddPosition_Injected");
		AddPositions_InjectedDelegateField = IL2CPP.ResolveICall<AddPositions_InjectedDelegate>("UnityEngine.TrailRenderer::AddPositions_Injected");
		SetPositionsWithNativeContainer_InjectedDelegateField = IL2CPP.ResolveICall<SetPositionsWithNativeContainer_InjectedDelegate>("UnityEngine.TrailRenderer::SetPositionsWithNativeContainer_Injected");
		GetPositionsWithNativeContainer_InjectedDelegateField = IL2CPP.ResolveICall<GetPositionsWithNativeContainer_InjectedDelegate>("UnityEngine.TrailRenderer::GetPositionsWithNativeContainer_Injected");
		GetVisiblePositionsWithNativeContainer_InjectedDelegateField = IL2CPP.ResolveICall<GetVisiblePositionsWithNativeContainer_InjectedDelegate>("UnityEngine.TrailRenderer::GetVisiblePositionsWithNativeContainer_Injected");
		AddPositionsWithNativeContainer_InjectedDelegateField = IL2CPP.ResolveICall<AddPositionsWithNativeContainer_InjectedDelegate>("UnityEngine.TrailRenderer::AddPositionsWithNativeContainer_Injected");
	}

	[CallerCount(103)]
	[CachedScanResults(RefRangeStart = 22793, RefRangeEnd = 22896, XrefRangeStart = 22793, XrefRangeEnd = 22896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TrailRenderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173616, XrefRangeEnd = 1173618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_time_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_time_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173618, XrefRangeEnd = 1173620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_startWidth_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_startWidth_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173620, XrefRangeEnd = 1173622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_startWidth_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_startWidth_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173622, XrefRangeEnd = 1173624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float get_endWidth_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_endWidth_Injected_Private_Static_Single_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173624, XrefRangeEnd = 1173626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_endWidth_Injected(System.IntPtr _unity_self, float value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_endWidth_Injected_Private_Static_Void_IntPtr_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public TrailRenderer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetPosition(int index, Vector3 position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetPosition_Injected(intPtr, index, ref position);
	}

	public Vector3 GetPosition(int index)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetPosition_Injected(intPtr, index, out var ret);
		return ret;
	}

	public void Clear()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Clear_Injected(intPtr);
	}

	public void BakeMesh(Mesh mesh, [Optional] bool useTransform)
	{
		BakeMesh(mesh, Camera.main, useTransform);
	}

	public void BakeMesh(Mesh mesh, Camera camera, [Optional] bool useTransform)
	{
		if ((object)mesh == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		if ((object)camera == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = MarshalledUnityObject.MarshalNotNull(mesh);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(mesh, "mesh");
		}
		System.IntPtr intPtr3 = MarshalledUnityObject.MarshalNotNull(camera);
		if (intPtr3 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(camera, "camera");
		}
		BakeMesh_Injected(intPtr, intPtr2, intPtr3, useTransform);
	}

	public AnimationCurve GetWidthCurveCopy()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr widthCurveCopy_Injected = GetWidthCurveCopy_Injected(intPtr);
		return (widthCurveCopy_Injected == (System.IntPtr)0) ? null : AnimationCurve.BindingsMarshaller.ConvertToManaged(widthCurveCopy_Injected);
	}

	public void SetWidthCurve(AnimationCurve curve)
	{
		if (curve == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(curve, "curve");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = AnimationCurve.BindingsMarshaller.ConvertToNative(curve);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(curve, "curve");
		}
		SetWidthCurve_Injected(intPtr, intPtr2);
	}

	public Gradient GetColorGradientCopy()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr colorGradientCopy_Injected = GetColorGradientCopy_Injected(intPtr);
		return (colorGradientCopy_Injected == (System.IntPtr)0) ? null : Gradient.BindingsMarshaller.ConvertToManaged(colorGradientCopy_Injected);
	}

	public void SetColorGradient(Gradient curve)
	{
		if (curve == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(curve, "curve");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		System.IntPtr intPtr2 = Gradient.BindingsMarshaller.ConvertToNative(curve);
		if (intPtr2 == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(curve, "curve");
		}
		SetColorGradient_Injected(intPtr, intPtr2);
	}

	public int GetPositions([Out] Il2CppStructArray<Vector3> positions)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public int GetVisiblePositions([Out] Il2CppStructArray<Vector3> positions)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public unsafe void SetPositions(Il2CppStructArray<Vector3> positions)
	{
		//IL_0027: Expected O, but got Ref
		//IL_002e: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		if (positions == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)positions, "positions");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector3> span);
		((Il2CppSystem.Span<Vector3>)(&span))._002Ector((Il2CppArrayBase<Vector3>)(object)positions);
		fixed (Vector3* begin = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper positions2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
			SetPositions_Injected(intPtr, ref positions2);
		}
	}

	public void AddPosition(Vector3 position)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddPosition_Injected(intPtr, ref position);
	}

	public unsafe void AddPositions(Il2CppStructArray<Vector3> positions)
	{
		//IL_0027: Expected O, but got Ref
		//IL_002e: Expected O, but got Ref
		//IL_003a: Expected O, but got Ref
		if (positions == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)positions, "positions");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<Vector3> span);
		((Il2CppSystem.Span<Vector3>)(&span))._002Ector((Il2CppArrayBase<Vector3>)(object)positions);
		fixed (Vector3* begin = &((Il2CppSystem.Span<Vector3>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper positions2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<Vector3>)(&span)).Length);
			AddPositions_Injected(intPtr, ref positions2);
		}
	}

	public unsafe void SetPositions(NativeArray<Vector3> positions)
	{
		//IL_0015: Expected O, but got Ref
		SetPositionsWithNativeContainer((System.IntPtr)positions.GetUnsafeReadOnlyPtr(), ((NativeArray<Vector3>)(&positions)).Length);
	}

	public unsafe void SetPositions(NativeSlice<Vector3> positions)
	{
		//IL_0015: Expected O, but got Ref
		SetPositionsWithNativeContainer((System.IntPtr)positions.GetUnsafeReadOnlyPtr(), ((NativeSlice<Vector3>)(&positions)).Length);
	}

	public unsafe int GetPositions([Out] NativeArray<Vector3> positions)
	{
		//IL_0015: Expected O, but got Ref
		return GetPositionsWithNativeContainer((System.IntPtr)positions.GetUnsafePtr(), ((NativeArray<Vector3>)(&positions)).Length);
	}

	public unsafe int GetPositions([Out] NativeSlice<Vector3> positions)
	{
		//IL_0015: Expected O, but got Ref
		return GetPositionsWithNativeContainer((System.IntPtr)positions.GetUnsafePtr(), ((NativeSlice<Vector3>)(&positions)).Length);
	}

	public unsafe int GetVisiblePositions([Out] NativeArray<Vector3> positions)
	{
		//IL_0015: Expected O, but got Ref
		return GetVisiblePositionsWithNativeContainer((System.IntPtr)positions.GetUnsafePtr(), ((NativeArray<Vector3>)(&positions)).Length);
	}

	public unsafe int GetVisiblePositions([Out] NativeSlice<Vector3> positions)
	{
		//IL_0015: Expected O, but got Ref
		return GetVisiblePositionsWithNativeContainer((System.IntPtr)positions.GetUnsafePtr(), ((NativeSlice<Vector3>)(&positions)).Length);
	}

	public unsafe void AddPositions([Out] NativeArray<Vector3> positions)
	{
		//IL_0015: Expected O, but got Ref
		AddPositionsWithNativeContainer((System.IntPtr)positions.GetUnsafePtr(), ((NativeArray<Vector3>)(&positions)).Length);
	}

	public unsafe void AddPositions([Out] NativeSlice<Vector3> positions)
	{
		//IL_0015: Expected O, but got Ref
		AddPositionsWithNativeContainer((System.IntPtr)positions.GetUnsafePtr(), ((NativeSlice<Vector3>)(&positions)).Length);
	}

	public void SetPositionsWithNativeContainer(System.IntPtr positions, int count)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		SetPositionsWithNativeContainer_Injected(intPtr, positions, count);
	}

	public int GetPositionsWithNativeContainer(System.IntPtr positions, int length)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetPositionsWithNativeContainer_Injected(intPtr, positions, length);
	}

	public int GetVisiblePositionsWithNativeContainer(System.IntPtr positions, int length)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return GetVisiblePositionsWithNativeContainer_Injected(intPtr, positions, length);
	}

	public void AddPositionsWithNativeContainer(System.IntPtr positions, int length)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		AddPositionsWithNativeContainer_Injected(intPtr, positions, length);
	}

	public static void set_time_Injected(System.IntPtr _unity_self, float value)
	{
		set_time_InjectedDelegateField(_unity_self, value);
	}

	public static float get_widthMultiplier_Injected(System.IntPtr _unity_self)
	{
		return get_widthMultiplier_InjectedDelegateField(_unity_self);
	}

	public static void set_widthMultiplier_Injected(System.IntPtr _unity_self, float value)
	{
		set_widthMultiplier_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_autodestruct_Injected(System.IntPtr _unity_self)
	{
		return get_autodestruct_InjectedDelegateField(_unity_self);
	}

	public static void set_autodestruct_Injected(System.IntPtr _unity_self, bool value)
	{
		set_autodestruct_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_emitting_Injected(System.IntPtr _unity_self)
	{
		return get_emitting_InjectedDelegateField(_unity_self);
	}

	public static void set_emitting_Injected(System.IntPtr _unity_self, bool value)
	{
		set_emitting_InjectedDelegateField(_unity_self, value);
	}

	public static int get_numCornerVertices_Injected(System.IntPtr _unity_self)
	{
		return get_numCornerVertices_InjectedDelegateField(_unity_self);
	}

	public static void set_numCornerVertices_Injected(System.IntPtr _unity_self, int value)
	{
		set_numCornerVertices_InjectedDelegateField(_unity_self, value);
	}

	public static int get_numCapVertices_Injected(System.IntPtr _unity_self)
	{
		return get_numCapVertices_InjectedDelegateField(_unity_self);
	}

	public static void set_numCapVertices_Injected(System.IntPtr _unity_self, int value)
	{
		set_numCapVertices_InjectedDelegateField(_unity_self, value);
	}

	public static float get_minVertexDistance_Injected(System.IntPtr _unity_self)
	{
		return get_minVertexDistance_InjectedDelegateField(_unity_self);
	}

	public static void set_minVertexDistance_Injected(System.IntPtr _unity_self, float value)
	{
		set_minVertexDistance_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_startColor_Injected(System.IntPtr _unity_self, out Color ret)
	{
		get_startColor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_startColor_Injected(System.IntPtr _unity_self, [In] ref Color value)
	{
		set_startColor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_endColor_Injected(System.IntPtr _unity_self, out Color ret)
	{
		get_endColor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_endColor_Injected(System.IntPtr _unity_self, [In] ref Color value)
	{
		set_endColor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static int get_positionCount_Injected(System.IntPtr _unity_self)
	{
		return get_positionCount_InjectedDelegateField(_unity_self);
	}

	public unsafe static void SetPosition_Injected(System.IntPtr _unity_self, int index, [In] ref Vector3 position)
	{
		SetPosition_InjectedDelegateField(_unity_self, index, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static void GetPosition_Injected(System.IntPtr _unity_self, int index, out Vector3 ret)
	{
		GetPosition_InjectedDelegateField(_unity_self, index, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_textureScale_Injected(System.IntPtr _unity_self, out Vector2 ret)
	{
		get_textureScale_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_textureScale_Injected(System.IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_textureScale_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_shadowBias_Injected(System.IntPtr _unity_self)
	{
		return get_shadowBias_InjectedDelegateField(_unity_self);
	}

	public static void set_shadowBias_Injected(System.IntPtr _unity_self, float value)
	{
		set_shadowBias_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_generateLightingData_Injected(System.IntPtr _unity_self)
	{
		return get_generateLightingData_InjectedDelegateField(_unity_self);
	}

	public static void set_generateLightingData_Injected(System.IntPtr _unity_self, bool value)
	{
		set_generateLightingData_InjectedDelegateField(_unity_self, value);
	}

	public static LineTextureMode get_textureMode_Injected(System.IntPtr _unity_self)
	{
		return get_textureMode_InjectedDelegateField(_unity_self);
	}

	public static void set_textureMode_Injected(System.IntPtr _unity_self, LineTextureMode value)
	{
		set_textureMode_InjectedDelegateField(_unity_self, value);
	}

	public static LineAlignment get_alignment_Injected(System.IntPtr _unity_self)
	{
		return get_alignment_InjectedDelegateField(_unity_self);
	}

	public static void set_alignment_Injected(System.IntPtr _unity_self, LineAlignment value)
	{
		set_alignment_InjectedDelegateField(_unity_self, value);
	}

	public static SpriteMaskInteraction get_maskInteraction_Injected(System.IntPtr _unity_self)
	{
		return get_maskInteraction_InjectedDelegateField(_unity_self);
	}

	public static void set_maskInteraction_Injected(System.IntPtr _unity_self, SpriteMaskInteraction value)
	{
		set_maskInteraction_InjectedDelegateField(_unity_self, value);
	}

	public static void Clear_Injected(System.IntPtr _unity_self)
	{
		Clear_InjectedDelegateField(_unity_self);
	}

	public static void BakeMesh_Injected(System.IntPtr _unity_self, System.IntPtr mesh, System.IntPtr camera, bool useTransform)
	{
		BakeMesh_InjectedDelegateField(_unity_self, mesh, camera, useTransform);
	}

	public static System.IntPtr GetWidthCurveCopy_Injected(System.IntPtr _unity_self)
	{
		return GetWidthCurveCopy_InjectedDelegateField(_unity_self);
	}

	public static void SetWidthCurve_Injected(System.IntPtr _unity_self, System.IntPtr curve)
	{
		SetWidthCurve_InjectedDelegateField(_unity_self, curve);
	}

	public static System.IntPtr GetColorGradientCopy_Injected(System.IntPtr _unity_self)
	{
		return GetColorGradientCopy_InjectedDelegateField(_unity_self);
	}

	public static void SetColorGradient_Injected(System.IntPtr _unity_self, System.IntPtr curve)
	{
		SetColorGradient_InjectedDelegateField(_unity_self, curve);
	}

	public unsafe static int GetPositions_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper positions)
	{
		return GetPositions_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positions));
	}

	public unsafe static int GetVisiblePositions_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper positions)
	{
		return GetVisiblePositions_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positions));
	}

	public unsafe static void SetPositions_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper positions)
	{
		SetPositions_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positions));
	}

	public unsafe static void AddPosition_Injected(System.IntPtr _unity_self, [In] ref Vector3 position)
	{
		AddPosition_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref position));
	}

	public unsafe static void AddPositions_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper positions)
	{
		AddPositions_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positions));
	}

	public static void SetPositionsWithNativeContainer_Injected(System.IntPtr _unity_self, System.IntPtr positions, int count)
	{
		SetPositionsWithNativeContainer_InjectedDelegateField(_unity_self, positions, count);
	}

	public static int GetPositionsWithNativeContainer_Injected(System.IntPtr _unity_self, System.IntPtr positions, int length)
	{
		return GetPositionsWithNativeContainer_InjectedDelegateField(_unity_self, positions, length);
	}

	public static int GetVisiblePositionsWithNativeContainer_Injected(System.IntPtr _unity_self, System.IntPtr positions, int length)
	{
		return GetVisiblePositionsWithNativeContainer_InjectedDelegateField(_unity_self, positions, length);
	}

	public static void AddPositionsWithNativeContainer_Injected(System.IntPtr _unity_self, System.IntPtr positions, int length)
	{
		AddPositionsWithNativeContainer_InjectedDelegateField(_unity_self, positions, length);
	}
}
