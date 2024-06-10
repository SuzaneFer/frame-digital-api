using FrameDigitalApi.Business.Interface;
using FrameDigitalApi.Dto;
using FrameDigitalApi.Repository.Interface;

namespace FrameDigitalApi.Business
{
    public class SampleBusiness : ISampleBusiness
    {
        private readonly ISampleRepository _repository;

        public SampleBusiness(ISampleRepository repository)
        {
            _repository = repository;
        }

        public SampleDto GetSample()
        {
            var entity = _repository.GetSample();
            return new SampleDto { Id = entity.Id, Name = entity.Name };
        }
    }
}
