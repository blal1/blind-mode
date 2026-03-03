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

public sealed class LineRenderer : Renderer
{
	private delegate float get_startWidth_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_startWidth_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_endWidth_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_endWidth_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_widthMultiplier_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_widthMultiplier_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate int get_numCornerVertices_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_numCornerVertices_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate int get_numCapVertices_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_numCapVertices_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate bool get_useWorldSpace_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_useWorldSpace_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_loop_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_loop_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate void get_startColor_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_startColor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate void get_endColor_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_endColor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

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

	private delegate void Simplify_InjectedDelegate(System.IntPtr _unity_self, float tolerance);

	private delegate void BakeMesh_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr mesh, System.IntPtr camera, bool useTransform);

	private delegate System.IntPtr GetWidthCurveCopy_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetWidthCurve_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr curve);

	private delegate System.IntPtr GetColorGradientCopy_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void SetColorGradient_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr curve);

	private delegate void SetPositions_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions);

	private delegate void SetPositionsWithNativeContainer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions, int count);

	private delegate int GetPositionsWithNativeContainer_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr positions, int length);

	private static readonly System.IntPtr NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositions_Public_Int32_Il2CppStructArray_1_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_positionCount_Injected_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_positionCount_Injected_Private_Static_Void_IntPtr_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0;

	private static readonly get_startWidth_InjectedDelegate get_startWidth_InjectedDelegateField;

	private static readonly set_startWidth_InjectedDelegate set_startWidth_InjectedDelegateField;

	private static readonly get_endWidth_InjectedDelegate get_endWidth_InjectedDelegateField;

	private static readonly set_endWidth_InjectedDelegate set_endWidth_InjectedDelegateField;

	private static readonly get_widthMultiplier_InjectedDelegate get_widthMultiplier_InjectedDelegateField;

	private static readonly set_widthMultiplier_InjectedDelegate set_widthMultiplier_InjectedDelegateField;

	private static readonly get_numCornerVertices_InjectedDelegate get_numCornerVertices_InjectedDelegateField;

	private static readonly set_numCornerVertices_InjectedDelegate set_numCornerVertices_InjectedDelegateField;

	private static readonly get_numCapVertices_InjectedDelegate get_numCapVertices_InjectedDelegateField;

	private static readonly set_numCapVertices_InjectedDelegate set_numCapVertices_InjectedDelegateField;

	private static readonly get_useWorldSpace_InjectedDelegate get_useWorldSpace_InjectedDelegateField;

	private static readonly set_useWorldSpace_InjectedDelegate set_useWorldSpace_InjectedDelegateField;

	private static readonly get_loop_InjectedDelegate get_loop_InjectedDelegateField;

	private static readonly set_loop_InjectedDelegate set_loop_InjectedDelegateField;

	private static readonly get_startColor_InjectedDelegate get_startColor_InjectedDelegateField;

	private static readonly set_startColor_InjectedDelegate set_startColor_InjectedDelegateField;

	private static readonly get_endColor_InjectedDelegate get_endColor_InjectedDelegateField;

	private static readonly set_endColor_InjectedDelegate set_endColor_InjectedDelegateField;

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

	private static readonly Simplify_InjectedDelegate Simplify_InjectedDelegateField;

	private static readonly BakeMesh_InjectedDelegate BakeMesh_InjectedDelegateField;

	private static readonly GetWidthCurveCopy_InjectedDelegate GetWidthCurveCopy_InjectedDelegateField;

	private static readonly SetWidthCurve_InjectedDelegate SetWidthCurve_InjectedDelegateField;

	private static readonly GetColorGradientCopy_InjectedDelegate GetColorGradientCopy_InjectedDelegateField;

	private static readonly SetColorGradient_InjectedDelegate SetColorGradient_InjectedDelegateField;

	private static readonly SetPositions_InjectedDelegate SetPositions_InjectedDelegateField;

	private static readonly SetPositionsWithNativeContainer_InjectedDelegate SetPositionsWithNativeContainer_InjectedDelegateField;

	private static readonly GetPositionsWithNativeContainer_InjectedDelegate GetPositionsWithNativeContainer_InjectedDelegateField;

	public unsafe int positionCount
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1173631, RefRangeEnd = 1173633, XrefRangeStart = 1173626, XrefRangeEnd = 1173631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1173638, RefRangeEnd = 1173639, XrefRangeStart = 1173633, XrefRangeEnd = 1173638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public int numPositions
	{
		get
		{
			return positionCount;
		}
		set
		{
			positionCount = value;
		}
	}

	public float startWidth
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_startWidth_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_startWidth_Injected(intPtr, value);
		}
	}

	public float endWidth
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_endWidth_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_endWidth_Injected(intPtr, value);
		}
	}

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

	public bool useWorldSpace
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_useWorldSpace_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_useWorldSpace_Injected(intPtr, value);
		}
	}

	public bool loop
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_loop_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_loop_Injected(intPtr, value);
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

	static LineRenderer()
	{
		Il2CppClassPointerStore<LineRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LineRenderer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr);
		NativeMethodInfoPtr_get_positionCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664492);
		NativeMethodInfoPtr_set_positionCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664493);
		NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664494);
		NativeMethodInfoPtr_GetPositions_Public_Int32_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664495);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664496);
		NativeMethodInfoPtr_get_positionCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664497);
		NativeMethodInfoPtr_set_positionCount_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664498);
		NativeMethodInfoPtr_SetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664499);
		NativeMethodInfoPtr_GetPositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr, 100664500);
		get_startWidth_InjectedDelegateField = IL2CPP.ResolveICall<get_startWidth_InjectedDelegate>("UnityEngine.LineRenderer::get_startWidth_Injected");
		set_startWidth_InjectedDelegateField = IL2CPP.ResolveICall<set_startWidth_InjectedDelegate>("UnityEngine.LineRenderer::set_startWidth_Injected");
		get_endWidth_InjectedDelegateField = IL2CPP.ResolveICall<get_endWidth_InjectedDelegate>("UnityEngine.LineRenderer::get_endWidth_Injected");
		set_endWidth_InjectedDelegateField = IL2CPP.ResolveICall<set_endWidth_InjectedDelegate>("UnityEngine.LineRenderer::set_endWidth_Injected");
		get_widthMultiplier_InjectedDelegateField = IL2CPP.ResolveICall<get_widthMultiplier_InjectedDelegate>("UnityEngine.LineRenderer::get_widthMultiplier_Injected");
		set_widthMultiplier_InjectedDelegateField = IL2CPP.ResolveICall<set_widthMultiplier_InjectedDelegate>("UnityEngine.LineRenderer::set_widthMultiplier_Injected");
		get_numCornerVertices_InjectedDelegateField = IL2CPP.ResolveICall<get_numCornerVertices_InjectedDelegate>("UnityEngine.LineRenderer::get_numCornerVertices_Injected");
		set_numCornerVertices_InjectedDelegateField = IL2CPP.ResolveICall<set_numCornerVertices_InjectedDelegate>("UnityEngine.LineRenderer::set_numCornerVertices_Injected");
		get_numCapVertices_InjectedDelegateField = IL2CPP.ResolveICall<get_numCapVertices_InjectedDelegate>("UnityEngine.LineRenderer::get_numCapVertices_Injected");
		set_numCapVertices_InjectedDelegateField = IL2CPP.ResolveICall<set_numCapVertices_InjectedDelegate>("UnityEngine.LineRenderer::set_numCapVertices_Injected");
		get_useWorldSpace_InjectedDelegateField = IL2CPP.ResolveICall<get_useWorldSpace_InjectedDelegate>("UnityEngine.LineRenderer::get_useWorldSpace_Injected");
		set_useWorldSpace_InjectedDelegateField = IL2CPP.ResolveICall<set_useWorldSpace_InjectedDelegate>("UnityEngine.LineRenderer::set_useWorldSpace_Injected");
		get_loop_InjectedDelegateField = IL2CPP.ResolveICall<get_loop_InjectedDelegate>("UnityEngine.LineRenderer::get_loop_Injected");
		set_loop_InjectedDelegateField = IL2CPP.ResolveICall<set_loop_InjectedDelegate>("UnityEngine.LineRenderer::set_loop_Injected");
		get_startColor_InjectedDelegateField = IL2CPP.ResolveICall<get_startColor_InjectedDelegate>("UnityEngine.LineRenderer::get_startColor_Injected");
		set_startColor_InjectedDelegateField = IL2CPP.ResolveICall<set_startColor_InjectedDelegate>("UnityEngine.LineRenderer::set_startColor_Injected");
		get_endColor_InjectedDelegateField = IL2CPP.ResolveICall<get_endColor_InjectedDelegate>("UnityEngine.LineRenderer::get_endColor_Injected");
		set_endColor_InjectedDelegateField = IL2CPP.ResolveICall<set_endColor_InjectedDelegate>("UnityEngine.LineRenderer::set_endColor_Injected");
		GetPosition_InjectedDelegateField = IL2CPP.ResolveICall<GetPosition_InjectedDelegate>("UnityEngine.LineRenderer::GetPosition_Injected");
		get_textureScale_InjectedDelegateField = IL2CPP.ResolveICall<get_textureScale_InjectedDelegate>("UnityEngine.LineRenderer::get_textureScale_Injected");
		set_textureScale_InjectedDelegateField = IL2CPP.ResolveICall<set_textureScale_InjectedDelegate>("UnityEngine.LineRenderer::set_textureScale_Injected");
		get_shadowBias_InjectedDelegateField = IL2CPP.ResolveICall<get_shadowBias_InjectedDelegate>("UnityEngine.LineRenderer::get_shadowBias_Injected");
		set_shadowBias_InjectedDelegateField = IL2CPP.ResolveICall<set_shadowBias_InjectedDelegate>("UnityEngine.LineRenderer::set_shadowBias_Injected");
		get_generateLightingData_InjectedDelegateField = IL2CPP.ResolveICall<get_generateLightingData_InjectedDelegate>("UnityEngine.LineRenderer::get_generateLightingData_Injected");
		set_generateLightingData_InjectedDelegateField = IL2CPP.ResolveICall<set_generateLightingData_InjectedDelegate>("UnityEngine.LineRenderer::set_generateLightingData_Injected");
		get_textureMode_InjectedDelegateField = IL2CPP.ResolveICall<get_textureMode_InjectedDelegate>("UnityEngine.LineRenderer::get_textureMode_Injected");
		set_textureMode_InjectedDelegateField = IL2CPP.ResolveICall<set_textureMode_InjectedDelegate>("UnityEngine.LineRenderer::set_textureMode_Injected");
		get_alignment_InjectedDelegateField = IL2CPP.ResolveICall<get_alignment_InjectedDelegate>("UnityEngine.LineRenderer::get_alignment_Injected");
		set_alignment_InjectedDelegateField = IL2CPP.ResolveICall<set_alignment_InjectedDelegate>("UnityEngine.LineRenderer::set_alignment_Injected");
		get_maskInteraction_InjectedDelegateField = IL2CPP.ResolveICall<get_maskInteraction_InjectedDelegate>("UnityEngine.LineRenderer::get_maskInteraction_Injected");
		set_maskInteraction_InjectedDelegateField = IL2CPP.ResolveICall<set_maskInteraction_InjectedDelegate>("UnityEngine.LineRenderer::set_maskInteraction_Injected");
		Simplify_InjectedDelegateField = IL2CPP.ResolveICall<Simplify_InjectedDelegate>("UnityEngine.LineRenderer::Simplify_Injected");
		BakeMesh_InjectedDelegateField = IL2CPP.ResolveICall<BakeMesh_InjectedDelegate>("UnityEngine.LineRenderer::BakeMesh_Injected");
		GetWidthCurveCopy_InjectedDelegateField = IL2CPP.ResolveICall<GetWidthCurveCopy_InjectedDelegate>("UnityEngine.LineRenderer::GetWidthCurveCopy_Injected");
		SetWidthCurve_InjectedDelegateField = IL2CPP.ResolveICall<SetWidthCurve_InjectedDelegate>("UnityEngine.LineRenderer::SetWidthCurve_Injected");
		GetColorGradientCopy_InjectedDelegateField = IL2CPP.ResolveICall<GetColorGradientCopy_InjectedDelegate>("UnityEngine.LineRenderer::GetColorGradientCopy_Injected");
		SetColorGradient_InjectedDelegateField = IL2CPP.ResolveICall<SetColorGradient_InjectedDelegate>("UnityEngine.LineRenderer::SetColorGradient_Injected");
		SetPositions_InjectedDelegateField = IL2CPP.ResolveICall<SetPositions_InjectedDelegate>("UnityEngine.LineRenderer::SetPositions_Injected");
		SetPositionsWithNativeContainer_InjectedDelegateField = IL2CPP.ResolveICall<SetPositionsWithNativeContainer_InjectedDelegate>("UnityEngine.LineRenderer::SetPositionsWithNativeContainer_Injected");
		GetPositionsWithNativeContainer_InjectedDelegateField = IL2CPP.ResolveICall<GetPositionsWithNativeContainer_InjectedDelegate>("UnityEngine.LineRenderer::GetPositionsWithNativeContainer_Injected");
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1173643, RefRangeEnd = 1173651, XrefRangeStart = 1173639, XrefRangeEnd = 1173643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPosition(int index, Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&index);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &position;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPosition_Public_Void_Int32_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1173662, RefRangeEnd = 1173664, XrefRangeStart = 1173651, XrefRangeEnd = 1173662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetPositions([Out] Il2CppStructArray<Vector3> positions)
	{
		//IL_0045: Expected native int or pointer, but got O
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		nint num = 0;
		*ptr = (nint)(&num);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositions_Public_Int32_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		nint num2 = num;
		Unsafe.Write((void*)(nint)positions, (num2 == 0) ? null : new Il2CppStructArray<Vector3>((System.IntPtr)num2));
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(103)]
	[CachedScanResults(RefRangeStart = 22793, RefRangeEnd = 22896, XrefRangeStart = 22793, XrefRangeEnd = 22896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LineRenderer()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineRenderer>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173664, XrefRangeEnd = 1173666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int get_positionCount_Injected(System.IntPtr _unity_self)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&_unity_self);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_positionCount_Injected_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173666, XrefRangeEnd = 1173668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_positionCount_Injected(System.IntPtr _unity_self, int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_positionCount_Injected_Private_Static_Void_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173668, XrefRangeEnd = 1173670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPosition_Injected(System.IntPtr _unity_self, int index, [In] ref Vector3 position)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&_unity_self);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref position);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPosition_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1173670, XrefRangeEnd = 1173672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPositions_Injected(System.IntPtr _unity_self, out BlittableArrayWrapper positions)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&_unity_self);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref positions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPositions_Injected_Private_Static_Int32_IntPtr_byref_BlittableArrayWrapper_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public LineRenderer(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void SetWidth(float start, float end)
	{
		startWidth = start;
		endWidth = end;
	}

	public void SetColors(Color start, Color end)
	{
		startColor = start;
		endColor = end;
	}

	public void SetVertexCount(int count)
	{
		positionCount = count;
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

	public void Simplify(float tolerance)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		Simplify_Injected(intPtr, tolerance);
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

	public static float get_startWidth_Injected(System.IntPtr _unity_self)
	{
		return get_startWidth_InjectedDelegateField(_unity_self);
	}

	public static void set_startWidth_Injected(System.IntPtr _unity_self, float value)
	{
		set_startWidth_InjectedDelegateField(_unity_self, value);
	}

	public static float get_endWidth_Injected(System.IntPtr _unity_self)
	{
		return get_endWidth_InjectedDelegateField(_unity_self);
	}

	public static void set_endWidth_Injected(System.IntPtr _unity_self, float value)
	{
		set_endWidth_InjectedDelegateField(_unity_self, value);
	}

	public static float get_widthMultiplier_Injected(System.IntPtr _unity_self)
	{
		return get_widthMultiplier_InjectedDelegateField(_unity_self);
	}

	public static void set_widthMultiplier_Injected(System.IntPtr _unity_self, float value)
	{
		set_widthMultiplier_InjectedDelegateField(_unity_self, value);
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

	public static bool get_useWorldSpace_Injected(System.IntPtr _unity_self)
	{
		return get_useWorldSpace_InjectedDelegateField(_unity_self);
	}

	public static void set_useWorldSpace_Injected(System.IntPtr _unity_self, bool value)
	{
		set_useWorldSpace_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_loop_Injected(System.IntPtr _unity_self)
	{
		return get_loop_InjectedDelegateField(_unity_self);
	}

	public static void set_loop_Injected(System.IntPtr _unity_self, bool value)
	{
		set_loop_InjectedDelegateField(_unity_self, value);
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

	public static void Simplify_Injected(System.IntPtr _unity_self, float tolerance)
	{
		Simplify_InjectedDelegateField(_unity_self, tolerance);
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

	public unsafe static void SetPositions_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper positions)
	{
		SetPositions_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref positions));
	}

	public static void SetPositionsWithNativeContainer_Injected(System.IntPtr _unity_self, System.IntPtr positions, int count)
	{
		SetPositionsWithNativeContainer_InjectedDelegateField(_unity_self, positions, count);
	}

	public static int GetPositionsWithNativeContainer_Injected(System.IntPtr _unity_self, System.IntPtr positions, int length)
	{
		return GetPositionsWithNativeContainer_InjectedDelegateField(_unity_self, positions, length);
	}
}
