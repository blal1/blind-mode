using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public class SpeedTreeWindAsset : Object
{
	private delegate int get_Version_InjectedDelegate(System.IntPtr _unity_self);

	private delegate void set_Version_InjectedDelegate(System.IntPtr _unity_self, int value);

	private delegate void Internal_Create_InjectedDelegate(System.IntPtr notSelf, int version, System.IntPtr data);

	private static readonly get_Version_InjectedDelegate get_Version_InjectedDelegateField = IL2CPP.ResolveICall<get_Version_InjectedDelegate>("UnityEngine.SpeedTreeWindAsset::get_Version_Injected");

	private static readonly set_Version_InjectedDelegate set_Version_InjectedDelegateField = IL2CPP.ResolveICall<set_Version_InjectedDelegate>("UnityEngine.SpeedTreeWindAsset::set_Version_Injected");

	private static readonly Internal_Create_InjectedDelegate Internal_Create_InjectedDelegateField = IL2CPP.ResolveICall<Internal_Create_InjectedDelegate>("UnityEngine.SpeedTreeWindAsset::Internal_Create_Injected");

	public int Version
	{
		get
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			return get_Version_Injected(intPtr);
		}
		set
		{
			System.IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (System.IntPtr)0)
			{
				UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException(this);
			}
			set_Version_Injected(intPtr, value);
		}
	}

	public unsafe static void Internal_Create(SpeedTreeWindAsset notSelf, int version, Il2CppStructArray<byte> data)
	{
		//IL_000a: Expected O, but got Ref
		//IL_0011: Expected O, but got Ref
		//IL_001d: Expected O, but got Ref
		Unsafe.SkipInit(out Il2CppSystem.Span<byte> span);
		((Il2CppSystem.Span<byte>)(&span))._002Ector((Il2CppArrayBase<byte>)(object)data);
		fixed (byte* begin = &((Il2CppSystem.Span<byte>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper data2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<byte>)(&span)).Length);
			Internal_Create_Injected(notSelf, version, ref data2);
		}
	}

	public static int get_Version_Injected(System.IntPtr _unity_self)
	{
		return get_Version_InjectedDelegateField(_unity_self);
	}

	public static void set_Version_Injected(System.IntPtr _unity_self, int value)
	{
		set_Version_InjectedDelegateField(_unity_self, value);
	}

	public unsafe static void Internal_Create_Injected(SpeedTreeWindAsset notSelf, int version, ref ManagedSpanWrapper data)
	{
		Internal_Create_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)notSelf), version, (nint)Unsafe.AsPointer(ref data));
	}
}
