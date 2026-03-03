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

public class FlowerTornado : MonoBehaviour
{
	public class ParticleInfo : Il2CppSystem.Object
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_particle_life;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_start_pos;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_revo_range;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_rotation_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_rotation_y;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_rotation_z;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_twist_rotation;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_dist;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_gravity;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_range;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_spread_speed;

		private static readonly System.IntPtr NativeFieldInfoPtr_particle_spread_accel;

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

		public unsafe float particle_revo_range
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_revo_range);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_revo_range)) = value;
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

		public unsafe float particle_dist
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_dist);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_dist)) = value;
			}
		}

		public unsafe float particle_gravity
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_gravity);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_gravity)) = value;
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

		public unsafe float particle_spread_speed
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_spread_speed);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_spread_speed)) = value;
			}
		}

		public unsafe float particle_spread_accel
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_spread_accel);
				return *(float*)num;
			}
			set
			{
				*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_spread_accel)) = value;
			}
		}

		static ParticleInfo()
		{
			Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "ParticleInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr);
			NativeFieldInfoPtr_particle_life = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_life");
			NativeFieldInfoPtr_particle_start_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_start_pos");
			NativeFieldInfoPtr_particle_revo_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_revo_range");
			NativeFieldInfoPtr_particle_rotation_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_rotation_x");
			NativeFieldInfoPtr_particle_rotation_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_rotation_y");
			NativeFieldInfoPtr_particle_rotation_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_rotation_z");
			NativeFieldInfoPtr_particle_twist_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_twist_rotation");
			NativeFieldInfoPtr_particle_dist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_dist");
			NativeFieldInfoPtr_particle_gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_gravity");
			NativeFieldInfoPtr_particle_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_range");
			NativeFieldInfoPtr_particle_spread_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_spread_speed");
			NativeFieldInfoPtr_particle_spread_accel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, "particle_spread_accel");
			NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleInfo>.NativeClassPtr, 100664124);
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

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_spread;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_radius_ellipse;

	private static readonly System.IntPtr NativeFieldInfoPtr_appear_spread_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_appear_spread_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_3D_rotation;

	private static readonly System.IntPtr NativeFieldInfoPtr_particle_distortion;

	private static readonly System.IntPtr NativeFieldInfoPtr_converge_radius_spread_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_converge_radius_spread_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_converge_radius_max;

	private static readonly System.IntPtr NativeFieldInfoPtr_anlgle_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_anlgle_accel;

	private static readonly System.IntPtr NativeFieldInfoPtr_anlgle_max_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_circle_decrease_speed;

	private static readonly System.IntPtr NativeFieldInfoPtr_add_particle_total;

	private static readonly System.IntPtr NativeFieldInfoPtr_add_particle_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_gravity_start;

	private static readonly System.IntPtr NativeFieldInfoPtr_gravity_accel;

	private static readonly System.IntPtr NativeFieldInfoPtr_gravity_float;

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

	public unsafe float particle_spread
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_spread);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_spread)) = value;
		}
	}

	public unsafe float particle_radius_ellipse
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_radius_ellipse);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_radius_ellipse)) = value;
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

	public unsafe float particle_distortion
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_distortion);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_particle_distortion)) = value;
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

	public unsafe int add_particle_total
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_add_particle_total);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_add_particle_total)) = value;
		}
	}

	public unsafe float add_particle_time
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_add_particle_time);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_add_particle_time)) = value;
		}
	}

	public unsafe float gravity_start
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gravity_start);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gravity_start)) = value;
		}
	}

	public unsafe float gravity_accel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gravity_accel);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gravity_accel)) = value;
		}
	}

	public unsafe float gravity_float
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gravity_float);
			return *(float*)num;
		}
		set
		{
			*(float*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_gravity_float)) = value;
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

	static FlowerTornado()
	{
		Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "FlowerTornado");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr);
		NativeFieldInfoPtr_pe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "pe");
		NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle");
		NativeFieldInfoPtr_particle_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle_total");
		NativeFieldInfoPtr_start_particle_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "start_particle_total");
		NativeFieldInfoPtr_particle_appearance_interval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle_appearance_interval");
		NativeFieldInfoPtr_particle_appear_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle_appear_radius");
		NativeFieldInfoPtr_particle_appear_radius_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle_appear_radius_max");
		NativeFieldInfoPtr_particle_thick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle_thick");
		NativeFieldInfoPtr_particle_spread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle_spread");
		NativeFieldInfoPtr_particle_radius_ellipse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle_radius_ellipse");
		NativeFieldInfoPtr_appear_spread_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "appear_spread_time");
		NativeFieldInfoPtr_appear_spread_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "appear_spread_speed");
		NativeFieldInfoPtr_particle_3D_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle_3D_rotation");
		NativeFieldInfoPtr_particle_distortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle_distortion");
		NativeFieldInfoPtr_converge_radius_spread_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "converge_radius_spread_time");
		NativeFieldInfoPtr_converge_radius_spread_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "converge_radius_spread_speed");
		NativeFieldInfoPtr_converge_radius_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "converge_radius_max");
		NativeFieldInfoPtr_anlgle_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "anlgle_speed");
		NativeFieldInfoPtr_anlgle_accel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "anlgle_accel");
		NativeFieldInfoPtr_anlgle_max_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "anlgle_max_speed");
		NativeFieldInfoPtr_circle_decrease_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "circle_decrease_speed");
		NativeFieldInfoPtr_add_particle_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "add_particle_total");
		NativeFieldInfoPtr_add_particle_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "add_particle_time");
		NativeFieldInfoPtr_gravity_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "gravity_start");
		NativeFieldInfoPtr_gravity_accel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "gravity_accel");
		NativeFieldInfoPtr_gravity_float = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "gravity_float");
		NativeFieldInfoPtr_particle_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particle_num");
		NativeFieldInfoPtr_numParticlesAlive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "numParticlesAlive");
		NativeFieldInfoPtr_base_particle_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "base_particle_angle");
		NativeFieldInfoPtr_particule_appearance_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particule_appearance_time");
		NativeFieldInfoPtr_converge_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "converge_radius");
		NativeFieldInfoPtr_base_particle_twist_angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "base_particle_twist_angle");
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "time");
		NativeFieldInfoPtr_cut_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "cut_num");
		NativeFieldInfoPtr_cut_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "cut_total");
		NativeFieldInfoPtr_particleInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, "particleInfos");
		NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, 100664119);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, 100664120);
		NativeMethodInfoPtr_particle_ini_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, 100664121);
		NativeMethodInfoPtr_particle_move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, 100664122);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr, 100664123);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39247, XrefRangeEnd = 39259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39259, XrefRangeEnd = 39270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 39282, RefRangeEnd = 39285, XrefRangeStart = 39270, XrefRangeEnd = 39282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void particle_ini()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_particle_ini_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 39329, RefRangeEnd = 39331, XrefRangeStart = 39285, XrefRangeEnd = 39329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void particle_move()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_particle_move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39331, XrefRangeEnd = 39339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FlowerTornado()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowerTornado>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FlowerTornado(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
