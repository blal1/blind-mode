using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

namespace UnityEngine;

public class LODGroup : Component
{
	private delegate float get_crossFadeAnimationDurationDelegate();

	private delegate void set_crossFadeAnimationDurationDelegate(float value);

	private delegate void get_localReferencePoint_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private delegate void set_localReferencePoint_InjectedDelegate(IntPtr _unity_self, [In] IntPtr value);

	private delegate float get_size_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_size_InjectedDelegate(IntPtr _unity_self, float value);

	private delegate int get_lodCount_InjectedDelegate(IntPtr _unity_self);

	private delegate bool get_lastLODBillboard_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_lastLODBillboard_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate LODFadeMode get_fadeMode_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_fadeMode_InjectedDelegate(IntPtr _unity_self, LODFadeMode value);

	private delegate bool get_animateCrossFading_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_animateCrossFading_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate bool get_enabled_InjectedDelegate(IntPtr _unity_self);

	private delegate void set_enabled_InjectedDelegate(IntPtr _unity_self, bool value);

	private delegate void RecalculateBounds_InjectedDelegate(IntPtr _unity_self);

	private delegate void ForceLOD_InjectedDelegate(IntPtr _unity_self, int index);

	private delegate void get_worldReferencePoint_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

	private static readonly get_crossFadeAnimationDurationDelegate get_crossFadeAnimationDurationDelegateField;

	private static readonly set_crossFadeAnimationDurationDelegate set_crossFadeAnimationDurationDelegateField;

	private static readonly get_localReferencePoint_InjectedDelegate get_localReferencePoint_InjectedDelegateField;

	private static readonly set_localReferencePoint_InjectedDelegate set_localReferencePoint_InjectedDelegateField;

	private static readonly get_size_InjectedDelegate get_size_InjectedDelegateField;

	private static readonly set_size_InjectedDelegate set_size_InjectedDelegateField;

	private static readonly get_lodCount_InjectedDelegate get_lodCount_InjectedDelegateField;

	private static readonly get_lastLODBillboard_InjectedDelegate get_lastLODBillboard_InjectedDelegateField;

	private static readonly set_lastLODBillboard_InjectedDelegate set_lastLODBillboard_InjectedDelegateField;

	private static readonly get_fadeMode_InjectedDelegate get_fadeMode_InjectedDelegateField;

	private static readonly set_fadeMode_InjectedDelegate set_fadeMode_InjectedDelegateField;

	private static readonly get_animateCrossFading_InjectedDelegate get_animateCrossFading_InjectedDelegateField;

	private static readonly set_animateCrossFading_InjectedDelegate set_animateCrossFading_InjectedDelegateField;

	private static readonly get_enabled_InjectedDelegate get_enabled_InjectedDelegateField;

	private static readonly set_enabled_InjectedDelegate set_enabled_InjectedDelegateField;

	private static readonly RecalculateBounds_InjectedDelegate RecalculateBounds_InjectedDelegateField;

	private static readonly ForceLOD_InjectedDelegate ForceLOD_InjectedDelegateField;

	private static readonly get_worldReferencePoint_InjectedDelegate get_worldReferencePoint_InjectedDelegateField;

