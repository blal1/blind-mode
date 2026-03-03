using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class CustomRenderTexture : RenderTexture
{
	private delegate void Internal_CreateCustomRenderTextureDelegate(System.IntPtr rt);

	private delegate void TriggerUpdate_InjectedDelegate(System.IntPtr _unity_self, int count);

	private delegate void TriggerInitialization_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void ClearUpdateZones_InjectedDelegate(System.IntPtr _unity_self);

	private delegate System.IntPtr get_material_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_material_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_initializationMaterial_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_initializationMaterial_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate System.IntPtr get_initializationTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_initializationTexture_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr value);

	private delegate void GetUpdateZonesInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr updateZones);

	private delegate void SetUpdateZonesInternal_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr updateZones);

	private delegate System.IntPtr GetDoubleBufferRenderTexture_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void EnsureDoubleBufferConsistency_InjectedDelegate(System.IntPtr _unity_self);

	private delegate CustomRenderTextureInitializationSource get_initializationSource_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_initializationSource_InjectedDelegate(System.IntPtr _unity_self, CustomRenderTextureInitializationSource value);

	private delegate void get_initializationColor_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

	private delegate void set_initializationColor_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr value);

	private delegate CustomRenderTextureUpdateMode get_updateMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_updateMode_InjectedDelegate(System.IntPtr _unity_self, CustomRenderTextureUpdateMode value);

	private delegate CustomRenderTextureUpdateMode get_initializationMode_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_initializationMode_InjectedDelegate(System.IntPtr _unity_self, CustomRenderTextureUpdateMode value);

	private delegate CustomRenderTextureUpdateZoneSpace get_updateZoneSpace_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_updateZoneSpace_InjectedDelegate(System.IntPtr _unity_self, CustomRenderTextureUpdateZoneSpace value);

	private delegate int get_shaderPass_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_shaderPass_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate uint get_cubemapFaceMask_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_cubemapFaceMask_InjectedDelegate(System.IntPtr _unity_self, uint value);

	private delegate bool get_doubleBuffered_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_doubleBuffered_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate bool get_wrapUpdateZones_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_wrapUpdateZones_InjectedDelegate(System.IntPtr _unity_self, bool value);

	private delegate float get_updatePeriod_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_updatePeriod_InjectedDelegate(System.IntPtr _unity_self, float value);

	private static readonly Internal_CreateCustomRenderTextureDelegate Internal_CreateCustomRenderTextureDelegateField;

	private static readonly TriggerUpdate_InjectedDelegate TriggerUpdate_InjectedDelegateField;

	private static readonly TriggerInitialization_InjectedDelegate TriggerInitialization_InjectedDelegateField;

	private static readonly ClearUpdateZones_InjectedDelegate ClearUpdateZones_InjectedDelegateField;

	private static readonly get_material_InjectedDelegate get_material_InjectedDelegateField;

	private static readonly set_material_InjectedDelegate set_material_InjectedDelegateField;

	private static readonly get_initializationMaterial_InjectedDelegate get_initializationMaterial_InjectedDelegateField;

	private static readonly set_initializationMaterial_InjectedDelegate set_initializationMaterial_InjectedDelegateField;

	private static readonly get_initializationTexture_InjectedDelegate get_initializationTexture_InjectedDelegateField;

	private static readonly set_initializationTexture_InjectedDelegate set_initializationTexture_InjectedDelegateField;

	private static readonly GetUpdateZonesInternal_InjectedDelegate GetUpdateZonesInternal_InjectedDelegateField;

	private static readonly SetUpdateZonesInternal_InjectedDelegate SetUpdateZonesInternal_InjectedDelegateField;

	private static readonly GetDoubleBufferRenderTexture_InjectedDelegate GetDoubleBufferRenderTexture_InjectedDelegateField;

	private static readonly EnsureDoubleBufferConsistency_InjectedDelegate EnsureDoubleBufferConsistency_InjectedDelegateField;

	private static readonly get_initializationSource_InjectedDelegate get_initializationSource_InjectedDelegateField;

	private static readonly set_initializationSource_InjectedDelegate set_initializationSource_InjectedDelegateField;

	private static readonly get_initializationColor_InjectedDelegate get_initializationColor_InjectedDelegateField;

	private static readonly set_initializationColor_InjectedDelegate set_initializationColor_InjectedDelegateField;

	private static readonly get_updateMode_InjectedDelegate get_updateMode_InjectedDelegateField;

	private static readonly set_updateMode_InjectedDelegate set_updateMode_InjectedDelegateField;

	private static readonly get_initializationMode_InjectedDelegate get_initializationMode_InjectedDelegateField;

	private static readonly set_initializationMode_InjectedDelegate set_initializationMode_InjectedDelegateField;

	private static readonly get_updateZoneSpace_InjectedDelegate get_updateZoneSpace_InjectedDelegateField;

	private static readonly set_updateZoneSpace_InjectedDelegate set_updateZoneSpace_InjectedDelegateField;

	private static readonly get_shaderPass_InjectedDelegate get_shaderPass_InjectedDelegateField;

	private static readonly set_shaderPass_InjectedDelegate set_shaderPass_InjectedDelegateField;

	private static readonly get_cubemapFaceMask_InjectedDelegate get_cubemapFaceMask_InjectedDelegateField;

	private static readonly set_cubemapFaceMask_InjectedDelegate set_cubemapFaceMask_InjectedDelegateField;

	private static readonly get_doubleBuffered_InjectedDelegate get_doubleBuffered_InjectedDelegateField;

	private static readonly set_doubleBuffered_InjectedDelegate set_doubleBuffered_InjectedDelegateField;

	private static readonly get_wrapUpdateZones_InjectedDelegate get_wrapUpdateZones_InjectedDelegateField;

	private static readonly set_wrapUpdateZones_InjectedDelegate set_wrapUpdateZones_InjectedDelegateField;

	private static readonly get_updatePeriod_InjectedDelegate get_updatePeriod_InjectedDelegateField;

	private static readonly set_updatePeriod_InjectedDelegate set_updatePeriod_InjectedDelegateField;

	public Material material
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Material>(get_material_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_material_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Material initializationMaterial
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Material>(get_initializationMaterial_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_initializationMaterial_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Texture initializationTexture
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Texture>(get_initializationTexture_Injected(intPtr));
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_initializationTexture_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public CustomRenderTextureInitializationSource initializationSource
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_initializationSource_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_initializationSource_Injected(intPtr, value);
		}
	}

	public Color initializationColor
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			get_initializationColor_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_initializationColor_Injected(intPtr, ref value);
		}
	}

	public CustomRenderTextureUpdateMode updateMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_updateMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_updateMode_Injected(intPtr, value);
		}
	}

	public CustomRenderTextureUpdateMode initializationMode
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_initializationMode_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_initializationMode_Injected(intPtr, value);
		}
	}

	public CustomRenderTextureUpdateZoneSpace updateZoneSpace
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_updateZoneSpace_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_updateZoneSpace_Injected(intPtr, value);
		}
	}

	public int shaderPass
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_shaderPass_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_shaderPass_Injected(intPtr, value);
		}
	}

	public uint cubemapFaceMask
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_cubemapFaceMask_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_cubemapFaceMask_Injected(intPtr, value);
		}
	}

	public bool doubleBuffered
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_doubleBuffered_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_doubleBuffered_Injected(intPtr, value);
		}
	}

	public bool wrapUpdateZones
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_wrapUpdateZones_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_wrapUpdateZones_Injected(intPtr, value);
		}
	}

	public float updatePeriod
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_updatePeriod_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_updatePeriod_Injected(intPtr, value);
		}
	}

	static CustomRenderTexture()
	{
		Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CustomRenderTexture");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTexture>.NativeClassPtr);
		Internal_CreateCustomRenderTextureDelegateField = IL2CPP.ResolveICall<Internal_CreateCustomRenderTextureDelegate>("UnityEngine.CustomRenderTexture::Internal_CreateCustomRenderTexture");
		TriggerUpdate_InjectedDelegateField = IL2CPP.ResolveICall<TriggerUpdate_InjectedDelegate>("UnityEngine.CustomRenderTexture::TriggerUpdate_Injected");
		TriggerInitialization_InjectedDelegateField = IL2CPP.ResolveICall<TriggerInitialization_InjectedDelegate>("UnityEngine.CustomRenderTexture::TriggerInitialization_Injected");
		ClearUpdateZones_InjectedDelegateField = IL2CPP.ResolveICall<ClearUpdateZones_InjectedDelegate>("UnityEngine.CustomRenderTexture::ClearUpdateZones_Injected");
		get_material_InjectedDelegateField = IL2CPP.ResolveICall<get_material_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_material_Injected");
		set_material_InjectedDelegateField = IL2CPP.ResolveICall<set_material_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_material_Injected");
		get_initializationMaterial_InjectedDelegateField = IL2CPP.ResolveICall<get_initializationMaterial_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationMaterial_Injected");
		set_initializationMaterial_InjectedDelegateField = IL2CPP.ResolveICall<set_initializationMaterial_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationMaterial_Injected");
		get_initializationTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_initializationTexture_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationTexture_Injected");
		set_initializationTexture_InjectedDelegateField = IL2CPP.ResolveICall<set_initializationTexture_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationTexture_Injected");
		GetUpdateZonesInternal_InjectedDelegateField = IL2CPP.ResolveICall<GetUpdateZonesInternal_InjectedDelegate>("UnityEngine.CustomRenderTexture::GetUpdateZonesInternal_Injected");
		SetUpdateZonesInternal_InjectedDelegateField = IL2CPP.ResolveICall<SetUpdateZonesInternal_InjectedDelegate>("UnityEngine.CustomRenderTexture::SetUpdateZonesInternal_Injected");
		GetDoubleBufferRenderTexture_InjectedDelegateField = IL2CPP.ResolveICall<GetDoubleBufferRenderTexture_InjectedDelegate>("UnityEngine.CustomRenderTexture::GetDoubleBufferRenderTexture_Injected");
		EnsureDoubleBufferConsistency_InjectedDelegateField = IL2CPP.ResolveICall<EnsureDoubleBufferConsistency_InjectedDelegate>("UnityEngine.CustomRenderTexture::EnsureDoubleBufferConsistency_Injected");
		get_initializationSource_InjectedDelegateField = IL2CPP.ResolveICall<get_initializationSource_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationSource_Injected");
		set_initializationSource_InjectedDelegateField = IL2CPP.ResolveICall<set_initializationSource_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationSource_Injected");
		get_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<get_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationColor_Injected");
		set_initializationColor_InjectedDelegateField = IL2CPP.ResolveICall<set_initializationColor_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationColor_Injected");
		get_updateMode_InjectedDelegateField = IL2CPP.ResolveICall<get_updateMode_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_updateMode_Injected");
		set_updateMode_InjectedDelegateField = IL2CPP.ResolveICall<set_updateMode_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_updateMode_Injected");
		get_initializationMode_InjectedDelegateField = IL2CPP.ResolveICall<get_initializationMode_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_initializationMode_Injected");
		set_initializationMode_InjectedDelegateField = IL2CPP.ResolveICall<set_initializationMode_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_initializationMode_Injected");
		get_updateZoneSpace_InjectedDelegateField = IL2CPP.ResolveICall<get_updateZoneSpace_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_updateZoneSpace_Injected");
		set_updateZoneSpace_InjectedDelegateField = IL2CPP.ResolveICall<set_updateZoneSpace_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_updateZoneSpace_Injected");
		get_shaderPass_InjectedDelegateField = IL2CPP.ResolveICall<get_shaderPass_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_shaderPass_Injected");
		set_shaderPass_InjectedDelegateField = IL2CPP.ResolveICall<set_shaderPass_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_shaderPass_Injected");
		get_cubemapFaceMask_InjectedDelegateField = IL2CPP.ResolveICall<get_cubemapFaceMask_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_cubemapFaceMask_Injected");
		set_cubemapFaceMask_InjectedDelegateField = IL2CPP.ResolveICall<set_cubemapFaceMask_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_cubemapFaceMask_Injected");
		get_doubleBuffered_InjectedDelegateField = IL2CPP.ResolveICall<get_doubleBuffered_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_doubleBuffered_Injected");
		set_doubleBuffered_InjectedDelegateField = IL2CPP.ResolveICall<set_doubleBuffered_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_doubleBuffered_Injected");
		get_wrapUpdateZones_InjectedDelegateField = IL2CPP.ResolveICall<get_wrapUpdateZones_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_wrapUpdateZones_Injected");
		set_wrapUpdateZones_InjectedDelegateField = IL2CPP.ResolveICall<set_wrapUpdateZones_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_wrapUpdateZones_Injected");
		get_updatePeriod_InjectedDelegateField = IL2CPP.ResolveICall<get_updatePeriod_InjectedDelegate>("UnityEngine.CustomRenderTexture::get_updatePeriod_Injected");
		set_updatePeriod_InjectedDelegateField = IL2CPP.ResolveICall<set_updatePeriod_InjectedDelegate>("UnityEngine.CustomRenderTexture::set_updatePeriod_Injected");
	}

	public CustomRenderTexture(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void Internal_CreateCustomRenderTexture(CustomRenderTexture rt)
	{
		Internal_CreateCustomRenderTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)rt));
	}

	public void TriggerUpdate(int count)
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		TriggerUpdate_Injected(intPtr, count);
	}

	public void Update(int count)
	{
		CustomRenderTextureManager.InvokeTriggerUpdate(this, count);
		TriggerUpdate(count);
	}

	public void Update()
	{
		Update(1);
	}

	public void TriggerInitialization()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		TriggerInitialization_Injected(intPtr);
	}

	public void Initialize()
	{
		TriggerInitialization();
		CustomRenderTextureManager.InvokeTriggerInitialize(this);
	}

	public void ClearUpdateZones()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		ClearUpdateZones_Injected(intPtr);
	}

	public void GetUpdateZonesInternal(Il2CppSystem.Object updateZones)
	{
		if (updateZones == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException(updateZones, "updateZones");
		}
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		GetUpdateZonesInternal_Injected(intPtr, updateZones);
	}

	public RenderTexture GetDoubleBufferRenderTexture()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		return Unmarshal.UnmarshalUnityObject<RenderTexture>(GetDoubleBufferRenderTexture_Injected(intPtr));
	}

	public void EnsureDoubleBufferConsistency()
	{
		System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (System.IntPtr)0)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
		}
		EnsureDoubleBufferConsistency_Injected(intPtr);
	}

	public static void TriggerUpdate_Injected(System.IntPtr _unity_self, int count)
	{
		TriggerUpdate_InjectedDelegateField(_unity_self, count);
	}

	public static void TriggerInitialization_Injected(System.IntPtr _unity_self)
	{
		TriggerInitialization_InjectedDelegateField(_unity_self);
	}

	public static void ClearUpdateZones_Injected(System.IntPtr _unity_self)
	{
		ClearUpdateZones_InjectedDelegateField(_unity_self);
	}

	public static System.IntPtr get_material_Injected(System.IntPtr _unity_self)
	{
		return get_material_InjectedDelegateField(_unity_self);
	}

	public static void set_material_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_material_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_initializationMaterial_Injected(System.IntPtr _unity_self)
	{
		return get_initializationMaterial_InjectedDelegateField(_unity_self);
	}

	public static void set_initializationMaterial_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_initializationMaterial_InjectedDelegateField(_unity_self, value);
	}

	public static System.IntPtr get_initializationTexture_Injected(System.IntPtr _unity_self)
	{
		return get_initializationTexture_InjectedDelegateField(_unity_self);
	}

	public static void set_initializationTexture_Injected(System.IntPtr _unity_self, System.IntPtr value)
	{
		set_initializationTexture_InjectedDelegateField(_unity_self, value);
	}

	public static void GetUpdateZonesInternal_Injected(System.IntPtr _unity_self, Il2CppSystem.Object updateZones)
	{
		GetUpdateZonesInternal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)updateZones));
	}

	public unsafe static void SetUpdateZonesInternal_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper updateZones)
	{
		SetUpdateZonesInternal_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref updateZones));
	}

	public static System.IntPtr GetDoubleBufferRenderTexture_Injected(System.IntPtr _unity_self)
	{
		return GetDoubleBufferRenderTexture_InjectedDelegateField(_unity_self);
	}

	public static void EnsureDoubleBufferConsistency_Injected(System.IntPtr _unity_self)
	{
		EnsureDoubleBufferConsistency_InjectedDelegateField(_unity_self);
	}

	public static CustomRenderTextureInitializationSource get_initializationSource_Injected(System.IntPtr _unity_self)
	{
		return get_initializationSource_InjectedDelegateField(_unity_self);
	}

	public static void set_initializationSource_Injected(System.IntPtr _unity_self, CustomRenderTextureInitializationSource value)
	{
		set_initializationSource_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_initializationColor_Injected(System.IntPtr _unity_self, out Color ret)
	{
		get_initializationColor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_initializationColor_Injected(System.IntPtr _unity_self, [In] ref Color value)
	{
		set_initializationColor_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static CustomRenderTextureUpdateMode get_updateMode_Injected(System.IntPtr _unity_self)
	{
		return get_updateMode_InjectedDelegateField(_unity_self);
	}

	public static void set_updateMode_Injected(System.IntPtr _unity_self, CustomRenderTextureUpdateMode value)
	{
		set_updateMode_InjectedDelegateField(_unity_self, value);
	}

	public static CustomRenderTextureUpdateMode get_initializationMode_Injected(System.IntPtr _unity_self)
	{
		return get_initializationMode_InjectedDelegateField(_unity_self);
	}

	public static void set_initializationMode_Injected(System.IntPtr _unity_self, CustomRenderTextureUpdateMode value)
	{
		set_initializationMode_InjectedDelegateField(_unity_self, value);
	}

	public static CustomRenderTextureUpdateZoneSpace get_updateZoneSpace_Injected(System.IntPtr _unity_self)
	{
		return get_updateZoneSpace_InjectedDelegateField(_unity_self);
	}

	public static void set_updateZoneSpace_Injected(System.IntPtr _unity_self, CustomRenderTextureUpdateZoneSpace value)
	{
		set_updateZoneSpace_InjectedDelegateField(_unity_self, value);
	}

	public static int get_shaderPass_Injected(System.IntPtr _unity_self)
	{
		return get_shaderPass_InjectedDelegateField(_unity_self);
	}

	public static void set_shaderPass_Injected(System.IntPtr _unity_self, int value)
	{
		set_shaderPass_InjectedDelegateField(_unity_self, value);
	}

	public static uint get_cubemapFaceMask_Injected(System.IntPtr _unity_self)
	{
		return get_cubemapFaceMask_InjectedDelegateField(_unity_self);
	}

	public static void set_cubemapFaceMask_Injected(System.IntPtr _unity_self, uint value)
	{
		set_cubemapFaceMask_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_doubleBuffered_Injected(System.IntPtr _unity_self)
	{
		return get_doubleBuffered_InjectedDelegateField(_unity_self);
	}

	public static void set_doubleBuffered_Injected(System.IntPtr _unity_self, bool value)
	{
		set_doubleBuffered_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_wrapUpdateZones_Injected(System.IntPtr _unity_self)
	{
		return get_wrapUpdateZones_InjectedDelegateField(_unity_self);
	}

	public static void set_wrapUpdateZones_Injected(System.IntPtr _unity_self, bool value)
	{
		set_wrapUpdateZones_InjectedDelegateField(_unity_self, value);
	}

	public static float get_updatePeriod_Injected(System.IntPtr _unity_self)
	{
		return get_updatePeriod_InjectedDelegateField(_unity_self);
	}

	public static void set_updatePeriod_Injected(System.IntPtr _unity_self, float value)
	{
		set_updatePeriod_InjectedDelegateField(_unity_self, value);
	}
}
