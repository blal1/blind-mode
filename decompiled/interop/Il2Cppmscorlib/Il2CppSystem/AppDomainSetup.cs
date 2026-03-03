using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem;

[System.Serializable]
public sealed class AppDomainSetup : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_application_base;

	private static readonly System.IntPtr NativeFieldInfoPtr_application_name;

	private static readonly System.IntPtr NativeFieldInfoPtr_cache_path;

	private static readonly System.IntPtr NativeFieldInfoPtr_configuration_file;

	private static readonly System.IntPtr NativeFieldInfoPtr_dynamic_base;

	private static readonly System.IntPtr NativeFieldInfoPtr_license_file;

	private static readonly System.IntPtr NativeFieldInfoPtr_private_bin_path;

	private static readonly System.IntPtr NativeFieldInfoPtr_private_bin_path_probe;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadow_copy_directories;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadow_copy_files;

	private static readonly System.IntPtr NativeFieldInfoPtr_publisher_policy;

	private static readonly System.IntPtr NativeFieldInfoPtr_path_changed;

	private static readonly System.IntPtr NativeFieldInfoPtr_loader_optimization;

	private static readonly System.IntPtr NativeFieldInfoPtr_disallow_binding_redirects;

	private static readonly System.IntPtr NativeFieldInfoPtr_disallow_code_downloads;

	private static readonly System.IntPtr NativeFieldInfoPtr__activationArguments;

	private static readonly System.IntPtr NativeFieldInfoPtr_domain_initializer;

	private static readonly System.IntPtr NativeFieldInfoPtr_application_trust;

	private static readonly System.IntPtr NativeFieldInfoPtr_domain_initializer_args;

	private static readonly System.IntPtr NativeFieldInfoPtr_disallow_appbase_probe;

	private static readonly System.IntPtr NativeFieldInfoPtr_configuration_bytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_serialized_non_primitives;

	private static readonly System.IntPtr NativeFieldInfoPtr_manager_assembly;

	private static readonly System.IntPtr NativeFieldInfoPtr_manager_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_partial_visible_assemblies;

	private static readonly System.IntPtr NativeFieldInfoPtr__TargetFrameworkName_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string application_base
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_application_base);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_application_base)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string application_name
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_application_name);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_application_name)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string cache_path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cache_path);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_cache_path)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string configuration_file
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configuration_file);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configuration_file)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string dynamic_base
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamic_base);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dynamic_base)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string license_file
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_license_file);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_license_file)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string private_bin_path
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_private_bin_path);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_private_bin_path)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string private_bin_path_probe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_private_bin_path_probe);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_private_bin_path_probe)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string shadow_copy_directories
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadow_copy_directories);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadow_copy_directories)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string shadow_copy_files
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadow_copy_files);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_shadow_copy_files)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool publisher_policy
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publisher_policy);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_publisher_policy)) = value;
		}
	}

	public unsafe bool path_changed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path_changed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_path_changed)) = value;
		}
	}

	public unsafe int loader_optimization
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loader_optimization);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_loader_optimization)) = value;
		}
	}

	public unsafe bool disallow_binding_redirects
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disallow_binding_redirects);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disallow_binding_redirects)) = value;
		}
	}

	public unsafe bool disallow_code_downloads
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disallow_code_downloads);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disallow_code_downloads)) = value;
		}
	}

	public unsafe Object _activationArguments
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activationArguments);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__activationArguments)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object domain_initializer
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_domain_initializer);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_domain_initializer)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Object application_trust
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_application_trust);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_application_trust)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStringArray domain_initializer_args
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_domain_initializer_args);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_domain_initializer_args)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool disallow_appbase_probe
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disallow_appbase_probe);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_disallow_appbase_probe)) = value;
		}
	}

	public unsafe Il2CppStructArray<byte> configuration_bytes
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configuration_bytes);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_configuration_bytes)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> serialized_non_primitives
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serialized_non_primitives);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_serialized_non_primitives)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string manager_assembly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manager_assembly);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manager_assembly)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string manager_type
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manager_type);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_manager_type)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppStringArray partial_visible_assemblies
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partial_visible_assemblies);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_partial_visible_assemblies)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string _TargetFrameworkName_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetFrameworkName_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__TargetFrameworkName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static AppDomainSetup()
	{
		Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "AppDomainSetup");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr);
		NativeFieldInfoPtr_application_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_base");
		NativeFieldInfoPtr_application_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_name");
		NativeFieldInfoPtr_cache_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "cache_path");
		NativeFieldInfoPtr_configuration_file = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "configuration_file");
		NativeFieldInfoPtr_dynamic_base = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "dynamic_base");
		NativeFieldInfoPtr_license_file = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "license_file");
		NativeFieldInfoPtr_private_bin_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "private_bin_path");
		NativeFieldInfoPtr_private_bin_path_probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "private_bin_path_probe");
		NativeFieldInfoPtr_shadow_copy_directories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "shadow_copy_directories");
		NativeFieldInfoPtr_shadow_copy_files = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "shadow_copy_files");
		NativeFieldInfoPtr_publisher_policy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "publisher_policy");
		NativeFieldInfoPtr_path_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "path_changed");
		NativeFieldInfoPtr_loader_optimization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "loader_optimization");
		NativeFieldInfoPtr_disallow_binding_redirects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_binding_redirects");
		NativeFieldInfoPtr_disallow_code_downloads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_code_downloads");
		NativeFieldInfoPtr__activationArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "_activationArguments");
		NativeFieldInfoPtr_domain_initializer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "domain_initializer");
		NativeFieldInfoPtr_application_trust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "application_trust");
		NativeFieldInfoPtr_domain_initializer_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "domain_initializer_args");
		NativeFieldInfoPtr_disallow_appbase_probe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "disallow_appbase_probe");
		NativeFieldInfoPtr_configuration_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "configuration_bytes");
		NativeFieldInfoPtr_serialized_non_primitives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "serialized_non_primitives");
		NativeFieldInfoPtr_manager_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "manager_assembly");
		NativeFieldInfoPtr_manager_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "manager_type");
		NativeFieldInfoPtr_partial_visible_assemblies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "partial_visible_assemblies");
		NativeFieldInfoPtr__TargetFrameworkName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, "<TargetFrameworkName>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr, 100667050);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AppDomainSetup()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppDomainSetup>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AppDomainSetup(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
