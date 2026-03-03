using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D.Animation;

public static class UpdateOrder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_spriteResolverUpdateOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_ikUpdateOrder;

	private static readonly System.IntPtr NativeFieldInfoPtr_spriteSkinUpdateOrder;

	public unsafe static int spriteResolverUpdateOrder
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_spriteResolverUpdateOrder, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_spriteResolverUpdateOrder, (void*)(&value));
		}
	}

	public unsafe static int ikUpdateOrder
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_ikUpdateOrder, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_ikUpdateOrder, (void*)(&value));
		}
	}

	public unsafe static int spriteSkinUpdateOrder
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_spriteSkinUpdateOrder, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_spriteSkinUpdateOrder, (void*)(&value));
		}
	}

	static UpdateOrder()
	{
		Il2CppClassPointerStore<UpdateOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "UpdateOrder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateOrder>.NativeClassPtr);
		NativeFieldInfoPtr_spriteResolverUpdateOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateOrder>.NativeClassPtr, "spriteResolverUpdateOrder");
		NativeFieldInfoPtr_ikUpdateOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateOrder>.NativeClassPtr, "ikUpdateOrder");
		NativeFieldInfoPtr_spriteSkinUpdateOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateOrder>.NativeClassPtr, "spriteSkinUpdateOrder");
	}

	public UpdateOrder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
