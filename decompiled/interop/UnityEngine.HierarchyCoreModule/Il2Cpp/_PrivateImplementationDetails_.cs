using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2Cpp;

[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_ : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=6")]
	public struct ValueTypeNPrivateSealedUnique
	{
		static ValueTypeNPrivateSealedUnique()
		{
			Il2CppClassPointerStore<ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=6");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTypeNPrivateSealedUnique>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct __StaticArrayInitTypeSize_003D6
	{
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_E09F1B9774E7BD16FF4AA0F427CA8BA3FE2FCD832454BB60E741311C9CBB2F43;

	public unsafe static ValueTypeNPrivateSealedUnique E09F1B9774E7BD16FF4AA0F427CA8BA3FE2FCD832454BB60E741311C9CBB2F43
	{
		get
		{
			Unsafe.SkipInit(out ValueTypeNPrivateSealedUnique result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_E09F1B9774E7BD16FF4AA0F427CA8BA3FE2FCD832454BB60E741311C9CBB2F43, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_E09F1B9774E7BD16FF4AA0F427CA8BA3FE2FCD832454BB60E741311C9CBB2F43, (void*)(&value));
		}
	}

	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.HierarchyCoreModule.dll", "", "<PrivateImplementationDetails>");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr);
		NativeFieldInfoPtr_E09F1B9774E7BD16FF4AA0F427CA8BA3FE2FCD832454BB60E741311C9CBB2F43 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "E09F1B9774E7BD16FF4AA0F427CA8BA3FE2FCD832454BB60E741311C9CBB2F43");
	}

	public _PrivateImplementationDetails_(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static uint ComputeStringHash(string s)
	{
		Unsafe.SkipInit(out uint num);
		if (s != null)
		{
			num = 2166136261u;
			for (int i = 0; i < s.Length; i++)
			{
				num = (s[i] ^ num) * 16777619;
			}
		}
		return num;
	}
}
