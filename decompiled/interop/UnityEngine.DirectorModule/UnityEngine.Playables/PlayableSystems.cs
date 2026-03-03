using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace UnityEngine.Playables;

public static class PlayableSystems : Il2CppSystem.Object
{
	public sealed class PlayableSystemDelegate : Il2CppSystem.MulticastDelegate
	{
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IReadOnlyList_1_DataPlayableOutput_0;

		static PlayableSystemDelegate()
		{
			Il2CppClassPointerStore<PlayableSystemDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayableSystems>.NativeClassPtr, "PlayableSystemDelegate");
			NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableSystemDelegate>.NativeClassPtr, 100663375);
			NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IReadOnlyList_1_DataPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableSystemDelegate>.NativeClassPtr, 100663376);
		}

		[CallerCount(588)]
		[CachedScanResults(RefRangeStart = 148277, RefRangeEnd = 148865, XrefRangeStart = 148277, XrefRangeEnd = 148865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayableSystemDelegate(Il2CppSystem.Object @object, System.IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableSystemDelegate>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)@object);
			*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &method;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		public unsafe virtual void Invoke(IReadOnlyList<DataPlayableOutput> outputs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)outputs);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IReadOnlyList_1_DataPlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public PlayableSystemDelegate(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public static implicit operator PlayableSystemDelegate(System.Action<IReadOnlyList<DataPlayableOutput>> P_0)
		{
			return DelegateSupport.ConvertDelegate<PlayableSystemDelegate>((System.Delegate)P_0);
		}

		public static PlayableSystemDelegate operator +(PlayableSystemDelegate P_0, PlayableSystemDelegate P_1)
		{
			return ((Il2CppObjectBase)Il2CppSystem.Delegate.Combine(P_0, P_1)).Cast<PlayableSystemDelegate>();
		}

		public static PlayableSystemDelegate operator -(PlayableSystemDelegate P_0, PlayableSystemDelegate P_1)
		{
			object obj = Il2CppSystem.Delegate.Remove(P_0, P_1);
			if (obj != null)
			{
				obj = ((Il2CppObjectBase)obj).Cast<PlayableSystemDelegate>();
			}
			return (PlayableSystemDelegate)obj;
		}
	}

	[OriginalName("UnityEngine.DirectorModule.dll", "", "PlayableSystemStage")]
	public enum PlayableSystemStage : ushort
	{
		FixedUpdate,
		FixedUpdatePostPhysics,
		Update,
		AnimationBegin,
		AnimationEnd,
		LateUpdate,
		Render
	}

	public class DataPlayableOutputList : Il2CppSystem.Object
	{
		public class DataPlayableOutputEnumerator : Il2CppSystem.Object
		{
			private static readonly System.IntPtr NativeFieldInfoPtr_m_List;

			private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataPlayableOutputList_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_DataPlayableOutput_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

			private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

			public unsafe DataPlayableOutputList m_List
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_List);
					System.IntPtr intPtr = *(System.IntPtr*)num;
					return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<DataPlayableOutputList>(intPtr) : null;
				}
				set
				{
					System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_List)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
				}
			}

			public unsafe int m_Index
			{
				get
				{
					nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index);
					return *(int*)num;
				}
				set
				{
					*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Index)) = value;
				}
			}

			public unsafe virtual DataPlayableOutput Current
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 1242583, RefRangeEnd = 1242584, XrefRangeStart = 1242582, XrefRangeEnd = 1242583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_DataPlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return *(DataPlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
				}
			}

			public unsafe virtual Il2CppSystem.Object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242584, XrefRangeEnd = 1242588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
					System.IntPtr* ptr = null;
					Unsafe.SkipInit(out System.IntPtr intPtr);
					System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			static DataPlayableOutputEnumerator()
			{
				Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr, "DataPlayableOutputEnumerator");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr);
				NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr, "m_List");
				NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr, "m_Index");
				NativeMethodInfoPtr__ctor_Public_Void_DataPlayableOutputList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr, 100663382);
				NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_DataPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr, 100663383);
				NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr, 100663384);
				NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr, 100663385);
				NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr, 100663386);
				NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr, 100663387);
			}

			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 721349, RefRangeEnd = 721351, XrefRangeStart = 721349, XrefRangeEnd = 721351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DataPlayableOutputEnumerator(DataPlayableOutputList list)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataPlayableOutputEnumerator>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)list);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_DataPlayableOutputList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			[CallerCount(0)]
			public unsafe virtual bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			[CallerCount(0)]
			public unsafe virtual void Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
			}

			public DataPlayableOutputEnumerator(System.IntPtr pointer)
				: base(pointer)
			{
			}
		}

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Outputs;

		private static readonly System.IntPtr NativeFieldInfoPtr_m_Count;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_PlayableOutputHandle_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_DataPlayableOutput_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_DataPlayableOutput_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		public unsafe PlayableOutputHandle* m_Outputs
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Outputs);
				return *(PlayableOutputHandle**)num;
			}
			set
			{
				*(PlayableOutputHandle**)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Outputs)) = value;
			}
		}

		public unsafe int m_Count
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Count);
				return *(int*)num;
			}
			set
			{
				*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Count)) = value;
			}
		}

		public unsafe virtual DataPlayableOutput this[int index]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242589, XrefRangeEnd = 1242590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = stackalloc System.IntPtr[1];
				*ptr = (nint)(&index);
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_DataPlayableOutput_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(DataPlayableOutput*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		public unsafe virtual int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				System.IntPtr* ptr = null;
				Unsafe.SkipInit(out System.IntPtr intPtr);
				System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		static DataPlayableOutputList()
		{
			Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayableSystems>.NativeClassPtr, "DataPlayableOutputList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr);
			NativeFieldInfoPtr_m_Outputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr, "m_Outputs");
			NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr, "m_Count");
			NativeMethodInfoPtr__ctor_Public_Void_ptr_PlayableOutputHandle_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr, 100663377);
			NativeMethodInfoPtr_get_Item_Public_Virtual_Final_New_get_DataPlayableOutput_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr, 100663378);
			NativeMethodInfoPtr_get_Count_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr, 100663379);
			NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_DataPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr, 100663380);
			NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr, 100663381);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242588, XrefRangeEnd = 1242589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataPlayableOutputList(PlayableOutputHandle* outputs, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataPlayableOutputList>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)outputs;
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &count;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_ptr_PlayableOutputHandle_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242590, XrefRangeEnd = 1242595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<DataPlayableOutput> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_DataPlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator<DataPlayableOutput>>(intPtr2) : null;
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		public DataPlayableOutputList(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private delegate int RegisterStreamStageDelegate(System.IntPtr streamType, int stage);

	private static readonly System.IntPtr NativeFieldInfoPtr_s_SystemTypes;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_Delegates;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_RWLock;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineTypeAndIndex_Private_Static_Int32_Int32_PlayableSystemStage_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_CallSystemDelegate_Private_Static_Boolean_Int32_PlayableSystemStage_IntPtr_Int32_0;

	private static readonly RegisterStreamStageDelegate RegisterStreamStageDelegateField;

	public unsafe static Dictionary<int, Il2CppSystem.Type> s_SystemTypes
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_SystemTypes, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, Il2CppSystem.Type>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_SystemTypes, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<int, PlayableSystemDelegate> s_Delegates
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_Delegates, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<int, PlayableSystemDelegate>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_Delegates, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static ReaderWriterLockSlim s_RWLock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_RWLock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ReaderWriterLockSlim>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_RWLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static PlayableSystems()
	{
		Il2CppClassPointerStore<PlayableSystems>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.DirectorModule.dll", "UnityEngine.Playables", "PlayableSystems");
		NativeFieldInfoPtr_s_SystemTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableSystems>.NativeClassPtr, "s_SystemTypes");
		NativeFieldInfoPtr_s_Delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableSystems>.NativeClassPtr, "s_Delegates");
		NativeFieldInfoPtr_s_RWLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableSystems>.NativeClassPtr, "s_RWLock");
		NativeMethodInfoPtr_CombineTypeAndIndex_Private_Static_Int32_Int32_PlayableSystemStage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableSystems>.NativeClassPtr, 100663372);
		NativeMethodInfoPtr_Internal_CallSystemDelegate_Private_Static_Boolean_Int32_PlayableSystemStage_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableSystems>.NativeClassPtr, 100663373);
		RegisterStreamStageDelegateField = IL2CPP.ResolveICall<RegisterStreamStageDelegate>("UnityEngine.Playables.PlayableSystems::RegisterStreamStage");
	}

	[CallerCount(0)]
	public unsafe static int CombineTypeAndIndex(int typeIndex, PlayableSystemStage stage)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&typeIndex);
		*(PlayableSystemStage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineTypeAndIndex_Private_Static_Int32_Int32_PlayableSystemStage_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1242595, XrefRangeEnd = 1242619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Internal_CallSystemDelegate(int systemIndex, PlayableSystemStage stage, System.IntPtr outputsPtr, int numOutputs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&systemIndex);
		*(PlayableSystemStage**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &stage;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &outputsPtr;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &numOutputs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_CallSystemDelegate_Private_Static_Boolean_Int32_PlayableSystemStage_IntPtr_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public PlayableSystems(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public static void RegisterSystemPhaseDelegate<TDataStream>(PlayableSystemStage stage, PlayableSystemDelegate systemDelegate) where TDataStream : new()
	{
		RegisterSystemPhaseDelegate(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TDataStream>()), stage, systemDelegate);
	}

	public static void RegisterSystemPhaseDelegate(Il2CppSystem.Type streamType, PlayableSystemStage stage, PlayableSystemDelegate systemDelegate)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static int RegisterStreamStage(Il2CppSystem.Type streamType, int stage)
	{
		return RegisterStreamStageDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)streamType), stage);
	}
}
