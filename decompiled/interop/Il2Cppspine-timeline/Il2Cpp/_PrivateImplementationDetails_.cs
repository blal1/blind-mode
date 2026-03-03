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
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=604")]
	public struct ValueTypeNPrivateSealed0
	{
		static ValueTypeNPrivateSealed0()
		{
			Il2CppClassPointerStore<ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=604");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTypeNPrivateSealed0>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=1649")]
	public struct ValueTypeNPrivateSealed1
	{
		static ValueTypeNPrivateSealed1()
		{
			Il2CppClassPointerStore<ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=1649");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTypeNPrivateSealed1>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_D00466D2BB470771AFDAED9771B343706F4A6F880B2F74B15854B2D9DED46F49;

	private static readonly System.IntPtr NativeFieldInfoPtr_E82D6A23AE5DDA16955206E6252A2A1D74B7FA4F934B342DC4614C5960B975DE;

	public unsafe static ValueTypeNPrivateSealed1 D00466D2BB470771AFDAED9771B343706F4A6F880B2F74B15854B2D9DED46F49
	{
		get
		{
			Unsafe.SkipInit(out ValueTypeNPrivateSealed1 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_D00466D2BB470771AFDAED9771B343706F4A6F880B2F74B15854B2D9DED46F49, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_D00466D2BB470771AFDAED9771B343706F4A6F880B2F74B15854B2D9DED46F49, (void*)(&value));
		}
	}

	public unsafe static ValueTypeNPrivateSealed0 E82D6A23AE5DDA16955206E6252A2A1D74B7FA4F934B342DC4614C5960B975DE
	{
		get
		{
			Unsafe.SkipInit(out ValueTypeNPrivateSealed0 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_E82D6A23AE5DDA16955206E6252A2A1D74B7FA4F934B342DC4614C5960B975DE, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_E82D6A23AE5DDA16955206E6252A2A1D74B7FA4F934B342DC4614C5960B975DE, (void*)(&value));
		}
	}

	static _PrivateImplementationDetails_()
	{
		Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-timeline.dll", "", "<PrivateImplementationDetails>");
		NativeFieldInfoPtr_D00466D2BB470771AFDAED9771B343706F4A6F880B2F74B15854B2D9DED46F49 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "D00466D2BB470771AFDAED9771B343706F4A6F880B2F74B15854B2D9DED46F49");
		NativeFieldInfoPtr_E82D6A23AE5DDA16955206E6252A2A1D74B7FA4F934B342DC4614C5960B975DE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "E82D6A23AE5DDA16955206E6252A2A1D74B7FA4F934B342DC4614C5960B975DE");
	}

	public _PrivateImplementationDetails_(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
