using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.ParticleSystemJobs;

[StructLayout(LayoutKind.Explicit)]
public struct NativeParticleData
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Array3
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		private static readonly System.IntPtr NativeFieldInfoPtr_z;

		[FieldOffset(0)]
		public System.IntPtr x;

		[FieldOffset(8)]
		public System.IntPtr y;

		[FieldOffset(16)]
		public System.IntPtr z;

		static Array3()
		{
			Il2CppClassPointerStore<Array3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "Array3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array3>.NativeClassPtr);
			NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array3>.NativeClassPtr, "x");
			NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array3>.NativeClassPtr, "y");
			NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array3>.NativeClassPtr, "z");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Array3>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Array4
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		private static readonly System.IntPtr NativeFieldInfoPtr_z;

		private static readonly System.IntPtr NativeFieldInfoPtr_w;

		[FieldOffset(0)]
		public System.IntPtr x;

		[FieldOffset(8)]
		public System.IntPtr y;

		[FieldOffset(16)]
		public System.IntPtr z;

		[FieldOffset(24)]
		public System.IntPtr w;

		static Array4()
		{
			Il2CppClassPointerStore<Array4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "Array4");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Array4>.NativeClassPtr);
			NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array4>.NativeClassPtr, "x");
			NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array4>.NativeClassPtr, "y");
			NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array4>.NativeClassPtr, "z");
			NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Array4>.NativeClassPtr, "w");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Array4>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_count;

	private static readonly System.IntPtr NativeFieldInfoPtr_positions;

	private static readonly System.IntPtr NativeFieldInfoPtr_velocities;

	private static readonly System.IntPtr NativeFieldInfoPtr_axisOfRotations;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotations;

	private static readonly System.IntPtr NativeFieldInfoPtr_rotationalSpeeds;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizes;

	private static readonly System.IntPtr NativeFieldInfoPtr_startColors;

	private static readonly System.IntPtr NativeFieldInfoPtr_aliveTimePercent;

	private static readonly System.IntPtr NativeFieldInfoPtr_inverseStartLifetimes;

	private static readonly System.IntPtr NativeFieldInfoPtr_randomSeeds;

	private static readonly System.IntPtr NativeFieldInfoPtr_customData1;

	private static readonly System.IntPtr NativeFieldInfoPtr_customData2;

	private static readonly System.IntPtr NativeFieldInfoPtr_meshIndices;

	[FieldOffset(0)]
	public int count;

	[FieldOffset(8)]
	public Array3 positions;

	[FieldOffset(32)]
	public Array3 velocities;

	[FieldOffset(56)]
	public Array3 axisOfRotations;

	[FieldOffset(80)]
	public Array3 rotations;

	[FieldOffset(104)]
	public Array3 rotationalSpeeds;

	[FieldOffset(128)]
	public Array3 sizes;

	[FieldOffset(152)]
	public System.IntPtr startColors;

	[FieldOffset(160)]
	public System.IntPtr aliveTimePercent;

	[FieldOffset(168)]
	public System.IntPtr inverseStartLifetimes;

	[FieldOffset(176)]
	public System.IntPtr randomSeeds;

	[FieldOffset(184)]
	public Array4 customData1;

	[FieldOffset(216)]
	public Array4 customData2;

	[FieldOffset(248)]
	public System.IntPtr meshIndices;

	static NativeParticleData()
	{
		Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.ParticleSystemModule.dll", "UnityEngine.ParticleSystemJobs", "NativeParticleData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr);
		NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "count");
		NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "positions");
		NativeFieldInfoPtr_velocities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "velocities");
		NativeFieldInfoPtr_axisOfRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "axisOfRotations");
		NativeFieldInfoPtr_rotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "rotations");
		NativeFieldInfoPtr_rotationalSpeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "rotationalSpeeds");
		NativeFieldInfoPtr_sizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "sizes");
		NativeFieldInfoPtr_startColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "startColors");
		NativeFieldInfoPtr_aliveTimePercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "aliveTimePercent");
		NativeFieldInfoPtr_inverseStartLifetimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "inverseStartLifetimes");
		NativeFieldInfoPtr_randomSeeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "randomSeeds");
		NativeFieldInfoPtr_customData1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "customData1");
		NativeFieldInfoPtr_customData2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "customData2");
		NativeFieldInfoPtr_meshIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, "meshIndices");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeParticleData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
