using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Tilemaps;

public sealed class TileAnimationData : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimatedSprites;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimationSpeed;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_AnimationStartTime;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;

	public unsafe Il2CppReferenceArray<Sprite> m_AnimatedSprites
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimatedSprites);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimatedSprites)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe float m_AnimationSpeed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimationSpeed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimationSpeed)) = value;
		}
	}

	public unsafe float m_AnimationStartTime
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimationStartTime);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_AnimationStartTime)) = value;
		}
	}

	public unsafe TileAnimationFlags m_Flags
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags);
			return *(TileAnimationFlags*)num;
		}
		set
		{
			*(TileAnimationFlags*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Flags)) = value;
		}
	}

	public Il2CppReferenceArray<Sprite> animatedSprites
	{
		get
		{
			return m_AnimatedSprites;
		}
		set
		{
			m_AnimatedSprites = value;
		}
	}

	public float animationSpeed
	{
		get
		{
			return m_AnimationSpeed;
		}
		set
		{
			m_AnimationSpeed = value;
		}
	}

	public float animationStartTime
	{
		get
		{
			return m_AnimationStartTime;
		}
		set
		{
			m_AnimationStartTime = value;
		}
	}

	public TileAnimationFlags flags
	{
		get
		{
			return m_Flags;
		}
		set
		{
			m_Flags = value;
		}
	}

	static TileAnimationData()
	{
		Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TilemapModule.dll", "UnityEngine.Tilemaps", "TileAnimationData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr);
		NativeFieldInfoPtr_m_AnimatedSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimatedSprites");
		NativeFieldInfoPtr_m_AnimationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimationSpeed");
		NativeFieldInfoPtr_m_AnimationStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_AnimationStartTime");
		NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr, "m_Flags");
	}

	public TileAnimationData(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public TileAnimationData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileAnimationData>.NativeClassPtr))
	{
	}
}
