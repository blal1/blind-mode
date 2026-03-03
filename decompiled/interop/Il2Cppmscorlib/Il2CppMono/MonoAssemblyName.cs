using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono;

[StructLayout(LayoutKind.Explicit)]
public struct MonoAssemblyName
{
	[StructLayout(LayoutKind.Explicit)]
	[ObfuscatedName("Mono.MonoAssemblyName+<public_key_token>e__FixedBuffer")]
	public struct _public_key_token_e__FixedBuffer
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;

		[FieldOffset(0)]
		public byte FixedElementField;

		static _public_key_token_e__FixedBuffer()
		{
			Il2CppClassPointerStore<_public_key_token_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "<public_key_token>e__FixedBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_public_key_token_e__FixedBuffer>.NativeClassPtr);
			NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_public_key_token_e__FixedBuffer>.NativeClassPtr, "FixedElementField");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_public_key_token_e__FixedBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_culture;

	private static readonly System.IntPtr NativeFieldInfoPtr_hash_value;

	private static readonly System.IntPtr NativeFieldInfoPtr_public_key;

	private static readonly System.IntPtr NativeFieldInfoPtr_public_key_token;

	private static readonly System.IntPtr NativeFieldInfoPtr_hash_alg;

	private static readonly System.IntPtr NativeFieldInfoPtr_hash_len;

	private static readonly System.IntPtr NativeFieldInfoPtr_flags;

	private static readonly System.IntPtr NativeFieldInfoPtr_major;

	private static readonly System.IntPtr NativeFieldInfoPtr_minor;

	private static readonly System.IntPtr NativeFieldInfoPtr_build;

	private static readonly System.IntPtr NativeFieldInfoPtr_revision;

	private static readonly System.IntPtr NativeFieldInfoPtr_arch;

	[FieldOffset(0)]
	public System.IntPtr name;

	[FieldOffset(8)]
	public System.IntPtr culture;

	[FieldOffset(16)]
	public System.IntPtr hash_value;

	[FieldOffset(24)]
	public System.IntPtr public_key;

	[FieldOffset(32)]
	public _public_key_token_e__FixedBuffer public_key_token;

	[FieldOffset(52)]
	public uint hash_alg;

	[FieldOffset(56)]
	public uint hash_len;

	[FieldOffset(60)]
	public uint flags;

	[FieldOffset(64)]
	public ushort major;

	[FieldOffset(66)]
	public ushort minor;

	[FieldOffset(68)]
	public ushort build;

	[FieldOffset(70)]
	public ushort revision;

	[FieldOffset(72)]
	public ushort arch;

	static MonoAssemblyName()
	{
		Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "MonoAssemblyName");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr);
		NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "name");
		NativeFieldInfoPtr_culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "culture");
		NativeFieldInfoPtr_hash_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "hash_value");
		NativeFieldInfoPtr_public_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "public_key");
		NativeFieldInfoPtr_public_key_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "public_key_token");
		NativeFieldInfoPtr_hash_alg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "hash_alg");
		NativeFieldInfoPtr_hash_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "hash_len");
		NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "flags");
		NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "major");
		NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "minor");
		NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "build");
		NativeFieldInfoPtr_revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "revision");
		NativeFieldInfoPtr_arch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, "arch");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoAssemblyName>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
