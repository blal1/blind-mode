using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2Cpp;

public class ParticleSwirl_twist : MonoBehaviour
{
	public class ParticleInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_particle_life;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_start_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_range;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_rotation_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_rotation_y;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_rotation_z;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_twist_rotation;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		public unsafe float particle_life
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_life);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_life)) = value;
			}
		}

		public unsafe float particle_start_pos
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_start_pos);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_start_pos)) = value;
			}
		}

		public unsafe float particle_range
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_range);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_range)) = value;
			}
		}

		public unsafe float particle_rotation_x
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_rotation_x);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_rotation_x)) = value;
			}
		}

		public unsafe float particle_rotation_y
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_rotation_y);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_rotation_y)) = value;
			}
		}

		public unsafe float particle_rotation_z
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_rotation_z);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_rotation_z)) = value;
			}
		}

		public unsafe float particle_twist_rotation
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_twist_rotation);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_twist_rotation)) = value;
			}
		}

		static ParticleInfo()
		{
			Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "ParticleInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr);
			NativeFieldInfoPtr_particle_life = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_life");
			NativeFieldInfoPtr_particle_start_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_start_pos");
			NativeFieldInfoPtr_particle_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_range");
			NativeFieldInfoPtr_particle_rotation_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_rotation_x");
			NativeFieldInfoPtr_particle_rotation_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_rotation_y");
			NativeFieldInfoPtr_particle_rotation_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_rotation_z");
			NativeFieldInfoPtr_particle_twist_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_twist_rotation");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, 100664141);
		}

		[CallerCount(1950)]
		[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParticleInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public ParticleInfo(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_pe;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_total;

	private static readonly System.IntPtr NativeFieldInfoPtr_start_particle_total;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_appearance_interval;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_appear_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_appear_radius_max;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_thick;

	private static readonly System.IntPtr NativeFieldInfoPtr_appear_spread_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_appear_spread_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_3D_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_converge_radius_spread_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_converge_radius_spread_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_converge_radius_max;

	private static readonly System.IntPtr NativeFieldInfoPtr_anlgle_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_anlgle_accel;

	private static readonly System.IntPtr NativeFieldInfoPtr_anlgle_max_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_circle_decrease_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_num;

	private static readonly System.IntPtr NativeFieldInfoPtr_numParticlesAlive;

	private static readonly System.IntPtr NativeFieldInfoPtr_base_particle_angle;

	private static readonly System.IntPtr NativeFieldInfoPtr_particule_appearance_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_converge_radius;

	private static readonly System.IntPtr NativeFieldInfoPtr_base_particle_twist_angle;

	private static readonly System.IntPtr NativeFieldInfoPtr_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_cut_num;

	private static readonly System.IntPtr NativeFieldInfoPtr_cut_total;

	private static readonly System.IntPtr NativeFieldInfoPtr_particleInfos;

	private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_particle_ini_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_particle_move_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe ParticleSystem pe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pe);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_pe)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<ParticleSystem.Particle> particle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<ParticleSystem.Particle>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int particle_total
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_total);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_total)) = value;
		}
	}

	public unsafe int start_particle_total
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start_particle_total);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_start_particle_total)) = value;
		}
	}

	public unsafe float particle_appearance_interval
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_appearance_interval);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_appearance_interval)) = value;
		}
	}

	public unsafe float particle_appear_radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_appear_radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_appear_radius)) = value;
		}
	}

	public unsafe float particle_appear_radius_max
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_appear_radius_max);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_appear_radius_max)) = value;
		}
	}

	public unsafe float particle_thick
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_thick);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_thick)) = value;
		}
	}

	public unsafe float appear_spread_time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appear_spread_time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appear_spread_time)) = value;
		}
	}

	public unsafe float appear_spread_speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appear_spread_speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_appear_spread_speed)) = value;
		}
	}

	public unsafe bool particle_3D_rotation
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_3D_rotation);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_3D_rotation)) = value;
		}
	}

	public unsafe float converge_radius_spread_time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converge_radius_spread_time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converge_radius_spread_time)) = value;
		}
	}

	public unsafe float converge_radius_spread_speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converge_radius_spread_speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converge_radius_spread_speed)) = value;
		}
	}

	public unsafe float converge_radius_max
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converge_radius_max);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converge_radius_max)) = value;
		}
	}

	public unsafe float anlgle_speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anlgle_speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anlgle_speed)) = value;
		}
	}

	public unsafe float anlgle_accel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anlgle_accel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anlgle_accel)) = value;
		}
	}

	public unsafe float anlgle_max_speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anlgle_max_speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_anlgle_max_speed)) = value;
		}
	}

	public unsafe float circle_decrease_speed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_circle_decrease_speed);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_circle_decrease_speed)) = value;
		}
	}

	public unsafe int particle_num
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_num);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_num)) = value;
		}
	}

	public unsafe int numParticlesAlive
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numParticlesAlive);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_numParticlesAlive)) = value;
		}
	}

	public unsafe float base_particle_angle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_base_particle_angle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_base_particle_angle)) = value;
		}
	}

	public unsafe float particule_appearance_time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particule_appearance_time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particule_appearance_time)) = value;
		}
	}

	public unsafe float converge_radius
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converge_radius);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_converge_radius)) = value;
		}
	}

	public unsafe float base_particle_twist_angle
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_base_particle_twist_angle);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_base_particle_twist_angle)) = value;
		}
	}

	public unsafe float time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_time)) = value;
		}
	}

	public unsafe int cut_num
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cut_num);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cut_num)) = value;
		}
	}

	public unsafe int cut_total
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cut_total);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cut_total)) = value;
		}
	}

	public unsafe List<ParticleInfo> particleInfos
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleInfos);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<ParticleInfo>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particleInfos)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ParticleSwirl_twist()
	{
		Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ParticleSwirl_twist");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr);
		NativeFieldInfoPtr_pe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "pe");
		NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "particle");
		NativeFieldInfoPtr_particle_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "particle_total");
		NativeFieldInfoPtr_start_particle_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "start_particle_total");
		NativeFieldInfoPtr_particle_appearance_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "particle_appearance_interval");
		NativeFieldInfoPtr_particle_appear_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "particle_appear_radius");
		NativeFieldInfoPtr_particle_appear_radius_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "particle_appear_radius_max");
		NativeFieldInfoPtr_particle_thick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "particle_thick");
		NativeFieldInfoPtr_appear_spread_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "appear_spread_time");
		NativeFieldInfoPtr_appear_spread_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "appear_spread_speed");
		NativeFieldInfoPtr_particle_3D_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "particle_3D_rotation");
		NativeFieldInfoPtr_converge_radius_spread_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "converge_radius_spread_time");
		NativeFieldInfoPtr_converge_radius_spread_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "converge_radius_spread_speed");
		NativeFieldInfoPtr_converge_radius_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "converge_radius_max");
		NativeFieldInfoPtr_anlgle_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "anlgle_speed");
		NativeFieldInfoPtr_anlgle_accel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "anlgle_accel");
		NativeFieldInfoPtr_anlgle_max_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "anlgle_max_speed");
		NativeFieldInfoPtr_circle_decrease_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "circle_decrease_speed");
		NativeFieldInfoPtr_particle_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "particle_num");
		NativeFieldInfoPtr_numParticlesAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "numParticlesAlive");
		NativeFieldInfoPtr_base_particle_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "base_particle_angle");
		NativeFieldInfoPtr_particule_appearance_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "particule_appearance_time");
		NativeFieldInfoPtr_converge_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "converge_radius");
		NativeFieldInfoPtr_base_particle_twist_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "base_particle_twist_angle");
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "time");
		NativeFieldInfoPtr_cut_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "cut_num");
		NativeFieldInfoPtr_cut_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "cut_total");
		NativeFieldInfoPtr_particleInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, "particleInfos");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, 100664136);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, 100664137);
		NativeMethodInfoPtr_particle_ini_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, 100664138);
		NativeMethodInfoPtr_particle_move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, 100664139);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr, 100664140);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39452, XrefRangeEnd = 39465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39465, XrefRangeEnd = 39481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 39496, RefRangeEnd = 39498, XrefRangeStart = 39481, XrefRangeEnd = 39496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void particle_ini()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_particle_ini_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 39527, RefRangeEnd = 39529, XrefRangeStart = 39498, XrefRangeEnd = 39527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void particle_move()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_particle_move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39529, XrefRangeEnd = 39537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ParticleSwirl_twist()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleSwirl_twist>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ParticleSwirl_twist(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
