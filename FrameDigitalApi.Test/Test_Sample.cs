using FrameDigitalApi.Business.Interface;
using FrameDigitalApi.Controllers;
using FrameDigitalApi.Dto;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NPOI.SS.Formula.Functions;
using Xunit;

namespace FrameDigitalApi.Tests;

public class Test_Sample
{
    private readonly Mock<ISampleBusiness> _sampleBusinessMock;
    private readonly SampleController _controller;

    public Test_Sample()
    {
        _sampleBusinessMock = new Mock<ISampleBusiness>();
        _controller = new SampleController(_sampleBusinessMock.Object);
    }

    [Fact]
    public void Get_ReturnsSampleDto()
    {
        var expectedDto = new SampleDto { Id = 1, Name = "Test" };
        _sampleBusinessMock.Setup(b => b.GetSample()).Returns(expectedDto);

        var result = _controller.Get();

        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnValue = Assert.IsType<SampleDto>(okResult.Value);
        Assert.Equal(expectedDto.Id, returnValue.Id);
        Assert.Equal(expectedDto.Name, returnValue.Name);
    }
}