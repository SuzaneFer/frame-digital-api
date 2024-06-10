using FrameDigitalApi.Entity;
using FrameDigitalApi.Repository.Interface;

namespace FrameDigitalApi.Repository
{
    public class SampleRepository : ISampleRepository
    {
        public SampleEntity GetSample()
        {
            return new SampleEntity { Id = 1, Name = "Test" };
        }

    }
}
