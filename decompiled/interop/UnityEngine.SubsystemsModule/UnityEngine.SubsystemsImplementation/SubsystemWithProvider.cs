using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.SubsystemsImplementation;

public class SubsystemWithProvider : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	public bool running
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	public SubsystemProvider providerBase
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
		set
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static SubsystemWithProvider()
	{
		Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine.SubsystemsImplementation", "SubsystemWithProvider");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr, 100663334);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SubsystemWithProvider()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubsystemWithProvider>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SubsystemWithProvider(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void Start()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Stop()
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public void Destroy()
	{
		Stop();
		if (SubsystemManager.RemoveStandaloneSubsystem(this))
		{
			this.OnDestroy();
		}
	}
}
