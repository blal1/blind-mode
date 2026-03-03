using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class PhysicsMaterial2D : Object
{
	private delegate float GetCombinedValuesDelegate(float valueA, float valueB, PhysicsMaterialCombine2D materialCombineA, PhysicsMaterialCombine2D materialCombineB);

	private delegate void Create_Internal_InjectedDelegate(System.IntPtr scriptMaterial, System.IntPtr name);

	private delegate float get_bounciness_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bounciness_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate float get_friction_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_friction_InjectedDelegate(System.IntPtr _unity_self, float value);

	private delegate PhysicsMaterialCombine2D get_frictionCombine_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_frictionCombine_InjectedDelegate(System.IntPtr _unity_self, PhysicsMaterialCombine2D value);

	private delegate PhysicsMaterialCombine2D get_bounceCombine_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_bounceCombine_InjectedDelegate(System.IntPtr _unity_self, PhysicsMaterialCombine2D value);

	private static readonly GetCombinedValuesDelegate GetCombinedValuesDelegateField = IL2CPP.ResolveICall<GetCombinedValuesDelegate>("UnityEngine.PhysicsMaterial2D::GetCombinedValues");

	private static readonly Create_Internal_InjectedDelegate Create_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Create_Internal_InjectedDelegate>("UnityEngine.PhysicsMaterial2D::Create_Internal_Injected");

	private static readonly get_bounciness_InjectedDelegate get_bounciness_InjectedDelegateField = IL2CPP.ResolveICall<get_bounciness_InjectedDelegate>("UnityEngine.PhysicsMaterial2D::get_bounciness_Injected");

	private static readonly set_bounciness_InjectedDelegate set_bounciness_InjectedDelegateField = IL2CPP.ResolveICall<set_bounciness_InjectedDelegate>("UnityEngine.PhysicsMaterial2D::set_bounciness_Injected");

	private static readonly get_friction_InjectedDelegate get_friction_InjectedDelegateField = IL2CPP.ResolveICall<get_friction_InjectedDelegate>("UnityEngine.PhysicsMaterial2D::get_friction_Injected");

	private static readonly set_friction_InjectedDelegate set_friction_InjectedDelegateField = IL2CPP.ResolveICall<set_friction_InjectedDelegate>("UnityEngine.PhysicsMaterial2D::set_friction_Injected");

	private static readonly get_frictionCombine_InjectedDelegate get_frictionCombine_InjectedDelegateField = IL2CPP.ResolveICall<get_frictionCombine_InjectedDelegate>("UnityEngine.PhysicsMaterial2D::get_frictionCombine_Injected");

	private static readonly set_frictionCombine_InjectedDelegate set_frictionCombine_InjectedDelegateField = IL2CPP.ResolveICall<set_frictionCombine_InjectedDelegate>("UnityEngine.PhysicsMaterial2D::set_frictionCombine_Injected");

	private static readonly get_bounceCombine_InjectedDelegate get_bounceCombine_InjectedDelegateField = IL2CPP.ResolveICall<get_bounceCombine_InjectedDelegate>("UnityEngine.PhysicsMaterial2D::get_bounceCombine_Injected");

	private static readonly set_bounceCombine_InjectedDelegate set_bounceCombine_InjectedDelegateField = IL2CPP.ResolveICall<set_bounceCombine_InjectedDelegate>("UnityEngine.PhysicsMaterial2D::set_bounceCombine_Injected");

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

	public float friction
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_friction_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_friction_Injected(intPtr, value);
		}
	}

	public PhysicsMaterialCombine2D frictionCombine
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

	public PhysicsMaterialCombine2D bounceCombine
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

	public static float GetCombinedValues(float valueA, float valueB, PhysicsMaterialCombine2D materialCombineA, PhysicsMaterialCombine2D materialCombineB)
	{
		return GetCombinedValuesDelegateField(valueA, valueB, materialCombineA, materialCombineB);
	}

	public unsafe static void Create_Internal(PhysicsMaterial2D scriptMaterial, string name)
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
					Create_Internal_Injected(scriptMaterial, ref managedSpanWrapper);
					return;
				}
			}
			Create_Internal_Injected(scriptMaterial, ref managedSpanWrapper);
		}
		finally
		{
		}
	}

	public unsafe static void Create_Internal_Injected(PhysicsMaterial2D scriptMaterial, ref ManagedSpanWrapper name)
	{
		Create_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)scriptMaterial), (nint)Unsafe.AsPointer(ref name));
	}

	public static float get_bounciness_Injected(System.IntPtr _unity_self)
	{
		return get_bounciness_InjectedDelegateField(_unity_self);
	}

	public static void set_bounciness_Injected(System.IntPtr _unity_self, float value)
	{
		set_bounciness_InjectedDelegateField(_unity_self, value);
	}

	public static float get_friction_Injected(System.IntPtr _unity_self)
	{
		return get_friction_InjectedDelegateField(_unity_self);
	}

	public static void set_friction_Injected(System.IntPtr _unity_self, float value)
	{
		set_friction_InjectedDelegateField(_unity_self, value);
	}

	public static PhysicsMaterialCombine2D get_frictionCombine_Injected(System.IntPtr _unity_self)
	{
		return get_frictionCombine_InjectedDelegateField(_unity_self);
	}

	public static void set_frictionCombine_Injected(System.IntPtr _unity_self, PhysicsMaterialCombine2D value)
	{
		set_frictionCombine_InjectedDelegateField(_unity_self, value);
	}

	public static PhysicsMaterialCombine2D get_bounceCombine_Injected(System.IntPtr _unity_self)
	{
		return get_bounceCombine_InjectedDelegateField(_unity_self);
	}

	public static void set_bounceCombine_Injected(System.IntPtr _unity_self, PhysicsMaterialCombine2D value)
	{
		set_bounceCombine_InjectedDelegateField(_unity_self, value);
	}
}
