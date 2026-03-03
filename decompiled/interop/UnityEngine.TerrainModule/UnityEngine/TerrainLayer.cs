using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class TerrainLayer : Object
{
	private delegate void Internal_CreateDelegate(IntPtr layer);

	private delegate IntPtr get_diffuseTexture_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_diffuseTexture_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate IntPtr get_normalMapTexture_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_normalMapTexture_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate IntPtr get_maskMapTexture_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_maskMapTexture_InjectedDelegate(IntPtr _unity_self, IntPtr value);

	private delegate void get_tileSize_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_tileSize_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_tileOffset_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_tileOffset_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_specular_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_specular_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate float get_metallic_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_metallic_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_smoothness_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_smoothness_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate float get_normalScale_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_normalScale_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate void get_diffuseRemapMin_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_diffuseRemapMin_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_diffuseRemapMax_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_diffuseRemapMax_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_maskMapRemapMin_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_maskMapRemapMin_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate void get_maskMapRemapMax_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_maskMapRemapMax_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate TerrainLayerSmoothnessSource get_smoothnessSource_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_smoothnessSource_InjectedDelegate(IntPtr _unity_self, TerrainLayerSmoothnessSource value);

	private static readonly Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<Internal_CreateDelegate>("UnityEngine.TerrainLayer::Internal_Create");

	private static readonly get_diffuseTexture_InjectedDelegate get_diffuseTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_diffuseTexture_InjectedDelegate>("UnityEngine.TerrainLayer::get_diffuseTexture_Injected");

	private static readonly set_diffuseTexture_InjectedDelegate set_diffuseTexture_InjectedDelegateField = IL2CPP.ResolveICall<set_diffuseTexture_InjectedDelegate>("UnityEngine.TerrainLayer::set_diffuseTexture_Injected");

	private static readonly get_normalMapTexture_InjectedDelegate get_normalMapTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_normalMapTexture_InjectedDelegate>("UnityEngine.TerrainLayer::get_normalMapTexture_Injected");

	private static readonly set_normalMapTexture_InjectedDelegate set_normalMapTexture_InjectedDelegateField = IL2CPP.ResolveICall<set_normalMapTexture_InjectedDelegate>("UnityEngine.TerrainLayer::set_normalMapTexture_Injected");

	private static readonly get_maskMapTexture_InjectedDelegate get_maskMapTexture_InjectedDelegateField = IL2CPP.ResolveICall<get_maskMapTexture_InjectedDelegate>("UnityEngine.TerrainLayer::get_maskMapTexture_Injected");

	private static readonly set_maskMapTexture_InjectedDelegate set_maskMapTexture_InjectedDelegateField = IL2CPP.ResolveICall<set_maskMapTexture_InjectedDelegate>("UnityEngine.TerrainLayer::set_maskMapTexture_Injected");

	private static readonly get_tileSize_InjectedDelegate get_tileSize_InjectedDelegateField = IL2CPP.ResolveICall<get_tileSize_InjectedDelegate>("UnityEngine.TerrainLayer::get_tileSize_Injected");

	private static readonly set_tileSize_InjectedDelegate set_tileSize_InjectedDelegateField = IL2CPP.ResolveICall<set_tileSize_InjectedDelegate>("UnityEngine.TerrainLayer::set_tileSize_Injected");

	private static readonly get_tileOffset_InjectedDelegate get_tileOffset_InjectedDelegateField = IL2CPP.ResolveICall<get_tileOffset_InjectedDelegate>("UnityEngine.TerrainLayer::get_tileOffset_Injected");

	private static readonly set_tileOffset_InjectedDelegate set_tileOffset_InjectedDelegateField = IL2CPP.ResolveICall<set_tileOffset_InjectedDelegate>("UnityEngine.TerrainLayer::set_tileOffset_Injected");

	private static readonly get_specular_InjectedDelegate get_specular_InjectedDelegateField = IL2CPP.ResolveICall<get_specular_InjectedDelegate>("UnityEngine.TerrainLayer::get_specular_Injected");

	private static readonly set_specular_InjectedDelegate set_specular_InjectedDelegateField = IL2CPP.ResolveICall<set_specular_InjectedDelegate>("UnityEngine.TerrainLayer::set_specular_Injected");

	private static readonly get_metallic_InjectedDelegate get_metallic_InjectedDelegateField = IL2CPP.ResolveICall<get_metallic_InjectedDelegate>("UnityEngine.TerrainLayer::get_metallic_Injected");

	private static readonly set_metallic_InjectedDelegate set_metallic_InjectedDelegateField = IL2CPP.ResolveICall<set_metallic_InjectedDelegate>("UnityEngine.TerrainLayer::set_metallic_Injected");

	private static readonly get_smoothness_InjectedDelegate get_smoothness_InjectedDelegateField = IL2CPP.ResolveICall<get_smoothness_InjectedDelegate>("UnityEngine.TerrainLayer::get_smoothness_Injected");

	private static readonly set_smoothness_InjectedDelegate set_smoothness_InjectedDelegateField = IL2CPP.ResolveICall<set_smoothness_InjectedDelegate>("UnityEngine.TerrainLayer::set_smoothness_Injected");

	private static readonly get_normalScale_InjectedDelegate get_normalScale_InjectedDelegateField = IL2CPP.ResolveICall<get_normalScale_InjectedDelegate>("UnityEngine.TerrainLayer::get_normalScale_Injected");

	private static readonly set_normalScale_InjectedDelegate set_normalScale_InjectedDelegateField = IL2CPP.ResolveICall<set_normalScale_InjectedDelegate>("UnityEngine.TerrainLayer::set_normalScale_Injected");

	private static readonly get_diffuseRemapMin_InjectedDelegate get_diffuseRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<get_diffuseRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::get_diffuseRemapMin_Injected");

	private static readonly set_diffuseRemapMin_InjectedDelegate set_diffuseRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<set_diffuseRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::set_diffuseRemapMin_Injected");

	private static readonly get_diffuseRemapMax_InjectedDelegate get_diffuseRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<get_diffuseRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::get_diffuseRemapMax_Injected");

	private static readonly set_diffuseRemapMax_InjectedDelegate set_diffuseRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<set_diffuseRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::set_diffuseRemapMax_Injected");

	private static readonly get_maskMapRemapMin_InjectedDelegate get_maskMapRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<get_maskMapRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::get_maskMapRemapMin_Injected");

	private static readonly set_maskMapRemapMin_InjectedDelegate set_maskMapRemapMin_InjectedDelegateField = IL2CPP.ResolveICall<set_maskMapRemapMin_InjectedDelegate>("UnityEngine.TerrainLayer::set_maskMapRemapMin_Injected");

	private static readonly get_maskMapRemapMax_InjectedDelegate get_maskMapRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<get_maskMapRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::get_maskMapRemapMax_Injected");

	private static readonly set_maskMapRemapMax_InjectedDelegate set_maskMapRemapMax_InjectedDelegateField = IL2CPP.ResolveICall<set_maskMapRemapMax_InjectedDelegate>("UnityEngine.TerrainLayer::set_maskMapRemapMax_Injected");

	private static readonly get_smoothnessSource_InjectedDelegate get_smoothnessSource_InjectedDelegateField = IL2CPP.ResolveICall<get_smoothnessSource_InjectedDelegate>("UnityEngine.TerrainLayer::get_smoothnessSource_Injected");

	private static readonly set_smoothnessSource_InjectedDelegate set_smoothnessSource_InjectedDelegateField = IL2CPP.ResolveICall<set_smoothnessSource_InjectedDelegate>("UnityEngine.TerrainLayer::set_smoothnessSource_Injected");

	public Texture2D diffuseTexture
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Texture2D>(get_diffuseTexture_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_diffuseTexture_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Texture2D normalMapTexture
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Texture2D>(get_normalMapTexture_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_normalMapTexture_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Texture2D maskMapTexture
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return Unmarshal.UnmarshalUnityObject<Texture2D>(get_maskMapTexture_Injected(intPtr));
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maskMapTexture_Injected(intPtr, MarshalledUnityObject.Marshal(value));
		}
	}

	public Vector2 tileSize
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_tileSize_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_tileSize_Injected(intPtr, ref value);
		}
	}

	public Vector2 tileOffset
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_tileOffset_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_tileOffset_Injected(intPtr, ref value);
		}
	}

	public Color specular
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_specular_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_specular_Injected(intPtr, ref value);
		}
	}

	public float metallic
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_metallic_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_metallic_Injected(intPtr, value);
		}
	}

	public float smoothness
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_smoothness_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_smoothness_Injected(intPtr, value);
		}
	}

	public float normalScale
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_normalScale_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_normalScale_Injected(intPtr, value);
		}
	}

	public Vector4 diffuseRemapMin
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_diffuseRemapMin_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_diffuseRemapMin_Injected(intPtr, ref value);
		}
	}

	public Vector4 diffuseRemapMax
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_diffuseRemapMax_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_diffuseRemapMax_Injected(intPtr, ref value);
		}
	}

	public Vector4 maskMapRemapMin
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_maskMapRemapMin_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maskMapRemapMin_Injected(intPtr, ref value);
		}
	}

	public Vector4 maskMapRemapMax
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_maskMapRemapMax_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_maskMapRemapMax_Injected(intPtr, ref value);
		}
	}

	public TerrainLayerSmoothnessSource smoothnessSource
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_smoothnessSource_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_smoothnessSource_Injected(intPtr, value);
		}
	}

	public static void Internal_Create(TerrainLayer layer)
	{
		Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)layer));
	}

	public static IntPtr get_diffuseTexture_Injected(IntPtr _unity_self)
	{
		return get_diffuseTexture_InjectedDelegateField(_unity_self);
	}

	public static void set_diffuseTexture_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_diffuseTexture_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr get_normalMapTexture_Injected(IntPtr _unity_self)
	{
		return get_normalMapTexture_InjectedDelegateField(_unity_self);
	}

	public static void set_normalMapTexture_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_normalMapTexture_InjectedDelegateField(_unity_self, value);
	}

	public static IntPtr get_maskMapTexture_Injected(IntPtr _unity_self)
	{
		return get_maskMapTexture_InjectedDelegateField(_unity_self);
	}

	public static void set_maskMapTexture_Injected(IntPtr _unity_self, IntPtr value)
	{
		set_maskMapTexture_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_tileSize_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_tileSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_tileSize_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_tileSize_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_tileOffset_Injected(IntPtr _unity_self, out Vector2 ret)
	{
		get_tileOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_tileOffset_Injected(IntPtr _unity_self, [In] ref Vector2 value)
	{
		set_tileOffset_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_specular_Injected(IntPtr _unity_self, out Color ret)
	{
		get_specular_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_specular_Injected(IntPtr _unity_self, [In] ref Color value)
	{
		set_specular_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_metallic_Injected(IntPtr _unity_self)
	{
		return get_metallic_InjectedDelegateField(_unity_self);
	}

	public static void set_metallic_Injected(IntPtr _unity_self, float value)
	{
		set_metallic_InjectedDelegateField(_unity_self, value);
	}

	public static float get_smoothness_Injected(IntPtr _unity_self)
	{
		return get_smoothness_InjectedDelegateField(_unity_self);
	}

	public static void set_smoothness_Injected(IntPtr _unity_self, float value)
	{
		set_smoothness_InjectedDelegateField(_unity_self, value);
	}

	public static float get_normalScale_Injected(IntPtr _unity_self)
	{
		return get_normalScale_InjectedDelegateField(_unity_self);
	}

	public static void set_normalScale_Injected(IntPtr _unity_self, float value)
	{
		set_normalScale_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void get_diffuseRemapMin_Injected(IntPtr _unity_self, out Vector4 ret)
	{
		get_diffuseRemapMin_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_diffuseRemapMin_Injected(IntPtr _unity_self, [In] ref Vector4 value)
	{
		set_diffuseRemapMin_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_diffuseRemapMax_Injected(IntPtr _unity_self, out Vector4 ret)
	{
		get_diffuseRemapMax_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_diffuseRemapMax_Injected(IntPtr _unity_self, [In] ref Vector4 value)
	{
		set_diffuseRemapMax_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_maskMapRemapMin_Injected(IntPtr _unity_self, out Vector4 ret)
	{
		get_maskMapRemapMin_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_maskMapRemapMin_Injected(IntPtr _unity_self, [In] ref Vector4 value)
	{
		set_maskMapRemapMin_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public unsafe static void get_maskMapRemapMax_Injected(IntPtr _unity_self, out Vector4 ret)
	{
		get_maskMapRemapMax_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_maskMapRemapMax_Injected(IntPtr _unity_self, [In] ref Vector4 value)
	{
		set_maskMapRemapMax_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static TerrainLayerSmoothnessSource get_smoothnessSource_Injected(IntPtr _unity_self)
	{
		return get_smoothnessSource_InjectedDelegateField(_unity_self);
	}

	public static void set_smoothnessSource_Injected(IntPtr _unity_self, TerrainLayerSmoothnessSource value)
	{
		set_smoothnessSource_InjectedDelegateField(_unity_self, value);
	}
}
