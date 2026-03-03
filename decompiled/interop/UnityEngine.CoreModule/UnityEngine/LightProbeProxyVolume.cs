using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class LightProbeProxyVolume : Behaviour
{
	public enum ResolutionMode
	{
		Automatic,
		Custom
	}

	public enum BoundingBoxMode
	{
		AutomaticLocal,
		AutomaticWorld,
		Custom
	}

	public enum ProbePositionMode
	{
		CellCorner,
		CellCenter
	}

	public enum RefreshMode
	{
		Automatic,
		EveryFrame,
		ViaScripting
	}

	public enum QualityMode
	{
		Low,
		Normal
	}

	public enum DataFormat
	{
		HalfFloat,
		Float
	}

	private delegate bool get_isFeatureSupportedDelegate();

	private delegate void get_boundsGlobal_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void get_sizeCustom_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_sizeCustom_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_originCustom_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_originCustom_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate float get_probeDensity_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_probeDensity_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate int get_gridResolutionX_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_gridResolutionX_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate int get_gridResolutionY_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_gridResolutionY_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate int get_gridResolutionZ_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_gridResolutionZ_InjectedDelegate(IntPtr _unity_self, int value);

	private delegate BoundingBoxMode get_boundingBoxMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_boundingBoxMode_InjectedDelegate(IntPtr _unity_self, BoundingBoxMode value);

	private delegate ResolutionMode get_resolutionMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_resolutionMode_InjectedDelegate(IntPtr _unity_self, ResolutionMode value);

	private delegate ProbePositionMode get_probePositionMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_probePositionMode_InjectedDelegate(IntPtr _unity_self, ProbePositionMode value);

	private delegate RefreshMode get_refreshMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_refreshMode_InjectedDelegate(IntPtr _unity_self, RefreshMode value);

	private delegate QualityMode get_qualityMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_qualityMode_InjectedDelegate(IntPtr _unity_self, QualityMode value);

	private delegate DataFormat get_dataFormat_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_dataFormat_InjectedDelegate(IntPtr _unity_self, DataFormat value);

	private delegate void SetDirtyFlag_InjectedDelegate(IntPtr _unity_self, bool flag);

	private static readonly get_isFeatureSupportedDelegate get_isFeatureSupportedDelegateField;

	private static readonly get_boundsGlobal_InjectedDelegate get_boundsGlobal_InjectedDelegateField;

	private static readonly get_sizeCustom_InjectedDelegate get_sizeCustom_InjectedDelegateField;

	private static readonly set_sizeCustom_InjectedDelegate set_sizeCustom_InjectedDelegateField;

	private static readonly get_originCustom_InjectedDelegate get_originCustom_InjectedDelegateField;

	private static readonly set_originCustom_InjectedDelegate set_originCustom_InjectedDelegateField;

	private static readonly get_probeDensity_InjectedDelegate get_probeDensity_InjectedDelegateField;

	private static readonly set_probeDensity_InjectedDelegate set_probeDensity_InjectedDelegateField;

	private static readonly get_gridResolutionX_InjectedDelegate get_gridResolutionX_InjectedDelegateField;

	private static readonly set_gridResolutionX_InjectedDelegate set_gridResolutionX_InjectedDelegateField;

	private static readonly get_gridResolutionY_InjectedDelegate get_gridResolutionY_InjectedDelegateField;

	private static readonly set_gridResolutionY_InjectedDelegate set_gridResolutionY_InjectedDelegateField;

	private static readonly get_gridResolutionZ_InjectedDelegate get_gridResolutionZ_InjectedDelegateField;

	private static readonly set_gridResolutionZ_InjectedDelegate set_gridResolutionZ_InjectedDelegateField;

	private static readonly get_boundingBoxMode_InjectedDelegate get_boundingBoxMode_InjectedDelegateField;

	private static readonly set_boundingBoxMode_InjectedDelegate set_boundingBoxMode_InjectedDelegateField;

	private static readonly get_resolutionMode_InjectedDelegate get_resolutionMode_InjectedDelegateField;

	private static readonly set_resolutionMode_InjectedDelegate set_resolutionMode_InjectedDelegateField;

	private static readonly get_probePositionMode_InjectedDelegate get_probePositionMode_InjectedDelegateField;

	private static readonly set_probePositionMode_InjectedDelegate set_probePositionMode_InjectedDelegateField;

	private static readonly get_refreshMode_InjectedDelegate get_refreshMode_InjectedDelegateField;

	private static readonly set_refreshMode_InjectedDelegate set_refreshMode_InjectedDelegateField;

	private static readonly get_qualityMode_InjectedDelegate get_qualityMode_InjectedDelegateField;

	private static readonly set_qualityMode_InjectedDelegate set_qualityMode_InjectedDelegateField;

	private static readonly get_dataFormat_InjectedDelegate get_dataFormat_InjectedDelegateField;

	private static readonly set_dataFormat_InjectedDelegate set_dataFormat_InjectedDelegateField;

	private static readonly SetDirtyFlag_InjectedDelegate SetDirtyFlag_InjectedDelegateField;

	public static bool isFeatureSupported => get_isFeatureSupportedDelegateField();

	public Bounds boundsGlobal
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_boundsGlobal_Injected(intPtr, out var ret);
			return ret;
		}
	}

	public Vector3 sizeCustom
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_sizeCustom_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_sizeCustom_Injected(intPtr, ref value);
		}
	}

	public Vector3 originCustom
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_originCustom_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_originCustom_Injected(intPtr, ref value);
		}
	}

	public float probeDensity
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_probeDensity_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_probeDensity_Injected(intPtr, value);
		}
	}

	public int gridResolutionX
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_gridResolutionX_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_gridResolutionX_Injected(intPtr, value);
		}
	}

	public int gridResolutionY
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_gridResolutionY_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_gridResolutionY_Injected(intPtr, value);
		}
	}

	public int gridResolutionZ
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_gridResolutionZ_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_gridResolutionZ_Injected(intPtr, value);
		}
	}

	public BoundingBoxMode boundingBoxMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_boundingBoxMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_boundingBoxMode_Injected(intPtr, value);
		}
	}

	public ResolutionMode resolutionMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_resolutionMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_resolutionMode_Injected(intPtr, value);
		}
	}

	public ProbePositionMode probePositionMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_probePositionMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_probePositionMode_Injected(intPtr, value);
		}
	}

	public RefreshMode refreshMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_refreshMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_refreshMode_Injected(intPtr, value);
		}
	}

	public QualityMode qualityMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_qualityMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_qualityMode_Injected(intPtr, value);
		}
	}

	public DataFormat dataFormat
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_dataFormat_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_dataFormat_Injected(intPtr, value);
		}
	}

	static LightProbeProxyVolume()
	{
		Il2CppClassPointerStore<LightProbeProxyVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LightProbeProxyVolume");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightProbeProxyVolume>.NativeClassPtr);
		get_isFeatureSupportedDelegateField = IL2CPP.ResolveICall<get_isFeatureSupportedDelegate>("UnityEngine.LightProbeProxyVolume::get_isFeatureSupported");
		get_boundsGlobal_InjectedDelegateField = IL2CPP.ResolveICall<get_boundsGlobal_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_boundsGlobal_Injected");
		get_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<get_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_sizeCustom_Injected");
		set_sizeCustom_InjectedDelegateField = IL2CPP.ResolveICall<set_sizeCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_sizeCustom_Injected");
		get_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<get_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_originCustom_Injected");
		set_originCustom_InjectedDelegateField = IL2CPP.ResolveICall<set_originCustom_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_originCustom_Injected");
		get_probeDensity_InjectedDelegateField = IL2CPP.ResolveICall<get_probeDensity_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_probeDensity_Injected");
		set_probeDensity_InjectedDelegateField = IL2CPP.ResolveICall<set_probeDensity_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_probeDensity_Injected");
		get_gridResolutionX_InjectedDelegateField = IL2CPP.ResolveICall<get_gridResolutionX_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionX_Injected");
		set_gridResolutionX_InjectedDelegateField = IL2CPP.ResolveICall<set_gridResolutionX_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionX_Injected");
		get_gridResolutionY_InjectedDelegateField = IL2CPP.ResolveICall<get_gridResolutionY_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionY_Injected");
		set_gridResolutionY_InjectedDelegateField = IL2CPP.ResolveICall<set_gridResolutionY_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionY_Injected");
		get_gridResolutionZ_InjectedDelegateField = IL2CPP.ResolveICall<get_gridResolutionZ_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_gridResolutionZ_Injected");
		set_gridResolutionZ_InjectedDelegateField = IL2CPP.ResolveICall<set_gridResolutionZ_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_gridResolutionZ_Injected");
		get_boundingBoxMode_InjectedDelegateField = IL2CPP.ResolveICall<get_boundingBoxMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_boundingBoxMode_Injected");
		set_boundingBoxMode_InjectedDelegateField = IL2CPP.ResolveICall<set_boundingBoxMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_boundingBoxMode_Injected");
		get_resolutionMode_InjectedDelegateField = IL2CPP.ResolveICall<get_resolutionMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_resolutionMode_Injected");
		set_resolutionMode_InjectedDelegateField = IL2CPP.ResolveICall<set_resolutionMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_resolutionMode_Injected");
		get_probePositionMode_InjectedDelegateField = IL2CPP.ResolveICall<get_probePositionMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_probePositionMode_Injected");
		set_probePositionMode_InjectedDelegateField = IL2CPP.ResolveICall<set_probePositionMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_probePositionMode_Injected");
		get_refreshMode_InjectedDelegateField = IL2CPP.ResolveICall<get_refreshMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_refreshMode_Injected");
		set_refreshMode_InjectedDelegateField = IL2CPP.ResolveICall<set_refreshMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_refreshMode_Injected");
		get_qualityMode_InjectedDelegateField = IL2CPP.ResolveICall<get_qualityMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_qualityMode_Injected");
		set_qualityMode_InjectedDelegateField = IL2CPP.ResolveICall<set_qualityMode_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_qualityMode_Injected");
		get_dataFormat_InjectedDelegateField = IL2CPP.ResolveICall<get_dataFormat_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::get_dataFormat_Injected");
		set_dataFormat_InjectedDelegateField = IL2CPP.ResolveICall<set_dataFormat_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::set_dataFormat_Injected");
		SetDirtyFlag_InjectedDelegateField = IL2CPP.ResolveICall<SetDirtyFlag_InjectedDelegate>("UnityEngine.LightProbeProxyVolume::SetDirtyFlag_Injected");
	}

	public LightProbeProxyVolume(IntPtr pointer)
		: base(pointer)
	{
	}

	public void Update()
	{
		SetDirtyFlag(flag: true);
	}

	public void SetDirtyFlag(bool flag)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		SetDirtyFlag_Injected(intPtr, flag);
	}

	public unsafe static void get_boundsGlobal_Injected(IntPtr _unity_self, out Bounds ret)
	{
		get_boundsGlobal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_sizeCustom_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_sizeCustom_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_sizeCustom_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_sizeCustom_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_originCustom_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_originCustom_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_originCustom_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_originCustom_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_probeDensity_Injected(IntPtr _unity_self)
	{
		return get_probeDensity_InjectedDelegateField(_unity_self);
	}

	public static void set_probeDensity_Injected(IntPtr _unity_self, float value)
	{
		set_probeDensity_InjectedDelegateField(_unity_self, value);
	}

	public static int get_gridResolutionX_Injected(IntPtr _unity_self)
	{
		return get_gridResolutionX_InjectedDelegateField(_unity_self);
	}

	public static void set_gridResolutionX_Injected(IntPtr _unity_self, int value)
	{
		set_gridResolutionX_InjectedDelegateField(_unity_self, value);
	}

	public static int get_gridResolutionY_Injected(IntPtr _unity_self)
	{
		return get_gridResolutionY_InjectedDelegateField(_unity_self);
	}

	public static void set_gridResolutionY_Injected(IntPtr _unity_self, int value)
	{
		set_gridResolutionY_InjectedDelegateField(_unity_self, value);
	}

	public static int get_gridResolutionZ_Injected(IntPtr _unity_self)
	{
		return get_gridResolutionZ_InjectedDelegateField(_unity_self);
	}

	public static void set_gridResolutionZ_Injected(IntPtr _unity_self, int value)
	{
		set_gridResolutionZ_InjectedDelegateField(_unity_self, value);
	}

	public static BoundingBoxMode get_boundingBoxMode_Injected(IntPtr _unity_self)
	{
		return get_boundingBoxMode_InjectedDelegateField(_unity_self);
	}

	public static void set_boundingBoxMode_Injected(IntPtr _unity_self, BoundingBoxMode value)
	{
		set_boundingBoxMode_InjectedDelegateField(_unity_self, value);
	}

	public static ResolutionMode get_resolutionMode_Injected(IntPtr _unity_self)
	{
		return get_resolutionMode_InjectedDelegateField(_unity_self);
	}

	public static void set_resolutionMode_Injected(IntPtr _unity_self, ResolutionMode value)
	{
		set_resolutionMode_InjectedDelegateField(_unity_self, value);
	}

	public static ProbePositionMode get_probePositionMode_Injected(IntPtr _unity_self)
	{
		return get_probePositionMode_InjectedDelegateField(_unity_self);
	}

	public static void set_probePositionMode_Injected(IntPtr _unity_self, ProbePositionMode value)
	{
		set_probePositionMode_InjectedDelegateField(_unity_self, value);
	}

	public static RefreshMode get_refreshMode_Injected(IntPtr _unity_self)
	{
		return get_refreshMode_InjectedDelegateField(_unity_self);
	}

	public static void set_refreshMode_Injected(IntPtr _unity_self, RefreshMode value)
	{
		set_refreshMode_InjectedDelegateField(_unity_self, value);
	}

	public static QualityMode get_qualityMode_Injected(IntPtr _unity_self)
	{
		return get_qualityMode_InjectedDelegateField(_unity_self);
	}

	public static void set_qualityMode_Injected(IntPtr _unity_self, QualityMode value)
	{
		set_qualityMode_InjectedDelegateField(_unity_self, value);
	}

	public static DataFormat get_dataFormat_Injected(IntPtr _unity_self)
	{
		return get_dataFormat_InjectedDelegateField(_unity_self);
	}

	public static void set_dataFormat_Injected(IntPtr _unity_self, DataFormat value)
	{
		set_dataFormat_InjectedDelegateField(_unity_self, value);
	}

	public static void SetDirtyFlag_Injected(IntPtr _unity_self, bool flag)
	{
		SetDirtyFlag_InjectedDelegateField(_unity_self, flag);
	}
}
