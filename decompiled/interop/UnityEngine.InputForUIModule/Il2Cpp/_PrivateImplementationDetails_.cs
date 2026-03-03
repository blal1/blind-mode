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
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=12")]
	public struct ValueTypeNPrivateSealedUnique
	{
		static ValueTypeNPrivateSealedUnique()
		{
			Il2CppClassPointerStore<ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=12");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTypeNPrivateSealedUnique>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct __StaticArrayInitTypeSize_003D12
	{
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137;

	public unsafe static ValueTypeNPrivateSealedUnique B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137
	{
		get
		{
			Unsafe.SkipInit(out ValueTypeNPrivateSealedUnique result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137, (void*)(&value));
		}
	}

	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputForUIModule.dll", "", "<PrivateImplementationDetails>");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr);
		NativeFieldInfoPtr_B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137");
	}

	public _PrivateImplementationDetails_(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
