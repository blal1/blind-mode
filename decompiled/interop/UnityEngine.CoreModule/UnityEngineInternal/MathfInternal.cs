using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngineInternal;

[StructLayout(LayoutKind.Explicit)]
public struct MathfInternal
{
	private static readonly System.IntPtr NativeFieldInfoPtr_FloatMinNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_FloatMinDenormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_IsFlushToZeroEnabled;

	public unsafe static float FloatMinNormal
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FloatMinNormal, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FloatMinNormal, (void*)(&value));
		}
	}

	public unsafe static float FloatMinDenormal
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FloatMinDenormal, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FloatMinDenormal, (void*)(&value));
		}
	}

	public unsafe static bool IsFlushToZeroEnabled
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IsFlushToZeroEnabled, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IsFlushToZeroEnabled, (void*)(&value));
		}
	}

	static MathfInternal()
	{
		Il2CppClassPointerStore<MathfInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", "MathfInternal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr);
		NativeFieldInfoPtr_FloatMinNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, "FloatMinNormal");
		NativeFieldInfoPtr_FloatMinDenormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, "FloatMinDenormal");
		NativeFieldInfoPtr_IsFlushToZeroEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, "IsFlushToZeroEnabled");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
