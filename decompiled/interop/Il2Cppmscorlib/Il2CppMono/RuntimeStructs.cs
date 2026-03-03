using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono;

public static class RuntimeStructs : Il2CppSystem.Object
{
	[StructLayout(LayoutKind.Explicit)]
	public struct RemoteClass
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_default_vtable;

		private static readonly System.IntPtr NativeFieldInfoPtr_xdomain_vtable;

		private static readonly System.IntPtr NativeFieldInfoPtr_proxy_class;

		private static readonly System.IntPtr NativeFieldInfoPtr_proxy_class_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_interface_count;

		[FieldOffset(0)]
		public System.IntPtr default_vtable;

		[FieldOffset(8)]
		public System.IntPtr xdomain_vtable;

		[FieldOffset(16)]
		public System.IntPtr proxy_class;

		[FieldOffset(24)]
		public System.IntPtr proxy_class_name;

		[FieldOffset(32)]
		public uint interface_count;

		static RemoteClass()
		{
			Il2CppClassPointerStore<RemoteClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "RemoteClass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteClass>.NativeClassPtr);
			NativeFieldInfoPtr_default_vtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteClass>.NativeClassPtr, "default_vtable");
			NativeFieldInfoPtr_xdomain_vtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteClass>.NativeClassPtr, "xdomain_vtable");
			NativeFieldInfoPtr_proxy_class = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteClass>.NativeClassPtr, "proxy_class");
			NativeFieldInfoPtr_proxy_class_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteClass>.NativeClassPtr, "proxy_class_name");
			NativeFieldInfoPtr_interface_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteClass>.NativeClassPtr, "interface_count");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoteClass>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct MonoClass
	{
		static MonoClass()
		{
			Il2CppClassPointerStore<MonoClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "MonoClass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoClass>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MonoClass>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct GenericParamInfo
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_pklass;

		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeFieldInfoPtr_flags;

		private static readonly System.IntPtr NativeFieldInfoPtr_token;

		private static readonly System.IntPtr NativeFieldInfoPtr_constraints;

		[FieldOffset(0)]
		public System.IntPtr pklass;

		[FieldOffset(8)]
		public System.IntPtr name;

		[FieldOffset(16)]
		public ushort flags;

		[FieldOffset(20)]
		public uint token;

		[FieldOffset(24)]
		public System.IntPtr constraints;

		static GenericParamInfo()
		{
			Il2CppClassPointerStore<GenericParamInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "GenericParamInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericParamInfo>.NativeClassPtr);
			NativeFieldInfoPtr_pklass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericParamInfo>.NativeClassPtr, "pklass");
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericParamInfo>.NativeClassPtr, "name");
			NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericParamInfo>.NativeClassPtr, "flags");
			NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericParamInfo>.NativeClassPtr, "token");
			NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericParamInfo>.NativeClassPtr, "constraints");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GenericParamInfo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct GPtrArray
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_data;

		private static readonly System.IntPtr NativeFieldInfoPtr_len;

		[FieldOffset(0)]
		public System.IntPtr data;

		[FieldOffset(8)]
		public int len;

		static GPtrArray()
		{
			Il2CppClassPointerStore<GPtrArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr, "GPtrArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPtrArray>.NativeClassPtr);
			NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPtrArray>.NativeClassPtr, "data");
			NativeFieldInfoPtr_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPtrArray>.NativeClassPtr, "len");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GPtrArray>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	static RuntimeStructs()
	{
		Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono", "RuntimeStructs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeStructs>.NativeClassPtr);
	}

	public RuntimeStructs(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
