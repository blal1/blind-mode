using Il2CppDummyDll;
using Unity.Jobs.LowLevel.Unsafe;

namespace Unity.Jobs;

[Token(Token = "0x2000006")]
[JobProducerType(typeof(IJobParallelForBatchExtensions.JobParallelForBatchProducer<>))]
public interface IJobParallelForBatch
{
	[Token(Token = "0x6000008")]
	void Execute(int startIndex, int count);
}
