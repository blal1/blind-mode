using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class PhysicsMaterial : Object
{
	private delegate void Internal_CreateDynamicsMaterial_InjectedDelegate(System.IntPtr mat, System.IntPtr name);

	private delegate float get_bounciness_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bounciness_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_dynamicFriction_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_dynamicFriction_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_staticFriction_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_staticFriction_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate PhysicsMaterialCombine get_frictionCombine_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_frictionCombine_InjectedDelegate(System.IntPtr _unity_self, PhysicsMaterialCombine value);

	private delegate PhysicsMaterialCombine get_bounceCombine_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bounceCombine_InjectedDelegate(System.IntPtr _unity_self, PhysicsMaterialCombine value);

	private static readonly Internal_CreateDynamicsMaterial_InjectedDelegate Internal_CreateDynamicsMaterial_InjectedDelegateField = IL2CPP.ResolveICall<Internal_CreateDynamicsMaterial_InjectedDelegate>("UnityEngine.PhysicsMaterial::Internal_CreateDynamicsMaterial_Injected");

	private static readonly get_bounciness_InjectedDelegate get_bounciness_InjectedDelegateField = IL2CPP.ResolveICall<get_bounciness_InjectedDelegate>("UnityEngine.PhysicsMaterial::get_bounciness_Injected");

	private static readonly set_bounciness_InjectedDelegate set_bounciness_InjectedDelegateField = IL2CPP.ResolveICall<set_bounciness_InjectedDelegate>("UnityEngine.PhysicsMaterial::set_bounciness_Injected");

	private static readonly get_dynamicFriction_InjectedDelegate get_dynamicFriction_InjectedDelegateField = IL2CPP.ResolveICall<get_dynamicFriction_InjectedDelegate>("UnityEngine.PhysicsMaterial::get_dynamicFriction_Injected");

	private static readonly set_dynamicFriction_InjectedDelegate set_dynamicFriction_InjectedDelegateField = IL2CPP.ResolveICall<set_dynamicFriction_InjectedDelegate>("UnityEngine.PhysicsMaterial::set_dynamicFriction_Injected");

	private static readonly get_staticFriction_InjectedDelegate get_staticFriction_InjectedDelegateField = IL2CPP.ResolveICall<get_staticFriction_InjectedDelegate>("UnityEngine.PhysicsMaterial::get_staticFriction_Injected");

	private static readonly set_staticFriction_InjectedDelegate set_staticFriction_InjectedDelegateField = IL2CPP.ResolveICall<set_staticFriction_InjectedDelegate>("UnityEngine.PhysicsMaterial::set_staticFriction_Injected");

	private static readonly get_frictionCombine_InjectedDelegate get_frictionCombine_InjectedDelegateField = IL2CPP.ResolveICall<get_frictionCombine_InjectedDelegate>("UnityEngine.PhysicsMaterial::get_frictionCombine_Injected");

	private static readonly set_frictionCombine_InjectedDelegate set_frictionCombine_InjectedDelegateField = IL2CPP.ResolveICall<set_frictionCombine_InjectedDelegate>("UnityEngine.PhysicsMaterial::set_frictionCombine_Injected");

	private static readonly get_bounceCombine_InjectedDelegate get_bounceCombine_InjectedDelegateField = IL2CPP.ResolveICall<get_bounceCombine_InjectedDelegate>("UnityEngine.PhysicsMaterial::get_bounceCombine_Injected");

	private static readonly set_bounceCombine_InjectedDelegate set_bounceCombine_InjectedDelegateField = IL2CPP.ResolveICall<set_bounceCombine_InjectedDelegate>("UnityEngine.PhysicsMaterial::set_bounceCombine_Injected");

	public float bounciness
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bounciness_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bounciness_Injected(intPtr, value);
		}
	}

	public float dynamicFriction
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_dynamicFriction_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_dynamicFriction_Injected(intPtr, value);
		}
	}

	public float staticFriction
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_staticFriction_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_staticFriction_Injected(intPtr, value);
		}
	}

	public PhysicsMaterialCombine frictionCombine
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_frictionCombine_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_frictionCombine_Injected(intPtr, value);
		}
	}

	public PhysicsMaterialCombine bounceCombine
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_bounceCombine_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_bounceCombine_Injected(intPtr, value);
		}
	}

	public unsafe static void Internal_CreateDynamicsMaterial(PhysicsMaterial mat, string name)
	{
		//IL_0019: Expected O, but got Ref
		//IL_0025: Expected O, but got Ref
		//The blocks IL_002a are reachable both inside and outside the pinned region starting at IL_0019. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		try
		{
			Unsafe.SkipInit(out ManagedSpanWrapper managedSpanWrapper);
			if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
			{
				Il2CppSystem.ReadOnlySpan<char> readOnlySpan = Il2CppSystem.MemoryExtensions.AsSpan(name);
				fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).GetPinnableReference())
				{
					managedSpanWrapper = new ManagedSpanWrapper(begin, ((Il2CppSystem.ReadOnlySpan<char>)(&readOnlySpan)).Length);
					Internal_CreateDynamicsMaterial_Injected(mat, ref managedSpanWrapper);
					return;
				}
			}
			Internal_CreateDynamicsMaterial_Injected(mat, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void Internal_CreateDynamicsMaterial_Injected(PhysicsMaterial mat, ref ManagedSpanWrapper name)
	{
		Internal_CreateDynamicsMaterial_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)mat), (nint)Unsafe.AsPointer(ref name));
	}

	public static float get_bounciness_Injected(System.IntPtr _unity_self)
	{
		return get_bounciness_InjectedDelegateField(_unity_self);
	}

	public static void set_bounciness_Injected(System.IntPtr _unity_self, float value)
	{
		set_bounciness_InjectedDelegateField(_unity_self, value);
	}

	public static float get_dynamicFriction_Injected(System.IntPtr _unity_self)
	{
		return get_dynamicFriction_InjectedDelegateField(_unity_self);
	}

	public static void set_dynamicFriction_Injected(System.IntPtr _unity_self, float value)
	{
		set_dynamicFriction_InjectedDelegateField(_unity_self, value);
	}

	public static float get_staticFriction_Injected(System.IntPtr _unity_self)
	{
		return get_staticFriction_InjectedDelegateField(_unity_self);
	}

	public static void set_staticFriction_Injected(System.IntPtr _unity_self, float value)
	{
		set_staticFriction_InjectedDelegateField(_unity_self, value);
	}

	public static PhysicsMaterialCombine get_frictionCombine_Injected(System.IntPtr _unity_self)
	{
		return get_frictionCombine_InjectedDelegateField(_unity_self);
	}

	public static void set_frictionCombine_Injected(System.IntPtr _unity_self, PhysicsMaterialCombine value)
	{
		set_frictionCombine_InjectedDelegateField(_unity_self, value);
	}

	public static PhysicsMaterialCombine get_bounceCombine_Injected(System.IntPtr _unity_self)
	{
		return get_bounceCombine_InjectedDelegateField(_unity_self);
	}

	public static void set_bounceCombine_Injected(System.IntPtr _unity_self, PhysicsMaterialCombine value)
	{
		set_bounceCombine_InjectedDelegateField(_unity_self, value);
	}
}
