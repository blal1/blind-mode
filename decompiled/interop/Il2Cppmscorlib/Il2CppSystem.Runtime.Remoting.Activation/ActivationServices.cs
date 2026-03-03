using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;
using Il2CppSystem.Runtime.Remoting.Proxies;

namespace Il2CppSystem.Runtime.Remoting.Activation;

public class ActivationServices : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__constructionActivator;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0;

	public unsafe static IActivator _constructionActivator
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__constructionActivator, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__constructionActivator, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static IActivator ConstructionActivator
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 794660, RefRangeEnd = 794661, XrefRangeStart = 794650, XrefRangeEnd = 794660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IActivator>(intPtr2) : null;
		}
	}

	static ActivationServices()
	{
		Il2CppClassPointerStore<ActivationServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Activation", "ActivationServices");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr);
		NativeFieldInfoPtr__constructionActivator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, "_constructionActivator");
		NativeMethodInfoPtr_get_ConstructionActivator_Private_Static_get_IActivator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670192);
		NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670193);
		NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670194);
		NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670195);
		NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670196);
		NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670197);
		NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670198);
		NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActivationServices>.NativeClassPtr, 100670199);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 794686, RefRangeEnd = 794688, XrefRangeStart = 794661, XrefRangeEnd = 794686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)proxy);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctorCall);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Activate_Public_Static_IMessage_RemotingProxy_ConstructionCall_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 794698, RefRangeEnd = 794700, XrefRangeStart = 794688, XrefRangeEnd = 794698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMessage RemoteActivate(IConstructionCallMessage ctorCall)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctorCall);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoteActivate_Public_Static_IMessage_IConstructionCallMessage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794786, RefRangeEnd = 794787, XrefRangeStart = 794700, XrefRangeEnd = 794786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ConstructionCall CreateConstructionCall(Type type, string activationUrl, Il2CppReferenceArray<Object> activationAttributes)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(activationUrl);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)activationAttributes);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateConstructionCall_Public_Static_ConstructionCall_Type_String_Il2CppReferenceArray_1_Object_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ConstructionCall>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 794808, RefRangeEnd = 794809, XrefRangeStart = 794787, XrefRangeEnd = 794808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ctorCall);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateInstanceFromMessage_Public_Static_IMessage_IConstructionCallMessage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IMessage>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 794809, XrefRangeEnd = 794818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object CreateProxyForType(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CreateProxyForType_Public_Static_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 794819, RefRangeEnd = 794822, XrefRangeStart = 794818, XrefRangeEnd = 794819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Object AllocateUninitializedClassInstance(Type type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AllocateUninitializedClassInstance_Public_Static_Object_Type_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 794823, RefRangeEnd = 794825, XrefRangeStart = 794822, XrefRangeEnd = 794823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableProxyActivation(Type type, bool enable)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)type);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &enable;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_EnableProxyActivation_Public_Static_Void_Type_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ActivationServices(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
