using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSpine;

public class IHasTextureRegion : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_get_Region_Public_Abstract_Virtual_New_get_TextureRegion_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Region_Public_Abstract_Virtual_New_set_Void_TextureRegion_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateRegion_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Sequence_Public_Abstract_Virtual_New_get_Sequence_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_Sequence_Public_Abstract_Virtual_New_set_Void_Sequence_0;

	public unsafe virtual TextureRegion Region
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Region_Public_Abstract_Virtual_New_get_TextureRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<TextureRegion>(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_Region_Public_Abstract_Virtual_New_set_Void_TextureRegion_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe virtual Sequence Sequence
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_get_Sequence_Public_Abstract_Virtual_New_get_Sequence_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Sequence>(intPtr2) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_set_Sequence_Public_Abstract_Virtual_New_set_Void_Sequence_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static IHasTextureRegion()
	{
		Il2CppClassPointerStore<IHasTextureRegion>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "IHasTextureRegion");
		NativeMethodInfoPtr_get_Region_Public_Abstract_Virtual_New_get_TextureRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTextureRegion>.NativeClassPtr, 100663665);
		NativeMethodInfoPtr_set_Region_Public_Abstract_Virtual_New_set_Void_TextureRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTextureRegion>.NativeClassPtr, 100663666);
		NativeMethodInfoPtr_UpdateRegion_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTextureRegion>.NativeClassPtr, 100663667);
		NativeMethodInfoPtr_get_Sequence_Public_Abstract_Virtual_New_get_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTextureRegion>.NativeClassPtr, 100663668);
		NativeMethodInfoPtr_set_Sequence_Public_Abstract_Virtual_New_set_Void_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IHasTextureRegion>.NativeClassPtr, 100663669);
	}

	[CallerCount(0)]
	public unsafe virtual void UpdateRegion()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdateRegion_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IHasTextureRegion(IntPtr pointer)
		: base(pointer)
	{
	}
}
