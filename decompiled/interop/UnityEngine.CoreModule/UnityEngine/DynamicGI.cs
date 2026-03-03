using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine;

public sealed class DynamicGI
{
	private delegate float get_indirectScaleDelegate();

	private delegate void set_indirectScaleDelegate(float value);

	private delegate float get_updateThresholdDelegate();

	private delegate void set_updateThresholdDelegate(float value);

	private delegate int get_materialUpdateTimeSliceDelegate();

	private delegate void set_materialUpdateTimeSliceDelegate(int value);

	private delegate bool get_synchronousModeDelegate();

	private delegate void set_synchronousModeDelegate(bool value);

	private delegate bool get_isConvergedDelegate();

	private delegate int get_scheduledMaterialUpdatesCountDelegate();

	private delegate bool get_asyncMaterialUpdatesDelegate();

	private delegate void set_asyncMaterialUpdatesDelegate(bool value);

	private delegate void UpdateEnvironmentDelegate();

	private delegate void SetEmissive_InjectedDelegate(System.IntPtr renderer, [In] System.IntPtr color);

	private delegate void SetEnvironmentData_InjectedDelegate(System.IntPtr input);

	private static readonly get_indirectScaleDelegate get_indirectScaleDelegateField = IL2CPP.ResolveICall<get_indirectScaleDelegate>("UnityEngine.DynamicGI::get_indirectScale");

	private static readonly set_indirectScaleDelegate set_indirectScaleDelegateField = IL2CPP.ResolveICall<set_indirectScaleDelegate>("UnityEngine.DynamicGI::set_indirectScale");

	private static readonly get_updateThresholdDelegate get_updateThresholdDelegateField = IL2CPP.ResolveICall<get_updateThresholdDelegate>("UnityEngine.DynamicGI::get_updateThreshold");

	private static readonly set_updateThresholdDelegate set_updateThresholdDelegateField = IL2CPP.ResolveICall<set_updateThresholdDelegate>("UnityEngine.DynamicGI::set_updateThreshold");

	private static readonly get_materialUpdateTimeSliceDelegate get_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<get_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::get_materialUpdateTimeSlice");

	private static readonly set_materialUpdateTimeSliceDelegate set_materialUpdateTimeSliceDelegateField = IL2CPP.ResolveICall<set_materialUpdateTimeSliceDelegate>("UnityEngine.DynamicGI::set_materialUpdateTimeSlice");

	private static readonly get_synchronousModeDelegate get_synchronousModeDelegateField = IL2CPP.ResolveICall<get_synchronousModeDelegate>("UnityEngine.DynamicGI::get_synchronousMode");

	private static readonly set_synchronousModeDelegate set_synchronousModeDelegateField = IL2CPP.ResolveICall<set_synchronousModeDelegate>("UnityEngine.DynamicGI::set_synchronousMode");

	private static readonly get_isConvergedDelegate get_isConvergedDelegateField = IL2CPP.ResolveICall<get_isConvergedDelegate>("UnityEngine.DynamicGI::get_isConverged");

	private static readonly get_scheduledMaterialUpdatesCountDelegate get_scheduledMaterialUpdatesCountDelegateField = IL2CPP.ResolveICall<get_scheduledMaterialUpdatesCountDelegate>("UnityEngine.DynamicGI::get_scheduledMaterialUpdatesCount");

	private static readonly get_asyncMaterialUpdatesDelegate get_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<get_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::get_asyncMaterialUpdates");

	private static readonly set_asyncMaterialUpdatesDelegate set_asyncMaterialUpdatesDelegateField = IL2CPP.ResolveICall<set_asyncMaterialUpdatesDelegate>("UnityEngine.DynamicGI::set_asyncMaterialUpdates");

	private static readonly UpdateEnvironmentDelegate UpdateEnvironmentDelegateField = IL2CPP.ResolveICall<UpdateEnvironmentDelegate>("UnityEngine.DynamicGI::UpdateEnvironment");

	private static readonly SetEmissive_InjectedDelegate SetEmissive_InjectedDelegateField = IL2CPP.ResolveICall<SetEmissive_InjectedDelegate>("UnityEngine.DynamicGI::SetEmissive_Injected");

	private static readonly SetEnvironmentData_InjectedDelegate SetEnvironmentData_InjectedDelegateField = IL2CPP.ResolveICall<SetEnvironmentData_InjectedDelegate>("UnityEngine.DynamicGI::SetEnvironmentData_Injected");

	public static float indirectScale
	{
		get
		{
			return get_indirectScaleDelegateField();
		}
		set
		{
			set_indirectScaleDelegateField(value);
		}
	}

	public static float updateThreshold
	{
		get
		{
			return get_updateThresholdDelegateField();
		}
		set
		{
			set_updateThresholdDelegateField(value);
		}
	}

	public static int materialUpdateTimeSlice
	{
		get
		{
			return get_materialUpdateTimeSliceDelegateField();
		}
		set
		{
			set_materialUpdateTimeSliceDelegateField(value);
		}
	}

	public static bool synchronousMode
	{
		get
		{
			return get_synchronousModeDelegateField();
		}
		set
		{
			set_synchronousModeDelegateField(value);
		}
	}

	public static bool isConverged => get_isConvergedDelegateField();

	public static int scheduledMaterialUpdatesCount => get_scheduledMaterialUpdatesCountDelegateField();

	public static bool asyncMaterialUpdates
	{
		get
		{
			return get_asyncMaterialUpdatesDelegateField();
		}
		set
		{
			set_asyncMaterialUpdatesDelegateField(value);
		}
	}

	public static void SetEmissive(Renderer renderer, Color color)
	{
		SetEmissive_Injected(Object.MarshalledUnityObject.Marshal(renderer), ref color);
	}

	public unsafe static void SetEnvironmentData(Il2CppStructArray<float> input)
	{
		//IL_0017: Expected O, but got Ref
		//IL_001e: Expected O, but got Ref
		//IL_002a: Expected O, but got Ref
		if (input == null)
		{
			UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object)(object)input, "input");
		}
		Unsafe.SkipInit(out Il2CppSystem.Span<float> span);
		((Il2CppSystem.Span<float>)(&span))._002Ector((Il2CppArrayBase<float>)(object)input);
		fixed (float* begin = &((Il2CppSystem.Span<float>)(&span)).GetPinnableReference())
		{
			ManagedSpanWrapper input2 = new ManagedSpanWrapper(begin, ((Il2CppSystem.Span<float>)(&span)).Length);
			SetEnvironmentData_Injected(ref input2);
		}
	}

	public static void UpdateEnvironment()
	{
		UpdateEnvironmentDelegateField();
	}

	public static void UpdateMaterials(Renderer renderer)
	{
	}

	public static void UpdateMaterials(Object renderer)
	{
	}

	public static void UpdateMaterials(Object renderer, int x, int y, int width, int height)
	{
	}

	public unsafe static void SetEmissive_Injected(System.IntPtr renderer, [In] ref Color color)
	{
		SetEmissive_InjectedDelegateField(renderer, (nint)Unsafe.AsPointer(ref color));
	}

	public unsafe static void SetEnvironmentData_Injected(ref ManagedSpanWrapper input)
	{
		SetEnvironmentData_InjectedDelegateField((nint)Unsafe.AsPointer(ref input));
	}
}
