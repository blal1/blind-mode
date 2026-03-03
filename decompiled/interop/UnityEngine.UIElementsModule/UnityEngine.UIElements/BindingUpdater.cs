using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000022")]
internal class BindingUpdater
{
	[Token(Token = "0x2000023")]
	private sealed class CastDataSourceVisitor : ConcreteTypeVisitor
	{
		[Token(Token = "0x17000023")]
		public DataBinding Binding
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public BindingContext bindingContext
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x29792E0", Offset = "0x29784E0", VA = "0x1829792E0")]
			[CompilerGenerated]
			get
			{
				return default(BindingContext);
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2979370", Offset = "0x2978570", VA = "0x182979370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public BindingResult result
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x26DD640", Offset = "0x26DC840", VA = "0x1826DD640")]
			[CompilerGenerated]
			get
			{
				return default(BindingResult);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2979400", Offset = "0x2978600", VA = "0x182979400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2979200", Offset = "0x2978400", VA = "0x182979200")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000A9")]
		protected override void VisitContainer<TContainer>(ref TContainer container)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
		public CastDataSourceVisitor()
		{
		}
	}

	[Token(Token = "0x2000024")]
	private sealed class UIPathVisitor : PathVisitor
	{
		[Token(Token = "0x17000026")]
		public DataBinding binding
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public BindingUpdateStage direction
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xAA4ED0", Offset = "0xAA40D0", VA = "0x180AA4ED0")]
			[CompilerGenerated]
			get
			{
				return default(BindingUpdateStage);
			}
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xAA4930", Offset = "0xAA3B30", VA = "0x180AA4930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public BindingContext bindingContext
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2999300", Offset = "0x2998500", VA = "0x182999300")]
			[CompilerGenerated]
			get
			{
				return default(BindingContext);
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x29993B0", Offset = "0x29985B0", VA = "0x1829993B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public BindingResult result
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x29993A0", Offset = "0x29985A0", VA = "0x1829993A0")]
			[CompilerGenerated]
			get
			{
				return default(BindingResult);
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2999440", Offset = "0x2998640", VA = "0x182999440")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x29991F0", Offset = "0x29983F0", VA = "0x1829991F0", Slot = "6")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60000B4")]
		protected override void VisitPath<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container, ref TValue value)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
		public UIPathVisitor()
		{
		}
	}

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x0")]
	private static readonly CastDataSourceVisitor s_VisitDataSourceAsRootVisitor;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x8")]
	private static readonly UIPathVisitor s_VisitDataSourceAtPathVisitor;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2976E80", Offset = "0x2976080", VA = "0x182976E80")]
	public bool ShouldProcessBindingAtStage(Binding bindingObject, BindingUpdateStage stage, bool versionChanged, bool dirty)
	{
		return default(bool);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x29771B0", Offset = "0x29763B0", VA = "0x1829771B0")]
	private static bool ShouldProcessBindingAtStage(DataBinding dataBinding, BindingUpdateStage stage, bool versionChanged, bool dirty)
	{
		return default(bool);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x29772C0", Offset = "0x29764C0", VA = "0x1829772C0")]
	private bool ShouldProcessBindingAtStage(CustomBinding customBinding, BindingUpdateStage stage, bool versionChanged, bool dirty)
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2978A40", Offset = "0x2977C40", VA = "0x182978A40")]
	public BindingResult UpdateUI(in BindingContext context, Binding bindingObject)
	{
		return default(BindingResult);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x29783B0", Offset = "0x29775B0", VA = "0x1829783B0")]
	public BindingResult UpdateSource(in BindingContext context, Binding bindingObject)
	{
		return default(BindingResult);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x29785B0", Offset = "0x29777B0", VA = "0x1829785B0")]
	private BindingResult UpdateUI(in BindingContext context, DataBinding dataBinding)
	{
		return default(BindingResult);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2978560", Offset = "0x2977760", VA = "0x182978560")]
	private BindingResult UpdateUI(in BindingContext context, CustomBinding customBinding)
	{
		return default(BindingResult);
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2977E50", Offset = "0x2977050", VA = "0x182977E50")]
	private BindingResult UpdateDataSource(in BindingContext context, DataBinding dataBinding)
	{
		return default(BindingResult);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2977E10", Offset = "0x2977010", VA = "0x182977E10")]
	private BindingResult UpdateDataSource(in BindingContext context, CustomBinding customBinding)
	{
		return default(BindingResult);
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x29773A0", Offset = "0x29765A0", VA = "0x1829773A0")]
	private static BindingResult TryUpdateUIWithNonContainer(in BindingContext context, DataBinding binding, object value)
	{
		return default(BindingResult);
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2978BF0", Offset = "0x2977DF0", VA = "0x182978BF0")]
	private static (bool, VisitReturnCode, BindingResult) VisitRoot(DataBinding dataBinding, ref object container, in BindingContext context)
	{
		return default((bool, VisitReturnCode, BindingResult));
	}

	[Token(Token = "0x600009C")]
	private static (bool, VisitReturnCode, VisitReturnCode, BindingResult) VisitAtPath<TContainer>(DataBinding dataBinding, BindingUpdateStage direction, ref TContainer container, in PropertyPath path, in BindingContext context)
	{
		return default((bool, VisitReturnCode, VisitReturnCode, BindingResult));
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2976C30", Offset = "0x2975E30", VA = "0x182976C30")]
	internal static string GetVisitationErrorString(VisitReturnCode returnCode, in BindingContext context)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2976970", Offset = "0x2975B70", VA = "0x182976970")]
	internal static string GetExtractValueErrorString(VisitReturnCode returnCode, object target, in PropertyPath path)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2976BB0", Offset = "0x2975DB0", VA = "0x182976BB0")]
	internal static string GetRootDataSourceError(object target)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public BindingUpdater()
	{
	}
}