	public Vector3 localReferencePoint
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_localReferencePoint_Injected(intPtr, out var ret);
			return ret;
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_localReferencePoint_Injected(intPtr, ref value);
		}
	}

	public float size
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_size_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_size_Injected(intPtr, value);
		}
	}

	public int lodCount
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_lodCount_Injected(intPtr);
		}
	}

	public bool lastLODBillboard
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_lastLODBillboard_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_lastLODBillboard_Injected(intPtr, value);
		}
	}

	public LODFadeMode fadeMode
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_fadeMode_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_fadeMode_Injected(intPtr, value);
		}
	}

	public bool animateCrossFading
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_animateCrossFading_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_animateCrossFading_Injected(intPtr, value);
		}
	}

	public bool enabled
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_enabled_Injected(intPtr);
		}
		set
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			set_enabled_Injected(intPtr, value);
		}
	}

	public static float crossFadeAnimationDuration
	{
		get
		{
			return get_crossFadeAnimationDurationDelegateField();
		}
		set
		{
			set_crossFadeAnimationDurationDelegateField(value);
		}
	}

	public Vector3 worldReferencePoint
	{
		get
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			get_worldReferencePoint_Injected(intPtr, out var ret);
			return ret;
		}
	}

	static LODGroup()
	{
		Il2CppClassPointerStore<LODGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "LODGroup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODGroup>.NativeClassPtr);
		get_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<get_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::get_crossFadeAnimationDuration");
		set_crossFadeAnimationDurationDelegateField = IL2CPP.ResolveICall<set_crossFadeAnimationDurationDelegate>("UnityEngine.LODGroup::set_crossFadeAnimationDuration");
		get_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<get_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_localReferencePoint_Injected");
		set_localReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<set_localReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::set_localReferencePoint_Injected");
		get_size_InjectedDelegateField = IL2CPP.ResolveICall<get_size_InjectedDelegate>("UnityEngine.LODGroup::get_size_Injected");
		set_size_InjectedDelegateField = IL2CPP.ResolveICall<set_size_InjectedDelegate>("UnityEngine.LODGroup::set_size_Injected");
		get_lodCount_InjectedDelegateField = IL2CPP.ResolveICall<get_lodCount_InjectedDelegate>("UnityEngine.LODGroup::get_lodCount_Injected");
		get_lastLODBillboard_InjectedDelegateField = IL2CPP.ResolveICall<get_lastLODBillboard_InjectedDelegate>("UnityEngine.LODGroup::get_lastLODBillboard_Injected");
		set_lastLODBillboard_InjectedDelegateField = IL2CPP.ResolveICall<set_lastLODBillboard_InjectedDelegate>("UnityEngine.LODGroup::set_lastLODBillboard_Injected");
		get_fadeMode_InjectedDelegateField = IL2CPP.ResolveICall<get_fadeMode_InjectedDelegate>("UnityEngine.LODGroup::get_fadeMode_Injected");
		set_fadeMode_InjectedDelegateField = IL2CPP.ResolveICall<set_fadeMode_InjectedDelegate>("UnityEngine.LODGroup::set_fadeMode_Injected");
		get_animateCrossFading_InjectedDelegateField = IL2CPP.ResolveICall<get_animateCrossFading_InjectedDelegate>("UnityEngine.LODGroup::get_animateCrossFading_Injected");
		set_animateCrossFading_InjectedDelegateField = IL2CPP.ResolveICall<set_animateCrossFading_InjectedDelegate>("UnityEngine.LODGroup::set_animateCrossFading_Injected");
		get_enabled_InjectedDelegateField = IL2CPP.ResolveICall<get_enabled_InjectedDelegate>("UnityEngine.LODGroup::get_enabled_Injected");
		set_enabled_InjectedDelegateField = IL2CPP.ResolveICall<set_enabled_InjectedDelegate>("UnityEngine.LODGroup::set_enabled_Injected");
		RecalculateBounds_InjectedDelegateField = IL2CPP.ResolveICall<RecalculateBounds_InjectedDelegate>("UnityEngine.LODGroup::RecalculateBounds_Injected");
		ForceLOD_InjectedDelegateField = IL2CPP.ResolveICall<ForceLOD_InjectedDelegate>("UnityEngine.LODGroup::ForceLOD_Injected");
		get_worldReferencePoint_InjectedDelegateField = IL2CPP.ResolveICall<get_worldReferencePoint_InjectedDelegate>("UnityEngine.LODGroup::get_worldReferencePoint_Injected");
	}

	public LODGroup(IntPtr pointer)
		: base(pointer)
	{
	}

	public void RecalculateBounds()
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		RecalculateBounds_Injected(intPtr);
	}

	public void ForceLOD(int index)
	{
		IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
		if (intPtr == (IntPtr)0)
		{
			ThrowHelper.ThrowNullReferenceException(this);
		}
		ForceLOD_Injected(intPtr, index);
	}

	public unsafe static void get_localReferencePoint_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_localReferencePoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void set_localReferencePoint_Injected(IntPtr _unity_self, [In] ref Vector3 value)
	{
		set_localReferencePoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref value));
	}

	public static float get_size_Injected(IntPtr _unity_self)
	{
		return get_size_InjectedDelegateField(_unity_self);
	}

	public static void set_size_Injected(IntPtr _unity_self, float value)
	{
		set_size_InjectedDelegateField(_unity_self, value);
	}

	public static int get_lodCount_Injected(IntPtr _unity_self)
	{
		return get_lodCount_InjectedDelegateField(_unity_self);
	}

	public static bool get_lastLODBillboard_Injected(IntPtr _unity_self)
	{
		return get_lastLODBillboard_InjectedDelegateField(_unity_self);
	}

	public static void set_lastLODBillboard_Injected(IntPtr _unity_self, bool value)
	{
		set_lastLODBillboard_InjectedDelegateField(_unity_self, value);
	}

	public static LODFadeMode get_fadeMode_Injected(IntPtr _unity_self)
	{
		return get_fadeMode_InjectedDelegateField(_unity_self);
	}

	public static void set_fadeMode_Injected(IntPtr _unity_self, LODFadeMode value)
	{
		set_fadeMode_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_animateCrossFading_Injected(IntPtr _unity_self)
	{
		return get_animateCrossFading_InjectedDelegateField(_unity_self);
	}

	public static void set_animateCrossFading_Injected(IntPtr _unity_self, bool value)
	{
		set_animateCrossFading_InjectedDelegateField(_unity_self, value);
	}

	public static bool get_enabled_Injected(IntPtr _unity_self)
	{
		return get_enabled_InjectedDelegateField(_unity_self);
	}

	public static void set_enabled_Injected(IntPtr _unity_self, bool value)
	{
		set_enabled_InjectedDelegateField(_unity_self, value);
	}

	public static void RecalculateBounds_Injected(IntPtr _unity_self)
	{
		RecalculateBounds_InjectedDelegateField(_unity_self);
	}

	public static void ForceLOD_Injected(IntPtr _unity_self, int index)
	{
		ForceLOD_InjectedDelegateField(_unity_self, index);
	}

	public unsafe static void get_worldReferencePoint_Injected(IntPtr _unity_self, out Vector3 ret)
	{
		get_worldReferencePoint_InjectedDelegateField(_unity_self, (nint)Unsafe.AsPointer(ref ret));
	}
}
